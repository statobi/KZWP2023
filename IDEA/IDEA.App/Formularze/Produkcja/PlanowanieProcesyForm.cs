using IDEA.Database;
using System;
using System.Data;
using System.Linq;
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

        Pracownicy PracownikDoEdycji = new Pracownicy();
        Proce ProcesDoEdycji = new Proce();
        Kontrola_Jakosci_Zamowienia NowaKontrolaJakosci = new Kontrola_Jakosci_Zamowienia();

        //Flagi

        private bool flagaEdycji = false;
        private bool flagaRzeczywistaDataRozpoczecia = false;
        private bool flagaRzeczywistaDataZakonczenia = false;



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
            this.dgvZaplanowaneProcesy.Columns["ID_Proces"].Visible = false;
            dgvZaplanowaneProcesy.Columns["ID_Pracownicy"].Visible = false;
            dgvZaplanowaneProcesy.Columns["ID_Sklad_Zamowienia"].Visible = false;


        }
        private void initDgvProcesy(int pr)
        {
            var pobranienazwyproduktu = db.Produkts
                .Where(x => x.ID_Produkt == pr)
                .Select(x => x.Nazwa)
                .FirstOrDefault();

            var wyborproduktu = from s in db.Proces_Technologiczny_Produktu
                                where s.Nazwa_produktu == pobranienazwyproduktu
                                select s;
            dgvProcesy.DataSource = wyborproduktu.ToList();


            //dgvProcesy.DataSource = db.Proces_Technologiczny_Produktu.ToList();

            initNazwyProcesow(pobranienazwyproduktu);



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



            var pobieranieskladu = from s in db.V_Sklad_Zamowienia
                                   where s.ID_Zamowienia_Klienci == id
                                   select s;
            dgvSkladZamowienia.DataSource = pobieranieskladu.ToList();
            this.dgvSkladZamowienia.Columns["ID_Zamowienia_Klienci"].Visible = false;

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
            this.dgvZamowienia.Columns["ID_Zamowienia_Klienci"].Visible = false;
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

            //DataGridViewRow selectedrow = dgvSkladZamowienia.Rows[index];

            int IDSK = int.Parse(dgvSkladZamowienia.Rows[e.RowIndex].Cells[1].Value.ToString());
            var idprodukt = db.Sklad_Zamowienia
                .Where(x => x.ID_Sklad_Zamowienia == IDSK)
               .Select(x => x.ID_Produkt)
               .FirstOrDefault();

            initDgvProcesy(idprodukt);
            // UZupełnianie ID skladu zamowienia
            string IDSkladu = dgvSkladZamowienia.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbIDSklad.Text = IDSkladu;
            dgvSkladZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
            //initWyborPracownicy();

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

            var MaszynyRodzaje = db.Maszyny_Ewidencja
            .Where(x => x.Rodzaj_maszyny == RodzajMaszyny)
            .Select(x => x.Symbol_maszyny).ToList();
            cbMaszyna.DataSource = MaszynyRodzaje;

        }

        private void cbNazwaProcesu_Click(object sender, EventArgs e)
        {
            //WybieranieMaszyny();
        }
        private void initWyborPracownicy()
        {
            //cbPracownik.DataSource = null;
            //cbPracownik.Text= string.Empty;
            //cbPracownik.Items.Clear();
            var WyborPracownika = db.V_Operatorzy_Maszyn
                    .Select(s => s.Nazwisko).ToList();
            cbPracownik.DataSource = WyborPracownika;
            //cbPracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPracownik.SelectedIndex = -1;

        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            Usuwanie();
            // initWyborPracownicy();
        }

        private void Usuwanie()
        {

            var idpracownikusuwany = PracownikDoUsuwania.ID_Pracownicy;

            var idprocesusuwany = ProcesDoUsuwania.ID_Proces;


            var idUsuwanyProcesPracownik = db.Proces_Pracownicy
                .Where(x => x.ID_Pracownicy == idpracownikusuwany && x.ID_Proces == idprocesusuwany)
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
            // index = dgvZaplanowaneProcesy.CurrentRow.Index;

            // DataGridViewRow selectedrow = dgvZaplanowaneProcesy.Rows[index];
            ProcesDoUsuwania.ID_Proces = int.Parse(dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[0].Value.ToString());
            PracownikDoUsuwania.ID_Pracownicy = int.Parse(dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[1].Value.ToString());
            


            if (flagaEdycji == true)
            {
                ProcesDoEdycji.ID_Proces = int.Parse(dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[0].Value.ToString());
                PracownikDoEdycji.ID_Pracownicy = int.Parse(dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[1].Value.ToString());
                tbIDSklad.Text = dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbNazwaProcesu.Text = dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbMaszyna.Text = dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[8].Value.ToString();
                cbPracownik.Text = dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbIloscProduktow.Text = dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (flagaRzeczywistaDataRozpoczecia == true)
                {
                    dtpDataRozpoczecia.Text = dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[11].Value.ToString();
                }
                else
                {
                    dtpDataRozpoczecia.Text = dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[9].Value.ToString();
                }


                if (flagaRzeczywistaDataZakonczenia == true)
                {
                    dtpDataZakonczenia.Text = dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[12].Value.ToString();
                }
                else
                {
                    dtpDataZakonczenia.Text = dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[10].Value.ToString();
                }


            }

            //Przesylanie do kontroli jakosci

            NowaKontrolaJakosci.ID_Sklad_Zamowienia =int.Parse(dgvZaplanowaneProcesy.Rows[e.RowIndex].Cells[2].Value.ToString());
            

        }

        private void EdycjaPlanowania()
        {

            var edytowanyProces = db.Proces
               .Where(x => x.ID_Proces == ProcesDoEdycji.ID_Proces)
               .FirstOrDefault();


            var edytowanyProcesPracownik = db.Proces_Pracownicy
               .Where(x => x.ID_Pracownicy == PracownikDoEdycji.ID_Pracownicy && x.ID_Proces == ProcesDoEdycji.ID_Proces)
               .FirstOrDefault();

            var IDPracwonika = db.Pracownicies
            .Where(x => x.Nazwisko == cbPracownik.Text)
            .Select(x => x.ID_Pracownicy)
            .FirstOrDefault();

            edytowanyProcesPracownik.ID_Pracownicy = IDPracwonika;
            edytowanyProcesPracownik.ID_Proces = ProcesDoEdycji.ID_Proces;

          //Odczytywanie Numeru ID dla danej nazwy procesu
            string Nazwaprocesu = cbNazwaProcesu.Text;
            var IDNazwyProcesu = db.Nazwa_Procesu
              .Where(x => x.Nazwa == Nazwaprocesu)
             .Select(x => x.ID_Nazwa_Procesu)
             .FirstOrDefault();

            edytowanyProces.ID_Nazwa_Procesu = IDNazwyProcesu;

            var czaspracymaszyny = db.Proces_Technologiczny
               .Where(x => x.ID_Nazwa_Procesu == edytowanyProces.ID_Nazwa_Procesu)
               .Select(x => x.Ilosc_Godzin)
               .FirstOrDefault();


            int CzasPracy = ObliczanieCzasuPracyMaszyny(czaspracymaszyny);
            //MessageBox.Show(CzasPracy.ToString());
            edytowanyProcesPracownik.Czas_Pracy = CzasPracy;

            ////Proces


            edytowanyProces.ID_Sklad_Zamowienia = int.Parse(tbIDSklad.Text);
            // dodawanie ID Maszyny
            string WybranaMaszyna = cbMaszyna.Text;
            var IDMaszyny = db.Maszynies
            .Where(x => x.Symbol == WybranaMaszyna)
            .Select(x => x.ID_Maszyny)
            .FirstOrDefault();

            edytowanyProces.ID_Maszyny = IDMaszyny;



            


            

            if (flagaRzeczywistaDataRozpoczecia == true)
            {
                edytowanyProces.Data_Rzeczywistego_Rozpoczecia = dtpDataRozpoczecia.Value;
            }
             else
                    {
                        edytowanyProces.Data_Planowanego_Rozpoczecia = dtpDataRozpoczecia.Value;
                    }

            if (flagaRzeczywistaDataZakonczenia == true)
            {
                edytowanyProces.Data_Rzeczywistego_Zakonczenia = dtpDataZakonczenia.Value;
            }
            else
            {
                edytowanyProces.Data_Planowanego_Zakonczenia = dtpDataZakonczenia.Value;
            }

           


            edytowanyProces.Ilosc = int.Parse(tbIloscProduktow.Text);

          



            edytowanyProces.Czas_Pracy_Maszyny = CzasPracy;

            db.SaveChanges();
            dgvZaplanowaneProcesy.Update();
            dgvZaplanowaneProcesy.Refresh();
            initDGV();
        }




        private void cbNazwaProcesu_MouseCaptureChanged(object sender, EventArgs e)
        {
            //WybieranieMaszyny();
        }

        private void cbNazwaProcesu_MouseClick(object sender, MouseEventArgs e)
        {
            //WybieranieMaszyny();
        }

        private void cbNazwaProcesu_SelectedIndexChanged(object sender, EventArgs e)
        {
            WybieranieMaszyny();
        }

        private void chBEdutuj_CheckedChanged(object sender, EventArgs e)
        {
            if (chBEdutuj.Checked)
            {
                flagaEdycji = true;
            }
            else
            {
                flagaEdycji = false;

            }
        }

        private void cheBRealnaDataRozp_CheckedChanged(object sender, EventArgs e)
        {
            if (chBEdutuj.Checked)
            {
                flagaRzeczywistaDataRozpoczecia = true;
            }
            else
            {
                flagaRzeczywistaDataRozpoczecia = false;

            }
        }

        private void cheBRealnaDataZak_CheckedChanged(object sender, EventArgs e)
        {
            if (chBEdutuj.Checked)
            {
                flagaRzeczywistaDataZakonczenia = true;
            }
            else
            {
                flagaRzeczywistaDataZakonczenia = false;

            }
        }

        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if(flagaEdycji == true)
            {
                EdycjaPlanowania();
            }
            else
            {
                MessageBox.Show("Nie ma czego edytować");
            }
        }

        private void btnKontrolaJakosci_Click(object sender, EventArgs e)
        {
            DialogResult Zapytaniewyslania = MessageBox.Show("Czy chcesz dodać nowa kontrole jakości dla składu zamówienia nr." + NowaKontrolaJakosci.ID_Sklad_Zamowienia.ToString(),"Dodawanie" , MessageBoxButtons.YesNo);
            if (Zapytaniewyslania == DialogResult.Yes)
            {
                db.Kontrola_Jakosci_Zamowienia.Add(NowaKontrolaJakosci);
                db.SaveChanges();
                MessageBox.Show("Kontrola dodana");
            }
            else if (Zapytaniewyslania == DialogResult.No)
            {
               
            }




        }

        private void btnZwrot_Click(object sender, EventArgs e)
        {
            using (ZwrotzKontroliJakosciForm zw = new ZwrotzKontroliJakosciForm())
            {
                zw.ShowDialog();
               
            }
        }


        private void ObliczanieDaty()
        {
            string Nazwaprocesu = cbNazwaProcesu.Text;
            var IDNazwyProcesu = db.Nazwa_Procesu
              .Where(x => x.Nazwa == Nazwaprocesu)
             .Select(x => x.ID_Nazwa_Procesu)
             .FirstOrDefault();

           

            var czaspracymaszyny = db.Proces_Technologiczny
                .Where(x => x.ID_Nazwa_Procesu == IDNazwyProcesu)
                .Select(x => x.Ilosc_Godzin)
                .FirstOrDefault();

            double CzasPracy = ObliczanieCzasuPracyMaszyny(czaspracymaszyny);
            double dmi = Math.Ceiling(CzasPracy/8);
            //MessageBox.Show(dmi.ToString());
            dtpDataZakonczenia.Value = dtpDataRozpoczecia.Value.AddDays(dmi);
            

        }
        private void dtpDataRozpoczecia_ValueChanged(object sender, EventArgs e)
        {
            ObliczanieDaty();
        }
    }
}
