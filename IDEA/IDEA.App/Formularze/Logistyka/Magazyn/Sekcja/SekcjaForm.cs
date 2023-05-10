using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.Sekcja
{
    public partial class SekcjaForm : Form, IRequestSubscriber, INotifficationSubscriber
    {
        private readonly CommonPublisher _publisher = CommonPublisher.GetInstance();
        private readonly OpenPanelPublisher _openNewPanelPublisher = OpenPanelPublisher.GetInstance();
        private readonly PolkaService _polkaService = new PolkaService();
        private readonly AsortymentService _asortymentService = new AsortymentService();

        private SekcjaOpen _messageObj;
        private PolkaDGV _focussedMagazynCell = new PolkaDGV();

        private List<PolkaDGV> _polkaDGVs;

        public SekcjaForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            if(message is SekcjaOpen sekcjaOpenMapped)
            {
                _messageObj = sekcjaOpenMapped;
                LblHeader.Text = sekcjaOpenMapped.SekcjaName;
                LblSubheader.Text = sekcjaOpenMapped.MagazynName;
            }

            InitPolkaGrid();
            AssignFoccusedRowToObj(0);
            InitAsortymentGrid();
        }

        public void GetNotification()
        {
            InitPolkaGrid();
        }

        private void InitPolkaGrid()
        {
            DGVPolka.DataSource = null;
            _polkaDGVs = new List<PolkaDGV>(_polkaService.ViewData(_messageObj.Id));
            DGVPolka.DataSource = _polkaDGVs;
            DGVPolka.Columns[0].Visible = false;
            DGVPolka.Columns["IdSekcja"].Visible = false;
            DGVPolka.Columns["Szerokosc"].HeaderText = "Szerokość";
            DGVPolka.Columns["Wysokosc"].HeaderText = "Wysokość";
            DGVPolka.Columns["Glebokosc"].HeaderText = "Głębokość";
            DGVPolka.Columns["Udzwig"].HeaderText = "Udźwig";
        }

        private void InitAsortymentGrid()
        {
            DGVAsortyment.DataSource = _asortymentService.ViewData(_focussedMagazynCell.Id);
            DGVAsortyment.Columns[0].Visible = false;
            DGVAsortyment.Columns["IdPracownik"].Visible = false;
            DGVAsortyment.Columns["IdPolka"].Visible = false;
            DGVAsortyment.Columns["TypAsortymentu"].HeaderText = "Typ asortymentu";
            DGVAsortyment.Columns["EmailPracownika"].HeaderText = "Pracownik";
            DGVAsortyment.Columns["Ilosc"].HeaderText = "Ilość";
        }

        private void DGVPolka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignFoccusedRowToObj(e.RowIndex);

            InitAsortymentGrid();
        }

        private void AssignFoccusedRowToObj(int rowIndex)
        {
            _focussedMagazynCell.Id = int.Parse(DGVPolka.Rows[rowIndex].Cells[0].Value.ToString());
            _focussedMagazynCell.Numer = DGVPolka.Rows[rowIndex].Cells["Numer"].Value.ToString();
            _focussedMagazynCell.Szerokosc = double.Parse(DGVPolka.Rows[rowIndex].Cells["Szerokosc"].Value.ToString());
            _focussedMagazynCell.Wysokosc = double.Parse(DGVPolka.Rows[rowIndex].Cells["Wysokosc"].Value.ToString());
            _focussedMagazynCell.Glebokosc = double.Parse(DGVPolka.Rows[rowIndex].Cells["Glebokosc"].Value.ToString());
            _focussedMagazynCell.IdSekcja = int.Parse(DGVPolka.Rows[rowIndex].Cells["IdSekcja"].Value.ToString());
        }

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            _openNewPanelPublisher.Open<MagazynForm>(new MagazynOpen
            {
                MagazynDGVRowIndex = _messageObj.MagazynDGVRowIndex,
                SekcjaDGVRowIndex = _messageObj.SekcjaDGVRowIndex
            }, "Magazyny");
            Close();
        }

        private void SekcjaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _publisher.Unsubscribe(this);
        }

        private void BtnAssortmentList_Click(object sender, System.EventArgs e)
        {
            _openNewPanelPublisher.Open<AsortymentForm>(new AsortymentListInput
            {
                SekcjaId = _messageObj.Id,
                MagazynName = _messageObj.MagazynName,
                SekcjaName= _messageObj.SekcjaName,
                SekcjaDGVRowIndex = _messageObj.SekcjaDGVRowIndex,
                MagazynDGVRowIndex = _messageObj.MagazynDGVRowIndex
            }, "Magazyny -> Asortyment");

            Close();
        }

        private void BtnDodajMagazyn_Click(object sender, System.EventArgs e)
        {
            var index = DGVPolka.SelectedRows[0].Index;
            var polka = _polkaDGVs[index];
            var dialog = new DodajPolkaForm();
            _publisher.Send<DodajPolkaForm>(new DodajPolkaInput
            {
                Dlugosc = polka.Glebokosc,
                IdSekcja = polka.IdSekcja,
                Nazwa = polka.Numer,
                Nosnosc = polka.Obciazenie,
                Szerokosc = polka.Szerokosc,
                Wysokosc = polka.Wysokosc,
            });
            dialog.ShowDialog();
        }
    }
}
