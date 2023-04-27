using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFPracownicyStanowiskoCU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Pracownicy selectedPracownicy = new Pracownicy();
        Pracownicy_Stanowisko selectedStanowisko = new Pracownicy_Stanowisko();
        public AFPracownicyStanowiskoCU(Pracownicy _selectedPracownicy)
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

            initDgwPracownicyStanowisko();            
            lblKindWindow.Text = "Działy Pracownika: " + selectedPracownicy.Imie + " " + selectedPracownicy.Nazwisko;
            cbStanowisko.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
            initDatePickers();
            initComboboxes();

        }
        private void initDgwPracownicyStanowisko()
        {
            var query = from ps in db.Pracownicy_Stanowisko
                        join s in db.Stanowiskoes on ps.ID_Stanowisko equals s.ID_Stanowisko
                        where ps.ID_Pracownicy == selectedPracownicy.ID_Pracownicy
                        orderby ps.Data
                        select new { ps.ID_Pracownicy, Stanowisko = s.Nazwa, Data = ps.Data };

            // przypisanie wyniku kwerendy do DataSource dla DataGridView
            DgwPracownicyStanowisko.DataSource = query.ToList();

            this.DgwPracownicyStanowisko.Columns["ID_Pracownicy"].Visible = false;
            DgwPracownicyStanowisko.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }


        private void initDatePickers()
        {
            dateDataZmiany.CustomFormat = "yyyy-MM-dd";
            dateDataZmiany.Format = DateTimePickerFormat.Custom;
            dateDataZmiany.Value = DateTime.Today;
        }
        private void initComboboxes()
        {
            
            var query = from d in db.Stanowiskoes
                        select new { d.ID_Stanowisko, d.Nazwa };
            cbStanowisko.DataSource = query.ToList();
            cbStanowisko.DisplayMember = "Nazwa";
            cbStanowisko.ValueMember = "ID_Stanowisko";
            cbStanowisko.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStanowisko.SelectedIndex = -1;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbStanowisko.Enabled = true;
            dateDataZmiany.Enabled = true;
            btnAccept.Enabled = true;
            btnCancel2.Enabled = true;
        }
        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            Pracownicy_Stanowisko newStanowisko = new Pracownicy_Stanowisko();
            newStanowisko.ID_Pracownicy = selectedPracownicy.ID_Pracownicy;
            newStanowisko.ID_Stanowisko = int.Parse(cbStanowisko.SelectedValue.ToString());
            newStanowisko.Data = dateDataZmiany.Value;
            db.Pracownicy_Stanowisko.Add(newStanowisko);
            db.SaveChanges();

            initDgwPracownicyStanowisko();
            cbStanowisko.SelectedIndex = -1;
            dateDataZmiany.Value = DateTime.Today;
            cbStanowisko.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            cbStanowisko.SelectedIndex = -1;
            dateDataZmiany.Value = DateTime.Today;
            cbStanowisko.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void DgwPracownicyStanowisko_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = DgwPracownicyStanowisko.CurrentRow.Index;
            DataGridViewRow selectedrow = DgwPracownicyStanowisko.Rows[index];

            selectedStanowisko.ID_Pracownicy_Stanowisko = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Pracownicy_Stanowisko
                        where p.ID_Pracownicy_Stanowisko == selectedStanowisko.ID_Pracownicy_Stanowisko
                        select p;
            foreach (Pracownicy_Stanowisko p in query)
            {
                selectedStanowisko.ID_Pracownicy = p.ID_Pracownicy;
                selectedStanowisko.ID_Stanowisko = p.ID_Stanowisko;
                selectedStanowisko.Data = p.Data;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?", "Usuwanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = from p in db.Pracownicy_Stanowisko
                                where p.ID_Pracownicy_Stanowisko == selectedStanowisko.ID_Pracownicy_Stanowisko
                                select p;
                    foreach (Pracownicy_Stanowisko p in query)
                        db.Pracownicy_Stanowisko.Remove(p);
                    db.SaveChanges();
                    initDgwPracownicyStanowisko();
                    flagSelected = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //kod
                }
            }
            else
                MessageBox.Show("Nie wybrano stanowiska!");
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

        private void AFPracownicyStanowiskoCU_Load(object sender, EventArgs e)
        {
            DgwPracownicyStanowisko.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DgwPracownicyStanowisko.ClearSelection();
        }

        
    }
}
