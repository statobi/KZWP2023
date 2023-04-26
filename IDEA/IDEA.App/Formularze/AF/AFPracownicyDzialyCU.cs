using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFPracownicyDzialyCU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Pracownicy selectedPracownicy = new Pracownicy();
        Pracownicy_Dzialy selectedDzial = new Pracownicy_Dzialy();
        public AFPracownicyDzialyCU(Pracownicy _selectedPracownicy)
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

            initDgwPracownicyDzialy();            
            lblKindWindow.Text = "Działy Pracownika: " + selectedPracownicy.Imie + " " + selectedPracownicy.Nazwisko;
            cbDzial.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
            initDatePickers();
            initComboboxes();

        }
        private void initDgwPracownicyDzialy()
        {
            var query = from pd in db.Pracownicy_Dzialy
                        join d in db.Dzialies on pd.ID_Dzialy equals d.ID_Dzialy
                        where pd.ID_Pracownicy == selectedPracownicy.ID_Pracownicy
                        orderby pd.Data
                        select new { pd.ID_Pracownicy, Dział = d.Nazwa, Data = pd.Data };

            // przypisanie wyniku kwerendy do DataSource dla DataGridView
            DgwPracownicyDzialy.DataSource = query.ToList();

            this.DgwPracownicyDzialy.Columns["ID_Pracownicy"].Visible = false;
            DgwPracownicyDzialy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }


        private void initDatePickers()
        {
            dateDataZmiany.CustomFormat = "yyyy-MM-dd";
            dateDataZmiany.Format = DateTimePickerFormat.Custom;
            dateDataZmiany.Value = DateTime.Today;
        }
        private void initComboboxes()
        {

            var query = from d in db.Dzialies
                        select new { d.ID_Dzialy, d.Nazwa };
            cbDzial.DataSource = query.ToList();
            cbDzial.DisplayMember = "Nazwa";
            cbDzial.ValueMember = "ID_Dzialy";
            cbDzial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDzial.SelectedIndex = -1;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbDzial.Enabled = true;
            dateDataZmiany.Enabled = true;
            btnAccept.Enabled = true;
            btnCancel2.Enabled = true;
        }
        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            Pracownicy_Dzialy newDzial = new Pracownicy_Dzialy();
            newDzial.ID_Pracownicy = selectedPracownicy.ID_Pracownicy;
            newDzial.ID_Dzialy = int.Parse(cbDzial.SelectedValue.ToString());
            newDzial.Data = dateDataZmiany.Value;
            db.Pracownicy_Dzialy.Add(newDzial);
            db.SaveChanges();

            initDgwPracownicyDzialy();
            cbDzial.SelectedIndex = -1;
            dateDataZmiany.Value = DateTime.Today;
            cbDzial.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            cbDzial.SelectedIndex = -1;
            dateDataZmiany.Value = DateTime.Today;
            cbDzial.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void DgwPracownicyDzialy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = DgwPracownicyDzialy.CurrentRow.Index;
            DataGridViewRow selectedrow = DgwPracownicyDzialy.Rows[index];

            selectedDzial.ID_Pracownicy_Dzialy = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Pracownicy_Dzialy
                        where p.ID_Pracownicy_Dzialy == selectedDzial.ID_Pracownicy_Dzialy
                        select p;
            foreach (Pracownicy_Dzialy p in query)
            {
                selectedDzial.ID_Pracownicy = p.ID_Pracownicy;
                selectedDzial.ID_Dzialy = p.ID_Dzialy;
                selectedDzial.Data = p.Data;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?", "Usuwanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = from p in db.Pracownicy_Dzialy
                                where p.ID_Pracownicy_Dzialy == selectedDzial.ID_Pracownicy_Dzialy
                                select p;
                    foreach (Pracownicy_Dzialy p in query)
                        db.Pracownicy_Dzialy.Remove(p);
                    db.SaveChanges();
                    initDgwPracownicyDzialy();
                    flagSelected = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //kod
                }
            }
            else
                MessageBox.Show("Nie wybrano działu!");
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

        private void AFPracownicyDzialyCU_Load(object sender, EventArgs e)
        {
            DgwPracownicyDzialy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        
    }
}
