using IDEA.App.Formularze.Produkcja;
using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class KontrolaJakosciForm: Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Klient selectedKlient = new Klient();

        public KontrolaJakosciForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initDgwKlienci();
            initDGVZamowienia();
            dgvZamowienia.SelectionChanged += dgvZamowienia_SelectionChanged;
        }

        private void initDgwKlienci()
        {
            dgvKlienci.DataSource = db.V_Kontrola_Jakosci.ToList();
            this.dgvKlienci.Columns["ID_Kontrola_Jakosci_Zamowienia"].Visible = false;
            dgvKlienci.Columns["Numer_skladu_zamowienia"].HeaderText = "Numer skladu zamowienia";
            dgvKlienci.Columns["Nazwa_Produktu"].HeaderText = "Nazwa Produktu";
            dgvKlienci.Columns["Ilosc_w_zamowieniu"].HeaderText = "Ilość w zamówieniu";
            dgvKlienci.Columns["Data_kontroli"].HeaderText = "Data kontroli";
            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //222
        }
        public void initDGVZamowienia()
        {
            dgvZamowienia.DataSource = db.Zlecenia_w_realizacji.ToList();
            this.dgvZamowienia.Columns["ID_Zamowienia_Klienci"].Visible = false;
            dgvZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        private void dgvZamowienia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZamowienia.SelectedRows.Count > 0)
            {
                string numerZamowienia = dgvZamowienia.SelectedRows[0].Cells["Numer_Zamowienia"].Value.ToString();

                foreach (DataGridViewRow row in dgvKlienci.Rows)
                {
                    string numerZamowienia1 = row.Cells["Numer_Zamowienia"].Value.ToString();
                    if (numerZamowienia1 == numerZamowienia)
                    {
                        row.Selected = true;
                        dgvKlienci.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
          
           
        
         
        }


        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            var newKontrolaJakosci = new V_Kontrola_Jakosci();
            db.V_Kontrola_Jakosci.Add(newKontrolaJakosci);

            dgvKlienci.DataSource = null;
            dgvKlienci.DataSource = db.V_Kontrola_Jakosci.ToList();

            dgvKlienci.RowsAdded += (s, ev) =>
            {
                // Set the default values for the new record
                var newRow = dgvKlienci.Rows[ev.RowIndex];
                newRow.Cells["Numer_skladu_zamowienia"].Value = "Nowy numer";
                newRow.Cells["Nazwa_Produktu"].Value = "Nowa nazwa";
                newRow.Cells["Ilosc_w_zamowieniu"].Value = 10;
                newRow.Cells["Data_kontroli"].Value = DateTime.Now;
            };
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKlienci.SelectedRows.Count > 0)
            {
                dgvKlienci.ReadOnly = false;
                dgvKlienci.BeginEdit(true);
                dgvKlienci.CellEndEdit += dgvKlienci_CellEndEdit;
            }

        }
        private void dgvKlienci_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvKlienci.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells["ID_Kontrola_Jakosci_Zamowienia"].Value);
            V_Kontrola_Jakosci k = db.V_Kontrola_Jakosci.Where(x => x.ID_Kontrola_Jakosci_Zamowienia == id).FirstOrDefault();

            if (k != null)
            {
                k.Numer_skladu_zamowienia = Convert.ToInt32(row.Cells["Numer_skladu_zamowienia"].Value);
                k.Nazwa_Produktu = Convert.ToString(row.Cells["Nazwa_Produktu"].Value);
                k.Ilosc_w_zamowieniu = Convert.ToInt32(row.Cells["Ilosc_w_zamowieniu"].Value);
                k.Data_kontroli = Convert.ToDateTime(row.Cells["Data_kontroli"].Value);
                db.SaveChanges();
                dgvKlienci.ReadOnly = true;
                dgvKlienci.CellEndEdit -= dgvKlienci_CellEndEdit;
            }
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?\n" + selectedKlient.Imie + " " + selectedKlient.Nazwisko, "Usuwanie", MessageBoxButtons.YesNo);
    if (dialogResult == DialogResult.Yes)
    {
        if (dgvKlienci.SelectedRows.Count > 0) // sprawdzamy czy została zaznaczona jakaś pozycja w dgvKlienci
        {
            int selectedRowIndex = dgvKlienci.SelectedRows[0].Index; // pobieramy indeks zaznaczonego wiersza
            int id = (int)dgvKlienci.Rows[selectedRowIndex].Cells["ID_Kontrola_Jakosci_Zamowienia"].Value; // pobieramy wartość z kolumny ID_Kontrola_Jakosci_Zamowienia dla zaznaczonego wiersza
            var selectedKontrola = db.Kontrola_Jakosci_Zamowienia.FirstOrDefault(k => k.ID_Kontrola_Jakosci_Zamowienia == id); // pobieramy obiekt Kontrola_Jakosci_Zamowienia o podanym ID
            db.Kontrola_Jakosci_Zamowienia.Remove(selectedKontrola); // usuwamy obiekt Kontrola_Jakosci_Zamowienia z bazy danych
            db.SaveChanges(); // zapisujemy zmiany w bazie danych
            dgvKlienci.Rows.RemoveAt(selectedRowIndex); // usuwamy zaznaczony wiersz z dgvKlienci
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
            string filtr = txtSearch.Text;

            dgvKlienci.DataSource = db.Klients.Where(k =>
               k.Imie.Contains(filtr)
            || k.Nazwisko.Contains(filtr)
            || k.Nazwa_Podmiotu.Contains(filtr)
            || k.NIP.Contains(filtr)
            || k.Adres_Ulica.Contains(filtr)
            || k.Adres_Kod_Pocztowy.Contains(filtr)
            || k.Adres_Miasto.Contains(filtr)
            || k.Telefon.Contains(filtr)
            || k.E_mail.Contains(filtr)).ToList();

            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


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
