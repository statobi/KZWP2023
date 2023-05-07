using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Produkcja
{
    public partial class ProcesyTechnologiczneForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private Produkt produkt = new Produkt();
        private Proces_Technologiczny selectedProces_Technologiczny = new Proces_Technologiczny();
        private Proces_Technologiczny_Material selectedProces_Technologiczny_Material = new Proces_Technologiczny_Material();
        private bool flagSelectedProces_Technologiczny = false;
        private bool flagEdycja = false;
        public ProcesyTechnologiczneForm(Produkt _produkt)
        {
            InitializeComponent();

            this.produkt = _produkt;
            initDgvProcesyTechnologiczne();
            initComboboxes();
        }

        private void initdgvProces_Materialy()
        {
            var ProcesMaterialQuery = from ptm in db.Proces_Technologiczny_Material
                         join m in db.Materials on ptm.ID_Material equals m.ID_Material
                         where ptm.ID_Proces_Technologiczny == selectedProces_Technologiczny.ID_Proces_Technologiczny
                         select new { ptm.ID_Proces_Technologiczny_Material, ptm.ID_Proces_Technologiczny, ptm.ID_Material, m.Nazwa, ptm.Ilosc };
            dgvProces_Materialy.DataSource = ProcesMaterialQuery.ToList();
            dgvProces_Materialy.Columns["ID_Proces_Technologiczny_Material"].Visible = false;
            dgvProces_Materialy.Columns["ID_Proces_Technologiczny"].Visible = false;
            dgvProces_Materialy.Columns["ID_Material"].Visible = false;
            dgvProces_Materialy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    



        private void initComboboxes()
        {
            var query1 = from p in db.Rodzaj_Maszyny
                         select new { p.ID_Rodzaj_Maszyny, p.Nazwa };
            cbRodzajMaszyny.DataSource = query1.ToList();
            cbRodzajMaszyny.DisplayMember = "Nazwa";
            cbRodzajMaszyny.ValueMember = "ID_Rodzaj_Maszyny";
            cbRodzajMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajMaszyny.SelectedIndex = -1;

            var query2 = from p in db.Nazwa_Procesu
                         select new { p.ID_Nazwa_Procesu, p.Nazwa };
            cbNazwaProcesu.DataSource = query2.ToList();
            cbNazwaProcesu.DisplayMember = "Nazwa";
            cbNazwaProcesu.ValueMember = "ID_Nazwa_Procesu";
            cbNazwaProcesu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNazwaProcesu.SelectedIndex = -1;

            var query3 = from m in db.Materials
                         join jm in db.Jednostka_miary on m.ID_Jednostka_miary equals jm.ID_Jednostka_miary
                         select new { m.ID_Material, Material = m.Nazwa + " " + jm.Nazwa, Jednostka = jm.Nazwa };
            cbMaterial.DataSource = query3.ToList();
            cbMaterial.DisplayMember = "Material";
            cbMaterial.ValueMember = "ID_Material";
            cbNazwaProcesu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNazwaProcesu.SelectedIndex = -1;
        }


        private void initDgvProcesyTechnologiczne()
        {

            var ProcesyTechnologiczneQuery = from pt in db.Proces_Technologiczny
                                             join rm in db.Rodzaj_Maszyny on pt.ID_Rodzaj_Maszyny equals rm.ID_Rodzaj_Maszyny
                                             join np in db.Nazwa_Procesu on pt.ID_Nazwa_Procesu equals np.ID_Nazwa_Procesu
                                             orderby pt.ID_Produkt, pt.Kolejnosc
                                             where pt.ID_Produkt == produkt.ID_Produkt
                                             select new
                                             {
                                                 pt.ID_Proces_Technologiczny,
                                                 pt.ID_Produkt,
                                                 pt.Kolejnosc,
                                                 WymaganaMaszyna = rm.Nazwa,
                                                 Proces = np.Nazwa,
                                                 pt.Ilosc_Pracownikow,
                                                 pt.Ilosc_Godzin
                                             };

            dgvProcesyTechnologiczne.DataSource = ProcesyTechnologiczneQuery.ToList();
            dgvProcesyTechnologiczne.Columns["ID_Produkt"].Visible = false;
            dgvProcesyTechnologiczne.Columns["ID_Proces_Technologiczny"].Visible = false;

            //this.dgvProcesyTechnologiczne.Columns["ID_x"].Visible = false;
            dgvProcesyTechnologiczne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ProcesyTechnologiczneForm_Load(object sender, EventArgs e)
        {

        }

        private void resetbuttons()
        {
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnAddCancel.Enabled = false;
            cbNazwaProcesu.Enabled = false;
            cbRodzajMaszyny.Enabled = false;
            numIloscGodzin.Enabled = false;
            numIloscPracownikow.Enabled = false;

            initComboboxes();
            numIloscGodzin.Value = 1;
            numIloscPracownikow.Value = 1;
            flagEdycja = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            btnAddCancel.Enabled = true;
            cbNazwaProcesu.Enabled = true;
            cbRodzajMaszyny.Enabled = true;
            numIloscGodzin.Enabled = true;
            numIloscPracownikow.Enabled = true;

        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            resetbuttons();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(flagEdycja==false)
            {
                Proces_Technologiczny new_proces_technologiczny = new Proces_Technologiczny();
                new_proces_technologiczny.ID_Produkt = produkt.ID_Produkt;
                new_proces_technologiczny.ID_Nazwa_Procesu = (int)cbNazwaProcesu.SelectedValue;
                new_proces_technologiczny.ID_Rodzaj_Maszyny = (int)cbRodzajMaszyny.SelectedIndex;
                new_proces_technologiczny.Ilosc_Godzin = (int)numIloscGodzin.Value;
                new_proces_technologiczny.Ilosc_Pracownikow = (int)numIloscPracownikow.Value;
                db.Proces_Technologiczny.Add(new_proces_technologiczny);
                db.SaveChanges();
            }
            else
            {
                Proces_Technologiczny update_proces = db.Proces_Technologiczny.First(p => p.ID_Proces_Technologiczny == selectedProces_Technologiczny.ID_Proces_Technologiczny);
                update_proces.ID_Produkt = produkt.ID_Produkt;
                update_proces.ID_Nazwa_Procesu = (int)cbNazwaProcesu.SelectedValue;
                update_proces.ID_Rodzaj_Maszyny = (int)cbRodzajMaszyny.SelectedIndex;
                update_proces.Ilosc_Godzin = (int)numIloscGodzin.Value;
                update_proces.Ilosc_Pracownikow = (int)numIloscPracownikow.Value;
                db.SaveChanges();
            }
            initDgvProcesyTechnologiczne();
            resetbuttons();
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć ProcesTechnologiczny nr: " + selectedProces_Technologiczny.ID_Proces_Technologiczny + " ?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query1 = from p in db.Proces_Technologiczny_Material
                             where p.ID_Proces_Technologiczny == selectedProces_Technologiczny.ID_Proces_Technologiczny
                             select p;
                foreach (Proces_Technologiczny_Material p in query1)
                    db.Proces_Technologiczny_Material.Remove(p);
                db.SaveChanges();
                var query2 = from p in db.Proces_Technologiczny
                             where p.ID_Proces_Technologiczny == selectedProces_Technologiczny.ID_Proces_Technologiczny
                             select p;
                foreach (Proces_Technologiczny p in query2)
                    db.Proces_Technologiczny.Remove(p);
                db.SaveChanges();
                initDgvProcesyTechnologiczne();
                initdgvProces_Materialy();
            }
            else
            {
                //kod
            }

        }

        private void dgvProcesyTechnologiczne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProcesyTechnologiczne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelectedProces_Technologiczny = true;
            int index;
            index = dgvProcesyTechnologiczne.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvProcesyTechnologiczne.Rows[index];

            selectedProces_Technologiczny.ID_Proces_Technologiczny = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from procest in db.Proces_Technologiczny
                        where procest.ID_Proces_Technologiczny == selectedProces_Technologiczny.ID_Proces_Technologiczny
                        select procest;
            foreach (Proces_Technologiczny procest in query)
            {
                selectedProces_Technologiczny.ID_Proces_Technologiczny = procest.ID_Proces_Technologiczny;
                selectedProces_Technologiczny.ID_Produkt = procest.ID_Produkt;
                selectedProces_Technologiczny.ID_Nazwa_Procesu = procest.ID_Produkt;
                selectedProces_Technologiczny.ID_Rodzaj_Maszyny = procest.ID_Rodzaj_Maszyny;
                selectedProces_Technologiczny.Ilosc_Pracownikow = procest.Ilosc_Pracownikow;
                selectedProces_Technologiczny.Ilosc_Godzin = procest.Ilosc_Godzin;
            }
            cbMaterial.Enabled = true;
            btnAddMaterial.Enabled = true;
            initdgvProces_Materialy();
        }

        private void dgvProces_Materialy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectedProces_Technologiczny_Material
            int index;
            index = dgvProces_Materialy.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvProces_Materialy.Rows[index];

            selectedProces_Technologiczny_Material.ID_Proces_Technologiczny_Material = int.Parse(selectedrow.Cells[0].Value.ToString());
            
            var query = from p in db.Proces_Technologiczny_Material
                        where p.ID_Proces_Technologiczny_Material == selectedProces_Technologiczny_Material.ID_Proces_Technologiczny
                        select p;
            foreach (Proces_Technologiczny_Material p in query)
            {
                selectedProces_Technologiczny_Material.ID_Proces_Technologiczny_Material = p.ID_Proces_Technologiczny_Material;
                
            }
        }

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMaterial.SelectedIndex!=-1)
            {
                numIloscMaterial.Enabled = true;
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            Proces_Technologiczny_Material newProcesTechnologiczny = new Proces_Technologiczny_Material();
            newProcesTechnologiczny.ID_Material = (int)cbMaterial.SelectedValue;
            newProcesTechnologiczny.Ilosc=(int)numIloscMaterial.Value;
            newProcesTechnologiczny.ID_Proces_Technologiczny = selectedProces_Technologiczny.ID_Proces_Technologiczny;
            db.Proces_Technologiczny_Material.Add(newProcesTechnologiczny);
            db.SaveChanges();
            initdgvProces_Materialy();
        }

        private void btnDeleteProcesTechnologicznyMaterial_Click(object sender, EventArgs e)
        {
            var query = from p in db.Proces_Technologiczny_Material
                        where p.ID_Proces_Technologiczny_Material == selectedProces_Technologiczny_Material.ID_Proces_Technologiczny_Material
                        select p;
            foreach (Proces_Technologiczny_Material p in query)
                db.Proces_Technologiczny_Material.Remove(p);
            db.SaveChanges();
            initdgvProces_Materialy();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flagEdycja = true;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            btnAddCancel.Enabled = true;
            cbNazwaProcesu.Enabled = true;
            cbRodzajMaszyny.Enabled = true;
            numIloscGodzin.Enabled = true;
            numIloscPracownikow.Enabled = true;

            cbNazwaProcesu.SelectedIndex = selectedProces_Technologiczny.ID_Nazwa_Procesu-1;
            cbRodzajMaszyny.SelectedIndex = selectedProces_Technologiczny.ID_Rodzaj_Maszyny-1;
            numIloscGodzin.Value = selectedProces_Technologiczny.Ilosc_Godzin;
            numIloscPracownikow.Value = selectedProces_Technologiczny.Ilosc_Pracownikow;
        }
    }
}
