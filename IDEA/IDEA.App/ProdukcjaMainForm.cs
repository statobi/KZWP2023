using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class ProdukcjaMainForm : Form
    {
        private InitForm _initForm;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private IconButton currentBtn;


        public ProdukcjaMainForm(InitForm initForm)
        {
            InitializeComponent();
            _initForm = initForm;
            leftBorderBtn = new Panel();
            
            
        }



        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelProdukcja.Controls.Add(childForm);
            panelProdukcja.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ProdukcjaMainForm_Load(object sender, EventArgs e)
        {

        }

        private void ProdukcjaMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _initForm.Show();
        }

        private void btnZarzadzaniaProdukcja_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ZarzadzanieProdukcjaForm());
        }
    }
}
