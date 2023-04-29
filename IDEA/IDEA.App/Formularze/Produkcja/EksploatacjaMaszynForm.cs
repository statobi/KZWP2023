using IDEA.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Produkcja
{
    public partial class EksploatacjaMaszynForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();

        public EksploatacjaMaszynForm()
        {
            InitializeComponent();
            initOpcjeParametrMaszyny();
        }

        private void initOpcjeParametrMaszyny()
        {
            var ParametrMaszyny = db.Parametr_Maszyny
                .Select(s => s.Nazwa_Parametru).ToList();
            cbParametrMaszyny.DataSource = ParametrMaszyny;
            cbParametrMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParametrMaszyny.SelectedIndex = -1;
        }

    }
}
