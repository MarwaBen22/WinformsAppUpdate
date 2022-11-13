using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRHApp.Forms;
using GRHApp.Classes;
using GRHApp.Properties;
using System.Globalization;

namespace GRHApp.UserControls
{
    public partial class UC_CivilState : UserControl
    {
        
        public UC_CivilState()
        {
            InitializeComponent();
            txtMtricule.TextChanged += MyTextClickHandler;
            txtLName.TextChanged += MyTextClickHandler;
            txtName.TextChanged += MyTextClickHandler;
            txtNameB.TextChanged += MyTextClickHandler;
            txtPBirth.TextChanged += MyTextClickHandler;
            txtAddress.TextChanged += MyTextClickHandler;
            txtPhone.TextChanged += MyTextClickHandler;
            txtFathName.TextChanged += MyTextClickHandler;
            txtMothName.TextChanged += MyTextClickHandler;
            txtBloodType.TextChanged += MyTextClickHandler;
            txtJobFath.TextChanged += MyTextClickHandler;
            txtJobMoth.TextChanged += MyTextClickHandler;
            txtSiblingsNum.TextChanged += MyTextClickHandler;
            txtMName.TextChanged += MyTextClickHandler;
            txtMJob.TextChanged += MyTextClickHandler;
            txtNumKids.TextChanged += MyTextClickHandler;
            txtNumAccount.TextChanged += MyTextClickHandler;
            txtSecuriteNum.TextChanged += MyTextClickHandler;
            txtCarteNum.TextChanged += MyTextClickHandler;
            txtDeliverBy.TextChanged += MyTextClickHandler;

            dtpBirth.ValueChanged += MyDateTimeClickHandler;
            dtpMarri.ValueChanged += MyDateTimeClickHandler;
            dtpDeliver.ValueChanged += MyDateTimeClickHandler;

            cbFamSit.TextChanged += MyComboClickHandler;
            cbNationality.TextChanged += MyTextClickHandler;

            pnlInfo2.Visible = false;
            btnBack.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pnlInfo2.Visible == false)
            {
                pnlInfo1.Visible = false;
                pnlInfo2.Visible = true;
                btnBack.Visible = true;
                btnNext.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (pnlInfo1.Visible == false)
            {
                pnlInfo1.Visible = true;
                pnlInfo2.Visible = false;
                btnBack.Visible = false;
                btnNext.Visible = true;
            }
        }

        private void pnlInfo2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtLName_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void txtMtricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        public Delegate Mat;
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            //TextBox ClickedText = (TextBox)sender;
            Mat.DynamicInvoke(txtMtricule.Text, txtLName.Text, txtName.Text, txtNameB.Text, dtpBirth.Value, txtPBirth.Text, cbNationality.Text, cbFamSit.Text, txtAddress.Text, txtPhone.Text, txtFathName.Text, txtMothName.Text, txtBloodType.Text, txtJobFath.Text, txtJobMoth.Text, txtSiblingsNum.Text, txtMName.Text, dtpMarri.Value, txtMJob.Text, txtNumKids.Text, txtNumAccount.Text, txtSecuriteNum.Text, txtCarteNum.Text, txtDeliverBy.Text, dtpDeliver.Value);
        }
        private void txt_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            switch (txt.Tag)
            {
                case "txtMat":
                    txtMtricule.TextChanged += MyTextClickHandler;
                    break;
                case "txtLNa":
                    txtLName.TextChanged += MyTextClickHandler;
                    break;
                case "txtNam":
                    txtName.TextChanged += MyTextClickHandler;
                    break;
                case "txtNameBef":
                    txtNameB.TextChanged += MyTextClickHandler;
                    break;
                case "txtPBirt":
                    txtPBirth.TextChanged += MyTextClickHandler;
                    break;
                case "txtAdres":
                    txtAddress.TextChanged += MyTextClickHandler;
                    break;
                case "tagPhone":
                    txtPhone.TextChanged += MyTextClickHandler;
                    break;
                case "tagFathName":
                    txtFathName.TextChanged += MyTextClickHandler;
                    break;
                case "tagMothName":
                    txtMothName.TextChanged += MyTextClickHandler;
                    break;
                case "tagBloodType":
                    txtBloodType.TextChanged += MyTextClickHandler;
                    break;
                case "tagFathJob":
                    txtJobFath.TextChanged += MyTextClickHandler;
                    break;
                case "tagMothJob":
                    txtJobMoth.TextChanged += MyTextClickHandler;
                    break;
                case "tagSiblingNum":
                    txtSiblingsNum.TextChanged += MyTextClickHandler;
                    break;
                case "tagMariName":
                    txtMName.TextChanged += MyTextClickHandler;
                    break;
                case "tahMariJob":
                    txtMJob.TextChanged += MyTextClickHandler;
                    break;
                case "tagChildNum":
                    txtNumKids.TextChanged += MyTextClickHandler;
                    break;
                case "tagAccount":
                    txtNumAccount.TextChanged += MyTextClickHandler;
                    break;
                case "tagSecur":
                    txtSecuriteNum.TextChanged += MyTextClickHandler;
                    break;
                case "tagCarteNum":
                    txtCarteNum.TextChanged += MyTextClickHandler;
                    break;
                case "tagDeliverBy":
                    txtDeliverBy.TextChanged += MyTextClickHandler;
                    break;
            }
            //txtLName.TextChanged += MyTextClickHandler; 
        }

        private void MyDateTimeClickHandler(object sender, EventArgs e)
        {
            DateTimePicker ClickedDate = (DateTimePicker)sender;
            Mat.DynamicInvoke(txtMtricule.Text, txtLName.Text, txtName.Text, txtNameB.Text, dtpBirth.Value, txtPBirth.Text, cbNationality.Text, cbFamSit.Text, txtAddress.Text, txtPhone.Text, txtFathName.Text, txtMothName.Text, txtBloodType.Text, txtJobFath.Text, txtJobMoth.Text, txtSiblingsNum.Text, txtMName.Text, dtpMarri.Value, txtMJob.Text, txtNumKids.Text, txtNumAccount.Text, txtSecuriteNum.Text, txtCarteNum.Text, txtDeliverBy.Text, dtpDeliver.Value);
        }
        private void dtp_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            switch (dtp.Tag)
            {
                case "dtpBirth":
                    dtpBirth.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagMariDate":
                    dtpMarri.ValueChanged += MyDateTimeClickHandler;
                    break;
                case "tagDeliverDate":
                    dtpDeliver.ValueChanged += MyDateTimeClickHandler;
                    break;
            }
        }

        private void MyComboClickHandler(object sender, EventArgs e)
        {
            ComboBox ClickedCombo = (ComboBox)sender;
            Mat.DynamicInvoke(txtMtricule.Text, txtLName.Text, txtName.Text, txtNameB.Text, dtpBirth.Value, txtPBirth.Text, cbNationality.Text, cbFamSit.Text, txtAddress.Text, txtPhone.Text, txtFathName.Text, txtMothName.Text, txtBloodType.Text, txtJobFath.Text, txtJobMoth.Text, txtSiblingsNum.Text, txtMName.Text, dtpMarri.Value, txtMJob.Text, txtNumKids.Text, txtNumAccount.Text, txtSecuriteNum.Text, txtCarteNum.Text, txtDeliverBy.Text, dtpDeliver.Value);
        }

        private void cb_Click(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            switch (cb.Tag)
            {
                case "cbFaSit":
                    cbFamSit.TextChanged += MyComboClickHandler;
                    break;
                case "cbNation":
                    cbNationality.TextChanged += MyComboClickHandler;
                    break;
            }
        }

        private void UC_CivilState_Load(object sender, EventArgs e)
        {

            txtMtricule.Text = Settings.Default.mat;
            txtLName.Text = Settings.Default.nom;
            txtName.Text = Settings.Default.prenom;
            txtNameB.Text = Settings.Default.nomFille;
            dtpBirth.Text = Settings.Default.dateNai;
            txtPBirth.Text = Settings.Default.lieuNai;
            cbFamSit.Text = Settings.Default.sitFam;
            cbNationality.Text = Settings.Default.nationalite;
            txtAddress.Text = Settings.Default.adresse;
            txtPhone.Text = Settings.Default.mobile;
            txtFathName.Text = Settings.Default.prePere;
            txtMothName.Text = Settings.Default.nomMere;
            txtBloodType.Text = Settings.Default.groupSang;
            txtJobFath.Text = Settings.Default.profPere;
            txtJobMoth.Text = Settings.Default.profMere;
            txtSiblingsNum.Text = Settings.Default.nomFrere;
            txtMName.Text = Settings.Default.nomConj;
            dtpMarri.Text = Settings.Default.dateMar;
            txtMJob.Text = Settings.Default.profConj;
            txtNumKids.Text = Settings.Default.nomEnfs;
            txtNumAccount.Text = Settings.Default.nomComp;
            txtSecuriteNum.Text = Settings.Default.numSec;
            txtCarteNum.Text = Settings.Default.cartNatio;
            txtDeliverBy.Text = Settings.Default.delivPar;
            dtpDeliver.Text = Settings.Default.dateDeliv;
        }

        private void UC_CivilState_Leave(object sender, EventArgs e)
        {
            Settings.Default.mat = txtMtricule.Text;
            Settings.Default.nom = txtLName.Text;
            Settings.Default.prenom = txtName.Text;
            Settings.Default.nomFille = txtNameB.Text;
            Settings.Default.dateNai = dtpBirth.Value.ToShortDateString();
            Settings.Default.lieuNai = txtPBirth.Text;
            Settings.Default.sitFam = cbFamSit.Text;
            Settings.Default.nationalite = cbNationality.Text;
            Settings.Default.adresse = txtAddress.Text;
            Settings.Default.mobile = txtPhone.Text;
            Settings.Default.prePere = txtFathName.Text;
            Settings.Default.nomMere = txtMothName.Text;
            Settings.Default.groupSang = txtBloodType.Text;
            Settings.Default.profPere = txtJobFath.Text;
            Settings.Default.profMere = txtJobMoth.Text;
            Settings.Default.nomFrere = txtSiblingsNum.Text;
            Settings.Default.nomConj = txtMName.Text;
            Settings.Default.dateMar = dtpMarri.Value.ToShortDateString();
            Settings.Default.profConj = txtMJob.Text;
            Settings.Default.nomEnfs = txtNumKids.Text;
            Settings.Default.nomComp = txtNumAccount.Text;
            Settings.Default.numSec = txtSecuriteNum.Text;
            Settings.Default.cartNatio = txtCarteNum.Text;
            Settings.Default.delivPar = txtDeliverBy.Text;
            Settings.Default.dateDeliv = dtpDeliver.Value.ToShortDateString();
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
