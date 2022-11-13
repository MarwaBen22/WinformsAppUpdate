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
using GRHApp.Properties;
using GRHApp.Classes;

namespace GRHApp.Forms
{
    public partial class Form_ModQualite : Form
    {
        public Form_ModQualite()
        {
            InitializeComponent();
            UserControls.UC_QualityDashboard c_QualityDashboard = new UserControls.UC_QualityDashboard();
            AddControlsToPanel(c_QualityDashboard);
        }
        crudClass crud = new crudClass();
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(c);
        }
        private void btnDocDC_Click(object sender, EventArgs e)
        {
            UserControls.UC_Quality c_Quality = new UserControls.UC_Quality();
            AddControlsToPanel(c_Quality);

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

        private void btnModBack_Click(object sender, EventArgs e)
        {
            Form_Module _Module = new Form_Module();
            _Module.Show();

            this.Hide();
        }

        private void btnDocDG_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualityDG c_QualityDG = new UserControls.UC_QualityDG();
            AddControlsToPanel(c_QualityDG);

        }

        private void btnDocAM_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualityAM c_QualityAM = new UserControls.UC_QualityAM();
            AddControlsToPanel(c_QualityAM);
        }

        private void btnDocRH_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualityRH c_QualityRH = new UserControls.UC_QualityRH();
            AddControlsToPanel(c_QualityRH);
        }

        private void btnDocMG_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualityMG c_QualityMG = new UserControls.UC_QualityMG();
            AddControlsToPanel(c_QualityMG);
        }

        private void btnDocCO_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualityCO c_QualityCO = new UserControls.UC_QualityCO();
            AddControlsToPanel(c_QualityCO);
        }

        private void btnDocPR_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualityPR c_QualityPR = new UserControls.UC_QualityPR();
            AddControlsToPanel(c_QualityPR);
        }

        private void btnDocCert_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualityCert c_QualityCert = new UserControls.UC_QualityCert();
            AddControlsToPanel(c_QualityCert);
        }

        private void btnDocHSE_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualiteHSE c_QualiteHSE = new UserControls.UC_QualiteHSE();
            AddControlsToPanel(c_QualiteHSE);
        }

        private void btnDocForm_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualityForm c_QualityForm = new UserControls.UC_QualityForm();
            AddControlsToPanel(c_QualityForm);
        }

        string userName = Settings.Default.userName;
        private void Form_ModQualite_Load(object sender, EventArgs e)
        {
            lblName.Text = Settings.Default.userName;
            if (crud.getUserPerm(userName, "utl") != "Faire tout")
            {
                btnDashboard.Visible = false;
                UserControls.UC_QualityDG c_QualityDG = new UserControls.UC_QualityDG();
                AddControlsToPanel(c_QualityDG);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UserControls.UC_QualityDashboard c_QualityDashboard = new UserControls.UC_QualityDashboard();
            AddControlsToPanel(c_QualityDashboard);
        }
    }
}
