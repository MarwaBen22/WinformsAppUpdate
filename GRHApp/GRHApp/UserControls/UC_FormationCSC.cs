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
    public partial class UC_FormationCSC : UserControl
    {
        public UC_FormationCSC()
        {
            InitializeComponent();
            txtExe1.TextChanged += MyTextClickHandler;
            txtTheme1.TextChanged += MyTextClickHandler;
            txtFP1.TextChanged += MyTextClickHandler;
            txtPeriod1.TextChanged += MyTextClickHandler;
            txtObject1.TextChanged += MyTextClickHandler;
            txtExe2.TextChanged += MyTextClickHandler;
            txtTheme2.TextChanged += MyTextClickHandler;
            txtFP2.TextChanged += MyTextClickHandler;
            txtPeriod2.TextChanged += MyTextClickHandler;
            txtObject2.TextChanged += MyTextClickHandler;
            txtExe3.TextChanged += MyTextClickHandler;
            txtTheme3.TextChanged += MyTextClickHandler;
            txtFP3.TextChanged += MyTextClickHandler;
            txtPeriod3.TextChanged += MyTextClickHandler;
            txtObject3.TextChanged += MyTextClickHandler;
            txtExe4.TextChanged += MyTextClickHandler;
            txtTheme4.TextChanged += MyTextClickHandler;
            txtFP4.TextChanged += MyTextClickHandler;
            txtPeriod4.TextChanged += MyTextClickHandler;
            txtObject4.TextChanged += MyTextClickHandler;
            txtExe5.TextChanged += MyTextClickHandler;
            txtTheme5.TextChanged += MyTextClickHandler;
            txtFP5.TextChanged += MyTextClickHandler;
            txtPeriod5.TextChanged += MyTextClickHandler;
            txtObject5.TextChanged += MyTextClickHandler;

            dtp1.ValueChanged += MyDateTimeClickHandler;
            dtp2.ValueChanged += MyDateTimeClickHandler;
            dtp3.ValueChanged += MyDateTimeClickHandler;
            dtp4.ValueChanged += MyDateTimeClickHandler;
            dtp5.ValueChanged += MyDateTimeClickHandler;
        }

        public Delegate Mat16;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat16.DynamicInvoke(txtExe1.Text, txtTheme1.Text, txtFP1.Text, txtPeriod1.Text, dtp1.Value, txtObject1.Text, txtExe2.Text, txtTheme2.Text, txtFP2.Text, txtPeriod2.Text, dtp2.Value, txtObject2.Text, txtExe3.Text, txtTheme3.Text, txtFP3.Text, txtPeriod3.Text, dtp3.Value, txtObject3.Text, txtExe4.Text, txtTheme4.Text, txtFP4.Text, txtPeriod4.Text, dtp4.Value, txtObject4.Text, txtExe5.Text, txtTheme5.Text, txtFP5.Text, txtPeriod5.Text, dtp5.Value, txtObject5.Text);
        }
        private void lblAim_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtForm_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Tag)
            {
                case "tagExe1":
                    txtExe1.TextChanged += MyTextClickHandler;
                    break;
                case "tagTheme1":
                    txtTheme1.TextChanged += MyTextClickHandler;
                    break;
                case "tagPlace1":
                    txtFP1.TextChanged += MyTextClickHandler;
                    break;
                case "tagPeriod1":
                    txtPeriod1.TextChanged += MyTextClickHandler;
                    break;
                case "tagObject1":
                    txtObject1.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe2":
                    txtExe2.TextChanged += MyTextClickHandler;
                    break;
                case "tagTheme2":
                    txtTheme2.TextChanged += MyTextClickHandler;
                    break;
                case "tagPlace2":
                    txtFP2.TextChanged += MyTextClickHandler;
                    break;
                case "tagPeriod2":
                    txtPeriod2.TextChanged += MyTextClickHandler;
                    break;
                case "tagObject2":
                    txtObject2.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe3":
                    txtExe3.TextChanged += MyTextClickHandler;
                    break;
                case "tagTheme3":
                    txtTheme3.TextChanged += MyTextClickHandler;
                    break;
                case "tagPlace3":
                    txtFP3.TextChanged += MyTextClickHandler;
                    break;
                case "tagPeriod3":
                    txtPeriod3.TextChanged += MyTextClickHandler;
                    break;
                case "tagObject3":
                    txtObject3.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe4":
                    txtExe4.TextChanged += MyTextClickHandler;
                    break;
                case "tagTheme4":
                    txtTheme4.TextChanged += MyTextClickHandler;
                    break;
                case "tagPlace4":
                    txtFP4.TextChanged += MyTextClickHandler;
                    break;
                case "tagPeriod4":
                    txtPeriod4.TextChanged += MyTextClickHandler;
                    break;
                case "tagObject4":
                    txtObject4.TextChanged += MyTextClickHandler;
                    break;
                case "tagExe5":
                    txtExe5.TextChanged += MyTextClickHandler;
                    break;
                case "tagTheme5":
                    txtTheme5.TextChanged += MyTextClickHandler;
                    break;
                case "tagPlace5":
                    txtFP5.TextChanged += MyTextClickHandler;
                    break;
                case "tagPeriod5":
                    txtPeriod5.TextChanged += MyTextClickHandler;
                    break;
                case "tagObject5":
                    txtObject5.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
            DateTimePicker ClickedDate = (DateTimePicker)sender;
            Mat16.DynamicInvoke(txtExe1.Text, txtTheme1.Text, txtFP1.Text, txtPeriod1.Text, dtp1.Value, txtObject1.Text, txtExe2.Text, txtTheme2.Text, txtFP2.Text, txtPeriod2.Text, dtp2.Value, txtObject2.Text, txtExe3.Text, txtTheme3.Text, txtFP3.Text, txtPeriod3.Text, dtp3.Value, txtObject3.Text, txtExe4.Text, txtTheme4.Text, txtFP4.Text, txtPeriod4.Text, dtp4.Value, txtObject4.Text, txtExe5.Text, txtTheme5.Text, txtFP5.Text, txtPeriod5.Text, dtp5.Value, txtObject5.Text);
        }
        private void dtp_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            switch (dtp.Tag)
            {
                case "tagFormDate1":
                    dtp1.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagFormDate2":
                    dtp2.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagFormDate3":
                    dtp3.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagFormDate4":
                    dtp4.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagFormDate5":
                    dtp5.ValueChanged += MyDateTimeClickHandler;
                    break;
            }
        }

        private void UC_FormationCSC_Load(object sender, EventArgs e)
        {
            txtExe1.Text = Settings.Default.exe1;
            txtTheme1.Text = Settings.Default.the1;
            txtFP1.Text = Settings.Default.lieuF1;
            txtPeriod1.Text = Settings.Default.dure1;
            dtp1.Text = Settings.Default.dateF1;
            txtObject1.Text = Settings.Default.obj1;
            txtExe2.Text = Settings.Default.exe2;
            txtTheme2.Text = Settings.Default.the2;
            txtFP2.Text = Settings.Default.lieuF2;
            txtPeriod2.Text = Settings.Default.dure2;
            dtp2.Text = Settings.Default.dateF2;
            txtObject2.Text = Settings.Default.obj2;
            txtExe3.Text = Settings.Default.exe3;
            txtTheme3.Text = Settings.Default.the3;
            txtFP3.Text = Settings.Default.lieuF3;
            txtPeriod3.Text = Settings.Default.dure3;
            dtp3.Text = Settings.Default.dateF3;
            txtObject3.Text = Settings.Default.obj3;
            txtExe4.Text = Settings.Default.exe4;
            txtTheme4.Text = Settings.Default.the4;
            txtFP4.Text = Settings.Default.lieuF4;
            txtPeriod4.Text = Settings.Default.dure4;
            dtp4.Text = Settings.Default.dateF4;
            txtObject4.Text = Settings.Default.obj4;
            txtExe5.Text = Settings.Default.exe5;
            txtTheme5.Text = Settings.Default.the5;
            txtFP5.Text = Settings.Default.lieuF5;
            txtPeriod5.Text = Settings.Default.dure5;
            dtp5.Text = Settings.Default.dateF5;
            txtObject5.Text = Settings.Default.obj5;
        }

        private void UC_FormationCSC_Leave(object sender, EventArgs e)
        {
            Settings.Default.exe1 = txtExe1.Text;
            Settings.Default.the1 = txtTheme1.Text;
            Settings.Default.lieuF1 = txtFP1.Text;
            Settings.Default.dure1 = txtPeriod1.Text;
            Settings.Default.dateF1 = dtp1.Value.ToShortDateString();
            Settings.Default.obj1 = txtObject1.Text;
            Settings.Default.exe2 = txtExe2.Text;
            Settings.Default.the2 = txtTheme2.Text;
            Settings.Default.lieuF2 = txtFP2.Text;
            Settings.Default.dure2 = txtPeriod2.Text;
            Settings.Default.dateF2 = dtp2.Value.ToShortDateString();
            Settings.Default.obj2 = txtObject2.Text;
            Settings.Default.exe3 = txtExe3.Text;
            Settings.Default.the3 = txtTheme3.Text;
            Settings.Default.lieuF3 = txtFP3.Text;
            Settings.Default.dure3 = txtPeriod3.Text;
            Settings.Default.dateF3 = dtp3.Value.ToShortDateString();
            Settings.Default.obj3 = txtObject3.Text;
            Settings.Default.exe4 = txtExe4.Text;
            Settings.Default.the4 = txtTheme4.Text;
            Settings.Default.lieuF4 = txtFP4.Text;
            Settings.Default.dure4 = txtPeriod4.Text;
            Settings.Default.dateF4 = dtp4.Value.ToShortDateString();
            Settings.Default.obj4 = txtObject4.Text;
            Settings.Default.exe5 = txtExe5.Text;
            Settings.Default.the5 = txtTheme5.Text;
            Settings.Default.lieuF5 = txtFP5.Text;
            Settings.Default.dure5 = txtPeriod5.Text;
            Settings.Default.dateF5 = dtp5.Value.ToShortDateString();
            Settings.Default.obj5 = txtObject5.Text;
        }
    }
}
