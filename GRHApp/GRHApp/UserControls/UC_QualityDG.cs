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
    public partial class UC_QualityDG : UserControl
    {
        public UC_QualityDG()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        public void display()
        {
            dgvQualiteDG.DataSource = crud.getCustom("select refNum, titre, révision, _date, file_Name, créé_le, créé_par, modifié_le, modifié_par from T_Qualité where categorie='DG'");
            dgvQualiteDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void display0()
        {
            dgvQualiteDG.DataSource = crud.getCustom("select refNum, titre, révision, _date, file_Name from T_Qualité where categorie='DG'");
            dgvQualiteDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_QualiteUpdate _QualiteUpdate = new Form_QualiteUpdate();
            _QualiteUpdate.btnUpdate.Visible = false;
            _QualiteUpdate.txtCateg.Text = "DG";
            _QualiteUpdate.Show();
        }

        string userName = Settings.Default.userName;
        private void UC_QualityDG_Load(object sender, EventArgs e)
        {
            try
            {
                cbSearch.SelectedIndex = 2;
                if (crud.getUserPerm(userName, "utl") != "Faire tout")
                {
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    display0();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                            dgvQualiteDG.DataSource = crud.searchCustom("refNum, titre, révision, _date, file_Name, créé_le, créé_par, modifié_le, modifié_par", "categorie = 'DG' and titre", txtSearch.Text, "T_Qualité").Tables[0];
                        }
                        break;

                    case 1:
                        if (txtSearch.Text != "")
                        {
                            dgvQualiteDG.DataSource = crud.searchCustom("refNum, titre, révision, _date, file_Name, créé_le, créé_par, modifié_le, modifié_par", "categorie = 'DG' and refNum", txtSearch.Text, "T_Qualité").Tables[0];
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
                    string deleteRow = dgvQualiteDG.CurrentRow.Cells["refNum"].Value.ToString();
                    crud.crudop("delete from T_Qualité where refNum = '" + deleteRow + "'");

                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Suppression de document DG','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                }
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string titre = dgvQualiteDG.CurrentRow.Cells[1].Value.ToString();
            txtFileName.Text = dgvQualiteDG.CurrentRow.Cells[4].Value.ToString();
            if (crud.check_Id("T_Qualité", "file_Name", txtFileName.Text) == "Code exists")
            {
                string num = dgvQualiteDG.CurrentRow.Cells["refNum"].Value.ToString();
                crud.openFile(num, "T_Qualité", "refNum");

                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Consultation de document " + titre + "','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
            }
            else
            {
                MessageBox.Show("Il n'y a pas de fichier importé");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form_QualiteUpdate form_Qualite = new Form_QualiteUpdate();
            form_Qualite.btnAdd.Visible = false;
            form_Qualite.txtRef.Text = dgvQualiteDG.CurrentRow.Cells[0].Value.ToString();
            form_Qualite.txtTitle.Text = dgvQualiteDG.CurrentRow.Cells[1].Value.ToString();
            form_Qualite.txtRevision.Text = dgvQualiteDG.CurrentRow.Cells[2].Value.ToString();
            form_Qualite.dtp.Text = dgvQualiteDG.CurrentRow.Cells[3].Value.ToString();
            form_Qualite.txtFileName.Text = dgvQualiteDG.CurrentRow.Cells[4].Value.ToString();
            form_Qualite.txtRef.ReadOnly = true;
            form_Qualite.Show();
        }
    }
}
