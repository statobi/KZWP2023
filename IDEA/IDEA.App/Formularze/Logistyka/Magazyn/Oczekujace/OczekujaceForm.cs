using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.Nieprzypisane
{
    public partial class OczekujaceForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();
        private readonly OpenPanelPublisher _openPanelPublisher = OpenPanelPublisher.GetInstance();
        private readonly OczekujaceService _oczekujaceService = new OczekujaceService();

        private OczekujaceInput _input;
        private List<OczekujaceDGV> _oczegujaceList;
        public OczekujaceForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            if (message is OczekujaceInput messageMapped)
            {
                _input = messageMapped;
                _oczegujaceList = _oczekujaceService.ViewData().ToList();

                InitDataGrid();
            }
        }

        private void InitDataGrid()
        {
            DGVOczekujace.DataSource = _oczegujaceList;
            DGVOczekujace.Columns[0].Visible = false;
            DGVOczekujace.Columns["Ilosc"].HeaderText = "Ilość";
            DGVOczekujace.Columns["TypAsortymentu"].HeaderText = "Typ asortymentu";
            DGVOczekujace.Columns["DataOd"].HeaderText = "Data przyjęcia";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _openPanelPublisher.Open<MagazynForm>(new MagazynOpen
            {
                MagazynDGVRowIndex = _input.MagazynDGVRowIndex,
                SekcjaDGVRowIndex = _input.SekcjaDGVRowIndex
            }, "Magazyny");

            Close();
        }
        private void BtnArrange_Click(object sender, EventArgs e)
        {
            var selectedItemsFromDataGrid = new List<OczekujaceDGV>();
            var selectedRows = DGVOczekujace.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                var index = selectedRow.Index;
                selectedItemsFromDataGrid.Add(_oczegujaceList[index]);
            }

            var ads = _oczekujaceService.CheckAssortmentTypeIsRegistered(selectedItemsFromDataGrid);
        }

        private void NieprzypisaneForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }
    }
}
