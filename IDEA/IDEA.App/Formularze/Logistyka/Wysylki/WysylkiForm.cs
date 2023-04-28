using IDEA.Database;
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
    public partial class WysylkiForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();

        public WysylkiForm()
        {
            InitializeComponent();
            initDgvWysylka();

        }

        void initDgvWysylka()
        {
            dgvWysylka.DataSource = db.Wysylki_All.ToList();
            dgvWysylka.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }



        private void dgvSkladWysylki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvWysylka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dataSN = Int32.Parse(dgvWysylka.Rows[e.RowIndex].Cells[0].Value.ToString());

            var query = (from s in db.SkladWysylka_Produkt
                         join p in db.Produkts on s.ID_Produkt equals p.ID_Produkt
                         join r in db.Rodzaj_Produktu on p.ID_Rodzaj_Produktu equals r.ID_Rodzaj_Produktu
                         join prac in db.Pracownicies on s.ID_Pracownik equals prac.ID_Pracownicy
                         join poj in db.Pojazds on s.ID_Pojazd equals poj.ID_Pojazd
                         join m in db.ModelePojazdus on poj.ID_ModelPojazd equals m.ID_ModelPojazd
                         where s.ID_Wysylka == dataSN
                         select new
                         {
                             ID_Wysyłki = dataSN,
                             Produkt = p.Nazwa,
                             Rodzaj_produktu = r.Nazwa,
                             Ilość = s.Ilosc,
                             Pracownik = prac.Imie + " " + prac.Nazwisko,
                             Pojazd = m.Marka + " " + m.Model + " [" + poj.NrRejestracyjny + "]"

                         }).ToList();
            dgvSkladWysylki.DataSource = query.ToList();
            dgvSkladWysylki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            WysylkiDodajForm secondForm = new WysylkiDodajForm();
            secondForm.Show();
        }

        private void WysylkiForm_Load(object sender, EventArgs e)
        {
        }


    }
}
