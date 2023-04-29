using IDEA.App.Modells;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class TypMaterialuChartForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _publisher = CommonPublisher.GetInstance();
        private readonly OpenNewPanelPublisher _openNewPanelPublisher = OpenNewPanelPublisher.GetInstance();

        private TypMaterialuChartOpen _messageObj;
        public TypMaterialuChartForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
        }

        public void GetData<TMessage>(TMessage message)
        {
            _messageObj = message as TypMaterialuChartOpen;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _openNewPanelPublisher.Open<MagazynForm, MagazynOpen>(new MagazynOpen
            {
                MagazynDGVRowIndex = _messageObj.MagazynDGVRowIndex,
                SekcjaDGVRowIndex = _messageObj.SekcjaDGVRowIndex
            }, "Magazyny");
            Close();
        }
    }
}
