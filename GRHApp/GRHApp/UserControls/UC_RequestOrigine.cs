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
    public partial class UC_RequestOrigine : UserControl
    {
        public UC_RequestOrigine()
        {
            InitializeComponent();
            txtChoice.TextChanged += MyTextClickHandler;
            txtOther.TextChanged += MyTextClickHandler;
        }

        string choice;

        private void rb1Choice_CheckedChanged(object sender, EventArgs e)
        {
            choice = "1stChoice";
            txtChoice.Text = choice;
        }

        private void rb2Choice_CheckedChanged(object sender, EventArgs e)
        {
            choice = "2ndChoice";
            txtChoice.Text = choice;
        }

        private void rb3Choice_CheckedChanged(object sender, EventArgs e)
        {
            choice = "3rdChoice";
            txtChoice.Text = choice;
        }

        public Delegate Mat10;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ChangedText = (TextBox)sender;
            Mat10.DynamicInvoke(txtChoice.Text, txtOther.Text);
        }
        private void txtOther_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagOthers":
                    txtOther.TextChanged += MyTextClickHandler;
                    break;
                case "tagChoice":
                    txtChoice.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void MyRadioButtonClickHandler(object sender, EventArgs e)
        {
            RadioButton ClickedRadio = (RadioButton)sender;
            Mat10.DynamicInvoke(txtChoice.Text, txtOther.Text);
        }
        private void rbChoice_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Tag)
            {
                case "tagChoi1":
                    rb1Choice.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagChoi2":
                    rb2Choice.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagChoi3":
                    rb3Choice.CheckedChanged += MyRadioButtonClickHandler;
                    break;
            }
        }

        private void UC_RequestOrigine_Load(object sender, EventArgs e)
        {
            choice = Settings.Default.choi;
            if (choice == "1stChoice")
            {
                rb1Choice.Checked = true;
            }
            else if (choice == "2ndChoice")
            {
                rb2Choice.Checked = true;
            }
            else if (choice == "3rdChoice")
            {
                rb3Choice.Checked = true;
            }
            txtOther.Text = Settings.Default.autr;
        }

        private void UC_RequestOrigine_Leave(object sender, EventArgs e)
        {
            Settings.Default.choi = choice;
            Settings.Default.autr = txtOther.Text;
        }
    }
}
