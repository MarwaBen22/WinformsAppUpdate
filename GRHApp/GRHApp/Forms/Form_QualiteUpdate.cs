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
using GRHApp.Properties;

namespace GRHApp.Forms
{
    public partial class Form_QualiteUpdate : Form
    {
        public Form_QualiteUpdate()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (crud.check_Id("T_Qualité", "file_Name", txtFileName.Text) == "Code exists")
            {
                var confirmResult = MessageBox.Show("Il y a déjà un fichier importé\nVoulez-vous le changer?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.ShowDialog();
                    txtFilePath.Text = dlg.FileName;
                }
            }
            else
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.ShowDialog();
                txtFilePath.Text = dlg.FileName;

            }
        }

        string user = Settings.Default.userName;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (crud.check_Id("T_Qualité", "refNum", txtRef.Text) == "Code exists")
                {
                    MessageBox.Show("Matricule existe déja");
                    clear();
                }
                else
                {
                    string num = txtRef.Text;
                    crud.saveFiles(txtFilePath.Text, num, txtTitle.Text, txtRevision.Text, dtp.Value, txtCateg.Text, DateTime.Now, user, "T_Qualité");
                    MessageBox.Show("Vos données ont été enregistrées");
                    clear();

                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Ajout de nouveau document " + txtCateg.Text + "','" + user + "','" + DateTime.Now + "')");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txtRef.Text = "";
            txtTitle.Text = "";
            txtRevision.Text = "";
            dtp.ResetText();
            txtFileName.Text = "";
            txtFilePath.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                crud.crudop("update T_Qualité set titre='" + txtTitle.Text + "',révision='" + txtRevision.Text + "',_date='" + dtp.Value.ToShortDateString() + "',modifié_le=CONVERT (datetime, '" + DateTime.Now + "', 121),modifié_par='" + user + "' where refNum='" + txtRef.Text + "'");
                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Modification de " + txtTitle.Text + "','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                MessageBox.Show("Vos données ont été mises à jour");
                clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Form_QualiteUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Les modifications que vous avez apportées ne seront pas sauvegardées", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
