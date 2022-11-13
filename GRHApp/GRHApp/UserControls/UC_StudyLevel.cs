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

namespace GRHApp.UserControls
{
    public partial class UC_StudyLevel : UserControl
    {
        public UC_StudyLevel()
        {
            InitializeComponent();
            txtEtabli1.TextChanged += MyTextClickHandler;
            txtDomain1.TextChanged += MyTextClickHandler;
            txtPeriod.TextChanged += MyTextClickHandler;
            txtDiplome.TextChanged += MyTextClickHandler;
            txtObtention1.TextChanged += MyTextClickHandler;
            txtEtabli2.TextChanged += MyTextClickHandler;
            txtDiplome2.TextChanged += MyTextClickHandler;
            txtPeriod2.TextChanged += MyTextClickHandler;
            txtDiplome2.TextChanged += MyTextClickHandler;
            txtObtention2.TextChanged += MyTextClickHandler;
            txtEtabli3.TextChanged += MyTextClickHandler;
            txtDomain3.TextChanged += MyTextClickHandler;
            txtPeriod3.TextChanged += MyTextClickHandler;
            txtDiplome3.TextChanged += MyTextClickHandler;
            txtObtention3.TextChanged += MyTextClickHandler;
            txtEtabli4.TextChanged += MyTextClickHandler;
            txtDomain4.TextChanged += MyTextClickHandler;
            txtPeriod4.TextChanged += MyTextClickHandler;
            txtDiplome4.TextChanged += MyTextClickHandler;
            txtObtention4.TextChanged += MyTextClickHandler;
        }

        public Delegate Mat2;
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat2.DynamicInvoke(txtEtabli1.Text, txtDomain1.Text, txtPeriod.Text, txtDiplome.Text, txtObtention1.Text, txtEtabli2.Text, txtDomain2.Text, txtPeriod2.Text, txtDiplome2.Text, txtObtention2.Text, txtEtabli3.Text, txtDomain3.Text, txtPeriod3.Text, txtDiplome3.Text, txtObtention3.Text, txtEtabli4.Text, txtDomain4.Text, txtPeriod4.Text, txtDiplome4.Text, txtObtention4.Text);
        }
        private void txtE_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagEtab1":
                    txtEtabli1.TextChanged += MyTextClickHandler;
                    break;
                case "tagSpec1":
                    txtDomain1.TextChanged += MyTextClickHandler;
                    break;
                case "tagPerio1":
                    txtPeriod.TextChanged += MyTextClickHandler;
                    break;
                case "tagDip1":
                    txtDiplome.TextChanged += MyTextClickHandler;
                    break;
                case "tagObt1":
                    txtObtention1.TextChanged += MyTextClickHandler;
                    break;
                case "tagEtab2":
                    txtEtabli2.TextChanged += MyTextClickHandler;
                    break;
                case "tagSpec2":
                    txtDiplome2.TextChanged += MyTextClickHandler;
                    break;
                case "tagPeri2":
                    txtPeriod2.TextChanged += MyTextClickHandler;
                    break;
                case "tagDip2":
                    txtDiplome2.TextChanged += MyTextClickHandler;
                    break;
                case "tagObt2":
                    txtObtention2.TextChanged += MyTextClickHandler;
                    break;
                case "tagEtab3":
                    txtEtabli3.TextChanged += MyTextClickHandler;
                    break;
                case "tagSpec3":
                    txtDomain3.TextChanged += MyTextClickHandler;
                    break;
                case "tagPeri3":
                    txtPeriod3.TextChanged += MyTextClickHandler;
                    break;
                case "tagDip3":
                    txtDiplome3.TextChanged += MyTextClickHandler;
                    break;
                case "tagObt3":
                    txtObtention3.TextChanged += MyTextClickHandler;
                    break;
                case "tagEtab4":
                    txtEtabli4.TextChanged += MyTextClickHandler;
                    break;
                case "tagSpec4":
                    txtDomain4.TextChanged += MyTextClickHandler;
                    break;
                case "tagPeri4":
                    txtPeriod4.TextChanged += MyTextClickHandler;
                    break;
                case "tagDip4":
                    txtDiplome4.TextChanged += MyTextClickHandler;
                    break;
                case "tagObt4":
                    txtObtention4.TextChanged += MyTextClickHandler;
                    break;
            }
        }
        
        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
           
        }
        private void dtpO_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void UC_StudyLevel_Load(object sender, EventArgs e)
        {
            txtEtabli1.Text = Settings.Default.eta1;
            txtDomain1.Text = Settings.Default.spe1;
            txtPeriod.Text = Settings.Default.per1;
            txtDiplome.Text = Settings.Default.dip1;
            txtObtention1.Text = Settings.Default.annObt1;
            txtEtabli2.Text = Settings.Default.eta2;
            txtDomain2.Text = Settings.Default.spe2;
            txtPeriod2.Text = Settings.Default.per2;
            txtDiplome2.Text = Settings.Default.dip2;
            txtObtention2.Text = Settings.Default.annObt2;
            txtEtabli3.Text = Settings.Default.eta3;
            txtDomain3.Text = Settings.Default.spe3;
            txtPeriod3.Text = Settings.Default.per3;
            txtDiplome3.Text = Settings.Default.dip3;
            txtObtention3.Text = Settings.Default.annObt3;
            txtEtabli4.Text = Settings.Default.eta4;
            txtDomain4.Text = Settings.Default.spe4;
            txtPeriod4.Text = Settings.Default.per4;
            txtDiplome4.Text = Settings.Default.dip4;
            txtObtention4.Text = Settings.Default.annObt4;
        }

        private void UC_StudyLevel_Leave(object sender, EventArgs e)
        {
            Settings.Default.eta1 = txtEtabli1.Text;
            Settings.Default.spe1 = txtDomain1.Text;
            Settings.Default.per1 = txtPeriod.Text;
            Settings.Default.dip1 = txtDiplome.Text;
            Settings.Default.annObt1 = txtObtention1.Text;
            Settings.Default.eta2 = txtEtabli2.Text;
            Settings.Default.spe2 = txtDomain2.Text;
            Settings.Default.per2 = txtPeriod2.Text;
            Settings.Default.dip2 = txtDiplome2.Text;
            Settings.Default.annObt2 = txtObtention2.Text;
            Settings.Default.eta3 = txtEtabli3.Text;
            Settings.Default.spe3 = txtDomain3.Text;
            Settings.Default.per3 = txtPeriod3.Text;
            Settings.Default.dip3 = txtDiplome3.Text;
            Settings.Default.annObt3 = txtObtention3.Text;
            Settings.Default.eta4 = txtEtabli4.Text;
            Settings.Default.spe4 = txtDomain4.Text;
            Settings.Default.per4 = txtPeriod4.Text;
            Settings.Default.dip4 = txtDiplome4.Text;
            Settings.Default.annObt4 = txtObtention4.Text;
        }

        private void txtEtabli1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
