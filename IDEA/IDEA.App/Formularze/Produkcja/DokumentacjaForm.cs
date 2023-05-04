using IDEA.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Produkcja
{
    public partial class DokumentacjaForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public DokumentacjaForm()
        {
            InitializeComponent();
            initDgvDokumentacja();
        }
        private void initDgvDokumentacja()
        {
            dgvDokumentacja.DataSource = db.Dokumentacjas.ToList();
            this.dgvDokumentacja.Columns["ID_Dokumentacja"].Visible = false;
            this.dgvDokumentacja.Columns["ID_Rodzaj_Dokumentacja"].Visible = false;
            this.dgvDokumentacja.Columns["ID_Produkt"].Visible = false;
            dgvDokumentacja.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
