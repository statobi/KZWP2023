using IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace;
using IDEA.App.MessageBoxes;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        private List<OczekujaceDGV> _staged = new List<OczekujaceDGV>();
        public OczekujaceForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
            InitCombobox();
        }

        public void GetData(object message)
        {
            if (message is OczekujaceInput messageMapped)
            {
                _input = messageMapped;
                _oczegujaceList = _oczekujaceService.ViewData().ToList();

                InitOczekujaceDataGrid();
            }
        }

        private void InitCombobox()
        {
            var dataSource = _oczekujaceService.GetMagazyny().ToList();
            CmbMagazyn.DataSource = dataSource;
            CmbMagazyn.DisplayMember = "Nazwa";
            CmbMagazyn.ValueMember = "IdMagazyn";
        }


        private void InitOczekujaceDataGrid()
        {
            DGVOczekujace.DataSource = null;
            DGVOczekujace.DataSource = _oczegujaceList;
            //DGVOczekujace.Columns[0].Visible = false;
            DGVOczekujace.Columns["Ilosc"].HeaderText = "Ilość";
            DGVOczekujace.Columns["TypAsortymentu"].HeaderText = "Typ asortymentu";
            DGVOczekujace.Columns["DataOd"].HeaderText = "Data przyjęcia";
        }

        private void InitStagedDataGrid()
        {
            DGVStaged.DataSource = null;
            DGVStaged.DataSource = _staged;
            //DGVStaged.Columns[0].Visible = false;
            DGVStaged.Columns["Ilosc"].HeaderText = "Ilość";
            DGVStaged.Columns["TypAsortymentu"].HeaderText = "Typ asortymentu";
            DGVStaged.Columns["DataOd"].HeaderText = "Data przyjęcia";
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
            var selectedItemsFromDataGrid = GetSelectedItemsOczekujace();

            var checkResult = _oczekujaceService.CheckAssortmentTypeIsRegistered(selectedItemsFromDataGrid.ToArray());

            if(checkResult != null)
            {
                CustomMessageBox.WarnBox("Niektóre pozycje z wybranego asortymentu nie mogą zostać automatycznie przydzielone do magazynu.", "Wymagana akcja");

                _openPanelPublisher.Open<PrzypiszTypZasobuForm>(new PrzypiszTypZasobuInput
                {
                    MagazynDGVRowIndex = _input.MagazynDGVRowIndex,
                    SekcjaDGVRowIndex = _input.SekcjaDGVRowIndex,
                    CheckResult = checkResult
                }, "Magazyny -> Dodanie asortymentu");
            }
        }

        private void BtnAddToStaged_Click(object sender, EventArgs e)
        {
            _staged.AddRange(GetSelectedItemsOczekujace());

            InitOczekujaceDataGrid();
            InitStagedDataGrid();
        }

        private void BtnRemoveFromStaged_Click(object sender, EventArgs e)
        {
            _oczegujaceList.AddRange(GetSelectedItemsStaged());

            InitOczekujaceDataGrid();
            InitStagedDataGrid();
        }

        private List<OczekujaceDGV> GetSelectedItemsOczekujace()
        {
            var selectedItemsFromDataGrid = new List<OczekujaceDGV>();
            var selectedRows = DGVOczekujace.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                var index = selectedRow.Index;
                selectedItemsFromDataGrid.Add(_oczegujaceList[index]);

                _oczegujaceList.RemoveAt(index);
            }

            return selectedItemsFromDataGrid;
        }

        private List<OczekujaceDGV> GetSelectedItemsStaged()
        {
            var selectedItemsFromDataGrid = new List<OczekujaceDGV>();
            var selectedRows = DGVStaged.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                var index = selectedRow.Index;
                selectedItemsFromDataGrid.Add(_staged[index]);

                _staged.RemoveAt(index);
            }

            return selectedItemsFromDataGrid;
        }

        private void NieprzypisaneForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }
    }
}
