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
    public partial class UC_EndContract : UserControl
    {
        public UC_EndContract()
        {
            InitializeComponent();
            txtContract.TextChanged += MyTextClickHandler;
            txtRef.TextChanged += MyTextClickHandler;
            dtpRenewCon.ValueChanged += MyDateTimeClickHandler;
            dtpNotification.ValueChanged += MyDateTimeClickHandler;
        }

        string contract;

        public Delegate Mat21;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat21.DynamicInvoke(txtContract.Text, dtpRenewCon.Value, dtpNotification.Value, txtRef.Text);
        }

        private void rbConcluant_CheckedChanged(object sender, EventArgs e)
        {
            contract = "concluant";
            txtContract.Text = contract;
        }

        private void rbNConcluant_CheckedChanged(object sender, EventArgs e)
        {
            contract = "non concluant";
            txtContract.Text = contract;
        }

        private void txtCon_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagContract":
                    txtContract.TextChanged += MyTextClickHandler;
                    break;
                case "tagRef":
                    txtRef.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
            DateTimePicker ClickedDate = (DateTimePicker)sender;
            Mat21.DynamicInvoke(txtContract.Text, dtpRenewCon.Value, dtpNotification.Value, txtRef.Text);
        }
        private void dtpCon_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            switch (dtp.Tag)
            {
                case "tagRenewDate":
                    dtpRenewCon.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagNotifDate":
                    dtpNotification.ValueChanged += MyDateTimeClickHandler;
                    break;
            }
        }

        private void UC_EndContract_Leave(object sender, EventArgs e)
        {
            Settings.Default.contract = contract;
            Settings.Default.dateRenouv = dtpRenewCon.Value.ToShortDateString();
            Settings.Default.dateNotif = dtpNotification.Value.ToShortDateString();
            Settings.Default.nRef = txtRef.Text;
        }

        private void UC_EndContract_Load(object sender, EventArgs e)
        {
            contract = Settings.Default.contract;
            if (contract == "concluant")
            {
                rbConcluant.Checked = true;
            }
            else if (contract == "non concluant")
            {
                rbNConcluant.Checked = true;
            }
            dtpRenewCon.Text = Settings.Default.dateRenouv;
            dtpNotification.Text = Settings.Default.dateNotif;
            txtRef.Text = Settings.Default.nRef;
        }
    }
}
