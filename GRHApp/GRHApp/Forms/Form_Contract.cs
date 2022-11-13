using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRHApp.Classes;

namespace GRHApp.Forms
{
    public partial class Form_Contract : Form
    {
        public Form_Contract()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtNumber.Text = "";
            txtLName.Text = "";
            txtName.Text = "";
            txtPost.Text = "";
            txtSalary.Text = "";
            dtpConStart.ResetText();
            dtpEnd.ResetText();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        crudClass crud = new crudClass();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumber.Text == "" || txtLName.Text == "" || txtName.Text == "" || txtPost.Text == "" || txtSalary.Text == "")
                {
                    MessageBox.Show("Veuillez remplir les blans");
                }
                else
                {
                    if (crud.check_Id("T_Contract", "num_Contract", txtNumber.Text) == "Code exists")
                    {
                        MessageBox.Show("Numéro de contrat existe déja");
                        clear();
                    }
                    else
                    {
                        crud.saveFile(txtFilePath.Text, txtNumber.Text, txtMatr.Text, txtPost.Text, txtSalary.Text, dtpConStart.Value, dtpEnd.Value);
                        MessageBox.Show("Vos données ont été enregistrées");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFilePath.Text = dlg.FileName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Les modifications que vous avez apportées ne seront pas sauvegardées", "Confirmation", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumber.Text == "" || txtLName.Text == "" || txtName.Text == "" || txtPost.Text == "" || txtSalary.Text == "")
                {
                    MessageBox.Show("Veuillez remplir les blans");
                }
                else
                {
                    crud.crudop("update T_Contract set num_Contract= '" + txtNumber.Text + "' ,id_Emp='" + txtMatr.Text + "',poste='" + txtPost.Text + "',salaire_Base='" + txtSalary.Text + "',date_Debut='" + dtpConStart.Value.ToShortDateString() + "',date_Fin='" + dtpEnd.Value.ToShortDateString() + "' where num_Contract = '" + txtNumber.Text + "'");
                    MessageBox.Show("Vos données ont été mises à jour");
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
