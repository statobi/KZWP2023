using IDEA.App.Models;
using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Observer;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.Sekcja
{
    public partial class DodajPolkaForm : Form, IRequestSubscriber
    {
        private readonly Repository<Polka> _repository = new Repository<Polka>();
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();
        public DodajPolkaForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        int idSekcja;

        public void GetData(object message)
        {
            if (message is DodajPolkaInput input)
            {
                idSekcja = input.IdSekcja;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajPolkaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _repository.Add(new Polka
            {
                DlugoscPietra = int.Parse(TxbDlugosc.Text),
                ID_Sekcja = idSekcja,
                LiczbaPieter = 5,
                Numer = TxbNumer.Text,
                SzerokoscPietra = int.Parse(TxbSzerokosc.Text),
                Udzwig = int.Parse(TxbNosnosc.Text),
                WysokoscPietra = int.Parse(TxbWysokosc.Text),
            });

            _commonPublisher.Notify<SekcjaForm>();

            Close();
        }
    }
}
