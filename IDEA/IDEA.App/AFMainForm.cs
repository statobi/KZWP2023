using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFMainForm : Form

    {
        private InitForm _initForm;
        public AFMainForm(InitForm initForm)
        {
            
            InitializeComponent();
            _initForm = initForm;
        }

        private void AFMainForm_Load(object sender, EventArgs e)
        {

        }

        private void AFMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _initForm.Show();
        }
    }
}
