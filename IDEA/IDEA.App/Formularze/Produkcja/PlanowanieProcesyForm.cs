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

namespace IDEA.App.Formularze.Produkcja
{
    public partial class PlanowanieProcesyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        public PlanowanieProcesyForm()
        {

            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");

            //Produkcja nowe funkcje

            initDGVZamowienia();
            initDGV();
            initWyborPracownicy();





        }

        private void initDGV()
        {

            dgvZaplanowaneProcesy.DataSource = db.Praca_Pracownikow_Produkcji.ToList();



        }
        private void initDgvProcesy(string pr)
        {
            var wyborproduktu = from s in db.Proces_Technologiczny_Produktu
                                where s.Nazwa_produktu == pr
                                select s;
            dgvProcesy.DataSource = wyborproduktu.ToList();


            //dgvProcesy.DataSource = db.Proces_Technologiczny_Produktu.ToList();

            initNazwyProcesow(pr);



        }

        private void initNazwyProcesow(string pro)
        {
            var NazwaProcesu = db.Proces_Technologiczny_Produktu
            .Where(x => x.Nazwa_produktu == pro)
            .Select(x => x.Nazwa_Procesu).ToList();
            cbNazwaProcesu.DataSource = NazwaProcesu;
        }


        private void initDgvSkladZamowienia(int id)
        {

            var query3 = from s in db.V_Sklad_Zamowienia
                         where s.ID_Zamowienia == id
                         select s;
            dgvSkladZamowienia.DataSource = query3.ToList();


            dgvSkladZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //var produkt = db.V_Sklad_Zamowienia
            //    .Where(x => x.ID_Zamowienia == id)
            //    .Select(x => x.Nazwa_Produktu)
            //    .FirstOrDefault();

            //initDgvProcesy(produkt);

        }
        private void PlanowanieProcesyForm_Load(object sender, EventArgs e)
        {

        }

        public void initDGVZamowienia()
        {
            dgvZamowienia.DataSource = db.Zlecenia_w_realizacji.ToList();
            dgvZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }




        private void dgvProcesy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvSkladZamowienia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSkladZamowienia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvZamowienia.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvZamowienia.Rows[index];

            int IDSK = int.Parse(selectedrow.Cells[0].Value.ToString());
            var produkt = db.V_Sklad_Zamowienia
                .Where(x => x.ID_Zamowienia == IDSK)
               .Select(x => x.Nazwa_Produktu)
               .FirstOrDefault();

            initDgvProcesy(produkt);
            // UZupełnianie ID skladu zamowienia
            string IDSkladu = selectedrow.Cells[0].Value.ToString();
            tbIDSklad.Text = IDSkladu;
        }

        private void dgvZamowienia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvZamowienia.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvZamowienia.Rows[index];

            int IDzamowienia = int.Parse(selectedrow.Cells[0].Value.ToString());
            initDgvSkladZamowienia(IDzamowienia);
        }


        private void PlanowanieProcesu()
        {
            Proce NowyProces = new Proce();
            //dodawanie ID skladu zamowienia
            NowyProces.ID_Sklad_Zamowienia = int.Parse(tbIDSklad.Text);
            // dodawanie ID Maszyny
            string WybranaMaszyna = cbMaszyna.Text;
            var IDMaszyny = db.Maszynies
            .Where(x => x.Symbol == WybranaMaszyna)
            .Select(x => x.ID_Maszyny)
            .FirstOrDefault();

            NowyProces.ID_Maszyny = IDMaszyny;



            //Odczytywanie Numeru ID dla danej nazwy procesu
            string Nazwaprocesu = cbNazwaProcesu.Text;
            var IDNazwyProcesu = db.Nazwa_Procesu
              .Where(x => x.Nazwa == Nazwaprocesu)
             .Select(x => x.ID_Nazwa_Procesu)
             .FirstOrDefault();

            NowyProces.ID_Nazwa_Procesu = IDNazwyProcesu;
            NowyProces.Data_Planowanego_Rozpoczecia = dtpDataRozpoczecia.Value;
            NowyProces.Data_Planowanego_Zakonczenia = dtpDataZakonczenia.Value;

            NowyProces.Ilosc = int.Parse(tbIloscProduktow.Text);

            var czaspracymaszyny = db.Proces_Technologiczny
                .Where(x => x.ID_Nazwa_Procesu == IDNazwyProcesu)
                .Select(x => x.Ilosc_Godzin)
                .FirstOrDefault();

            int CzasPracy = ObliczanieCzasuPracyMaszyny(czaspracymaszyny);

            NowyProces.Czas_Pracy_Maszyny = CzasPracy;
            if (IDNazwyProcesu == 1 && IDMaszyny == 7 && CzasPracy == 8)
            {

                MessageBox.Show("dziala");
            }

        }
        private int ObliczanieCzasuPracyMaszyny(int CzasPracy)
        {
            int Czas = CzasPracy * int.Parse(tbIloscProduktow.Text);

            return Czas;
        }

        private void iBtnNew_Click(object sender, EventArgs e)
        {

            PlanowanieProcesu();


        }

        private void cbMaszyna_Click(object sender, EventArgs e)
        {

        }


        private void WybieranieMaszyny()
        {
            string Nazwaprocesu = cbNazwaProcesu.Text;
            var RodzajMaszyny = db.Proces_Technologiczny_Produktu
              .Where(x => x.Nazwa_Procesu == Nazwaprocesu)
             .Select(x => x.Potrzebny_rodzaj_maszyny)
             .FirstOrDefault();

            var MaszynyRodzaje = db.Dostepnosc_Maszyn
            .Where(x => x.Rodzaj_Maszyny == RodzajMaszyny)
            .Select(x => x.Symbol_Maszyny).ToList();
            cbMaszyna.DataSource = MaszynyRodzaje;

        }

        private void cbNazwaProcesu_Click(object sender, EventArgs e)
        {
            WybieranieMaszyny();
        }
        private void initWyborPracownicy()
        {
            var WyborPracownika = db.Dostepnosc_Operatorow_Maszyn
                    .Select(s => s.Nazwisko).ToList();
            cbPracownik.DataSource = WyborPracownika;
            //cbPracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPracownik.SelectedIndex = -1;

        }
    }
}
