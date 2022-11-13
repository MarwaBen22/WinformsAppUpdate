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
    public partial class UC_Discipline : UserControl
    {
        public UC_Discipline()
        {
            InitializeComponent();
            txtQualif1.TextChanged += MyTextClickHandler;
            txtPunish1.TextChanged += MyTextClickHandler;
            txtMotive1.TextChanged += MyTextClickHandler;
            txtObserv1.TextChanged += MyTextClickHandler;
            txtQualif2.TextChanged += MyTextClickHandler;
            txtPunish2.TextChanged += MyTextClickHandler;
            txtMotive2.TextChanged += MyTextClickHandler;
            txtObserv2.TextChanged += MyTextClickHandler;
            txtQualif3.TextChanged += MyTextClickHandler;
            txtPunish3.TextChanged += MyTextClickHandler;
            txtMotive3.TextChanged += MyTextClickHandler;
            txtObserv3.TextChanged += MyTextClickHandler;
            txtQualif4.TextChanged += MyTextClickHandler;
            txtPunish4.TextChanged += MyTextClickHandler;
            txtMotive4.TextChanged += MyTextClickHandler;
            txtObserv4.TextChanged += MyTextClickHandler;

            dtp1.ValueChanged += MyDateTimeClickHandler;
            dtp1.ValueChanged += MyDateTimeClickHandler;
            dtp3.ValueChanged += MyDateTimeClickHandler;
            dtp4.ValueChanged += MyDateTimeClickHandler;
        }

        public Delegate Mat17;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat17.DynamicInvoke(txtQualif1.Text, txtPunish1.Text, dtp1.Value, txtMotive1.Text, txtObserv1.Text, txtQualif2.Text, txtPunish2.Text, dtp1.Value, txtMotive2.Text, txtObserv2.Text, txtQualif3.Text, txtPunish3.Text, dtp3.Value, txtMotive3.Text, txtObserv3.Text, txtQualif4.Text, txtPunish4.Text, dtp4.Value, txtMotive4.Text, txtObserv4.Text);
        }

        private void txtDiscip_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagQualif1":
                    txtQualif1.TextChanged += MyTextClickHandler;
                    break;
                case "tagSanc1":
                    txtPunish1.TextChanged += MyTextClickHandler;
                    break;
                case "tagMotif1":
                    txtMotive1.TextChanged += MyTextClickHandler;
                    break;
                case "tagObser1":
                    txtObserv1.TextChanged += MyTextClickHandler;
                    break;
                case "tagQuali2":
                    txtQualif2.TextChanged += MyTextClickHandler;
                    break;
                case "tagSanc2":
                    txtPunish2.TextChanged += MyTextClickHandler;
                    break;
                case "tagMotif2":
                    txtMotive2.TextChanged += MyTextClickHandler;
                    break;
                case "tagObser2":
                    txtObserv2.TextChanged += MyTextClickHandler;
                    break;
                case "tagQuali3":
                    txtQualif3.TextChanged += MyTextClickHandler;
                    break;
                case "tagSanc3":
                    txtPunish3.TextChanged += MyTextClickHandler;
                    break;
                case "tagMotif3":
                    txtMotive3.TextChanged += MyTextClickHandler;
                    break;
                case "tagObser3":
                    txtObserv3.TextChanged += MyTextClickHandler;
                    break;
                case "tagQuali4":
                    txtQualif4.TextChanged += MyTextClickHandler;
                    break;
                case "tagSanc4":
                    txtPunish4.TextChanged += MyTextClickHandler;
                    break;
                case "tagMotif4":
                    txtMotive4.TextChanged += MyTextClickHandler;
                    break;
                case "tagObser4":
                    txtObserv4.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
            DateTimePicker ClickedDate = (DateTimePicker)sender;
            Mat17.DynamicInvoke(txtQualif1.Text, txtPunish1.Text, dtp1.Value, txtMotive1.Text, txtObserv1.Text, txtQualif2.Text, txtPunish2.Text, dtp1.Value, txtMotive2.Text, txtObserv2.Text, txtQualif3.Text, txtPunish3.Text, dtp3.Value, txtMotive3.Text, txtObserv3.Text, txtQualif4.Text, txtPunish4.Text, dtp4.Value, txtMotive4.Text, txtObserv4.Text);
        }
        private void dtpD_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            switch (dtp.Tag)
            {
                case "tagSDate1":
                    dtp1.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagSDate2":
                    dtp1.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagSDate3":
                    dtp3.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagSDate4":
                    dtp4.ValueChanged += MyDateTimeClickHandler;
                    break;
            }
        }

        private void UC_Discipline_Load(object sender, EventArgs e)
        {
            txtQualif1.Text = Settings.Default.qual1;
            txtPunish1.Text = Settings.Default.natS1;
            dtp1.Text = Settings.Default.dateS1;
            txtMotive1.Text = Settings.Default.motif1;
            txtObserv1.Text = Settings.Default.obser1;
            txtQualif2.Text = Settings.Default.qual2;
            txtPunish2.Text = Settings.Default.natS2;
            dtp1.Text = Settings.Default.dateS2;
            txtMotive2.Text = Settings.Default.motif2;
            txtObserv2.Text = Settings.Default.obser2;
            txtQualif3.Text = Settings.Default.qual3;
            txtPunish3.Text = Settings.Default.natS3;
            dtp3.Text = Settings.Default.dateS3;
            txtMotive3.Text = Settings.Default.motif3;
            txtObserv3.Text = Settings.Default.obser3;
            txtQualif4.Text = Settings.Default.qual4;
            txtPunish4.Text = Settings.Default.natS4;
            dtp4.Text = Settings.Default.dateS4;
            txtMotive4.Text = Settings.Default.motif4;
            txtObserv4.Text = Settings.Default.obser4;
        }

        private void UC_Discipline_Leave(object sender, EventArgs e)
        {
            Settings.Default.qual1 = txtQualif1.Text;
            Settings.Default.natS1 = txtPunish1.Text;
            Settings.Default.dateS1 = dtp1.Value.ToShortDateString();
            Settings.Default.motif1 = txtMotive1.Text;
            Settings.Default.obser1 = txtObserv1.Text;
            Settings.Default.qual2 = txtQualif2.Text;
            Settings.Default.natS2 = txtPunish2.Text;
            Settings.Default.dateS2 = dtp1.Value.ToShortDateString();
            Settings.Default.motif2 = txtMotive2.Text;
            Settings.Default.obser2 = txtObserv2.Text;
            Settings.Default.qual3 = txtQualif3.Text;
            Settings.Default.natS3 = txtPunish3.Text;
            Settings.Default.dateS3 = dtp3.Value.ToShortDateString();
            Settings.Default.motif3 = txtMotive3.Text;
            Settings.Default.obser3 = txtObserv3.Text;
            Settings.Default.qual4 = txtQualif4.Text;
            Settings.Default.natS4 = txtPunish4.Text;
            Settings.Default.dateS4 = dtp4.Value.ToShortDateString();
            Settings.Default.motif4 = txtMotive4.Text;
            Settings.Default.obser4 = txtObserv4.Text;
        }

        private void txtNote1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Discipline_Load_1(object sender, EventArgs e)
        {

        }
    }
}
