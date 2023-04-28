using IDEA.App.Formularze.Logistyka.Magazyn.Sekcja;
using IDEA.App.MessageBoxes;
using IDEA.App.Modells;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class MagazynForm : Form, IRequestSubscriber, INotifficationSubscriber
    {
        private readonly CommonPublisher _publisher = CommonPublisher.GetInstance();
        private readonly OpenNewPanelPublisher _openNewPanelPublisher = OpenNewPanelPublisher.GetInstance();

        private readonly MagazynService _magazynService = new MagazynService();
        private readonly SekcjaService _sekcjaService = new SekcjaService();

        private MagazynDGV _focussedMagazynRow = new MagazynDGV();
        private SekcjaDGV _focussedSekcjaRow = new SekcjaDGV();

        private int _foccusedMagazynRowIndex = 0;
        private int _foccusedSekcjaRowIndex = 0;

        public MagazynForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
            InitMagazynGrid();
            MagazynFocusedRow(0);
            InitSekcjaGrid();
            SekcjaFocusedRow(0);
        }

        public void GetData<TMessage>(TMessage message)
        {
            var obj = message as MagazynOpen;
            DGVMagazyny.Rows[obj.MagazynDGVRowIndex].Selected = true;
        }

        public void GetNotification()
        {
            InitMagazynGrid();
            InitSekcjaGrid();
        }

        private void InitMagazynGrid()
        {
            DGVMagazyny.DataSource = _magazynService.DataGridData();
            DGVMagazyny.Columns[0].Visible = false;
            DGVMagazyny.Columns["NrTelefonu"].HeaderText = "Nr telefonu";
            DGVMagazyny.Columns["PowierzchniaRobocza"].HeaderText = "Powierzchnia";
            DGVMagazyny.Columns["CalkowitaZajetoscPowierzchni"].HeaderText = "Zajętość magazynu";
            DGVMagazyny.Rows[_foccusedMagazynRowIndex].Selected = true;
        }

        private void InitSekcjaGrid()
        {
            var dataSource = _sekcjaService.ViewData(_focussedMagazynRow.Id);
            DVGSekcja.DataSource = dataSource;
            DVGSekcja.Columns[0].Visible = false;
            DVGSekcja.Columns["IdMagazyn"].Visible = false;
            DVGSekcja.Columns["PowierzchniaRobocza"].HeaderText = "Powierzchnia";
            DVGSekcja.Columns["TypZasobu"].HeaderText = "Typ zasobu";
            DVGSekcja.Columns["Wysokosc"].HeaderText = "Wysokość";

            if (dataSource.Any())
            DVGSekcja.Rows[_foccusedSekcjaRowIndex].Selected = true;
        }

        private void BtnDodajMagazyn_Click(object sender, EventArgs e)
        {
            var dodajMagazynForm = new DodajMagazynForm();
            dodajMagazynForm.ShowDialog();
        }

        private void BtnModyfikujMagazyn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_focussedMagazynRow.Nazwa))
            {
                CustomMessageBox.ErrorBox("Należy najpierw wybrać magazyn");
                return;
            }

            var edytujMagazynForm = new EdytujMagazynForm();
            _publisher.Send<EdytujMagazynForm, MagazynDGV>(_focussedMagazynRow);
            edytujMagazynForm.ShowDialog();
        }

        private void DGVMagazyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_foccusedMagazynRowIndex == e.RowIndex) return;
            _foccusedMagazynRowIndex = e.RowIndex;
            _foccusedSekcjaRowIndex = 0;
            MagazynFocusedRow(e.RowIndex);
            InitSekcjaGrid();
            if (_sekcjaService.ViewData(_focussedMagazynRow.Id).Any())
            SekcjaFocusedRow(0);
        }

        //m²

        private void MagazynFocusedRow(int rowIndex)
        {
            _focussedMagazynRow.Id = int.Parse(DGVMagazyny.Rows[rowIndex].Cells[0].Value.ToString());
            _focussedMagazynRow.Nazwa = DGVMagazyny.Rows[rowIndex].Cells["Nazwa"].Value.ToString();
            _focussedMagazynRow.NrTelefonu = DGVMagazyny.Rows[rowIndex].Cells["NrTelefonu"].Value.ToString();
            _focussedMagazynRow.PowierzchniaRobocza = double.Parse(DGVMagazyny.Rows[rowIndex].Cells["PowierzchniaRobocza"].Value.ToString());
        }

        private void SekcjaFocusedRow(int rowIndex)
        {
            _focussedSekcjaRow.Id = int.Parse(DVGSekcja.Rows[rowIndex].Cells[0].Value.ToString());
            _focussedSekcjaRow.Numer = DVGSekcja.Rows[rowIndex].Cells["Numer"].Value.ToString();
            _focussedSekcjaRow.PowierzchniaRobocza = double.Parse(DVGSekcja.Rows[rowIndex].Cells["PowierzchniaRobocza"].Value.ToString());
            _focussedSekcjaRow.TypZasobu = DVGSekcja.Rows[rowIndex].Cells["TypZasobu"].Value.ToString();
            _focussedSekcjaRow.Wysokosc = double.Parse(DVGSekcja.Rows[rowIndex].Cells["Wysokosc"].Value.ToString());
        }

        private void DVGSekcja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _foccusedSekcjaRowIndex = e.RowIndex;
            SekcjaFocusedRow(e.RowIndex);
        }

        private void DVGSekcja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clicked = new SekcjaOpen
            {
                Id = int.Parse(DVGSekcja.Rows[e.RowIndex].Cells[0].Value.ToString()),
                MagazynName = _focussedMagazynRow.Nazwa,
                SekcjaName = DVGSekcja.Rows[e.RowIndex].Cells["Numer"].Value.ToString(),
                MagazynDGVRowIndex = DGVMagazyny.SelectedRows[0].Index
            };

            _openNewPanelPublisher.Send<SekcjaForm, SekcjaOpen>(clicked, "Magazyny -> Sekcja");
            Close();
        }

        private void BtnAddSekcja_Click(object sender, EventArgs e)
        {
            var dodajSekcjeForm = new DodajSekcjeForm();
            _publisher.Send<DodajSekcjeForm, MagazynDGV>(_focussedMagazynRow);
            dodajSekcjeForm.ShowDialog();
        }

        private void BtnModifySekcja_Click(object sender, EventArgs e)
        {
            var edytujSekcjeForm = new EdytujSekcjeForm();
            _publisher.Send<EdytujSekcjeForm, ModifySekcja>(new ModifySekcja
            {
                Id = _focussedSekcjaRow.Id,
                Numer = _focussedSekcjaRow.Numer,
                PowierzchniaRoboczaSekcji = _focussedSekcjaRow.PowierzchniaRobocza,
                TypZasobu = _focussedSekcjaRow.TypZasobu,
                Wysokosc = _focussedSekcjaRow.Wysokosc,
                MagazynId = _focussedMagazynRow.Id,
                PowierzchniaRoboczaMagazynu = _focussedMagazynRow.PowierzchniaRobocza
            });

            edytujSekcjeForm.ShowDialog();
        }

        private void MagazynForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _publisher.Unsubscribe(this);
        }
    }
}
