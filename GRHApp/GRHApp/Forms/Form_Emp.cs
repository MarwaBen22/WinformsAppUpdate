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
using GRHApp.Forms;

namespace GRHApp.Forms
{
    public partial class Form_Emp : Form
    {
        public Form_Emp()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();

        public void clear()
        {
            txtNumber.Text = "";
            txtLName.Text = "";
            txtName.Text = "";
            dtpBirth.ResetText();
            txtPBirth.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtJob.Text = "";
            cbCivility.Items.Insert(3, "Choisir votre civilité");
            cbCivility.SelectedIndex = 3;
            cbFamSit.Items.Insert(4, "Choisir un situation");
            cbFamSit.SelectedIndex = 4;
            //cbService.Items.Insert(0, "Choisir un service");
            //cbService.SelectedIndex = 0;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "" || txtLName.Text == "" || txtName.Text == "" || txtPBirth.Text == "" || cbCivility.Text == "" || cbFamSit.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtJob.Text == "" || cbService.Text == "")
            {
                MessageBox.Show("Veuillez remplir les blans");
            }
            else
            {
                crud.crudop("update T_Employe set num_Service=(select num_Service from T_Service where nom_Service='" + cbService.Text + "'),nom='" + txtLName.Text + "',prenom='" + txtName.Text + "',date_Naissance='" + dtpBirth.Value.ToShortDateString() + "',lieu_Naissance='" + txtPBirth.Text + "',civilité='" + cbCivility.Text + "',sit_Familiale='" + cbFamSit.Text + "',adresse='" + txtAddress.Text + "',email='" + txtEmail.Text + "',téléphone='" + txtPhone.Text + "',poste='" + txtJob.Text + "',date_Recr='" + dtpJobStart.Value.ToShortDateString() + "' where id_Emp='" + txtNumber.Text + "'");
                MessageBox.Show("Vos données ont été mises à jour");
                clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Les modifications que vous avez apportées ne seront pas sauvegardées", "Confirmation", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "" || txtLName.Text == "" || txtName.Text == "" || txtPBirth.Text == "" || cbCivility.Text == "" || cbFamSit.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtJob.Text == "" || cbService.Text == "")
            {
                MessageBox.Show("Veuillez remplir les blans");
            }
            else
            {
                if (crud.check_Id("T_Employe", "id_Emp", txtNumber.Text) == "Code exists")
                {
                    MessageBox.Show("Matricule existe déja");
                    clear();
                }
                else
                { 
                    crud.crudop("insert into T_Employe values ('" + txtNumber.Text + "',(select num_Service from T_Service where nom_Service='" + cbService.Text + "') ,'" + txtLName.Text + "','" + txtName.Text + "','" + dtpBirth.Value.ToShortDateString() + "','" + txtPBirth.Text + "','" + cbCivility.Text + "','" + cbFamSit.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtJob.Text + "','"+ dtpJobStart.Value.ToShortDateString() +"')");
                    MessageBox.Show("Vos données ont été enregistrées");
                    clear();
                }
            }
        }

        private void Form_Emp_Load(object sender, EventArgs e)
        {
            
        }

        private void cbCivility_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (cbCivility.SelectedIndex == 3)
                    cbCivility.Items.RemoveAt(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbFamSit_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (cbFamSit.SelectedIndex == 4)
                    cbFamSit.Items.RemoveAt(4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbService_MouseClick(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    if (cbService.SelectedIndex == 0)
            //        cbService.Items.RemoveAt(0);

            //    cbService.DisplayMember = "nom_Service";
            //    cbService.ValueMember = "nom_Service";
            //    cbService.DataSource = crud.get0("T_Service");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            Form_Service _Service = new Form_Service();
            _Service.Show();
        }

        private void cbService_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        int page = 1;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (page == 1)
            { 
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" Fiche de Renseignement & carrière ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(280, 90));
                e.Graphics.DrawString(" 1.Etat civil: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 120));
                e.Graphics.DrawString(" Matricule: " + txtLName.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 150));

                e.Graphics.DrawString(" Nom: " + txtLName.Text + "    Prénom: " + txtName.Text + "    Nom De Jeune Fille: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 170));
                e.Graphics.DrawString(" Né(e) le: " + dtpBirth.Value.ToShortDateString() + "    à " + txtPBirth.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 190));
                e.Graphics.DrawString(" Situation de Famille: " + cbFamSit.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 210));
                e.Graphics.DrawString(" Nationalité: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 230));
                e.Graphics.DrawString(" Adresse: " + txtAddress.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                e.Graphics.DrawString(" N° Tél: " + txtPhone.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 270));
                e.Graphics.DrawString(" Prénom de Père: " + "    Nom et Prénom de la Mère: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 290));
                e.Graphics.DrawString(" Groupe sanguin: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 310));
                e.Graphics.DrawString(" Profession des Parents: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 330));
                e.Graphics.DrawString("   *Père: " + "    *Mère: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 350));
                e.Graphics.DrawString(" Nombres de Frères & Soeurs: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 370));
                e.Graphics.DrawString(" Nom et Prénom du Conjoint: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 390));
                e.Graphics.DrawString(" Profession du Conjoint: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 410));
                e.Graphics.DrawString(" N°Compte Bancaire: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 430));
                e.Graphics.DrawString(" N°Sécurité Sociale: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 450));
                e.Graphics.DrawString(" Carte Nationale N°: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 470));
                e.Graphics.DrawString(" 2.Situation vis a vis du service national: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 500));
                e.Graphics.DrawString(" Dégagé: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 530));
                e.Graphics.DrawString(" Date d'immobilisation: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 550));
                e.Graphics.DrawString(" Sursitaire: Du: " + "    Au: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 570));
                e.Graphics.DrawString(" Apte non incorporale: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 590));
                e.Graphics.DrawString(" 3.Niveau scolaire et universitaire: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 620));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 650));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 665));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 680));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 681));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 696));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 711));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 712));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 727));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 742));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 743));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 758));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 773));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 774));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 789));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 804));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 805));
                e.Graphics.DrawString(" 4.Enseignement professionnel: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(90, 835));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 865));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 880));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 895));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 896));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 911));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 926));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 927));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 942));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 957));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 958));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 973));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 988));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 989));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1004));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1019));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1020));
                e.Graphics.DrawString(" Etablissement ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(105, 675));
                e.Graphics.DrawString(" Spécialité ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(275, 675));
                e.Graphics.DrawString(" Période ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(400, 675));
                e.Graphics.DrawString(" Diplome ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(535, 675));
                e.Graphics.DrawString(" Année ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(675, 675));
            
                e.Graphics.DrawString(" Etablissement ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(105, 890));
                e.Graphics.DrawString(" Spécialité ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(275, 890));
                e.Graphics.DrawString(" Période ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(400, 890));
                e.Graphics.DrawString(" Diplome ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(535, 890));
                e.Graphics.DrawString(" Année ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(675, 890));

                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            if (page == 2)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" 5.Stages effectues: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 90));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 120));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 135));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 150));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 151));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 166));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 181));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 182));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 197));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 212));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 213));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 228));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 243));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 244));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 259));
                e.Graphics.DrawString(" |                                     |                          |                       |                                  |                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 274));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 275));
                e.Graphics.DrawString(" Etablissement ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(105, 145));
                e.Graphics.DrawString(" Spécialité ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(275, 145));
                e.Graphics.DrawString(" Période ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(400, 145));
                e.Graphics.DrawString(" Diplome ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(535, 145));
                e.Graphics.DrawString(" Année ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(675, 145));

                e.Graphics.DrawString(" 6.Carrière professionnelle: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 305));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 335));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 350));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 365));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 366));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 381));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 396));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 397));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 412));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 427));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 428));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 443));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 458));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 459));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 474));
                e.Graphics.DrawString(" |                                         |                                |                               |                                      |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 489));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 490));
                e.Graphics.DrawString(" Employeur ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(130, 360));
                e.Graphics.DrawString(" Emploi ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(320, 360));
                e.Graphics.DrawString(" Du:     Au: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(450, 360));
                e.Graphics.DrawString(" Motif du départ ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(610, 360));

                e.Graphics.DrawString(" 7.Langues: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 520));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 550));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 565));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 580));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 581));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 596));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 611));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 612));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 627));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 642));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 643));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 658));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 673));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 674));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 689));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 704));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 705));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 720));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 735));
                e.Graphics.DrawString(" |                    |                    |                    |                   |                    |                    |                    |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 750));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 751));
                e.Graphics.DrawString(" Langues ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 575));
                e.Graphics.DrawString(" Nature ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(190, 575));
                e.Graphics.DrawString(" T.Bien ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(290, 575));
                e.Graphics.DrawString(" Bien ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(390, 575));
                e.Graphics.DrawString(" Moyen(+) ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(475, 575));
                e.Graphics.DrawString(" Moyen(-) ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(575, 575));
                e.Graphics.DrawString(" Néant ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(675, 575));

                e.Graphics.DrawString(" Français ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 606));
                e.Graphics.DrawString(" Arabe ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 637));
                e.Graphics.DrawString(" Anglais ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 668));
                e.Graphics.DrawString(" Allemand ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 699));
                e.Graphics.DrawString(" Autre ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 725));

                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 598));
                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 629));
                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 660));
                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 691));
                e.Graphics.DrawString(" Ecrit\n Parlé ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 722));

                e.Graphics.DrawString(" 8.Maitrise de logiciels informatique: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 781));
                e.Graphics.DrawString(" _______________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(385, 811));
                e.Graphics.DrawString("                                                                   |                                                                               |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 826));
                e.Graphics.DrawString("                                                                   |                                                                               |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 841));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 842));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 857));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 872));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 887));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 888));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 903));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 918));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 919));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 934));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 949));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 950));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 965));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 980));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 981));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 996));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1011));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1012));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1027));
                e.Graphics.DrawString(" |                        |                    |                    |                  |                   |                   |                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1042));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1043));
                e.Graphics.DrawString(" Pondération ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(525, 830));
                e.Graphics.DrawString(" Logiciels ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 867));
                e.Graphics.DrawString("   Avec\nformation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(205, 867));
                e.Graphics.DrawString("   Sans\nformation", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(305, 867));
                e.Graphics.DrawString(" T.Bien ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(405, 867));
                e.Graphics.DrawString(" Bien ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(502, 867));
                e.Graphics.DrawString(" Moyen ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(588, 867));
                e.Graphics.DrawString(" Initiation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(673, 867));


                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            //page++;
            if (page == 3)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" 9.Travaux particuliers réalises: (études, projets, ...etc.)", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 90));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 120));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 135));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 150));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 165));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 180));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 195));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 210));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 225));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 240));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 255));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 270));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 285));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 300));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 315));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 330));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 345));
                e.Graphics.DrawString(" |                                                                                                                                                |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 360));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 361));
                e.Graphics.DrawString(" 10.Centres d'intéret: (Lecture, Sport, Musique, Loisirs ...) ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 391));
                e.Graphics.DrawString(" Citez vos centres d'intéret par ordre de priorité. ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 411));
                e.Graphics.DrawString(" 1. " + "           .2 ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 441));
                e.Graphics.DrawString(" 3. " + "           .4 ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 461));
                e.Graphics.DrawString(" 5. " + "           .6 ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 481));
                e.Graphics.DrawString(" 7. " + "           .8 ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 501));
                e.Graphics.DrawString(" 11.Origine de votre demande de recrutement suite a: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 531));
                e.Graphics.DrawString(" * Avis de recrutement paru par voie de presse            [ " + " ]" , new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 561));
                e.Graphics.DrawString(" * Recommondation par le bureau de main d'oeuvre    [ " + " ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 581));
                e.Graphics.DrawString(" * Recommondation par un travailleur de CSC             [ " + " ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 601));
                e.Graphics.DrawString(" * Autre:     " + "", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 621));
                e.Graphics.DrawString(" 12.Connaissez-vous des personnes au niveau de CSC? Si oui, lesquelles? ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 651));
                e.Graphics.DrawString(" Noms ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(180, 681));
                e.Graphics.DrawString(" Prénoms ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(380, 681));
                e.Graphics.DrawString(" Fontions ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 681));

                e.Graphics.DrawString(" *\n *\n * ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(110, 701));
                e.Graphics.DrawString(" *\n *\n * ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(310, 701));
                e.Graphics.DrawString(" *\n *\n * ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(530, 701));

                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            if (page == 4 )
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" PARTIE A REMPLIR PAR RH: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(180, 90));
                e.Graphics.DrawString(" 13.Médicine de travail: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 120));
                e.Graphics.DrawString(" Test cocluant: [ " + " ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 150));
                e.Graphics.DrawString(" Test non cocluant: [ " + " ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 170));
                e.Graphics.DrawString(" 14.Test professionnel: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 200));
                e.Graphics.DrawString(" Test cocluant: [ " + " ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 230));
                e.Graphics.DrawString(" Test non cocluant: [ " + " ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                e.Graphics.DrawString(" 15.Contrat: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 280));
                e.Graphics.DrawString(" Contrat de travail: établi le " + "      Fonction: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 310));
                e.Graphics.DrawString(" Direction/Service/Projet: " + "      Date d'engagement: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 330));
                e.Graphics.DrawString(" 16.Primes et Indemnités: " + " ]", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 360));
                e.Graphics.DrawString(" Salaire de base: " + "      IEP: " + "      Panier: [ " + " ]       Transport: [ " + " ]       Salissure: [ " + " ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 390));
                e.Graphics.DrawString(" Indemnité Véhicule: [ " + " ]       Frais de déplacement: [ " + " ]       Danger: [ " + " ]       Téléphone: [ " + " ]       Pénibilité: [ " + " ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 410));
                e.Graphics.DrawString(" Insalubrité: [ " + " ]       Fidélité: [ " + " ]       PRI: [ " + " ]       PRC: [ " + " ]       PPI: [ " + " ]       IQ: [ " + " ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 430));
                e.Graphics.DrawString(" Frais de mission: [ " + " ]       IFRI: [ " + " ]       Autre: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 450));
                e.Graphics.DrawString(" 17.Appréciation Fin Période D'essai: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 480));
                e.Graphics.DrawString(" Période d'essai conclut: [ " + " ]       Période d'essai à prolonger: [ " + " ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 510));
                e.Graphics.DrawString(" Essai non concluant: [ " + " ]", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 530));
                e.Graphics.DrawString(" Lettre de notification le: " + " Réf ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, 550));
                e.Graphics.DrawString(" 18.Formation au sein de CSC EXP: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 580));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 610));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 625));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 640));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 655));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 656));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 671));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 686));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 687));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 702));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 717));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 718));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 733));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 748));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 749));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 764));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 779));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 780));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 795));
                e.Graphics.DrawString(" |                                |                      |                    |                 |                   |                             |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 810));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(68, 811));
                e.Graphics.DrawString(" Exercise ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(118, 635));
                e.Graphics.DrawString(" Theme ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(253, 635));
                e.Graphics.DrawString("   Lieu de\n formation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(350, 635));
                e.Graphics.DrawString(" Durée ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(450, 635));
                e.Graphics.DrawString(" Date ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(540, 635));
                e.Graphics.DrawString(" Objectif de la\n    formation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(625, 635));
                e.Graphics.DrawString(" 19.Mesures Disciplinaires: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 841));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 871));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 886));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 901));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 916));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 917));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 932));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 947));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 948));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 963));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 978));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 979));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 994));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1009));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1010));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1025));
                e.Graphics.DrawString(" |                                     |                          |                    |                              |                            |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1040));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1041));
                e.Graphics.DrawString(" Qualifiaction\n   de la faute ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(110, 896));
                e.Graphics.DrawString(" Nature de\n la sanction ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(275, 896));
                e.Graphics.DrawString(" Date ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(410, 896));
                e.Graphics.DrawString(" Motif ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(522, 896));
                e.Graphics.DrawString(" Observation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(640, 896));


                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            if (page == 5)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" 20.Surveillance: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 90));
                e.Graphics.DrawString(" Etape:  Initiale [ " + " ]       suivi1 [ " + " ]       suivi2 [ " + " ]       suivi3 [ " + " ]       non surveillé [ " + " ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 120));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 140));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 155));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 170));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 185));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 186));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 201));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 216));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 217));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 232));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 247));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 248));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 263));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 278));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 279));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 294));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 309));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 310));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 325));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 340));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 341));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 356));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 371));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 372));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 387));
                e.Graphics.DrawString(" |                   |                     |                                  |                              |                                     |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 402));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 403));
                e.Graphics.DrawString(" Date ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(100, 165));
                e.Graphics.DrawString(" Etape ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(195, 165));
                e.Graphics.DrawString(" Technique CND\n        Utilisé ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(290, 165));
                e.Graphics.DrawString(" Notation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(472, 165));
                e.Graphics.DrawString(" Remarque ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(625, 165));
                e.Graphics.DrawString(" 21.Evaluation annuelle des compétences: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 433));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 463));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 478));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 493));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 494));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 509));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 524));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 525));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 540));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 555));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 556));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 571));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 586));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 587));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 602));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 617));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 618));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 633));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 648));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 649));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 664));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 679));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 680));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 695));
                e.Graphics.DrawString(" |                                         |                                                   |                                                   |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 710));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 711));
                e.Graphics.DrawString(" Exercice ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(135, 488));
                e.Graphics.DrawString(" Notation Global ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(325, 488));
                e.Graphics.DrawString(" Appréciation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(575, 488));
                e.Graphics.DrawString(" 22.Pistes d'amélioration: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 741));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 771));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 786));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 801));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 816));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 817));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 832));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 847));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 848));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 863));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 878));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 879));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 894));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 909));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 910));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 925));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 940));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 941));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 956));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 971));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 972));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 987));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1002));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1003));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1018));
                e.Graphics.DrawString(" |                   |                               |                                  |                              |                           |", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(68, 1033));
                e.Graphics.DrawString(" ________________________________________________________________________ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 1034));
                e.Graphics.DrawString(" Exercice ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 796));
                e.Graphics.DrawString("   Promotion par\névolution de poste ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(178, 796));
                e.Graphics.DrawString(" Réaffectation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(347, 796));
                e.Graphics.DrawString(" Formation ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(515, 796));
                e.Graphics.DrawString(" Autres ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(660, 796));


                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = true;
            }
            if (page == 6)
            {
                e.Graphics.DrawString(" C.S.C Expertise Spa ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 60));
                e.Graphics.DrawString(" RH da 02 ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(650, 60));
                e.Graphics.DrawString(" 23.Appréciation Fin Contrat CDD: ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(90, 120));
                e.Graphics.DrawString(" Contrat concluant:       [ " + " ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 150));
                e.Graphics.DrawString(" Contrat de travail renouvelé le: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 170));
                e.Graphics.DrawString(" Contrat non concluant:       [ " + " ] ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 190));
                e.Graphics.DrawString(" Lettre de notification le: " + "       N°Ref: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(90, 210));


                e.Graphics.DrawString(" Révision 03.\n13/02/2022 ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 1070));
                e.HasMorePages = false;
            }
            page++;
        }
    }
}
