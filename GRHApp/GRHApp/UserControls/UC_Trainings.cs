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
    public partial class UC_Trainings : UserControl
    {
        public UC_Trainings()
        {
            InitializeComponent();
            txtEtabli1.TextChanged += MyTextClickHandler;
            txtDomain1.TextChanged += MyTextClickHandler;
            txtPeriod.TextChanged += MyTextClickHandler;
            txtDiplome.TextChanged += MyTextClickHandler;
            txtObtD1.TextChanged += MyTextClickHandler;
            txtEtabli2.TextChanged += MyTextClickHandler;
            txtDiplome2.TextChanged += MyTextClickHandler;
            txtPeriod2.TextChanged += MyTextClickHandler;
            txtDiplome2.TextChanged += MyTextClickHandler;
            txtObtD2.TextChanged += MyTextClickHandler;
            txtEtabli3.TextChanged += MyTextClickHandler;
            txtDomain3.TextChanged += MyTextClickHandler;
            txtPeriod3.TextChanged += MyTextClickHandler;
            txtDiplome3.TextChanged += MyTextClickHandler;
            txtObtD3.TextChanged += MyTextClickHandler;
            txtEtabli4.TextChanged += MyTextClickHandler;
            txtDomain4.TextChanged += MyTextClickHandler;
            txtPeriod4.TextChanged += MyTextClickHandler;
            txtDiplome4.TextChanged += MyTextClickHandler;
            txtObtD4.TextChanged += MyTextClickHandler;
        }

        public Delegate Mat4;
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat4.DynamicInvoke(txtEtabli1.Text, txtDomain1.Text, txtPeriod.Text, txtDiplome.Text, txtObtD1.Text, txtEtabli2.Text, txtDomain2.Text, txtPeriod2.Text, txtDiplome2.Text, txtObtD2.Text, txtEtabli3.Text, txtDomain3.Text, txtPeriod3.Text, txtDiplome3.Text, txtObtD3.Text, txtEtabli4.Text, txtDomain4.Text, txtPeriod4.Text, txtDiplome4.Text, txtObtD4.Text);
        }
        private void txtE2_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagE1":
                    txtEtabli1.TextChanged += MyTextClickHandler;
                    break;
                case "tagS1":
                    txtDomain1.TextChanged += MyTextClickHandler;
                    break;
                case "tagP1":
                    txtPeriod.TextChanged += MyTextClickHandler;
                    break;
                case "tagD1":
                    txtDiplome.TextChanged += MyTextClickHandler;
                    break;
                case "tagO1":
                    txtObtD1.TextChanged += MyTextClickHandler;
                    break;
                case "tagE2":
                    txtEtabli2.TextChanged += MyTextClickHandler;
                    break;
                case "tagS2":
                    txtDiplome2.TextChanged += MyTextClickHandler;
                    break;
                case "tagP2":
                    txtPeriod2.TextChanged += MyTextClickHandler;
                    break;
                case "tagD2":
                    txtDiplome2.TextChanged += MyTextClickHandler;
                    break;
                case "tagO2":
                    txtObtD2.TextChanged += MyTextClickHandler;
                    break;
                case "tagE3":
                    txtEtabli3.TextChanged += MyTextClickHandler;
                    break;
                case "tagS3":
                    txtDomain3.TextChanged += MyTextClickHandler;
                    break;
                case "tagP3":
                    txtPeriod3.TextChanged += MyTextClickHandler;
                    break;
                case "tagD3":
                    txtDiplome3.TextChanged += MyTextClickHandler;
                    break;
                case "tagO3":
                    txtObtD3.TextChanged += MyTextClickHandler;
                    break;
                case "tagE4":
                    txtEtabli4.TextChanged += MyTextClickHandler;
                    break;
                case "tagS4":
                    txtDomain4.TextChanged += MyTextClickHandler;
                    break;
                case "tagP4":
                    txtPeriod4.TextChanged += MyTextClickHandler;
                    break;
                case "tagD4":
                    txtDiplome4.TextChanged += MyTextClickHandler;
                    break;
                case "tagO4":
                    txtObtD4.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void UC_Trainings_Load(object sender, EventArgs e)
        {
            txtEtabli1.Text = Settings.Default.etabl1;
            txtDomain1.Text = Settings.Default.speci1;
            txtPeriod.Text = Settings.Default.perio1;
            txtDiplome.Text = Settings.Default.diplo1;
            txtObtD1.Text = Settings.Default.annObten1;
            txtEtabli2.Text = Settings.Default.etabl2;
            txtDomain2.Text = Settings.Default.speci2;
            txtPeriod2.Text = Settings.Default.perio2;
            txtDiplome2.Text = Settings.Default.diplo2;
            txtObtD2.Text = Settings.Default.annObten2;
            txtEtabli3.Text = Settings.Default.etabl3;
            txtDomain3.Text = Settings.Default.speci3;
            txtPeriod3.Text = Settings.Default.perio3;
            txtDiplome3.Text = Settings.Default.diplo3;
            txtObtD3.Text = Settings.Default.annObten3;
            txtEtabli4.Text = Settings.Default.etabl4;
            txtDomain4.Text = Settings.Default.speci4;
            txtPeriod4.Text = Settings.Default.perio4;
            txtDiplome4.Text = Settings.Default.diplo4;
            txtObtD4.Text = Settings.Default.annObten4;
        }

        private void UC_Trainings_Leave(object sender, EventArgs e)
        {
            Settings.Default.etabl1 = txtEtabli1.Text;
            Settings.Default.speci1 = txtDomain1.Text;
            Settings.Default.perio1 = txtPeriod.Text;
            Settings.Default.diplo1 = txtDiplome.Text;
            Settings.Default.annObten1 = txtObtD1.Text;
            Settings.Default.etabl2 = txtEtabli2.Text;
            Settings.Default.speci2 = txtDomain2.Text;
            Settings.Default.perio2 = txtPeriod2.Text;
            Settings.Default.diplo2 = txtDiplome2.Text;
            Settings.Default.annObten2 = txtObtD2.Text;
            Settings.Default.etabl3 = txtEtabli3.Text;
            Settings.Default.speci3 = txtDomain3.Text;
            Settings.Default.perio3 = txtPeriod3.Text;
            Settings.Default.diplo3 = txtDiplome3.Text;
            Settings.Default.annObten3 = txtObtD3.Text;
            Settings.Default.etabl4 = txtEtabli4.Text;
            Settings.Default.speci4 = txtDomain4.Text;
            Settings.Default.perio4 = txtPeriod4.Text;
            Settings.Default.diplo4 = txtDiplome4.Text;
            Settings.Default.annObten4 = txtObtD4.Text;
        }
    }
}
