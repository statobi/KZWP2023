using IDEA.Logistyka.Modele;
using IDEA.Logistyka.Observer;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class EdytujMagazynForm : Form, ISubscriber
    {
        private readonly Publisher _publisher = Publisher.GetInstance();

        public EdytujMagazynForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
        }

        public void UpdateView(string message = null)
        {
            var obj = JsonConvert.DeserializeObject<MagazynDGV>(message);
            TxbNazwa.Text = obj.Nazwa;
            TxbTelefon.Text = obj.NrTelefonu;
            TxbPowierzchniaRobocza.Text = obj.PowierzchniaRobocza.ToString();
        }

        private void BtnEdytujMagazyn_Click(object sender, EventArgs e)
        {
            _publisher.Notify<MagazynForm>();
        }

        private void EdytujMagazynForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _publisher.Unsubscribe(this);
        }
    }
}
