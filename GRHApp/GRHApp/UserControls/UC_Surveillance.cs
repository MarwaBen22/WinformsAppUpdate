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
    public partial class UC_Surveillance : UserControl
    {
        public UC_Surveillance()
        {
            InitializeComponent();
            txtStepChoice.TextChanged += MyTextClickHandler;
            txtStep1.TextChanged += MyTextClickHandler;
            txtTechnic1.TextChanged += MyTextClickHandler;
            txtMark1.TextChanged += MyTextClickHandler;
            txtNote1.TextChanged += MyTextClickHandler;
            txtStep2.TextChanged += MyTextClickHandler;
            txtTechnic2.TextChanged += MyTextClickHandler;
            txtMark2.TextChanged += MyTextClickHandler;
            txtNote2.TextChanged += MyTextClickHandler;
            txtStep3.TextChanged += MyTextClickHandler;
            txtTechnic3.TextChanged += MyTextClickHandler;
            txtMark3.TextChanged += MyTextClickHandler;
            txtNote3.TextChanged += MyTextClickHandler;
            txtStep4.TextChanged += MyTextClickHandler;
            txtTechnic4.TextChanged += MyTextClickHandler;
            txtMark4.TextChanged += MyTextClickHandler;
            txtNote4.TextChanged += MyTextClickHandler;
            txtStep5.TextChanged += MyTextClickHandler;
            txtTechnic5.TextChanged += MyTextClickHandler;
            txtMark5.TextChanged += MyTextClickHandler;
            txtNote5.TextChanged += MyTextClickHandler;
            txtStep6.TextChanged += MyTextClickHandler;
            txtTechnic6.TextChanged += MyTextClickHandler;
            txtMark6.TextChanged += MyTextClickHandler;
            txtNote6.TextChanged += MyTextClickHandler;
            txtStep7.TextChanged += MyTextClickHandler;
            txtTechnic7.TextChanged += MyTextClickHandler;
            txtMark7.TextChanged += MyTextClickHandler;
            txtNote7.TextChanged += MyTextClickHandler;

            dtp1.ValueChanged += MyDateTimeClickHandler;
            dtp2.ValueChanged += MyDateTimeClickHandler;
            dtp3.ValueChanged += MyDateTimeClickHandler;
            dtp4.ValueChanged += MyDateTimeClickHandler;
            dtp5.ValueChanged += MyDateTimeClickHandler;
            dtp6.ValueChanged += MyDateTimeClickHandler;
            dtp7.ValueChanged += MyDateTimeClickHandler;
        }

        string step;

        public Delegate Mat18;


        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void MyRadioButtonClickHandler(object sender, EventArgs e)
        {
            RadioButton ClickedRadio = (RadioButton)sender;
            Mat18.DynamicInvoke(txtStepChoice.Text, dtp1.Value, txtStep1.Text, txtTechnic1.Text, txtMark1.Text, txtNote1.Text, dtp2.Value, txtStep2.Text, txtTechnic2.Text, txtMark2.Text, txtNote2.Text, dtp3.Value, txtStep3.Text, txtTechnic3.Text, txtMark3.Text, txtNote3.Text, dtp4.Value, txtStep4.Text, txtTechnic4.Text, txtMark4.Text, txtNote4.Text, dtp5.Value, txtStep5.Text, txtTechnic5.Text, txtMark5.Text, txtNote5.Text, dtp6.Value, txtStep6.Text, txtTechnic6.Text, txtMark6.Text, txtNote6.Text, dtp7.Value, txtStep7.Text, txtTechnic7.Text, txtMark7.Text, txtNote7.Text);
        }
        private void rbSurv_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Tag)
            {
                case "tagInit":
                    rbInit.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagFoll1":
                    rbFollow1.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagFoll2":
                    rbFollow2.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagFoll3":
                    rbFollow3.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagNFollo":
                    rbNFollow.CheckedChanged += MyRadioButtonClickHandler;
                    break;
            }
        }

        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
            DateTimePicker ClickedDate = (DateTimePicker)sender;
            Mat18.DynamicInvoke(txtStepChoice.Text, dtp1.Value, txtStep1.Text, txtTechnic1.Text, txtMark1.Text, txtNote1.Text, dtp2.Value, txtStep2.Text, txtTechnic2.Text, txtMark2.Text, txtNote2.Text, dtp3.Value, txtStep3.Text, txtTechnic3.Text, txtMark3.Text, txtNote3.Text, dtp4.Value, txtStep4.Text, txtTechnic4.Text, txtMark4.Text, txtNote4.Text, dtp5.Value, txtStep5.Text, txtTechnic5.Text, txtMark5.Text, txtNote5.Text, dtp6.Value, txtStep6.Text, txtTechnic6.Text, txtMark6.Text, txtNote6.Text, dtp7.Value, txtStep7.Text, txtTechnic7.Text, txtMark7.Text, txtNote7.Text);
        }
        private void dtpSurv_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            switch (dtp.Tag)
            {
                case "tagDate1":
                    dtp1.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagDate2":
                    dtp2.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagDate3":
                    dtp3.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagDate4":
                    dtp4.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagDate5":
                    dtp5.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagDate6":
                    dtp6.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagDate7":
                    dtp7.ValueChanged += MyDateTimeClickHandler;
                    break;
            }
        }

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ChangedText = (TextBox)sender;
            Mat18.DynamicInvoke(txtStepChoice.Text, dtp1.Value, txtStep1.Text, txtTechnic1.Text, txtMark1.Text, txtNote1.Text, dtp2.Value, txtStep2.Text, txtTechnic2.Text, txtMark2.Text, txtNote2.Text, dtp3.Value, txtStep3.Text, txtTechnic3.Text, txtMark3.Text, txtNote3.Text, dtp4.Value, txtStep4.Text, txtTechnic4.Text, txtMark4.Text, txtNote4.Text, dtp5.Value, txtStep5.Text, txtTechnic5.Text, txtMark5.Text, txtNote5.Text, dtp6.Value, txtStep6.Text, txtTechnic6.Text, txtMark6.Text, txtNote6.Text, dtp7.Value, txtStep7.Text, txtTechnic7.Text, txtMark7.Text, txtNote7.Text);
        }
        private void txtS_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagStepChoi":
                    txtStepChoice.TextChanged += MyTextClickHandler;
                    break;
                case "tagStep1":
                    txtStep1.TextChanged += MyTextClickHandler;
                    break;
                case "tagTech1":
                    txtTechnic1.TextChanged += MyTextClickHandler;
                    break;
                case "tagNote1":
                    txtMark1.TextChanged += MyTextClickHandler;
                    break;
                case "tagRemark1":
                    txtNote1.TextChanged += MyTextClickHandler;
                    break;
                case "tagStep2":
                    txtStep2.TextChanged += MyTextClickHandler;
                    break;
                case "tagTech2":
                    txtTechnic2.TextChanged += MyTextClickHandler;
                    break;
                case "tagNote2":
                    txtMark2.TextChanged += MyTextClickHandler;
                    break;
                case "tagRemark2":
                    txtNote2.TextChanged += MyTextClickHandler;
                    break;
                case "tagStep3":
                    txtStep3.TextChanged += MyTextClickHandler;
                    break;
                case "tagTech3":
                    txtTechnic3.TextChanged += MyTextClickHandler;
                    break;
                case "tagNote3":
                    txtMark3.TextChanged += MyTextClickHandler;
                    break;
                case "tagRemark3":
                    txtNote3.TextChanged += MyTextClickHandler;
                    break;
                case "tagStep4":
                    txtStep4.TextChanged += MyTextClickHandler;
                    break;
                case "tagTech4":
                    txtTechnic4.TextChanged += MyTextClickHandler;
                    break;
                case "tagNote4":
                    txtMark4.TextChanged += MyTextClickHandler;
                    break;
                case "tagRemark4":
                    txtNote4.TextChanged += MyTextClickHandler;
                    break;
                case "tagStep5":
                    txtStep5.TextChanged += MyTextClickHandler;
                    break;
                case "tagTech5":
                    txtTechnic5.TextChanged += MyTextClickHandler;
                    break;
                case "tagNote5":
                    txtMark5.TextChanged += MyTextClickHandler;
                    break;
                case "tagRemark5":
                    txtNote5.TextChanged += MyTextClickHandler;
                    break;
                case "tagStep6":
                    txtStep6.TextChanged += MyTextClickHandler;
                    break;
                case "tagTech6":
                    txtTechnic6.TextChanged += MyTextClickHandler;
                    break;
                case "tagNote6":
                    txtMark6.TextChanged += MyTextClickHandler;
                    break;
                case "tagRemark6":
                    txtNote6.TextChanged += MyTextClickHandler;
                    break;
                case "tagStep7":
                    txtStep7.TextChanged += MyTextClickHandler;
                    break;
                case "tagTech7":
                    txtTechnic7.TextChanged += MyTextClickHandler;
                    break;
                case "tagNote7":
                    txtMark7.TextChanged += MyTextClickHandler;
                    break;
                case "tagRemark7":
                    txtNote7.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void rbInit_CheckedChanged(object sender, EventArgs e)
        {
            step = "Initiale";
            txtStepChoice.Text = step;
        }

        private void rbFollow1_CheckedChanged(object sender, EventArgs e)
        {
            step = "suivi 1";
            txtStepChoice.Text = step;
        }

        private void rbFollow2_CheckedChanged(object sender, EventArgs e)
        {
            step = "suivi 2";
            txtStepChoice.Text = step;
        }

        private void rbFollow3_CheckedChanged(object sender, EventArgs e)
        {
            step = "suivi 3";
            txtStepChoice.Text = step;
        }

        private void rbNFollow_CheckedChanged(object sender, EventArgs e)
        {
            step = "non surveillé";
            txtStepChoice.Text = step;
        }

        private void UC_Surveillance_Load(object sender, EventArgs e)
        {
            txtStepChoice.Text = Settings.Default.etape;
            dtp1.Text = Settings.Default.dateSur1;
            txtStep1.Text = Settings.Default.etapSur1;
            txtTechnic1.Text = Settings.Default.tech1;
            txtMark1.Text = Settings.Default.not1;
            txtNote1.Text = Settings.Default.rema1;
            dtp2.Text = Settings.Default.dateSur2;
            txtStep2.Text = Settings.Default.etapSur2;
            txtTechnic2.Text = Settings.Default.tech2;
            txtMark2.Text = Settings.Default.not2;
            txtNote2.Text = Settings.Default.rema2;
            dtp3.Text = Settings.Default.dateSur3;
            txtStep3.Text = Settings.Default.etapSur3;
            txtTechnic3.Text = Settings.Default.tech3;
            txtMark3.Text = Settings.Default.not3;
            txtNote3.Text = Settings.Default.rema3;
            dtp4.Text = Settings.Default.dateSur4;
            txtStep4.Text = Settings.Default.etapSur4;
            txtTechnic4.Text = Settings.Default.tech4;
            txtMark4.Text = Settings.Default.not4;
            txtNote4.Text = Settings.Default.rema4;
            dtp5.Text = Settings.Default.dateSur5;
            txtStep5.Text = Settings.Default.etapSur5;
            txtTechnic5.Text = Settings.Default.tech5;
            txtMark5.Text = Settings.Default.not5;
            txtNote5.Text = Settings.Default.rema5;
            dtp6.Text = Settings.Default.dateSur6;
            txtStep6.Text = Settings.Default.etapSur6;
            txtTechnic6.Text = Settings.Default.tech6;
            txtMark6.Text = Settings.Default.not6;
            txtNote6.Text = Settings.Default.rema6;
            dtp7.Text = Settings.Default.dateSur7;
            txtStep7.Text = Settings.Default.etapSur7;
            txtTechnic7.Text = Settings.Default.tech7;
            txtMark7.Text = Settings.Default.not7;
            txtNote7.Text = Settings.Default.rema7;
        }

        private void UC_Surveillance_Leave(object sender, EventArgs e)
        {
            Settings.Default.etape = txtStepChoice.Text;
            Settings.Default.dateSur1 = dtp1.Value.ToShortDateString();
            Settings.Default.etapSur1 = txtStep1.Text;
            Settings.Default.tech1 = txtTechnic1.Text;
            Settings.Default.not1 = txtMark1.Text;
            Settings.Default.rema1 = txtNote1.Text;
            Settings.Default.dateSur2 = dtp2.Value.ToShortDateString();
            Settings.Default.etapSur2 = txtStep2.Text;
            Settings.Default.tech2 = txtTechnic2.Text;
            Settings.Default.not2 = txtMark2.Text;
            Settings.Default.rema2 = txtNote2.Text;
            Settings.Default.dateSur3 = dtp3.Value.ToShortDateString();
            Settings.Default.etapSur3 = txtStep3.Text;
            Settings.Default.tech3 = txtTechnic3.Text;
            Settings.Default.not3 = txtMark3.Text;
            Settings.Default.rema3 = txtNote3.Text;
            Settings.Default.dateSur4 = dtp4.Value.ToShortDateString();
            Settings.Default.etapSur4 = txtStep4.Text;
            Settings.Default.tech4 = txtTechnic4.Text;
            Settings.Default.not4 = txtMark4.Text;
            Settings.Default.rema4 = txtNote4.Text;
            Settings.Default.dateSur5 = dtp5.Value.ToShortDateString();
            Settings.Default.etapSur5 = txtStep5.Text;
            Settings.Default.tech5 = txtTechnic5.Text;
            Settings.Default.not5 = txtMark5.Text;
            Settings.Default.rema5 = txtNote5.Text;
            Settings.Default.dateSur6 = dtp6.Value.ToShortDateString();
            Settings.Default.etapSur6 = txtStep6.Text;
            Settings.Default.tech6 = txtTechnic6.Text;
            Settings.Default.not6 = txtMark6.Text;
            Settings.Default.rema6 = txtNote6.Text;
            Settings.Default.dateSur7 = dtp7.Value.ToShortDateString();
            Settings.Default.etapSur7 = txtStep7.Text;
            Settings.Default.tech7 = txtTechnic7.Text;
            Settings.Default.not7 = txtMark7.Text;
            Settings.Default.rema7 = txtNote7.Text;
        }
    }
}
