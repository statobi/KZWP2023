﻿using IDEA.App.Enums;
using IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace;
using IDEA.App.MessageBoxes;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Database;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class TransportWewnetrznyKonfiguracjaZlecenia : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();
        private readonly OpenPanelPublisher _openPanelPublisher = OpenPanelPublisher.GetInstance();

        private List<MagazynZawartosc> _magazynZawartoscCollection;
        private List<MagazynZawartosc> _staged = new List<MagazynZawartosc>();
        private TransportWewnetrznyKonfiguracjaZleceniaInput _input;
        private readonly TransportWewnetrznyKonfiguracjaZleceniaService _service = new TransportWewnetrznyKonfiguracjaZleceniaService();


        private TransportWewnetrznyPodsumowanieForm _transportWindow;

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
                _magazynZawartoscCollection = _service.GetAsortymentFromMagazyn(2).ToList();

                InitSkladMagazynuDGV();
                InitCombobox();
            }

            if (message is DodajIloscSkladZleceniaOutput dodajIloscSkladZleceniaOutput)
            {
                if (dodajIloscSkladZleceniaOutput.StagedStatus == StagedStatus.From)
                    RemoveFormStagedSingle(dodajIloscSkladZleceniaOutput);

                if (dodajIloscSkladZleceniaOutput.StagedStatus == StagedStatus.To)
                    AddToStagedSingle(dodajIloscSkladZleceniaOutput);
            }
        }

        private void InitCombobox()
        {
            CmbMagazyn.DataSource = _service.GetMagazyny().ToList();
            CmbMagazyn.DisplayMember = nameof(MagazynCmb.Nazwa);

            CmbPojazd.DataSource = _service.GetPojazdy().ToList();
            CmbPojazd.DisplayMember = nameof(PojazdCmb.Nazwa);

            CmbKierowca.DataSource = _service.GetPracownicy().ToList();
            CmbKierowca.DisplayMember = nameof(PracownicyCmb.ImieNazwisko);
        }

        private void InitSkladMagazynuDGV()
        {
            DGVSkladMagazynu.DataSource = null;
            DGVSkladMagazynu.DataSource = _magazynZawartoscCollection;
            DGVSkladMagazynu.Columns[0].Visible = false;
            DGVSkladMagazynu.Columns[1].Visible = false;
            DGVSkladMagazynu.Columns[2].Visible = false;
            DGVSkladMagazynu.Columns["Ilosc"].HeaderText = "Ilość";
            DGVSkladMagazynu.Columns["TypAsortymentu"].HeaderText = "Typ asortymentu";
        }

        private void InitStagedDGV()
        {
            DGVStaged.DataSource = null;
            DGVStaged.DataSource = _staged;
            DGVStaged.Columns[0].Visible = false;
            DGVStaged.Columns[1].Visible = false;
            DGVStaged.Columns[2].Visible = false;
            DGVStaged.Columns["Ilosc"].HeaderText = "Ilość";
            DGVStaged.Columns["TypAsortymentu"].HeaderText = "Typ asortymentu";
        }

        private void CmbMagazyn_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idMagazyn = ((MagazynCmb)CmbMagazyn.SelectedValue).IdMagazyn;

            if (_staged.Any())
            {
                var dialogResult = CustomMessageBox.WarnBoxBoolean("Czy na pewno chcesz zmienić magazyn?\nZmiana magazynu spowoduje utratę przemiesionego asortymentu.", "Ostrzeżenie");

                if (dialogResult)
                {
                    _magazynZawartoscCollection = _service.GetAsortymentFromMagazyn(idMagazyn).ToList();
                    InitSkladMagazynuDGV();

                    _staged.Clear();
                    InitStagedDGV();
                }
                else
                {
                    CmbMagazyn.SelectedIndex = _selectedIndex;
                }

                return;
            }

            _magazynZawartoscCollection = _service.GetAsortymentFromMagazyn(idMagazyn).ToList();
            _selectedIndex = CmbMagazyn.SelectedIndex;
            InitSkladMagazynuDGV();
        }

        private void BtnAddToStagedSingle_Click(object sender, EventArgs e)
        {
            if (!_magazynZawartoscCollection.Any()) return;
            var dialog = new DodajIloscSkladZleceniaForm();

            var selectedRows = DGVSkladMagazynu.SelectedRows[0];

            _commonPublisher.Send<DodajIloscSkladZleceniaForm>(new DodajIloscSkladZleceniaInput
            {
                Zawartosc = _magazynZawartoscCollection[selectedRows.Index],
                RowIndex = selectedRows.Index,
                StagedStatus = StagedStatus.To
            });

            dialog.ShowDialog();
        }

        private void BtnAddToStaged_Click(object sender, EventArgs e)
        {
            _staged.AddRange(GetSelectedItemsOczekujace());

            InitSkladMagazynuDGV();
            InitStagedDGV();
        }

        private void BtnRemoveFromStagedSingle_Click(object sender, EventArgs e)
        {
            if (!_staged.Any()) return;

            var dialog = new DodajPoIlosciForm();

            var selectedRows = DGVStaged.SelectedRows[0];

            _commonPublisher.Send<DodajIloscSkladZleceniaForm>(new DodajIloscSkladZleceniaInput
            {
                Zawartosc = _staged[selectedRows.Index],
                RowIndex = selectedRows.Index,
                StagedStatus = StagedStatus.From
            });

            dialog.ShowDialog();
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _openPanelPublisher.Open<TransportWewnetrznyForm>(new TransportWewnetrznyInput
            {
                SelectedRowIndex = _input.SelectedRowIndex
            }, "Transport wewnętrzny");
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

        private void AddToStagedSingle(DodajIloscSkladZleceniaOutput dialogOutput)
        {
            if (dialogOutput.Zawartosc.Ilosc == dialogOutput.EnteredIlosc)
                _magazynZawartoscCollection.RemoveAt(dialogOutput.RowIndex);
            else
            {
                var oczekujaceResult = _magazynZawartoscCollection
                .FirstOrDefault(x => x.UfId == dialogOutput.Zawartosc.UfId);

                oczekujaceResult.Ilosc -= dialogOutput.EnteredIlosc;
            }

            if (!_staged.Select(x => x.UfId).Contains(dialogOutput.Zawartosc.UfId))
            {
                _staged.Add(new MagazynZawartosc
                {
                    IdRozlozenie = dialogOutput.Zawartosc.IdRozlozenie,
                    UfId = dialogOutput.Zawartosc.UfId,
                    IdAsortyment = dialogOutput.Zawartosc.IdAsortyment,
                    Nazwa = dialogOutput.Zawartosc.Nazwa,
                    Ilosc = dialogOutput.EnteredIlosc,
                    TypAsortymentu = dialogOutput.Zawartosc.TypAsortymentu,
                    Polka = dialogOutput.Zawartosc.Polka
                });

                InitSkladMagazynuDGV();
                InitStagedDGV();

                return;
            }

            var stagedResult = _staged
                .FirstOrDefault(x => x.UfId == dialogOutput.Zawartosc.UfId);

            stagedResult.Ilosc += dialogOutput.EnteredIlosc;

            InitSkladMagazynuDGV();
            InitStagedDGV();
        }

        private void RemoveFormStagedSingle(DodajIloscSkladZleceniaOutput dialogOutput)
        {
            if (dialogOutput.Zawartosc.Ilosc == dialogOutput.EnteredIlosc)
                _staged.RemoveAt(dialogOutput.RowIndex);
            else
            {
                var oczekujaceResult = _staged
                .FirstOrDefault(x => x.UfId == dialogOutput.Zawartosc.UfId);

                oczekujaceResult.Ilosc -= dialogOutput.EnteredIlosc;
            }

            if (!_magazynZawartoscCollection.Select(x => x.UfId).Contains(dialogOutput.Zawartosc.UfId))
            {
                _magazynZawartoscCollection.Add(new MagazynZawartosc
                {
                    IdRozlozenie = dialogOutput.Zawartosc.IdRozlozenie,
                    UfId = dialogOutput.Zawartosc.UfId,
                    IdAsortyment = dialogOutput.Zawartosc.IdAsortyment,
                    Nazwa = dialogOutput.Zawartosc.Nazwa,
                    Ilosc = dialogOutput.EnteredIlosc,
                    TypAsortymentu = dialogOutput.Zawartosc.TypAsortymentu,
                    Polka = dialogOutput.Zawartosc.Polka
                });

                InitSkladMagazynuDGV();
                InitStagedDGV();

                return;
            }

            var stagedResult = _magazynZawartoscCollection
                .FirstOrDefault(x => x.UfId == dialogOutput.Zawartosc.UfId);

            stagedResult.Ilosc += dialogOutput.EnteredIlosc;

            InitSkladMagazynuDGV();
            InitStagedDGV();
        }

        private void TransportWewnetrznyKonfiguracjaZlecenia_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!_staged.Any()) return;

            var idPojazd = ((PojazdCmb)CmbPojazd.SelectedValue).IdPojazd;

            var weightCheck = _service.PojazdWeightCheck(idPojazd, _staged);

            if (!weightCheck)
            {
                CustomMessageBox.ErrorBox("Przekroczono dopuszczalną wagę pojazdu");
                return;
            }

            var dimensionCheck = _service.PojazdDimensionCheck(idPojazd, _staged);

            if (!dimensionCheck)
            {
                CustomMessageBox.ErrorBox("Wybrane materiały przekraczają gabaryty pojazdu");
                return;
            }

            if (_transportWindow is null)
            {
                _transportWindow = new TransportWewnetrznyPodsumowanieForm();
                _transportWindow.Show();
            }
            _commonPublisher.Send<TransportWewnetrznyPodsumowanieForm>(new TransportWewnetrznyPodsumowanieInput
            {
                Zawartosc = _staged,
                IdMagazynKoncowy = 1,
                IdMagazynPoczatkowy = ((MagazynCmb)CmbMagazyn.SelectedValue).IdMagazyn,
                IdPojazd = idPojazd,
                IdPracownik = ((PracownicyCmb)CmbKierowca.SelectedValue).IdPracownik,
                Kierowca = ((PracownicyCmb)CmbKierowca.SelectedValue).ImieNazwisko,
                MagazynKoncowy = "Magazyn produkcji",
                MagazynPoczatkowy = ((MagazynCmb)CmbMagazyn.SelectedValue).Nazwa,
                Pojazd = ((PojazdCmb)CmbPojazd.SelectedValue).Nazwa,
            });

            _staged.Clear();
            InitStagedDGV();
        }
    }
}
