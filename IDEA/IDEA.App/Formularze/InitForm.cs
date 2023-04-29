using FontAwesome.Sharp;
using IDEA.App.Factories;
using IDEA.App.Formularze.Logistyka.Magazyn;
using IDEA.App.Formularze.Logistyka.Pojazdy;
using IDEA.App.Formularze.Logistyka.Transport_wewnetrzny;
using IDEA.App.Formularze.Produkcja;
using IDEA.App.Observer;
using IDEA.Logistyka.Observer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class InitForm : Form, IOpenNewPanelSubscriber
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private readonly OpenNewPanelPublisher _openNewPanelPublisher = OpenNewPanelPublisher.GetInstance();
        private readonly CommonPublisher _publisher = CommonPublisher.GetInstance();
        private IconButton _clickedMenuButton = null;

        public InitForm()
        {
            InitializeComponent();
            customizeDesign();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 30);
            _openNewPanelPublisher.Subscribe(this);
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(181, 241, 255);
            public static Color color2 = Color.FromArgb(172, 126, 241);
            public static Color color3 = Color.FromArgb(172, 126, 241);
            public static Color color4 = Color.FromArgb(172, 126, 241);
            public static Color color5 = Color.FromArgb(172, 126, 241);
            public static Color color6 = Color.FromArgb(172, 126, 241);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Przycisk
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 46, 86);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                _clickedMenuButton = (IconButton)senderBtn;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0,100,189);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void customizeDesign()
        {
            panelAFSubmenu.Visible = false;
            panelProdukcjaSubmenu.Visible = false;
            panelLogistykaSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelAFSubmenu.Visible == true)
                panelAFSubmenu.Visible = false;
            if (panelProdukcjaSubmenu.Visible == true)
                panelProdukcjaSubmenu.Visible = false;
            if (panelLogistykaSubmenu.Visible == true)
                panelLogistykaSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }


        #region Dział AF - Submenu
        private void btnAF_Click(object sender, System.EventArgs e)
        {
            showSubmenu(panelAFSubmenu);
        }

        private void btnAFKlienci_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AFKlienciForm());
            //Your code here
            //
            
        }

        private void btnAFPracownicy_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AFPracownicyForm());
            //Your code here
            //
        }

        private void btnAFZamowienia_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AFZamowieniaForm());
        }

        private void btnAFUrlopy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AFUrlopyForm());
        }

        private void btnAFFaktury_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AFFakturyForm());
        }

        private void btnAFSrodkiMajatkowe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AFSrodkiMajatkoweForm());
        }
        private void btnAFKosztyRozne_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AFKosztyRozneForm());
        }
        #endregion - 


        #region Produkcja - Submenu
        private void btnProdukcja_Click(object sender, System.EventArgs e)
        {
            showSubmenu(panelProdukcjaSubmenu);
        }



        private void btnProdukcja1_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new MaszynyForm());
            //Your code here
            //
            //hideSubmenu();
        }

        private void btnProdukcja2_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new PlanowanieProcesyForm());

            //Your code here
            //
            //hideSubmenu();
        }

        private void btnProdukcja3_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new KontrolaJakosciForm());
            //Your code here
            //
            //hideSubmenu();
        }
        #endregion


        #region Logistyka - Submenu
        private void btnLogistyka_Click(object sender, System.EventArgs e)
        {
            showSubmenu(panelLogistykaSubmenu);
        }

        private void btnLogistyka1_Click(object sender, System.EventArgs e)
        {
            //Your code here
            //
            if (sender == _clickedMenuButton) return;

            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new MagazynForm());
            //hideSubmenu();
        }

        private void btnLogistyka2_Click(object sender, System.EventArgs e)
        {
            //Your code here
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new PojazdyForm());
        }

        private void btnLogistyka3_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new TransportWewnetrznyForm());
        }

        #endregion



        private void btnHelp_Click(object sender, System.EventArgs e)
        {
            //Your code here
            //
            hideSubmenu();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm= childForm;
            childForm.TopLevel= false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pBoxLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            DisableButton();
            hideSubmenu();
        }

        private void InitForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void OpenPanel<TReceiver, TMessage>(TMessage messageObj, string menuButtonText) where TReceiver: Form
        {
            var form = NewPanelFactory.CreateNewPanel<TReceiver>();
            _clickedMenuButton.Text = menuButtonText;
            OpenChildForm(form);
            _publisher.Send<TReceiver, TMessage>(messageObj);
        }
    }
}
