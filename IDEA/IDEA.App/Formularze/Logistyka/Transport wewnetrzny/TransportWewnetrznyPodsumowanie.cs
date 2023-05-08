using IDEA.App.Models;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class TransportWewnetrznyPodsumowanieForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();
        private List<TransportDGV> _transporty = new List<TransportDGV>();
        private List<MagazynZawartoscTransport> _sklad = new List<MagazynZawartoscTransport>();

        private readonly TransportWewnetrznyKonfiguracjaZleceniaService _service = new TransportWewnetrznyKonfiguracjaZleceniaService();

        private int _lastId;

        private int _clickedIndex;

        public TransportWewnetrznyPodsumowanieForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            if (message is TransportWewnetrznyPodsumowanieInput input)
            {
                _transporty.Add(new TransportDGV
                {
                    Id = _lastId,
                    Data = DateTime.Now,
                    IdKierowca = input.IdPracownik,
                    IdMagazynPoczatkowy = input.IdMagazynPoczatkowy,
                    IdMagazynKoncowy = input.IdMagazynKoncowy,
                    IdPojazd = input.IdPojazd,
                    Kierowca = input.Kierowca,
                    MagazynPoczatkowy = input.MagazynPoczatkowy,
                    MagazynKoncowy = input.MagazynKoncowy,
                    Pojazd = input.Pojazd,
                });

                _sklad.Add(new MagazynZawartoscTransport
                {
                    IdTransport = _lastId,
                    Zawartosc = new List<MagazynZawartosc>(input.Zawartosc),
                });

                InitTransportyDGV();
                InitSkladDGV();
                _lastId++;
            }
        }

        private void InitTransportyDGV()
        {
            DGVTransporty.DataSource = null;
            DGVTransporty.DataSource = _transporty;
            DGVTransporty.Columns[0].Visible = false;
            DGVTransporty.Columns[1].Visible = false;
            DGVTransporty.Columns[2].Visible = false;
            DGVTransporty.Columns[3].Visible = false;
            DGVTransporty.Columns[4].Visible = false;
        }

        private void InitSkladDGV()
        {
            DGVSklad.DataSource = null;
            var dataSource = _sklad.Where(x => x.IdTransport == _clickedIndex).SelectMany(x => x.Zawartosc).ToList();
            DGVSklad.DataSource = dataSource;
            DGVSklad.Columns[0].Visible = false;
            DGVSklad.Columns[1].Visible = false;
            DGVSklad.Columns[2].Visible = false;
        }

        private void DGVTransporty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _clickedIndex = DGVTransporty.SelectedRows[0].Index;
            InitSkladDGV();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var data = _sklad.SelectMany(x => x.Zawartosc);
            _service.AddAsortyment(1, data);
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void TransportWewnetrznyPodsumowanie_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);

        }

    }
}
