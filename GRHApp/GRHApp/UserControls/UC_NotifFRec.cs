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
    public partial class UC_NotifFRec : UserControl
    {
        public UC_NotifFRec()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        string userName = Settings.Default.userName;
        public void display()
        {
            dgvNotifFRec.DataSource = crud.getAlertsPers("c.num_ref", "T_DRecruit", userName);
            dgvNotifFRec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string currentRow = dgvNotifFRec.CurrentRow.Cells["num_ref"].Value.ToString();
            string currentAlrtId = dgvNotifFRec.CurrentRow.Cells["id_Alert"].Value.ToString();
            if (crud.getAlertInfo(currentRow, "num_ref").Item3 == "Demande refusée")
            {
                crud.crudop("delete from T_Alerts where id_Alert='" + currentAlrtId + "'");
                string comment = crud.getDRecInfo(currentRow, "num_ref").Item14;

                MessageBox.Show(comment);
            }
            else
            {
                Form_RecruitRequest recruitRequest = new Form_RecruitRequest();
                recruitRequest.txtIdAlrt.Text = dgvNotifFRec.CurrentRow.Cells[0].Value.ToString();
                recruitRequest.txtRef.Text = dgvNotifFRec.CurrentRow.Cells[4].Value.ToString();
                recruitRequest.txtPost.Text = crud.getDRecInfo(currentRow, "num_ref").Item1;
                recruitRequest.txtNumber.Text = crud.getDRecInfo(currentRow, "num_ref").Item2;
                recruitRequest.txtFormation.Text = crud.getDRecInfo(currentRow, "num_ref").Item3;
                recruitRequest.txtAge.Text = crud.getDRecInfo(currentRow, "num_ref").Item4;
                if (crud.getDRecInfo(currentRow, "num_ref").Item5 == "Féminin")
                {
                    recruitRequest.rbFemale.Checked = true;
                }
                else if (crud.getDRecInfo(currentRow, "num_ref").Item5 == "Masculin")
                {
                    recruitRequest.rbMale.Checked = true;
                }
                if (crud.getDRecInfo(currentRow, "num_ref").Item6 == "1erChoix")
                {
                    recruitRequest.rb1Choice.Checked = true;
                }
                else if (crud.getDRecInfo(currentRow, "num_ref").Item6 == "2èmeChoix")
                {
                    recruitRequest.rb2Choice.Checked = true;
                }
                else if (crud.getDRecInfo(currentRow, "num_ref").Item6 == "3èmeChoix")
                {
                    recruitRequest.rb3Choice.Checked = true;
                }
                else if (crud.getDRecInfo(currentRow, "num_ref").Item6 == "4èmeChoix")
                {
                    recruitRequest.rb4Choice.Checked = true;
                }
                else
                {
                    recruitRequest.txtOther.Text = crud.getDRecInfo(currentRow, "num_ref").Item6;
                }
                recruitRequest.txtBasicForm.Text = crud.getDRecInfo(currentRow, "num_ref").Item7;
                recruitRequest.txtExperience.Text = crud.getDRecInfo(currentRow, "num_ref").Item8;
                recruitRequest.txtResident.Text = crud.getDRecInfo(currentRow, "num_ref").Item9;
                if (crud.getDRecInfo(currentRow, "num_ref").Item10 == "OUI")
                {
                    recruitRequest.rbDriveY.Checked = true;
                }
                else if (crud.getDRecInfo(currentRow, "num_ref").Item10 == "NON")
                {
                    recruitRequest.rbDriveN.Checked = true;
                }
                recruitRequest.txtAvailable.Text = crud.getDRecInfo(currentRow, "num_ref").Item11;
                if (crud.getDRecInfo(currentRow, "num_ref").Item12 == "OUI")
                {
                    recruitRequest.rbOpporY.Checked = true;
                }
                else if (crud.getDRecInfo(currentRow, "num_ref").Item12 == "NON")
                {
                    recruitRequest.rbOpporN.Checked = true;
                }
                if (crud.getDRecInfo(currentRow, "num_ref").Item13 == "Accord")
                {
                    recruitRequest.rbAccord.Checked = true;
                }
                else if (crud.getDRecInfo(currentRow, "num_ref").Item13 == "Differ")
                {
                    recruitRequest.rbDiffer.Checked = true;
                }
                else if (crud.getDRecInfo(currentRow, "num_ref").Item13 == "Rejete")
                {
                    recruitRequest.rbReject.Checked = true;
                }
                recruitRequest.fileDate.Text = dgvNotifFRec.CurrentRow.Cells[14].Value.ToString();
                recruitRequest.txtUser.Text = dgvNotifFRec.CurrentRow.Cells[15].Value.ToString();
                recruitRequest.txtCandidat1.Text = crud.getRecruitInfo(currentRow, "num_ref").Item2;
                recruitRequest.txtCandidat2.Text = crud.getRecruitInfo(currentRow, "num_ref").Item4;
                recruitRequest.txtCandidat3.Text = crud.getRecruitInfo(currentRow, "num_ref").Item6;
                recruitRequest.txtCandidat4.Text = crud.getRecruitInfo(currentRow, "num_ref").Item8;
                recruitRequest.txtCandidat5.Text = crud.getRecruitInfo(currentRow, "num_ref").Item10;
                recruitRequest.txtCandidat6.Text = crud.getRecruitInfo(currentRow, "num_ref").Item12;
                recruitRequest.txtCandidat7.Text = crud.getRecruitInfo(currentRow, "num_ref").Item14;
                recruitRequest.txtCandidat8.Text = crud.getRecruitInfo(currentRow, "num_ref").Item16;
                recruitRequest.txtCandidat9.Text = crud.getRecruitInfo(currentRow, "num_ref").Item18;
                recruitRequest.txtCandidat10.Text = crud.getRecruitInfo(currentRow, "num_ref").Item20;
                recruitRequest.txtCandId.Text = crud.getRecruitInfo(currentRow, "num_ref").Item1;
                recruitRequest.txtCandId1.Text = crud.getRecruitInfo(currentRow, "num_ref").Item3;
                recruitRequest.txtCandId2.Text = crud.getRecruitInfo(currentRow, "num_ref").Item5;
                recruitRequest.txtCandId3.Text = crud.getRecruitInfo(currentRow, "num_ref").Item7;
                recruitRequest.txtCandId4.Text = crud.getRecruitInfo(currentRow, "num_ref").Item9;
                recruitRequest.txtCandId5.Text = crud.getRecruitInfo(currentRow, "num_ref").Item11;
                recruitRequest.txtCandId6.Text = crud.getRecruitInfo(currentRow, "num_ref").Item13;
                recruitRequest.txtCandId7.Text = crud.getRecruitInfo(currentRow, "num_ref").Item15;
                recruitRequest.txtCandId8.Text = crud.getRecruitInfo(currentRow, "num_ref").Item17;
                recruitRequest.txtCandId9.Text = crud.getRecruitInfo(currentRow, "num_ref").Item19;
                recruitRequest.txtRCId1.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item1;
                recruitRequest.txtCandi1.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item2;
                recruitRequest.txtBForm1.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item3;
                recruitRequest.txtCForm1.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item4;
                recruitRequest.txtResid1.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item5;
                recruitRequest.txtFamSit1.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item6;
                recruitRequest.txtExp1.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item7;
                recruitRequest.txtRCId2.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item8;
                recruitRequest.txtCandi2.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item9;
                recruitRequest.txtBForm2.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item10;
                recruitRequest.txtCForm2.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item11;
                recruitRequest.txtResid2.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item12;
                recruitRequest.txtFamSit2.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item13;
                recruitRequest.txtExp2.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item14;
                recruitRequest.txtRCId3.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item15;
                recruitRequest.txtCandi3.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item16;
                recruitRequest.txtBForm3.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item17;
                recruitRequest.txtCForm3.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item18;
                recruitRequest.txtResid3.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item19;
                recruitRequest.txtFamSit3.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item20;
                recruitRequest.txtExp3.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item21;
                recruitRequest.txtRCId4.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item22;
                recruitRequest.txtCandi4.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item23;
                recruitRequest.txtBForm4.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item24;
                recruitRequest.txtCForm4.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item25;
                recruitRequest.txtResid4.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item26;
                recruitRequest.txtFamSit4.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item27;
                recruitRequest.txtExp4.Text = crud.getRecruitInfo0(currentRow, "num_ref").Item28;
                recruitRequest.btnPrint.Visible = false;
                recruitRequest.btnAdd.Visible = false;
                recruitRequest.btnUpdate.Visible = false;
                recruitRequest.btnCancel.Visible = false;
                recruitRequest.btnValidate.Location = new Point(265, 511);
                recruitRequest.btnRefuse.Location = new Point(387, 511);
                if (userName != "DG")
                {
                    recruitRequest.btnApprobation.Enabled = false;
                    foreach (var pnl in recruitRequest.Controls.OfType<Panel>())
                    {
                        foreach (var txt in pnl.Controls.OfType<TextBox>())
                        {
                            txt.ReadOnly = true;
                        }
                    }
                    foreach (var pnl in recruitRequest.Controls.OfType<Panel>())
                    {
                        foreach (var rb in pnl.Controls.OfType<RadioButton>())
                        {
                            rb.Enabled = false;
                        }
                    }
                }
                else
                {
                    recruitRequest.btnApprobation.Enabled = true;
                    foreach (var pnl in recruitRequest.Controls.OfType<Panel>())
                    {
                        foreach (var txt in pnl.Controls.OfType<TextBox>())
                        {
                            txt.ReadOnly = true;
                        }
                    }
                    foreach (var pnl in recruitRequest.Controls.OfType<Panel>())
                    {
                        foreach (var rb in pnl.Controls.OfType<RadioButton>())
                        {
                            rb.Enabled = false;
                        }
                    }
                    recruitRequest.rbAccord.Enabled = true;
                    recruitRequest.rbDiffer.Enabled = true;
                    recruitRequest.rbReject.Enabled = true;
                }
                if (userName == "Tebich Amina" || userName == "Farah Wided")
                {
                    recruitRequest.btnValidate.Text = "  Imprimer";
                    recruitRequest.btnRefuse.Visible = false;
                    recruitRequest.btnValidate.Location = new Point(325, 511);
                }
                recruitRequest.Show();
            }

        }
    }
}
