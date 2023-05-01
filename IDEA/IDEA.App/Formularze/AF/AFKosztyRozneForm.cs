using IDEA.App.Formularze.AF;
using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFKosztyRozneForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Koszty_Rozne selectedKoszty_Rozne = new Koszty_Rozne();

        public AFKosztyRozneForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy Koszt");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj Koszt");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń Koszt");
            initDgwKosztyRozne();
        }

        private void initDgwKosztyRozne()
        {
            var query = from kr in db.Koszty_Rozne
                        join rkr in db.Rodzaj_Koszty_Rozne on kr.ID_Rodzaj_Koszty_Rozne equals rkr.ID_Rodzaj_Koszty_Rozne
                        join p in db.Pracownicies on kr.ID_Pracownicy equals p.ID_Pracownicy
                        join f in db.Fakturies on kr.ID_Faktury equals f.ID_Faktury
                        orderby kr.Data descending
                        select new
                        {
                            kr.ID_Koszty_Rozne,
                            RodzajKosztyRozne = rkr.Nazwa,
                            kr.ID_Rodzaj_Koszty_Rozne,
                            Pracownik = p.Imie + " " + p.Nazwisko,
                            kr.Kwota_Netto,
                            kr.Kwota_Brutto,
                            kr.ID_Faktury,
                            kr.Data,
                        };



            // przypisanie wyniku kwerendy do DataSource dla DataGridView
            dgvKosztyRozne.DataSource = query.ToList();

            this.dgvKosztyRozne.Columns["ID_Koszty_Rozne"].Visible = false;
            dgvKosztyRozne.Columns["ID_Rodzaj_Koszty_Rozne"].Visible = false;
            dgvKosztyRozne.Columns["RodzajKosztyRozne"].HeaderText = "Rodzaj Kosztu";


        }
        private void AFKosztyRozneForm_Load(object sender, EventArgs e)
        {
            dgvKosztyRozne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvKosztyRozne.ClearSelection();
        }
        private void dgvKosztyRozne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = dgvKosztyRozne.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvKosztyRozne.Rows[index];

            selectedKoszty_Rozne.ID_Koszty_Rozne = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from kr in db.Koszty_Rozne
                        where kr.ID_Koszty_Rozne == selectedKoszty_Rozne.ID_Koszty_Rozne
                        select kr;
            foreach (Koszty_Rozne kr in query)
            {
                selectedKoszty_Rozne.ID_Rodzaj_Koszty_Rozne = kr.ID_Rodzaj_Koszty_Rozne;
                selectedKoszty_Rozne.ID_Pracownicy = kr.ID_Pracownicy;
                selectedKoszty_Rozne.Kwota_Netto = kr.Kwota_Netto;
                selectedKoszty_Rozne.Kwota_Brutto = kr.Kwota_Brutto;
                selectedKoszty_Rozne.ID_Faktury = kr.ID_Faktury;
                selectedKoszty_Rozne.Data = kr.Data;

            }




      
            //Wersja Edycja

            }

            private void txtSearch_TextChanged(object sender, EventArgs e)
            {
                string filtr = txtSearch.Text;

                dgvKosztyRozne.DataSource = db.Klients.Where(k =>
                   k.Imie.Contains(filtr)
                || k.Nazwisko.Contains(filtr)
                || k.Nazwa_Podmiotu.Contains(filtr)
                || k.NIP.Contains(filtr)
                || k.Adres_Ulica.Contains(filtr)
                || k.Adres_Kod_Pocztowy.Contains(filtr)
                || k.Adres_Miasto.Contains(filtr)
                || k.Telefon.Contains(filtr)
                || k.E_mail.Contains(filtr)).ToList();

                dgvKosztyRozne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            }

        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openKlientEdition(sender);
            using (AFKosztyRozneCU aF = new AFKosztyRozneCU())
            {
                aF.ShowDialog();
                initDgwKosztyRozne();
            }
        }

        private void iBtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {

        }
    }


    } 

