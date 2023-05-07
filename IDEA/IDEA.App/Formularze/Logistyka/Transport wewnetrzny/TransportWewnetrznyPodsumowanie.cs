using IDEA.App.Models;
using IDEA.Logistyka.Observer;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class TransportWewnetrznyPodsumowanieForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();
        public TransportWewnetrznyPodsumowanieForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            if (message is TransportWewnetrznyPodsumowanieInput)
            {

            }
        }

        private void TransportWewnetrznyPodsumowanie_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);

        }
    }
}
