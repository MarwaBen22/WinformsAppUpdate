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

namespace GRHApp.Forms
{
    public partial class ResetPW1 : Form
    {
        public ResetPW1()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();
        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "   Nouveau mot de passe")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtConfirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtConfirmPassword.Text == "   Confirmer le mot de passe")
            {
                txtConfirmPassword.Clear();
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void pcbPW_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
                txtPassword.PasswordChar = '\0';
        }

        private void pcbPW_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
                txtPassword.PasswordChar = '*';
        }

        private void pcbConfirmPW_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '*')
                txtConfirmPassword.PasswordChar = '\0';
        }

        private void pcbConfirmPW_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '\0')
                txtConfirmPassword.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtPassword.Text == "   Nouveau mot de passe" || txtConfirmPassword.Text == "" || txtConfirmPassword.Text == "   Confirmer le mot de passe")
            {
                MessageBox.Show("Veuillez saisir vos données");
            }
            else
            {
                crud.crudop("update T_Login set user_PW='" + txtConfirmPassword.Text + "' where user_Email='" + lblHiddenEmail.Text + "'");

                MessageBox.Show("Mot de passe modifié");
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                lblCheckPW.Text = "Mot de passe incorrect";
            }
            else
            {
                lblCheckPW.Text = "";
            }
        }

        private void ResetPW1_Load(object sender, EventArgs e)
        {
            /*ResetPW resetPW = new ResetPW();
            lblHiddenEmail.Text = resetPW.txtEmail.Text;*/
        }
    }
}
