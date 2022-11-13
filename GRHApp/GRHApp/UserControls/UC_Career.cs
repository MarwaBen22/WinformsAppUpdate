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
    public partial class UC_Career : UserControl
    {
        public UC_Career()
        {
            InitializeComponent();
            txtEmp1.TextChanged += MyTextClickHandler;
            txtWork1.TextChanged += MyTextClickHandler;
            txtFrom1.TextChanged += MyTextClickHandler;
            txtTo1.TextChanged += MyTextClickHandler;
            txtMotive1.TextChanged += MyTextClickHandler;
            txtEmp2.TextChanged += MyTextClickHandler;
            txtWork2.TextChanged += MyTextClickHandler;
            txtFrom2.TextChanged += MyTextClickHandler;
            txtTo2.TextChanged += MyTextClickHandler;
            txtMotive2.TextChanged += MyTextClickHandler;
            txtEmp3.TextChanged += MyTextClickHandler;
            txtWork3.TextChanged += MyTextClickHandler;
            txtFrom3.TextChanged += MyTextClickHandler;
            txtTo3.TextChanged += MyTextClickHandler;
            txtMotive3.TextChanged += MyTextClickHandler;
            txtEmp4.TextChanged += MyTextClickHandler;
            txtWork4.TextChanged += MyTextClickHandler;
            txtFrom4.TextChanged += MyTextClickHandler;
            txtTo4.TextChanged += MyTextClickHandler;
            txtMotive4.TextChanged += MyTextClickHandler;
        }

        public Delegate Mat5;
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat5.DynamicInvoke(txtEmp1.Text, txtWork1.Text, txtFrom1.Text, txtTo1.Text, txtMotive1.Text, txtEmp2.Text, txtWork2.Text, txtFrom2.Text, txtTo2.Text, txtMotive2.Text, txtEmp3.Text, txtWork3.Text, txtFrom3.Text, txtTo3.Text, txtMotive3.Text, txtEmp4.Text, txtWork4.Text, txtFrom4.Text, txtTo4.Text, txtMotive4.Text);
        }
        private void txtEmp_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagEmp1":
                    txtEmp1.TextChanged += MyTextClickHandler;
                    break;
                case "tagWork1":
                    txtWork1.TextChanged += MyTextClickHandler;
                    break;
                case "tagFrom1":
                    txtFrom1.TextChanged += MyTextClickHandler;
                    break;
                case "tagTo1":
                    txtTo1.TextChanged += MyTextClickHandler;
                    break;
                case "tagMot1":
                    txtMotive1.TextChanged += MyTextClickHandler;
                    break;
                case "tagEmp2":
                    txtEmp2.TextChanged += MyTextClickHandler;
                    break;
                case "tagWork2":
                    txtWork2.TextChanged += MyTextClickHandler;
                    break;
                case "tagFrom2":
                    txtFrom2.TextChanged += MyTextClickHandler;
                    break;
                case "tagTo2":
                    txtTo2.TextChanged += MyTextClickHandler;
                    break;
                case "tagMot2":
                    txtMotive2.TextChanged += MyTextClickHandler;
                    break;
                case "tagEmp3":
                    txtEmp3.TextChanged += MyTextClickHandler;
                    break;
                case "tagWork3":
                    txtWork3.TextChanged += MyTextClickHandler;
                    break;
                case "tagFrom3":
                    txtFrom3.TextChanged += MyTextClickHandler;
                    break;
                case "tagTo3":
                    txtTo3.TextChanged += MyTextClickHandler;
                    break;
                case "tagMot3":
                    txtMotive3.TextChanged += MyTextClickHandler;
                    break;
                case "tagEmp4":
                    txtEmp4.TextChanged += MyTextClickHandler;
                    break;
                case "tagWork4":
                    txtWork4.TextChanged += MyTextClickHandler;
                    break;
                case "tagFrom4":
                    txtFrom4.TextChanged += MyTextClickHandler;
                    break;
                case "tagTo4":
                    txtTo4.TextChanged += MyTextClickHandler;
                    break;
                case "tagMot4":
                    txtMotive4.TextChanged += MyTextClickHandler;
                    break;

            }
        }

        private void dtp_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void UC_Career_Load(object sender, EventArgs e)
        {
            txtEmp1.Text = Settings.Default.emp1;
            txtWork1.Text = Settings.Default.job1;
            txtFrom1.Text = Settings.Default.dateDeb1;
            txtTo1.Text = Settings.Default.dateFin1;
            txtMotive1.Text = Settings.Default.motifDep1;
            txtEmp2.Text = Settings.Default.emp2;
            txtWork2.Text = Settings.Default.job2;
            txtFrom2.Text = Settings.Default.dateDeb2;
            txtTo2.Text = Settings.Default.dateFin2;
            txtMotive2.Text = Settings.Default.motifDep2;
            txtEmp3.Text = Settings.Default.emp3;
            txtWork3.Text = Settings.Default.job3;
            txtFrom3.Text = Settings.Default.dateDeb3;
            txtTo3.Text = Settings.Default.dateFin3;
            txtMotive3.Text = Settings.Default.motifDep3;
            txtEmp4.Text = Settings.Default.emp4;
            txtWork4.Text = Settings.Default.job4;
            txtFrom4.Text = Settings.Default.dateDeb4;
            txtTo4.Text = Settings.Default.dateFin4;
            txtMotive4.Text = Settings.Default.motifDep4;
        }

        private void UC_Career_Leave(object sender, EventArgs e)
        {
            Settings.Default.emp1 = txtEmp1.Text;
            Settings.Default.job1 = txtWork1.Text;
            Settings.Default.dateDeb1 = txtFrom1.Text;
            Settings.Default.dateFin1 = txtTo1.Text;
            Settings.Default.motifDep1 = txtMotive1.Text;
            Settings.Default.emp2 = txtEmp2.Text;
            Settings.Default.job2 = txtWork2.Text;
            Settings.Default.dateDeb2 = txtFrom2.Text;
            Settings.Default.dateFin2 = txtTo2.Text;
            Settings.Default.motifDep2 = txtMotive2.Text;
            Settings.Default.emp3 = txtEmp3.Text;
            Settings.Default.job3 = txtWork3.Text;
            Settings.Default.dateDeb3 = txtFrom3.Text;
            Settings.Default.dateFin3 = txtTo3.Text;
            Settings.Default.motifDep3 = txtMotive3.Text;
            Settings.Default.emp4 = txtEmp4.Text;
            Settings.Default.job4 = txtWork4.Text;
            Settings.Default.dateDeb4 = txtFrom4.Text;
            Settings.Default.dateFin4 = txtTo4.Text;
            Settings.Default.motifDep4 = txtMotive4.Text;
        }
    }
}
