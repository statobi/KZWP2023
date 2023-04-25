using IDEA.App.MessageBoxes;
using IDEA.Logistyka.Magazyny;
using IDEA.Logistyka.Modele;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Serwisy.Sekcje;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class MagazynForm : Form, ISubscriber
    {
        private readonly Publisher _publisher = Publisher.GetInstance();

        private readonly MagazynService _magazynService = new MagazynService();
        private readonly SekcjaService _sekcjaService = new SekcjaService();

        private MagazynDGV _focussedCell = new MagazynDGV();

        public MagazynForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
            InitMagazynGrid();
            AssignFoccusedRowToObj();
            InitSekcjaGrid();
        }

        public void UpdateView(string message = null)
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
            DVGSekcja.DataSource = _sekcjaService.DataGridData(_focussedCell.Id);
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
            if (string.IsNullOrEmpty(_focussedCell.Nazwa))
            {
                CustomMessageBox.ErrorBox("Należy najpierw wybrać magazyn");
                return;
            }

            var edytujMagazynForm = new EdytujMagazynForm();
            _publisher.Notify<EdytujMagazynForm>(_focussedCell);
            edytujMagazynForm.ShowDialog();
        }

        private void DGVMagazyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _focussedCell.Id = int.Parse(DGVMagazyny.Rows[e.RowIndex].Cells[0].Value.ToString());
            _focussedCell.Nazwa = DGVMagazyny.Rows[e.RowIndex].Cells["Nazwa"].Value.ToString();
            _focussedCell.NrTelefonu = DGVMagazyny.Rows[e.RowIndex].Cells["NrTelefonu"].Value.ToString();
            _focussedCell.PowierzchniaRobocza = DGVMagazyny.Rows[e.RowIndex].Cells["PowierzchniaRobocza"].Value.ToString();
            InitSekcjaGrid();
        }

        private void AssignFoccusedRowToObj()
        {
            _focussedCell.Id = int.Parse(DGVMagazyny.Rows[0].Cells[0].Value.ToString());
            _focussedCell.Nazwa = DGVMagazyny.Rows[0].Cells["Nazwa"].Value.ToString();
            _focussedCell.NrTelefonu = DGVMagazyny.Rows[0].Cells["NrTelefonu"].Value.ToString();
            _focussedCell.PowierzchniaRobocza = DGVMagazyny.Rows[0].Cells["PowierzchniaRobocza"].Value.ToString();
        }

        private void DVGSekcja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _publisher.Notify<InitForm>();
        }
    }
}
