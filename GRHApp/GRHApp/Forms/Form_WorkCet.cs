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
    public partial class Form_WorkCet : Form
    {
        public Form_WorkCet()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();

        public void clear()
        {
            txtSearch.Text = "";
            txtNumber.Text = "";
            txtLName.Text = "";
            txtName.Text = "";
            dtpBirth.ResetText();
            txtPBirth.Text = "";
            txtAddress.Text = "";
            txtJob.Text = "";
            dtpRecruit.ResetText();
            dtpTil.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        string user = Settings.Default.userName;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtNumber.Text == "" || txtLName.Text == "" || txtName.Text == "" || txtPBirth.Text == "" || txtAddress.Text == "" || txtJob.Text == "")
                {
                    MessageBox.Show("Veuillez remplir les blans");
                }
                else
                {
                    if (crud.check_Id("T_Cert", "numRef", txtNumber.Text) == "Code exists")
                    {
                        MessageBox.Show("Numéro de certificat existe déja");
                        clear();
                    }
                    else
                    {
                        crud.crudop("insert into T_Cert (numRef, id_Emp, date_Fin, c.créé_le, c.créé_par) values ('" + txtNumber.Text + "','" + txtSearch.Text + "','" + dtpTil.Value.ToShortDateString() + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'" + user + "')");
                        
                        crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Ajout de certificat','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                        MessageBox.Show("Vos données ont été enregistrées");
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (crud.check_Id("T_EmployeInfo", "id_Emp", txtSearch.Text) == "Code exists")
                {
                    if (txtSearch.Text != "")
                    {
                        txtLName.Text = crud.getEmployee(txtSearch.Text, "e.id_Emp").Item1;
                        txtName.Text = crud.getEmployee(txtSearch.Text, "e.id_Emp").Item2;
                        dtpBirth.Text = crud.getEmployee(txtSearch.Text, "e.id_Emp").Item3;
                        txtPBirth.Text = crud.getEmployee(txtSearch.Text, "e.id_Emp").Item4;
                        txtAddress.Text = crud.getEmployee(txtSearch.Text, "e.id_Emp").Item5;
                        txtJob.Text = crud.getEmployee(txtSearch.Text, "e.id_Emp").Item6;
                        dtpRecruit.Text = crud.getEmployee(txtSearch.Text, "e.id_Emp").Item7;
                    }
                }
                else
                {
                    MessageBox.Show("Matricule n'existe pas");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            System.Drawing.Image img = System.Drawing.Image.FromFile(@"D:\logo expertise.png");
            e.Graphics.DrawImage(img, 50, 50, 100, 110);

            e.Graphics.DrawString("الجمهورية الجزائرية الديمقراطية الشعبية", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(250, 30));
            e.Graphics.DrawString(" وزارة التعليم العالي و البحث العلمي ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(255, 60));
            e.Graphics.DrawString(" المديرية العامة للبحث العلمي و التطوير التكنولوجي ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(205, 90));
            e.Graphics.DrawString(" CRTI مركز البحث في التكنولوجيات الصناعية ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(210, 120));
            e.Graphics.DrawString(" مؤسسة الإلحام المراقبة و الخبرة الصناعية -شركة ذات أسهم ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(175, 150));
            e.Graphics.DrawString(" EPE-C.S.C Expertise Spa Filiale de CRTI ", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(170, 180));
            e.Graphics.DrawString(" Capital social: 70 000 000 DA Filiale à 100% du C.R.T.I Ex C.S.C-MESRS ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 220));
            e.Graphics.DrawString(" _________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 230));

            e.Graphics.DrawString(" Réf N°: " + txtNumber.Text + "/GRH/CSCEXP/" + DateTime.Now.ToString("yyyy"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 270));
            e.Graphics.DrawString(" BOU-ISMAIL le  " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Underline), Brushes.Black, new Point(550, 290));
            e.Graphics.DrawString(" CERTIFICAT DE TRAVAIL ", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(200, 340));
            e.Graphics.DrawString(" Nous, Soussignons EPE CSC Expertise spa/Filiale 100% CRTI sise à ZONE ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 420));
            e.Graphics.DrawString(" INDUSTRIELLE N°30 BOU-ISMAIL wilaya TIPAZA ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 440));
            e.Graphics.DrawString(" Attestons que Mme/Mr: ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 480));
            e.Graphics.DrawString("  " + txtLName.Text + "  " + txtName.Text + " .", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(250, 480));

            e.Graphics.DrawString(" Né le: ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 510));
            e.Graphics.DrawString("  " + dtpBirth.Value.ToShortDateString() + " à " + txtPBirth.Text + " .", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(120, 510));

            e.Graphics.DrawString(" Demeurant à: ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 540));
            e.Graphics.DrawString("  " + txtAddress.Text + " .", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(175, 540));

            e.Graphics.DrawString(" A été employé au sein de notre entreprise du: ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 570));
            e.Graphics.DrawString("  " + dtpRecruit.Value.ToShortDateString() + " au " + dtpTil.Value.ToShortDateString() + ".", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(430, 570));

            e.Graphics.DrawString(" En quanlité de: ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 600));
            e.Graphics.DrawString("  " + txtJob.Text + " .", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(185, 600));

            e.Graphics.DrawString(" Le présente certificat est délivrée pour servir et valoir ce que de droit. ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 650));
            e.Graphics.DrawString(" Chef département Administration et moyens. ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(400, 730));

            e.Graphics.DrawString(" NB: le présent certificat est délivré en deux exemplaires originaux d'en un est un remis à l'intéressé. ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 850));
            e.Graphics.DrawString(" Direction Général N°30 Zone Industrielle de Bou Ismail Wilaya de Tipaza Tel/fax: (024)32.57.72 ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(100, 1050));
            e.Graphics.DrawString(" Département Administration et moyen Tel/fax: (024)32.57.68 ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(220, 1070));
            e.Graphics.DrawString(" Site Web: ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(320, 1090));
            e.Graphics.DrawString(" www.cscexpertisespa.dz ", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, new Point(380, 1090));

            e.Graphics.DrawString("    " + txtUser.Text + " \n" + fileDate.Value, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 1070));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;

            crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Impression de certificat','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

        }
    }
}
