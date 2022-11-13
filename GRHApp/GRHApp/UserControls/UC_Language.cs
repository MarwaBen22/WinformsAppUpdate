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
    public partial class UC_Language : UserControl
    {
        public UC_Language()
        {
            InitializeComponent();
            txtFrench.TextChanged += MyTextClickHandler;
            txtArabic.TextChanged += MyTextClickHandler;
            txtEnglish.TextChanged += MyTextClickHandler;
            txtGerman.TextChanged += MyTextClickHandler;
            txtOtherO.TextChanged += MyTextClickHandler;
        }
        string French;
        string Arabe;
        string English;
        string German;
        string Other;

        private void rbVGFr_CheckedChanged(object sender, EventArgs e)
        {
            French = "T.Bien";
            txtFrench.Text = French;
        }

        private void rbGFr_CheckedChanged(object sender, EventArgs e)
        {
            French = "Bien";
            txtFrench.Text = French;
        }

        private void rbMPFr_CheckedChanged(object sender, EventArgs e)
        {
            French = "Moyen+";
            txtFrench.Text = French;
        }

        private void rbMNFr_CheckedChanged(object sender, EventArgs e)
        {
            French = "Moyen-";
            txtFrench.Text = French;
        }

        private void rbNFr_CheckedChanged(object sender, EventArgs e)
        {
            French = "Néant";
            txtFrench.Text = French;
        }

        private void rbVGAr_CheckedChanged(object sender, EventArgs e)
        {
            Arabe = "T.Bien";
            txtArabic.Text = Arabe;
        }

        private void rbGAr_CheckedChanged(object sender, EventArgs e)
        {
            Arabe = "Bien";
            txtArabic.Text = Arabe;
        }

        private void rbMPAr_CheckedChanged(object sender, EventArgs e)
        {
            Arabe = "Moyen+";
            txtArabic.Text = Arabe;
        }

        private void rbMNAr_CheckedChanged(object sender, EventArgs e)
        {
            Arabe = "Moyen-";
            txtArabic.Text = Arabe;
        }

        private void rbNAr_CheckedChanged(object sender, EventArgs e)
        {
            Arabe = "Néant";
            txtArabic.Text = Arabe;
        }

        private void rbVGEng_CheckedChanged(object sender, EventArgs e)
        {
            English = "T.Bien"; 
            txtEnglish.Text = English;
        }

        private void rbGEng_CheckedChanged(object sender, EventArgs e)
        {
            English = "Bien";
            txtEnglish.Text = English;
        }

        private void rbMPEng_CheckedChanged(object sender, EventArgs e)
        {
            English = "Moyen+";
            txtEnglish.Text = English;
        }

        private void rbMNEng_CheckedChanged(object sender, EventArgs e)
        {
            English = "Moyen-";
            txtEnglish.Text = English;
        }

        private void rbNEng_CheckedChanged(object sender, EventArgs e)
        {
            English = "Néant";
            txtEnglish.Text = English;
        }

        private void rbVGer_CheckedChanged(object sender, EventArgs e)
        {
            German = "T.Bien";
            txtGerman.Text = German;
        }

        private void rbGer_CheckedChanged(object sender, EventArgs e)
        {
            German = "Bien";
            txtGerman.Text = German;
        }

        private void rbMPGer_CheckedChanged(object sender, EventArgs e)
        {
            German = "Moyen+";
            txtGerman.Text = German;
        }

        private void rbMNGer_CheckedChanged(object sender, EventArgs e)
        {
            German = "Moyen-";
            txtGerman.Text = German;
        }

        private void rbNGer_CheckedChanged(object sender, EventArgs e)
        {
            German = "Néant";
            txtGerman.Text = German;
        }

        private void rbVGOth_CheckedChanged(object sender, EventArgs e)
        {
            Other = "T.Bien";
            txtOtherO.Text = Other;
        }

        private void rbGOth_CheckedChanged(object sender, EventArgs e)
        {
            Other = "Bien";
            txtOtherO.Text = Other;
        }

        private void rbMPOth_CheckedChanged(object sender, EventArgs e)
        {
            Other = "Moyen+";
            txtOtherO.Text = Other;
        }

        private void rbMNOth_CheckedChanged(object sender, EventArgs e)
        {
            Other = "Moyen-";
            txtOtherO.Text = Other;
        }

        private void rbNOth_CheckedChanged(object sender, EventArgs e)
        {
            Other = "Néant";
            txtOtherO.Text = Other;
        }

        public Delegate Mat6;
        private void MyRadioButtonClickHandler(object sender, EventArgs e)
        {
            RadioButton ClickedRadio = (RadioButton)sender;
            Mat6.DynamicInvoke(txtFrench.Text, txtArabic.Text, txtEnglish.Text, txtGerman.Text, txtOther.Text, txtOtherO.Text);
        }

        private void rb1_Click(object sender, EventArgs e)
        {
            RadioButton rb1 = (RadioButton)sender;
            switch (rb1.Tag)
            {
                case "tagFrTB":
                    rbVGFr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagFrB":
                    rbGFr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagFrM+":
                    rbMPFr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagFrM-":
                    rbMNFr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagFrN":
                    rbNFr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagArTB":
                    rbVGAr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagArB":
                    rbGAr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagArM+":
                    rbMPAr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagArM-":
                    rbMNAr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagArN":
                    rbNAr.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagEnTB":
                    rbVGEng.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagEnB":
                    rbGEng.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagEnM+":
                    rbMPEng.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagEnM-":
                    rbMNEng.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagEnN":
                    rbNEng.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagGeTB":
                    rbVGer.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagGeB":
                    rbGer.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagGeM+":
                    rbMPGer.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagGeM-":
                    rbMNGer.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagGeN":
                    rbNGer.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagOtTB":
                    rbVGOth.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagOtB":
                    rbGOth.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagOtM+":
                    rbMPOth.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagOtM-":
                    rbMNOth.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagOtN":
                    rbNOth.CheckedChanged += MyRadioButtonClickHandler;
                    break;
            }
        }
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat6.DynamicInvoke(txtFrench.Text, txtArabic.Text, txtEnglish.Text, txtGerman.Text, txtOther.Text, txtOtherO.Text);
        }
        private void txtOther_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagFrTxt":
                    txtFrench.TextChanged += MyTextClickHandler;
                    break;
                case "tagArTxt":
                    txtArabic.TextChanged += MyTextClickHandler;
                    break;
                case "tagEnTxt":
                    txtEnglish.TextChanged += MyTextClickHandler;
                    break;
                case "tagGeTxt":
                    txtGerman.TextChanged += MyTextClickHandler;
                    break;
                case "tagOtTxt":
                    txtOtherO.TextChanged += MyTextClickHandler;
                    break;
                case "tagOther":
                    txtOther.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void txtFrench_Click(object sender, EventArgs e)
        {

        }

        private void UC_Language_Load(object sender, EventArgs e)
        {
            French = Settings.Default.fre;
            if (French == "T.Bien")
            {
                rbVGFr.Checked = true;
            }
            else if (French == "Bien")
            {
                rbGFr.Checked = true;
            }
            else if (French == "Moyen+")
            {
                rbMPFr.Checked = true;
            }
            else if (French == "Moyen-")
            {
                rbMNFr.Checked = true;
            }
            else if (French == "Néant")
            {
                rbNFr.Checked = true;
            }
            Arabe = Settings.Default.ara;
            if (Arabe == "T.Bien")
            {
                rbVGAr.Checked = true;
            }
            else if (Arabe == "Bien")
            {
                rbGAr.Checked = true;
            }
            else if (Arabe == "Moyen+")
            {
                rbMPAr.Checked = true;
            }
            else if (Arabe == "Moyen-")
            {
                rbMNAr.Checked = true;
            }
            else if (Arabe == "Néant")
            {
                rbNAr.Checked = true;
            }
            English = Settings.Default.ang;
            if (English == "T.Bien")
            {
                rbVGEng.Checked = true;
            }
            else if (English == "Bien")
            {
                rbGEng.Checked = true;
            }
            else if (English == "Moyen+")
            {
                rbMPEng.Checked = true;
            }
            else if (English == "Moyen-")
            {
                rbMNEng.Checked = true;
            }
            else if (English == "Néant")
            {
                rbNEng.Checked = true;
            }
            German = Settings.Default.all;
            if (German == "T.Bien")
            {
                rbVGer.Checked = true;
            }
            else if (German == "Bien")
            {
                rbGer.Checked = true;
            }
            else if (German == "Moyen+")
            {
                rbMPGer.Checked = true;
            }
            else if (German == "Moyen-")
            {
                rbMNGer.Checked = true;
            }
            else if (German == "Néant")
            {
                rbNGer.Checked = true;
            }
            Other = Settings.Default.aut;
            if (Other == "T.Bien")
            {
                rbVGOth.Checked = true;
            }
            else if (Other == "Bien")
            {
                rbGOth.Checked = true;
            }
            else if (Other == "Moyen+")
            {
                rbMPOth.Checked = true;
            }
            else if (Other == "Moyen-")
            {
                rbMNOth.Checked = true;
            }
            else if (Other == "Néant")
            {
                rbNOth.Checked = true;
            }
            txtOther.Text = Settings.Default.autLang;
        }

        private void UC_Language_Leave(object sender, EventArgs e)
        {
            Settings.Default.fre = French;
            Settings.Default.ara = Arabe;
            Settings.Default.ang = English;
            Settings.Default.all = German;
            Settings.Default.aut = Other;
            Settings.Default.autLang = txtOther.Text;
        }
    }
}
