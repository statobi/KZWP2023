using IDEA.App.Formularze.Logistyka.Magazyn.Nieprzypisane;
using IDEA.App.MessageBoxes;
using IDEA.App.Models;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Validators;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace
{
    public partial class DodajPoIlosciForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();

        private DodajPoIlosciInput _input;
        public DodajPoIlosciForm()
        {
            InitializeComponent();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            if (message is DodajPoIlosciInput input)
            {
                _input = input;

                Init();
            }
        }

        private void Init()
        {
            LblMaxIlosc.Text = _input.Oczekujace.Ilosc.ToString();
            TxbIlosc.Text = _input.Oczekujace.Ilosc.ToString();

            LblAsortyment.Text = _input.Oczekujace.TypAsortymentu.ToString();
            TxbAsortyment.Text = _input.Oczekujace.Nazwa;
        }

        private void DodajPoIlosciForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _commonPublisher.Unsubscribe(this);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var validatorResult = DodajPoIlosciValidator.Validate(TxbIlosc.Text, _input.Oczekujace.Ilosc);

            if (!string.IsNullOrEmpty(validatorResult))
            {
                CustomMessageBox.ValidateMessageBox(validatorResult);
                return;
            }

            var ilosc = int.Parse(TxbIlosc.Text);

            _commonPublisher.Send<OczekujaceForm>(new DodajPoIlosciOutput
            {
                Oczekujace = new OczekujaceDGV
                {
                    Id = _input.Oczekujace.Id,
                    UfId = _input.Oczekujace.UfId,
                    IdAsortyment = _input.Oczekujace.IdAsortyment,
                    Nazwa = _input.Oczekujace.Nazwa,
                    DataOd = _input.Oczekujace.DataOd,
                    TypAsortymentu = _input.Oczekujace.TypAsortymentu,
                    Ilosc = _input.Oczekujace.Ilosc,
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
