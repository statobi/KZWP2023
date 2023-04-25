using IDEA.Logistyka.Magazyny;
using IDEA.Logistyka.Modele;
using IDEA.Logistyka.Obserwator;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class MagazynForm : Form, ISubscriber
    {
        private readonly IPublisher _publisher = Publisher.GetInstance();
        private readonly MagazynService _magazynService = new MagazynService();
        private MagazynDGV _focussedCell = new MagazynDGV();
        public MagazynForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
            InitGrid();
        }

        public void UpdateView(string message = null)
        {
            DGVMagazyny.DataSource = _magazynService.DataGridData();
        }

        private void InitGrid()
        {
            DGVMagazyny.DataSource = _magazynService.DataGridData();
            DGVMagazyny.Columns[0].Visible = false;
            DGVMagazyny.Columns["NrTelefonu"].HeaderText = "Nr telefonu";
            DGVMagazyny.Columns["PowierzchniaRobocza"].HeaderText = "Powierzchnia";
            DGVMagazyny.Columns["CalkowitaZajetoscPowierzchni"].HeaderText = "Zajętość magazynu";
        }

        private void BtnDodajMagazyn_Click(object sender, EventArgs e)
        {
            var dodajMagazynForm = new DodajMagazynForm();
            dodajMagazynForm.ShowDialog();
        }

        private void BtnModyfikujMagazyn_Click(object sender, EventArgs e)
        {
            var dodajMagazynForm = new DodajMagazynForm();
            _publisher.Notify(typeof(DodajMagazynForm));
            dodajMagazynForm.ShowDialog();
        }

        private void DGVMagazyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _focussedCell.Nazwa = DGVMagazyny.Rows[e.RowIndex].Cells["Nazwa"].Value.ToString();
            _focussedCell.NrTelefonu = DGVMagazyny.Rows[e.RowIndex].Cells["NrTelefonu"].Value.ToString();
            _focussedCell.PowierzchniaRobocza = int.Parse(DGVMagazyny.Rows[e.RowIndex].Cells["PowierzchniaRobocza"].Value.ToString());
        }
    }
}
