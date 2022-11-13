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
    public partial class UC_Leave : UserControl
    {
        public UC_Leave()
        {
            InitializeComponent();
            txtOtherCauses.TextChanged += MyTextClickHandler;
            dtpLeave.ValueChanged += MyDateTimeClickHandler;
            combCateg.TextChanged += MyComboClickHandler;
            combCause.TextChanged += MyComboClickHandler;
        }

        public Delegate Mat22;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ChangedText = (TextBox)sender;
            Mat22.DynamicInvoke(combCause.Text, dtpLeave.Value, combCateg.Text, txtOtherCauses.Text);
        }

        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
            DateTimePicker ClickedDate = (DateTimePicker)sender;
            Mat22.DynamicInvoke(combCause.Text, dtpLeave.Value, combCateg.Text, txtOtherCauses.Text);
        }

        private void combCateg_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dtpLeave_MouseDown(object sender, MouseEventArgs e)
        {
            dtpLeave.ValueChanged += MyDateTimeClickHandler;
        }
        private void MyComboClickHandler(object sender, EventArgs e)
        {
            ComboBox comb = (ComboBox)sender;
            Mat22.DynamicInvoke(combCause.Text, dtpLeave.Value, combCateg.Text, txtOtherCauses.Text);
        }

        private void combLeave_Click(object sender, EventArgs e)
        {
            ComboBox comb = (ComboBox)sender;
            switch (comb.Tag)
            {
                case "tagCateg":
                    combCateg.TextChanged += MyComboClickHandler;
                    break;
                case "tagCause":
                    combCause.TextChanged += MyComboClickHandler;
                    break;
            }
        }

        private void txtOtherCauses_Click(object sender, EventArgs e)
        {
            txtOtherCauses.TextChanged += MyTextClickHandler;
        }

        private void UC_Leave_Load(object sender, EventArgs e)
        {
            dtpLeave.Text = Settings.Default.dateDep;
            combCateg.Text = Settings.Default.categDep;
            combCause.Text = Settings.Default.causeDep;
            txtOtherCauses.Text = Settings.Default.othCauseDep;
        }

        private void UC_Leave_Leave(object sender, EventArgs e)
        {
            Settings.Default.dateDep = dtpLeave.Text;
            Settings.Default.categDep = combCateg.Text;
            Settings.Default.causeDep = combCause.Text;
            Settings.Default.othCauseDep = txtOtherCauses.Text;
        }
    }
}
