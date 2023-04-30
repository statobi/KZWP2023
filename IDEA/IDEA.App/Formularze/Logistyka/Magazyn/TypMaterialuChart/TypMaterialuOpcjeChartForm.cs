using IDEA.App.Models;
using IDEA.Logistyka.Observer;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.TypMaterialuChart
{
    public partial class TypMaterialuOpcjeChartForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _publisher = CommonPublisher.GetInstance();
        private TypMaterialuOpcjeChartInput _input;
        public TypMaterialuOpcjeChartForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            _input = message as TypMaterialuOpcjeChartInput;

            InitComboBoxes();
        }

        private void InitComboBoxes()
        {
            CmbMagazyn.DataSource = _input.Magazyny.ToList();
            CmbMagazyn.DisplayMember = "Nazwa";
            CmbMagazyn.ValueMember = "Id";

            CmbTypWykresu.DataSource = _input.TypyWykresow.ToList();
        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            _publisher.Send<TypMaterialuChartForm>(new TypMaterialuOpcjeChartOutput
            {
                MagazynId = (int)CmbMagazyn.SelectedValue,
                TypWykresuCmbIndex = CmbTypWykresu.SelectedIndex
            });

            Close();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void TypMaterialuOpcjeChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _publisher.Unsubscribe(this);
        }
    }
}
