using IDEA.App.Models;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class TransportWewnetrznyKonfiguracjaZlecenia : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();

        private List<MagazynZawartosc> _magazynZawartoscCollection;
        private TransportWewnetrznyKonfiguracjaZleceniaInput _input;
        private readonly TransportWewnetrznyKonfiguracjaZleceniaService _service = new TransportWewnetrznyKonfiguracjaZleceniaService();

        public TransportWewnetrznyKonfiguracjaZlecenia()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            if (message is TransportWewnetrznyKonfiguracjaZleceniaInput input)
            {
                _input = input;

                InitCombobox();
                //InitSkladMagazynuDGV(1);
            }
        }

        private void InitCombobox()
        {
            CmbMagazyn.DataSource = _service.GetMagazyny().ToList();
            CmbMagazyn.DisplayMember = "Nazwa";
        }

        private void InitSkladMagazynuDGV(int idMagazyn)
        {
            DGVSkladMagazynu.DataSource = null;
            DGVSkladMagazynu.DataSource = _service.GetAsortymentFromMagazyn(idMagazyn).ToList();
            DGVSkladMagazynu.Columns[0].Visible = false;
            DGVSkladMagazynu.Columns[1].Visible = false;
        }

        private void CmbMagazyn_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idMagazyn = ((MagazynCmb)CmbMagazyn.SelectedValue).IdMagazyn;
            InitSkladMagazynuDGV(idMagazyn);
        }

        private void TransportWewnetrznyKonfiguracjaZlecenia_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }
    }
}
