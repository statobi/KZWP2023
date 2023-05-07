using IDEA.App.Enums;
using IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace;
using IDEA.App.MessageBoxes;
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
        private List<MagazynZawartosc> _staged = new List<MagazynZawartosc>();
        private TransportWewnetrznyKonfiguracjaZleceniaInput _input;
        private readonly TransportWewnetrznyKonfiguracjaZleceniaService _service = new TransportWewnetrznyKonfiguracjaZleceniaService();
        private int _selectedIndex = -1;

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
            }
        }

        private void InitCombobox()
        {
            CmbMagazyn.DataSource = _service.GetMagazyny().ToList();
            CmbMagazyn.DisplayMember = "Nazwa";
        }

        private void InitSkladMagazynuDGV()
        {
            DGVSkladMagazynu.DataSource = null;
            DGVSkladMagazynu.DataSource = _magazynZawartoscCollection;
            DGVSkladMagazynu.Columns[0].Visible = false;
            DGVSkladMagazynu.Columns[1].Visible = false;
        }

        private void InitStagedDGV()
        {
            DGVStaged.DataSource = null;
            DGVStaged.DataSource = _staged;
            DGVSkladMagazynu.Columns[0].Visible = false;
            DGVSkladMagazynu.Columns[1].Visible = false;
        }

        private void CmbMagazyn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedIndex == CmbMagazyn.SelectedIndex)
                return;

            if (_staged.Any())
            {
                var dialogResult = CustomMessageBox.WarnBoxBoolean("Czy na pewno chcesz zmienić magazyn?\nZmiana magazynu spowoduje utratę przemiesionego asortymentu.", "Ostrzeżenie");

                if (!dialogResult)
                {
                    CmbMagazyn.SelectedIndex = _selectedIndex;
                    return;
                }
            }

            var idMagazyn = ((MagazynCmb)CmbMagazyn.SelectedValue).IdMagazyn;
            _magazynZawartoscCollection = _service.GetAsortymentFromMagazyn(idMagazyn).ToList();
            InitSkladMagazynuDGV();

            _selectedIndex = CmbMagazyn.SelectedIndex;
            _staged.Clear();
            InitStagedDGV();
        }

        private void BtnAddToStagedSingle_Click(object sender, EventArgs e)
        {
            //if (!_oczegujaceList.Any()) return;
            //var dialog = new DodajPoIlosciForm();

            //var selectedRows = DGVOczekujace.SelectedRows[0];

            //_commonPublisher.Send<DodajPoIlosciForm>(new DodajPoIlosciInput
            //{
            //    Oczekujace = _oczegujaceList[selectedRows.Index],
            //    RowIndex = selectedRows.Index,
            //    StagedStatus = StagedStatus.To
            //});

            //dialog.ShowDialog();
        }

        private void BtnAddToStaged_Click(object sender, EventArgs e)
        {
            _staged.AddRange(GetSelectedItemsOczekujace());

            InitSkladMagazynuDGV();
            InitStagedDGV();
        }

        private void BtnRemoveFromStagedSingle_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveFromStaged_Click(object sender, EventArgs e)
        {
            _magazynZawartoscCollection.AddRange(GetSelectedItemsStaged());

            InitSkladMagazynuDGV();
            InitStagedDGV();
        }

        private void DGVSkladMagazynu_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVSkladMagazynu.SelectedRows.Count > 1)
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

        private List<MagazynZawartosc> GetSelectedItemsOczekujace()
        {
            var selectedItemsFromDataGrid = new List<MagazynZawartosc>();
            var tempCollection = new List<MagazynZawartosc>(_magazynZawartoscCollection);
            var selectedRows = DGVSkladMagazynu.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                var index = selectedRow.Index;
                selectedItemsFromDataGrid.Add(tempCollection[index]);

                _magazynZawartoscCollection.Remove(tempCollection[index]);
            }

            return selectedItemsFromDataGrid;
        }

        private List<MagazynZawartosc> GetSelectedItemsStaged()
        {
            var selectedItemsFromDataGrid = new List<MagazynZawartosc>();
            var tempCollection = new List<MagazynZawartosc>(_staged);
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
                _magazynZawartoscCollection.RemoveAt(dialogOutput.RowIndex);
            else
            {
                var oczekujaceResult = _magazynZawartoscCollection
                .FirstOrDefault(x => x.UfId == dialogOutput.Oczekujace.UfId);

                oczekujaceResult.Ilosc -= dialogOutput.EnteredIlosc;
            }

            if (!_staged.Select(x => x.UfId).Contains(dialogOutput.Oczekujace.UfId))
            {
                _staged.Add(new MagazynZawartosc
                {
                    UfId = dialogOutput.Oczekujace.UfId,
                    IdAsortyment = dialogOutput.Oczekujace.IdAsortyment,
                    Nazwa = dialogOutput.Oczekujace.Nazwa,
                    Ilosc = dialogOutput.EnteredIlosc,
                    TypAsortymentu = dialogOutput.Oczekujace.TypAsortymentu,
                });

                InitSkladMagazynuDGV();
                InitStagedDGV();

                return;
            }

            var stagedResult = _staged
                .FirstOrDefault(x => x.UfId == dialogOutput.Oczekujace.UfId);

            stagedResult.Ilosc += dialogOutput.EnteredIlosc;

            InitSkladMagazynuDGV();
            InitStagedDGV();
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

            if (!_magazynZawartoscCollection.Select(x => x.UfId).Contains(dialogOutput.Oczekujace.UfId))
            {
                _magazynZawartoscCollection.Add(new MagazynZawartosc
                {
                    UfId = dialogOutput.Oczekujace.UfId,
                    IdAsortyment = dialogOutput.Oczekujace.IdAsortyment,
                    Nazwa = dialogOutput.Oczekujace.Nazwa,
                    Ilosc = dialogOutput.EnteredIlosc,
                    TypAsortymentu = dialogOutput.Oczekujace.TypAsortymentu,
                });

                InitSkladMagazynuDGV();
                InitStagedDGV();

                return;
            }

            var stagedResult = _magazynZawartoscCollection
                .FirstOrDefault(x => x.UfId == dialogOutput.Oczekujace.UfId);

            stagedResult.Ilosc += dialogOutput.EnteredIlosc;

            InitSkladMagazynuDGV();
            InitStagedDGV();
        }

        private void TransportWewnetrznyKonfiguracjaZlecenia_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }
    }
}
