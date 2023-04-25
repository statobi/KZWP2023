using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn.Sekcja
{
    public partial class SekcjaForm : Form, ISubscriber
    {
        private readonly Publisher _publisher = Publisher.GetInstance();
        public SekcjaForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
        }

        public void GetData(string message = null)
        {
            var messageObj = JsonConvert.DeserializeObject<SekcjaOpenForm>(message);
        }
    }
}
