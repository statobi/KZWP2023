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
                StatusPakowania.ID_Zamowienia_Klienci = ZamowieniedoPakowania.ID_Zamowienia_Klienci;
                StatusPakowania.ID_Status_Zamowienia = 4;
                StatusPakowania.Data = dateWysylki.Value;
                db.ZamowieniaKlienci_StatusZamowienia.Add(StatusPakowania);
                db.SaveChanges();
                MessageBox.Show("Przekazano do Pakowania");
            }
            else if (Zapytaniewyslania == DialogResult.No)
            {

            }
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
    }
}
