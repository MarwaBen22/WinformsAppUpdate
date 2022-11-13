using GRHApp.Properties;
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
using System.IO;

namespace GRHApp.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            
            InitializeComponent();

            hidePanel();
            customDesign();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Voulez-vous sortir de l'application?", "Confirmation", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                Application.Exit();
                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Déconnexion','" + lblName.Text + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
            }
        }

        public void customDesign()
        {
            pnlDashList.Visible = false;
            pnlDocuments.Visible = false;
        }

        public void hidePanel()
        {
            if (pnlDashList.Visible == true)
                pnlDashList.Visible = false;

            if (pnlDocuments.Visible == true)
                pnlDocuments.Visible = false;
        }

        public void hideSubPanel()
        {
            if (pnlDemRec.Visible == true)
                pnlDemRec.Visible = false;
        }
        public void showPanel(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hidePanel();
                subPanel.Visible = true;
            }
            else
            {
                subPanel.Visible = false;
            }
        }

        public void showSubPanel(Panel subSubPanel)
        {
            if (subSubPanel.Visible == false)
            {
                hideSubPanel();
                subSubPanel.Visible = true;
            }
            else
            {
                subSubPanel.Visible = false;
            }
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(c);
        }

        private void btnEmps_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            //showPanel(pnlAbsence);
        }

        private void btnEmpDetails_Click(object sender, EventArgs e)
        {
            UserControls.UC_Employe c_Employe = new UserControls.UC_Employe();
            AddControlsToPanel(c_Employe);

            hidePanel();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            //UserControls.UC_Contract c_Contract = new UserControls.UC_Contract();
            //AddControlsToPanel(c_Contract);

            //hidePanel();
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            UserControls.UC_Attendance c_Attendance = new UserControls.UC_Attendance();
            AddControlsToPanel(c_Attendance);

            hidePanel();
        }

        private void btnWorkAttes_Click(object sender, EventArgs e)
        {
            UserControls.UC_WorkAttes c_WorkAttes = new UserControls.UC_WorkAttes();
            AddControlsToPanel(c_WorkAttes);

            hidePanel();
        }

        //public void showRecNotif()
        //{
        //    notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"Images\4696645_alert_audio_bell_notification_sound_icon.ico"));
        //    notifyIcon1.Text = "Some text goes here.";
        //    notifyIcon1.Visible = true;
        //    notifyIcon1.BalloonTipTitle = "Notification";
        //    notifyIcon1.BalloonTipText = "Fiche de recrutement";
        //    notifyIcon1.ShowBalloonTip(10000);
        //}
        private void btnDocument_Click(object sender, EventArgs e)
        {
            if (crud.getAlertInfo(Settings.Default.userName, "alrt_To").Item2 != "En attente")
            {
                btnRecruitDem.Image = null;
                btnNotifDRec.Image = null;
            }
            
            pnlDemRec.Visible = false;
            showPanel(pnlDocuments);
        }

        private void btnWorkCert_Click(object sender, EventArgs e)
        {
            UserControls.UC_WorkCert c_WorkCert = new UserControls.UC_WorkCert();
            AddControlsToPanel(c_WorkCert);

            hidePanel();
        }

        private void btnHoliday_Click(object sender, EventArgs e)
        {
            UserControls.UC_Conge c_Conge = new UserControls.UC_Conge();
            AddControlsToPanel(c_Conge);

            hidePanel();
        }

        private void btnRecruitingF_Click(object sender, EventArgs e)
        {
            UserControls.UC_InfoSheet c_InfoSheet = new UserControls.UC_InfoSheet();
            AddControlsToPanel(c_InfoSheet);

            hidePanel();
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            UserControls.UC_ActivityJournal c_ActivityJournal = new UserControls.UC_ActivityJournal();
            AddControlsToPanel(c_ActivityJournal);

            hidePanel();
        }

        private void btnRecruitDem_Click(object sender, EventArgs e)
        {
            showSubPanel(pnlDemRec);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserControls.UC_UsersManage c_UsersManage = new UserControls.UC_UsersManage();
            AddControlsToPanel(c_UsersManage);

            hidePanel();
        }

        crudClass crud = new crudClass();
        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblName.Text = Settings.Default.userName;
            //crudClass crud = new crudClass();
            string userName = Settings.Default.userName;
            string ChefDAM = crud.getChefStruct("DAM", "nom_Structure").Item1;
            string ChefDG = crud.getChefStruct("DG", "nom_Structure").Item1;
            //Dashboard dashboard = new Dashboard();
            if (userName == ChefDG || userName == ChefDAM || userName == "Tebich Amina" || userName == "Farah Wided")
            {
                UserControls.UC_DRDashboard c_DRDashboard = new UserControls.UC_DRDashboard();
                AddControlsToPanel(c_DRDashboard);
            }
            if (crud.getUserInfo(Settings.Default.userName, "name").Item1 == "Consultation")
            {
                Settings.Default.fichRec = "Consultation";
                
                //UserControls.UC_RecruitFile _RecruitFile = new UserControls.UC_RecruitFile();
                //_RecruitFile.btnAdd.Enabled = false;
                //_RecruitFile.btnUpdate.Enabled = false;
                //_RecruitFile.btnDelete.Enabled = false;
                //_RecruitFile.btnPrint.Enabled = false;
            }
            else if (crud.getUserInfo(Settings.Default.userName, "name").Item1 == "Non")
            {
                btnRecruitDem.Enabled = false;
            }
            if (crud.getUserInfo(Settings.Default.userName, "name").Item2 == "Consultation")
            {
                Settings.Default.fichRen = "Consultation";

                //UserControls.UC_InfoSheet _InfoSheet = new UserControls.UC_InfoSheet();
                //_InfoSheet.btnAdd.Enabled = false;
                //_InfoSheet.btnUpdate.Enabled = false;
                //_InfoSheet.btnDelete.Enabled = false;
                //_InfoSheet.btnPrint.Enabled = false;
            }
            else if (crud.getUserInfo(Settings.Default.userName, "name").Item2 == "Non")
            {
                btnRecruitingF.Enabled = false;
            }
            if (crud.getUserInfo(Settings.Default.userName, "name").Item3 == "Consultation")
            {
                Settings.Default.attTrav = "Consultation";

                //UserControls.UC_WorkAttes _WorkAttes = new UserControls.UC_WorkAttes();
                //_WorkAttes.btnAdd.Enabled = false;
                //_WorkAttes.btnImport.Enabled = false;
                //_WorkAttes.btnDelete.Enabled = false;
                //_WorkAttes.btnPrint.Enabled = false;
                //_WorkAttes.btnView.Enabled = false;
            }
            else if (crud.getUserInfo(Settings.Default.userName, "name").Item3 == "Non")
            {
                btnWorkAttes.Enabled = false;
            }
            if (crud.getUserInfo(Settings.Default.userName, "name").Item4 == "Consultation")
            {
                Settings.Default.certTrav = "Consultation";

                //UserControls.UC_WorkCert _WorkCert = new UserControls.UC_WorkCert();
                //_WorkCert.btnAdd.Enabled = false;
                //_WorkCert.btnImport.Enabled = false;
                //_WorkCert.btnDelete.Enabled = false;
                //_WorkCert.btnPrint.Enabled = false;
                //_WorkCert.btnView.Enabled = false;
            }
            else if (crud.getUserInfo(Settings.Default.userName, "name").Item4 == "Non")
            {
                btnWorkCert.Enabled = false;
            }
            if (crud.getUserInfo(Settings.Default.userName, "name").Item5 == "Consultation")
            {
                Settings.Default.titCong = "Consultation";

                //UserControls.UC_Conge _Conge = new UserControls.UC_Conge();
                //_Conge.btnAdd.Enabled = false;
                //_Conge.btnImport.Enabled = false;
                //_Conge.btnDelete.Enabled = false;
                //_Conge.btnPrint.Enabled = false;
                //_Conge.btnView.Enabled = false;
            }
            else if (crud.getUserInfo(Settings.Default.userName, "name").Item5 == "Non")
            {
                btnHoliday.Enabled = false;
            }
            if (lblName.Text == "AdminERP")
            {
                btnJournal.Visible = true;
                btnUsers.Visible = true;
                btnDocument.Visible = false;
                btnAlerts.Visible = true;
            }
            else
            {
                btnJournal.Visible = false;
                btnUsers.Visible = false;
                btnDocument.Visible = true;
                btnAlerts.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Voulez-vous déconnecter de l'application?", "Confirmation", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.Show();

                crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Déconnexion','" + lblName.Text + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                this.Hide();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            showPanel(pnlDashList);
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            UserControls.UC_MyAccount c_MyAccount = new UserControls.UC_MyAccount();
            AddControlsToPanel(c_MyAccount);

            hidePanel();
        }

        private void pnlDocuments_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        string userName = Settings.Default.userName;
        private void btnAddDRec_Click(object sender, EventArgs e)
        {
            UserControls.UC_RecruitFile c_RecruitFile = new UserControls.UC_RecruitFile();
            AddControlsToPanel(c_RecruitFile);

            hideSubPanel();
            hidePanel();
        }

        private void btnNotifDRec_Click(object sender, EventArgs e)
        {
            UserControls.UC_NotifFRec c_NotifFRec = new UserControls.UC_NotifFRec();
            AddControlsToPanel(c_NotifFRec);

            hideSubPanel();
            hidePanel();
        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            UserControls.UC_Alerts c_Alerts = new UserControls.UC_Alerts();
            AddControlsToPanel(c_Alerts);

            hidePanel();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashDR_Click(object sender, EventArgs e)
        {
            UserControls.UC_DRDashboard c_DRDashboard = new UserControls.UC_DRDashboard();
            AddControlsToPanel(c_DRDashboard);

            hidePanel();
        }

        private void btnDashAttes_Click(object sender, EventArgs e)
        {
            UserControls.UC_DashboardAttes c_DashboardAttes = new UserControls.UC_DashboardAttes();
            AddControlsToPanel(c_DashboardAttes);

            hidePanel();
        }

        private void btnDashCert_Click(object sender, EventArgs e)
        {
            UserControls.UC_DashboardCert c_DashboardCert = new UserControls.UC_DashboardCert();
            AddControlsToPanel(c_DashboardCert);

            hidePanel();
        }

        private void btnDashCong_Click(object sender, EventArgs e)
        {
            UserControls.UC_DashboardCong c_DashboardCong = new UserControls.UC_DashboardCong();
            AddControlsToPanel(c_DashboardCong);

            hidePanel();
        }

        private void btnDashRenseign_Click(object sender, EventArgs e)
        {
            UserControls.UC_DashboardFicheRenseign c_DashboardFicheRenseign = new UserControls.UC_DashboardFicheRenseign();
            AddControlsToPanel(c_DashboardFicheRenseign);

            hidePanel();
        }

        private void btnModBack_Click(object sender, EventArgs e)
        {
            Form_Module _Module = new Form_Module();
            _Module.Show();

            this.Hide();
        }
    }
}
