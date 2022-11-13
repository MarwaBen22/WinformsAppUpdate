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
    public partial class UC_Medecin : UserControl
    {
        public UC_Medecin()
        {
            InitializeComponent();
            txtMed.TextChanged += MyTextClickHandler;
            txtProf.TextChanged += MyTextClickHandler;
        }

        string Med = "";
        string Prof = "";

        public Delegate Mat12;


        private void MyRadioButtonClickHandler(object sender, EventArgs e)
        {
            RadioButton ClickedRadio = (RadioButton)sender;
            Mat12.DynamicInvoke(txtMed.Text, txtProf.Text);
        }
        private void rbTest_Click(object sender, EventArgs e)
        {
            RadioButton rb1 = (RadioButton)sender;
            switch (rb1.Tag)
            {
                case "tagMdC":
                    rbMedC.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagMdNC":
                    rbMedNC.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagPfC":
                    rbProC.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagPfNC":
                    rbProNC.CheckedChanged += MyRadioButtonClickHandler;
                    break;
            }
        }

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ChangedText = (TextBox)sender;
            Mat12.DynamicInvoke(txtMed.Text, txtProf.Text);
        }
        private void txtTest_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagMd":
                    txtMed.TextChanged += MyTextClickHandler;
                    break;
                case "tagPf":
                    txtProf.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void rbMedC_CheckedChanged(object sender, EventArgs e)
        {
            Med = "Concluant";
            txtMed.Text = Med;
        }

        private void rbMedNC_CheckedChanged(object sender, EventArgs e)
        {
            Med = "Non Concluant";
            txtMed.Text = Med;
        }

        private void rbProC_CheckedChanged(object sender, EventArgs e)
        {
            Prof = "Concluant";
            txtProf.Text = Prof;
        }

        private void rbProNC_CheckedChanged(object sender, EventArgs e)
        {
            Prof = "Non Concluant";
            txtProf.Text = Prof;
        }

        private void UC_Medecin_Load(object sender, EventArgs e)
        {
            Med = Settings.Default.testMed;
            if (Med == "Concluant")
            {
                rbMedC.Checked = true;
            }
            else if (Med == "Non Concluant")
            {
                rbMedNC.Checked = true;
            }
            Prof = Settings.Default.testProf;
            if (Prof == "Concluant")
            {
                rbProC.Checked = true;
            }
            else if (Prof == "Non Concluant")
            {
                rbProNC.Checked = true;
            }
        }

        private void UC_Medecin_Leave(object sender, EventArgs e)
        {
            Settings.Default.testMed = Med;
            Settings.Default.testProf = Prof;
        }
    }
}
