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
    public partial class UC_Emprovement : UserControl
    {
        public UC_Emprovement()
        {
            InitializeComponent();
            txtExer1.TextChanged += MyTextClickHandler;
            txtPromo1.TextChanged += MyTextClickHandler;
            txtReaff1.TextChanged += MyTextClickHandler;
            txtForm1.TextChanged += MyTextClickHandler;
            txtOther1.TextChanged += MyTextClickHandler;
            txtExer2.TextChanged += MyTextClickHandler;
            txtPromo2.TextChanged += MyTextClickHandler;
            txtReaff2.TextChanged += MyTextClickHandler;
            txtForm2.TextChanged += MyTextClickHandler;
            txtOther2.TextChanged += MyTextClickHandler;
            txtExer3.TextChanged += MyTextClickHandler;
            txtPromo3.TextChanged += MyTextClickHandler;
            txtReaff3.TextChanged += MyTextClickHandler;
            txtForm3.TextChanged += MyTextClickHandler;
            txtOther3.TextChanged += MyTextClickHandler;
            txtExer4.TextChanged += MyTextClickHandler;
            txtPromo4.TextChanged += MyTextClickHandler;
            txtReaff4.TextChanged += MyTextClickHandler;
            txtForm4.TextChanged += MyTextClickHandler;
            txtOther4.TextChanged += MyTextClickHandler;
            txtExer5.TextChanged += MyTextClickHandler;
            txtPromo5.TextChanged += MyTextClickHandler;
            txtReaff5.TextChanged += MyTextClickHandler;
            txtForm5.TextChanged += MyTextClickHandler;
            txtOther5.TextChanged += MyTextClickHandler;
            txtExer6.TextChanged += MyTextClickHandler;
            txtPromo6.TextChanged += MyTextClickHandler;
            txtReaff6.TextChanged += MyTextClickHandler;
            txtForm6.TextChanged += MyTextClickHandler;
            txtOther6.TextChanged += MyTextClickHandler;
            txtExer7.TextChanged += MyTextClickHandler;
            txtPromo7.TextChanged += MyTextClickHandler;
            txtReaff7.TextChanged += MyTextClickHandler;
            txtForm7.TextChanged += MyTextClickHandler;
            txtOther7.TextChanged += MyTextClickHandler;
        }

        public Delegate Mat20;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat20.DynamicInvoke(txtExer1.Text, txtPromo1.Text, txtReaff1.Text, txtForm1.Text, txtOther1.Text, txtExer2.Text, txtPromo2.Text, txtReaff2.Text, txtForm2.Text, txtOther2.Text, txtExer3.Text, txtPromo3.Text, txtReaff3.Text, txtForm3.Text, txtOther3.Text, txtExer4.Text, txtPromo4.Text, txtReaff4.Text, txtForm4.Text, txtOther4.Text, txtExer5.Text, txtPromo5.Text, txtReaff5.Text, txtForm5.Text, txtOther5.Text, txtExer6.Text, txtPromo6.Text, txtReaff6.Text, txtForm6.Text, txtOther6.Text, txtExer7.Text, txtPromo7.Text, txtReaff7.Text, txtForm7.Text, txtOther7.Text);
        }
        private void UC_Emprovement_Load(object sender, EventArgs e)
        {
            txtExer1.Text = Settings.Default.exerc1;
            txtPromo1.Text = Settings.Default.promo1;
            txtReaff1.Text = Settings.Default.reaff1;
            txtForm1.Text = Settings.Default.form1;
            txtOther1.Text = Settings.Default.autre1;
            txtExer2.Text = Settings.Default.exerc2;
            txtPromo2.Text = Settings.Default.promo2;
            txtReaff2.Text = Settings.Default.reaff2;
            txtForm2.Text = Settings.Default.form2;
            txtOther2.Text = Settings.Default.autre2;
            txtExer3.Text = Settings.Default.exerc3;
            txtPromo3.Text = Settings.Default.promo3;
            txtReaff3.Text = Settings.Default.reaff3;
            txtForm3.Text = Settings.Default.form3;
            txtOther3.Text = Settings.Default.autre3;
            txtExer4.Text = Settings.Default.exerc4;
            txtPromo4.Text = Settings.Default.promo4;
            txtReaff4.Text = Settings.Default.reaff4;
            txtForm4.Text = Settings.Default.form4;
            txtOther4.Text = Settings.Default.autre4;
            txtExer5.Text = Settings.Default.exerc5;
            txtPromo5.Text = Settings.Default.promo5;
            txtReaff5.Text = Settings.Default.reaff5;
            txtForm5.Text = Settings.Default.form5;
            txtOther5.Text = Settings.Default.autre5;
            txtExer6.Text = Settings.Default.exerc6;
            txtPromo6.Text = Settings.Default.promo6;
            txtReaff6.Text = Settings.Default.reaff6;
            txtForm6.Text = Settings.Default.form6;
            txtOther6.Text = Settings.Default.autre6;
            txtExer7.Text = Settings.Default.exerc7;
            txtPromo7.Text = Settings.Default.promo7;
            txtReaff7.Text = Settings.Default.reaff7;
            txtForm7.Text = Settings.Default.form7;
            txtOther7.Text = Settings.Default.autre7;
        }

        private void txtEmpro_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagExer1":
                    txtExer1.TextChanged += MyTextClickHandler;
                    break;
                case "tagProm1":
                    txtPromo1.TextChanged += MyTextClickHandler;
                    break;
                case "tagReaf1":
                    txtReaff1.TextChanged += MyTextClickHandler;
                    break;
                case "Form1":
                    txtForm1.TextChanged += MyTextClickHandler;
                    break;
                case "tagOthers1":
                    txtOther1.TextChanged += MyTextClickHandler;
                    break;
                case "tagExer2":
                    txtExer2.TextChanged += MyTextClickHandler;
                    break;
                case "tagProm2":
                    txtPromo2.TextChanged += MyTextClickHandler;
                    break;
                case "tagReaf2":
                    txtReaff2.TextChanged += MyTextClickHandler;
                    break;
                case "tagForm2":
                    txtForm2.TextChanged += MyTextClickHandler;
                    break;
                case "tagOthers2":
                    txtOther2.TextChanged += MyTextClickHandler;
                    break;
                case "tagExer3":
                    txtExer3.TextChanged += MyTextClickHandler;
                    break;
                case "tagProm3":
                    txtPromo3.TextChanged += MyTextClickHandler;
                    break;
                case "tagReaf3":
                    txtReaff3.TextChanged += MyTextClickHandler;
                    break;
                case "tagForm3":
                    txtForm3.TextChanged += MyTextClickHandler;
                    break;
                case "tagOthers3":
                    txtOther3.TextChanged += MyTextClickHandler;
                    break;
                case "tagExer4":
                    txtExer4.TextChanged += MyTextClickHandler;
                    break;
                case "tagProm4":
                    txtPromo4.TextChanged += MyTextClickHandler;
                    break;
                case "tagReaf4":
                    txtReaff4.TextChanged += MyTextClickHandler;
                    break;
                case "tagForm4":
                    txtForm4.TextChanged += MyTextClickHandler;
                    break;
                case "tagOthers4":
                    txtOther4.TextChanged += MyTextClickHandler;
                    break;
                case "tagExer5":
                    txtExer5.TextChanged += MyTextClickHandler;
                    break;
                case "tagProm5":
                    txtPromo5.TextChanged += MyTextClickHandler;
                    break;
                case "tagReaf5":
                    txtReaff5.TextChanged += MyTextClickHandler;
                    break;
                case "tagForm5":
                    txtForm5.TextChanged += MyTextClickHandler;
                    break;
                case "tagOthers5":
                    txtOther5.TextChanged += MyTextClickHandler;
                    break;
                case "tagExer6":
                    txtExer6.TextChanged += MyTextClickHandler;
                    break;
                case "tagProm6":
                    txtPromo6.TextChanged += MyTextClickHandler;
                    break;
                case "tagReaf6":
                    txtReaff6.TextChanged += MyTextClickHandler;
                    break;
                case "tagForm6":
                    txtForm6.TextChanged += MyTextClickHandler;
                    break;
                case "tagOthers6":
                    txtOther6.TextChanged += MyTextClickHandler;
                    break;
                case "tagExer7":
                    txtExer7.TextChanged += MyTextClickHandler;
                    break;
                case "tagProm7":
                    txtPromo7.TextChanged += MyTextClickHandler;
                    break;
                case "tagReaf7":
                    txtReaff7.TextChanged += MyTextClickHandler;
                    break;
                case "tagForm7":
                    txtForm7.TextChanged += MyTextClickHandler;
                    break;
                case "tagOthers7":
                    txtOther7.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void UC_Emprovement_Leave(object sender, EventArgs e)
        {
            Settings.Default.exerc1 = txtExer1.Text;
            Settings.Default.promo1 = txtPromo1.Text;
            Settings.Default.reaff1 = txtReaff1.Text;
            Settings.Default.form1 = txtForm1.Text;
            Settings.Default.autre1 = txtOther1.Text;
            Settings.Default.exerc2 = txtExer2.Text;
            Settings.Default.promo2 = txtPromo2.Text;
            Settings.Default.reaff2 = txtReaff2.Text;
            Settings.Default.form2 = txtForm2.Text;
            Settings.Default.autre2 = txtOther2.Text;
            Settings.Default.exerc3 = txtExer3.Text;
            Settings.Default.promo3 = txtPromo3.Text;
            Settings.Default.reaff3 = txtReaff3.Text;
            Settings.Default.form3 = txtForm3.Text;
            Settings.Default.autre3 = txtOther3.Text;
            Settings.Default.exerc4 = txtExer4.Text;
            Settings.Default.promo4 = txtPromo4.Text;
            Settings.Default.reaff4 = txtReaff4.Text;
            Settings.Default.form4 = txtForm4.Text;
            Settings.Default.autre4 = txtOther4.Text;
            Settings.Default.exerc5 = txtExer5.Text;
            Settings.Default.promo5 = txtPromo5.Text;
            Settings.Default.reaff5 = txtReaff5.Text;
            Settings.Default.form5 = txtForm5.Text;
            Settings.Default.autre5 = txtOther5.Text;
            Settings.Default.exerc6 = txtExer6.Text;
            Settings.Default.promo6 = txtPromo6.Text;
            Settings.Default.reaff6 = txtReaff6.Text;
            Settings.Default.form6 = txtForm6.Text;
            Settings.Default.autre6 = txtOther6.Text;
            Settings.Default.exerc7 = txtExer7.Text;
            Settings.Default.promo7 = txtPromo7.Text;
            Settings.Default.reaff7 = txtReaff7.Text;
            Settings.Default.form7 = txtForm7.Text;
            Settings.Default.autre7 = txtOther7.Text;
        }
    }
}
