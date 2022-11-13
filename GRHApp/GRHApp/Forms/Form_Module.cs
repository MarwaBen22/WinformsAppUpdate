using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRHApp.Classes;
using GRHApp.Properties;

namespace GRHApp.Forms
{
    public partial class Form_Module : Form
    {
        public Form_Module()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();

        string userName = Settings.Default.userName;
        private void btnGRH_Click(object sender, EventArgs e)
        {
            string ChefDAM = crud.getChefStruct("DAM", "nom_Structure").Item1;
            string ChefDG = crud.getChefStruct("DG", "nom_Structure").Item1;
            Dashboard dashboard = new Dashboard();
            if (userName == ChefDG || userName == ChefDAM || userName == "Tebich Amina" || userName == "Farah Wided")
            {
                dashboard.btnDashboard.Visible = true;
            }
            else
            {
                dashboard.btnDashboard.Visible = false;
            }
            dashboard.Show();

            this.Hide();
        }

        private void btnModBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ModQualite _ModQualite = new Form_ModQualite();
            _ModQualite.Show();

            this.Hide();
        }

        private void Form_Module_Load(object sender, EventArgs e)
        {
            if (crud.getAlertInfo(Settings.Default.userName, "alrt_To").Item2 == "En attente")
            {
                //showRecNotif();
            }
            else
            {
                lblGRH.Image = null;
            }
        }
    }
}
