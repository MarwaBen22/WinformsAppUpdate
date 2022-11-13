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
    public partial class UC_Software : UserControl
    {
        public UC_Software()
        {
            InitializeComponent();
            txtFor1.TextChanged += MyTextClickHandler;
            txtLev1.TextChanged += MyTextClickHandler;
            txtFor2.TextChanged += MyTextClickHandler;
            txtLev2.TextChanged += MyTextClickHandler;
            txtFor3.TextChanged += MyTextClickHandler;
            txtLev3.TextChanged += MyTextClickHandler;
            txtFor4.TextChanged += MyTextClickHandler;
            txtLev4.TextChanged += MyTextClickHandler;

            txtSoftware1.TextChanged += MyTextClickHandler;
            txtSoftware2.TextChanged += MyTextClickHandler;
            txtSoftware3.TextChanged += MyTextClickHandler;
            txtSoftware4.TextChanged += MyTextClickHandler;


        }
        string Sof1Form;
        string Sof1Lev;
        string Sof2Form;
        string Sof2Lev;
        string Sof3Form;
        string Sof3Lev;
        string Sof4Form;
        string Sof4Lev;
        private void rbWFS1_CheckedChanged(object sender, EventArgs e)
        {
            Sof1Form = "Avec formation";
            txtFor1.Text = Sof1Form;
        }

        private void rbWoutFS1_CheckedChanged(object sender, EventArgs e)
        {
            Sof1Form = "Sans formation";
            txtFor1.Text = Sof1Form;
        }

        private void rbVGoodS1_CheckedChanged(object sender, EventArgs e)
        {
            Sof1Lev = "T.Bien";
            txtLev1.Text = Sof1Lev;
        }

        private void rbGoodS1_CheckedChanged(object sender, EventArgs e)
        {
            Sof1Lev = "Bien";
            txtLev1.Text = Sof1Lev;
        }

        private void rbMediumS1_CheckedChanged(object sender, EventArgs e)
        {
            Sof1Lev = "Moyen";
            txtLev1.Text = Sof1Lev;
        }

        private void rbInitS1_CheckedChanged(object sender, EventArgs e)
        {
            Sof1Lev = "Initiation";
            txtLev1.Text = Sof1Lev;
        }

        private void rbWFS2_CheckedChanged(object sender, EventArgs e)
        {
            Sof2Form = "Avec formation";
            txtFor2.Text = Sof2Form;
        }

        private void rbWoutFS2_CheckedChanged(object sender, EventArgs e)
        {
            Sof2Form = "Sans formation";
            txtFor2.Text = Sof2Form;
        }

        private void rbVGoodS2_CheckedChanged(object sender, EventArgs e)
        {
            Sof2Lev = "T.Bien";
            txtLev2.Text = Sof2Lev;
        }

        private void rbGoodS2_CheckedChanged(object sender, EventArgs e)
        {
            Sof2Lev = "Bien";
            txtLev2.Text = Sof2Lev;
        }

        private void rbMediumS2_CheckedChanged(object sender, EventArgs e)
        {
            Sof2Lev = "Moyen";
            txtLev2.Text = Sof2Lev;
        }

        private void rbIntS2_CheckedChanged(object sender, EventArgs e)
        {
            Sof2Lev = "Initiation";
            txtLev2.Text = Sof2Lev;
        }

        private void rbWFS3_CheckedChanged(object sender, EventArgs e)
        {
            Sof3Form = "Avec formation";
            txtFor3.Text = Sof3Form;
        }

        private void rbWoutFS3_CheckedChanged(object sender, EventArgs e)
        {
            Sof3Form = "Sans formation";
            txtFor3.Text = Sof3Form;
        }

        private void rbVGoodS3_CheckedChanged(object sender, EventArgs e)
        {
            Sof3Lev = "T.Bien";
            txtLev3.Text = Sof3Lev;
        }

        private void rbGoodS3_CheckedChanged(object sender, EventArgs e)
        {
            Sof3Lev = "Bien";
            txtLev3.Text = Sof3Lev;
        }

        private void rbMediumS3_CheckedChanged(object sender, EventArgs e)
        {
            Sof3Lev = "Moyen";
            txtLev3.Text = Sof3Lev;
        }

        private void rbInitS3_CheckedChanged(object sender, EventArgs e)
        {
            Sof3Lev = "Initiation";
            txtLev3.Text = Sof3Lev;
        }

        private void rbWFS4_CheckedChanged(object sender, EventArgs e)
        {
            Sof4Form = "Avec formation";
            txtFor4.Text = Sof4Form;
        }

        private void rbWoutFS4_CheckedChanged(object sender, EventArgs e)
        {
            Sof4Form = "Sans formation";
            txtFor4.Text = Sof4Form;
        }

        private void rbVGoodS4_CheckedChanged(object sender, EventArgs e)
        {
            Sof4Lev = "T.Bien";
            txtLev4.Text = Sof4Lev;
        }

        private void rbGoodS4_CheckedChanged(object sender, EventArgs e)
        {
            Sof4Lev = "Bien";
            txtLev4.Text = Sof4Lev;
        }

        private void rbMediumS4_CheckedChanged(object sender, EventArgs e)
        {
            Sof4Lev = "Moyen";
            txtLev4.Text = Sof4Lev;
        }

        private void rbInitS4_CheckedChanged(object sender, EventArgs e)
        {
            Sof4Lev = "Initiation";
            txtLev4.Text = Sof4Lev;
        }

        public Delegate Mat7;
        private void MyRadioButtonClickHandler(object sender, EventArgs e)
        {
            RadioButton ClickedRadio = (RadioButton)sender;
            Mat7.DynamicInvoke(txtSoftware1.Text, txtFor1.Text, txtLev1.Text, txtSoftware2.Text, txtFor2.Text, txtLev2.Text, txtSoftware3.Text, txtFor3.Text, txtLev3.Text, txtSoftware4.Text, txtFor4.Text, txtLev4.Text);
        }

        private void rb2_Click(object sender, EventArgs e)
        {
            RadioButton rb2 = (RadioButton)sender;
            switch (rb2.Tag)
            {
                case "tagS1WF":
                    rbWFS1.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS1WtF":
                    rbWoutFS1.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS1VG":
                    rbVGoodS1.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS1G":
                    rbGoodS1.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS1M":
                    rbMediumS1.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS1I":
                    rbInitS1.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS2WF":
                    rbWFS2.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS2WtF":
                    rbWoutFS2.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS2VG":
                    rbVGoodS2.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS2G":
                    rbGoodS2.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS2M":
                    rbMediumS2.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS2I":
                    rbIntS2.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS3WF":
                    rbWFS3.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS3WtF":
                    rbWoutFS3.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS3VG":
                    rbVGoodS3.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS3G":
                    rbGoodS3.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS3M":
                    rbMediumS3.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS3I":
                    rbInitS3.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS4WF":
                    rbWFS4.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS4WoutF":
                    rbWoutFS4.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS4VG":
                    rbVGoodS4.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS4G":
                    rbGoodS4.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS4M":
                    rbMediumS4.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagS4I":
                    rbInitS4.CheckedChanged += MyRadioButtonClickHandler;
                    break;
            }
        }
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat7.DynamicInvoke(txtSoftware1.Text, txtFor1.Text, txtLev1.Text, txtSoftware2.Text, txtFor2.Text, txtLev2.Text, txtSoftware3.Text, txtFor3.Text, txtLev3.Text, txtSoftware4.Text, txtFor4.Text, txtLev4.Text);
        }

        private void txtSoft_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagSof1":
                    txtSoftware1.TextChanged += MyTextClickHandler;
                    break;
                case "tagFor1":
                    txtFor1.TextChanged += MyTextClickHandler;
                    break;
                case "tagLev1":
                    txtLev1.TextChanged += MyTextClickHandler;
                    break;
                case "tagSof2":
                    txtSoftware2.TextChanged += MyTextClickHandler;
                    break;
                case "tagFor2":
                    txtFor2.TextChanged += MyTextClickHandler;
                    break;
                case "tagLev2":
                    txtLev2.TextChanged += MyTextClickHandler;
                    break;
                case "tagSof3":
                    txtSoftware3.TextChanged += MyTextClickHandler;
                    break;
                case "tagFor3":
                    txtFor3.TextChanged += MyTextClickHandler;
                    break;
                case "tagLev3":
                    txtLev3.TextChanged += MyTextClickHandler;
                    break;
                case "tagSof4":
                    txtSoftware4.TextChanged += MyTextClickHandler;
                    break;
                case "tagFor4":
                    txtFor4.TextChanged += MyTextClickHandler;
                    break;
                case "tagLev4":
                    txtLev4.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void UC_Software_Load(object sender, EventArgs e)
        {
            txtSoftware1.Text = Settings.Default.log1;
            Sof1Form = Settings.Default.log1For;
            if (Sof1Form == "Avec formation")
            {
                rbWFS1.Checked = true;
            }
            else if (Sof1Form == "Sans formation")
            {
                rbWoutFS1.Checked = true;
            }
            Sof1Lev = Settings.Default.log1Niv;
            if (Sof1Lev == "T.Bien")
            {
                rbVGoodS1.Checked = true;
            }
            else if (Sof1Lev == "Bien")
            {
                rbGoodS1.Checked = true;
            }
            else if (Sof1Lev == "Moyen")
            {
                rbMediumS1.Checked = true;
            }
            else if (Sof1Lev == "Initiation")
            {
                rbInitS1.Checked = true;
            }
            txtSoftware2.Text = Settings.Default.log2;
            Sof2Form = Settings.Default.log2For;
            if (Sof2Form == "Avec formation")
            {
                rbWFS2.Checked = true;
            }
            else if (Sof2Form == "Sans formation")
            {
                rbWoutFS2.Checked = true;
            }
            Sof2Lev = Settings.Default.log2Niv;
            if (Sof2Lev == "T.Bien")
            {
                rbVGoodS2.Checked = true;
            }
            else if (Sof2Lev == "Bien")
            {
                rbGoodS2.Checked = true;
            }
            else if (Sof2Lev == "Moyen")
            {
                rbMediumS2.Checked = true;
            }
            else if (Sof2Lev == "Initiation")
            {
                rbIntS2.Checked = true;
            }
            txtSoftware3.Text = Settings.Default.log3;
            Sof3Form = Settings.Default.log3For;
            if (Sof3Form == "Avec formation")
            {
                rbWFS3.Checked = true;
            }
            else if (Sof3Form == "Sans formation")
            {
                rbWoutFS3.Checked = true;
            }
            Sof3Lev = Settings.Default.log3Niv;
            if (Sof3Lev == "T.Bien")
            {
                rbVGoodS3.Checked = true;
            }
            else if (Sof3Lev == "Bien")
            {
                rbGoodS3.Checked = true;
            }
            else if (Sof3Lev == "Moyen")
            {
                rbMediumS3.Checked = true;
            }
            else if (Sof3Lev == "Initiation")
            {
                rbInitS3.Checked = true;
            }
            txtSoftware4.Text = Settings.Default.log4;
            Sof4Form = Settings.Default.log4For;
            if (Sof4Form == "Avec formation")
            {
                rbWFS4.Checked = true;
            }
            else if (Sof4Form == "Sans formation")
            {
                rbWoutFS4.Checked = true;
            }
            Sof4Lev = Settings.Default.log4Niv;
            if (Sof4Lev == "T.Bien")
            {
                rbVGoodS4.Checked = true;
            }
            else if (Sof4Lev == "Bien")
            {
                rbGoodS4.Checked = true;
            }
            else if (Sof4Lev == "Moyen")
            {
                rbMediumS4.Checked = true;
            }
            else if (Sof4Lev == "Initiation")
            {
                rbInitS4.Checked = true;
            }
        }

        private void UC_Software_Leave(object sender, EventArgs e)
        {
            Settings.Default.log1 = txtSoftware1.Text;
            Settings.Default.log1For = Sof1Form;
            Settings.Default.log1Niv = Sof1Lev;
            Settings.Default.log2 = txtSoftware2.Text;
            Settings.Default.log2For = Sof2Form;
            Settings.Default.log2Niv = Sof2Lev;
            Settings.Default.log3 = txtSoftware3.Text;
            Settings.Default.log3For = Sof3Form;
            Settings.Default.log3Niv = Sof3Lev;
            Settings.Default.log4 = txtSoftware4.Text;
            Settings.Default.log4For = Sof4Form;
            Settings.Default.log4Niv = Sof4Lev;
        }
    }
}
