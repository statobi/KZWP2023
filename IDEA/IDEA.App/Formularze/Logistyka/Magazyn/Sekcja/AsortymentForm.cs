using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Linq;
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
            DGVMaterialy.DataSource = _assortmentListService.GetMaterialy(idSekcja).ToList();
            DGVMaterialy.Columns["Ilosc"].HeaderText = "Ilość";
            DGVMaterialy.Columns["DataOd"].HeaderText = "Data dodania";
            DGVMaterialy.Columns["Polka"].HeaderText = "Numer półki";
        }

        private void InitDGVProdukty(int idSekcja)
        {
            DGVProdukty.DataSource = _assortmentListService.GetProdukty(idSekcja).ToList();
            DGVProdukty.Columns["Ilosc"].HeaderText = "Ilość";
            DGVProdukty.Columns["DataOd"].HeaderText = "Data dodania";
            DGVProdukty.Columns["Polka"].HeaderText = "Numer półki";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _openPanelPublisher.Open<SekcjaForm>(new SekcjaOpen
            {
                Id = _input.SekcjaId,
                MagazynName = _input.MagazynName,
                SekcjaName = _input.SekcjaName,
                MagazynDGVRowIndex = _input.MagazynDGVRowIndex,
                SekcjaDGVRowIndex = _input.SekcjaDGVRowIndex
            }, "Magazyny -> Sekcja");

            Close();
        }

        private void AsortymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }
    }
}
