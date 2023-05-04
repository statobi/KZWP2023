using IDEA.App.Models;
using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class ZleceniaMagazynoweForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Klient selectedKlient = new Klient();
        int idKliknietyPrroces;
        int iloscwprocesie;
        public ZleceniaMagazynoweForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initDgwObecneProcesy();
            InitdgvMagazynProdukcja();
        }

        private void initDgwObecneProcesy()
        {
            var ObecneProcesy = db.Proces
                .Where(x => x.Data_Rzeczywistego_Rozpoczecia == null && x.Data_Rzeczywistego_Zakonczenia == null)
                .Select(x => new ObecneProcesy
                {
                    ID_Proces= x.ID_Proces,
                    Ilosc = x.Ilosc,
                    Nazwa_Procesu = x.Nazwa_Procesu.Nazwa,
                    Numer_Skladu_Zamowienia = x.ID_Sklad_Zamowienia,
                    Numer_Zamowienia = x.Sklad_Zamowienia.Zamowienia_Klienci.Numer


                })
                .ToList();
                
            dgvObecneProcesy.DataSource = ObecneProcesy;

            dgvObecneProcesy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //222
        }

        private void InitdgvMagazynProdukcja()
        {
            var materialynaMagazynie = db.Sekcjas
                .Where(x => x.ID_Magazyn == 1)
                .SelectMany(x => x.Polkas)
                .SelectMany(x => x.RozlozeniePolki_Materialy)
                .Select(x => new MaterialywMagazynie
                {
                    ID_Material = x.ID_Material,
                    Ilosc = x.Ilosc,
                    Nazwa_Materialu = x.Material.Nazwa,
                    Opis = x.Material.Opis
                })
                .GroupBy(x => x.ID_Material)
                .Select(g => new
                {
                    ID_Material = g.Key,
                    Ilosc = g.Sum(x => x.Ilosc),
                    Nazwa_Materialu = g.FirstOrDefault().Nazwa_Materialu,
                    Opis = g.FirstOrDefault().Opis
                })
                .ToList();

            dgvMagazynProdukcja.DataSource= materialynaMagazynie;

        }

        private void Zapotrzebowanie()
        {
            var potrzebneMaterialy = db.Proces
                .Where(x => x.ID_Proces == idKliknietyPrroces)
                .Select(x => x.Nazwa_Procesu)
                .SelectMany(x => x.Proces_Technologiczny)
                .SelectMany(x => x.Proces_Technologiczny_Material)
                .Select(x => new MaterialydoProcesu 
                { 
                ID_Material= x.ID_Material,
                Ilosc = x.Ilosc * iloscwprocesie ,
                Nazwa_Materialu = x.Material.Nazwa
                })
                .ToList();

            var materialynaMagazynie = db.Sekcjas
                .Where(x => x.ID_Magazyn == 1)
                .SelectMany(x => x.Polkas)
                .SelectMany(x => x.RozlozeniePolki_Materialy)
                .Select(x => new MaterialywMagazynie
                {
                    ID_Material = x.ID_Material,
                    Ilosc = x.Ilosc,
                    Nazwa_Materialu = x.Material.Nazwa,
                    Opis = x.Material.Opis
                })
                .GroupBy(x => x.ID_Material)
                .Select(g => new
                {
                    ID_Material = g.Key,
                    Ilosc = g.Sum(x => x.Ilosc),
                    Nazwa_Materialu = g.FirstOrDefault().Nazwa_Materialu,
                    Opis = g.FirstOrDefault().Opis
                })
                .ToList();

            var zapotrzebowanie = from p in potrzebneMaterialy
                                  join m in materialynaMagazynie on p.ID_Material equals m.ID_Material into joinResult
                                  from m in joinResult.DefaultIfEmpty()
                                  where m == null || p.Ilosc > m.Ilosc
                                  select new { p.ID_Material, NazwaMaterialu = p.Nazwa_Materialu, IloscWMagazynie = m == null ? 0 : m.Ilosc, IloscPotrzebna = p.Ilosc };

            dgvMaterialyBrakujace.DataSource = zapotrzebowanie.ToList();

        }

        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvObecneProcesy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idKliknietyPrroces = int.Parse(dgvObecneProcesy.Rows[e.RowIndex].Cells[0].Value.ToString());
            iloscwprocesie = int.Parse(dgvObecneProcesy.Rows[e.RowIndex].Cells[4].Value.ToString());
            Zapotrzebowanie();
        }


        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openKlientEdition(sender);
            
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
           

        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
           


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;

            
            dgvObecneProcesy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void dgvKlienci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
