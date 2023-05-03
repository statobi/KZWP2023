using IDEA.App.Enums;
using IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace;
using IDEA.App.MessageBoxes;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
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

            if (message is DodajPoIlosciOutput dodajPoIlosciOutput)
            {
                if (dodajPoIlosciOutput.StagedStatus == StagedStatus.From)
                    RemoveFormStagedSingle(dodajPoIlosciOutput);

                if (dodajPoIlosciOutput.StagedStatus == StagedStatus.To)
                    AddToStagedSingle(dodajPoIlosciOutput);
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
            DGVOczekujace.Columns[0].Visible = false;
            DGVOczekujace.Columns[1].Visible = false;
            DGVOczekujace.Columns[2].Visible = false;
            DGVOczekujace.Columns["Ilosc"].HeaderText = "Ilość";
            DGVOczekujace.Columns["TypAsortymentu"].HeaderText = "Typ asortymentu";
            DGVOczekujace.Columns["DataOd"].HeaderText = "Data przyjęcia";
        }

        private void InitStagedDataGrid()
        {
            DGVStaged.DataSource = null;
            DGVStaged.DataSource = _staged;
            DGVStaged.Columns[0].Visible = false;
            DGVStaged.Columns[1].Visible = false;
            DGVStaged.Columns[2].Visible = false;
            DGVStaged.Columns["Ilosc"].HeaderText = "Ilość";
            DGVStaged.Columns["TypAsortymentu"].HeaderText = "Typ asortymentu";
            DGVStaged.Columns["DataOd"].HeaderText = "Data przyjęcia";
        }

        #region Event handlers

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
            var selectedItemsFromDataGrid = _staged;

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

        private void DGVOczekujace_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVOczekujace.SelectedRows.Count > 1)
            {
                BtnAddToStagedSingle.Enabled = false;
                return;
            }

            BtnAddToStagedSingle.Enabled = true;
        }

        private void DGVStaged_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVStaged.SelectedRows.Count > 1)
            {
                BtnRemoveFromStagedSingle.Enabled = false;
                return;
            }

            BtnRemoveFromStagedSingle.Enabled = true;
        }

        private void BtnAddToStagedSingle_Click(object sender, EventArgs e)
        {
            if (!_oczegujaceList.Any()) return;
            var dialog = new DodajPoIlosciForm();

            var selectedRows = DGVOczekujace.SelectedRows[0];

            _commonPublisher.Send<DodajPoIlosciForm>(new DodajPoIlosciInput
            {
                Oczekujace = _oczegujaceList[selectedRows.Index],
                RowIndex = selectedRows.Index,
                StagedStatus = StagedStatus.To
            });

            dialog.ShowDialog();
        }

        private void BtnRemoveFromStagedSingle_Click(object sender, EventArgs e)
        {
            if (!_staged.Any()) return;

            var dialog = new DodajPoIlosciForm();

            var selectedRows = DGVStaged.SelectedRows[0];

            _commonPublisher.Send<DodajPoIlosciForm>(new DodajPoIlosciInput
            {
                Oczekujace = _staged[selectedRows.Index],
                RowIndex = selectedRows.Index,
                StagedStatus = StagedStatus.From
            });

            dialog.ShowDialog();
        }

        #endregion

        private List<OczekujaceDGV> GetSelectedItemsOczekujace()
        {
            var selectedItemsFromDataGrid = new List<OczekujaceDGV>();
            var tempCollection = new List<OczekujaceDGV>(_oczegujaceList);
            var selectedRows = DGVOczekujace.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                var index = selectedRow.Index;
                selectedItemsFromDataGrid.Add(tempCollection[index]);

                _oczegujaceList.Remove(tempCollection[index]);
            }

            return selectedItemsFromDataGrid;
        }

        private List<OczekujaceDGV> GetSelectedItemsStaged()
        {
            var selectedItemsFromDataGrid = new List<OczekujaceDGV>();
            var tempCollection = new List<OczekujaceDGV>(_staged);
            var selectedRows = DGVStaged.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                var index = selectedRow.Index;
                selectedItemsFromDataGrid.Add(tempCollection[index]);

                _staged.Remove(tempCollection[index]);
            }

            return selectedItemsFromDataGrid;
        }

        private void AddToStagedSingle(DodajPoIlosciOutput dialogOutput)
        {
            if (dialogOutput.Oczekujace.Ilosc == dialogOutput.EnteredIlosc)
                _oczegujaceList.RemoveAt(dialogOutput.RowIndex);
            else
            {
                var oczekujaceResult = _oczegujaceList
                .FirstOrDefault(x => x.UfId == dialogOutput.Oczekujace.UfId);

                oczekujaceResult.Ilosc -= dialogOutput.EnteredIlosc;
            }

            if (!_staged.Select(x => x.UfId).Contains(dialogOutput.Oczekujace.UfId))
            {
                _staged.Add(new OczekujaceDGV
                {
                    Id = dialogOutput.Oczekujace.Id,
                    UfId = dialogOutput.Oczekujace.UfId,
                    IdAsortyment = dialogOutput.Oczekujace.IdAsortyment,
                    Nazwa = dialogOutput.Oczekujace.Nazwa,
                    Ilosc = dialogOutput.EnteredIlosc,
                    DataOd = dialogOutput.Oczekujace.DataOd,
                    TypAsortymentu = dialogOutput.Oczekujace.TypAsortymentu,
                });

                InitOczekujaceDataGrid();
                InitStagedDataGrid();

                return;
            }

            var stagedResult = _staged
                .FirstOrDefault(x => x.UfId == dialogOutput.Oczekujace.UfId);

            stagedResult.Ilosc += dialogOutput.EnteredIlosc;

            InitOczekujaceDataGrid();
            InitStagedDataGrid();
        }

        private void RemoveFormStagedSingle(DodajPoIlosciOutput dialogOutput)
        {
            if (dialogOutput.Oczekujace.Ilosc == dialogOutput.EnteredIlosc)
                _staged.RemoveAt(dialogOutput.RowIndex);
            else
            {
                var oczekujaceResult = _staged
                .FirstOrDefault(x => x.UfId == dialogOutput.Oczekujace.UfId);

                oczekujaceResult.Ilosc -= dialogOutput.EnteredIlosc;
            }

            if (!_oczegujaceList.Select(x => x.UfId).Contains(dialogOutput.Oczekujace.UfId))
            {
                _oczegujaceList.Add(new OczekujaceDGV
                {
                    Id = dialogOutput.Oczekujace.Id,
                    UfId = dialogOutput.Oczekujace.UfId,
                    IdAsortyment = dialogOutput.Oczekujace.IdAsortyment,
                    Nazwa = dialogOutput.Oczekujace.Nazwa,
                    Ilosc = dialogOutput.EnteredIlosc,
                    DataOd = dialogOutput.Oczekujace.DataOd,
                    TypAsortymentu = dialogOutput.Oczekujace.TypAsortymentu,
                });

                InitOczekujaceDataGrid();
                InitStagedDataGrid();

                return;
            }

            var stagedResult = _oczegujaceList
                .FirstOrDefault(x => x.UfId == dialogOutput.Oczekujace.UfId);

            stagedResult.Ilosc += dialogOutput.EnteredIlosc;

            InitOczekujaceDataGrid();
            InitStagedDataGrid();
        }

        private void NieprzypisaneForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }
    }
}
