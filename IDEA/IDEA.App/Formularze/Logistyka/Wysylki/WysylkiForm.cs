using IDEA.Database;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Wysylki
{
    public partial class WysylkiForm : Form, INotifficationSubscriber 
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        CommonPublisher commonPublisher = CommonPublisher.GetInstance();
        int dataSN = 1, IDwysylki = 1;

        public WysylkiForm()
        {
            InitializeComponent();
            initDgvWysylka();
            initDgvSkladWysylki();
            commonPublisher.Subscribe(this);
            btnWszystkie.Enabled = false;
        }

        public void GetNotification()
        {
            initDgvWysylka();
            initDgvSkladWysylki();
            initDgvWysylka();
            btnWszystkie.Enabled = false;
            btnPlanowane.Enabled = true;
            btnZrealizowane.Enabled = true;
        }

        void initDgvWysylka()
        {
            dgvWysylka.DataSource = db.Wysylki_All.ToList();
            dgvWysylka.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvWysylka.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvWysylka.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvWysylka.Rows[0].Selected = true;
            btnDelete.Enabled = false;  
            btnEdit.Enabled = false;
        }

        private void initDgvSkladWysylki()
        {
            var query = (from s in db.SkladWysylka_Produkt
                         join m in db.Magazyns on s.ID_Magazyn equals m.ID_Magazyn
                         join p in db.Produkts on s.ID_Produkt equals p.ID_Produkt
                         join r in db.Rodzaj_Produktu on p.ID_Rodzaj_Produktu equals r.ID_Rodzaj_Produktu
                         join prac in db.Pracownicies on s.ID_Pracownik equals prac.ID_Pracownicy
                         join z in db.Zamowienia_Klienci on s.ID_ZamowieniaKlienci equals z.ID_Zamowienia_Klienci
                         where s.ID_Wysylka == IDwysylki
                         select new
                         {
                             ID_Wysyłki = IDwysylki,
                             ID_Zamowienia = s.ID_ZamowieniaKlienci,
                             Nr_zam = z.Numer,
                             Magazyn = m.Nazwa,
                             Produkt = p.Nazwa,
                             Rodzaj_produktu = r.Nazwa,
                             Ilość = s.Ilosc,
                             Pracownik = prac.Imie + " " + prac.Nazwisko,
                         }).ToList();
            dgvSkladWysylki.DataSource = query.ToList();
            dgvSkladWysylki.Columns["ID_Wysyłki"].Visible = false;
            dgvSkladWysylki.Columns["ID_Zamowienia"].Visible = false;
            dgvSkladWysylki.Columns["Nr_zam"].HeaderText = "Numer zamówienia";
            dgvSkladWysylki.Columns["Rodzaj_produktu"].HeaderText = "Rodzaj produktu";
            dgvSkladWysylki.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladWysylki.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladWysylki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void dgvWysylka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataSN = dgvWysylka.CurrentCell.RowIndex;
            IDwysylki = Int32.Parse(dgvWysylka.Rows[dataSN].Cells["ID_Wysyłki"].Value.ToString());
            initDgvSkladWysylki();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WysylkiDodajForm secondForm = new WysylkiDodajForm();
            secondForm.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            WysylkiEdytujForm secondForm = new WysylkiEdytujForm(IDwysylki);
            secondForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć zaznaczony rekord?\n", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var context = new IDEAEntities())
                {
                    while (context.SkladWysylka_Produkt.FirstOrDefault(p => p.ID_Wysylka == IDwysylki) != default)
                    {
                        var usunSWP = context.SkladWysylka_Produkt.First(p => p.ID_Wysylka == IDwysylki);

                        var queryLista = (from swp in db.SkladWysylka_Produkt
                                          join zk in db.Zamowienia_Klienci on swp.ID_ZamowieniaKlienci equals zk.ID_Zamowienia_Klienci
                                          join sz in db.Sklad_Zamowienia on zk.ID_Zamowienia_Klienci equals sz.ID_Zamowienia_Klienci
                                          where swp.ID_SkladWysylka_Produkt == usunSWP.ID_SkladWysylka_Produkt && sz.ID_Produkt == usunSWP.ID_Produkt
                                          select sz).ToList();
                        foreach (var item in queryLista)
                        {
                            using (var context1 = new IDEAEntities())
                            {
                                var dodajSZ = context1.Sklad_Zamowienia.First(p => p.ID_Sklad_Zamowienia == item.ID_Sklad_Zamowienia);

                                dodajSZ.IloscWyslanychProduktow = dodajSZ.IloscWyslanychProduktow - usunSWP.Ilosc;
                                context1.SaveChanges();
                                
                            }
                        }

                        context.SkladWysylka_Produkt.Attach(usunSWP);
                        context.SkladWysylka_Produkt.Remove(usunSWP);
                        context.SaveChanges();
                    }
                    var usunWys = context.Wysylkas.SingleOrDefault(p => p.ID_Wysylka == IDwysylki);
                    context.Wysylkas.Attach(usunWys);
                    context.Wysylkas.Remove(usunWys);
                    context.SaveChanges();
                }
                initDgvWysylka();
                initDgvSkladWysylki();

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }


        private void btnZrealizowane_Click(object sender, EventArgs e)
        {
            var query = (from w in db.Wysylki_All
                         where w.Data <= DateTime.Now
                         orderby w.Data
                         select w).ToList();
            dgvWysylka.DataSource = query;
            btnWszystkie.Enabled = true;
            btnPlanowane.Enabled = true;
            btnZrealizowane.Enabled = false;
        }

        private void btnPlanowane_Click(object sender, EventArgs e)
        {
            var query = (from w in db.Wysylki_All
                         where w.Data > DateTime.Now
                         orderby w.Data
                         select w).ToList();
            dgvWysylka.DataSource = query;
            btnWszystkie.Enabled = true;
            btnPlanowane.Enabled = false;
            btnZrealizowane.Enabled = true;
        }

        private void btnWszystkie_Click(object sender, EventArgs e)
        {
            initDgvWysylka();
            btnWszystkie.Enabled = false;
            btnPlanowane.Enabled = true;
            btnZrealizowane.Enabled = true;
        }

        private void WysylkiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commonPublisher.Unsubscribe(this);
        }
    }
}
