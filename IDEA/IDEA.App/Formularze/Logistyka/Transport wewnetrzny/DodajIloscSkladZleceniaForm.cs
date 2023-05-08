using IDEA.App.Formularze.Logistyka.Magazyn.Nieprzypisane;
using IDEA.App.MessageBoxes;
using IDEA.App.Models;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Validators;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class DodajIloscSkladZleceniaForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();

        private DodajIloscSkladZleceniaInput _input;

        public DodajIloscSkladZleceniaForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            if (message is DodajIloscSkladZleceniaInput input)
            {
                _input = input;

                Init();
            }
        }

        private void Init()
        {
            LblMaxIlosc.Text = _input.Zawartosc.Ilosc.ToString();
            TxbIlosc.Text = _input.Zawartosc.Ilosc.ToString();

            LblAsortyment.Text = _input.Zawartosc.TypAsortymentu.ToString();
            TxbAsortyment.Text = _input.Zawartosc.Nazwa;
        }

        private void DodajIloscSkladZleceniaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var validatorResult = DodajPoIlosciValidator.Validate(TxbIlosc.Text, _input.Zawartosc.Ilosc);

            if (!string.IsNullOrEmpty(validatorResult))
            {
                CustomMessageBox.ValidateMessageBox(validatorResult);
                return;
            }

            var ilosc = int.Parse(TxbIlosc.Text);

            _commonPublisher.Send<TransportWewnetrznyKonfiguracjaZlecenia>(new DodajIloscSkladZleceniaOutput
            {
                Zawartosc = new MagazynZawartosc
                {
                    UfId = _input.Zawartosc.UfId,
                    IdAsortyment = _input.Zawartosc.IdAsortyment,
                    Nazwa = _input.Zawartosc.Nazwa,
                    TypAsortymentu = _input.Zawartosc.TypAsortymentu,
                    Ilosc = _input.Zawartosc.Ilosc,
                },
                EnteredIlosc = ilosc,
                RowIndex = _input.RowIndex,
                StagedStatus = _input.StagedStatus
            });

            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
