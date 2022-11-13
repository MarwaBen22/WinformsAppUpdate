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
    public partial class UC_Conge : UserControl
    {
        public UC_Conge()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        public void display()
        {
            dgvConge.DataSource = crud.more_tables("t.fonction,t.date_Engage, c.nom_Ref, c.nom_jours, c.date_debut, c.date_Fin, c.reprise, c.conge_Restant, c.file_Name, c.créé_le, c.créé_par, c.nature_Conge", "T_Conge", " left join T_Contrat t on t.id_Emp=e.id_Emp");
            dgvConge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UC_Conge_Load(object sender, EventArgs e)
        {
            try
            {
                cbSearch.SelectedIndex = 2;
                if (Settings.Default.titCong == "Consultation")
                {
                    btnAdd.Enabled = false;
                    btnImport.Enabled = false;
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;
                    btnView.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Conge _Conge = new Form_Conge();
            _Conge.btnUpdate.Visible = false;
            _Conge.btnPrint.Visible = false;
            _Conge.btnAdd.Location = new Point(182, 487);
            _Conge.btnCancel.Location = new Point(304, 487);
            _Conge.Show();
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

                            dgvConge.DataSource = crud.search_moreTables("t.fonction,t.date_Engage, c.nom_Ref, c.nom_jours, c.date_debut, c.date_Fin, c.reprise, c.conge_Restant, c.file_Name, c.créé_le, c.créé_par, c.nature_Conge", "T_Conge", " left join T_Contrat t on t.id_Emp=e.id_Emp", "nom", txtSearch.Text).Tables[0];
                        }
                        break;

                    case 1:
                        if (txtSearch.Text != "")
                        {
                            dgvConge.DataSource = crud.search_moreTables("t.fonction,t.date_Engage, c.nom_Ref, c.nom_jours, c.date_debut, c.date_Fin, c.reprise, c.conge_Restant, c.file_Name, c.créé_le, c.créé_par, c.nature_Conge", "T_Conge", " left join T_Contrat t on t.id_Emp=e.id_Emp", "nom_Ref", txtSearch.Text).Tables[0];
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

        string user = Settings.Default.userName;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Etes-vous sur de vouloir supprimer cet enregistrement?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    string deleteRow = dgvConge.CurrentRow.Cells["nom_Ref"].Value.ToString();
                    crud.crudop("delete from T_Conge where nom_Ref = '" + deleteRow + "'");
                    
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Suppression de titre de congé','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

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
            Form_Conge _Conge = new Form_Conge();
            _Conge.txtLName.Text = dgvConge.CurrentRow.Cells[1].Value.ToString();
            _Conge.txtName.Text = dgvConge.CurrentRow.Cells[2].Value.ToString();
            _Conge.txtJob.Text = dgvConge.CurrentRow.Cells[3].Value.ToString();
            _Conge.dtpRecruit.Text = dgvConge.CurrentRow.Cells[4].Value.ToString();
            _Conge.txtNumber.Text = dgvConge.CurrentRow.Cells[5].Value.ToString();
            _Conge.txtNumDays.Text = dgvConge.CurrentRow.Cells[6].Value.ToString();
            _Conge.dtpFrom.Text = dgvConge.CurrentRow.Cells[7].Value.ToString();
            _Conge.dtpTil.Text = dgvConge.CurrentRow.Cells[8].Value.ToString();
            _Conge.dtpReturn.Text = dgvConge.CurrentRow.Cells[9].Value.ToString();
            _Conge.txtRest.Text = dgvConge.CurrentRow.Cells[10].Value.ToString();
            _Conge.fileDate.Text = dgvConge.CurrentRow.Cells[12].Value.ToString();
            _Conge.txtUser.Text = dgvConge.CurrentRow.Cells[13].Value.ToString();
            _Conge.txtNature.Text = dgvConge.CurrentRow.Cells[14].Value.ToString();
            _Conge.btnAdd.Visible = false;
            _Conge.btnUpdate.Visible = false;
            _Conge.btnPrint.Location = new Point(243, 487);
            _Conge.btnCancel.Visible = false;
            foreach (var txt in _Conge.Controls.OfType<TextBox>())
            {
                txt.ReadOnly = true;
            }
            foreach (var dtp in _Conge.Controls.OfType<DateTimePicker>())
            {
                dtp.Enabled = false;
            }
            _Conge.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtFileName.Text = dgvConge.CurrentRow.Cells[11].Value.ToString();
            if (crud.check_Id("T_Conge", "file_Name", txtFileName.Text) == "Code exists")
            {
                string num = dgvConge.CurrentRow.Cells["nom_Ref"].Value.ToString();
                crud.openFile(num, "T_Conge", "nom_Ref");

            }
            else
            {
                MessageBox.Show("Il n'y a pas de fichier importé");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            txtFileName.Text = dgvConge.CurrentRow.Cells[11].Value.ToString();
            if (crud.check_Id("T_Conge", "file_Name", txtFileName.Text) == "Code exists")
            {
                var confirmResult = MessageBox.Show("Il y a déjà un fichier importé\nVoulez-vous le changer?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.ShowDialog();
                    txtFilePath.Text = dlg.FileName;
                    string num = dgvConge.CurrentRow.Cells["nom_Ref"].Value.ToString();
                    crud.saveFile0(txtFilePath.Text, num, "T_Conge", "nom_Ref");
                    MessageBox.Show("Fichier importé avec succès");
                    
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Importation de titre de congé','" + user + "','" + DateTime.Now + "')");
                }
            }
            else
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.ShowDialog();
                txtFilePath.Text = dlg.FileName;
                string num = dgvConge.CurrentRow.Cells["nom_Ref"].Value.ToString();
                crud.saveFile0(txtFilePath.Text, num, "T_Conge", "nom_Ref");
                MessageBox.Show("Fichier importé avec succès");
                
                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Importation de titre de congé','" + user + "','" + DateTime.Now + "')");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form_Conge _Conge = new Form_Conge();
            _Conge.txtLName.Text = dgvConge.CurrentRow.Cells[1].Value.ToString();
            _Conge.txtName.Text = dgvConge.CurrentRow.Cells[2].Value.ToString();
            _Conge.txtJob.Text = dgvConge.CurrentRow.Cells[3].Value.ToString();
            _Conge.dtpRecruit.Text = dgvConge.CurrentRow.Cells[4].Value.ToString();
            _Conge.txtNumber.Text = dgvConge.CurrentRow.Cells[5].Value.ToString();
            _Conge.txtNumDays.Text = dgvConge.CurrentRow.Cells[6].Value.ToString();
            _Conge.dtpFrom.Text = dgvConge.CurrentRow.Cells[7].Value.ToString();
            _Conge.dtpTil.Text = dgvConge.CurrentRow.Cells[8].Value.ToString();
            _Conge.dtpReturn.Text = dgvConge.CurrentRow.Cells[9].Value.ToString();
            _Conge.txtRest.Text = dgvConge.CurrentRow.Cells[10].Value.ToString();
            _Conge.fileDate.Text = dgvConge.CurrentRow.Cells[12].Value.ToString();
            _Conge.txtUser.Text = dgvConge.CurrentRow.Cells[13].Value.ToString();
            _Conge.txtNature.Text = dgvConge.CurrentRow.Cells[14].Value.ToString();
            _Conge.btnAdd.Visible = false;
            _Conge.btnPrint.Visible = false;
            _Conge.btnUpdate.Visible = true;
            _Conge.btnUpdate.Location = new Point(182, 487);
            _Conge.btnCancel.Location = new Point(304, 487);
            
            _Conge.ShowDialog();
        }
    }
}
