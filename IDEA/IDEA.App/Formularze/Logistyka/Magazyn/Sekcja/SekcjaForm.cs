using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.Sekcja
{
    public partial class SekcjaForm : Form, ISubscriber
    {
        private readonly Publisher _publisher = Publisher.GetInstance();
        private readonly PolkaService _polkaService = new PolkaService();
        private readonly AsortymentService _asortymentService = new AsortymentService();

        private SekcjaOpenForm _messageObj;
        private PolkaDGV _focussedMagazynCell = new PolkaDGV();

        public SekcjaForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
        }

        public void GetData(string message = null)
        {
            _messageObj = JsonConvert.DeserializeObject<SekcjaOpenForm>(message);
            LblHeader.Text = _messageObj.SekcjaName;
            LblSubheader.Text = _messageObj.MagazynName;

            InitPolkaGrid();
            AssignFoccusedRowToObj(0);
            InitAsortymentGrid();
        }

        private void InitPolkaGrid()
        {
            var asdads = _polkaService.ViewData(_messageObj.Id);
            DGVPolka.DataSource = _polkaService.ViewData(_messageObj.Id);
            DGVPolka.Columns[0].Visible = false;
            DGVPolka.Columns["IdSekcja"].Visible = false;
            DGVPolka.Columns["Szerokosc"].HeaderText = "Szerokość";
            DGVPolka.Columns["Wysokosc"].HeaderText = "Wysokość";
            DGVPolka.Columns["Glebokosc"].HeaderText = "Głębokość";
            DGVPolka.Columns["Udzwig"].HeaderText = "Udźwig";
        }

        private void InitAsortymentGrid()
        {
            var asdads = _asortymentService.ViewData(_focussedMagazynCell.Id);
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
            Close();
        }

        private void SekcjaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _publisher.Unsubscribe(this);
        }
    }
}
