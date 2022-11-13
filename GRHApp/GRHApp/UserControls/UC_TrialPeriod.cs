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
    public partial class UC_TrialPeriod : UserControl
    {
        string choice;
        public UC_TrialPeriod()
        {
            InitializeComponent();
            txtTri.TextChanged += MyTextClickHandler;
            txtRef.TextChanged += MyTextClickHandler;
            dtpNotification.ValueChanged += MyDateTimeClickHandler;
        }

        public Delegate Mat15;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat15.DynamicInvoke(txtTri.Text, dtpNotification.Value, txtRef.Text);
        }

        private void rbConcluant_CheckedChanged(object sender, EventArgs e)
        {
            choice = "Concluant";
            txtTri.Text = choice;
        }

        private void rbPAdd_CheckedChanged(object sender, EventArgs e)
        {
            choice = "prolonger";
            txtTri.Text = choice;
        }

        private void rbPNConcluant_CheckedChanged(object sender, EventArgs e)
        {
            choice = "Non Concluant";
            txtTri.Text = choice;
        }

        private void txtT_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagTri":
                    txtTri.TextChanged += MyTextClickHandler;
                    break;
                case "tagRef":
                    txtRef.TextChanged += MyTextClickHandler;
                    break;
            }
        }
        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
            DateTimePicker ClickedDate = (DateTimePicker)sender;
            Mat15.DynamicInvoke(txtTri.Text, dtpNotification.Value, txtRef.Text);
        }

        private void dtpNotification_MouseDown(object sender, MouseEventArgs e)
        {
            dtpNotification.ValueChanged += MyDateTimeClickHandler;
        }

        private void MyRadioButtonClickHandler(object sender, EventArgs e)
        {
            RadioButton ClickedRadio = (RadioButton)sender;
            Mat15.DynamicInvoke(txtTri.Text, dtpNotification.Value, txtRef.Text);
        }
        private void rbP_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Tag)
            {
                case "tagTriCon":
                    rbConcluant.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagTriExtend":
                    rbPAdd.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagTriNCon":
                    rbPNConcluant.CheckedChanged += MyRadioButtonClickHandler;
                    break;
            }
        }

        private void UC_TrialPeriod_Load(object sender, EventArgs e)
        {
            choice = Settings.Default.periodEssai;
            if (choice == "Concluant")
            {
                rbConcluant.Checked = true;
            }
            else if (choice == "prolonger")
            {
                rbPAdd.Checked = true;
            }
            else if (choice == "Non Concluant")
            {
                rbPNConcluant.Checked = true;
            }
            dtpNotification.Text = Settings.Default.dateNotifEssai;
            txtRef.Text = Settings.Default.refEssai;
        }

        private void UC_TrialPeriod_Leave(object sender, EventArgs e)
        {
            Settings.Default.periodEssai = choice;
            Settings.Default.dateNotifEssai = dtpNotification.Value.ToShortDateString();
            Settings.Default.refEssai = txtRef.Text;
        }
    }
}
