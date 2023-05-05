using IDEA.App.Models;
using IDEA.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class ZleceniaMagazynoweForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Klient selectedKlient = new Klient();
        int idKliknietyPrroces;
        int iloscwprocesie;

        bool FlagaZezwólnaOtwarcie = false;
        bool FlagaZezwólnaZamkniecie = false;
        int idzlecenia;
        int idskladu;


        public ZleceniaMagazynoweForm()
        {  
           
            InitializeComponent();
            initWyborPracownicy(); 
            initDgwObecneProcesy();
            InitdgvMagazynProdukcja();
            InitPowracajace();
            InitMaterialycb();
            AddColumnHeaders();

        }

        private void InitPowracajace()
        {
            cbpowr.Items.Add("Tak");
            cbpowr.Items.Add("Nie");
            cbzwrot.Items.Add("Tak");
            cbzwrot.Items.Add("Nie");
        }

        private void InitMaterialycb()
        {
            var materialy = db.Materials
                .Select(x => x.Nazwa).ToList();

            cbmaterial.DataSource= materialy;
            cbmaterial.SelectedIndex= -1;
        }


        private void initWyborPracownicy()
        {
            //cbPracownik.DataSource = null;
            //cbPracownik.Text= string.Empty;
            //cbPracownik.Items.Clear();
            var WyborPracownika = db.V_Operatorzy_Maszyn
                    .Select(s => s.Nazwisko).ToList();
            cbPracownik.DataSource = WyborPracownika;
            //cbPracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPracownik.SelectedIndex = -1;

        }

        private void initDgwObecneProcesy()
        {
            var ObecneProcesy = db.Proces
                .Where(x => x.Data_Rzeczywistego_Rozpoczecia == null && x.Data_Rzeczywistego_Zakonczenia == null)
                .Select(x => new ObecneProcesy
                {
                    ID_Proces= x.ID_Proces,
                    Ilosc = x.Ilosc,
                    Nazwa_Procesu = x.Nazwa_Procesu.Nazwa,
                    Numer_Skladu_Zamowienia = x.ID_Sklad_Zamowienia,
                    Numer_Zamowienia = x.Sklad_Zamowienia.Zamowienia_Klienci.Numer


                })
                .ToList();
                
            dgvObecneProcesy.DataSource = ObecneProcesy;
            dgvObecneProcesy.Columns["ID_Proces"].Visible = false;
            dgvObecneProcesy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
        }

        private void InitdgvMagazynProdukcja()
        {
            var materialynaMagazynie = db.Sekcjas
                .Where(x => x.ID_Magazyn == 1)
                .SelectMany(x => x.Polkas)
                .SelectMany(x => x.RozlozeniePolki_Materialy)
                .Select(x => new MaterialywMagazynie
                {
                    ID_Material = x.ID_Material,
                    Ilosc = x.Ilosc,
                    Nazwa_Materialu = x.Material.Nazwa,
                    Opis = x.Material.Opis
                })
                .GroupBy(x => x.ID_Material)
                .Select(g => new
                {
                    ID_Material = g.Key,
                    Ilosc = g.Sum(x => x.Ilosc),
                    Nazwa_Materialu = g.FirstOrDefault().Nazwa_Materialu,
                    Opis = g.FirstOrDefault().Opis
                })
                .ToList();

            dgvMagazynProdukcja.DataSource= materialynaMagazynie;
            dgvMagazynProdukcja.Columns["ID_Material"].Visible = false;
        }

        private void Zapotrzebowanie()
        {
            var potrzebneMaterialy = db.Proces
                .Where(x => x.ID_Proces == idKliknietyPrroces)
                .Select(x => x.Nazwa_Procesu)
                .SelectMany(x => x.Proces_Technologiczny)
                .SelectMany(x => x.Proces_Technologiczny_Material)
                .Select(x => new MaterialydoProcesu 
                { 
                ID_Material= x.ID_Material,
                Ilosc = x.Ilosc * iloscwprocesie ,
                Nazwa_Materialu = x.Material.Nazwa
                })
                .ToList();

            var materialynaMagazynie = db.Sekcjas
                .Where(x => x.ID_Magazyn == 1)
                .SelectMany(x => x.Polkas)
                .SelectMany(x => x.RozlozeniePolki_Materialy)
                .Select(x => new MaterialywMagazynie
                {
                    ID_Material = x.ID_Material,
                    Ilosc = x.Ilosc,
                    Nazwa_Materialu = x.Material.Nazwa,
                    Opis = x.Material.Opis
                })
                .GroupBy(x => x.ID_Material)
                .Select(g => new
                {
                    ID_Material = g.Key,
                    Ilosc = g.Sum(x => x.Ilosc),
                    Nazwa_Materialu = g.FirstOrDefault().Nazwa_Materialu,
                    Opis = g.FirstOrDefault().Opis
                })
                .ToList();

            var zapotrzebowanie = from p in potrzebneMaterialy
                                  join m in materialynaMagazynie on p.ID_Material equals m.ID_Material into joinResult
                                  from m in joinResult.DefaultIfEmpty()
                                  where m == null || p.Ilosc > m.Ilosc
                                  select new { p.ID_Material, NazwaMaterialu = p.Nazwa_Materialu, IloscWMagazynie = m == null ? 0 : m.Ilosc, IloscPotrzebna = p.Ilosc };

            dgvMaterialyBrakujace.DataSource = zapotrzebowanie.ToList();
            dgvMaterialyBrakujace.Columns["ID_Material"].Visible = false;
        }

        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvObecneProcesy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idKliknietyPrroces = int.Parse(dgvObecneProcesy.Rows[e.RowIndex].Cells[0].Value.ToString());
            iloscwprocesie = int.Parse(dgvObecneProcesy.Rows[e.RowIndex].Cells[4].Value.ToString());
            Zapotrzebowanie();
            idskladu = int.Parse(dgvObecneProcesy.Rows[e.RowIndex].Cells[2].Value.ToString());
        }


        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openKlientEdition(sender);
            
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
           

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //string filtr = txtSearch.Text;

            
            dgvObecneProcesy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void dgvKlienci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbPracownik_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbPracownik.Text == null)
            //{
            //    btnOtwZlec.Enabled= false;
            //}
            //else
            //{
            //    btnOtwZlec.Enabled = true;
            //}
        }
        private void Zezwol()
        {
            cbPracownik.Enabled = true;
            cbmaterial.Enabled = true;
            cbpowr.Enabled = true;
            dtpData.Enabled = true;
            cbzwrot.Enabled = true;
            tbuwagi.Enabled = true;
            txtilosc.Enabled= true;
            btnZamkZlec.Enabled = true;
            cbPracownik.Enabled= true;
            btndodajdoListy.Enabled = true;
            BtnDelete.Enabled = true;
        }
        private void btnOtwZlec_Click(object sender, EventArgs e)
        {
            Zezwol();
            
            idzlecenia = CreateNewZlecenieMagazynowe().ID_Zlecenie_Magazynowe;


        }

        private void AddColumnHeaders()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Numer Zlecenia Magazynowe";
            dataGridView1.Columns[1].Name = "ID_Material";
            dataGridView1.Columns["ID_Material"].Visible= false;
            dataGridView1.Columns[2].Name = "Nazwa_Materialu";
            dataGridView1.Columns[3].Name = "Ilość";
        }

        private Zlecenie_Magazynowe CreateNewZlecenieMagazynowe()
        {
            // pobieramy najwyższy dotychczasowy numer ID_Zlecenia_Magazynowe z bazy danych lub listy obiektów
            var highestId = db.Zlecenie_Magazynowe
                .Max(x => x.ID_Zlecenie_Magazynowe); ;

            // tworzymy nowy obiekt ZlecenieMagazynowe i przypisujemy mu nowy unikalny numer ID_Zlecenia_Magazynowe
            Zlecenie_Magazynowe zlecenieMagazynowe = new Zlecenie_Magazynowe();
            zlecenieMagazynowe.ID_Zlecenie_Magazynowe = highestId + 1;

            return zlecenieMagazynowe;
        }
        private void DodajMaterialDoZamowienia(int idzlecenia)
        {
            string nazwaMaterialu = cbmaterial.SelectedItem.ToString();
            int ilosc = int.Parse(txtilosc.Text);


            // znajdujemy ID_Material odpowiadające wybranej nazwie materiału
            int idMaterialu = db.Materials
                .Where(x => x.Nazwa == nazwaMaterialu)
                .Select(x => x.ID_Material)
                .FirstOrDefault();

            // tworzymy nowy obiekt ListaZamowieniaProdukcja i uzupelniamy go danymi
            ListaZamowieniaProdukcja noweZamowienie = new ListaZamowieniaProdukcja();
            noweZamowienie.ID_Zlecenia_Magazynowe = idzlecenia;
            noweZamowienie.ID_Material = idMaterialu;
            noweZamowienie.Nazwa_Materialu = nazwaMaterialu;
            noweZamowienie.Ilosc = ilosc;

            // dodajemy nowy obiekt do listy ListaZamowieniaProdukcja
            //ListaZamowieniaProdukcja.Add(noweZamowienie);

            // dodajemy nowy rekord do DataGridView
            dataGridView1.Rows.Add(
                noweZamowienie.ID_Zlecenia_Magazynowe,
                noweZamowienie.ID_Material,
                noweZamowienie.Nazwa_Materialu,
                noweZamowienie.Ilosc
            );
        }

        private void btndodajdoListy_Click(object sender, EventArgs e)
        {
            DodajMaterialDoZamowienia(idzlecenia);
        }

        private void btnZamkZlec_Click(object sender, EventArgs e)
        {
            if (dgvObecneProcesy.SelectedRows.Count > 0)
            {
            DodanieZamowienia();
            ClearDataGridView();
            Zamknij();

              
            }
            else
            {
                MessageBox.Show("Nie wybrano Procesu.");
            }
          
        }

        private void Zamknij()
        {
            cbPracownik.Enabled = false;
            cbmaterial.Enabled = false;
            cbpowr.Enabled = false;
            dtpData.Enabled = false;
            cbzwrot.Enabled = false;
            tbuwagi.Enabled = false;
            txtilosc.Enabled = false;
            btnZamkZlec.Enabled = false;
            cbPracownik.Enabled = false;
            btndodajdoListy.Enabled = false;
            BtnDelete.Enabled = false;
        }


        private void DodanieZamowienia()
        {

                // Tworzenie nowego obiektu ZlecenieMagazynowe i przypisanie mu właściwości
                Zlecenie_Magazynowe zlecenieMagazynowe = new Zlecenie_Magazynowe();
                zlecenieMagazynowe.ID_Zlecenie_Magazynowe = idzlecenia;
                zlecenieMagazynowe.ID_Sklad_Zamowienia = idskladu;

                string WybranyPracownik = cbPracownik.Text;
                var IDPracwonika = db.Pracownicies
                .Where(x => x.Nazwisko == WybranyPracownik)
                .Select(x => x.ID_Pracownicy)
                .FirstOrDefault();

                zlecenieMagazynowe.ID_Pracownicy = IDPracwonika;
                zlecenieMagazynowe.Data = dtpData.Value.Date;
                zlecenieMagazynowe.CzyZlecenieStale = cbpowr.Text;

                if (cbzwrot.Text == "Tak")
                {
                    zlecenieMagazynowe.Zwrot = true;
                }
                else if (cbzwrot.Text == "Nie")
                {
                    zlecenieMagazynowe.Zwrot = false;
                }
                else
                {
                    MessageBox.Show("Nie wybrałeś zwrotu");
                return;
                }

                zlecenieMagazynowe.Uwagi = tbuwagi.Text;

                // Dodawanie nowego obiektu do bazy danych
                db.Zlecenie_Magazynowe.Add(zlecenieMagazynowe);
                db.SaveChanges();

                // Pobieranie ID nowo dodanego obiektu
                int idZleceniaMagazynowe = zlecenieMagazynowe.ID_Zlecenie_Magazynowe;

                // Dodawanie rekordów do tabeli Sklad_Zlecenie_Magazynowe
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Tworzenie nowego obiektu Sklad_Zlecenie_Magazynowe i przypisanie mu właściwości
                    Sklad_Zlecenie_Magazynowe skladZlecenieMagazynowe = new Sklad_Zlecenie_Magazynowe();
                    skladZlecenieMagazynowe.ID_Zlecenie_Magazynowe = idzlecenia;
                    skladZlecenieMagazynowe.ID_Material = Convert.ToInt32(row.Cells["ID_Material"].Value);
                    if (row.Cells["ID_Material"].Value == null)
                    {
                        break;
                    }
                    skladZlecenieMagazynowe.Data = dtpData.Value.Date; ;
                    skladZlecenieMagazynowe.CzyZlecenieStale = cbpowr.Text;
                    skladZlecenieMagazynowe.Zwrot = cbzwrot.Text;
                    skladZlecenieMagazynowe.Uwagi = tbuwagi.Text;
                    skladZlecenieMagazynowe.IloscMaterialow = Convert.ToInt32(row.Cells["Ilość"].Value);

                    // Dodawanie nowego obiektu do bazy danych
                    db.Sklad_Zlecenie_Magazynowe.Add(skladZlecenieMagazynowe);
                }

                db.SaveChanges();
         

        }
        private void ClearDataGridView()
        {
            dataGridView1.Rows.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            UsuwanieZListy();
        }

        private void UsuwanieZListy()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz indeks wybranego wiersza
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Usuń wybrany wiersz z DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Nie wybrano wiersza do usunięcia.");
            }
        }


    }
}
