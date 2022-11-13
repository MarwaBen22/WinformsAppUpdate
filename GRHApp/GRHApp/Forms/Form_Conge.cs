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
    public partial class Form_Conge : Form
    {
        public Form_Conge()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();
        public void clear()
        {
            txtLName.Text = "";
            txtName.Text = "";
            txtJob.Text = "";
            dtpRecruit.ResetText();
            txtNumDays.Text = "";
            //txtSearch.Text = "";
            txtNature.Text = "";
            //dtpFrom.ResetText();
            dtpTil.ResetText();
            dtpReturn.ResetText();
            txtRest.Text = "";
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
                
                if (txtNumber.Text == "" || txtLName.Text == "" || txtName.Text == "" || txtNature.Text == "" || txtRest.Text == "" || txtJob.Text == "")
                {
                    MessageBox.Show("Veuillez remplir les blans");
                }
                else
                {
                    if (crud.check_Id("T_Conge", "nom_Ref", txtNumber.Text) == "Code exists")
                    {
                        MessageBox.Show("Numéro de référence existe déja");
                        clear();
                    }
                    else
                    {
                        crud.crudop("insert into T_Conge (nom_Ref, id_Emp, nom_jours, nature_Conge, date_debut, date_Fin, reprise, conge_Restant, c.créé_le, c.créé_par) values ('" + txtNumber.Text + "','" + txtSearch.Text + "','" + txtNumDays.Text + "','" + txtNature.Text + "','" + dtpFrom.Value.ToShortDateString() + "','" + dtpTil.Value.ToShortDateString() + "','" + dtpReturn.Value.ToShortDateString() + "','" + Convert.ToInt32(txtRest.Text) + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'" + user + "')"); ; ;
                        
                        crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Ajout de titre de congé','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

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
            e.Graphics.DrawString(" TITRE DE CONGE ", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(250, 340));
            e.Graphics.DrawString(" Nous Soussignons, Société de Soudage, Controle et Expertise Industriels ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 420));
            e.Graphics.DrawString(" (EPE CSC Expertise spa) ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(70, 440));

            e.Graphics.DrawString(" Décidons que Madame/ Monsieur: ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 470));
            e.Graphics.DrawString(" Nom & Prénom:  ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(90, 500));
            e.Graphics.DrawString("   " + txtLName.Text + " " + txtName.Text + ".", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(205, 500));

            e.Graphics.DrawString(" Fonction:  ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(90, 520));
            e.Graphics.DrawString("   " + txtJob.Text + ".", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(155, 520));

            e.Graphics.DrawString(" Date de recrutement:  ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(90, 540));
            e.Graphics.DrawString("   " + dtpRecruit.Text + ".", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(250, 540));

            e.Graphics.DrawString(" Bénéficie d'un congé de:  ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 600));
            e.Graphics.DrawString("   " + txtNumDays.Text + "  jours.", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(255, 600));

            e.Graphics.DrawString(" Nature congé:  ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 630));
            e.Graphics.DrawString("   " + txtNature.Text + " .", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(140, 630));

            e.Graphics.DrawString(" A Compter du:  ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 660));
            e.Graphics.DrawString("   " + dtpFrom.Text + "  AU  " + dtpTil.Text + ".", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(175, 660));

            e.Graphics.DrawString(" La reprise de travail est fixée au:  ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 690));
            e.Graphics.DrawString("   " + dtpReturn.Text + ".", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(325, 690));

            e.Graphics.DrawString(" Droit de congé Restant:  ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(70, 720));
            e.Graphics.DrawString("   " + txtRest.Text + "  jours.", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(250, 720));

            e.Graphics.DrawString(" NB:  ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 780));
            e.Graphics.DrawString(" * Le salarié en congé peut être rappelé pour nécessité impérieuse de service.  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(90, 800));
            e.Graphics.DrawString(" * L'EPE CSC EXPERTISE SPA, se réserver le droit de compenser tous les droits de congé accordé indument.  ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(90, 830));
            e.Graphics.DrawString(" Chef département Administration et moyens. ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(400, 910));

            e.Graphics.DrawString(" Direction Général N°30 Zone Industrielle de Bou Ismail Wilaya de Tipaza Tel/fax: (024)32.57.72 ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(100, 1050));
            e.Graphics.DrawString(" Département Administration et moyen Tel/fax: (024)32.57.68 ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(220, 1070));
            e.Graphics.DrawString(" Site Web: ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(320, 1090));
            e.Graphics.DrawString(" www.cscexpertisespa.dz ", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, new Point(380, 1090));

            e.Graphics.DrawString("    " + txtUser.Text + " \n" + fileDate.Value, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 1070));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;

            crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Impression de titre de congé','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumDays.Text == "")
            {
                MessageBox.Show("Veuillez remplir le nombre de jours de congé");
            }
            else
            {
                int NumDays = Convert.ToInt32(txtNumDays.Text)-1;
                dtpTil.Value = dtpFrom.Value.AddDays(NumDays);
                dtpReturn.Value = dtpTil.Value.AddDays(1);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                crud.crudop("update T_Conge set nom_jours='" + txtNumDays.Text + "',nature_Conge='" + txtNature.Text + "',date_debut='" + dtpFrom.Value.ToShortDateString() + "',date_Fin='" + dtpTil.Value.ToShortDateString() + "',reprise='" + dtpReturn.Value.ToShortDateString() + "',conge_Restant='" + txtRest.Text + "' where nom_Ref='" + txtNumber.Text + "'");
                MessageBox.Show("Vos données ont été mises à jour");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
