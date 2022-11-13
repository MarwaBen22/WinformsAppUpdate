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
    public partial class Form_FPoste : Form
    {
        public Form_FPoste()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            e.Graphics.DrawString(" Ministère du travail et de l'emploi et sécurité social ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(220, 60));
            e.Graphics.DrawString(" Agence National de l'Emploi ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(310, 80));
            e.Graphics.DrawString(" AWEM BOUISMAIL ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(350, 100));
            e.Graphics.DrawString(" Fiche de poste ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(370, 120));
            e.Graphics.DrawString(" (Prise d'offre nationale) ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(340, 140));
            e.Graphics.DrawString(" Ref: " + "/GRH CSC EXP-SPA/"+ DateTime.Now.ToString("yyyy"), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 180));
            e.Graphics.DrawString(" Bouismail: " + DateTime.Now.ToShortDateString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(560, 180));
            e.Graphics.DrawString(" La fiche de recrutement N°: ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("  " + txtDRref.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(225, 200));
            e.Graphics.DrawString(" Indentification de l'entreprise: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 230));
            e.Graphics.DrawString(" EPE CSC Expertise Spa ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(275, 230));
            e.Graphics.DrawString(" Branche d'activité: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString(" Soudage, contrôle industriel...............Secteur juridique: EPE SPA ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(195, 250));
            e.Graphics.DrawString(" Adresse: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 270));
            e.Graphics.DrawString(" Zone Industriel N°30 BouIsmail W.Tipaza ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(120, 270));
            e.Graphics.DrawString(" Tél: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 290));
            e.Graphics.DrawString(" 024-32-57-68 / 0661-49-55-96 ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(85, 290));
            e.Graphics.DrawString(" Email: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 310));
            e.Graphics.DrawString(" cscexpertise.servicegrh@gmail.com / chargee.etude1.grh@cscexpertisespa.dz ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(100, 310));
            e.Graphics.DrawString(" Responsable de recrutement: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 330));
            e.Graphics.DrawString(" BENAMROUCHE Yasmina ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(273, 330));
            e.Graphics.DrawString(" Nombre du poste à pouvoir: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("  " + txtPNumber.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(255, 350));
            e.Graphics.DrawString(" Nature du poste de travail à occuper: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 370));
            e.Graphics.DrawString("  " + txtPNature.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(320, 370));
            e.Graphics.DrawString(" Sexe: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 390));
            e.Graphics.DrawString("  " + txtGender.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 390));
            e.Graphics.DrawString(" Poste / profil recherché: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 410));
            e.Graphics.DrawString("  " + txtPost.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(225, 410));
            e.Graphics.DrawString(" Description des taches à accomplir: ", new Font("Arial", 11, FontStyle.Underline), Brushes.Black, new Point(50, 430));
            e.Graphics.DrawString(" Diplôme: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("  " + txtDiplome.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(118, 450));
            e.Graphics.DrawString(" Niveau d'instruction: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 470));
            e.Graphics.DrawString("  " + txtLevel.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(200, 470));
            e.Graphics.DrawString(" Age: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 490));
            e.Graphics.DrawString("  " + txtAge.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(85, 490));
            e.Graphics.DrawString(" Maitrise des langues: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 510));
            e.Graphics.DrawString("  " + txtLanguage.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(205, 510));
            e.Graphics.DrawString(" Expérience: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 530));
            e.Graphics.DrawString("  " + txtExperience.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(135, 530));
            e.Graphics.DrawString(" Logiciel: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 550));
            e.Graphics.DrawString("  " + txtSoftware.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(115, 550));
            e.Graphics.DrawString(" Autre Compétence / connaissance: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 570));
            e.Graphics.DrawString("  " + txtOthCimpt.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(305, 570));
            e.Graphics.DrawString(" Condition de travail et avantages: ", new Font("Arial", 11, FontStyle.Underline), Brushes.Black, new Point(50, 590));
            e.Graphics.DrawString(" Bonne état de santé ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 610));
            e.Graphics.DrawString(" Projet: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 630));
            e.Graphics.DrawString("  " + txtProject.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(100, 630));
            e.Graphics.DrawString(" Lieu de travail: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 650));
            e.Graphics.DrawString("  " + txtWorkPlace.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(160, 650));
            e.Graphics.DrawString(" Hébergement: indemnité", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 670));
            e.Graphics.DrawString(" Restauration: indemnité", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 690));
            e.Graphics.DrawString(" Permis de conduite: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 710));
            e.Graphics.DrawString("  " + txtDriveL.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(200, 710));
            e.Graphics.DrawString(" Transport: indemnité", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 730));
            e.Graphics.DrawString(" Salaire (fourchettes): Selon grille de salaire de la société ou projet (diplôme / qualification /", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 750));
            e.Graphics.DrawString(" expérience) ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 770));
            e.Graphics.DrawString(" Autre information utiles: ", new Font("Arial", 11, FontStyle.Underline), Brushes.Black, new Point(50, 790));
            e.Graphics.DrawString(" Résidence: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 810));
            e.Graphics.DrawString("  " + txtResident.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 810));

            e.Graphics.DrawString(" Sans précèdent judiciaire. ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 830));
            e.Graphics.DrawString(" Aptitude Médicale pour le poste / Test Covid  Négatif.", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 850));


            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDRref.Text == "")
                {
                    MessageBox.Show("Veuillez entrer le numéro de référence.");
                }
                else
                {
                    txtPNumber.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item2;
                    txtPNature.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item3;
                    txtGender.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item4;
                    txtPost.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item5;
                    txtDiplome.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item6;
                    txtLevel.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item7;
                    txtAge.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item8;
                    txtLanguage.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item9;
                    txtExperience.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item10;
                    txtSoftware.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item11;
                    txtOthCimpt.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item12;
                    txtProject.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item13;
                    txtWorkPlace.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item14;
                    txtDriveL.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item15;
                    txtResident.Text = crud.getInfoForANEM(txtDRref.Text, "num_ref").Item16;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txtRefNum.Text = "";
            txtDRref.Text = "";
            txtPNature.Text = "";
            txtPNumber.Text = "";
            txtGender.Text = "";
            txtPost.Text = "";
            txtDiplome.Text = "";
            txtLevel.Text = "";
            txtAge.Text = "";
            txtLanguage.Text = "";
            txtExperience.Text = "";
            txtSoftware.Text = "";
            txtOthCimpt.Text = "";
            txtProject.Text = "";
            txtDriveL.Text = "";
            txtResident.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                crud.crudop("insert into (numRef, date_Fiche, ref_DR) T_FPoste values ('" + txtRefNum.Text + "',CONVERT (datetime, '" + DateTime.Now + "', 121), '" + txtDRref.Text + "')");

                MessageBox.Show("Vos données ont été enregistrées");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
