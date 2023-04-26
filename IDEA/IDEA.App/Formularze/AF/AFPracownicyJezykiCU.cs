using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFPracownicyJezykiCU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Pracownicy selectedPracownicy = new Pracownicy();
        Pracownicy_Jezyki selectedJezyki= new Pracownicy_Jezyki();
        public AFPracownicyJezykiCU(Pracownicy _selectedPracownicy)
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

            initDgwPracownicyJezyki();            
            lblKindWindow.Text = "Języki Pracownika: " + selectedPracownicy.Imie + " " + selectedPracownicy.Nazwisko;
            cbJezyk.Enabled = false;
            cbPoziom.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
            initDatePickers();
            initComboboxes();

        }


        private void initDgwPracownicyJezyki()
        {
            var query = from pd in db.Pracownicy_Jezyki
                        join d in db.Jezykis on pd.ID_Jezyki equals d.ID_Jezyki
                        join pz in db.Poziom_Znajomosci on pd.ID_Poziom_Znajomosci equals pz.ID_Poziom_Znajomosci
                        where pd.ID_Pracownicy == selectedPracownicy.ID_Pracownicy
                        orderby pd.Data
                        select new { pd.ID_Pracownicy, Jezyk = d.Nazwa, Data = pd.Data, Poziom = pz.Nazwa };

            // przypisanie wyniku kwerendy do DataSource dla DataGridView
            DgwPracownicyJezyki.DataSource = query.ToList();

            this.DgwPracownicyJezyki.Columns["ID_Pracownicy"].Visible = false;
            DgwPracownicyJezyki.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

     
        private void initDatePickers()
        {
            dateDataZmiany.CustomFormat = "yyyy-MM-dd";
            dateDataZmiany.Format = DateTimePickerFormat.Custom;
            dateDataZmiany.Value = DateTime.Today;
        }
        private void initComboboxes()
        {

            var query = from d in db.Jezykis
                        select new { d.ID_Jezyki, d.Nazwa };
            cbJezyk.DataSource = query.ToList();
            cbJezyk.DisplayMember = "Nazwa";
            cbJezyk.ValueMember = "ID_Jezyki";
            cbJezyk.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJezyk.SelectedIndex = -1;

        }
        private void cbPoziom_SelectedIndexChanged(object sender, EventArgs e)
        {

            var query = from d in db.Poziom_Znajomosci
                        select new { d.ID_Poziom_Znajomosci, d.Nazwa };
            cbPoziom.DataSource = query.ToList();
            cbPoziom.DisplayMember = "Nazwa";
            cbPoziom.ValueMember = "ID_Poziom_Znajomosc";
            cbPoziom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPoziom.SelectedIndex = -1;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbJezyk.Enabled = true;
            cbPoziom.Enabled = true;
            dateDataZmiany.Enabled = true;
            btnAccept.Enabled = true;
            btnCancel2.Enabled = true;
        }
        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            Pracownicy_Jezyki newJezyki = new Pracownicy_Jezyki();
            newJezyki.ID_Pracownicy = selectedPracownicy.ID_Pracownicy;
            newJezyki.ID_Jezyki = int.Parse(cbJezyk.SelectedValue.ToString());
            newJezyki.ID_Poziom_Znajomosci = int.Parse(cbPoziom.SelectedValue.ToString());
            newJezyki.Data = dateDataZmiany.Value;
            db.Pracownicy_Jezyki.Add(newJezyki);
            db.SaveChanges();

            initDgwPracownicyJezyki();
            cbJezyk.SelectedIndex = -1;
            cbPoziom.SelectedIndex = -1;
            dateDataZmiany.Value = DateTime.Today;
            cbJezyk.Enabled = false;
            cbPoziom.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            cbJezyk.SelectedIndex = -1;
            dateDataZmiany.Value = DateTime.Today;
            cbJezyk.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void DgwPracownicyJezyki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = DgwPracownicyJezyki.CurrentRow.Index;
            DataGridViewRow selectedrow = DgwPracownicyJezyki.Rows[index];

            selectedJezyki.ID_Pracownicy_Jezyki = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Pracownicy_Jezyki
                        where p.ID_Pracownicy_Jezyki == selectedJezyki.ID_Pracownicy_Jezyki
                        select p;
            foreach (Pracownicy_Jezyki p in query)
            {
                selectedJezyki.ID_Pracownicy = p.ID_Pracownicy;
                selectedJezyki.ID_Jezyki = p.ID_Jezyki;
                selectedJezyki.Data = p.Data;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?", "Usuwanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = from p in db.Pracownicy_Jezyki
                                where p.ID_Pracownicy_Jezyki == selectedJezyki.ID_Pracownicy_Jezyki
                                select p;
                    foreach (Pracownicy_Jezyki p in query)
                        db.Pracownicy_Jezyki.Remove(p);
                    db.SaveChanges();
                    initDgwPracownicyJezyki();
                    flagSelected = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //kod
                }
            }
            else
                MessageBox.Show("Nie wybrano pola do edycji!");
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
            DgwPracownicyJezyki.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
