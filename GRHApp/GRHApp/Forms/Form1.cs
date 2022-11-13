using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRHApp.Forms;
using GRHApp.Classes;
using GRHApp.Properties;
using System.IO;

namespace GRHApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();
        private void btnClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Voulez-vous sortir de l'application?", "Confirmation", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "   Nom d'utilisateur")
            {
                txtUserName.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "   Mot de passe")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "   Mot de passe";
            txtUserName.Text = "   Nom d'utilisateur";
            txtPassword.PasswordChar = '\0';
        }

        private void pcbPassword_Click(object sender, EventArgs e)
        {

        }

        private void pcbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            txtPassword.PasswordChar = '\0';
        }

        private void pcbPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
                txtPassword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPW resetPW = new ResetPW();
            resetPW.Show();
            this.Hide();
        }

        public void showRecNotif()
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"Images\4696645_alert_audio_bell_notification_sound_icon.ico"));
            notifyIcon1.Text = "Some text goes here.";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipText = "Fiche de recrutement";
            notifyIcon1.ShowBalloonTip(10000);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtUserName.Text == "   Nom d'utilisateur" || txtPassword.Text == "" || txtPassword.Text == "   Mot de passe")
            {
                MessageBox.Show("Veuillez saisir vos données");
            }
            else
            {
                if (crud.check_PW(txtUserName.Text, txtPassword.Text) == "all correct")
                {

                    Settings.Default.userName = txtUserName.Text;

                    Form_Module _Module = new Form_Module();
                    if (crud.getAlertInfo(Settings.Default.userName, "alrt_To").Item2 == "En attente")
                    {
                        showRecNotif();
                    }
                    else
                    {
                        _Module.lblGRH.Image = null;
                    }
                    //Form_Module _Module = new Form_Module();
                    _Module.Show();

                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Login','" + txtUserName.Text + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Le nom d'utilisateur ou le mot de passe saisi est incorrect, veuillez réessayer");

                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
