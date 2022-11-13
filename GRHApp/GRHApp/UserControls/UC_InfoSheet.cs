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
using GRHApp.Properties;
using GRHApp.UserControls;

namespace GRHApp.UserControls
{
    public partial class UC_InfoSheet : UserControl
    {
        public UC_InfoSheet()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        public void display()
        {
            dgvInfoSh.DataSource = crud.multi_tables();
            dgvInfoSh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UC_InfoSheet_Load(object sender, EventArgs e)
        {
            try
            {
                cbSearch.SelectedIndex = 2;
                if (Settings.Default.fichRen == "consultation")
                {
                    //UserControls.UC_InfoSheet _InfoSheet = new UserControls.UC_InfoSheet();
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;
                    btnView.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Recruit _Recruit = new Form_Recruit();
            _Recruit.btnUpdate.Visible = false;
            _Recruit.btnPrint.Visible = false;
            _Recruit.btnAdd.Location = new Point(281, 569);
            _Recruit.btnCancel.Location = new Point(403, 569);
            _Recruit.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Text = "Rechercher";
                txtSearch.ReadOnly = true;
                cbSearch.Items.Insert(2, "Recherche par");
                cbSearch.SelectedIndex = 2;

                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbSearch.SelectedIndex)
                {
                    case 0:
                        if (txtSearch.Text != "")
                        {

                            dgvInfoSh.DataSource = crud.search("id_Emp", txtSearch.Text).Tables[0];
                        }
                        break;

                    case 1:
                        if (txtSearch.Text != "")
                        {
                            dgvInfoSh.DataSource = crud.search("nom", txtSearch.Text).Tables[0];
                        }
                        break;


                    default:
                        MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtSearch.Text == "Rechercher" && cbSearch.SelectedIndex != 2)
                {
                    txtSearch.Text = "";
                    txtSearch.ReadOnly = false;
                }
                else if (cbSearch.SelectedIndex == 2)
                {
                    MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                    txtSearch.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (cbSearch.SelectedIndex == 2)
                    cbSearch.Items.RemoveAt(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string user = Settings.Default.userName;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Etes-vous sur de vouloir supprimer cet enregistrement?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    string deleteRow = dgvInfoSh.CurrentRow.Cells["id_Emp"].Value.ToString();
                    crud.crudop("delete from T_EmployeInfo where id_Emp = '" + deleteRow + "'");
                    
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Suppresseion de fiche de renseignement','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
                }
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyUCLoadHandler(object sender, EventArgs e)
        {
            //Each time the user control load, the text boxes and so get filled with records.
            //The records were already saved in Settings.
            //
            UC_CivilState c_CivilState = new UC_CivilState();
            c_CivilState.txtMtricule.Text = Settings.Default.mat;
            c_CivilState.txtLName.Text = Settings.Default.nom;
            c_CivilState.txtName.Text = Settings.Default.prenom;
            c_CivilState.txtNameB.Text = Settings.Default.nomFille;
            c_CivilState.dtpBirth.Text = Settings.Default.dateNai;
            c_CivilState.txtPBirth.Text = Settings.Default.lieuNai;
            c_CivilState.cbFamSit.Text = Settings.Default.sitFam;
            c_CivilState.cbNationality.Text = Settings.Default.nationalite;
            c_CivilState.txtAddress.Text = Settings.Default.adresse;
            c_CivilState.txtPhone.Text = Settings.Default.phone;
            c_CivilState.txtFathName.Text = Settings.Default.prePere;
            c_CivilState.txtMothName.Text = Settings.Default.nomMere;
            c_CivilState.txtBloodType.Text = Settings.Default.groupSang;
            c_CivilState.txtJobFath.Text = Settings.Default.profPere;
            c_CivilState.txtJobMoth.Text = Settings.Default.profMere;
            c_CivilState.txtSiblingsNum.Text = Settings.Default.nomFrere;
            c_CivilState.txtMName.Text = Settings.Default.nomConj;
            c_CivilState.dtpMarri.Text = Settings.Default.dateMar;
            c_CivilState.txtJobFath.Text = Settings.Default.profConj;
            c_CivilState.txtNumKids.Text = Settings.Default.nomEnfs;
            c_CivilState.txtNumAccount.Text = Settings.Default.nomComp;
            c_CivilState.txtSecuriteNum.Text = Settings.Default.numSec;
            c_CivilState.txtCarteNum.Text = Settings.Default.cartNatio;
            c_CivilState.txtDeliverBy.Text = Settings.Default.delivPar;
            c_CivilState.dtpDeliver.Text = Settings.Default.dateDeliv;
            c_CivilState.txtName.Text = Settings.Default.prenom;
            //
            UC_Military c_Military = new UC_Military();
            if (Settings.Default.degage == "OUI")
            {
                c_Military.rbEngageY.Checked = true;
            }
            else if (Settings.Default.degage == "NON")
            {
                c_Military.rbEngageN.Checked = true;
            }
            c_Military.dtpImmo.Text = Settings.Default.dateImmo;
            c_Military.dtpSursiFrom.Text = Settings.Default.sursiDu;
            c_Military.dtpSursiTo.Text = Settings.Default.sursiAu;
            if (Settings.Default.apteInco == "OUI")
            {
                c_Military.rbAbilityY.Checked = true;
            }
            else if (Settings.Default.apteInco == "NON")
            {
                c_Military.rbAbilityN.Checked = true;
            }
            //
            UC_StudyLevel c_StudyLevel = new UC_StudyLevel();
            c_StudyLevel.txtEtabli1.Text = Settings.Default.etab1;
            c_StudyLevel.txtDomain1.Text = Settings.Default.spec1;
            c_StudyLevel.txtPeriod.Text = Settings.Default.peri1;
            c_StudyLevel.txtDiplome.Text = Settings.Default.dipl1;
            c_StudyLevel.txtObtention1.Text = Settings.Default.annObte1;
            c_StudyLevel.txtEtabli2.Text = Settings.Default.etab2;
            c_StudyLevel.txtDomain2.Text = Settings.Default.spec2;
            c_StudyLevel.txtPeriod2.Text = Settings.Default.peri2;
            c_StudyLevel.txtDiplome2.Text = Settings.Default.dipl2;
            c_StudyLevel.txtObtention2.Text = Settings.Default.annObte2;
            c_StudyLevel.txtEtabli3.Text = Settings.Default.etab3;
            c_StudyLevel.txtDomain3.Text = Settings.Default.spec3;
            c_StudyLevel.txtPeriod3.Text = Settings.Default.peri3;
            c_StudyLevel.txtDiplome3.Text = Settings.Default.dipl3;
            c_StudyLevel.txtObtention3.Text = Settings.Default.annObte3;
            c_StudyLevel.txtEtabli4.Text = Settings.Default.etab4;
            c_StudyLevel.txtDomain4.Text = Settings.Default.spec4;
            c_StudyLevel.txtPeriod4.Text = Settings.Default.peri4;
            c_StudyLevel.txtDiplome4.Text = Settings.Default.dipl4;
            c_StudyLevel.txtObtention4.Text = Settings.Default.annObte4;
            //
            UC_Trainings c_Trainings = new UC_Trainings();
            c_Trainings.txtEtabli1.Text = Settings.Default.etabl1;
            c_Trainings.txtDomain1.Text = Settings.Default.speci1;
            c_Trainings.txtPeriod.Text = Settings.Default.perio1;
            c_Trainings.txtDiplome.Text = Settings.Default.diplo1;
            c_Trainings.txtObtD1.Text = Settings.Default.annObten1;
            c_Trainings.txtEtabli2.Text = Settings.Default.etabl2;
            c_Trainings.txtDomain2.Text = Settings.Default.speci2;
            c_Trainings.txtPeriod2.Text = Settings.Default.perio2;
            c_Trainings.txtDiplome2.Text = Settings.Default.diplo2;
            c_Trainings.txtObtD2.Text = Settings.Default.annObten2;
            c_Trainings.txtEtabli3.Text = Settings.Default.etabl3;
            c_Trainings.txtDomain3.Text = Settings.Default.speci3;
            c_Trainings.txtPeriod3.Text = Settings.Default.perio3;
            c_Trainings.txtDiplome3.Text = Settings.Default.diplo3;
            c_Trainings.txtObtD3.Text = Settings.Default.annObten3;
            c_Trainings.txtEtabli4.Text = Settings.Default.etabl4;
            c_Trainings.txtDomain4.Text = Settings.Default.speci4;
            c_Trainings.txtPeriod4.Text = Settings.Default.perio4;
            c_Trainings.txtDiplome4.Text = Settings.Default.diplo4;
            c_Trainings.txtObtD4.Text = Settings.Default.annObten4;
            //
            UC_Career c_Career = new UC_Career();
            c_Career.txtEmp1.Text = Settings.Default.emp1;
            c_Career.txtWork1.Text = Settings.Default.job1;
            c_Career.txtFrom1.Text = Settings.Default.dateDeb1;
            c_Career.txtTo1.Text = Settings.Default.dateFin1;
            c_Career.txtMotive1.Text = Settings.Default.motifDep1;
            c_Career.txtEmp2.Text = Settings.Default.emp2;
            c_Career.txtWork2.Text = Settings.Default.job2;
            c_Career.txtFrom2.Text = Settings.Default.dateDeb2;
            c_Career.txtTo2.Text = Settings.Default.dateFin2;
            c_Career.txtMotive2.Text = Settings.Default.motifDep2;
            c_Career.txtEmp3.Text = Settings.Default.emp3;
            c_Career.txtWork3.Text = Settings.Default.job3;
            c_Career.txtFrom3.Text = Settings.Default.dateDeb3;
            c_Career.txtTo3.Text = Settings.Default.dateFin3;
            c_Career.txtMotive3.Text = Settings.Default.motifDep3;
            c_Career.txtEmp4.Text = Settings.Default.emp4;
            c_Career.txtWork4.Text = Settings.Default.job4;
            c_Career.txtFrom4.Text = Settings.Default.dateDeb4;
            c_Career.txtTo4.Text = Settings.Default.dateFin4;
            c_Career.txtMotive4.Text = Settings.Default.motifDep4;
            //
            UC_Language c_Language = new UC_Language();
            if (Settings.Default.fre == "T.Bien")
            {
                c_Language.rbVGFr.Checked = true;
            }
            else if (Settings.Default.fre == "Bien")
            {
                c_Language.rbGFr.Checked = true;
            }
            else if (Settings.Default.fre == "Moyen+")
            {
                c_Language.rbMPFr.Checked = true;
            }
            else if (Settings.Default.fre == "Moyen-")
            {
                c_Language.rbMNFr.Checked = true;
            }
            else if (Settings.Default.fre == "Néant")
            {
                c_Language.rbNFr.Checked = true;
            }
            if (Settings.Default.ara == "T.Bien")
            {
                c_Language.rbVGAr.Checked = true;
            }
            else if (Settings.Default.ara == "Bien")
            {
                c_Language.rbGAr.Checked = true;
            }
            else if (Settings.Default.ara == "Moyen+")
            {
                c_Language.rbMPAr.Checked = true;
            }
            else if (Settings.Default.ara == "Moyen-")
            {
                c_Language.rbMNAr.Checked = true;
            }
            else if (Settings.Default.ara == "Néant")
            {
                c_Language.rbNAr.Checked = true;
            }
            if (Settings.Default.ang == "T.Bien")
            {
                c_Language.rbVGEng.Checked = true;
            }
            else if (Settings.Default.ang == "Bien")
            {
                c_Language.rbGEng.Checked = true;
            }
            else if (Settings.Default.ang == "Moyen+")
            {
                c_Language.rbMPEng.Checked = true;
            }
            else if (Settings.Default.ang == "Moyen-")
            {
                c_Language.rbMNEng.Checked = true;
            }
            else if (Settings.Default.ang == "Néant")
            {
                c_Language.rbNEng.Checked = true;
            }
            if (Settings.Default.all == "T.Bien")
            {
                c_Language.rbVGer.Checked = true;
            }
            else if (Settings.Default.all == "Bien")
            {
                c_Language.rbGer.Checked = true;
            }
            else if (Settings.Default.all == "Moyen+")
            {
                c_Language.rbMPGer.Checked = true;
            }
            else if (Settings.Default.all == "Moyen-")
            {
                c_Language.rbMNGer.Checked = true;
            }
            else if (Settings.Default.all == "Néant")
            {
                c_Language.rbNGer.Checked = true;
            }
            if (Settings.Default.aut == "T.Bien")
            {
                c_Language.rbVGOth.Checked = true;
            }
            else if (Settings.Default.aut == "Bien")
            {
                c_Language.rbGOth.Checked = true;
            }
            else if (Settings.Default.aut == "Moyen+")
            {
                c_Language.rbMPOth.Checked = true;
            }
            else if (Settings.Default.aut == "Moyen-")
            {
                c_Language.rbMNOth.Checked = true;
            }
            else if (Settings.Default.aut == "Néant")
            {
                c_Language.rbNOth.Checked = true;
            }
            c_Language.txtOther.Text = Settings.Default.autLang;
            //
            UC_Software c_Software = new UC_Software();
            c_Software.txtSoftware1.Text = Settings.Default.log1;
            if (Settings.Default.log1For == "Avec formation")
            {
                c_Software.rbWFS1.Checked = true;
            }
            else if (Settings.Default.log1For == "Sans formation")
            {
                c_Software.rbWoutFS1.Checked = true;
            }
            if (Settings.Default.log1Niv == "T.Bien")
            {
                c_Software.rbVGoodS1.Checked = true;
            }
            else if (Settings.Default.log1Niv == "Bien")
            {
                c_Software.rbGoodS1.Checked = true;
            }
            else if (Settings.Default.log1Niv == "Moyen")
            {
                c_Software.rbMediumS1.Checked = true;
            }
            else if (Settings.Default.log1Niv == "Initiation")
            {
                c_Software.rbInitS1.Checked = true;
            }
            c_Software.txtSoftware2.Text = Settings.Default.log2;
            if (Settings.Default.log2For == "Avec formation")
            {
                c_Software.rbWFS2.Checked = true;
            }
            else if (Settings.Default.log2For == "Sans formation")
            {
                c_Software.rbWoutFS2.Checked = true;
            }
            if (Settings.Default.log2Niv == "T.Bien")
            {
                c_Software.rbVGoodS2.Checked = true;
            }
            else if (Settings.Default.log2Niv == "Bien")
            {
                c_Software.rbGoodS2.Checked = true;
            }
            else if (Settings.Default.log2Niv == "Moyen")
            {
                c_Software.rbMediumS2.Checked = true;
            }
            else if (Settings.Default.log2Niv == "Initiation")
            {
                c_Software.rbIntS2.Checked = true;
            }
            c_Software.txtSoftware3.Text = Settings.Default.log3;
            if (Settings.Default.log3For == "Avec formation")
            {
                c_Software.rbWFS3.Checked = true;
            }
            else if (Settings.Default.log3For == "Sans formation")
            {
                c_Software.rbWoutFS3.Checked = true;
            }
            if (Settings.Default.log3Niv == "T.Bien")
            {
                c_Software.rbVGoodS3.Checked = true;
            }
            else if (Settings.Default.log3Niv == "Bien")
            {
                c_Software.rbGoodS3.Checked = true;
            }
            else if (Settings.Default.log3Niv == "Moyen")
            {
                c_Software.rbMediumS3.Checked = true;
            }
            else if (Settings.Default.log3Niv == "Initiation")
            {
                c_Software.rbInitS3.Checked = true;
            }
            c_Software.txtSoftware4.Text = Settings.Default.log4;
            if (Settings.Default.log4For == "Avec formation")
            {
                c_Software.rbWFS4.Checked = true;
            }
            else if (Settings.Default.log4For == "Sans formation")
            {
                c_Software.rbWoutFS4.Checked = true;
            }
            if (Settings.Default.log4Niv == "T.Bien")
            {
                c_Software.rbVGoodS4.Checked = true;
            }
            else if (Settings.Default.log4Niv == "Bien")
            {
                c_Software.rbGoodS4.Checked = true;
            }
            else if (Settings.Default.log4Niv == "Moyen")
            {
                c_Software.rbMediumS4.Checked = true;
            }
            else if (Settings.Default.log4Niv == "Initiation")
            {
                c_Software.rbInitS4.Checked = true;
            }
            //
            UC_Projects c_Projects = new UC_Projects();
            c_Projects.txtProjects.Text = Settings.Default.trax;
            //
            UC_Intersets c_Intersets = new UC_Intersets();
            c_Intersets.txtInter1.Text = Settings.Default.inter1;
            c_Intersets.txtInter2.Text = Settings.Default.inter2;
            c_Intersets.txtInter3.Text = Settings.Default.inter3;
            c_Intersets.txtInter4.Text = Settings.Default.inter4;
            c_Intersets.txtInter5.Text = Settings.Default.inter5;
            c_Intersets.txtInter6.Text = Settings.Default.inter6;
            c_Intersets.txtInter7.Text = Settings.Default.inter7;
            c_Intersets.txtInter8.Text = Settings.Default.inter8;
            //
            UC_DoYouKnow c_DoYouKnow = new UC_DoYouKnow();
            c_DoYouKnow.txtFName1.Text = Settings.Default.nom1;
            c_DoYouKnow.txtName1.Text = Settings.Default.pren1;
            c_DoYouKnow.txtJob1.Text = Settings.Default.fonc1;
            c_DoYouKnow.txtFName2.Text = Settings.Default.nom2;
            c_DoYouKnow.txtName2.Text = Settings.Default.pren2;
            c_DoYouKnow.txtJob2.Text = Settings.Default.fonc2;
            //
            UC_Medecin c_Medecin = new UC_Medecin();
            if (Settings.Default.testMed == "Concluant")
            {
                c_Medecin.rbMedC.Checked = true;
            }
            else if (Settings.Default.testMed == "Non Concluant")
            {
                c_Medecin.rbMedNC.Checked = true;
            }
            if (Settings.Default.testProf == "Concluant")
            {
                c_Medecin.rbProC.Checked = true;
            }
            else if (Settings.Default.testProf == "Non Concluant")
            {
                c_Medecin.rbProNC.Checked = true;
            }
            //
            UC_ContractInfo c_ContractInfo = new UC_ContractInfo();
            c_ContractInfo.dtpContract.Text = Settings.Default.dateCont;
            c_ContractInfo.txtPost.Text = Settings.Default.fonc;
            c_ContractInfo.txtService.Text = Settings.Default.service;
            c_ContractInfo.dtpEngage.Text = Settings.Default.dateEngage;
            c_ContractInfo.combEtat.Text = Settings.Default.etatCont;
            //
            UC_Rewards c_Rewards = new UC_Rewards();
            c_Rewards.txtSalary.Text = Settings.Default.salaire;
            c_Rewards.txtIEP.Text = Settings.Default.iep;
            if (Settings.Default.panier == "Yes")
            {
                c_Rewards.cbPanier.Checked = true;
            }
            else if (Settings.Default.panier == "No")
            {
                c_Rewards.cbPanier.Checked = false;
            }
            if (Settings.Default.trans == "Yes")
            {
                c_Rewards.cbTransport.Checked = true;
            }
            else if (Settings.Default.trans == "No")
            {
                c_Rewards.cbTransport.Checked = false;
            }
            if (Settings.Default.saliss == "Yes")
            {
                c_Rewards.cbSoil.Checked = true;
            }
            else if (Settings.Default.saliss == "No")
            {
                c_Rewards.cbSoil.Checked = false;
            }
            if (Settings.Default.indemnV == "Yes")
            {
                c_Rewards.cbIndemnity.Checked = true;
            }
            else if (Settings.Default.indemnV == "No")
            {
                c_Rewards.cbIndemnity.Checked = false;
            }
            if (Settings.Default.deplace == "Yes")
            {
                c_Rewards.cbMove.Checked = true;
            }
            else if (Settings.Default.deplace == "No")
            {
                c_Rewards.cbMove.Checked = false;
            }
            if (Settings.Default.danger == "Yes")
            {
                c_Rewards.cbDanger.Checked = true;
            }
            else if (Settings.Default.danger == "No")
            {
                c_Rewards.cbDanger.Checked = false;
            }
            if (Settings.Default.phone == "Yes")
            {
                c_Rewards.cbPhone.Checked = true;
            }
            else if (Settings.Default.phone == "No")
            {
                c_Rewards.cbPhone.Checked = false;
            }
            if (Settings.Default.penibilite == "Yes")
            {
                c_Rewards.cbSeverty.Checked = true;
            }
            else if (Settings.Default.penibilite == "No")
            {
                c_Rewards.cbSeverty.Checked = false;
            }
            if (Settings.Default.insalub == "Yes")
            {
                c_Rewards.cbInsalubrity.Checked = true;
            }
            else if (Settings.Default.insalub == "No")
            {
                c_Rewards.cbInsalubrity.Checked = false;
            }
            if (Settings.Default.fidelite == "Yes")
            {
                c_Rewards.cbFidelity.Checked = true;
            }
            else if (Settings.Default.fidelite == "No")
            {
                c_Rewards.cbFidelity.Checked = false;
            }
            if (Settings.Default.pri == "Yes")
            {
                c_Rewards.cbPRI.Checked = true;
            }
            else if (Settings.Default.pri == "No")
            {
                c_Rewards.cbPRI.Checked = false;
            }
            if (Settings.Default.prc == "Yes")
            {
                c_Rewards.cbPRC.Checked = true;
            }
            else if (Settings.Default.prc == "No")
            {
                c_Rewards.cbPRC.Checked = false;
            }
            if (Settings.Default.ppi == "Yes")
            {
                c_Rewards.cbPPI.Checked = true;
            }
            else if (Settings.Default.ppi == "No")
            {
                c_Rewards.cbPPI.Checked = false;
            }
            if (Settings.Default.iq == "Yes")
            {
                c_Rewards.cbIQ.Checked = true;
            }
            else if (Settings.Default.iq == "No")
            {
                c_Rewards.cbIQ.Checked = false;
            }
            if (Settings.Default.mission == "Yes")
            {
                c_Rewards.cbMission.Checked = true;
            }
            else if (Settings.Default.mission == "No")
            {
                c_Rewards.cbMission.Checked = false;
            }
            if (Settings.Default.ifri == "Yes")
            {
                c_Rewards.cbIFRI.Checked = true;
            }
            else if (Settings.Default.ifri == "No")
            {
                c_Rewards.cbIFRI.Checked = false;
            }
            c_Rewards.txtOther.Text = Settings.Default.autre;
            //
            UC_TrialPeriod c_TrialPeriod = new UC_TrialPeriod();
            if (Settings.Default.periodEssai == "Concluant")
            {
                c_TrialPeriod.rbConcluant.Checked = true;
            }
            else if (Settings.Default.periodEssai == "prolonger")
            {
                c_TrialPeriod.rbPAdd.Checked = true;
            }
            else if (Settings.Default.periodEssai == "Non Concluant")
            {
                c_TrialPeriod.rbPNConcluant.Checked = true;
            }
            c_TrialPeriod.dtpNotification.Text = Settings.Default.dateNotifEssai;
            c_TrialPeriod.txtRef.Text = Settings.Default.refEssai;
            //
            UC_FormationCSC c_FormationCSC = new UC_FormationCSC();
            c_FormationCSC.txtExe1.Text = Settings.Default.exe1;
            c_FormationCSC.txtTheme1.Text = Settings.Default.the1;
            c_FormationCSC.txtFP1.Text = Settings.Default.lieuF1;
            c_FormationCSC.txtPeriod1.Text = Settings.Default.dure1;
            c_FormationCSC.dtp1.Text = Settings.Default.dateF1;
            c_FormationCSC.txtObject1.Text = Settings.Default.obj1;
            c_FormationCSC.txtExe2.Text = Settings.Default.exe2;
            c_FormationCSC.txtTheme2.Text = Settings.Default.the2;
            c_FormationCSC.txtFP2.Text = Settings.Default.lieuF2;
            c_FormationCSC.txtPeriod2.Text = Settings.Default.dure2;
            c_FormationCSC.dtp2.Text = Settings.Default.dateF2;
            c_FormationCSC.txtObject2.Text = Settings.Default.obj2;
            c_FormationCSC.txtExe3.Text = Settings.Default.exe3;
            c_FormationCSC.txtTheme3.Text = Settings.Default.the3;
            c_FormationCSC.txtFP3.Text = Settings.Default.lieuF3;
            c_FormationCSC.txtPeriod3.Text = Settings.Default.dure3;
            c_FormationCSC.dtp3.Text = Settings.Default.dateF3;
            c_FormationCSC.txtObject3.Text = Settings.Default.obj3;
            c_FormationCSC.txtExe4.Text = Settings.Default.exe4;
            c_FormationCSC.txtTheme4.Text = Settings.Default.the4;
            c_FormationCSC.txtFP4.Text = Settings.Default.lieuF4;
            c_FormationCSC.txtPeriod4.Text = Settings.Default.dure4;
            c_FormationCSC.dtp4.Text = Settings.Default.dateF4;
            c_FormationCSC.txtObject4.Text = Settings.Default.obj4;
            c_FormationCSC.txtExe5.Text = Settings.Default.exe5;
            c_FormationCSC.txtTheme5.Text = Settings.Default.the5;
            c_FormationCSC.txtFP5.Text = Settings.Default.lieuF5;
            c_FormationCSC.txtPeriod5.Text = Settings.Default.dure5;
            c_FormationCSC.dtp5.Text = Settings.Default.dateF5;
            c_FormationCSC.txtObject5.Text = Settings.Default.obj5;
            //
            UC_Discipline c_Discipline = new UC_Discipline();
            c_Discipline.txtQualif1.Text = Settings.Default.qual1;
            c_Discipline.txtPunish1.Text = Settings.Default.natS1;
            c_Discipline.dtp1.Text = Settings.Default.dateS1;
            c_Discipline.txtMotive1.Text = Settings.Default.motif1;
            c_Discipline.txtObserv1.Text = Settings.Default.obser1;
            c_Discipline.txtQualif2.Text = Settings.Default.qual2;
            c_Discipline.txtPunish2.Text = Settings.Default.natS2;
            c_Discipline.dtp1.Text = Settings.Default.dateS2;
            c_Discipline.txtMotive2.Text = Settings.Default.motif2;
            c_Discipline.txtObserv2.Text = Settings.Default.obser2;
            c_Discipline.txtQualif3.Text = Settings.Default.qual3;
            c_Discipline.txtPunish3.Text = Settings.Default.natS3;
            c_Discipline.dtp3.Text = Settings.Default.dateS3;
            c_Discipline.txtMotive3.Text = Settings.Default.motif3;
            c_Discipline.txtObserv3.Text = Settings.Default.obser3;
            c_Discipline.txtQualif4.Text = Settings.Default.qual4;
            c_Discipline.txtPunish4.Text = Settings.Default.natS4;
            c_Discipline.dtp4.Text = Settings.Default.dateS4;
            c_Discipline.txtMotive4.Text = Settings.Default.motif4;
            c_Discipline.txtObserv4.Text = Settings.Default.obser4;
            //
            UC_Surveillance c_Surveillance = new UC_Surveillance();
            if (Settings.Default.etape == "Initiale")
            {
                c_Surveillance.rbInit.Checked = true;
            }
            else if (Settings.Default.etape == "suivi 1")
            {
                c_Surveillance.rbFollow1.Checked = true;
            }
            else if (Settings.Default.etape == "suivi 2")
            {
                c_Surveillance.rbFollow2.Checked = true;
            }
            else if (Settings.Default.etape == "suivi 3")
            {
                c_Surveillance.rbFollow3.Checked = true;
            }
            else if (Settings.Default.etape == "non surveillé")
            {
                c_Surveillance.rbNFollow.Checked = true;
            }
            c_Surveillance.dtp1.Text = Settings.Default.dateSur1;
            c_Surveillance.txtStep1.Text = Settings.Default.etapSur1;
            c_Surveillance.txtTechnic1.Text = Settings.Default.tech1;
            c_Surveillance.txtMark1.Text = Settings.Default.not1;
            c_Surveillance.txtNote1.Text = Settings.Default.rema1;
            c_Surveillance.dtp2.Text = Settings.Default.dateSur2;
            c_Surveillance.txtStep2.Text = Settings.Default.etapSur2;
            c_Surveillance.txtTechnic2.Text = Settings.Default.tech2;
            c_Surveillance.txtMark2.Text = Settings.Default.not2;
            c_Surveillance.txtNote2.Text = Settings.Default.rema2;
            c_Surveillance.dtp3.Text = Settings.Default.dateSur3;
            c_Surveillance.txtStep3.Text = Settings.Default.etapSur3;
            c_Surveillance.txtTechnic3.Text = Settings.Default.tech3;
            c_Surveillance.txtMark3.Text = Settings.Default.not3;
            c_Surveillance.txtNote3.Text = Settings.Default.rema3;
            c_Surveillance.dtp4.Text = Settings.Default.dateSur4;
            c_Surveillance.txtStep4.Text = Settings.Default.etapSur4;
            c_Surveillance.txtTechnic4.Text = Settings.Default.tech4;
            c_Surveillance.txtMark4.Text = Settings.Default.not4;
            c_Surveillance.txtNote4.Text = Settings.Default.rema4;
            c_Surveillance.dtp5.Text = Settings.Default.dateSur5;
            c_Surveillance.txtStep5.Text = Settings.Default.etapSur5;
            c_Surveillance.txtTechnic5.Text = Settings.Default.tech5;
            c_Surveillance.txtMark5.Text = Settings.Default.not5;
            c_Surveillance.txtNote5.Text = Settings.Default.rema5;
            c_Surveillance.dtp6.Text = Settings.Default.dateSur6;
            c_Surveillance.txtStep6.Text = Settings.Default.etapSur6;
            c_Surveillance.txtTechnic6.Text = Settings.Default.tech6;
            c_Surveillance.txtMark6.Text = Settings.Default.not6;
            c_Surveillance.txtNote6.Text = Settings.Default.rema6;
            c_Surveillance.dtp7.Text = Settings.Default.dateSur7;
            c_Surveillance.txtStep7.Text = Settings.Default.etapSur7;
            c_Surveillance.txtTechnic7.Text = Settings.Default.tech7;
            c_Surveillance.txtMark7.Text = Settings.Default.not7;
            c_Surveillance.txtNote7.Text = Settings.Default.rema7;
            //
            UC_Evaluation c_Evaluation = new UC_Evaluation();
            c_Evaluation.txtExer1.Text = Settings.Default.exer1;
            c_Evaluation.txtNote1.Text = Settings.Default.notGlob1;
            c_Evaluation.txtAppr1.Text = Settings.Default.appr1;
            c_Evaluation.txtExer2.Text = Settings.Default.exer2;
            c_Evaluation.txtNote2.Text = Settings.Default.notGlob2;
            c_Evaluation.txtAppr2.Text = Settings.Default.appr2;
            c_Evaluation.txtExer3.Text = Settings.Default.exer3;
            c_Evaluation.txtNote3.Text = Settings.Default.notGlob3;
            c_Evaluation.txtAppr3.Text = Settings.Default.appr3;
            c_Evaluation.txtExer4.Text = Settings.Default.exer4;
            c_Evaluation.txtNote4.Text = Settings.Default.notGlob4;
            c_Evaluation.txtAppr4.Text = Settings.Default.appr4;
            c_Evaluation.txtExer5.Text = Settings.Default.exer5;
            c_Evaluation.txtNote5.Text = Settings.Default.notGlob5;
            c_Evaluation.txtAppr5.Text = Settings.Default.appr5;
            c_Evaluation.txtExer6.Text = Settings.Default.exer6;
            c_Evaluation.txtNote6.Text = Settings.Default.notGlob6;
            c_Evaluation.txtAppr6.Text = Settings.Default.appr6;
            c_Evaluation.txtExer7.Text = Settings.Default.exer7;
            c_Evaluation.txtNote7.Text = Settings.Default.notGlob7;
            c_Evaluation.txtAppr7.Text = Settings.Default.appr7;
            //
            UC_Emprovement c_Emprovement = new UC_Emprovement();
            c_Emprovement.txtExer1.Text = Settings.Default.exerc1;
            c_Emprovement.txtPromo1.Text = Settings.Default.promo1;
            c_Emprovement.txtReaff1.Text = Settings.Default.reaff1;
            c_Emprovement.txtExer1.Text = Settings.Default.form1;
            c_Emprovement.txtExer1.Text = Settings.Default.autre1;
            c_Emprovement.txtExer2.Text = Settings.Default.exerc2;
            c_Emprovement.txtPromo2.Text = Settings.Default.promo2;
            c_Emprovement.txtReaff2.Text = Settings.Default.reaff2;
            c_Emprovement.txtExer2.Text = Settings.Default.form2;
            c_Emprovement.txtExer2.Text = Settings.Default.autre2;
            c_Emprovement.txtExer3.Text = Settings.Default.exerc3;
            c_Emprovement.txtPromo3.Text = Settings.Default.promo3;
            c_Emprovement.txtReaff3.Text = Settings.Default.reaff3;
            c_Emprovement.txtExer3.Text = Settings.Default.form3;
            c_Emprovement.txtExer3.Text = Settings.Default.autre3;
            c_Emprovement.txtExer4.Text = Settings.Default.exerc4;
            c_Emprovement.txtPromo4.Text = Settings.Default.promo4;
            c_Emprovement.txtReaff4.Text = Settings.Default.reaff4;
            c_Emprovement.txtExer4.Text = Settings.Default.form4;
            c_Emprovement.txtExer4.Text = Settings.Default.autre4;
            c_Emprovement.txtExer5.Text = Settings.Default.exerc5;
            c_Emprovement.txtPromo5.Text = Settings.Default.promo5;
            c_Emprovement.txtReaff5.Text = Settings.Default.reaff5;
            c_Emprovement.txtExer5.Text = Settings.Default.form5;
            c_Emprovement.txtExer5.Text = Settings.Default.autre5;
            c_Emprovement.txtExer6.Text = Settings.Default.exerc6;
            c_Emprovement.txtPromo6.Text = Settings.Default.promo6;
            c_Emprovement.txtReaff6.Text = Settings.Default.reaff6;
            c_Emprovement.txtExer6.Text = Settings.Default.form6;
            c_Emprovement.txtExer6.Text = Settings.Default.autre6;
            c_Emprovement.txtExer7.Text = Settings.Default.exerc7;
            c_Emprovement.txtPromo7.Text = Settings.Default.promo7;
            c_Emprovement.txtReaff7.Text = Settings.Default.reaff7;
            c_Emprovement.txtExer7.Text = Settings.Default.form7;
            c_Emprovement.txtExer7.Text = Settings.Default.autre7;
            //
            UC_EndContract c_EndContract = new UC_EndContract();
            if (Settings.Default.contract == "concluant")
            {
                c_EndContract.rbConcluant.Checked = true;
            }
            else if (Settings.Default.contract == "non concluant")
            {
                c_EndContract.rbNConcluant.Checked = true;
            }
            //
            UC_Leave c_Leave = new UC_Leave();
            c_Leave.dtpLeave.Text = Settings.Default.dateDep;
            c_Leave.combCateg.Text = Settings.Default.categDep;
            c_Leave.combCause.Text = Settings.Default.causeDep;
            c_Leave.txtOtherCauses.Text = Settings.Default.othCauseDep;
        }
        //public Delegate Mat13;
        public void transferData()
        {
            //Each time the button of the user control is pressed, all records get saved in Settings to be retrieved later.
            string selectedRow = dgvInfoSh.CurrentRow.Cells["id_Emp"].Value.ToString();
            Settings.Default.mat = crud.getEmployeeInfo(selectedRow, "id_Emp").Item1;
            Settings.Default.nom = crud.getEmployeeInfo(selectedRow, "id_Emp").Item2;
            Settings.Default.prenom = crud.getEmployeeInfo(selectedRow, "id_Emp").Item3;
            Settings.Default.nomFille = crud.getEmployeeInfo(selectedRow, "id_Emp").Item4;
            Settings.Default.dateNai = crud.getEmployeeInfo(selectedRow, "id_Emp").Item5;
            Settings.Default.lieuNai = crud.getEmployeeInfo(selectedRow, "id_Emp").Item6;
            Settings.Default.sitFam = crud.getEmployeeInfo(selectedRow, "id_Emp").Item7;
            Settings.Default.nationalite = crud.getEmployeeInfo(selectedRow, "id_Emp").Item8;
            Settings.Default.adresse = crud.getEmployeeInfo(selectedRow, "id_Emp").Item9;
            Settings.Default.mobile = crud.getEmployeeInfo(selectedRow, "id_Emp").Item10;
            Settings.Default.prePere = crud.getEmployeeInfo(selectedRow, "id_Emp").Item11;
            Settings.Default.nomMere = crud.getEmployeeInfo(selectedRow, "id_Emp").Item12;
            Settings.Default.groupSang = crud.getEmployeeInfo(selectedRow, "id_Emp").Item13;
            Settings.Default.profPere = crud.getEmployeeInfo(selectedRow, "id_Emp").Item14;
            Settings.Default.profMere = crud.getEmployeeInfo(selectedRow, "id_Emp").Item15;
            Settings.Default.nomFrere = crud.getEmployeeInfo(selectedRow, "id_Emp").Item16;
            Settings.Default.nomConj = crud.getEmployeeInfo(selectedRow, "id_Emp").Item17;
            Settings.Default.dateMar = crud.getEmployeeInfo(selectedRow, "id_Emp").Item18;
            Settings.Default.profConj = crud.getEmployeeInfo(selectedRow, "id_Emp").Item19;
            Settings.Default.nomEnfs = crud.getEmployeeInfo(selectedRow, "id_Emp").Item20;
            Settings.Default.nomComp = crud.getEmployeeInfo(selectedRow, "id_Emp").Item21;
            Settings.Default.numSec = crud.getEmployeeInfo(selectedRow, "id_Emp").Item22;
            Settings.Default.cartNatio = crud.getEmployeeInfo(selectedRow, "id_Emp").Item23;
            Settings.Default.delivPar = crud.getEmployeeInfo(selectedRow, "id_Emp").Item24;
            Settings.Default.dateDeliv = crud.getEmployeeInfo(selectedRow, "id_Emp").Item25;
            //
            Settings.Default.degage = crud.getEmployeeInfo(selectedRow, "id_Emp").Item26;
            Settings.Default.dateImmo = crud.getEmployeeInfo(selectedRow, "id_Emp").Item27;
            Settings.Default.sursiDu = crud.getEmployeeInfo(selectedRow, "id_Emp").Item28;
            Settings.Default.sursiAu = crud.getEmployeeInfo(selectedRow, "id_Emp").Item29;
            Settings.Default.apteInco = crud.getEmployeeInfo(selectedRow, "id_Emp").Item30;
            //
            Settings.Default.autr = crud.getEmployeeInfo(selectedRow, "id_Emp").Item31;
            Settings.Default.dateDoc = crud.getEmployeeInfo(selectedRow, "id_Emp").Item32;
            Settings.Default.choi = crud.getEmployeeInfo(selectedRow, "id_Emp").Item33;
            //
            Settings.Default.id_NivSco = crud.getEmployeeInfo(selectedRow, "id_Emp").Item54;
            Settings.Default.eta1 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item34;
            Settings.Default.spe1 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item35;
            Settings.Default.per1 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item36;
            Settings.Default.dip1 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item37;
            Settings.Default.annObt1 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item38;
            Settings.Default.id_NivSco1 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item56;
            Settings.Default.eta2 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item39;
            Settings.Default.spe2 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item40;
            Settings.Default.per2 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item41;
            Settings.Default.dip2 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item42;
            Settings.Default.annObt2 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item43;
            Settings.Default.id_NivSco3 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item57;
            Settings.Default.eta3 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item44;
            Settings.Default.spe3 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item45;
            Settings.Default.per3 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item46;
            Settings.Default.dip3 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item47;
            Settings.Default.annObt3 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item48;
            Settings.Default.id_NivSco3 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item58;
            Settings.Default.eta4 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item49;
            Settings.Default.spe4 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item50;
            Settings.Default.per4 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item51;
            Settings.Default.dip4 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item52;
            Settings.Default.annObt4 = crud.getEmployeeInfo(selectedRow, "id_Emp").Item53;
            //
            Settings.Default.id_EnsProf = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item21;
            Settings.Default.etab1 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item1;
            Settings.Default.spec1 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item2;
            Settings.Default.peri1 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item3;
            Settings.Default.dipl1 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item4;
            Settings.Default.annObte1 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item5;
            Settings.Default.id_EnsProf1 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item22;
            Settings.Default.etab2 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item6;
            Settings.Default.spec2 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item7;
            Settings.Default.peri2 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item8;
            Settings.Default.dipl2 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item9;
            Settings.Default.annObte2 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item10;
            Settings.Default.id_EnsProf3 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item23;
            Settings.Default.etab3 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item11;
            Settings.Default.spec3 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item12;
            Settings.Default.peri3 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item13;
            Settings.Default.dipl3 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item14;
            Settings.Default.annObte3 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item15;
            Settings.Default.id_EnsProf3 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item24;
            Settings.Default.etab4 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item16;
            Settings.Default.spec4 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item17;
            Settings.Default.peri4 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item18;
            Settings.Default.dipl4 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item19;
            Settings.Default.annObte4 = crud.getEmployeeProfStudy(selectedRow, "id_Emp").Item20;
            //
            Settings.Default.id_Stag = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item21;
            Settings.Default.etabl1 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item1;
            Settings.Default.speci1 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item2;
            Settings.Default.perio1 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item3;
            Settings.Default.diplo1 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item4;
            Settings.Default.annObten1 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item5;
            Settings.Default.id_Stag1 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item22;
            Settings.Default.etabl2 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item6;
            Settings.Default.speci2 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item7;
            Settings.Default.perio2 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item8;
            Settings.Default.diplo2 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item9;
            Settings.Default.annObten2 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item10;
            Settings.Default.id_Stag2 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item23;
            Settings.Default.etabl3 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item11;
            Settings.Default.speci3 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item12;
            Settings.Default.perio3 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item13;
            Settings.Default.diplo3 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item14;
            Settings.Default.annObten3 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item15;
            Settings.Default.id_Stag3 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item24;
            Settings.Default.etabl4 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item16;
            Settings.Default.speci4 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item17;
            Settings.Default.perio4 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item18;
            Settings.Default.diplo4 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item19;
            Settings.Default.annObten4 = crud.getEmployeeTrainings(selectedRow, "id_Emp").Item20;
            //
            Settings.Default.id_Carr = crud.getEmployeeCareer(selectedRow, "id_Emp").Item21;
            Settings.Default.emp1 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item1;
            Settings.Default.job1 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item2;
            Settings.Default.dateDeb1 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item3;
            Settings.Default.dateFin1 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item4;
            Settings.Default.motifDep1 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item5;
            Settings.Default.id_Carr1 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item22;
            Settings.Default.emp2 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item6;
            Settings.Default.job2 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item7;
            Settings.Default.dateDeb2 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item8;
            Settings.Default.dateFin2 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item9;
            Settings.Default.motifDep2 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item10;
            Settings.Default.id_Carr2 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item23;
            Settings.Default.emp3 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item11;
            Settings.Default.job3 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item12;
            Settings.Default.dateDeb3 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item13;
            Settings.Default.dateFin3 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item14;
            Settings.Default.motifDep3 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item15;
            Settings.Default.id_Carr3 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item24;
            Settings.Default.emp4 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item16;
            Settings.Default.job4 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item17;
            Settings.Default.dateDeb4 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item18;
            Settings.Default.dateFin4 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item19;
            Settings.Default.motifDep4 = crud.getEmployeeCareer(selectedRow, "id_Emp").Item20;
            //
            Settings.Default.fre = crud.getEmployeeLanguages(selectedRow, "id_Emp").Item1;
            Settings.Default.ara = crud.getEmployeeLanguages(selectedRow, "id_Emp").Item2;
            Settings.Default.ang = crud.getEmployeeLanguages(selectedRow, "id_Emp").Item3;
            Settings.Default.all = crud.getEmployeeLanguages(selectedRow, "id_Emp").Item4;
            Settings.Default.autLang = crud.getEmployeeLanguages(selectedRow, "id_Emp").Item5;
            Settings.Default.aut = crud.getEmployeeLanguages(selectedRow, "id_Emp").Item6;
            //
            Settings.Default.id_Log = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item13;
            Settings.Default.log1 = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item1;
            Settings.Default.log1For = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item2;
            Settings.Default.log1Niv = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item3;
            Settings.Default.id_Log1 = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item14;
            Settings.Default.log2 = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item4;
            Settings.Default.log2For = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item5;
            Settings.Default.log2Niv = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item6;
            Settings.Default.id_Log2 = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item15;
            Settings.Default.log3 = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item7;
            Settings.Default.log3For = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item8;
            Settings.Default.log3Niv = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item9;
            Settings.Default.id_Log3 = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item16;
            Settings.Default.log4 = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item10;
            Settings.Default.log4For = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item11;
            Settings.Default.log4Niv = crud.getEmployeeSoftware(selectedRow, "id_Emp").Item12;
            //
            Settings.Default.trax = crud.getEmployeeProjects(selectedRow, "id_Emp");
            //
            Settings.Default.id_Inter = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item9;
            Settings.Default.inter1 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item1;
            Settings.Default.id_inter1 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item10;
            Settings.Default.inter2 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item2;
            Settings.Default.id_Inter2 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item11;
            Settings.Default.inter3 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item3;
            Settings.Default.id_Inter3 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item12;
            Settings.Default.inter4 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item4;
            Settings.Default.id_Inter4 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item13;
            Settings.Default.inter5 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item5;
            Settings.Default.id_Inter5 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item14;
            Settings.Default.inter6 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item6;
            Settings.Default.id_Inter6 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item15;
            Settings.Default.inter7 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item7;
            Settings.Default.id_Inter7 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item16;
            Settings.Default.inter8 = crud.getEmployeeIntersets(selectedRow, "id_Emp").Item8;
            //
            Settings.Default.id_Conn = crud.getEmployeeAcquitance(selectedRow, "id_Emp").Item7;
            Settings.Default.nom1 = crud.getEmployeeAcquitance(selectedRow, "id_Emp").Item1;
            Settings.Default.pren1 = crud.getEmployeeAcquitance(selectedRow, "id_Emp").Item2;
            Settings.Default.fonc1 = crud.getEmployeeAcquitance(selectedRow, "id_Emp").Item3;
            Settings.Default.id_Conn1 = crud.getEmployeeAcquitance(selectedRow, "id_Emp").Item8;
            Settings.Default.nom2 = crud.getEmployeeAcquitance(selectedRow, "id_Emp").Item4;
            Settings.Default.pren2 = crud.getEmployeeAcquitance(selectedRow, "id_Emp").Item5;
            Settings.Default.fonc2 = crud.getEmployeeAcquitance(selectedRow, "id_Emp").Item6;
            //
            Settings.Default.testMed = crud.getEmployeeTests(selectedRow, "id_Emp").Item1;
            Settings.Default.testProf = crud.getEmployeeTests(selectedRow, "id_Emp").Item2;
            //
            Settings.Default.dateCont = crud.getEmployeeContract(selectedRow, "id_Emp").Item1;
            Settings.Default.fonc = crud.getEmployeeContract(selectedRow, "id_Emp").Item2;
            Settings.Default.service = crud.getEmployeeContract(selectedRow, "id_Emp").Item3;
            Settings.Default.dateEngage = crud.getEmployeeContract(selectedRow, "id_Emp").Item4;
            Settings.Default.etatCont = crud.getEmployeeContract(selectedRow, "id_Emp").Item5;
            //
            Settings.Default.salaire = crud.getEmployeeRewards(selectedRow, "id_Emp").Item1;
            Settings.Default.iep = crud.getEmployeeRewards(selectedRow, "id_Emp").Item2;
            Settings.Default.panier = crud.getEmployeeRewards(selectedRow, "id_Emp").Item3;
            Settings.Default.trans = crud.getEmployeeRewards(selectedRow, "id_Emp").Item4;
            Settings.Default.saliss = crud.getEmployeeRewards(selectedRow, "id_Emp").Item5;
            Settings.Default.indemnV = crud.getEmployeeRewards(selectedRow, "id_Emp").Item6;
            Settings.Default.deplace = crud.getEmployeeRewards(selectedRow, "id_Emp").Item7;
            Settings.Default.danger = crud.getEmployeeRewards(selectedRow, "id_Emp").Item8;
            Settings.Default.phone = crud.getEmployeeRewards(selectedRow, "id_Emp").Item9;
            Settings.Default.penibilite = crud.getEmployeeRewards(selectedRow, "id_Emp").Item10;
            Settings.Default.insalub = crud.getEmployeeRewards(selectedRow, "id_Emp").Item11;
            Settings.Default.fidelite = crud.getEmployeeRewards(selectedRow, "id_Emp").Item12;
            Settings.Default.pri = crud.getEmployeeRewards(selectedRow, "id_Emp").Item13;
            Settings.Default.prc = crud.getEmployeeRewards(selectedRow, "id_Emp").Item14;
            Settings.Default.ppi = crud.getEmployeeRewards(selectedRow, "id_Emp").Item15;
            Settings.Default.iq = crud.getEmployeeRewards(selectedRow, "id_Emp").Item16;
            Settings.Default.mission = crud.getEmployeeRewards(selectedRow, "id_Emp").Item17;
            Settings.Default.ifri = crud.getEmployeeRewards(selectedRow, "id_Emp").Item18;
            Settings.Default.autre = crud.getEmployeeRewards(selectedRow, "id_Emp").Item19;
            //
            Settings.Default.periodEssai = crud.getEmployeeEndTrial(selectedRow, "id_Emp").Item1;
            Settings.Default.dateNotifEssai = crud.getEmployeeEndTrial(selectedRow, "id_Emp").Item2;
            Settings.Default.refEssai = crud.getEmployeeEndTrial(selectedRow, "id_Emp").Item3;
            //
            Settings.Default.id_Form = crud.getEmployeeFormation(selectedRow, "id_Emp").Item31;
            Settings.Default.exe1 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item1;
            Settings.Default.the1 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item2;
            Settings.Default.lieuF1 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item3;
            Settings.Default.dure1 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item4;
            Settings.Default.dateF1 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item5;
            Settings.Default.obj1 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item6;
            Settings.Default.id_Form1 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item32;
            Settings.Default.exe2 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item7;
            Settings.Default.the2 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item8;
            Settings.Default.lieuF2 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item9;
            Settings.Default.dure2 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item10;
            Settings.Default.dateF2 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item11;
            Settings.Default.obj2 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item12;
            Settings.Default.id_Form2 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item33;
            Settings.Default.exe3 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item13;
            Settings.Default.the3 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item14;
            Settings.Default.lieuF3 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item15;
            Settings.Default.dure3 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item16;
            Settings.Default.dateF3 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item17;
            Settings.Default.obj3 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item18;
            Settings.Default.id_Form3 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item34;
            Settings.Default.exe4 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item19;
            Settings.Default.the4 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item20;
            Settings.Default.lieuF4 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item21;
            Settings.Default.dure4 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item22;
            Settings.Default.dateF4 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item23;
            Settings.Default.obj4 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item24;
            Settings.Default.id_Form4 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item35;
            Settings.Default.exe5 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item25;
            Settings.Default.the5 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item26;
            Settings.Default.lieuF5 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item27;
            Settings.Default.dure5 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item28;
            Settings.Default.dateF5 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item29;
            Settings.Default.obj5 = crud.getEmployeeFormation(selectedRow, "id_Emp").Item30;
            //
            Settings.Default.id_Desi = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item21;
            Settings.Default.qual1 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item1;
            Settings.Default.natS1 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item2;
            Settings.Default.dateS1 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item3;
            Settings.Default.motif1 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item4;
            Settings.Default.obser1 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item5;
            Settings.Default.id_Desi1 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item22;
            Settings.Default.qual2 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item6;
            Settings.Default.natS2 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item7;
            Settings.Default.dateS2 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item8;
            Settings.Default.motif2 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item9;
            Settings.Default.obser2 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item10;
            Settings.Default.id_Desi2 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item23;
            Settings.Default.qual3 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item11;
            Settings.Default.natS3 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item12;
            Settings.Default.dateS3 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item13;
            Settings.Default.motif3 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item14;
            Settings.Default.obser3 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item15;
            Settings.Default.id_Desi3 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item24;
            Settings.Default.qual4 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item16;
            Settings.Default.natS4 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item17;
            Settings.Default.dateS4 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item18;
            Settings.Default.motif4 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item19;
            Settings.Default.obser4 = crud.getEmployeeDiscipline(selectedRow, "id_Emp").Item20;
            //
            Settings.Default.id_Surve = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item37;
            Settings.Default.etape = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item1;
            Settings.Default.dateSur1 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item2;
            Settings.Default.etapSur1 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item3;
            Settings.Default.tech1 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item4;
            Settings.Default.not1 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item5;
            Settings.Default.rema1 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item6;
            Settings.Default.id_Surve1 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item38;
            Settings.Default.dateSur2 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item7;
            Settings.Default.etapSur2 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item8;
            Settings.Default.tech2 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item9;
            Settings.Default.not2 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item10;
            Settings.Default.rema2 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item11;
            Settings.Default.id_Surve2 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item39;
            Settings.Default.dateSur3 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item12;
            Settings.Default.etapSur3 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item13;
            Settings.Default.tech3 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item14;
            Settings.Default.not3 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item15;
            Settings.Default.rema3 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item16;
            Settings.Default.id_Surve3 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item40;
            Settings.Default.dateSur4 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item17;
            Settings.Default.etapSur4 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item18;
            Settings.Default.tech4 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item19;
            Settings.Default.not4 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item20;
            Settings.Default.rema4 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item21;
            Settings.Default.id_Surve4 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item41;
            Settings.Default.dateSur5 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item22;
            Settings.Default.etapSur5 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item23;
            Settings.Default.tech5 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item24;
            Settings.Default.not5 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item25;
            Settings.Default.rema5 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item26;
            Settings.Default.id_Surve5 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item42;
            Settings.Default.dateSur6 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item27;
            Settings.Default.etapSur6 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item28;
            Settings.Default.tech6 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item29;
            Settings.Default.not6 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item30;
            Settings.Default.rema6 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item31;
            Settings.Default.id_Surve6 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item43;
            Settings.Default.dateSur7 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item32;
            Settings.Default.etapSur7 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item33;
            Settings.Default.tech7 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item34;
            Settings.Default.not7 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item35;
            Settings.Default.rema7 = crud.getEmployeeSurveillance(selectedRow, "id_Emp").Item36;
            //
            Settings.Default.id_Eval = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item22;
            Settings.Default.exer1 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item1;
            Settings.Default.notGlob1 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item2;
            Settings.Default.appr1 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item3;
            Settings.Default.id_Eval1 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item23;
            Settings.Default.exer2 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item4;
            Settings.Default.notGlob2 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item5;
            Settings.Default.appr2 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item6;
            Settings.Default.id_Eval2 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item24;
            Settings.Default.exer3 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item7;
            Settings.Default.notGlob3 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item8;
            Settings.Default.appr3 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item9;
            Settings.Default.id_Eval3 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item25;
            Settings.Default.exer4 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item10;
            Settings.Default.notGlob4 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item11;
            Settings.Default.appr4 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item12;
            Settings.Default.id_Eval4 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item26;
            Settings.Default.exer5 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item13;
            Settings.Default.notGlob5 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item14;
            Settings.Default.appr5 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item15;
            Settings.Default.id_Eval5 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item27;
            Settings.Default.exer6 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item16;
            Settings.Default.notGlob6 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item17;
            Settings.Default.appr6 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item18;
            Settings.Default.id_Eval6 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item28;
            Settings.Default.exer7 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item19;
            Settings.Default.notGlob7 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item20;
            Settings.Default.appr7 = crud.getEmployeeEvaluation(selectedRow, "id_Emp").Item21;
            //
            Settings.Default.id_Ame = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item36;
            Settings.Default.exerc1 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item1;
            Settings.Default.promo1 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item2;
            Settings.Default.reaff1 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item3;
            Settings.Default.form1 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item4;
            Settings.Default.autre1 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item5;
            Settings.Default.id_Ame1 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item37;
            Settings.Default.exerc2 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item6;
            Settings.Default.promo2 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item7;
            Settings.Default.reaff2 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item8;
            Settings.Default.form2 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item9;
            Settings.Default.autre2 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item10;
            Settings.Default.id_Ame2 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item38;
            Settings.Default.exerc3 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item11;
            Settings.Default.promo3 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item12;
            Settings.Default.reaff3 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item13;
            Settings.Default.form3 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item14;
            Settings.Default.autre3 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item15;
            Settings.Default.id_Ame3 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item39;
            Settings.Default.exerc4 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item16;
            Settings.Default.promo4 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item17;
            Settings.Default.reaff4 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item18;
            Settings.Default.form4 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item19;
            Settings.Default.autre4 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item20;
            Settings.Default.id_Ame4 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item40;
            Settings.Default.exerc5 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item21;
            Settings.Default.promo5 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item22;
            Settings.Default.reaff5 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item23;
            Settings.Default.form5 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item24;
            Settings.Default.autre5 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item25;
            Settings.Default.id_Ame5 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item41;
            Settings.Default.exerc6 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item26;
            Settings.Default.promo6 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item27;
            Settings.Default.reaff6 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item28;
            Settings.Default.form6 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item29;
            Settings.Default.autre6 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item30;
            Settings.Default.id_Ame6 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item42;
            Settings.Default.exerc7 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item31;
            Settings.Default.promo7 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item32;
            Settings.Default.reaff7 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item33;
            Settings.Default.form7 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item34;
            Settings.Default.autre7 = crud.getEmployeeEmprove(selectedRow, "id_Emp").Item35;
            //
            Settings.Default.contract = crud.getEmployeeEndContract(selectedRow, "id_Emp").Item1;
            Settings.Default.dateRenouv = crud.getEmployeeEndContract(selectedRow, "id_Emp").Item2;
            Settings.Default.dateNotif = crud.getEmployeeEndContract(selectedRow, "id_Emp").Item3;
            Settings.Default.nRef = crud.getEmployeeEndContract(selectedRow, "id_Emp").Item4;
            //
            Settings.Default.dateDep = crud.getEmployeeDepart(selectedRow, "id_Emp").Item1;
            Settings.Default.categDep = crud.getEmployeeDepart(selectedRow, "id_Emp").Item2;
            Settings.Default.causeDep = crud.getEmployeeDepart(selectedRow, "id_Emp").Item3;
            Settings.Default.othCauseDep = crud.getEmployeeDepart(selectedRow, "id_Emp").Item4;
            
            //Form_Recruit _Recruit = new Form_Recruit();
            UserControl userControl = new UserControl();
            switch (userControl.Name)
            {
                case "UC_CivilState":
                    UC_CivilState c_CivilState = new UC_CivilState();
                    c_CivilState.Load += MyUCLoadHandler;
                    break;
                case "UC_Military":
                    UC_Military c_Military = new UC_Military();
                    c_Military.Load += MyUCLoadHandler;
                    break;
                case "UC_StudyLevel":
                    UC_StudyLevel c_StudyLevel = new UC_StudyLevel();
                    c_StudyLevel.Load += MyUCLoadHandler;
                    break;
                case "UC_ProfStudy":
                    UC_ProfStudy c_ProfStudy = new UC_ProfStudy();
                    c_ProfStudy.Load += MyUCLoadHandler;
                    break;
                case "UC_Trainings":
                    UC_Trainings c_Trainings = new UC_Trainings();
                    c_Trainings.Load += MyUCLoadHandler;
                    break;
                case "UC_Career":
                    UC_Career c_Career = new UC_Career();
                    c_Career.Load += MyUCLoadHandler;
                    break;
                case "UC_Language":
                    UC_Language c_Language = new UC_Language();
                    c_Language.Load += MyUCLoadHandler;
                    break;
                case "UC_Software":
                    UC_Software c_Software = new UC_Software();
                    c_Software.Load += MyUCLoadHandler;
                    break;
                case "UC_Projects":
                    UC_Projects c_Projects = new UC_Projects();
                    c_Projects.Load += MyUCLoadHandler;
                    break;
                case "UC_Intersets":
                    UC_Intersets c_Intersets = new UC_Intersets();
                    c_Intersets.Load += MyUCLoadHandler;
                    break;
                case "UC_DoYouKnow":
                    UC_DoYouKnow c_DoYouKnow = new UC_DoYouKnow();
                    c_DoYouKnow.Load += MyUCLoadHandler;
                    break;
                case "UC_Medecin":
                    UC_Medecin c_Medecin = new UC_Medecin();
                    c_Medecin.Load += MyUCLoadHandler;
                    break;
                case "UC_ContractInfo":
                    UC_ContractInfo c_ContractInfo = new UC_ContractInfo();
                    c_ContractInfo.Load += MyUCLoadHandler;
                    break;
                case "UC_Rewards":
                    UC_Rewards c_Rewards = new UC_Rewards();
                    c_Rewards.Load += MyUCLoadHandler;
                    break;
                case "UC_TrialPeriod":
                    UC_TrialPeriod c_TrialPeriod = new UC_TrialPeriod();
                    c_TrialPeriod.Load += MyUCLoadHandler;
                    break;
                case "UC_FormationCSC":
                    UC_FormationCSC c_FormationCSC = new UC_FormationCSC();
                    c_FormationCSC.Load += MyUCLoadHandler;
                    break;
                case "UC_Discipline":
                    UC_Discipline c_Discipline = new UC_Discipline();
                    c_Discipline.Load += MyUCLoadHandler;
                    break;
                case "UC_Surveillance":
                    UC_Surveillance c_Surveillance = new UC_Surveillance();
                    c_Surveillance.Load += MyUCLoadHandler;
                    break;
                case "UC_Evaluation":
                    UC_Evaluation c_Evaluation = new UC_Evaluation();
                    c_Evaluation.Load += MyUCLoadHandler;
                    break;
                case "UC_Emprovement":
                    UC_Emprovement c_Emprovement = new UC_Emprovement();
                    c_Emprovement.Load += MyUCLoadHandler;
                    break;
                case "UC_EndContract":
                    UC_EndContract c_EndContract = new UC_EndContract();
                    c_EndContract.Load += MyUCLoadHandler;
                    break;
                case "UC_Leave":
                    UC_Leave c_Leave = new UC_Leave();
                    c_Leave.Load += MyUCLoadHandler;
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            transferData();
            string selectedRow = dgvInfoSh.CurrentRow.Cells["id_Emp"].Value.ToString();
            Form_Recruit _Recruit = new Form_Recruit();
            _Recruit.fileDate.Text = dgvInfoSh.CurrentRow.Cells[10].Value.ToString();
            _Recruit.txtUser.Text = crud.getEmployeeInfo(selectedRow, "id_Emp").Item55;
            _Recruit.btnAdd.Visible = false;
            _Recruit.btnUpdate.Visible = false;
            _Recruit.btnCancel.Visible = false;
            _Recruit.btnPrint.Location = new Point(342, 569);
            _Recruit.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            transferData();
            Form_Recruit recruit = new Form_Recruit();
            recruit.btnAdd.Visible = false;
            recruit.btnPrint.Visible = false;
            recruit.btnUpdate.Location = new Point(281, 569);
            recruit.btnCancel.Location = new Point(403, 569);
            recruit.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
                //txtFileName.Text = dgvInfoSh.CurrentRow.Cells[12].Value.ToString();
                //if (crud.check_Id("T_EmployeInfo", "file_Name", txtFileName.Text) == "Code exists")
                //{
                //    string num = dgvInfoSh.CurrentRow.Cells["id_Emp"].Value.ToString();
                //    crud.openFile(num, "T_EmployeInfo", "id_Emp");

                //}
                //else
                //{
                //    MessageBox.Show("Il n'y a pas de fichier importé");
                //}
           
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //txtFileName.Text = dgvInfoSh.CurrentRow.Cells[12].Value.ToString();
            //if (crud.check_Id("T_EmployeInfo", "file_Name", txtFileName.Text) == "Code exists")
            //{
            //    var confirmResult = MessageBox.Show("Il y a déjà un fichier importé\nVoulez-vous le changer?", "Confirmation", MessageBoxButtons.OKCancel);
            //    if (confirmResult == DialogResult.OK)
            //    {
            //        OpenFileDialog dlg = new OpenFileDialog();
            //        dlg.ShowDialog();
            //        txtFilePath.Text = dlg.FileName;
            //        string num = dgvInfoSh.CurrentRow.Cells["id_Emp"].Value.ToString();
            //        crud.saveFile0(txtFilePath.Text, num, "T_EmployeInfo", "id_Emp");
            //        MessageBox.Show("Fichier importé avec succès");
                    
            //        crud.crudop("insert into T_Journal values ('Importation de fiche de renseignemnt','" + user + "','" + DateTime.Now + "')");

            //    }
            //}
            //else
            //{
            //    OpenFileDialog dlg = new OpenFileDialog();
            //    dlg.ShowDialog();
            //    txtFilePath.Text = dlg.FileName;
            //    string num = dgvInfoSh.CurrentRow.Cells["id_Emp"].Value.ToString();
            //    crud.saveFile0(txtFilePath.Text, num, "T_EmployeInfo", "id_Emp");
            //    MessageBox.Show("Fichier importé avec succès");
                
            //    crud.crudop("insert into T_Journal values ('Importation de fiche de renseignemnt','" + user + "','" + DateTime.Now + "')");

            //}
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            transferData();
            Form_Recruit recruit = new Form_Recruit();
            recruit.btnAdd.Visible = false;
            recruit.btnPrint.Visible = false;
            recruit.btnUpdate.Visible = false;
            recruit.btnCancel.Visible = false;
            
            recruit.Show();
        }
    }
}
