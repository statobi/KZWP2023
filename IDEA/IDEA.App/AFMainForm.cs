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

using FontAwesome.Sharp;


namespace IDEA.App
{
    public partial class AFMainForm : Form

    {
        //Okno initForm by można było je pokazać
        private InitForm _initForm;

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public AFMainForm(InitForm initForm)
        {
            
            InitializeComponent();
            _initForm = initForm;
            leftBorderBtn= new Panel();
            leftBorderBtn.Size = new Size(7, 30);
            panelMenu.Controls.Add(leftBorderBtn);

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(172, 126, 241);
            public static Color color3 = Color.FromArgb(172, 126, 241);
            public static Color color4 = Color.FromArgb(172, 126, 241);
            public static Color color5 = Color.FromArgb(172, 126, 241);
            public static Color color6 = Color.FromArgb(172, 126, 241);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn !=null)
            {
                DisableButton();
                //Przycisk
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign= ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location= new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null) 
            {
                currentBtn.BackColor = Color.FromArgb(227, 227, 227);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm!= null) 
            { 
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag=childForm;
            childForm.BringToFront();
            childForm.Show();   
        }

        private void AFMainForm_Load(object sender, EventArgs e)
        {

        }

        private void AFMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _initForm.Show();
        }

        private void btnKlienci_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AFKlienciForm());
        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new AFPracownicyForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible=false;
        }
    }
}
