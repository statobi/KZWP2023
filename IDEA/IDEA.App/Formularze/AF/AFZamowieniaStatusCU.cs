using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFZamowieniaStatusCU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Zamowienia_Klienci selectedZamowienie = new Zamowienia_Klienci();
        ZamowieniaKlienci_StatusZamowienia selectedStatus = new ZamowieniaKlienci_StatusZamowienia();
        public AFZamowieniaStatusCU(Zamowienia_Klienci _selectedZamowienie)
        {
            InitializeComponent();
            selectedZamowienie = _selectedZamowienie;
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

            iniDgvStatus();
            lblKindWindow.Text = "Status zamówienia nr: " + selectedZamowienie.Numer;
            cbStatus.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
            initDatePickers();
            initComboboxes();
        }

        private void iniDgvStatus()
        {
            var query = from zksk in db.ZamowieniaKlienci_StatusZamowienia
                        join sz in db.Status_Zamowienia on zksk.ID_Status_Zamowienia equals sz.ID_Status_Zamowienia
                        where zksk.ID_Zamowienia_Klienci == selectedZamowienie.ID_Zamowienia_Klienci
                        orderby zksk.Data
                        select new { zksk.ID_ZamowieniaKlienci_StatusZamowienia, zksk.ID_Zamowienia_Klienci, Status = sz.Nazwa, Data = zksk.Data };

            // przypisanie wyniku kwerendy do DataSource dla DataGridView
            dgvStatus.DataSource = query.ToList();

            this.dgvStatus.Columns["ID_ZamowieniaKlienci_StatusZamowienia"].Visible = false;
            this.dgvStatus.Columns["ID_Zamowienia_Klienci"].Visible = false;
            dgvStatus.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDatePickers()
        {
            dateDataZmiany.CustomFormat = "yyyy-MM-dd";
            dateDataZmiany.Format = DateTimePickerFormat.Custom;
            dateDataZmiany.Value = DateTime.Today;
        }
        private void initComboboxes()
        {

            var query = from sz in db.Status_Zamowienia
                        select new { sz.ID_Status_Zamowienia, sz.Nazwa };
            cbStatus.DataSource = query.ToList();
            cbStatus.DisplayMember = "Nazwa";
            cbStatus.ValueMember = "ID_Status_Zamowienia";
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.SelectedIndex = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbStatus.Enabled = true;
            dateDataZmiany.Enabled = true;
            btnAccept.Enabled = true;
            btnCancel2.Enabled = true;
        }
        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex >= 0)
            {
                ZamowieniaKlienci_StatusZamowienia newStatus = new ZamowieniaKlienci_StatusZamowienia();
                newStatus.ID_Zamowienia_Klienci = selectedZamowienie.ID_Zamowienia_Klienci;
                newStatus.ID_Status_Zamowienia = int.Parse(cbStatus.SelectedValue.ToString());
                newStatus.Data = dateDataZmiany.Value;
                db.ZamowieniaKlienci_StatusZamowienia.Add(newStatus);
                db.SaveChanges();

                iniDgvStatus();
                cbStatus.SelectedIndex = -1;
                dateDataZmiany.Value = DateTime.Today;
                cbStatus.Enabled = false;
                dateDataZmiany.Enabled = false;
                btnAccept.Enabled = false;
                btnCancel2.Enabled = false;
            }
            else
                MessageBox.Show("Nie wprowadzono wymaganych danych!");
        }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = -1;
            dateDataZmiany.Value = DateTime.Today;
            cbStatus.Enabled = false;
            dateDataZmiany.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel2.Enabled = false;
        }
        private void dgvStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = dgvStatus.CurrentRow.Index;
            DataGridViewRow selectedrow = dgvStatus.Rows[index];

            selectedStatus.ID_ZamowieniaKlienci_StatusZamowienia = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from zksz in db.ZamowieniaKlienci_StatusZamowienia
                        where zksz.ID_ZamowieniaKlienci_StatusZamowienia == selectedStatus.ID_ZamowieniaKlienci_StatusZamowienia
                        select zksz;
            foreach (ZamowieniaKlienci_StatusZamowienia zksz in query)
            {
                selectedStatus.ID_Zamowienia_Klienci = zksz.ID_Zamowienia_Klienci;
                selectedStatus.ID_Status_Zamowienia = zksz.ID_Status_Zamowienia;
                selectedStatus.Data = zksz.Data;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?", "Usuwanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query2 = from zksz in db.ZamowieniaKlienci_StatusZamowienia
                                 where zksz.ID_ZamowieniaKlienci_StatusZamowienia == selectedStatus.ID_ZamowieniaKlienci_StatusZamowienia
                                 select zksz;
                    foreach (ZamowieniaKlienci_StatusZamowienia zksz in query2)
                    {
                        db.ZamowieniaKlienci_StatusZamowienia.Remove(zksz);
                    }
                    db.SaveChanges();
                    iniDgvStatus();
                    flagSelected = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //kod
                }
            }
            else
                MessageBox.Show("Nie wybrano statusu!");
        }
        private void iBtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void AFPracownicyDzialyCU_Load(object sender, EventArgs e)
        {
            dgvStatus.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvStatus.ClearSelection();
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
    }
}
