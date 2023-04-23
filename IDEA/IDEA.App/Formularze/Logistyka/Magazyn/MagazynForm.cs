using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Magazyny;
using IDEA.Logistyka.Obserwator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class MagazynForm : Form, ISubscriber
    {
        private readonly IPublisher _publisher = Publisher.GetInstance();
        private readonly MagazynService _magazynService = new MagazynService();
        public MagazynForm()
        {
            InitializeComponent();
            _publisher.Zasubskrybuj(this);
            InitGrid();
        }

        public void ZaktualizujWidok()
        {
            DGVMagazyny.DataSource = _magazynService.DataGridData();
        }

        private void InitGrid()
        {
            DGVMagazyny.DataSource = _magazynService.DataGridData();
            DGVMagazyny.Columns[0].Visible = false;
            DGVMagazyny.Columns["NrTelefonu"].HeaderText = "Nr telefonu";
            DGVMagazyny.Columns["PowierzchniaRobocza"].HeaderText = "Powierzchnia";
            DGVMagazyny.Columns["CalkowitaZajetoscPowierzchni"].HeaderText = "Zajętość magazynu";
        }

        private void BtnDodajMagazyn_Click(object sender, EventArgs e)
        {
            var dodajMagazynForm = new DodajMagazynForm();
            dodajMagazynForm.ShowDialog();
        }
    }
}
