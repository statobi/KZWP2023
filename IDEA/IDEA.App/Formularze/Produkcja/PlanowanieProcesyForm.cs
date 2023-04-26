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
        Pracownicy PracownikDoUsuwania = new Pracownicy();
        Proce ProcesDoUsuwania = new Proce();
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
            //var KolejneIDProcesu = db.Proces
            //    .Max(x => x.ID_Proces);
            //KolejneIDProcesu = KolejneIDProcesu + 1;
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

            db.Proces.Add(NowyProces);
            db.SaveChanges();
            


            string WybranyPracownik = cbPracownik.Text;
            var IDPracwonika = db.Pracownicies
            .Where(x => x.Nazwisko == WybranyPracownik)
            .Select(x => x.ID_Pracownicy)
            .FirstOrDefault();
            Proces_Pracownicy NowyProcesPracownicy = new Proces_Pracownicy();

            NowyProcesPracownicy.ID_Proces = NowyProces.ID_Proces;
            NowyProcesPracownicy.ID_Pracownicy = IDPracwonika;
            NowyProcesPracownicy.Czas_Pracy = CzasPracy;
            db.Proces_Pracownicy.Add(NowyProcesPracownicy);
            db.SaveChanges();




            dgvZaplanowaneProcesy.Update();
            dgvZaplanowaneProcesy.Refresh();
            initDGV();


            //NowyProces.Czas_Pracy_Maszyny = CzasPracy;
            //if (IDNazwyProcesu == 1 && IDMaszyny == 7 && CzasPracy == 8)
            //{

            //    MessageBox.Show("dziala");
            //}

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

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            Usuwanie();
        }

        private void Usuwanie()
        {

            var idpracownikusuwany = db.Pracownicies
                          .Where(d => d.Nazwisko == PracownikDoUsuwania.Nazwisko && d.Imie == PracownikDoUsuwania.Imie)
                          .Select(d => d.ID_Pracownicy)
                          .FirstOrDefault();

            var idprocesusuwany = db.Proces
                          .Where(p => p.Ilosc == ProcesDoUsuwania.Ilosc &&  p.Data_Planowanego_Zakonczenia == ProcesDoUsuwania.Data_Planowanego_Zakonczenia)
                          .Select(p => p.ID_Proces)
                          .FirstOrDefault();

          


            var idUsuwanyProcesPracownik = db.Proces_Pracownicy
                .Where(x => x.ID_Pracownicy ==idpracownikusuwany && x.ID_Proces == idprocesusuwany)
                .Select(x => x.Proces_Pracownicy1)
                .FirstOrDefault();

            

            var UsuwanyProcesPracownik = from g in db.Proces_Pracownicy
                                where g.Proces_Pracownicy1 == idUsuwanyProcesPracownik 
                                select g;
            foreach (Proces_Pracownicy g in UsuwanyProcesPracownik)
                db.Proces_Pracownicy.Remove(g);
            db.SaveChanges();


            var Procesusuwany = from r in db.Proces
                                where r.ID_Proces == idprocesusuwany
                                select r;
            foreach (Proce r in Procesusuwany)
                db.Proces.Remove(r);
            db.SaveChanges();
            
            initDGV();
        }

        private void dgvZaplanowaneProcesy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvZaplanowaneProcesy.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvZaplanowaneProcesy.Rows[index];
            PracownikDoUsuwania.Imie = selectedrow.Cells[0].Value.ToString();
            PracownikDoUsuwania.Nazwisko = selectedrow.Cells[1].Value.ToString();
            ProcesDoUsuwania.Ilosc = int.Parse(selectedrow.Cells[4].Value.ToString());
            ProcesDoUsuwania.Data_Planowanego_Zakonczenia = DateTime.Parse(selectedrow.Cells[6].Value.ToString());
            //ProcesDoUsuwania.Data_Planowanego_Zakonczenia = DateTime.Parse(selectedrow.Cells[7].Value.ToString());
        }
    }
}
