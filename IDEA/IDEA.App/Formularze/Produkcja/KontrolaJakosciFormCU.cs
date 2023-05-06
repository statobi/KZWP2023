using IDEA.Database;
using System;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class KontrolaJakosciFormCU : Form
    {
        private bool flagEdit = false;
        Kontrola_Jakosci_Zamowienia selectedV_Kontrola_Jakosci = new Kontrola_Jakosci_Zamowienia();
        IDEAEntities db = IDEADatabase.GetInstance();

        //Wersja Dodawanie
        public KontrolaJakosciFormCU()
        {
            InitializeComponent();
        }
        //Wersja Edycja
        public KontrolaJakosciFormCU(Kontrola_Jakosci_Zamowienia _selectedV_Kontrola_Jakosci)
        {
            flagEdit = true;
            InitializeComponent();
            selectedV_Kontrola_Jakosci = _selectedV_Kontrola_Jakosci;
            lblKindWindow.Text = "Edytowanie kontroli jakości";
            txtZaakceptowane.Text = selectedV_Kontrola_Jakosci.Zaakcpetowane.ToString();
            txtOdrzucone.Text = selectedV_Kontrola_Jakosci.Odrzucone.ToString();
            dtpData.Text = selectedV_Kontrola_Jakosci.Data.ToString();
            txtUwagi.Text = selectedV_Kontrola_Jakosci.Uwagi;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
           
               
                    //Edycja
                    Kontrola_Jakosci_Zamowienia updateV_Kontrola_Jakosci = db.Kontrola_Jakosci_Zamowienia.First((p => p.ID_Kontrola_Jakosci_Zamowienia == selectedV_Kontrola_Jakosci.ID_Kontrola_Jakosci_Zamowienia));
                    updateV_Kontrola_Jakosci.ID_Sklad_Zamowienia = selectedV_Kontrola_Jakosci.ID_Sklad_Zamowienia;
                    updateV_Kontrola_Jakosci.Zaakcpetowane = int.Parse(txtZaakceptowane.Text);
                    updateV_Kontrola_Jakosci.Odrzucone = int.Parse(txtOdrzucone.Text);
                    updateV_Kontrola_Jakosci.Data = dtpData.Value;
                    updateV_Kontrola_Jakosci.Uwagi = txtUwagi.Text;
                    db.Kontrola_Jakosci_Zamowienia.AddOrUpdate(updateV_Kontrola_Jakosci);
                    db.SaveChanges();

            // //Dodanie nowego klienta
            // V_Kontrola_Jakosci V_Kontrola_JakosciNew = new V_Kontrola_Jakosci();
            // V_Kontrola_JakosciNew.Zaakcpetowane = int.Parse(txtZaakceptowane.Text);
            // V_Kontrola_JakosciNew.Odrzucone = int.Parse(txtOdrzucone.Text);
            //V_Kontrola_JakosciNew.Data_kontroli = DateTime.ParseExact(txtDataKontroli.Text, "dd/MM/yyyy", null);
            // V_Kontrola_JakosciNew.Uwagi = txtUwagi.Text;
            // db.V_Kontrola_Jakosci.Add(V_Kontrola_JakosciNew);
            // //db.SaveChanges();
            
            this.DialogResult = DialogResult.OK;
                this.Close();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AFKlienciCU_Load(object sender, EventArgs e)
        {

        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {

        }

        //Przesuwanie okna myszą
        private Point? lastPoint = null;
        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }
        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (lastPoint.HasValue)
            {
                int deltaX = e.X - lastPoint.Value.X;
                int deltaY = e.Y - lastPoint.Value.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }
        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void KontrolaJakosciFormCU_Load(object sender, EventArgs e)
        {

        }
    }
}
