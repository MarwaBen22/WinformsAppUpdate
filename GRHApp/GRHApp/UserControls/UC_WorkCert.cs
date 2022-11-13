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
    public partial class UC_WorkCert : UserControl
    {
        public UC_WorkCert()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        public void display()
        {
            dgvCetificate.DataSource = crud.more_tables("e.date_Naissance,e.lieu_Naissance,e.adresse,t.fonction,t.date_Engage, c.numRef, c.date_Fin, c.file_Name, c.créé_le, c.créé_par", "T_Cert", "left join T_Contrat t on t.id_Emp=e.id_Emp");
            dgvCetificate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UC_WorkCert_Load(object sender, EventArgs e)
        {
            try
            {
                cbSearch.SelectedIndex = 2;
                if (Settings.Default.certTrav == "Consultation")
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
            Form_WorkCet _WorkCet = new Form_WorkCet();
            _WorkCet.btnUpdate.Visible = false;
            _WorkCet.btnPrint.Visible = false;
            _WorkCet.btnAdd.Location = new Point(182, 443);
            _WorkCet.btnCancel.Location = new Point(304, 443);
            _WorkCet.Show();
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

                            dgvCetificate.DataSource = crud.search_moreTables("e.date_Naissance,e.lieu_Naissance,e.adresse,t.fonction,t.date_Engage, c.numRef, c.date_Fin, c.file_Name, c.créé_le, c.créé_par", "T_Cert", "left join T_Contrat t on t.id_Emp=e.id_Emp", "nom", txtSearch.Text).Tables[0];
                        }
                        break;

                    case 1:
                        if (txtSearch.Text != "")
                        {
                            dgvCetificate.DataSource = crud.search_moreTables("e.date_Naissance,e.lieu_Naissance,e.adresse,t.fonction,t.date_Engage, c.numRef, c.date_Fin, c.file_Name, c.créé_le, c.créé_par", "T_Cert", "left join T_Contrat t on t.id_Emp=e.id_Emp", "numRef", txtSearch.Text).Tables[0];
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
                    string deleteRow = dgvCetificate.CurrentRow.Cells["numRef"].Value.ToString();
                    crud.crudop("delete from T_Cert where numRef = '" + deleteRow + "'");
                    
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Suppresion de certificat','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
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
            Form_WorkCet _WorkCet = new Form_WorkCet();
            _WorkCet.txtNumber.Text = dgvCetificate.CurrentRow.Cells[8].Value.ToString();
            _WorkCet.txtLName.Text = dgvCetificate.CurrentRow.Cells[1].Value.ToString();
            _WorkCet.txtName.Text = dgvCetificate.CurrentRow.Cells[2].Value.ToString();
            _WorkCet.dtpBirth.Text = dgvCetificate.CurrentRow.Cells[3].Value.ToString();
            _WorkCet.txtPBirth.Text = dgvCetificate.CurrentRow.Cells[4].Value.ToString();
            _WorkCet.txtAddress.Text = dgvCetificate.CurrentRow.Cells[5].Value.ToString();
            _WorkCet.txtJob.Text = dgvCetificate.CurrentRow.Cells[6].Value.ToString();
            _WorkCet.dtpRecruit.Text = dgvCetificate.CurrentRow.Cells[7].Value.ToString();
            _WorkCet.dtpTil.Text = dgvCetificate.CurrentRow.Cells[9].Value.ToString();
            _WorkCet.fileDate.Text = dgvCetificate.CurrentRow.Cells[11].Value.ToString();
            _WorkCet.txtUser.Text = dgvCetificate.CurrentRow.Cells[12].Value.ToString();
            _WorkCet.btnAdd.Visible = false;
            _WorkCet.btnUpdate.Visible = false;
            _WorkCet.btnCancel.Visible = false;
            _WorkCet.btnPrint.Location = new Point(243, 443);
            foreach (var txt in _WorkCet.Controls.OfType<TextBox>())
            {
                txt.ReadOnly = true;
            }
            foreach (var dtp in _WorkCet.Controls.OfType<DateTimePicker>())
            {
                dtp.Enabled = false;
            }
            _WorkCet.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtFileName.Text = dgvCetificate.CurrentRow.Cells[10].Value.ToString();
            if (crud.check_Id("T_Cert", "file_Name", txtFileName.Text) == "Code exists")
            {
                string num = dgvCetificate.CurrentRow.Cells["numRef"].Value.ToString();
                crud.openFile(num, "T_Cert", "numRef");

            }
            else
            {
                MessageBox.Show("Il n'y a pas de fichier importé");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            txtFileName.Text = dgvCetificate.CurrentRow.Cells[10].Value.ToString();
            if (crud.check_Id("T_Cert", "file_Name", txtFileName.Text) == "Code exists")
            {
                var confirmResult = MessageBox.Show("Il y a déjà un fichier importé\nVoulez-vous le changer?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.ShowDialog();
                    txtFilePath.Text = dlg.FileName;
                    string num = dgvCetificate.CurrentRow.Cells["numRef"].Value.ToString();
                    crud.saveFile0(txtFilePath.Text, num, "T_Cert", "numRef");
                    MessageBox.Show("Fichier importé avec succès");
                    
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Importation de Certificat','" + user + "','" + DateTime.Now + "')");

                }
            }
            else
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.ShowDialog();
                txtFilePath.Text = dlg.FileName;
                string num = dgvCetificate.CurrentRow.Cells["numRef"].Value.ToString();
                crud.saveFile0(txtFilePath.Text, num, "T_Cert", "numRef");
                MessageBox.Show("Fichier importé avec succès");
                
                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Importation de Certificat','" + user + "','" + DateTime.Now + "')");

            }
        }
    }
}
