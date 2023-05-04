using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFUrlopyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Urlopy selectedUrlopy = new Urlopy();
        private bool flagLoaded = false;



        public AFUrlopyForm()
        {

            InitializeComponent();
            initDgwUrlopy();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipReset = new ToolTip();
            toolTipReset.SetToolTip(btnReset, "Reset");
        }

        private void initDgwUrlopy()
        {
            var Urlopy_Ewidencja = from u in db.Urlopies
                                   join p in db.Pracownicies on u.ID_Pracownicy equals p.ID_Pracownicy
                                   join ru in db.Rodzaj_Urlopu on u.ID_Rodzaj_Urlopu equals ru.ID_Rodzaj_Urlopu
                                   select new
                                   {
                                       p.Imie,
                                       p.Nazwisko,
                                       p.ID_Pracownicy,
                                       u.Data_od,
                                       u.Data_do,
                                       u.ID_Rodzaj_Urlopu,
                                       ru.Nazwa,
                                       u.Dni_Robocze,
                                       u.ID_Urlopy
                                   };
            dgvUrlopy.DataSource = Urlopy_Ewidencja.ToList();
            this.dgvUrlopy.Columns["ID_Pracownicy"].Visible = false;
            this.dgvUrlopy.Columns["ID_Rodzaj_urlopu"].Visible = false;
            this.dgvUrlopy.Columns["ID_Urlopy"].Visible = false;            //~----------------------------------------------------------------------------------------------
            dgvUrlopy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            var query1 = from p in db.Pracownicies
                         select new { p.ID_Pracownicy, Pracownik = p.Imie + " " + p.Nazwisko };
            comboBoxUrlopyPracownik.DataSource = query1.ToList();
            comboBoxUrlopyPracownik.DisplayMember = "Pracownik";
            comboBoxUrlopyPracownik.ValueMember = "ID_Pracownicy";
            //cbPracownik.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbPracownik.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxUrlopyPracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUrlopyPracownik.SelectedIndex = -1;

        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvUrlopy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            flagLoaded = true;

        }

        private void dgvUrlopy_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            flagSelected = true;
            int index;
            index = dgvUrlopy.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvUrlopy.Rows[index];
            selectedUrlopy.ID_Urlopy = int.Parse(selectedrow.Cells[8].Value.ToString());
            var query = from p in db.Urlopies
                        where p.ID_Urlopy == selectedUrlopy.ID_Urlopy
                        select p;
            foreach (Urlopy p in query)
            {
                selectedUrlopy.ID_Urlopy = p.ID_Urlopy;
                selectedUrlopy.ID_Pracownicy = p.ID_Pracownicy;
                selectedUrlopy.ID_Rodzaj_Urlopu = p.ID_Rodzaj_Urlopu;
                selectedUrlopy.Data_od = p.Data_od;
                selectedUrlopy.Data_do = p.Data_do;
                selectedUrlopy.Dni_Robocze = p.Dni_Robocze;
            }
        }

        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openKlientEdition(sender);
            using (AFUrlopy2CU aF = new AFUrlopy2CU())
            {
                aF.ShowDialog();
                initDgwUrlopy();
            }
        }

        private void comboBoxUrlopyPracownik_SelectedIndexChanged(object sender, EventArgs e)
        {
            int filtr;
            if (flagLoaded)
            {
                if (comboBoxUrlopyPracownik.SelectedIndex != -1)
                {
                    filtr = (int)comboBoxUrlopyPracownik.SelectedValue;
                    //MessageBox.Show(filtr.ToString());
                    var Urlopy_Ewidencja = from u in db.Urlopies
                                           join p in db.Pracownicies on u.ID_Pracownicy equals p.ID_Pracownicy
                                           join ru in db.Rodzaj_Urlopu on u.ID_Rodzaj_Urlopu equals ru.ID_Rodzaj_Urlopu
                                           select new
                                           {
                                               p.Imie,
                                               p.Nazwisko,
                                               p.ID_Pracownicy,
                                               u.Data_od,
                                               u.Data_do,
                                               u.ID_Rodzaj_Urlopu,
                                               ru.Nazwa,
                                               u.Dni_Robocze,
                                               u.ID_Urlopy
                                           };
                    var query = from s in Urlopy_Ewidencja
                                where s.ID_Pracownicy == filtr
                                select s;
                    dgvUrlopy.DataSource = query.ToList();

                }
                else
                {
                    var Urlopy_Ewidencja = from u in db.Urlopies
                                           join p in db.Pracownicies on u.ID_Pracownicy equals p.ID_Pracownicy
                                           join ru in db.Rodzaj_Urlopu on u.ID_Rodzaj_Urlopu equals ru.ID_Rodzaj_Urlopu
                                           select new
                                           {
                                               p.Imie,
                                               p.Nazwisko,
                                               p.ID_Pracownicy,
                                               u.Data_od,
                                               u.Data_do,
                                               u.ID_Rodzaj_Urlopu,
                                               ru.Nazwa,
                                               u.Dni_Robocze,
                                               u.ID_Urlopy
                                           };
                    var query = from s in Urlopy_Ewidencja
                                select s;
                    dgvUrlopy.DataSource = query.ToList();
                }
            }



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBoxUrlopyPracownik.SelectedIndex = -1;
        }


        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            {
                if (flagSelected)
                {
                    using (AFUrlopy2CU aF = new AFUrlopy2CU(selectedUrlopy))
                    {
                        aF.ShowDialog();
                        initDgwUrlopy();
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano urlopu do edycji!");
                }
            }
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć urlop?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query = from p in db.Urlopies
                            where p.ID_Urlopy == selectedUrlopy.ID_Urlopy
                            select p;
                foreach (Urlopy p in query)
                    db.Urlopies.Remove(p);
                db.SaveChanges();
                initDgwUrlopy();
            }
            else if (dialogResult == DialogResult.No)
            {
                //kod
            }
        }
    }
}
