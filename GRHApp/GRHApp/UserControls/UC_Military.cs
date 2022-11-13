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
    public partial class UC_Military : UserControl
    {
        public UC_Military()
        {
            InitializeComponent();
            textBox1.TextChanged += MyTextClickHandler;
            textBox2.TextChanged += MyTextClickHandler;

            dtpImmo.ValueChanged += MyDateTimeClickHandler;
            dtpSursiFrom.ValueChanged += MyDateTimeClickHandler;
            dtpSursiTo.ValueChanged += MyDateTimeClickHandler;
        }

        string Engage;
        string Apte;
        
        private void UC_Military_Load(object sender, EventArgs e)
        {
            string girlName = Settings.Default.nomFille;
            if (girlName != "")
            {
                foreach (var rb in pnlYN0.Controls.OfType<RadioButton>())
                {
                    rb.Enabled = false;
                }
                foreach (var rb1 in pnlYN1.Controls.OfType<RadioButton>())
                {
                    rb1.Enabled = false;
                }
                foreach (var dtp in this.Controls.OfType<DateTimePicker>())
                {
                    dtp.Enabled = false;
                }
            }
            Engage = Settings.Default.degage;
            if (Engage == "OUI")
            {
                rbEngageY.Checked = true;
            }
            else if (Engage == "NON")
            {
                rbEngageN.Checked = true;
            }
            dtpImmo.Text = Settings.Default.dateImmo;
            dtpSursiFrom.Text = Settings.Default.sursiDu;
            dtpSursiTo.Text = Settings.Default.sursiAu;
            Apte = Settings.Default.apteInco;
            if (Apte == "OUI")
            {
                rbAbilityY.Checked = true;
            }
            else if (Apte == "NON")
            {
                rbAbilityN.Checked = true;
            }
        }
        public Delegate Mat1;
        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
            DateTimePicker ClickedDate = (DateTimePicker)sender;
            Mat1.DynamicInvoke(Engage, dtpImmo.Value, dtpSursiFrom.Value, dtpSursiTo.Value, Apte);
        }
        private void dtpM_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePicker dtp1 = (DateTimePicker)sender;
            switch (dtp1.Tag)
            {
                case "tagImmo":
                    dtpImmo.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagSursiF":
                    dtpSursiFrom.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagSursiT":
                    dtpSursiTo.ValueChanged += MyDateTimeClickHandler;
                    break;
            }
        }
        
        private void rbEngageY_CheckedChanged(object sender, EventArgs e)
        {
            Engage = "OUI";
            textBox1.Text = Engage;
        }

        private void rbEngageN_CheckedChanged(object sender, EventArgs e)
        {
            Engage = "NON";
            textBox1.Text = Engage;
        }

        private void rbAbilityY_CheckedChanged(object sender, EventArgs e)
        {
            Apte = "OUI";
            textBox2.Text = Apte;
        }

        private void rbAbilityN_CheckedChanged(object sender, EventArgs e)
        {
            Apte = "NON";
            textBox2.Text = Apte;
        }

        private void MyRadioButtonClickHandler(object sender, EventArgs e)
        {
            RadioButton ClickedRadio = (RadioButton)sender;
            Mat1.DynamicInvoke(textBox1.Text, dtpImmo.Value, dtpSursiFrom.Value, dtpSursiTo.Value, Apte);
        }
        private void rb_Click(object sender, EventArgs e)
        {
            RadioButton rb1 = (RadioButton)sender;
            switch (rb1.Tag)
            {
                case "tagEngY":
                    textBox1.TextChanged += MyTextClickHandler;
                    break;
                case "tagEngN":
                    textBox1.TextChanged += MyTextClickHandler;
                    break;
                //case "tagText":
                //    textBox1.TextChanged += MyRadioButtonClickHandler;
                //    break;
                case "tagAptY":
                    rbAbilityY.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagAptN":
                    rbAbilityN.CheckedChanged += MyRadioButtonClickHandler;
                    break;
            }
        }

        private void rbEngageY_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ChangedText = (TextBox)sender;
            Mat1.DynamicInvoke(textBox1.Text, dtpImmo.Value, dtpSursiFrom.Value, dtpSursiTo.Value, textBox2.Text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagText":
                    textBox1.TextChanged += MyTextClickHandler;
                    break;
                case "tagText2":
                    textBox2.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void pnlYN0_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_Military_Leave(object sender, EventArgs e)
        {
            Settings.Default.degage = Engage;
            Settings.Default.dateImmo = dtpImmo.Value.ToShortDateString();
            Settings.Default.sursiDu = dtpSursiFrom.Value.ToShortDateString();
            Settings.Default.sursiAu = dtpSursiTo.Value.ToShortDateString();
            Settings.Default.apteInco = Apte;
        }
    }
}
