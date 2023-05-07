using IDEA.App.Formularze.Produkcja;
using IDEA.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class KontrolaJakosciForm : Form
    {
        IDEAEntities db = new IDEAEntities();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Kontrola_Jakosci_Zamowienia selectedV_Kontrola_Jakosci = new Kontrola_Jakosci_Zamowienia();

        public KontrolaJakosciForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            // toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initDgwKlienci();
            initDGVZamowienia();
            //dgvZamowienia.SelectionChanged += dgvZamowienia_SelectionChanged;
        }
        //private void refreshDgwKlienci()
        //{
        //    // Usunięcie źródła danych
        //    dgvKlienci.DataSource = null;

        //    // Ponowne załadowanie danych
        //    List<V_Kontrola_Jakosci> listaKontroliJakosci = db.V_Kontrola_Jakosci.ToList();

        //    // Przypisanie zaktualizowanej listy danych do kontrolki DataGridView
        //    dgvKlienci.DataSource = listaKontroliJakosci;

        //    // Odświeżenie kontrolki DataGridView
        //    dgvKlienci.Refresh();
        //    dgvKlienci.Invalidate();
        //}
        private void initDgwKlienci()
        {
           // dgvKlienci.DataSource = null;
            dgvKlienci.DataSource = db.V_Kontrola_Jakosci.ToList();
            dgvKlienci.Columns["ID_Kontrola_Jakosci_Zamowienia"].Visible = false;
            dgvKlienci.Columns["Numer_skladu_zamowienia"].HeaderText = "Numer skladu zamowienia";
            dgvKlienci.Columns["Nazwa_Produktu"].HeaderText = "Nazwa Produktu";
            dgvKlienci.Columns["Ilosc_w_Kontroli"].HeaderText = "Ilość w Kontroli";
            dgvKlienci.Columns["Data_kontroli"].HeaderText = "Data kontroli";
            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        public void initDGVZamowienia()
        {
            dgvZamowienia.DataSource = db.Zlecenia_w_realizacji.ToList();
            this.dgvZamowienia.Columns["ID_Zamowienia_Klienci"].Visible = false;
            dgvZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        //private void dgvZamowienia_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvZamowienia.SelectedRows.Count > 0)
        //    {
        //        string numerZamowienia = dgvZamowienia.SelectedRows[0].Cells["Numer_Zamowienia"].Value.ToString();

        //        foreach (DataGridViewRow row in dgvKlienci.Rows)
        //        {
        //            string numerZamowienia1 = row.Cells["Numer_Zamowienia"].Value.ToString();
        //            if (numerZamowienia1 == numerZamowienia)
        //            {
        //                row.Selected = true;
        //                dgvKlienci.FirstDisplayedScrollingRowIndex = row.Index;
        //                break;
        //            }
        //        }
        //    }
        //}
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            selectedV_Kontrola_Jakosci.ID_Kontrola_Jakosci_Zamowienia = int.Parse(dgvKlienci.Rows[e.RowIndex].Cells[0].Value.ToString());

            var query = from p in db.Kontrola_Jakosci_Zamowienia
                        where p.ID_Kontrola_Jakosci_Zamowienia == selectedV_Kontrola_Jakosci.ID_Kontrola_Jakosci_Zamowienia
                        select p;
            foreach (Kontrola_Jakosci_Zamowienia p in query)
            {
                selectedV_Kontrola_Jakosci.ID_Kontrola_Jakosci_Zamowienia = p.ID_Kontrola_Jakosci_Zamowienia;
                selectedV_Kontrola_Jakosci.ID_Sklad_Zamowienia = p.ID_Sklad_Zamowienia;
                selectedV_Kontrola_Jakosci.Zaakcpetowane = p.Zaakcpetowane;
                selectedV_Kontrola_Jakosci.Odrzucone= p.Odrzucone;
                selectedV_Kontrola_Jakosci.Data = p.Data;
                selectedV_Kontrola_Jakosci.Uwagi= p.Uwagi;


            }

        }


        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //refreshDgwKlienci();

            //using (KontrolaJakosciFormCU aF = new KontrolaJakosciFormCU())
            // {
            //     aF.ShowDialog();
            //   initDgwKlienci();
            //  }
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                using (KontrolaJakosciFormCU aF = new KontrolaJakosciFormCU(selectedV_Kontrola_Jakosci))
                {
                    aF.ShowDialog();
                    initDgwKlienci();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego zamówienia!");
            }
            //dgvKlienci.DataSource = db.V_Kontrola_Jakosci.ToList();
           // dgvKlienci.Refresh();
            //RestartForm();
           // initDgwKlienci();
        }


        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.BringToFront();
            childForm.Show();
        }
        private void RestartForm()
        {

            Form currentForm = this.ActiveControl as Form;

            if (currentForm != null)
            {
                currentForm.Close();
            }

            //PlanowanieProcesyForm planowanieProcesyForm = ;

            OpenChildForm(new PlanowanieProcesyForm());

        }


        //usun
        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?\n" + selectedV_Kontrola_Jakosci.ID_Kontrola_Jakosci_Zamowienia + " " + selectedV_Kontrola_Jakosci.ID_Kontrola_Jakosci_Zamowienia, "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgvKlienci.SelectedRows.Count > 0) // sprawdzamy czy została zaznaczona jakaś pozycja w dgvKlienci
                {
                    int selectedRowIndex = dgvKlienci.SelectedRows[0].Index; // pobieramy indeks zaznaczonego wiersza
                    int id = (int)dgvKlienci.Rows[selectedRowIndex].Cells["ID_Kontrola_Jakosci_Zamowienia"].Value; // pobieramy wartość z kolumny ID_Kontrola_Jakosci_Zamowienia dla zaznaczonego wiersza
                    var selectedKontrola = db.Kontrola_Jakosci_Zamowienia.FirstOrDefault(k => k.ID_Kontrola_Jakosci_Zamowienia == id); // pobieramy obiekt Kontrola_Jakosci_Zamowienia o podanym ID
                    db.Kontrola_Jakosci_Zamowienia.Remove(selectedKontrola); // usuwamy obiekt Kontrola_Jakosci_Zamowienia z bazy danych
                    db.SaveChanges(); // zapisujemy zmiany w bazie danych
                    initDgwKlienci();
                    initDgwKlienci();
                    MessageBox.Show("Usunięto pomyślnie."); // wyświetlamy komunikat o sukcesie usuwania
                }
                else
                {
                    MessageBox.Show("Nie zaznaczono żadnej pozycji."); // wyświetlamy komunikat o niezaznaczeniu żadnej pozycji
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //kod
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKlienci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKonczenieProdukcji_Click(object sender, EventArgs e)
        {
            using (ProdukcjaKonczenieProdukcjiForm pkpf = new ProdukcjaKonczenieProdukcjiForm())
            {
                pkpf.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvZamowienia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}