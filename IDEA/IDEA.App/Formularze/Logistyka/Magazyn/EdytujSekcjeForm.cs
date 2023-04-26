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

        private MagazynDGV _receivedMagazyn = null;

        public EdytujSekcjeForm()
        {
            InitializeComponent();
            InitCmbTypZasobu();
            _commonPublisher.Subscribe(this);
        }

        public void GetData<TMessage>(string message)
        {
            if (typeof(TMessage) == typeof(MagazynDGV))
            {
                _receivedMagazyn = JsonConvert.DeserializeObject<MagazynDGV>(message);
            }

            UpdateTotalReservedPowierzchniaRobocza();
        }

        private void InitCmbTypZasobu()
        {
            var typyZasobow = _typZasobuService
            .ViewData()
            .Select(x => x.Nazwa)
            .ToArray();
            CmbTypZasobu.DataSource = typyZasobow;
        }

        private void UpdateTotalReservedPowierzchniaRobocza()
        {
            LblPowierzchniaRobocza.Text = $"{_sekcjaService.TotalReservedPowierzchniaRobocza(_receivedMagazyn)}m²";
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
