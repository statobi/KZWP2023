using IDEA.App.MessageBoxes;
using IDEA.App.Models;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using IDEA.Logistyka.Validators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace
{
    public partial class DodajDoTypuZasobuForm : Form
    {
        private readonly DodajDoTypuZasobuService _dodajDoTypuZasobuService = new DodajDoTypuZasobuService();
        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();

        private List<TypZasobuCmb> _cmbDataSource;
        public DodajDoTypuZasobuForm()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void InitComboBox()
        {
            _cmbDataSource = _dodajDoTypuZasobuService.GetTypZasobu().OrderBy(x => x.Name).ToList();
            CmbTypZasobu.DataSource = _cmbDataSource;
            CmbTypZasobu.DisplayMember = "Name";
            CmbTypZasobu.ValueMember = "Id";
        }

        private void CbAddTypZasobu_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;

            if(checkBox.Checked)
            {
                TxbAddTypZasobu.Enabled = true;
                CmbTypZasobu.Enabled = false;
                return;
            }

            TxbAddTypZasobu.Enabled = false;
            CmbTypZasobu.Enabled = true;
        }
        private void BtnApply_Click(object sender, EventArgs e)
        {
            var validation = DodajDoTypuZasobuValidator.Validate(_cmbDataSource.Select(x => x.Name), TxbAddTypZasobu.Text);

            if (!string.IsNullOrEmpty(validation))
            {
                CustomMessageBox.ValidateMessageBox(validation);
                return;
            }

            if (CbAddTypZasobu.Checked)
            {
                _dodajDoTypuZasobuService.AddTypZasobu(TxbAddTypZasobu.Text);
                var latest = _dodajDoTypuZasobuService.GetTypZasobu().Select(x => x.Id).LastOrDefault();

                _commonPublisher.Send<PrzypiszTypZasobuForm>(new DodajDoTypuZasobuOutput
                {
                    IdTypZasobu = latest,
                });

                return;
            }

            _commonPublisher.Send<PrzypiszTypZasobuForm>(new DodajDoTypuZasobuOutput
            {
                IdTypZasobu = ((TypZasobuCmb)CmbTypZasobu.SelectedItem).Id,
            });
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
