using IDEA.App.Formularze.Produkcja;
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

namespace IDEA.App
{
    public partial class NarzedziaForm : Form
    {
        IDEAEntities db = new IDEAEntities();
        private bool flagSelected = false;
        Narzedzia selectedNarzedzia = new Narzedzia();
        public NarzedziaForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initdgvNarzedzia();
        }

       

        
        private void initdgvNarzedzia()
        {
            // dgvKlienci.DataSource = null;
            dgvNarzedzia.DataSource = db.V_Narzedzia.ToList();
          
            dgvNarzedzia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {

            //using (NarzedziaFormCU aF = new NarzedziaFormCU())
            // {
            //     aF.ShowDialog();
            //   initDgwKlienci();
            //  }
        }
        //Wersja Edycja
      

        private void iBtnEdit_Click_1(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                using (NarzedziaFormCU aF = new NarzedziaFormCU(selectedNarzedzia))
                {
                    aF.ShowDialog();
                    initdgvNarzedzia();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano narzędzia do edycji!");
            }
        }

        private void dgvNarzedzia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvNarzedzia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            selectedNarzedzia.ID_Narzedzia = int.Parse(dgvNarzedzia.Rows[e.RowIndex].Cells[0].Value.ToString());

            var query = from p in db.Narzedzias
                        where p.ID_Rodzaj_Narzedzia == selectedNarzedzia.ID_Narzedzia
                        select p;
            foreach (Narzedzia p in query)
            {
                selectedNarzedzia.ID_Narzedzia = p.ID_Narzedzia;
                selectedNarzedzia.ID_Rodzaj_Narzedzia = p.ID_Rodzaj_Narzedzia;
                //selectedNarzedzia.Nazwa = p.Nazwa;
                selectedNarzedzia.Symbol = p.Symbol;
                selectedNarzedzia.Data_przychodu = p.Data_przychodu;
                selectedNarzedzia.Data_rozchodu = p.Data_rozchodu;


            }
        }
    }

}
