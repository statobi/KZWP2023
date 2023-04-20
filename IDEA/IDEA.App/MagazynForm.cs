using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class MagazynForm : Form
    {
        public MagazynForm()
        {
            InitializeComponent();
        }

        private void BtnDodajMagazyn_Click(object sender, EventArgs e)
        {
            Hide();
            var dodajMagazynForm = new DodajMagazynForm(this);
            dodajMagazynForm.ShowDialog();
        }
    }
}
