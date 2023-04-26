using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFPracownicyRodzajUmowyCU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Pracownicy selectedPracownicy = new Pracownicy();
        Pracownicy_RodzajUmowy selectedRodzajUmowy = new Pracownicy_RodzajUmowy();
        public AFPracownicyRodzajUmowyCU(Pracownicy _selectedPracownicy)
        {
            InitializeComponent();
            selectedPracownicy = _selectedPracownicy;
            ToolTip toolTipAdd = new ToolTip();
            toolTipAdd.SetToolTip(btnAdd, "Dodaj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(btnDelete, "Usuń");
            ToolTip toolTipBack = new ToolTip();
            toolTipBack.SetToolTip(iBtnBack, "Cofnij");
            ToolTip toolTipAccept = new ToolTip();
            toolTipAccept.SetToolTip(btnAccept, "Akceptuj");
            ToolTip toolTipCancel = new ToolTip();
            toolTipCancel.SetToolTip(btnCancel2, "Anuluj");

            initDgwPracownicyRodzajUmowy();            
            lblKindWindow.Text = "Rodzaj Umowy Pracownika: " + selectedPracownicy.Imie + " " + selectedPracownicy.Nazwisko;
            cbRodzajUmowy.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
            initDatePickers();
            initComboboxes();

        }
        private void initDgwPracownicyRodzajUmowy()
        {
            var query = from ru in db.Pracownicy_RodzajUmowy
                        join d in db.Rodzaj_Umowy on ru.ID_Rodzaj_Umowy equals d.ID_Rodzaj_Umowy
                        where ru.ID_Pracownicy == selectedPracownicy.ID_Pracownicy
                        orderby ru.Data
                        select new { ru.ID_Pracownicy, Rodzaj_Umowy = d.Nazwa, Data = ru.Data };

            // przypisanie wyniku kwerendy do DataSource dla DataGridView
            DgwPracownicyRodzajUmowy.DataSource = query.ToList();

            this.DgwPracownicyRodzajUmowy.Columns["ID_Pracownicy"].Visible = false;
            DgwPracownicyRodzajUmowy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }


        private void initDatePickers()
        {
            dateDataZmiany.CustomFormat = "yyyy-MM-dd";
            dateDataZmiany.Format = DateTimePickerFormat.Custom;
            dateDataZmiany.Value = DateTime.Today;
        }
        private void initComboboxes()
        {

            var query = from d in db.Rodzaj_Umowy
                        select new { d.ID_Rodzaj_Umowy, d.Nazwa };
            cbRodzajUmowy.DataSource = query.ToList();
            cbRodzajUmowy.DisplayMember = "Nazwa";
            cbRodzajUmowy.ValueMember = "ID_Rodzaj_Umowy";
            cbRodzajUmowy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajUmowy.SelectedIndex = -1;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbRodzajUmowy.Enabled = true;
            dateDataZmiany.Enabled = true;
            btnAccept.Enabled = true;
            btnCancel2.Enabled = true;
        }
        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            Pracownicy_RodzajUmowy newRodzajUmowy = new Pracownicy_RodzajUmowy();
            newRodzajUmowy.ID_Pracownicy = selectedPracownicy.ID_Pracownicy;
            newRodzajUmowy.ID_Rodzaj_Umowy = int.Parse(cbRodzajUmowy.SelectedValue.ToString());
            newRodzajUmowy.Data = dateDataZmiany.Value;
            db.Pracownicy_RodzajUmowy.Add(newRodzajUmowy);
            db.SaveChanges();

            initDgwPracownicyRodzajUmowy();
            cbRodzajUmowy.SelectedIndex = -1;
            dateDataZmiany.Value = DateTime.Today;
            cbRodzajUmowy.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            cbRodzajUmowy.SelectedIndex = -1;
            dateDataZmiany.Value = DateTime.Today;
            cbRodzajUmowy.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void DgwPracownicyRodzajUmowy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = DgwPracownicyRodzajUmowy.CurrentRow.Index;
            DataGridViewRow selectedrow = DgwPracownicyRodzajUmowy.Rows[index];

            selectedRodzajUmowy.ID_Pracownicy_RodzajUmowy = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Pracownicy_RodzajUmowy
                        where p.ID_Pracownicy_RodzajUmowy == selectedRodzajUmowy.ID_Pracownicy_RodzajUmowy
                        select p;
            foreach (Pracownicy_RodzajUmowy p in query)
            {
                selectedRodzajUmowy.ID_Pracownicy = p.ID_Pracownicy;
                selectedRodzajUmowy.ID_Pracownicy_RodzajUmowy = p.ID_Rodzaj_Umowy;
                selectedRodzajUmowy.Data = p.Data;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?", "Usuwanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = from p in db.Pracownicy_RodzajUmowy
                                where p.ID_Pracownicy_RodzajUmowy == selectedRodzajUmowy.ID_Pracownicy_RodzajUmowy
                                select p;
                    foreach (Pracownicy_RodzajUmowy p in query)
                        db.Pracownicy_RodzajUmowy.Remove(p);
                    db.SaveChanges();
                    initDgwPracownicyRodzajUmowy();
                    flagSelected = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //kod
                }
            }
            else
                MessageBox.Show("Nie wybrano rodzaju umowy!");
        }
       
        //-------------------------------------------------------------------------------------------------Przesuwanie okna myszą
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

        private void dateDataRealizacji_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iBtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AFPracownicyRodzajUmowyCU_Load(object sender, EventArgs e)
        {
            DgwPracownicyRodzajUmowy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        
    }
}
