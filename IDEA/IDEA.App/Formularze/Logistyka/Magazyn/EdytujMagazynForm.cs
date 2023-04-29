using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class EdytujMagazynForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _publisher = CommonPublisher.GetInstance();

        public EdytujMagazynForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
        }

        public void GetData<TMessage>(TMessage message)
        {
            var obj = message as MagazynDGV;

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
