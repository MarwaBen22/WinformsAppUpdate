using GRHApp.Properties;
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

namespace GRHApp.UserControls
{
    public partial class UC_MyAccount : UserControl
    {
        public UC_MyAccount()
        {
            InitializeComponent();
            txtUserN.Text = Settings.Default.userName;
        }

        crudClass crud = new crudClass();
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            crud.crudop("update T_Login set user_Email='" + txtEmail.Text + "', user_PW='" + txtConfirm.Text + "' where name='" + txtUserN.Text + "'");
            MessageBox.Show("Vos données ont été mises à jour");
        }

        public void clear()
        {
            txtEmail.Text = "";
            txtNewPassword.Text = "";
            txtConfirm.Text = "";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void UC_MyAccount_Load(object sender, EventArgs e)
        {
            txtEmail.Text = crud.getAccountInfo(txtUserN.Text, "name").Item2 ;
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirm.Text != txtNewPassword.Text)
            {
                lblAlert.Text = "Mot de passe incorrect";
            }
            else
            {
                lblAlert.Text = "";
            }
        }
    }
}
