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
    public partial class MaszynyCU : Form
    {

        private bool flagEdit = false;
        Maszyny selectedMaszyny = new Maszyny();
        IDEAEntities db = IDEADatabase.GetInstance();

        public MaszynyCU()
        {
            InitializeComponent();
        }

        private void lblImie_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
        }

        private void MaszynyCU_Load(object sender, EventArgs e)
        {

        }
    }
}
