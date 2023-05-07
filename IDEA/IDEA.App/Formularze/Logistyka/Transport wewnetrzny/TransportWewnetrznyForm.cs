using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Database;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class TransportWewnetrznyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelectedZlecenieMagazynowe = false;
        private bool flagSelectedSklad = false;
        Zlecenie_Magazynowe selectedMaterial = new Zlecenie_Magazynowe();

        private readonly TransportWewnetrznyService _transportWewnetrznyService = new TransportWewnetrznyService();

        private IEnumerable<ZlecenieMagazynoweDGV> _query;
        private IEnumerable<SkladZlecenieMagazynoweDGV> _skladZlecenieMagazynoweDGV;
        private int _selectedIndex = 0;

        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();
        private readonly OpenPanelPublisher _openPanelPublisher = OpenPanelPublisher.GetInstance();

        int dataSN = 1, IDTransport, IDSklad;
        public TransportWewnetrznyForm()
        {
            InitializeComponent();
            initgrid_TW();
            InitDGVSkladZlecenie(1);
        }

        private void InitDGVSkladZlecenie(int idZamowienieMagazynowe)
        {
            _skladZlecenieMagazynoweDGV = _transportWewnetrznyService.GetSkladTransportWewnetrzny(idZamowienieMagazynowe).ToList();
            DGVSkladZlecenia.DataSource = null;
            DGVSkladZlecenia.DataSource = _skladZlecenieMagazynoweDGV;
            DGVSkladZlecenia.Columns[0].Visible = false;
            DGVSkladZlecenia.Columns[1].Visible = false;
            DGVSkladZlecenia.Columns[2].Visible = false;
            DGVSkladZlecenia.Columns["Ilosc"].HeaderText = "Ilość";
            DGVSkladZlecenia.Columns["TypAsortymentu"].HeaderText = "Typ asortymentu";
        }

        private void initgrid_TW()
        {
            _query = _transportWewnetrznyService.GetZleceniaMagazynowe().ToList();

            dgv_zlecenie_magazynowe.DataSource = _query;
            dgv_transporty_wewnetrzne.DataSource = db.Logistyka_Transport_wewnetrzny.ToList();

            dgv_zlecenie_magazynowe.Columns[0].Visible = false;
            dgv_zlecenie_magazynowe.Columns[1].Visible = false;
            dgv_zlecenie_magazynowe.Columns["DataZlecenia"].HeaderText = "Data zlecenia";
            dgv_zlecenie_magazynowe.Columns["CzyOdbior"].HeaderText = "Czy odbior";
        }


        private void dgv_sklad_zamowienia_material_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_sklad_zamowienia_produkt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransportWewnetrznyForm_Load(object sender, EventArgs e)
        {
            dgv_transporty_wewnetrzne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
            InitDGVSkladZlecenie(index + 1);
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
        }

        private void btn_Dodaj_Transport_wewnetrzny_Click(object sender, EventArgs e)
        {
            var window = new SkladZamowieniaForm();
            _commonPublisher.Send<SkladZamowieniaForm>(new SkladZamowieniaInput
            {
                SkladZlecenieMagazynowe = _skladZlecenieMagazynoweDGV
            });
            window.Show();
            _openPanelPublisher.Open<TransportWewnetrznyKonfiguracjaZlecenia>(new TransportWewnetrznyKonfiguracjaZleceniaInput
            {

            }, "Transport wewnętrzny");

            //using (DodajTransportWewnetrznyForm Pr = new DodajTransportWewnetrznyForm())
            //{
            //    _commonPublisher.Send<DodajTransportWewnetrznyForm>(new DodajTransportWewnetrznyInput
            //    {
            //        IdZlecenieMagazynowe = _query.ElementAt(_selectedIndex).Id
            //    });
            //    Pr.ShowDialog();
            //    InitDodajTransport();
            //}
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
            dataSN = dgv_transporty_wewnetrzne.CurrentCell.RowIndex;
            IDTransport = Int32.Parse(dgv_transporty_wewnetrzne.Rows[dataSN].Cells["ID_TransportWewnetrzny"].Value.ToString());
            var query = from s in db.TransportWewnetrznies
                        join stw in db.Sklad_TransportWewnetrzny_Material on s.ID_TransportWewnetrzny equals stw.ID_TransportWewnetrzny
                        where s.ID_TransportWewnetrzny == IDTransport
                        select stw.ID_Sklad_TransportWewnetrzny_Material;

            IDSklad = query.SingleOrDefault();
            btn_usun_transport_wewnetrzny.Enabled = true;
        }
    }
    
}
