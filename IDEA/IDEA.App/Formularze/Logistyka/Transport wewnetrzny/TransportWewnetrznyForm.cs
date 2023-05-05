using IDEA.App.Formularze.Produkcja;
using IDEA.App.Models;
using IDEA.Database;
using IDEA.Logistyka.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class TransportWewnetrznyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelectedZlecenieMagazynowe = false;
        private bool flagSelectedSklad = false;
        Zlecenie_Magazynowe selectedMaterial = new Zlecenie_Magazynowe();

        private IEnumerable<Zlecenie_Magazynowe> _query;
        private int _selectedIndex = 0;

        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();

        int dataSN = 1, IDTransport, IDSklad;
        public TransportWewnetrznyForm()
        {
            InitializeComponent();
            initgrid_TW();
        }
        private void initgrid_TW()
        {
            //dgv_sklad_zamowienia_material.DataSource = db.Transport_wewnetrzny_Material.ToList();
            //dgv_sklad_zamowienia_produkt.DataSource = db.Transport_wewnetrzny_Produkt.ToList();
            var query = from s in db.Zlecenie_Magazynowe 
                        orderby s.Data descending
                        select s;
            dgv_zlecenie_magazynowe.DataSource = query.ToList(); 
            dgv_dostepne_pojazd.DataSource = db.Logistyka_Transport_wewnetrzny.ToList();
            _query = db.Zlecenie_Magazynowe.ToList();
            dgv_zlecenie_magazynowe.DataSource = _query;
            dgv_zlecenie_magazynowe.Columns["ID_Sklad_zamowienia"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["ID_Pracownicy"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["CzyZlecenieStale"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["Pracownicy"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["Sklad_Zlecenie_Magazynowe"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["Sklad_Zlecenie_Produkt"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["ZleceniaStales"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["TransportWewnetrznies"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["Sklad_Zamowienia"].Visible = false;
            dgv_dostepne_pojazd.Rows[0].Selected = true;
            btn_usun_TW.Enabled = false;
        }


        private void dgv_sklad_zamowienia_material_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_sklad_zamowienia_produkt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransportWewnetrznyForm_Load(object sender, EventArgs e)
        {
            dgv_sklad_zamowienia_material.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv_sklad_zamowienia_produkt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv_dostepne_pojazd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv_zlecenie_magazynowe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgv_zlecenie_magazynowe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_zlecenie_magazynowe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelectedZlecenieMagazynowe = true;
            int index;
            index = dgv_zlecenie_magazynowe.CurrentRow.Index;
            _selectedIndex = index;
            DataGridViewRow selectedrow = dgv_zlecenie_magazynowe.Rows[index];

            selectedMaterial.ID_Zlecenie_Magazynowe = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Zlecenie_Magazynowe
                        where p.ID_Zlecenie_Magazynowe == selectedMaterial.ID_Zlecenie_Magazynowe
                        select p;
            foreach (Zlecenie_Magazynowe p in query)
            {
                selectedMaterial.ID_Zlecenie_Magazynowe = p.ID_Zlecenie_Magazynowe;
                selectedMaterial.Uwagi = p.Uwagi;
                selectedMaterial.Data = p.Data;

            }
            InitSkladMaterial();
            InitSkladProdukt();
        }
        private void InitSkladMaterial()
        {
            var query3 = from s in db.Transport_wewnetrzny_Material
                         join sz in db.Zlecenie_Magazynowe on s.ID_Zlecenie_Magazynowe equals sz.ID_Zlecenie_Magazynowe
                         where s.ID_Zlecenie_Magazynowe == selectedMaterial.ID_Zlecenie_Magazynowe
                         select new
                         {
                             s.ID_Zlecenie_Magazynowe,
                             s.Material,
                             s.Ilosc_sztuk,
                             s.Objetosc_zamowienia,
                             s.Masa_zamowienia
                         };
                             
                             
            dgv_sklad_zamowienia_material.DataSource = query3.ToList();
        }
        private void InitSkladProdukt()
        {
            var query4 = from b in db.Transport_wewnetrzny_Produkt
                         join sz in db.Zlecenie_Magazynowe on b.ID_Zlecenie_Magazynowe equals sz.ID_Zlecenie_Magazynowe
                         where b.ID_Zlecenie_Magazynowe == selectedMaterial.ID_Zlecenie_Magazynowe
                         select new
                         {
                             b.ID_Zlecenie_Magazynowe,
                             b.Produkt,
                             b.Ilosc_sztuk,
                             b.Objetosc_zamowienia,
                             b.Masa_zamowienia
                            
                         };
            dgv_sklad_zamowienia_produkt.DataSource = query4.ToList();
        }

        private void btn_Dodaj_Transport_wewnetrzny_Click(object sender, EventArgs e)
        {
            using (DodajTransportWewnetrznyForm Pr = new DodajTransportWewnetrznyForm())
            {
                _commonPublisher.Send<DodajTransportWewnetrznyForm>(new DodajTransportWewnetrznyInput
                {
                    IdZlecenieMagazynowe = _query.ElementAt(_selectedIndex).ID_Zlecenie_Magazynowe
                });
                Pr.ShowDialog();
                InitDodajTransport();
            }
        }
        private void InitDodajTransport()
        {
            this.Size = new Size(600, 600);
        }

        private void btn_usun_TW_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć zaznaczony rekord?\n", "", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    using (var context = new IDEAEntities())
            //    {
            //        var usunTransport = context.Sklad_TransportWewnetrzny_Material.Where(p => p.ID_TransportWewnetrzny == IDTransport);
            //        context.Sklad_TransportWewnetrzny_Material.RemoveRange(usunTransport);
            //        context.SaveChanges();
            //    }

            //    using (var context = new IDEAEntities())
            //    {
            //        var usunSWP = context.TransportWewnetrznies.First(p => p.ID_TransportWewnetrzny == IDTransport);
            //        context.TransportWewnetrznies.Attach(usunSWP);
            //        context.TransportWewnetrznies.Remove(usunSWP);
            //        context.SaveChanges();
            //    }

            //    initgrid_TW();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
            //DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć zamówienie nr: " + " ?", "Usuwanie", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    var query = from p in db.TransportWewnetrznies
            //                join sz in db.Sklad_TransportWewnetrzny_Material on p.ID_TransportWewnetrzny equals sz.ID_TransportWewnetrzny
            //                where p.ID_TransportWewnetrzny == selectedMaterial.ID_Zlecenie_Magazynowe
            //                select p;
            //    foreach (TransportWewnetrzny p in query)
            //    {
            //        db.TransportWewnetrznies.Remove(p);
            //    }

            //    db.SaveChanges();
            //    initgrid_TW();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć zaznaczony rekord?\n", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var context = new IDEAEntities())
                {
                    var usunSWP = context.TransportWewnetrznies.SingleOrDefault(p => p.ID_TransportWewnetrzny == IDTransport);

                    context.TransportWewnetrznies.Attach(usunSWP);
                    context.TransportWewnetrznies.Remove(usunSWP);

                    context.SaveChanges();
                    

                }


                initgrid_TW();


            }
            else if (dialogResult == DialogResult.No)
            {
                return;

            }


        }

        private void dgv_dostepne_pojazd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataSN = dgv_dostepne_pojazd.CurrentCell.RowIndex;
            IDTransport = Int32.Parse(dgv_dostepne_pojazd.Rows[dataSN].Cells["ID_TransportWewnetrzny"].Value.ToString());
            var query = from s in db.TransportWewnetrznies
                        join stw in db.Sklad_TransportWewnetrzny_Material on s.ID_TransportWewnetrzny equals stw.ID_TransportWewnetrzny
                        where s.ID_TransportWewnetrzny == IDTransport
                        select stw.ID_Sklad_TransportWewnetrzny_Material;

            IDSklad = query.SingleOrDefault();
            btn_usun_TW.Enabled = true;
        }
    }
    
}
