using IDEA.App.Formularze.Logistyka.Magazyn.Sekcja;
using IDEA.App.MessageBoxes;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class MagazynForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _publisher = CommonPublisher.GetInstance();
        private readonly OpenNewPanelPublisher _openNewPanelPublisher = OpenNewPanelPublisher.GetInstance();

        private readonly MagazynService _magazynService = new MagazynService();
        private readonly SekcjaService _sekcjaService = new SekcjaService();

        private MagazynDGV _focussedMagazynCell = new MagazynDGV();

        public MagazynForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
            InitMagazynGrid();
            AssignFoccusedRowToObj(0);
            InitSekcjaGrid();
        }

        public void GetData<TMessage>(string message)
        {
            if(typeof(TMessage) == typeof(MagazynOpen))
            {
                var obj = JsonConvert.DeserializeObject<MagazynOpen>(message);
                DGVMagazyny.Rows[obj.MagazynDGVRowIndex].Selected = true;
            }
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
            _publisher.Send<EdytujMagazynForm, MagazynDGV>(_focussedMagazynCell);
            edytujMagazynForm.ShowDialog();
        }

        private void DGVMagazyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignFoccusedRowToObj(e.RowIndex);
            InitSekcjaGrid();
        }

        //m²

        private void AssignFoccusedRowToObj(int rowIndex)
        {
            _focussedMagazynCell.Id = int.Parse(DGVMagazyny.Rows[rowIndex].Cells[0].Value.ToString());
            _focussedMagazynCell.Nazwa = DGVMagazyny.Rows[rowIndex].Cells["Nazwa"].Value.ToString();
            _focussedMagazynCell.NrTelefonu = DGVMagazyny.Rows[rowIndex].Cells["NrTelefonu"].Value.ToString();
            _focussedMagazynCell.PowierzchniaRobocza = double.Parse(DGVMagazyny.Rows[rowIndex].Cells["PowierzchniaRobocza"].Value.ToString());
        }

        private void DVGSekcja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clicked = new SekcjaOpen
            {
                Id = int.Parse(DVGSekcja.Rows[e.RowIndex].Cells[0].Value.ToString()),
                MagazynName = _focussedMagazynCell.Nazwa,
                SekcjaName = DVGSekcja.Rows[e.RowIndex].Cells["Numer"].Value.ToString(),
                MagazynDGVRowIndex = DGVMagazyny.SelectedRows[0].Index
            };

            _openNewPanelPublisher.Send<SekcjaForm, SekcjaOpen>(clicked, "Magazyny -> Sekcja");
            Close();
        }

        private void BtnAddSekcja_Click(object sender, EventArgs e)
        {
            var dodajSekcjeForm = new DodajSekcjeForm();
            _publisher.Send<DodajSekcjeForm, MagazynDGV>(_focussedMagazynCell);
            dodajSekcjeForm.ShowDialog();
        }

        private void BtnModifySekcja_Click(object sender, EventArgs e)
        {
            var edytujSekcjeForm = new EdytujSekcjeForm();
            _publisher.Send<EdytujSekcjeForm, MagazynDGV>(_focussedMagazynCell);
            edytujSekcjeForm.ShowDialog();
        }

        private void MagazynForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _publisher.Unsubscribe(this);
        }
    }
}
