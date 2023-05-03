using IDEA.App.Formularze.Logistyka.Magazyn.Nieprzypisane;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Enums;
using IDEA.Logistyka.Observer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace
{
    public partial class PrzypiszTypZasobuForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();
        private readonly OpenPanelPublisher _openPanelPublisher = OpenPanelPublisher.GetInstance();

        private PrzypiszTypZasobuInput _input;
        public PrzypiszTypZasobuForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
           if (message is PrzypiszTypZasobuInput mapped)
           {
                _input = mapped;

                InitDGVMaterial();
                InitDGVProdukt();
           }
        }

        private void InitDGVMaterial()
        {
            DGVMaterialy.DataSource = _input.CheckResult.Where(x => x.TypAsortymentu == TypAsortymentu.Material).ToList();
            DGVMaterialy.Columns[0].Visible = false;
            DGVMaterialy.Columns["TypAsortymentu"].Visible = false;
            DGVMaterialy.Columns["IdRodzajMaterialu"].Visible = false;
            DGVMaterialy.Columns["Nazwa"].HeaderText = "Nazwa materiału";
            DGVMaterialy.Columns["RodzajMaterialu"].HeaderText = "Rodzaj materialu";
        }

        private void InitDGVProdukt()
        {
            DGVProdukty.DataSource = _input.CheckResult.Where(x => x.TypAsortymentu == TypAsortymentu.Produkt).ToList();
            DGVMaterialy.Columns[0].Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _openPanelPublisher.Open<OczekujaceForm>(new OczekujaceInput
            {
                MagazynDGVRowIndex = _input.MagazynDGVRowIndex,
                SekcjaDGVRowIndex =  _input.SekcjaDGVRowIndex
            }, "Magazyny -> Oczekujące");

            Close();
        }

        private void PrzypiszTypZasobuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }

    }
}
