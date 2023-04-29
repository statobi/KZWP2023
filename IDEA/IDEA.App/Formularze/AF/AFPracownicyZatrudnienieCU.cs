using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFPracownicyZatrudnienieCU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Pracownicy selectedPracownicy = new Pracownicy();
        Pracownicy_Zatrudnienie selectedZatrudnienie = new Pracownicy_Zatrudnienie();
        public AFPracownicyZatrudnienieCU(Pracownicy _selectedPracownicy)
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

            initDgwPracownicyZatrudnienie();            
            lblKindWindow.Text = "Zatrudnienie Pracownika: " + selectedPracownicy.Imie + " " + selectedPracownicy.Nazwisko;
            txtPensjaNetto.Enabled = false;
            txtPensjaBrutto.Enabled = false;
            numDotychczasowystaz.Enabled = false;
            dateDataod.Enabled = false;
            dateDatado.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
            initDatePickers();
            initDatePickers_2();



        }
        private void initDgwPracownicyZatrudnienie()
        {
            var query = from pz in db.Pracownicy_Zatrudnienie
                        join z in db.Pracownicy_Zatrudnienie on pz.ID_Pracownicy_Zatrudnienie equals z.ID_Pracownicy_Zatrudnienie
                        where pz.ID_Pracownicy == selectedPracownicy.ID_Pracownicy
                        orderby pz.Data_od
                        select new { pz.ID_Pracownicy, Data_od = pz.Data_od, Data_do = pz.Data_do, Pensja_Netto = pz.Pensja_Netto, Pensja_Brutto = pz.Pensja_Brutto, Dotychczasowy_Staz = pz.Dotychczasowy_Staz};

            // przypisanie wyniku kwerendy do DataSource dla DataGridView
            DgwPracownicyZatrudnienie.DataSource = query.ToList();
            this.DgwPracownicyZatrudnienie.Columns["ID_Pracownicy"].Visible = false;


            DgwPracownicyZatrudnienie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }


        private void initDatePickers()
        {
            dateDataod.CustomFormat = "yyyy-MM-dd";
            dateDataod.Format = DateTimePickerFormat.Custom;
            dateDataod.Value = DateTime.Today;
        }
        private void initDatePickers_2()
        {
            dateDatado.CustomFormat = "yyyy-MM-dd";
            dateDatado.Format = DateTimePickerFormat.Custom;
            dateDatado.Value = DateTime.Today;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtPensjaNetto.Enabled = true;
            txtPensjaBrutto.Enabled = true;
            numDotychczasowystaz.Enabled = true;
            dateDataod.Enabled = true;
            dateDatado.Enabled = true;
            btnAccept.Enabled = true;
            btnCancel2.Enabled = true;
        }
        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            Pracownicy_Zatrudnienie newZatrudnienie = new Pracownicy_Zatrudnienie();
            newZatrudnienie.ID_Pracownicy = selectedPracownicy.ID_Pracownicy;
            newZatrudnienie.Pensja_Netto = decimal.Parse(txtPensjaNetto.Text);
            newZatrudnienie.Pensja_Brutto = decimal.Parse(txtPensjaBrutto.Text);
            newZatrudnienie.Dotychczasowy_Staz = (int)numDotychczasowystaz.Value;
            newZatrudnienie.Data_od = dateDataod.Value;
            newZatrudnienie.Data_do = dateDatado.Value;

            db.Pracownicy_Zatrudnienie.Add(newZatrudnienie);
            db.SaveChanges();

            initDgwPracownicyZatrudnienie();
            dateDataod.Value = DateTime.Today;
            dateDatado.Value = DateTime.Today;
            txtPensjaNetto.Enabled = true;
            txtPensjaBrutto.Enabled = true;
            numDotychczasowystaz.Enabled = true;
            dateDataod.Enabled = false;
            dateDataod.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            dateDataod.Value = DateTime.Today;
            txtPensjaNetto.Enabled = false;
            txtPensjaBrutto.Enabled = false;
            numDotychczasowystaz.Enabled = false;
            dateDataod.Enabled = false;
            dateDatado.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void DgwPracownicyZatrudnienie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = DgwPracownicyZatrudnienie.CurrentRow.Index;
            DataGridViewRow selectedrow = DgwPracownicyZatrudnienie.Rows[index];

            selectedZatrudnienie.ID_Pracownicy_Zatrudnienie = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Pracownicy_Zatrudnienie
                        where p.ID_Pracownicy_Zatrudnienie == selectedZatrudnienie.ID_Pracownicy_Zatrudnienie
                        select p;
            foreach (Pracownicy_Zatrudnienie p in query)
            {
                selectedZatrudnienie.ID_Pracownicy = p.ID_Pracownicy;
                selectedZatrudnienie.ID_Pracownicy_Zatrudnienie = p.ID_Pracownicy_Zatrudnienie;
                selectedZatrudnienie.Data_od = p.Data_od;
                selectedZatrudnienie.Data_do = p.Data_do;
                selectedZatrudnienie.Pensja_Netto = p.Pensja_Netto;
                selectedZatrudnienie.Pensja_Netto = p.Pensja_Netto;
                selectedZatrudnienie.Dotychczasowy_Staz = p.Dotychczasowy_Staz;

            }

        }
        private void txtPensjaNetto_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(txtPensjaNetto.Text, out double PensjaNetto))
            {
                PensjaNetto = double.Parse(txtPensjaNetto.Text);
                double PensjaBrutto = PensjaNetto * 1.23;
                string cenaRounded = PensjaBrutto.ToString("0.00");
                txtPensjaBrutto.Text = cenaRounded;

            }
            else
            {
                txtPensjaNetto.Clear();
                txtPensjaBrutto.Clear();
            }
        }
            private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?", "Usuwanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = from p in db.Pracownicy_Zatrudnienie
                                where p.ID_Pracownicy_Zatrudnienie == selectedZatrudnienie.ID_Pracownicy_Zatrudnienie
                                select p;
                    foreach (Pracownicy_Zatrudnienie p in query)
                        db.Pracownicy_Zatrudnienie.Remove(p);
                    db.SaveChanges();
                    initDgwPracownicyZatrudnienie();
                    flagSelected = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //kod
                }
            }
            else
                MessageBox.Show("Nie wybrano pola do usunięcia!");
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

        private void iBtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AFPracownicyZatrudnienieCU_Load(object sender, EventArgs e)
        {
            DgwPracownicyZatrudnienie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DgwPracownicyZatrudnienie.ClearSelection();
        }

        private void dateDataod_ValueChanged(object sender, EventArgs e)
        {

        }

      
    }
}
