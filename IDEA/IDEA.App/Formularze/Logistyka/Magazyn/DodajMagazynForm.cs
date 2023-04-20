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
    public partial class DodajMagazynForm : Form
    {
        private readonly MagazynForm _magazynForm;
        public DodajMagazynForm(MagazynForm magazynForm)
        {
            InitializeComponent();
            _magazynForm = magazynForm;
        }

        private void DodajMagazynForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _magazynForm.ShowDialog();
        }
    }
}
