using IDEA.App.Modells;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using Newtonsoft.Json;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class EdytujSekcjeForm : Form, IRequestSubscriber
    {
        private TypZasobuService _typZasobuService = new TypZasobuService();
        private SekcjaService _sekcjaService = new SekcjaService();
        private CommonPublisher _commonPublisher = CommonPublisher.GetInstance();

        private ModifySekcja _receivedObj = null;

        public EdytujSekcjeForm()
        {
            InitializeComponent();
            InitCmbTypZasobu();
            _commonPublisher.Subscribe(this);
        }

        public void GetData<TMessage>(string message)
        {
            if (typeof(TMessage) == typeof(ModifySekcja))
            {
                _receivedObj = JsonConvert.DeserializeObject<ModifySekcja>(message);
            }

            UpdateView();
        }

        private void InitCmbTypZasobu()
        {
            var typyZasobow = _typZasobuService
            .ViewData()
            .Select(x => x.Nazwa)
            .ToArray();
            CmbTypZasobu.DataSource = typyZasobow;
        }

        private void UpdateView()
        {
            TxbNumer.Text = _receivedObj.Numer;
            TxbPowierzchniaRobocza.Text = _receivedObj.PowierzchniaRoboczaSekcji.ToString();
            TxbWysokosc.Text = _receivedObj.Wysokosc.ToString();
            var comboboxIndex = CmbTypZasobu.FindString(_receivedObj.TypZasobu);
            CmbTypZasobu.SelectedIndex = comboboxIndex;

            UpdateTotalReservedPowierzchniaRobocza();
        }

        private void UpdateTotalReservedPowierzchniaRobocza()
        {
            LblPowierzchniaRobocza.Text = $"{_sekcjaService.TotalReservedPowierzchniaRobocza(_receivedObj.MagazynId, _receivedObj.PowierzchniaRoboczaMagazynu)}m²";
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
