using IDEA.App.Formularze.Logistyka.Magazyn.Sekcja;
using IDEA.App.MessageBoxes;
using IDEA.App.Observer;
using IDEA.Logistyka.Magazyny;
using IDEA.Logistyka.Modele;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class MagazynForm : Form, ISubscriber
    {
        private readonly Publisher _publisher = Publisher.GetInstance();
        private readonly OpenNewPanelPublisher _openNewPanelPublisher = OpenNewPanelPublisher.GetInstance();

        private readonly MagazynService _magazynService = new MagazynService();
        private readonly SekcjaService _sekcjaService = new SekcjaService();

        private MagazynDGV _focussedMagazynCell = new MagazynDGV();

        public MagazynForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
            InitMagazynGrid();
            AssignFoccusedRowToObj();
            InitSekcjaGrid();
        }

        public void GetData(string message = null)
        {
            DGVMagazyny.DataSource = _magazynService.DataGridData();
        }

        private void InitMagazynGrid()
        {
            DGVMagazyny.DataSource = _magazynService.DataGridData();
            DGVMagazyny.Columns[0].Visible = false;
            DGVMagazyny.Columns["NrTelefonu"].HeaderText = "Nr telefonu";
            DGVMagazyny.Columns["PowierzchniaRobocza"].HeaderText = "Powierzchnia";
            DGVMagazyny.Columns["CalkowitaZajetoscPowierzchni"].HeaderText = "Zajętość magazynu";
        }

        private void InitSekcjaGrid()
        {
            DVGSekcja.DataSource = _sekcjaService.ViewData(_focussedMagazynCell.Id);
            DVGSekcja.Columns[0].Visible = false;
            DVGSekcja.Columns["IdMagazyn"].Visible = false;
            DVGSekcja.Columns["PowierzchniaRobocza"].HeaderText = "Powierzchnia";
            DVGSekcja.Columns["TypZasobu"].HeaderText = "Typ zasobu";
            DVGSekcja.Columns["Wysokosc"].HeaderText = "Wysokość";

        }

        private void BtnDodajMagazyn_Click(object sender, EventArgs e)
        {
            var dodajMagazynForm = new DodajMagazynForm();
            dodajMagazynForm.ShowDialog();
        }

        private void BtnModyfikujMagazyn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_focussedMagazynCell.Nazwa))
            {
                CustomMessageBox.ErrorBox("Należy najpierw wybrać magazyn");
                return;
            }

            var edytujMagazynForm = new EdytujMagazynForm();
            _publisher.Notify<EdytujMagazynForm>(_focussedMagazynCell);
            edytujMagazynForm.ShowDialog();
        }

        private void DGVMagazyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _focussedMagazynCell.Id = int.Parse(DGVMagazyny.Rows[e.RowIndex].Cells[0].Value.ToString());
            _focussedMagazynCell.Nazwa = DGVMagazyny.Rows[e.RowIndex].Cells["Nazwa"].Value.ToString();
            _focussedMagazynCell.NrTelefonu = DGVMagazyny.Rows[e.RowIndex].Cells["NrTelefonu"].Value.ToString();
            _focussedMagazynCell.PowierzchniaRobocza = DGVMagazyny.Rows[e.RowIndex].Cells["PowierzchniaRobocza"].Value.ToString();
            InitSekcjaGrid();
        }

        private void AssignFoccusedRowToObj()
        {
            _focussedMagazynCell.Id = int.Parse(DGVMagazyny.Rows[0].Cells[0].Value.ToString());
            _focussedMagazynCell.Nazwa = DGVMagazyny.Rows[0].Cells["Nazwa"].Value.ToString();
            _focussedMagazynCell.NrTelefonu = DGVMagazyny.Rows[0].Cells["NrTelefonu"].Value.ToString();
            _focussedMagazynCell.PowierzchniaRobocza = DGVMagazyny.Rows[0].Cells["PowierzchniaRobocza"].Value.ToString();
        }

        private void DVGSekcja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clicked = new SekcjaOpenForm
            {
                Id = int.Parse(DVGSekcja.Rows[e.RowIndex].Cells[0].Value.ToString()),
                MagazynName = _focussedMagazynCell.Nazwa,
                SekcjaName = DVGSekcja.Rows[e.RowIndex].Cells["Numer"].Value.ToString()
            };

            _openNewPanelPublisher.Notify<SekcjaForm>(clicked);
            Close();
        }

        private void BtnAddSekcja_Click(object sender, EventArgs e)
        {
            var dodajSekcjeForm = new DodajSekcjeForm();
            dodajSekcjeForm.ShowDialog();
        }

        private void BtnModifySekcja_Click(object sender, EventArgs e)
        {
            var edytujSekcjeForm = new EdytujSekcjeForm();
            edytujSekcjeForm.ShowDialog();
        }

        private void MagazynForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _publisher.Unsubscribe(this);
        }

    }
}
