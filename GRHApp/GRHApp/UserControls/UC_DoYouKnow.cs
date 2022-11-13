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
    public partial class UC_DoYouKnow : UserControl
    {
        public UC_DoYouKnow()
        {
            InitializeComponent();
            txtFName1.TextChanged += MyTextClickHandler;
            txtName1.TextChanged += MyTextClickHandler;
            txtJob1.TextChanged += MyTextClickHandler;
            txtFName2.TextChanged += MyTextClickHandler;
            txtName2.TextChanged += MyTextClickHandler;
            txtJob2.TextChanged += MyTextClickHandler;
        }

        public Delegate Mat11;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat11.DynamicInvoke(txtFName1.Text, txtName1.Text, txtJob1.Text, txtFName2.Text, txtName2.Text, txtJob2.Text);
        }
        private void txt_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagFNam1":
                    txtFName1.TextChanged += MyTextClickHandler;
                    break;
                case "tagNam1":
                    txtName1.TextChanged += MyTextClickHandler;
                    break;
                case "tagJob1":
                    txtJob1.TextChanged += MyTextClickHandler;
                    break;
                case "tagFNam2":
                    txtFName2.TextChanged += MyTextClickHandler;
                    break;
                case "tagNam2":
                    txtName2.TextChanged += MyTextClickHandler;
                    break;
                case "tagJob2":
                    txtJob2.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void UC_DoYouKnow_Load(object sender, EventArgs e)
        {
            txtFName1.Text = Settings.Default.nom1;
            txtName1.Text = Settings.Default.pren1;
            txtJob1.Text = Settings.Default.fonc1;
            txtFName2.Text = Settings.Default.nom2;
            txtName2.Text = Settings.Default.pren2;
            txtJob2.Text = Settings.Default.fonc2;
        }

        private void UC_DoYouKnow_Leave(object sender, EventArgs e)
        {
            Settings.Default.nom1 = txtFName1.Text;
            Settings.Default.pren1 = txtName1.Text;
            Settings.Default.fonc1 = txtJob1.Text;
            Settings.Default.nom2 = txtFName2.Text;
            Settings.Default.pren2 = txtName2.Text;
            Settings.Default.fonc2 = txtJob2.Text;
        }
    }
}
