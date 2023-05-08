using IDEA.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Produkcja
{
    public partial class ProdukcjaKonczenieProdukcjiForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();

        Zamowienia_Klienci ZamowieniedoPakowania = new Zamowienia_Klienci();
        ZamowieniaKlienci_StatusZamowienia StatusPakowania = new ZamowieniaKlienci_StatusZamowienia();
        public ProdukcjaKonczenieProdukcjiForm()
        {
            InitializeComponent();
            InitZakonczeniaProukcji();
            initDatePickers();
            initWyborPracownicy();
        }


        private void InitZakonczeniaProukcji()
        {
            
            dgvZakonczenie.DataSource = db.V_Zakonczenie_Produkcji.ToList();
            this.dgvZakonczenie.Columns["ID_Zamowienia_Klienci"].Visible = false;
            
            dgvZakonczenie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void iBtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void initDatePickers()
        {
            dateWysylki.CustomFormat = "yyyy-MM-dd";
            dateWysylki.Format = DateTimePickerFormat.Custom;
            dateWysylki.Value = DateTime.Today;
        }


        private void Pakowanie()
        {
            DialogResult Zapytaniewyslania = MessageBox.Show("Czy chcesz zmienić status zamówienia nr." + ZamowieniedoPakowania.Numer + " na gotowe do wysyłki? ", "Dodawanie", MessageBoxButtons.YesNo);
            if (Zapytaniewyslania == DialogResult.Yes)
            {
                Dodawaniezleceniamagazynowego();
                StatusPakowania.ID_Zamowienia_Klienci = ZamowieniedoPakowania.ID_Zamowienia_Klienci;
                StatusPakowania.ID_Status_Zamowienia = 4;
                StatusPakowania.Data = dateWysylki.Value;
                db.ZamowieniaKlienci_StatusZamowienia.Add(StatusPakowania);
                db.SaveChanges();
                
                MessageBox.Show("Przekazano do Pakowania");
                InitZakonczeniaProukcji();
            }
            else if (Zapytaniewyslania == DialogResult.No)
            {

            }
        }
        private void Dodawaniezleceniamagazynowego()
        {
            var listaCalegoSkladuZamowienia = db.Sklad_Zamowienia
                .Where(x =>x.ID_Zamowienia_Klienci == ZamowieniedoPakowania.ID_Zamowienia_Klienci)
                .Select(x =>x.ID_Sklad_Zamowienia) .ToList();

            string WybranyPracownik = cbPracownik.Text;
            var IDPracwonika = db.Pracownicies
            .Where(x => x.Nazwisko == WybranyPracownik)
            .Select(x => x.ID_Pracownicy)
            .FirstOrDefault();
       
            





            for (int i = 0; i < listaCalegoSkladuZamowienia.Count; i++)
            {
                Zlecenie_Magazynowe Zlecenie = new Zlecenie_Magazynowe();
                var zleceniekolejne = db.Zlecenie_Magazynowe
                    .Max(x => x.ID_Zlecenie_Magazynowe);
                zleceniekolejne = zleceniekolejne + 1; 
                Zlecenie.ID_Zlecenie_Magazynowe = zleceniekolejne;
                Zlecenie.ID_Sklad_Zamowienia = listaCalegoSkladuZamowienia[0];
                Zlecenie.ID_Pracownicy = IDPracwonika;
                Zlecenie.ID_Magazyn = 1;
                Zlecenie.Data = dateWysylki.Value;
                Zlecenie.CzyZlecenieStale = "Nie";
                Zlecenie.Zwrot = true;
                db.Zlecenie_Magazynowe.Add(Zlecenie);
                 db.SaveChanges();




                //var zlecenieprodukt = db.Zlecenie_Magazynowe
                //    .Where(x => x.ID_Sklad_Zamowienia== Zlecenie.ID_Sklad_Zamowienia && x.CzyZlecenieStale == Zlecenie.CzyZlecenieStale && x.ID_Pracownicy == Zlecenie.ID_Pracownicy && x.Data == Zlecenie.Data && x.Zwrot == Zlecenie.Zwrot)
                //    .Select(x => x.ID_Zlecenie_Magazynowe)
                //    .FirstOrDefault();
                int zlecenieprodukt = Zlecenie.ID_Zlecenie_Magazynowe;
                int idsklad = listaCalegoSkladuZamowienia[i];

                var dodanieproduktu =  db.Sklad_Zamowienia
                .Where(x => x.ID_Sklad_Zamowienia == idsklad)
                .Select(x => x.ID_Produkt).ToList();
                for (int z = 0; z < dodanieproduktu.Count; z++)
                {
                    Sklad_Zlecenie_Produkt NoweZlecenieProdukt = new Sklad_Zlecenie_Produkt();
                    NoweZlecenieProdukt.ID_Zlecenie_Magazynowe = zlecenieprodukt;
                    NoweZlecenieProdukt.ID_Produkt = dodanieproduktu[z];

                    int idprod = dodanieproduktu[z];
                    var iloscproduktow = db.Sklad_Zamowienia
                        .Where(x => x.ID_Sklad_Zamowienia == Zlecenie.ID_Sklad_Zamowienia && x.ID_Produkt == idprod)
                        .Select(x =>x.Ilosc)
                        .FirstOrDefault();
                    NoweZlecenieProdukt.IloscProduktow= iloscproduktow;
                    NoweZlecenieProdukt.Data = dateWysylki.Value;
                    NoweZlecenieProdukt.Zwrot = "Tak";
                    NoweZlecenieProdukt.Uwagi = "brak";
                    NoweZlecenieProdukt.CzyZlecenieStale = "Nie";
                    db.Sklad_Zlecenie_Produkt.Add(NoweZlecenieProdukt);
                    db.SaveChanges();

                    RozlozeniePolki_Produkty nowerozlozenie = new RozlozeniePolki_Produkty();
                    nowerozlozenie.ID_Polka = 13;
                    nowerozlozenie.ID_Produkt= idprod;
                    nowerozlozenie.ID_Pracownik = IDPracwonika;
                    nowerozlozenie.Ilosc = iloscproduktow;
                    nowerozlozenie.DataOd = dateWysylki.Value;



                }


            }
            dgvZakonczenie.Update();
            dgvZakonczenie.Refresh();

        }

        private void dgvZakonczenie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ZamowieniedoPakowania.ID_Zamowienia_Klienci = int.Parse(dgvZakonczenie.Rows[e.RowIndex].Cells[0].Value.ToString());
            ZamowieniedoPakowania.Numer = dgvZakonczenie.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnPakowanie_Click(object sender, EventArgs e)
        {
            Pakowanie();
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
        private void ProdukcjaKonczenieProdukcjiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
