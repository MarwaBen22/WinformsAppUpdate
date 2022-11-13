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

namespace GRHApp.UserControls
{
    public partial class UC_RecruitFile : UserControl
    {
        public UC_RecruitFile()
        {
            InitializeComponent();
            string chefStruct = crud.getChefStruct(Settings.Default.userName, "l.name").Item1;
            string ChefDAM = crud.getChefStruct("DAM", "nom_Structure").Item1;
            string ChefDG = crud.getChefStruct("DG", "nom_Structure").Item1;
            if (userName == ChefDG)
            {
                display4();
            }
            else if (userName == ChefDAM && userName != ChefDG)
            {
                display3();
            }
            else if (userName == chefStruct && userName != ChefDAM && userName != ChefDG)
            {
                display1();
            }
            else if (userName == "Tebich Amina" || userName == "Farah Wided")
            {
                display();
            }
            else
            {
                display2();
            }
        }

        crudClass crud = new crudClass();

        public void display4()
        {
            string DG = crud.getChefStruct("DG", "nom_Structure").Item1;
            dgvRecruitRequest.DataSource = crud.get4(DG);
            dgvRecruitRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void display3()
        {
            string ChefDAM = crud.getChefStruct("DAM", "nom_Structure").Item1;
            dgvRecruitRequest.DataSource = crud.get3(ChefDAM);
            dgvRecruitRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void display2()
        {
            dgvRecruitRequest.DataSource = crud.get2(userName);
            dgvRecruitRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void display1()
        {
            string chefStruct = crud.getChefStruct(Settings.Default.userName, "l.name").Item1;
            dgvRecruitRequest.DataSource = crud.get1(chefStruct);
            dgvRecruitRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void display()
        {
            dgvRecruitRequest.DataSource = crud.get00("T_DRecruit");
            dgvRecruitRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        string userName = Settings.Default.userName;
        private void UC_RecruitFile_Load(object sender, EventArgs e)
        {
            try
            {
                cbSearch.SelectedIndex = 2;
                textBox1.Text = Settings.Default.fichRec;
                if (Settings.Default.fichRec == "Consultation")
                {
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_RecruitRequest _RecruitRequest = new Form_RecruitRequest();
            _RecruitRequest.btnPrint.Visible = false;
            _RecruitRequest.btnUpdate.Visible = false;
            _RecruitRequest.btnValidate.Visible = false;
            _RecruitRequest.btnRefuse.Visible = false;
            _RecruitRequest.btnAdd.Location = new Point(265, 511);
            _RecruitRequest.btnCancel.Location = new Point(387, 511);
            _RecruitRequest.btnApprobation.Enabled = false;
            _RecruitRequest.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Text = "Rechercher";
                txtSearch.ReadOnly = true;
                cbSearch.Items.Insert(2, "Recherche par");
                cbSearch.SelectedIndex = 2;

                string chefStruct = crud.getChefStruct(Settings.Default.userName, "l.name").Item1;
                string ChefDAM = crud.getChefStruct("DAM", "nom_Structure").Item1;
                string ChefDG = crud.getChefStruct("DG", "nom_Structure").Item1;
                if (userName == ChefDG)
                {
                    display4();
                }
                else if (userName == ChefDAM && userName != ChefDG)
                {
                    display3();
                }
                else if (userName == chefStruct && userName != ChefDAM && userName != ChefDG)
                {
                    display1();
                }
                else if (userName == "Tebich Amina" || userName == "Farah Wided")
                {
                    display();
                }
                else
                {
                    display2();
                }
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
                string chefStruct = crud.getChefStruct(Settings.Default.userName, "l.name").Item1;
                string ChefDAM = crud.getChefStruct("DAM", "nom_Structure").Item1;
                string ChefDG = crud.getChefStruct("DG", "nom_Structure").Item1;
                if (userName == "Tebich Amina" || userName == "Farah Wided")
                {
                    switch (cbSearch.SelectedIndex)
                    {
                        case 0:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search00("num_ref", txtSearch.Text, "T_DRecruit").Tables[0];
                            }
                            break;

                        case 1:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search00("poste_Travail", txtSearch.Text, "T_DRecruit").Tables[0];
                            }
                            break;


                        default:
                            MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                            break;
                    }
                }
                else if (userName == ChefDG)
                {
                    switch (cbSearch.SelectedIndex)
                    {
                        case 0:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search4("num_ref", txtSearch.Text, "T_DRecruit").Tables[0];
                            }
                            break;

                        case 1:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search4("poste_Travail", txtSearch.Text, "T_DRecruit").Tables[0];
                            }
                            break;


                        default:
                            MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                            break;
                    }
                }
                else if (userName == ChefDAM && userName != ChefDG)
                {
                    switch (cbSearch.SelectedIndex)
                    {
                        case 0:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search3("num_ref", txtSearch.Text, "T_DRecruit").Tables[0];
                            }
                            break;

                        case 1:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search3("poste_Travail", txtSearch.Text, "T_DRecruit").Tables[0];
                            }
                            break;


                        default:
                            MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                            break;
                    }
                }
                else if (userName == chefStruct && userName != ChefDAM && userName != ChefDG)
                {
                    switch (cbSearch.SelectedIndex)
                    {
                        case 0:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search1("num_ref", txtSearch.Text, chefStruct).Tables[0];
                            }
                            break;

                        case 1:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search1("poste_Travail", txtSearch.Text, chefStruct).Tables[0];
                            }
                            break;


                        default:
                            MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                            break;
                    }
                }
                else
                {
                    switch (cbSearch.SelectedIndex)
                    {
                        case 0:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search2("num_ref", txtSearch.Text, userName).Tables[0];
                            }
                            break;

                        case 1:
                            if (txtSearch.Text != "")
                            {
                                dgvRecruitRequest.DataSource = crud.search2("poste_Travail", txtSearch.Text, userName).Tables[0];
                            }
                            break;


                        default:
                            MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                            break;
                    }
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
                    string deleteRow = dgvRecruitRequest.CurrentRow.Cells["num_ref"].Value.ToString();
                    crud.crudop("delete from T_DRecruit where num_ref = '" + deleteRow + "'");

                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Suppresseion de fiche de recrutement','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                }
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string selectedRow = dgvRecruitRequest.CurrentRow.Cells["num_ref"].Value.ToString();

            Form_RecruitRequest _RecruitRequest = new Form_RecruitRequest();
            _RecruitRequest.txtRef.Text = dgvRecruitRequest.CurrentRow.Cells[0].Value.ToString();
            _RecruitRequest.txtPost.Text = dgvRecruitRequest.CurrentRow.Cells[1].Value.ToString();
            _RecruitRequest.txtNumber.Text = dgvRecruitRequest.CurrentRow.Cells[2].Value.ToString();
            _RecruitRequest.txtFormation.Text = dgvRecruitRequest.CurrentRow.Cells[3].Value.ToString();
            _RecruitRequest.txtAge.Text = dgvRecruitRequest.CurrentRow.Cells[4].Value.ToString();
            if (dgvRecruitRequest.CurrentRow.Cells[5].Value.ToString() == "Féminin")
            {
                _RecruitRequest.rbFemale.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[5].Value.ToString() == "Masculin")
            {
                _RecruitRequest.rbMale.Checked = true;
            }
            if (dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString() == "1erChoix")
            {
                _RecruitRequest.rb1Choice.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString() == "2èmeChoix")
            {
                _RecruitRequest.rb2Choice.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString() == "3èmeChoix")
            {
                _RecruitRequest.rb3Choice.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString() == "4èmeChoix")
            {
                _RecruitRequest.rb4Choice.Checked = true;
            }
            else
            {
                _RecruitRequest.txtOther.Text = dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString();
            }
            if (dgvRecruitRequest.CurrentRow.Cells[7].Value.ToString() == "Permanant")
            {
                _RecruitRequest.rbPermanent.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[7].Value.ToString() == "Temporaire")
            {
                _RecruitRequest.rbTemporary.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[7].Value.ToString() == "Temps partiel")
            {
                _RecruitRequest.rbPartTime.Checked = true;
            }
            _RecruitRequest.txtProjects.Text = dgvRecruitRequest.CurrentRow.Cells[8].Value.ToString();
            _RecruitRequest.txtWorkPlace.Text = dgvRecruitRequest.CurrentRow.Cells[9].Value.ToString();
            _RecruitRequest.txtBasicForm.Text = dgvRecruitRequest.CurrentRow.Cells[10].Value.ToString();
            _RecruitRequest.txtExperience.Text = dgvRecruitRequest.CurrentRow.Cells[11].Value.ToString();
            _RecruitRequest.txtLanguages.Text = dgvRecruitRequest.CurrentRow.Cells[12].Value.ToString();
            _RecruitRequest.txtResident.Text = dgvRecruitRequest.CurrentRow.Cells[13].Value.ToString();
            if (dgvRecruitRequest.CurrentRow.Cells[14].Value.ToString() == "OUI")
            {
                _RecruitRequest.rbDriveY.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[14].Value.ToString() == "NON")
            {
                _RecruitRequest.rbDriveN.Checked = true;
            }
            _RecruitRequest.txtAvailable.Text = dgvRecruitRequest.CurrentRow.Cells[15].Value.ToString();
            _RecruitRequest.txtSoftware.Text = dgvRecruitRequest.CurrentRow.Cells[16].Value.ToString();
            _RecruitRequest.txtOthCompt.Text = dgvRecruitRequest.CurrentRow.Cells[17].Value.ToString();
            if (dgvRecruitRequest.CurrentRow.Cells[18].Value.ToString() == "OUI")
            {
                _RecruitRequest.rbOpporY.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[18].Value.ToString() == "NON")
            {
                _RecruitRequest.rbOpporN.Checked = true;
            }
            if (dgvRecruitRequest.CurrentRow.Cells[19].Value.ToString() == "Accord")
            {
                _RecruitRequest.rbAccord.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[19].Value.ToString() == "Differ")
            {
                _RecruitRequest.rbDiffer.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[19].Value.ToString() == "Rejete")
            {
                _RecruitRequest.rbReject.Checked = true;
            }
            _RecruitRequest.fileDate.Text = dgvRecruitRequest.CurrentRow.Cells[20].Value.ToString();
            _RecruitRequest.txtUser.Text = dgvRecruitRequest.CurrentRow.Cells[21].Value.ToString();
            _RecruitRequest.txtCandidat1.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item2;
            _RecruitRequest.txtCandidat2.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item4;
            _RecruitRequest.txtCandidat3.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item6;
            _RecruitRequest.txtCandidat4.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item8;
            _RecruitRequest.txtCandidat5.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item10;
            _RecruitRequest.txtCandidat6.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item12;
            _RecruitRequest.txtCandidat7.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item14;
            _RecruitRequest.txtCandidat8.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item16;
            _RecruitRequest.txtCandidat9.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item18;
            _RecruitRequest.txtCandidat10.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item20;
            _RecruitRequest.txtCandidat11.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item22;
            _RecruitRequest.txtCandidat12.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item24;
            _RecruitRequest.txtCandidat13.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item26;
            _RecruitRequest.txtCandidat14.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item28;
            _RecruitRequest.txtCandidat15.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item30;
            _RecruitRequest.txtCandidat16.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item32;
            _RecruitRequest.txtCandidat17.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item34;
            _RecruitRequest.txtCandidat18.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item36;
            _RecruitRequest.txtCandidat19.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item38;
            _RecruitRequest.txtCandidat20.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item40;
            _RecruitRequest.txtCandidat21.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item42;
            _RecruitRequest.txtCandidat22.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item44;
            _RecruitRequest.txtCandidat23.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item46;
            _RecruitRequest.txtCandidat24.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item48;
            _RecruitRequest.txtCandidat25.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item50;
            _RecruitRequest.txtCandidat26.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item52;
            _RecruitRequest.txtCandidat27.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item54;
            _RecruitRequest.txtCandidat28.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item56;
            _RecruitRequest.txtCandidat29.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item58;
            _RecruitRequest.txtCandidat30.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item60;

            _RecruitRequest.txtCandId.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item1;
            _RecruitRequest.txtCandId1.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item3;
            _RecruitRequest.txtCandId2.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item5;
            _RecruitRequest.txtCandId3.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item7;
            _RecruitRequest.txtCandId4.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item9;
            _RecruitRequest.txtCandId5.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item11;
            _RecruitRequest.txtCandId6.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item13;
            _RecruitRequest.txtCandId7.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item15;
            _RecruitRequest.txtCandId8.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item17;
            _RecruitRequest.txtCandId9.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item19;
            _RecruitRequest.txtCandId10.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item21;
            _RecruitRequest.txtCandId11.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item23;
            _RecruitRequest.txtCandId12.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item25;
            _RecruitRequest.txtCandId13.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item27;
            _RecruitRequest.txtCandId14.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item29;
            _RecruitRequest.txtCandId15.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item31;
            _RecruitRequest.txtCandId16.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item33;
            _RecruitRequest.txtCandId17.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item35;
            _RecruitRequest.txtCandId18.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item37;
            _RecruitRequest.txtCandId19.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item39;
            _RecruitRequest.txtCandId20.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item41;
            _RecruitRequest.txtCandId21.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item43;
            _RecruitRequest.txtCandId22.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item45;
            _RecruitRequest.txtCandId23.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item47;
            _RecruitRequest.txtCandId24.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item49;
            _RecruitRequest.txtCandId25.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item51;
            _RecruitRequest.txtCandId26.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item53;
            _RecruitRequest.txtCandId27.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item55;
            _RecruitRequest.txtCandId28.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item57;
            _RecruitRequest.txtCandId29.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item59;


            _RecruitRequest.txtRCId1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item1;
            _RecruitRequest.txtCandi1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item2;
            _RecruitRequest.txtBForm1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item3;
            _RecruitRequest.txtCForm1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item4;
            _RecruitRequest.txtResid1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item5;
            _RecruitRequest.txtFamSit1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item6;
            _RecruitRequest.txtExp1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item7;
            _RecruitRequest.txtRCId2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item8;
            _RecruitRequest.txtCandi2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item9;
            _RecruitRequest.txtBForm2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item10;
            _RecruitRequest.txtCForm2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item11;
            _RecruitRequest.txtResid2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item12;
            _RecruitRequest.txtFamSit2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item13;
            _RecruitRequest.txtExp2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item14;
            _RecruitRequest.txtRCId3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item15;
            _RecruitRequest.txtCandi3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item16;
            _RecruitRequest.txtBForm3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item17;
            _RecruitRequest.txtCForm3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item18;
            _RecruitRequest.txtResid3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item19;
            _RecruitRequest.txtFamSit3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item20;
            _RecruitRequest.txtExp3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item21;
            _RecruitRequest.txtRCId4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item22;
            _RecruitRequest.txtCandi4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item23;
            _RecruitRequest.txtBForm4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item24;
            _RecruitRequest.txtCForm4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item25;
            _RecruitRequest.txtResid4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item26;
            _RecruitRequest.txtFamSit4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item27;
            _RecruitRequest.txtExp4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item28;
            foreach (var pnl in _RecruitRequest.Controls.OfType<Panel>())
            {
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    txt.ReadOnly = true;

                }
            }
            _RecruitRequest.rbFemale.Enabled = false;
            _RecruitRequest.rbMale.Enabled = false;
            _RecruitRequest.rb1Choice.Enabled = false;
            _RecruitRequest.rb2Choice.Enabled = false;
            _RecruitRequest.rb3Choice.Enabled = false;
            _RecruitRequest.rb4Choice.Enabled = false;
            _RecruitRequest.rbDriveY.Enabled = false;
            _RecruitRequest.rbDriveN.Enabled = false;
            _RecruitRequest.rbOpporY.Enabled = false;
            _RecruitRequest.rbOpporN.Enabled = false;
            _RecruitRequest.rbAccord.Enabled = false;
            _RecruitRequest.rbDiffer.Enabled = false;
            _RecruitRequest.rbReject.Enabled = false;
            _RecruitRequest.btnAdd.Visible = false;
            _RecruitRequest.btnUpdate.Visible = false;
            _RecruitRequest.btnCancel.Visible = false;
            _RecruitRequest.btnRefuse.Visible = false;
            _RecruitRequest.btnValidate.Visible = false;
            _RecruitRequest.btnPrint.Location = new Point(326, 511);
            _RecruitRequest.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedRow = dgvRecruitRequest.CurrentRow.Cells["num_ref"].Value.ToString();

            Form_RecruitRequest _RecruitRequest = new Form_RecruitRequest();
            _RecruitRequest.txtRef.Text = dgvRecruitRequest.CurrentRow.Cells[0].Value.ToString();
            _RecruitRequest.txtPost.Text = dgvRecruitRequest.CurrentRow.Cells[1].Value.ToString();
            _RecruitRequest.txtNumber.Text = dgvRecruitRequest.CurrentRow.Cells[2].Value.ToString();
            _RecruitRequest.txtFormation.Text = dgvRecruitRequest.CurrentRow.Cells[3].Value.ToString();
            _RecruitRequest.txtAge.Text = dgvRecruitRequest.CurrentRow.Cells[4].Value.ToString();
            if (dgvRecruitRequest.CurrentRow.Cells[5].Value.ToString() == "Féminin")
            {
                _RecruitRequest.rbFemale.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[5].Value.ToString() == "Masculin")
            {
                _RecruitRequest.rbMale.Checked = true;
            }
            if (dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString() == "1erChoix")
            {
                _RecruitRequest.rb1Choice.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString() == "2èmeChoix")
            {
                _RecruitRequest.rb2Choice.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString() == "3èmeChoix")
            {
                _RecruitRequest.rb3Choice.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString() == "4èmeChoix")
            {
                _RecruitRequest.rb4Choice.Checked = true;
            }
            else
            {
                _RecruitRequest.txtOther.Text = dgvRecruitRequest.CurrentRow.Cells[6].Value.ToString();
            }
            if (dgvRecruitRequest.CurrentRow.Cells[7].Value.ToString() == "Permanant")
            {
                _RecruitRequest.rbPermanent.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[7].Value.ToString() == "Temporaire")
            {
                _RecruitRequest.rbTemporary.Checked = true;
            }
            else if(dgvRecruitRequest.CurrentRow.Cells[7].Value.ToString() == "Temps partiel")
            {
                _RecruitRequest.rbPartTime.Checked = true;
            }
            _RecruitRequest.txtProjects.Text = dgvRecruitRequest.CurrentRow.Cells[8].Value.ToString();
            _RecruitRequest.txtWorkPlace.Text = dgvRecruitRequest.CurrentRow.Cells[9].Value.ToString();
            _RecruitRequest.txtBasicForm.Text = dgvRecruitRequest.CurrentRow.Cells[10].Value.ToString();
            _RecruitRequest.txtExperience.Text = dgvRecruitRequest.CurrentRow.Cells[11].Value.ToString();
            _RecruitRequest.txtLanguages.Text = dgvRecruitRequest.CurrentRow.Cells[12].Value.ToString();
            _RecruitRequest.txtResident.Text = dgvRecruitRequest.CurrentRow.Cells[13].Value.ToString();
            if (dgvRecruitRequest.CurrentRow.Cells[14].Value.ToString() == "OUI")
            {
                _RecruitRequest.rbDriveY.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[14].Value.ToString() == "NON")
            {
                _RecruitRequest.rbDriveN.Checked = true;
            }
            _RecruitRequest.txtAvailable.Text = dgvRecruitRequest.CurrentRow.Cells[15].Value.ToString();
            _RecruitRequest.txtSoftware.Text = dgvRecruitRequest.CurrentRow.Cells[16].Value.ToString();
            _RecruitRequest.txtOthCompt.Text = dgvRecruitRequest.CurrentRow.Cells[17].Value.ToString();
            if (dgvRecruitRequest.CurrentRow.Cells[18].Value.ToString() == "OUI")
            {
                _RecruitRequest.rbOpporY.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[18].Value.ToString() == "NON")
            {
                _RecruitRequest.rbOpporN.Checked = true;
            }
            if (dgvRecruitRequest.CurrentRow.Cells[19].Value.ToString() == "Accord")
            {
                _RecruitRequest.rbAccord.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[19].Value.ToString() == "Differ")
            {
                _RecruitRequest.rbDiffer.Checked = true;
            }
            else if (dgvRecruitRequest.CurrentRow.Cells[19].Value.ToString() == "Rejete")
            {
                _RecruitRequest.rbReject.Checked = true;
            }
            _RecruitRequest.fileDate.Text = dgvRecruitRequest.CurrentRow.Cells[20].Value.ToString();
            _RecruitRequest.txtUser.Text = dgvRecruitRequest.CurrentRow.Cells[21].Value.ToString();
            _RecruitRequest.txtCandidat1.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item2;
            _RecruitRequest.txtCandidat2.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item4;
            _RecruitRequest.txtCandidat3.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item6;
            _RecruitRequest.txtCandidat4.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item8;
            _RecruitRequest.txtCandidat5.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item10;
            _RecruitRequest.txtCandidat6.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item12;
            _RecruitRequest.txtCandidat7.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item14;
            _RecruitRequest.txtCandidat8.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item16;
            _RecruitRequest.txtCandidat9.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item18;
            _RecruitRequest.txtCandidat10.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item20;
            _RecruitRequest.txtCandId.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item1;
            _RecruitRequest.txtCandId1.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item3;
            _RecruitRequest.txtCandId2.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item5;
            _RecruitRequest.txtCandId3.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item7;
            _RecruitRequest.txtCandId4.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item9;
            _RecruitRequest.txtCandId5.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item11;
            _RecruitRequest.txtCandId6.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item13;
            _RecruitRequest.txtCandId7.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item15;
            _RecruitRequest.txtCandId8.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item17;
            _RecruitRequest.txtCandId9.Text = crud.getRecruitInfo(selectedRow, "num_ref").Item19;
            _RecruitRequest.txtRCId1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item1;
            _RecruitRequest.txtCandi1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item2;
            _RecruitRequest.txtBForm1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item3;
            _RecruitRequest.txtCForm1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item4;
            _RecruitRequest.txtResid1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item5;
            _RecruitRequest.txtFamSit1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item6;
            _RecruitRequest.txtExp1.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item7;
            _RecruitRequest.txtRCId2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item8;
            _RecruitRequest.txtCandi2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item9;
            _RecruitRequest.txtBForm2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item10;
            _RecruitRequest.txtCForm2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item11;
            _RecruitRequest.txtResid2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item12;
            _RecruitRequest.txtFamSit2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item13;
            _RecruitRequest.txtExp2.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item14;
            _RecruitRequest.txtRCId3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item15;
            _RecruitRequest.txtCandi3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item16;
            _RecruitRequest.txtBForm3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item17;
            _RecruitRequest.txtCForm3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item18;
            _RecruitRequest.txtResid3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item19;
            _RecruitRequest.txtFamSit3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item20;
            _RecruitRequest.txtExp3.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item21;
            _RecruitRequest.txtRCId4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item22;
            _RecruitRequest.txtCandi4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item23;
            _RecruitRequest.txtBForm4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item24;
            _RecruitRequest.txtCForm4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item25;
            _RecruitRequest.txtResid4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item26;
            _RecruitRequest.txtFamSit4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item27;
            _RecruitRequest.txtExp4.Text = crud.getRecruitInfo0(selectedRow, "num_ref").Item28;
            _RecruitRequest.txtRef.ReadOnly = true;
           
            _RecruitRequest.btnAdd.Visible = false;
            _RecruitRequest.btnPrint.Visible = false;
            _RecruitRequest.btnRefuse.Visible = false;
            _RecruitRequest.btnValidate.Visible = false;
            _RecruitRequest.btnUpdate.Location = new Point(265, 511);
            _RecruitRequest.btnCancel.Location = new Point(387, 511);
            _RecruitRequest.Show();
        }
    }
}
