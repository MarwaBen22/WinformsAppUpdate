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
    public partial class UC_ContractInfo : UserControl
    {
        public UC_ContractInfo()
        {
            InitializeComponent();
            txtPost.TextChanged += MyTextClickHandler;
            txtService.TextChanged += MyTextClickHandler;
            dtpContract.ValueChanged += MyDateTimeClickHandler;
            dtpEngage.ValueChanged += MyDateTimeClickHandler;
            combEtat.TextChanged += MyComboClickHandler;
        }

        public Delegate Mat13;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat13.DynamicInvoke(dtpContract.Value, txtPost.Text, txtService.Text, dtpEngage.Value, combEtat.SelectedItem);
        }

        private void txtCon_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagPost":
                    txtPost.TextChanged += MyTextClickHandler;
                    break;
                case "tagService":
                    txtService.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
            DateTimePicker ClickedDate = (DateTimePicker)sender;
            Mat13.DynamicInvoke(dtpContract.Value, txtPost.Text, txtService.Text, dtpEngage.Value, combEtat.SelectedItem);
        }
        private void dtpContract_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            switch (dtp.Tag)
            {
                case "tagContD":
                    dtpContract.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagStartD":
                    dtpEngage.ValueChanged += MyDateTimeClickHandler;
                    break;
            }
        }

        private void UC_ContractInfo_Load(object sender, EventArgs e)
        {
            dtpContract.Text = Settings.Default.dateCont;
            txtPost.Text = Settings.Default.fonc;
            txtService.Text = Settings.Default.service;
            dtpEngage.Text = Settings.Default.dateEngage;
            combEtat.Text = Settings.Default.etatCont;
        }

        private void UC_ContractInfo_Leave(object sender, EventArgs e)
        {
            Settings.Default.dateCont = dtpContract.Value.ToShortDateString();
            Settings.Default.fonc = txtPost.Text;
            Settings.Default.service = txtService.Text;
            Settings.Default.dateEngage = dtpEngage.Value.ToShortDateString();
            Settings.Default.etatCont = combEtat.Text;
        }

        private void MyComboClickHandler(object sender, EventArgs e)
        {
            ComboBox ClickedText = (ComboBox)sender;
            Mat13.DynamicInvoke(dtpContract.Value, txtPost.Text, txtService.Text, dtpEngage.Value, combEtat.SelectedItem);
        }
        private void combEtat_Click(object sender, EventArgs e)
        {
            combEtat.TextChanged += MyComboClickHandler;
        }
    }
}
