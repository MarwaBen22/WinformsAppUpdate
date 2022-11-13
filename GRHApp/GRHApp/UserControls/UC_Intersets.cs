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
    public partial class UC_Intersets : UserControl
    {
        public UC_Intersets()
        {
            InitializeComponent();
            txtInter1.TextChanged += MyTextClickHandler;
            txtInter2.TextChanged += MyTextClickHandler;
            txtInter3.TextChanged += MyTextClickHandler;
            txtInter4.TextChanged += MyTextClickHandler;
            txtInter5.TextChanged += MyTextClickHandler;
            txtInter6.TextChanged += MyTextClickHandler;
            txtInter7.TextChanged += MyTextClickHandler;
            txtInter8.TextChanged += MyTextClickHandler;
        }

        private void UC_Intersets_Load(object sender, EventArgs e)
        {
            txtInter1.Text = Settings.Default.inter1;
            txtInter2.Text = Settings.Default.inter2;
            txtInter3.Text = Settings.Default.inter3;
            txtInter4.Text = Settings.Default.inter4;
            txtInter5.Text = Settings.Default.inter5;
            txtInter6.Text = Settings.Default.inter6;
            txtInter7.Text = Settings.Default.inter7;
            txtInter8.Text = Settings.Default.inter8;
        }
        public Delegate Mat9;
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat9.DynamicInvoke(txtInter1.Text, txtInter2.Text, txtInter3.Text, txtInter4.Text, txtInter5.Text, txtInter6.Text, txtInter7.Text, txtInter8.Text);
        }

        private void txtInter_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagInt1":
                    txtInter1.TextChanged += MyTextClickHandler;
                    break;
                case "tagInt2":
                    txtInter2.TextChanged += MyTextClickHandler;
                    break;
                case "tagInt3":
                    txtInter3.TextChanged += MyTextClickHandler;
                    break;
                case "tagInt4":
                    txtInter4.TextChanged += MyTextClickHandler;
                    break;
                case "tagInt5":
                    txtInter5.TextChanged += MyTextClickHandler;
                    break;
                case "tagInt6":
                    txtInter6.TextChanged += MyTextClickHandler;
                    break;
                case "tagInt7":
                    txtInter7.TextChanged += MyTextClickHandler;
                    break;
                case "tagInt8":
                    txtInter8.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void UC_Intersets_Leave(object sender, EventArgs e)
        {
            Settings.Default.inter1 = txtInter1.Text;
            Settings.Default.inter2 = txtInter2.Text;
            Settings.Default.inter3 = txtInter3.Text;
            Settings.Default.inter4 = txtInter4.Text;
            Settings.Default.inter5 = txtInter5.Text;
            Settings.Default.inter6 = txtInter6.Text;
            Settings.Default.inter7 = txtInter7.Text;
            Settings.Default.inter8 = txtInter8.Text;
        }
    }
}
