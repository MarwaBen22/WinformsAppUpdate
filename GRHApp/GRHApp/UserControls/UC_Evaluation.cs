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
    public partial class UC_Evaluation : UserControl
    {
        public UC_Evaluation()
        {
            InitializeComponent();
            txtExer1.TextChanged += MyTextClickHandler;
            txtNote1.TextChanged += MyTextClickHandler;
            txtAppr1.TextChanged += MyTextClickHandler;
            txtExer2.TextChanged += MyTextClickHandler;
            txtNote2.TextChanged += MyTextClickHandler;
            txtAppr2.TextChanged += MyTextClickHandler;
            txtExer3.TextChanged += MyTextClickHandler;
            txtNote3.TextChanged += MyTextClickHandler;
            txtAppr3.TextChanged += MyTextClickHandler;
            txtExer4.TextChanged += MyTextClickHandler;
            txtNote4.TextChanged += MyTextClickHandler;
            txtAppr4.TextChanged += MyTextClickHandler;
            txtExer5.TextChanged += MyTextClickHandler;
            txtNote5.TextChanged += MyTextClickHandler;
            txtAppr5.TextChanged += MyTextClickHandler;
            txtExer6.TextChanged += MyTextClickHandler;
            txtNote6.TextChanged += MyTextClickHandler;
            txtAppr6.TextChanged += MyTextClickHandler;
            txtExer7.TextChanged += MyTextClickHandler;
            txtNote7.TextChanged += MyTextClickHandler;
            txtAppr7.TextChanged += MyTextClickHandler;
        }

        public Delegate Mat19;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat19.DynamicInvoke(txtExer1.Text, txtNote1.Text, txtAppr1.Text, txtExer2.Text, txtNote2.Text, txtAppr2.Text, txtExer3.Text, txtNote3.Text, txtAppr3.Text, txtExer4.Text, txtNote4.Text, txtAppr4.Text, txtExer5.Text, txtNote5.Text, txtAppr5.Text, txtExer6.Text, txtNote6.Text, txtAppr6.Text, txtExer7.Text, txtNote7.Text, txtAppr7.Text);
        }
        private void txtEva_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagExe1":
                    txtExer1.TextChanged += MyTextClickHandler;
                    break;
                case "tagGNote1":
                    txtNote1.TextChanged += MyTextClickHandler;
                    break;
                case "tagApp1":
                    txtAppr1.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe2":
                    txtExer2.TextChanged += MyTextClickHandler;
                    break;
                case "tagGNote2":
                    txtNote2.TextChanged += MyTextClickHandler;
                    break;
                case "tagApp2":
                    txtAppr2.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe3":
                    txtExer3.TextChanged += MyTextClickHandler;
                    break;
                case "tagGNote3":
                    txtNote3.TextChanged += MyTextClickHandler;
                    break;
                case "tagApp3":
                    txtAppr3.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe4":
                    txtExer4.TextChanged += MyTextClickHandler;
                    break;
                case "tagGNote4":
                    txtNote4.TextChanged += MyTextClickHandler;
                    break;
                case "tagApp4":
                    txtAppr4.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe5":
                    txtExer5.TextChanged += MyTextClickHandler;
                    break;
                case "tagGNote5":
                    txtNote5.TextChanged += MyTextClickHandler;
                    break;
                case "tagApp5":
                    txtAppr5.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe6":
                    txtExer6.TextChanged += MyTextClickHandler;
                    break;
                case "tagGNote6":
                    txtNote6.TextChanged += MyTextClickHandler;
                    break;
                case "tagApp6":
                    txtAppr6.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe7":
                    txtExer7.TextChanged += MyTextClickHandler;
                    break;
                case "tagGNote7":
                    txtNote7.TextChanged += MyTextClickHandler;
                    break;
                case "tagApp7":
                    txtAppr7.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void UC_Evaluation_Load(object sender, EventArgs e)
        {
            txtExer1.Text = Settings.Default.exer1;
            txtNote1.Text = Settings.Default.notGlob1;
            txtAppr1.Text = Settings.Default.appr1;
            txtExer2.Text = Settings.Default.exer2;
            txtNote2.Text = Settings.Default.notGlob2;
            txtAppr2.Text = Settings.Default.appr2;
            txtExer3.Text = Settings.Default.exer3;
            txtNote3.Text = Settings.Default.notGlob3;
            txtAppr3.Text = Settings.Default.appr3;
            txtExer4.Text = Settings.Default.exer4;
            txtNote4.Text = Settings.Default.notGlob4;
            txtAppr4.Text = Settings.Default.appr4;
            txtExer5.Text = Settings.Default.exer5;
            txtNote5.Text = Settings.Default.notGlob5;
            txtAppr5.Text = Settings.Default.appr5;
            txtExer6.Text = Settings.Default.exer6;
            txtNote6.Text = Settings.Default.notGlob6;
            txtAppr6.Text = Settings.Default.appr6;
            txtExer7.Text = Settings.Default.exer7;
            txtNote7.Text = Settings.Default.notGlob7;
            txtAppr7.Text = Settings.Default.appr7;
        }

        private void UC_Evaluation_Leave(object sender, EventArgs e)
        {
            Settings.Default.exer1 = txtExer1.Text;
            Settings.Default.notGlob1 = txtNote1.Text;
            Settings.Default.appr1 = txtAppr1.Text;
            Settings.Default.exer3 = txtExer2.Text;
            Settings.Default.notGlob3 = txtNote2.Text;
            Settings.Default.appr3 = txtAppr2.Text;
            Settings.Default.exer4 = txtExer4.Text;
            Settings.Default.notGlob4 = txtNote4.Text;
            Settings.Default.appr4 = txtAppr4.Text;
            Settings.Default.exer5 = txtExer5.Text;
            Settings.Default.notGlob5 = txtNote5.Text;
            Settings.Default.appr5 = txtAppr5.Text;
            Settings.Default.exer6 = txtExer6.Text;
            Settings.Default.notGlob6 = txtNote6.Text;
            Settings.Default.appr6 = txtAppr6.Text;
            Settings.Default.exer7 = txtExer7.Text;
            Settings.Default.notGlob7 = txtNote7.Text;
            Settings.Default.appr7 = txtAppr7.Text;
        }
    }
}
