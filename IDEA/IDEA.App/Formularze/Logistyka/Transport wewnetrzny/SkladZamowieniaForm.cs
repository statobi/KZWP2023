using IDEA.App.Models;
using IDEA.Logistyka.Observer;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class SkladZamowieniaForm : Form, IRequestSubscriber
    {

        private CommonPublisher _commonPublisher = CommonPublisher.GetInstance();
        public SkladZamowieniaForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            if(message is SkladZamowieniaInput input)
            {
                DGVSkladZamowienia.DataSource = input.SkladZlecenieMagazynowe.ToList();
                DGVSkladZamowienia.Columns[0].Visible = false;
                DGVSkladZamowienia.Columns[1].Visible = false;
                DGVSkladZamowienia.Columns[2].Visible = false;
            }
        }

        private void SkladZamowieniaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }
    }
}
