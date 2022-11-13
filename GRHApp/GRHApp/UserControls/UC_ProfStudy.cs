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
    public partial class UC_ProfStudy : UserControl
    {
        public UC_ProfStudy()
        {
            InitializeComponent();
            txtEtabli1.TextChanged += MyTextClickHandler;
            txtDomain1.TextChanged += MyTextClickHandler;
            txtPeriod.TextChanged += MyTextClickHandler;
            txtDiplome.TextChanged += MyTextClickHandler;
            txtObtent1.TextChanged += MyTextClickHandler;
            txtEtabli2.TextChanged += MyTextClickHandler;
            txtDiplome2.TextChanged += MyTextClickHandler;
            txtPeriod2.TextChanged += MyTextClickHandler;
            txtDiplome2.TextChanged += MyTextClickHandler;
            txtObtent2.TextChanged += MyTextClickHandler;
            txtEtabli3.TextChanged += MyTextClickHandler;
            txtDomain3.TextChanged += MyTextClickHandler;
            txtPeriod3.TextChanged += MyTextClickHandler;
            txtDiplome3.TextChanged += MyTextClickHandler;
            txtObtent3.TextChanged += MyTextClickHandler;
            txtEtabli4.TextChanged += MyTextClickHandler;
            txtDomain4.TextChanged += MyTextClickHandler;
            txtPeriod4.TextChanged += MyTextClickHandler;
            txtDiplome4.TextChanged += MyTextClickHandler;
            txtObtent4.TextChanged += MyTextClickHandler;
        }

        public Delegate Mat3;
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat3.DynamicInvoke(txtEtabli1.Text, txtDomain1.Text, txtPeriod.Text, txtDiplome.Text, txtObtent1.Text, txtEtabli2.Text, txtDomain2.Text, txtPeriod2.Text, txtDiplome2.Text, txtObtent2.Text, txtEtabli3.Text, txtDomain3.Text, txtPeriod3.Text, txtDiplome3.Text, txtObtent3.Text, txtEtabli4.Text, txtDomain4.Text, txtPeriod4.Text, txtDiplome4.Text, txtObtent4.Text);
        }

        private void txtE2_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagEta1":
                    txtEtabli1.TextChanged += MyTextClickHandler;
                    break;
                case "tagSp1":
                    txtDomain1.TextChanged += MyTextClickHandler;
                    break;
                case "tagPer1":
                    txtPeriod.TextChanged += MyTextClickHandler;
                    break;
                case "tagDipl1":
                    txtDiplome.TextChanged += MyTextClickHandler;
                    break;
                case "tagObten1":
                    txtObtent1.TextChanged += MyTextClickHandler;
                    break;
                case "tagEta2":
                    txtEtabli2.TextChanged += MyTextClickHandler;
                    break;
                case "tagSP2":
                    txtDiplome2.TextChanged += MyTextClickHandler;
                    break;
                case "tagPer2":
                    txtPeriod2.TextChanged += MyTextClickHandler;
                    break;
                case "tagDipl2":
                    txtDiplome2.TextChanged += MyTextClickHandler;
                    break;
                case "tagObten2":
                    txtObtent2.TextChanged += MyTextClickHandler;
                    break;
                case "tagEat3":
                    txtEtabli3.TextChanged += MyTextClickHandler;
                    break;
                case "tagSP3":
                    txtDomain3.TextChanged += MyTextClickHandler;
                    break;
                case "tagPer3":
                    txtPeriod3.TextChanged += MyTextClickHandler;
                    break;
                case "tagDipl3":
                    txtDiplome3.TextChanged += MyTextClickHandler;
                    break;
                case "tagObten3":
                    txtObtent3.TextChanged += MyTextClickHandler;
                    break;
                case "tagEta4":
                    txtEtabli4.TextChanged += MyTextClickHandler;
                    break;
                case "tagSP4":
                    txtDomain4.TextChanged += MyTextClickHandler;
                    break;
                case "tagPer4":
                    txtPeriod4.TextChanged += MyTextClickHandler;
                    break;
                case "tagDipl4":
                    txtDiplome4.TextChanged += MyTextClickHandler;
                    break;
                case "tagObten4":
                    txtObtent4.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void UC_ProfStudy_Load(object sender, EventArgs e)
        {
            txtEtabli1.Text = Settings.Default.etab1;
            txtDomain1.Text = Settings.Default.spec1;
            txtPeriod.Text = Settings.Default.peri1;
            txtDiplome.Text = Settings.Default.dipl1;
            txtObtent1.Text = Settings.Default.annObte1;
            txtEtabli2.Text = Settings.Default.etab2;
            txtDomain2.Text = Settings.Default.spec2;
            txtPeriod2.Text = Settings.Default.peri2;
            txtDiplome2.Text = Settings.Default.dipl2;
            txtObtent2.Text = Settings.Default.annObte2;
            txtEtabli3.Text = Settings.Default.etab3;
            txtDomain3.Text = Settings.Default.spec3;
            txtPeriod3.Text = Settings.Default.peri3;
            txtDiplome3.Text = Settings.Default.dipl3;
            txtObtent3.Text = Settings.Default.annObte3;
            txtEtabli4.Text = Settings.Default.etab4;
            txtDomain4.Text = Settings.Default.spec4;
            txtPeriod4.Text = Settings.Default.peri4;
            txtDiplome4.Text = Settings.Default.dipl4;
            txtObtent4.Text = Settings.Default.annObte4;
        }

        private void UC_ProfStudy_Leave(object sender, EventArgs e)
        {
            Settings.Default.etab1 = txtEtabli1.Text;
            Settings.Default.spec1 = txtDomain1.Text;
            Settings.Default.peri1 = txtPeriod.Text;
            Settings.Default.dipl1 = txtDiplome.Text;
            Settings.Default.annObte1 = txtObtent1.Text;
            Settings.Default.etab2 = txtEtabli2.Text;
            Settings.Default.spec2 = txtDomain2.Text;
            Settings.Default.peri2 = txtPeriod2.Text;
            Settings.Default.dipl2 = txtDiplome2.Text;
            Settings.Default.annObte2 = txtObtent2.Text;
            Settings.Default.etab3 = txtEtabli3.Text;
            Settings.Default.spec3 = txtDomain3.Text;
            Settings.Default.peri3 = txtPeriod3.Text;
            Settings.Default.dipl3 = txtDiplome3.Text;
            Settings.Default.annObte3 = txtObtent3.Text;
            Settings.Default.etab4 = txtEtabli4.Text;
            Settings.Default.spec4 = txtDomain4.Text;
            Settings.Default.peri4 = txtPeriod4.Text;
            Settings.Default.dipl4 = txtDiplome4.Text;
            Settings.Default.annObte4 = txtObtent4.Text;
        }
    }
}
