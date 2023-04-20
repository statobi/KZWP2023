using System.Windows.Forms;

namespace IDEA.App
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void btnAF_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            AFMainForm aF= new AFMainForm(this);
            aF.Show();  
            
        }

        private void btnProdukcja_Click(object sender, System.EventArgs e)
        {

        }

        private void btnLogistyka_Click(object sender, System.EventArgs e)
        {

        }

        private void InitForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
