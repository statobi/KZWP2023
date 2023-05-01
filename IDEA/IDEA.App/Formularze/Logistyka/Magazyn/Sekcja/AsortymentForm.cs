using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.Sekcja
{
    public partial class AsortymentForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();
        private readonly OpenPanelPublisher _openPanelPublisher = OpenPanelPublisher.GetInstance();
        private readonly AssortmentListService _assortmentListService = new AssortmentListService();

        private AsortymentListInput _input;
        public AsortymentForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            if(message is AsortymentListInput messageMapped)
            {
                _input = messageMapped;

                InitDGVMaterialy(messageMapped.SekcjaId);
                InitDGVProdukty(messageMapped.SekcjaId);
            }
        }

        private void InitDGVMaterialy(int idSekcja)
        {
            DGVMaterialy.DataSource = _assortmentListService.GetMaterialy(idSekcja);
        }
        
        private void InitDGVProdukty(int idSekcja)
        {
            DGVProdukty.DataSource = _assortmentListService.GetProdukty(idSekcja);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _openPanelPublisher.Open<SekcjaForm>(new AsortymentListOutput
            {

            }, "Magazyny -> Sekcja");

            Close();
        }

        private void AsortymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }
    }
}
