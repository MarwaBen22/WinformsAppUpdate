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
using System.Net.Mail;
using System.Net;

namespace GRHApp.Forms
{
    public partial class ResetPW : Form
    {
        public ResetPW()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "   Adresse e-mail")
            {
                txtEmail.Clear();
            }
        }

        private void txtVerificationCode_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtVerificationCode.Text == "   Code de vérification")
            {
                txtVerificationCode.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtEmail.Text == "   Adresse e-mail")
            {
                MessageBox.Show("Veuillez saisir votre adresse e-mail");
            }
            else
            {
                if (crud.check_Id("T_Login", "user_Email", txtEmail.Text) == "Code exists")
                {
                    sendEmail();
                    button1.Visible = true;
                    txtVerificationCode.Visible = true;
                    pictureBox1.Visible = true;
                    btnLogin.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cet email n'existe pas dans notre base de données");
                }
            }
        }

        string randomCode;
        public static string to;
        private void sendEmail()
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage msg = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "mb5176581@gmail.com";
            pass = "vwvoasmealhqljvv";
            messageBody = "Votre code de réinitialisation de mot de passe est:    " + randomCode;
            msg.To.Add(to);
            msg.From = new MailAddress(from);
            msg.Body = messageBody;
            msg.Subject = "Réinitialisation du mot de passe ";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(msg);
                MessageBox.Show("Code envoyé avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtVerificationCode.Text == "" || txtVerificationCode.Text == "   Code de vérification")
            {
                MessageBox.Show("Veuillez entrer le code que vous avez reçu");
            }
            else
            {
                if (randomCode == txtVerificationCode.Text)
                {
                    to = txtEmail.Text;
                    ResetPW1 resetPW1 = new ResetPW1();
                    resetPW1.lblHiddenEmail.Text = to;
                    resetPW1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ce code est incorrect\n Veuillez vérifier à nouveau");

                }
            }
        }
    }
}
