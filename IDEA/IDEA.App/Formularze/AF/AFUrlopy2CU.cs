using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFUrlopy2CU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagEdit = false;
        Urlopy selectedUrlopy = new Urlopy();

        //Wersja Dodawanie
        public AFUrlopy2CU()
        {
            InitializeComponent();

            initDatePickers();
            initComboboxes();
        }
        //Wersja Edycja
        public AFUrlopy2CU(Urlopy _selectedUrlopy)
        {
            flagEdit = true;
            InitializeComponent();
            selectedUrlopy = _selectedUrlopy;
            lblKindWindow.Text = "Edytowanie Istniejącego Urlopu";

            initDatePickers();
            initComboboxes();

            cbRodzajUrlopu.SelectedIndex = selectedUrlopy.ID_Rodzaj_Urlopu - 1;
            cbPracownik.SelectedIndex = selectedUrlopy.ID_Pracownicy - 1;
            dateDataPocz.Value = selectedUrlopy.Data_od;
            dateDataKonc.Value = selectedUrlopy.Data_do;
            numDniRobocze.Value = selectedUrlopy.Dni_Robocze;
            cbPracownik.Enabled = false;
        }
        private void initDatePickers()
        {
            dateDataPocz.CustomFormat = "yyyy-MM-dd";
            dateDataPocz.Format = DateTimePickerFormat.Custom;
            dateDataPocz.Value = DateTime.Today;

            dateDataKonc.CustomFormat = "yyyy-MM-dd";
            dateDataKonc.Format = DateTimePickerFormat.Custom;
            dateDataKonc.Value = DateTime.Today;
        }
        private void initComboboxes()
        {
            var query1 = from p in db.Pracownicies
                         select new { p.ID_Pracownicy, ImieNazwisko = p.Imie + " " + p.Nazwisko };
            cbPracownik.DataSource = query1.ToList();
            cbPracownik.DisplayMember = "ImieNazwisko";
            cbPracownik.ValueMember = "ID_Pracownicy";
            //cbPracownik.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbPracownik.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbPracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPracownik.SelectedIndex = -1;

            var query2 = from r in db.Rodzaj_Urlopu
                         select new { r.ID_Rodzaj_Urlopu, Nazwa = r.Nazwa };
            cbRodzajUrlopu.DataSource = query2.ToList();
            cbRodzajUrlopu.DisplayMember = "Nazwa";
            cbRodzajUrlopu.ValueMember = "ID_Rodzaj_Urlopu";
            //cbKlient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbKlient.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbRodzajUrlopu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajUrlopu.SelectedIndex = -1;

        }
        private bool czyUrlop()
        {
            bool czyurloppp = false;
            int wykorzystanyUrlop = 0;
            var query = from u in db.Wykorzystany_Urlop
                        where (int)cbPracownik.SelectedValue == u.ID_Pracownicy
                        select u;

            foreach (Wykorzystany_Urlop wu in query)
                wykorzystanyUrlop = (int)wu.Wykorzystany_Urlop1;
            //------------------------------------
            int wykorzystanyNaZadanie = 0;
            var query2 = from u2 in db.Wykorzystany_Urlop_Na_Zadanie
                         where (int)cbPracownik.SelectedValue == u2.ID_Pracownicy
                         select u2;
            foreach (Wykorzystany_Urlop_Na_Zadanie wu2 in query2)
                wykorzystanyNaZadanie = (int)wu2.Wykorzystany_Urlop_Na_Zadanie1;
            //----------------------------------
            int IDtypUmowy = 0;
            var query3 = from u3 in db.Pracownicy_RodzajUmowy
                         where (int)cbPracownik.SelectedValue == u3.ID_Pracownicy
                         select u3;
            foreach (Pracownicy_RodzajUmowy wu3 in query3)
                IDtypUmowy = (int)wu3.ID_Rodzaj_Umowy;
            //---------------------------
            int staz = 0;
            var query4 = from u4 in db.Pracownicy_Zatrudnienie
                         where (int)cbPracownik.SelectedValue == u4.ID_Pracownicy
                         select u4;
            foreach (Pracownicy_Zatrudnienie wu4 in query4)
                staz = (int)wu4.Dotychczasowy_Staz;
            //-------------------------------------------
            int zadanyUrlop = (int)numDniRobocze.Value;
            //MessageBox.Show(IDtypUmowy.ToString());
            //MessageBox.Show(zadanyUrlop.ToString());
            //MessageBox.Show(staz.ToString());
            //MessageBox.Show(wykorzystanyNaZadanie.ToString());
            if (IDtypUmowy == 1)
            {
                if (staz >= 10)
                {
                    if (zadanyUrlop + wykorzystanyUrlop <= 26)
                    {
                        if ((int)cbRodzajUrlopu.SelectedValue == 3)
                        {
                            if (wykorzystanyNaZadanie + zadanyUrlop <= 4)
                            {
                                czyurloppp = true;
                            }
                            else
                            {
                                MessageBox.Show("Wybrana ilość dni urlopu przekroczy maksymalną liczbę dni urlopu na żądanie w tym roku");

                            }
                        }
                        else
                        {
                            czyurloppp = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wybrana ilość dni urlopu przekroczy maksymalną liczbę dni urlopu w tym roku");
                    }
                }
                else
                {

                    if (zadanyUrlop + wykorzystanyUrlop <= 20)
                    {
                        if ((int)cbRodzajUrlopu.SelectedValue == 3)
                        {
                            if (wykorzystanyNaZadanie + zadanyUrlop <= 4)
                            {
                                czyurloppp = true;
                            }
                            else
                            {
                                MessageBox.Show("Wybrana ilość dni urlopu przekroczy maksymalną liczbę dni urlopu na żądanie w tym roku");
                            }
                        }
                        else
                        {
                            czyurloppp = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wybrana ilość dni urlopu przekroczy maksymalną liczbę dni urlopu w tym roku");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pracownikowi z tym typem umowy nie przysługuje urlop");
            }
            return czyurloppp;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (czyUrlop())
            {
                if (cbRodzajUrlopu.SelectedIndex >= 0
                    && cbPracownik.SelectedIndex >= 0
                        )
                {


                    if (flagEdit)
                    {
                        //     Edycja
                        Urlopy updateUrlop = db.Urlopies.First(p => p.ID_Urlopy == selectedUrlopy.ID_Urlopy);
                        updateUrlop.ID_Rodzaj_Urlopu = (int)cbRodzajUrlopu.SelectedValue;
                        updateUrlop.ID_Pracownicy = (int)cbPracownik.SelectedValue;
                        updateUrlop.Data_od = dateDataPocz.Value;
                        updateUrlop.Data_do = dateDataKonc.Value;
                        updateUrlop.Dni_Robocze = (int)numDniRobocze.Value;
                        ///////////////
                        db.SaveChanges();
                    }
                    else
                    {
                        //Dodanie nowego urlopu

                        Urlopy newUrlopy = new Urlopy();
                        newUrlopy.ID_Rodzaj_Urlopu = (int)cbRodzajUrlopu.SelectedValue;
                        newUrlopy.ID_Pracownicy = (int)cbPracownik.SelectedValue;
                        newUrlopy.Data_od = dateDataPocz.Value;
                        newUrlopy.Data_do = dateDataKonc.Value;
                        newUrlopy.Dni_Robocze = (int)numDniRobocze.Value;
                        /////////////
                        db.Urlopies.Add(newUrlopy);
                        db.SaveChanges();
                    }


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Nie wprowadzono wymaganych danych!");
            }

            //else
               // MessageBox.Show("Nie spełniono warunków przyznania urlopu");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void AFKlienciCU_Load(object sender, EventArgs e)
        {

        }

        //Przesuwanie okna myszą
        private Point? lastPoint = null;
        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }
        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (lastPoint.HasValue)
            {
                int deltaX = e.X - lastPoint.Value.X;
                int deltaY = e.Y - lastPoint.Value.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }
        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = null;
        }


    }
}



