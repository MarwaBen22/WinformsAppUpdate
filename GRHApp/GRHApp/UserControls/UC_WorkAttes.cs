using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRHApp.Classes;
using GRHApp.Forms;
using GRHApp.Properties;

namespace GRHApp.UserControls
{
    public partial class UC_WorkAttes : UserControl
    {
        public UC_WorkAttes()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        public void display()
        {
            dgvWorkAttes.DataSource = crud.more_tables("e.date_Naissance,e.lieu_Naissance,e.adresse,t.fonction,t.date_Engage, c.num_Ref, c.file_Name, c.créé_le, c.créé_par", "T_AttesCert", "left join T_Contrat t on t.id_Emp=e.id_Emp");
            dgvWorkAttes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UC_WorkAttes_Load(object sender, EventArgs e)
        {
            try
            {
                if (Settings.Default.attTrav == "Consultation")
                {
                    btnAdd.Enabled = false;
                    btnImport.Enabled = false;
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;
                    btnView.Enabled = true;
                }
                cbSearch.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AttesCert _AttesCert = new Form_AttesCert();
            _AttesCert.btnUpdate.Visible = false;
            _AttesCert.btnPrint.Visible = false;
            _AttesCert.btnAdd.Location = new Point(182, 438);
            _AttesCert.btnCancel.Location = new Point(304, 438);
            _AttesCert.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Text = "Rechercher";
                txtSearch.ReadOnly = true;
                cbSearch.Items.Insert(2, "Recherche par");
                cbSearch.SelectedIndex = 2;

                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbSearch.SelectedIndex)
                {
                    case 0:
                        if (txtSearch.Text != "")
                        {

                            dgvWorkAttes.DataSource = crud.search_moreTables("e.date_Naissance,e.lieu_Naissance,e.adresse,t.fonction,t.date_Engage, c.num_Ref, c.file_Name, c.créé_le, c.créé_par", "T_AttesCert", "left join T_Contrat t on t.id_Emp=e.id_Emp", "nom", txtSearch.Text).Tables[0];
                        }
                        break;

                    case 1:
                        if (txtSearch.Text != "")
                        {
                            dgvWorkAttes.DataSource = crud.search_moreTables("e.date_Naissance,e.lieu_Naissance,e.adresse,t.fonction,t.date_Engage, c.num_Ref, c.file_Name, c.créé_le, c.créé_par", "T_AttesCert", "left join T_Contrat t on t.id_Emp=e.id_Emp", "num_Ref", txtSearch.Text).Tables[0];
                        }
                        break;

                    default:
                        MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtSearch.Text == "Rechercher" && cbSearch.SelectedIndex != 2)
                {
                    txtSearch.Text = "";
                    txtSearch.ReadOnly = false;
                }
                else if (cbSearch.SelectedIndex == 2)
                {
                    MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                    txtSearch.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (cbSearch.SelectedIndex == 2)
                    cbSearch.Items.RemoveAt(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string userName = Settings.Default.userName;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                var confirmResult = MessageBox.Show("Etes-vous sur de vouloir supprimer cet enregistrement?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    string deleteRow = dgvWorkAttes.CurrentRow.Cells["num_Ref"].Value.ToString();
                    crud.crudop("delete from T_AttesCert where num_Ref = '" + deleteRow + "'");
                    
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Suppression d une attestation','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
                }
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form_AttesCert _AttesCert = new Form_AttesCert();
            _AttesCert.txtNumber.Text = dgvWorkAttes.CurrentRow.Cells[8].Value.ToString();
            _AttesCert.txtLName.Text = dgvWorkAttes.CurrentRow.Cells[1].Value.ToString();
            _AttesCert.txtName.Text = dgvWorkAttes.CurrentRow.Cells[2].Value.ToString();
            _AttesCert.dtpBirth.Text = dgvWorkAttes.CurrentRow.Cells[3].Value.ToString(); 
            _AttesCert.txtPBirth.Text = dgvWorkAttes.CurrentRow.Cells[4].Value.ToString();
            _AttesCert.txtAddress.Text = dgvWorkAttes.CurrentRow.Cells[5].Value.ToString();
            _AttesCert.txtJob.Text = dgvWorkAttes.CurrentRow.Cells[6].Value.ToString();
            _AttesCert.dtpRecruit.Text = dgvWorkAttes.CurrentRow.Cells[7].Value.ToString();
            _AttesCert.fileDate.Text = dgvWorkAttes.CurrentRow.Cells[10].Value.ToString();
            _AttesCert.txtUser.Text = dgvWorkAttes.CurrentRow.Cells[11].Value.ToString();
            _AttesCert.btnAdd.Visible = false;
            _AttesCert.btnUpdate.Visible = false;
            _AttesCert.btnCancel.Visible = false;
            _AttesCert.btnPrint.Location = new Point(243, 438);
            foreach (var txt in _AttesCert.Controls.OfType<TextBox>())
            {
                txt.ReadOnly = true;
            }
            foreach (var dtp in _AttesCert.Controls.OfType<DateTimePicker>())
            {
                dtp.Enabled = false;
            }
            _AttesCert.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtFileName.Text = dgvWorkAttes.CurrentRow.Cells[9].Value.ToString();
            if (crud.check_Id("T_AttesCert", "file_Name", txtFileName.Text) == "Code exists")
            {
                string num = dgvWorkAttes.CurrentRow.Cells["num_Ref"].Value.ToString();
                crud.openFile(num, "T_AttesCert", "num_Ref");
                
            }
            else
            {
                MessageBox.Show("Il n'y a pas de fichier importé");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            txtFileName.Text = dgvWorkAttes.CurrentRow.Cells[9].Value.ToString();
            if (crud.check_Id("T_AttesCert", "file_Name", txtFileName.Text) == "Code exists")
            {
                var confirmResult = MessageBox.Show("Il y a déjà un fichier importé\nVoulez-vous le changer??", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.ShowDialog();
                    txtFilePath.Text = dlg.FileName;
                    string num = dgvWorkAttes.CurrentRow.Cells["num_Ref"].Value.ToString();
                    crud.saveFile0(txtFilePath.Text, num, "T_AttesCert", "num_Ref");
                    MessageBox.Show("Fichier importé avec succès");
                    
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Importation d une attestation','" + userName + "','" + DateTime.Now + "')");
                }
            }
            else
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.ShowDialog();
                txtFilePath.Text = dlg.FileName;
                string num = dgvWorkAttes.CurrentRow.Cells["num_Ref"].Value.ToString();
                crud.saveFile0(txtFilePath.Text, num, "T_AttesCert", "num_Ref");
                MessageBox.Show("Fichier importé avec succès");
                
                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Importation d une attestation','" + userName + "','" + DateTime.Now + "')");

            }
        }

        private void dgvWorkAttes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
