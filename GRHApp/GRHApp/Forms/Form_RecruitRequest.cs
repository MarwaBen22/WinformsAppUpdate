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
    public partial class Form_RecruitRequest : Form
    {
        public Form_RecruitRequest()
        {
            InitializeComponent();

            string candidat1 = txtCandidat1.Text;
            pnlPourvoi.Visible = true;
            pnlButtons.AutoScroll = false;
            pnlButtons.HorizontalScroll.Enabled = false;
        }


        crudClass crud = new crudClass();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public int scrollValue = 0;
        public int ScrollValue
        {
            get
            {
                return scrollValue;
            }
            set
            {
                scrollValue = value;
                pnlButtons.HorizontalScroll.Maximum = 700;

                if (scrollValue < pnlButtons.HorizontalScroll.Minimum)
                {
                    scrollValue = pnlButtons.HorizontalScroll.Minimum;
                }
                if (scrollValue > pnlButtons.HorizontalScroll.Maximum)
                {
                    scrollValue = pnlButtons.HorizontalScroll.Maximum;
                }

                pnlButtons.HorizontalScroll.Value = scrollValue;
                pnlButtons.PerformLayout();

            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            ScrollValue -= pnlButtons.HorizontalScroll.LargeChange;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ScrollValue += pnlButtons.HorizontalScroll.LargeChange;
        }

        string Gender;
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Féminin";
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Masculin";
        }

        private void btnPourvoi_Click(object sender, EventArgs e)
        {
            if (pnlPourvoi.Visible == false)
            {
                pnlPourvoi.Visible = true;
                pnlMotif.Visible = false;
                pnlCritic.Visible = false;
                pnlOpportunité.Visible = false;
                pnlEntretien.Visible = false;
                pnlRenseignement.Visible = false;
            }
            
        }

        private void btnMotif_Click(object sender, EventArgs e)
        {
            if (pnlMotif.Visible == false)
            {
                pnlPourvoi.Visible = false;
                pnlMotif.Visible = true;
                pnlCritic.Visible = false;
                pnlOpportunité.Visible = false;
                pnlEntretien.Visible = false;
                pnlRenseignement.Visible = false;
            }
        }

        private void btnCritere_Click(object sender, EventArgs e)
        {
            if (pnlCritic.Visible == false)
            {
                pnlPourvoi.Visible = false;
                pnlMotif.Visible = false;
                pnlCritic.Visible = true;
                pnlOpportunité.Visible = false;
                pnlEntretien.Visible = false;
                pnlRenseignement.Visible = false;
            }
        }

        string license;
        private void rbDriveY_CheckedChanged(object sender, EventArgs e)
        {
            license = "OUI";
        }

        private void rbDriveN_CheckedChanged(object sender, EventArgs e)
        {
            license = "NON";
        }

        string motif;
        private void rb1Choice_CheckedChanged(object sender, EventArgs e)
        {
            motif = "1erChoix";
        }

        private void rb2Choice_CheckedChanged(object sender, EventArgs e)
        {
            motif = "2èmeChoix";
        }

        private void rb3Choice_CheckedChanged(object sender, EventArgs e)
        {
            motif = "3èmeChoix";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            motif = "4èmeChoix";
        }

        private void btnOpportunite_Click(object sender, EventArgs e)
        {
            if (pnlOpportunité.Visible == false)
            {
                pnlPourvoi.Visible = false;
                pnlMotif.Visible = false;
                pnlCritic.Visible = false;
                pnlOpportunité.Visible = true;
                pnlEntretien.Visible = false;
                pnlRenseignement.Visible = false;

            }
            pnlAppro.Visible = false;
            lblApprobation.Visible = false;
       
            lblOpportunity.Visible = true;
                pnlYN0.Visible = true;
        }

        private void btnApprobation_Click(object sender, EventArgs e)
        {
            if (pnlOpportunité.Visible == false)
            {
                pnlPourvoi.Visible = false;
                pnlMotif.Visible = false;
                pnlCritic.Visible = false;
                pnlOpportunité.Visible = true;
                pnlEntretien.Visible = false;
                pnlRenseignement.Visible = false;
            }
            lblOpportunity.Visible = false;
            pnlYN0.Visible = false;
            pnlAppro.Visible = true;
            lblApprobation.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlEntretien.Visible == false)
            {
                pnlPourvoi.Visible = false;
                pnlMotif.Visible = false;
                pnlCritic.Visible = false;
                pnlOpportunité.Visible = false;
                pnlEntretien.Visible = true;
                pnlRenseignement.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pnlRenseignement.Visible == false)
            {
                pnlPourvoi.Visible = false;
                pnlMotif.Visible = false;
                pnlCritic.Visible = false;
                pnlOpportunité.Visible = false;
                pnlEntretien.Visible = false;
                pnlRenseignement.Visible = true;
            }
        }

        public void clear()
        {
            txtPost.Text = "";
            txtNumber.Text = "";
            txtFormation.Text = "";
            txtAge.Text = "";
            if (rbFemale.Checked == true)
            {
                rbFemale.Checked = false;
            }
            if (rbMale.Checked == true)
            {
                rbMale.Checked = false;
            }
            if (rb1Choice.Checked == true)
            {
                rb1Choice.Checked = false;
            }
            if (rb2Choice.Checked == true)
            {
                rb2Choice.Checked = false;
            }
            if (rb3Choice.Checked == true)
            {
                rb3Choice.Checked = false;
            }
            if (rb4Choice.Checked == true)
            {
                rb4Choice.Checked = false;
            }
            txtOther.Text = "";
            txtBasicForm.Text = "";
            txtExperience.Text = "";
            txtResident.Text = "";
            if (rbDriveY.Checked == true)
            {
                rbDriveY.Checked = false;
            }
            if (rbDriveN.Checked == true)
            {
                rbDriveN.Checked = false;
            }
            txtAvailable.Text = "";
            if (rbOpporY.Checked == true)
            {
                rbOpporY.Checked = false;
            }
            if (rbOpporN.Checked == true)
            {
                rbOpporN.Checked = false;
            }
            if (rbAccord.Checked == true)
            {
                rbAccord.Checked = false;
            }
            if (rbDiffer.Checked == true)
            {
                rbDiffer.Checked = false;
            }
            if (rbReject.Checked == true)
            {
                rbReject.Checked = false;
            }
            txtCandidat1.Text = "";
            txtCandidat2.Text = "";
            txtCandidat3.Text = "";
            txtCandidat4.Text = "";
            txtCandidat5.Text = "";
            txtCandidat6.Text = "";
            txtCandidat7.Text = "";
            txtCandidat8.Text = "";
            txtCandidat9.Text = "";
            txtCandidat10.Text = "";
            txtCandi1.Text = "";
            txtBForm1.Text = "";
            txtResid1.Text = "";
            txtFamSit1.Text = "";
            txtExp1.Text = "";
            txtCandi2.Text = "";
            txtBForm2.Text = "";
            txtResid2.Text = "";
            txtFamSit2.Text = "";
            txtExp2.Text = "";
            txtCandi3.Text = "";
            txtBForm3.Text = "";
            txtResid3.Text = "";
            txtFamSit3.Text = "";
            txtExp3.Text = "";
            txtCandi4.Text = "";
            txtBForm4.Text = "";
            txtResid4.Text = "";
            txtFamSit4.Text = "";
            txtExp4.Text = "";
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

                //txtCandidat2.Text = candidat1;
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

        int page = 1;
        string userName = Settings.Default.userName;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string visaChSt1 = crud.getRecSignatures(txtRef.Text, "num_ref").Item1;
            string visaDAM = crud.getRecSignatures(txtRef.Text, "num_ref").Item2;

            string visaCG = crud.getRecSignatures(txtRef.Text, "num_ref").Item4;
            
            string visaDG = crud.getRecSignatures(txtRef.Text, "num_ref").Item6;
            
            string visaGRH1 = crud.getRecSignatures(txtRef.Text, "num_ref").Item8;
            string visaChS2 = crud.getRecSignatures(txtRef.Text, "num_ref").Item9;

            string visa = crud.getRecSignatures(txtRef.Text, "num_ref").Item12;
            if (page == 1)
            { 
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
            e.Graphics.DrawString(" RH da 01 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
            e.Graphics.DrawString(" Réf N°:  " + txtRef.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 90));

            e.Graphics.DrawString(" Fiche de Recrutement ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(330, 120));
            
            e.Graphics.DrawString(" 1.Pourvoi de poste: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString(" Poste de travail: " + txtPost.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 180));
            e.Graphics.DrawString(" Nombre: [ " + txtNumber.Text + " ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(350, 180));
            e.Graphics.DrawString(" Formation: " + txtFormation.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString(" Age: " + txtAge.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 220));
            if (Gender == "Féminin")
            {
                e.Graphics.DrawString(" Sexe:       F [ + ]       M[  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 240));
            }
            else if (Gender == "Masculin")
            {
                e.Graphics.DrawString(" Sexe:       F [  ]       M[ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 240));
            }
            else
            {
                e.Graphics.DrawString(" Sexe:       F [  ]       M[  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 240));
            }

            e.Graphics.DrawString(" 2.Motif de pourvoi de poste: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 270));
            if (motif == "1erChoix")
            {
                e.Graphics.DrawString(" Surcroit temporaire de travail [ + ]       Remplacement d'un départ [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 300));
                e.Graphics.DrawString(" Remplacement temporaire d'un titulaire [  ]       Assurer ine relève [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 320));
                e.Graphics.DrawString(" Autres: " + txtOther.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 340));
            }
            else if (motif == "2èmeChoix")
            {
                e.Graphics.DrawString(" Surcroit temporaire de travail [  ]       Remplacement d'un départ [ + ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 300));
                e.Graphics.DrawString(" Remplacement temporaire d'un titulaire [  ]       Assurer ine relève [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 320));
                e.Graphics.DrawString(" Autres: " + txtOther.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 340));

            }
            else if (motif == "3èmeChoix")
            {
                e.Graphics.DrawString(" Surcroit temporaire de travail [  ]       Remplacement d'un départ [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 300));
                e.Graphics.DrawString(" Remplacement temporaire d'un titulaire [ + ]       Assurer ine relève [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 320));
                e.Graphics.DrawString(" Autres: " + txtOther.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 340));
            }
            else if (motif == "4èmeChoix")
            {
                e.Graphics.DrawString(" Surcroit temporaire de travail [  ]       Remplacement d'un départ [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 300));
                e.Graphics.DrawString(" Remplacement temporaire d'un titulaire [  ]       Assurer ine relève [ + ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 320));
                e.Graphics.DrawString(" Autres: " + txtOther.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 340));
            }
            else
            {
                e.Graphics.DrawString(" Surcroit temporaire de travail [  ]       Remplacement d'un départ [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 300));
                e.Graphics.DrawString(" Remplacement temporaire d'un titulaire [  ]       Assurer ine relève [  ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 320));
                e.Graphics.DrawString(" Autres: " + txtOther.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 340));
            }

            e.Graphics.DrawString(" Nature du poste de travail: " + jobNature, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 360));
            e.Graphics.DrawString(" Projets: " + txtProjects.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 380));
            e.Graphics.DrawString(" Lieu de travail: " + txtWorkPlace.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 400));

            e.Graphics.DrawString(" 3.Critère de sélection: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 430));
            e.Graphics.DrawString(" Formation de base: " + txtBasicForm.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 460));
            e.Graphics.DrawString(" Maitrise des langues: " + txtLanguages.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 480));
            
            e.Graphics.DrawString(" Expérience: " + txtExperience.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 500));

            e.Graphics.DrawString(" Résidence: " + txtResident.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 520));
            if (license == "OUI")
            {
                e.Graphics.DrawString(" Permis de conduire:       OUI [ + ]       NON [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 540));
            }
            else if (license == "NON")
            {
                e.Graphics.DrawString(" Permis de conduire:       OUI [  ]       NON [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 540));
            }
            else
            {
                e.Graphics.DrawString(" Permis de conduire:       OUI [  ]       NON [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 540));
            }
            e.Graphics.DrawString(" Disponibilité: " + txtAvailable.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 560));
            e.Graphics.DrawString(" Logiciel: " + txtSoftware.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 580));
            e.Graphics.DrawString(" Autre compétence: " + txtOthCompt.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 600));

            e.Graphics.DrawString(" 4.Opportunité de recrutement: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 630));
            if (opportune == "OUI")
            {
                e.Graphics.DrawString(" OUI [ + ]       NON [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 660));
            }
            else if (opportune == "NON")
            {
                e.Graphics.DrawString(" OUI [  ]       NON [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 660));
            }
            else
            {
                e.Graphics.DrawString(" OUI [  ]       NON [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 660));
            }

            e.Graphics.DrawString(" 5.Approbation DG: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 690));
            if (appro == "Accord")
            {
                e.Graphics.DrawString(" Recrutement accordé [ + ]       Différé [  ]       Rejeté [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 720));
            }
            else if (appro == "Differ")
            {
                e.Graphics.DrawString(" Recrutement accordé [  ]       Différé [ + ]       Rejeté [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 720));
            }
            else if (appro == "Rejete")
            {
                e.Graphics.DrawString(" Recrutement accordé [  ]       Différé [  ]       Rejeté [ + ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 720));
            }
            else
            {
                e.Graphics.DrawString(" Recrutement accordé [  ]       Différé [  ]       Rejeté [  ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 720));
            }

            e.Graphics.DrawString(" 6.Entretien d'embauche: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 750));
            e.Graphics.DrawString(" Candidats: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(50, 780));
            e.Graphics.DrawString(" 1. " + txtCandidat1.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 780));
            e.Graphics.DrawString(" 2. " + txtCandidat2.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 800));
            e.Graphics.DrawString(" 3. " + txtCandidat3.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 820));
            e.Graphics.DrawString(" 4. " + txtCandidat4.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 840));
            e.Graphics.DrawString(" 5. " + txtCandidat5.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 860));
            e.Graphics.DrawString(" 6. " + txtCandidat6.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 880));
            e.Graphics.DrawString(" 7. " + txtCandidat7.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 900));
            e.Graphics.DrawString(" 8. " + txtCandidat8.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 920));
            e.Graphics.DrawString(" 9. " + txtCandidat9.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 940));
            e.Graphics.DrawString(" 10. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 960));
            e.Graphics.DrawString(" 11. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 980));
            e.Graphics.DrawString(" 12. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 1000));
            e.Graphics.DrawString(" 13. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 1020));
            e.Graphics.DrawString(" 14. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 1040));
            e.Graphics.DrawString(" 15. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(130, 1060));
            
            e.Graphics.DrawString(" 16. " + txtCandidat1.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 780));
            e.Graphics.DrawString(" 17. " + txtCandidat2.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 800));
            e.Graphics.DrawString(" 18. " + txtCandidat3.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 820));
            e.Graphics.DrawString(" 19. " + txtCandidat4.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 840));
            e.Graphics.DrawString(" 20. " + txtCandidat5.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 860));
            e.Graphics.DrawString(" 21. " + txtCandidat6.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 880));
            e.Graphics.DrawString(" 22. " + txtCandidat7.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 900));
            e.Graphics.DrawString(" 23. " + txtCandidat8.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 920));
            e.Graphics.DrawString(" 24. " + txtCandidat9.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 940));
            e.Graphics.DrawString(" 25. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 960));
            e.Graphics.DrawString(" 26. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 980));
            e.Graphics.DrawString(" 27. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 1000));
            e.Graphics.DrawString(" 28. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 1020));
            e.Graphics.DrawString(" 29. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 1040));
            e.Graphics.DrawString(" 30. " + txtCandidat10.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 1060));

            e.Graphics.DrawString(" Date: " + fileDate.Value.ToShortDateString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 150));
            //e.Graphics.DrawString(" Visa Chef structure: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(630, 220));
            e.Graphics.DrawString(" " + txtUser.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 170));


            e.Graphics.DrawString(" Date: " + crud.getRecSignatures(txtRef.Text, "num_ref").Item10, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 200));
            e.Graphics.DrawString(" Visa Chef structure: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 220));
            e.Graphics.DrawString(" " + visaChSt1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 240));

            e.Graphics.DrawString(" Date: " + crud.getRecSignatures(txtRef.Text, "num_ref").Item11, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 305));
            e.Graphics.DrawString(" Visa DAM ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 320));
            e.Graphics.DrawString(" " + visaDAM, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 340));

            e.Graphics.DrawString(" Date: " + crud.getRecSignatures(txtRef.Text, "num_ref").Item3, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 630));
            e.Graphics.DrawString(" Visa CG ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 645));
            e.Graphics.DrawString(" " + visaCG, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 665));

            e.Graphics.DrawString(" Date: " + crud.getRecSignatures(txtRef.Text, "num_ref").Item5, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 690));
            e.Graphics.DrawString(" Visa DG ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 705));
            e.Graphics.DrawString(" " + visaDG, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 725));

            e.Graphics.DrawString(" Date: " + crud.getRecSignatures(txtRef.Text, "num_ref").Item7, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 750));
            
            e.Graphics.DrawString(" Visa GRH ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 800));
            e.Graphics.DrawString(" " + visaGRH1, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 820));

            e.Graphics.DrawString(" Visa Chef structure ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 880));
            e.Graphics.DrawString(" " + visaChS2, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 900));

            e.Graphics.DrawString(" __________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 130));
            e.Graphics.DrawString(" __________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 610));
            e.Graphics.DrawString(" __________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 670));
            e.Graphics.DrawString(" __________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 730));
            //e.Graphics.DrawString(" __________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 850));
            e.Graphics.DrawString(" __________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 1060));

            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 145));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 160));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 175));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 190));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 205));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 220));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 235));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 250));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 265));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 280));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 295));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 310));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 325));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 340));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 355));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 370));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 385));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 400));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 415));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 430));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 445));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 460));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 475));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 490));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 505));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 520));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 535));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 550));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 565));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 580));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 595));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 610));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 625));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 640));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 655));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 670));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 685));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 700));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 715));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 730));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 745));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 760));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 775));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 790));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 805));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 820));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 835));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 850));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 865));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 880));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 895));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 910));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 925));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 940));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 955));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 970));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 985));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1000));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1015));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1030));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1045));
            e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1060));
            
            e.Graphics.DrawString("    " + userName + " \n" + DateTime.Now, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(570, 1080));

            e.Graphics.DrawString(" Révision 04.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1080));
                e.HasMorePages = true;
            }
            if (page == 2)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 01 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" __________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 130));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 145));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 160));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 175));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 190));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 205));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 220));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 235));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 250));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 265));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 280));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 295));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 310));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 325));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 340));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 355));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 370));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 385));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 400));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 415));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 430));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 445));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 460));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 475));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 490));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 505));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 520));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 535));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 550));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 565));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 580));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 595));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 610));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 625));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 640));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 655));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 670));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 685));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 700));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 715));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 730));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 745));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 760));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 775));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 790));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 805));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 820));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 835));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 850));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 865));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 880));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 895));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 910));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 925));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 940));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 955));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 970));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 985));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1000));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1015));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1030));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1045));
                e.Graphics.DrawString(" | ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 1060));
                e.Graphics.DrawString(" __________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(45, 1060));

                e.Graphics.DrawString(" 7.Renseignement du Candidat Retenue: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(50, 150));
                e.Graphics.DrawString(" ___________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(48, 160));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 175));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 190));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 205));
                e.Graphics.DrawString(" ___________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(48, 206));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 221));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 236));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 251));
                e.Graphics.DrawString(" ___________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(48, 252));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 267));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 282));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 297));
                e.Graphics.DrawString(" ___________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(48, 298));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 313));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 328));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 343));
                e.Graphics.DrawString(" ___________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(48, 344));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 359));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 374));
                e.Graphics.DrawString(" |                   |                  |                    |                  |                   |                   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(48, 389));

                e.Graphics.DrawString(" ___________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(48, 390));
                e.Graphics.DrawString(" Candidat \n  retunue ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(75, 185));
                e.Graphics.DrawString(" Formation \n  de base ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(160, 185));
                e.Graphics.DrawString("     Formation \ncomplémentaire ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(237, 185));
                e.Graphics.DrawString(" Résidence ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(345, 185));
                e.Graphics.DrawString(" Situation \n  familiale ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(435, 185));
                e.Graphics.DrawString(" Expérience \nProfessionnel ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(522, 185));

                Rectangle recCanRet1 = new Rectangle(60, 225, 88, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recCanRet1);
                e.Graphics.DrawString(" " + txtCandi1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recCanRet1);

                Rectangle recForBas1 = new Rectangle(151, 225, 85, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recForBas1);
                e.Graphics.DrawString(" " + txtBForm1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recForBas1);

                Rectangle recForComp1 = new Rectangle(240, 225, 91, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recForComp1);
                e.Graphics.DrawString(" " + txtCForm1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recForComp1);

                Rectangle recRes1 = new Rectangle(335, 225, 85, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recRes1);
                e.Graphics.DrawString(" " + txtResid1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recRes1);

                Rectangle recSitFam1 = new Rectangle(423, 225, 89, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recSitFam1);
                e.Graphics.DrawString(" " + txtFamSit1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recSitFam1);

                Rectangle recExp1 = new Rectangle(516, 225, 91, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recExp1);
                e.Graphics.DrawString(" " + txtExp1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recExp1);

                Rectangle recCanRet2 = new Rectangle(60, 270, 88, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recCanRet2);
                e.Graphics.DrawString(" " + txtCandi2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recCanRet2);

                Rectangle recForBas2 = new Rectangle(151, 270, 85, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recForBas2);
                e.Graphics.DrawString(" " + txtBForm2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recForBas2);

                Rectangle recForComp2 = new Rectangle(240, 270, 91, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recForComp2);
                e.Graphics.DrawString(" " + txtCForm2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recForComp2);

                Rectangle recRes2 = new Rectangle(335, 270, 85, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recRes2);
                e.Graphics.DrawString(" " + txtResid2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recRes2);

                Rectangle recSitFam2 = new Rectangle(423, 270, 89, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recSitFam2);
                e.Graphics.DrawString(" " + txtFamSit2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recSitFam2);

                Rectangle recExp2 = new Rectangle(516, 270, 91, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recExp2);
                e.Graphics.DrawString(" " + txtExp2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recExp2);

                Rectangle recCanRet3 = new Rectangle(60, 318, 88, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recCanRet3);
                e.Graphics.DrawString(" " + txtCandi2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recCanRet3);

                Rectangle recForBas3 = new Rectangle(151, 318, 85, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recForBas3);
                e.Graphics.DrawString(" " + txtBForm1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recForBas3);

                Rectangle recForComp3 = new Rectangle(240, 318, 91, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recForComp3);
                e.Graphics.DrawString(" " + txtCForm3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recForComp3);

                Rectangle recRes3 = new Rectangle(335, 318, 85, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recRes3);
                e.Graphics.DrawString(" " + txtResid3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recRes3);

                Rectangle recSitFam3 = new Rectangle(423, 318, 89, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recSitFam3);
                e.Graphics.DrawString(" " + txtFamSit3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recSitFam3);

                Rectangle recExp3 = new Rectangle(516, 318, 91, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recExp3);
                e.Graphics.DrawString(" " + txtExp3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recExp3);

                Rectangle recCanRet4 = new Rectangle(60, 364, 88, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recCanRet4);
                e.Graphics.DrawString(" " + txtCandi2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recCanRet4);

                Rectangle recForBas4 = new Rectangle(151, 364, 85, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recForBas4);
                e.Graphics.DrawString(" " + txtBForm1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recForBas4);

                Rectangle recForComp4 = new Rectangle(240, 364, 91, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recForComp4);
                e.Graphics.DrawString(" " + txtCForm4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recForComp4);

                Rectangle recRes4 = new Rectangle(335, 364, 85, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recRes4);
                e.Graphics.DrawString(" " + txtResid4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recRes4);

                Rectangle recSitFam4 = new Rectangle(423, 364, 89, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recSitFam4);
                e.Graphics.DrawString(" " + txtFamSit4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recSitFam4);

                Rectangle recExp4 = new Rectangle(516, 364, 91, 44);
                e.Graphics.FillRectangle(Brushes.Transparent, recExp4);
                e.Graphics.DrawString(" " + txtExp4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, recExp4);

                e.Graphics.DrawString(" Date: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 150));
                e.Graphics.DrawString(" Visa GRH ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 185));
                e.Graphics.DrawString(" Visa Chef structure: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(610, 221));

                e.Graphics.DrawString("    " + userName + " \n" + DateTime.Now, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(570, 1080));

                e.Graphics.DrawString(" Révision 04.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1080));
                e.HasMorePages = false;
            }
            page++;
            if (page > 2)
                page = 1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;

            crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Impression de fiche de recrutement','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

        }

        public string opportune;
        private void rbOpporY_CheckedChanged(object sender, EventArgs e)
        {
            opportune = "OUI";
        }

        private void rbOpporN_CheckedChanged(object sender, EventArgs e)
        {
            opportune = "NON";
        }

        string appro;
        private void rbAccord_CheckedChanged(object sender, EventArgs e)
        {
            appro = "Accord";
        }

        private void rbDiffer_CheckedChanged(object sender, EventArgs e)
        {
            appro = "Differ";
        }

        private void rbReject_CheckedChanged(object sender, EventArgs e)
        {
            appro = "Rejete";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (motif == "")
            {
                motif = txtOther.Text;
            }
            if (crud.check_Id("T_DRecruit", "num_ref", txtRef.Text) == "Code exists")
            {
                MessageBox.Show("numéro de référence existe déja");
                clear();
            }
            else
            {
                string idStruct = crud.getChefStruct(Settings.Default.userName, "l.name").Item3;
                string chefStruct = crud.getChefStruct(Settings.Default.userName, "l.name").Item1;
                string ChefDAM = crud.getChefStruct("DAM", "nom_Structure").Item1;
                string ChefDG = crud.getChefStruct("DG", "nom_Structure").Item1;
                if (Settings.Default.userName != chefStruct)
                {
                    crud.crudop("insert into T_DRecruit (num_ref, poste_Travail, nombre, formation, age, sexe, motif, formation_Base, expérience, résidence, permis_Conduire, disponibilité, créé_le, créé_par, etat, id_Struct, statut, visa, dateVisa, nature_PostTravail, projets, lieu_Travail, langues, logiciels, autre_Compétence) values ('" + txtRef.Text + "/CSCExp/" + DateTime.Now.ToString("yyyy") + "','" + txtPost.Text + "','" + txtNumber.Text + "','" + txtFormation.Text + "','" + txtAge.Text + "','" + Gender + "','" + motif + "','" + txtBasicForm.Text + "','" + txtExperience.Text + "','" + txtResident.Text + "','" + license + "','" + txtAvailable.Text + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'" + userName + "','En cours'," + idStruct + ",'En cours','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'" + jobNature + "','" + txtProjects.Text + "','" + txtWorkPlace.Text + "','" + txtLanguages.Text + "','" + txtSoftware.Text + "','" + txtOthCompt.Text + "')");
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','" + chefStruct + "','Fiche de recrutement', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtRef.Text + "')");
                }
                else if (userName == chefStruct && userName != ChefDAM && userName != ChefDG)
                {
                    crud.crudop("insert into T_DRecruit (num_ref, poste_Travail, nombre, formation, age, sexe, motif, formation_Base, expérience, résidence, permis_Conduire, disponibilité, créé_le, créé_par, visa_ChSt1, dateChSt1, etat, id_Struct, statut, nature_PostTravail, projets, lieu_Travail, langues, logiciels, autre_Compétence) values ('" + txtRef.Text + "/CSCExp/" + DateTime.Now.ToString("yyyy") + "','" + txtPost.Text + "','" + txtNumber.Text + "','" + txtFormation.Text + "','" + txtAge.Text + "','" + Gender + "','" + motif + "','" + txtBasicForm.Text + "','" + txtExperience.Text + "','" + txtResident.Text + "','" + license + "','" + txtAvailable.Text + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'" + userName + "','" + chefStruct + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'En cours'," + idStruct + ",'En cours','" + jobNature + "','" + txtProjects.Text + "','" + txtWorkPlace.Text + "','" + txtLanguages.Text + "','" + txtSoftware.Text + "','" + txtOthCompt.Text + "')");
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','" + ChefDAM + "','Fiche de recrutement', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtRef.Text + "')");
                }
                else if (userName == ChefDAM && userName != ChefDG)
                {
                    crud.crudop("insert into T_DRecruit (num_ref, poste_Travail, nombre, formation, age, sexe, motif, formation_Base, expérience, résidence, permis_Conduire, disponibilité, créé_le, créé_par, visa_DAM, dateDAM, etat, id_Struct, statut, nature_PostTravail, projets, lieu_Travail, langues, logiciels, autre_Compétence) values ('" + txtRef.Text + "/CSCExp/" + DateTime.Now.ToString("yyyy") + "','" + txtPost.Text + "','" + txtNumber.Text + "','" + txtFormation.Text + "','" + txtAge.Text + "','" + Gender + "','" + motif + "','" + txtBasicForm.Text + "','" + txtExperience.Text + "','" + txtResident.Text + "','" + license + "','" + txtAvailable.Text + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'" + userName + "','" + ChefDAM + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'En cours'," + idStruct + ",'En cours','" + jobNature + "','" + txtProjects.Text + "','" + txtWorkPlace.Text + "','" + txtLanguages.Text + "','" + txtSoftware.Text + "','" + txtOthCompt.Text + "')");
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','" + ChefDG + "','Fiche de recrutement', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtRef.Text + "')");
                }
                else if (userName == ChefDG)
                {
                    crud.crudop("insert into T_DRecruit (num_ref, poste_Travail, nombre, formation, age, sexe, motif, formation_Base, expérience, résidence, permis_Conduire, disponibilité, approbation_DG, créé_le, créé_par, visa_DG, date_DG, etat, id_Struct, statut, nature_PostTravail, projets, lieu_Travail, langues, logiciels, autre_Compétence) values ('" + txtRef.Text + "/CSCExp/" + DateTime.Now.ToString("yyyy") + "','" + txtPost.Text + "','" + txtNumber.Text + "','" + txtFormation.Text + "','" + txtAge.Text + "','" + Gender + "','" + motif + "','" + txtBasicForm.Text + "','" + txtExperience.Text + "','" + txtResident.Text + "','" + license + "','" + txtAvailable.Text + "','Accord',CONVERT (datetime, '" + DateTime.Now + "', 121),'" + userName + "','" + ChefDG + "',CONVERT (datetime, '" + DateTime.Now + "', 121),'En cours'," + idStruct + ",'En cours','" + jobNature + "','" + txtProjects.Text + "','" + txtWorkPlace.Text + "','" + txtLanguages.Text + "','" + txtSoftware.Text + "','" + txtOthCompt.Text + "')");
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','Tebich Amina','Fiche de recrutement', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtRef.Text + "')");
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','Farah Wided','Fiche de recrutement', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtRef.Text + "')");
                }
                crud.crudop("insert into T_Condidats values ('" + txtRef.Text + "','" + txtCandidat1.Text + "'),('" + txtRef.Text + "','" + txtCandidat2.Text + "'),('" + txtRef.Text + "','" + txtCandidat3.Text + "'),('" + txtRef.Text + "','" + txtCandidat4.Text + "'),('" + txtRef.Text + "','" + txtCandidat5.Text + "'),('" + txtRef.Text + "','" + txtCandidat6.Text + "'),('" + txtRef.Text + "','" + txtCandidat7.Text + "'),('" + txtRef.Text + "','" + txtCandidat8.Text + "'),('" + txtRef.Text + "','" + txtCandidat9.Text + "'),('" + txtRef.Text + "','" + txtCandidat10.Text + "'),('" + txtRef.Text + "','" + txtCandidat11.Text + "'),('" + txtRef.Text + "','" + txtCandidat12.Text + "'),('" + txtRef.Text + "','" + txtCandidat13.Text + "'),('" + txtRef.Text + "','" + txtCandidat14.Text + "'),('" + txtRef.Text + "','" + txtCandidat15.Text + "'),('" + txtRef.Text + "','" + txtCandidat16.Text + "'),('" + txtRef.Text + "','" + txtCandidat17.Text + "'),('" + txtRef.Text + "','" + txtCandidat18.Text + "'),('" + txtRef.Text + "','" + txtCandidat19.Text + "'),('" + txtRef.Text + "','" + txtCandidat20.Text + "'),('" + txtRef.Text + "','" + txtCandidat21.Text + "'),('" + txtRef.Text + "','" + txtCandidat22.Text + "'),('" + txtRef.Text + "','" + txtCandidat23.Text + "'),('" + txtRef.Text + "','" + txtCandidat24.Text + "'),('" + txtRef.Text + "','" + txtCandidat25.Text + "'),('" + txtRef.Text + "','" + txtCandidat26.Text + "'),('" + txtRef.Text + "','" + txtCandidat27.Text + "'),('" + txtRef.Text + "','" + txtCandidat28.Text + "'),('" + txtRef.Text + "','" + txtCandidat29.Text + "'),('" + txtRef.Text + "','" + txtCandidat30.Text + "')");
                crud.crudop("insert into T_RenseignCandidat values ('" + txtRef.Text + "','" + txtCandi1.Text + "','" + txtBForm1.Text + "','" + txtCForm1.Text + "','" + txtResid1.Text + "','" + txtFamSit1.Text + "','" + txtExp1.Text + "'),('" + txtRef.Text + "','" + txtCandi2.Text + "','" + txtBForm2.Text + "','" + txtCForm2.Text + "','" + txtResid2.Text + "','" + txtFamSit2.Text + "','" + txtExp2.Text + "'),('" + txtRef.Text + "','" + txtCandi3.Text + "','" + txtBForm3.Text + "','" + txtCForm3.Text + "','" + txtResid3.Text + "','" + txtFamSit3.Text + "','" + txtExp3.Text + "'),('" + txtRef.Text + "','" + txtCandi4.Text + "','" + txtBForm4.Text + "','" + txtCForm4.Text + "','" + txtResid4.Text + "','" + txtFamSit4.Text + "','" + txtExp4.Text + "')");

                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Ajout de nouveau fiche de recrutement','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
                MessageBox.Show("Vos données ont été enregistrées");
                clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                crud.crudop("update T_DRecruit set poste_Travail='" + txtPost.Text + "',nombre='" + txtNumber.Text + "',formation='" + txtFormation.Text + "',age='" + txtAge.Text + "',sexe='" + Gender + "',motif='" + motif + "',formation_Base='" + txtBasicForm.Text + "',expérience='" + txtExperience.Text + "',résidence='" + txtResident.Text + "',permis_Conduire='" + license + "',disponibilité='" + txtAvailable.Text + "',opportunité='" + opportune + "',approbation_DG='" + appro + "',modifié_le=CONVERT (datetime, '" + DateTime.Now + "', 121),modifié_par='" + userName + "',nature_PostTravail='" + jobNature + "',projets='" + txtProjects.Text + "',lieu_Travail='" + txtWorkPlace.Text + "',langues='" + txtLanguages.Text + "',logiciels='" + txtSoftware.Text + "',autre_Compétence='" + txtOthCompt.Text + "' where num_ref='" + txtRef.Text + "'");

                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat1.Text, "id_Candi", txtCandId.Text);
                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat2.Text, "id_Candi", txtCandId1.Text);
                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat3.Text, "id_Candi", txtCandId2.Text);
                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat4.Text, "id_Candi", txtCandId3.Text);
                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat5.Text, "id_Candi", txtCandId4.Text);
                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat6.Text, "id_Candi", txtCandId5.Text);
                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat7.Text, "id_Candi", txtCandId6.Text);
                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat8.Text, "id_Candi", txtCandId7.Text);
                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat9.Text, "id_Candi", txtCandId8.Text);
                crud.updateMultiRows("T_Condidats", "nom_Candidat", txtCandidat10.Text, "id_Candi", txtCandId9.Text);

                crud.updateMultiRows("T_RenseignCandidat", "cand_Retenue", txtCandi1.Text, "id_Renseig", txtRCId1.Text);
                crud.updateMultiRows("T_RenseignCandidat", "form_Base", txtBForm1.Text, "id_Renseig", txtRCId1.Text);
                crud.updateMultiRows("T_RenseignCandidat", "form_Comp", txtCForm1.Text, "id_Renseig", txtRCId1.Text);
                crud.updateMultiRows("T_RenseignCandidat", "réside_Rensei", txtResid1.Text, "id_Renseig", txtRCId1.Text);
                crud.updateMultiRows("T_RenseignCandidat", "sit_Fam", txtFamSit1.Text, "id_Renseig", txtRCId1.Text);
                crud.updateMultiRows("T_RenseignCandidat", "expéri_Rensi", txtExp1.Text, "id_Renseig", txtRCId1.Text);
                crud.updateMultiRows("T_RenseignCandidat", "cand_Retenue", txtCandi2.Text, "id_Renseig", txtRCId2.Text);
                crud.updateMultiRows("T_RenseignCandidat", "form_Base", txtBForm2.Text, "id_Renseig", txtRCId2.Text);
                crud.updateMultiRows("T_RenseignCandidat", "form_Comp", txtCForm2.Text, "id_Renseig", txtRCId2.Text);
                crud.updateMultiRows("T_RenseignCandidat", "réside_Rensei", txtResid2.Text, "id_Renseig", txtRCId2.Text);
                crud.updateMultiRows("T_RenseignCandidat", "sit_Fam", txtFamSit2.Text, "id_Renseig", txtRCId2.Text);
                crud.updateMultiRows("T_RenseignCandidat", "expéri_Rensi", txtExp2.Text, "id_Renseig", txtRCId2.Text);
                crud.updateMultiRows("T_RenseignCandidat", "cand_Retenue", txtCandi3.Text, "id_Renseig", txtRCId3.Text);
                crud.updateMultiRows("T_RenseignCandidat", "form_Base", txtBForm3.Text, "id_Renseig", txtRCId3.Text);
                crud.updateMultiRows("T_RenseignCandidat", "form_Comp", txtCForm3.Text, "id_Renseig", txtRCId3.Text);
                crud.updateMultiRows("T_RenseignCandidat", "réside_Rensei", txtResid3.Text, "id_Renseig", txtRCId3.Text);
                crud.updateMultiRows("T_RenseignCandidat", "sit_Fam", txtFamSit3.Text, "id_Renseig", txtRCId3.Text);
                crud.updateMultiRows("T_RenseignCandidat", "expéri_Rensi", txtExp3.Text, "id_Renseig", txtRCId3.Text);
                crud.updateMultiRows("T_RenseignCandidat", "cand_Retenue", txtCandi4.Text, "id_Renseig", txtRCId4.Text);
                crud.updateMultiRows("T_RenseignCandidat", "form_Base", txtBForm4.Text, "id_Renseig", txtRCId4.Text);
                crud.updateMultiRows("T_RenseignCandidat", "form_Comp", txtCForm4.Text, "id_Renseig", txtRCId4.Text);
                crud.updateMultiRows("T_RenseignCandidat", "réside_Rensei", txtResid4.Text, "id_Renseig", txtRCId4.Text);
                crud.updateMultiRows("T_RenseignCandidat", "sit_Fam", txtFamSit4.Text, "id_Renseig", txtRCId4.Text);
                crud.updateMultiRows("T_RenseignCandidat", "expéri_Rensi", txtExp4.Text, "id_Renseig", txtRCId4.Text);

                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Modification de fiche de recrutement','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                MessageBox.Show("Vos données ont été mises à jour");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void txtCandidat1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            //crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Demande de recrutement refusée','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

            Form_Justify _Justify = new Form_Justify();
            _Justify.txtnumRef.Text = txtRef.Text;
            _Justify.txtAlertId.Text = txtIdAlrt.Text;
            _Justify.Show();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string chefStruct = crud.getChefStruct(Settings.Default.userName, "l.name").Item1;
            string ChefDAM = crud.getChefStruct("DAM", "nom_Structure").Item1;
            string ChefDG = crud.getChefStruct("DG", "nom_Structure").Item1;
            if (userName == chefStruct && userName != ChefDAM && userName != ChefDG)
            {
                crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','" + ChefDAM + "','Fiche de recrutement', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtRef.Text + "')");
                crud.crudop("delete from T_Alerts where id_Alert='" + txtIdAlrt.Text + "'");
                crud.crudop("update T_DRecruit set visa_ChSt1='" + userName + "', dateChSt1=CONVERT(datetime, '" + DateTime.Now + "', 121) ,etat='Validé par chef structure', statut='En cours' where num_ref='" + txtRef.Text + "'");
                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Validé la demande','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                MessageBox.Show("Validation");

            }
            else if (userName == ChefDAM && userName != ChefDG)
            {
                crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','" + ChefDG + "','Fiche de recrutement', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtRef.Text + "')");
                crud.crudop("delete from T_Alerts where id_Alert='" + txtIdAlrt.Text + "'");
                crud.crudop("update T_DRecruit set visa_DAM='" + userName + "', dateDAM=CONVERT (datetime, '" + DateTime.Now + "', 121), etat='Validé par DAM', statut='En cours' where num_ref='" + txtRef.Text + "'");
                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Validé la demande','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                MessageBox.Show("Validation");
            }
            
            else if (userName == ChefDG)
            {
                
                if (appro == "Accord")
                {
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1), '" + userName + "','Tebich Amina','Fiche de recrutement', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtRef.Text + "')");
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1), '" + userName + "','Farah Widad','Fiche de recrutement', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtRef.Text + "')");

                    crud.crudop("delete from T_Alerts where id_Alert='" + txtIdAlrt.Text + "'");
                    crud.crudop("update T_DRecruit set approbation_DG='" + appro + "',date_DG='" + DateTime.Now.ToShortDateString() + "', visa_DG='" + userName + "', etat='Validé par DG', statut='Accepté' where num_ref='" + txtRef.Text + "'");
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Validé la demande','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
                    txtUser.Text = appro;
                    MessageBox.Show("Validation");
                }
                else if (appro == "Differ")
                {
                    crud.crudop("update T_DRecruit set approbation_DG='" + appro + "' where num_ref='" + txtRef.Text + "'");
                    Form_Justify _Justify = new Form_Justify();
                    _Justify.txtnumRef.Text = txtRef.Text;
                    _Justify.txtAlertId.Text = txtIdAlrt.Text;
                    _Justify.Show();
                }
                else if (appro == "Rejete")
                {
                    crud.crudop("update T_DRecruit set approbation_DG='" + appro + "' where num_ref='" + txtRef.Text + "'");
                    Form_Justify _Justify = new Form_Justify();
                    _Justify.txtnumRef.Text = txtRef.Text;
                    _Justify.txtAlertId.Text = txtIdAlrt.Text;
                    _Justify.Show();
                }
            }
            else if (userName == "Tebich Amina" || userName == "Farah Wided")
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                crud.crudop("delete from T_Alerts where num_ref='" + txtRef.Text + "'");
                //crud.crudop("update T_DRecruit set approbation_DG='" + appro + "',date_DG='" + DateTime.Now.ToShortDateString() + "', visa_DG='" + userName + "', etat='Validé par DG', statut='Accepté' where num_ref='" + txtRef.Text + "'");
                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Impression de la demande','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
                txtUser.Text = appro;
                //MessageBox.Show("Validation");
            }
        }

        private void Form_RecruitRequest_Load(object sender, EventArgs e)
        {
            string ChefDG = crud.getChefStruct("DG", "nom_Structure").Item1;
            if (userName == ChefDG && pnlOpportunité.Visible == false)
            {
                pnlPourvoi.Visible = false;
                pnlMotif.Visible = false;
                pnlCritic.Visible = false;
                pnlOpportunité.Visible = true;
                pnlEntretien.Visible = false;
                pnlRenseignement.Visible = false;

                lblOpportunity.Visible = false;
                pnlYN0.Visible = false;
                pnlAppro.Visible = true;
                lblApprobation.Visible = true;

                btnRefuse.Visible = false;
                btnValidate.Text = "   Envoyé";
                btnValidate.Location = new Point(325, 511);
            }
            
        }

        private void pnlCritic_Paint(object sender, PaintEventArgs e)
        {

        }
        string jobNature;
        private void rbPermanent_CheckedChanged(object sender, EventArgs e)
        {
            jobNature = "Permanant";
        }

        private void rbTemporary_CheckedChanged(object sender, EventArgs e)
        {
            jobNature = "Temporaire";
        }

        private void rbPartTime_CheckedChanged(object sender, EventArgs e)
        {
            jobNature = "Temps partiel";
        }
    }
}
