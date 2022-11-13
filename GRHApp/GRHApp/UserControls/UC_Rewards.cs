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
    public partial class UC_Rewards : UserControl
    {
        public UC_Rewards()
        {
            InitializeComponent();
            txtSalary.TextChanged += MyTextClickHandler;
            txtIEP.TextChanged += MyTextClickHandler;
            txtOther.TextChanged += MyTextClickHandler;
            txtPanier.TextChanged += MyTextClickHandler;
            txtTrans.TextChanged += MyTextClickHandler;
            txtSoil.TextChanged += MyTextClickHandler;
            txtIndemn.TextChanged += MyTextClickHandler;
            txtDeplace.TextChanged += MyTextClickHandler;
            txtDanger.TextChanged += MyTextClickHandler;
            txtPhone.TextChanged += MyTextClickHandler;
            txtPenibilite.TextChanged += MyTextClickHandler;
            txtInsalub.TextChanged += MyTextClickHandler;
            txtFidelite.TextChanged += MyTextClickHandler;
            txtPRI.TextChanged += MyTextClickHandler;
            txtPRC.TextChanged += MyTextClickHandler;
            txtPPI.TextChanged += MyTextClickHandler;
            txtIQ.TextChanged += MyTextClickHandler;
            txtMission.TextChanged += MyTextClickHandler;
            txtIFRI.TextChanged += MyTextClickHandler;
        }

        string Panier = "";
        string Transp = "";
        string Saliss = "";
        string Indemnity = "";
        string Deplace = "";
        string Danger = "";
        string Phone = "";
        string Penibilite = "";
        string Insalub = "";
        string Fidelity = "";
        string PRI = "";
        string PRC = "";
        string PPI = "";
        string IQ = "";
        string Mission = "";
        string IFRI = "";

        public Delegate Mat14;

        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ChangedText = (TextBox)sender;
            Mat14.DynamicInvoke(txtSalary.Text, txtIEP.Text,txtOther.Text, Panier, Transp, Saliss, Indemnity, Deplace, Danger, Phone, Penibilite, Insalub, Fidelity, PRI, PRC, PPI, IQ, Mission, IFRI);
        }
        private void txtR_Click(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            switch (text.Tag)
            {
                case "tagSalary":
                    txtSalary.TextChanged += MyTextClickHandler;
                    break;
                case "tagIEP":
                    txtIEP.TextChanged += MyTextClickHandler;
                    break;
                case "tagOther":
                    txtOther.TextChanged += MyTextClickHandler;
                    break;
                case "tagPanTxt":
                    txtPanier.TextChanged += MyTextClickHandler;
                    break;
                case "tagTranTxt":
                    txtTrans.TextChanged += MyTextClickHandler;
                    break;
                case "tagSalTxt":
                    txtSoil.TextChanged += MyTextClickHandler;
                    break;
                case "tagIndTxt":
                    txtIndemn.TextChanged += MyTextClickHandler;
                    break;
                case "tagDepTxt":
                    txtDeplace.TextChanged += MyTextClickHandler;
                    break;
                case "tagDanTxt":
                    txtDanger.TextChanged += MyTextClickHandler;
                    break;
                case "tagPhoTxt":
                    txtPhone.TextChanged += MyTextClickHandler;
                    break;
                case "tagPenTxt":
                    txtPenibilite.TextChanged += MyTextClickHandler;
                    break;
                case "tagInsTxt":
                    txtInsalub.TextChanged += MyTextClickHandler;
                    break;
                case "tagFidTxt":
                    txtFidelite.TextChanged += MyTextClickHandler;
                    break;
                case "tagPRITxt":
                    txtPRI.TextChanged += MyTextClickHandler;
                    break;
                case "tagPRCTxt":
                    txtPRC.TextChanged += MyTextClickHandler;
                    break;
                case "tagPPITxt":
                    txtPPI.TextChanged += MyTextClickHandler;
                    break;
                case "tagIQTxt":
                    txtIQ.TextChanged += MyTextClickHandler;
                    break;
                case "tagMissTxt":
                    txtMission.TextChanged += MyTextClickHandler;
                    break;
                case "tagIFRTxt":
                    txtIFRI.TextChanged += MyTextClickHandler;
                    break;
            }
        }

        private void MyRadioButtonClickHandler(object sender, EventArgs e)
        {
            CheckBox ClickedBox = (CheckBox)sender;
            Mat14.DynamicInvoke(txtSalary.Text, txtIEP.Text, txtOther.Text, Panier, Transp, Saliss, Indemnity, Deplace, Danger, Phone, Penibilite, Insalub, Fidelity, PRI, PRC, PPI, IQ, Mission, IFRI);
        }
        private void cbR_Click(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            switch (chb.Tag)
            {
                case "tagPanier":
                    cbPanier.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagTrans":
                    cbTransport.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagSaliss":
                    cbSoil.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagIndemn":
                    cbIndemnity.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagDeplace":
                    cbMove.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagDanger":
                    cbDanger.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagPhone":
                    cbPhone.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagPenibilite":
                    cbSeverty.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagInsalub":
                    cbInsalubrity.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagFidel":
                    cbFidelity.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagPRI":
                    cbPRI.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagPRC":
                    cbPRC.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagPPI":
                    cbPPI.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagIQ":
                    cbIQ.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagMission":
                    cbMission.CheckedChanged += MyRadioButtonClickHandler;
                    break;
                case "tagIFRI":
                    cbIFRI.CheckedChanged += MyRadioButtonClickHandler;
                    break;
            }
        }

        private void cbPanier_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPanier.Checked == true)
            {
                Panier = "Yes";
                txtPanier.Text = Panier;
            }
            else
            {
                Panier = "No";
                txtPanier.Text = Panier;
            }
        }

        private void cbTransport_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTransport.Checked == true)
            {
                Transp = "Yes";
                txtTrans.Text = Transp;
            }
            else
            {
                Transp = "No";
                txtTrans.Text = Transp;
            }
        }

        private void cbSoil_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSoil.Checked == true)
            {
                Saliss = "Yes";
                txtSoil.Text = Saliss;
            }
            else
            {
                Saliss = "No";
                txtSoil.Text = Saliss;
            }
        }

        private void cbIndemnity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIndemnity.Checked == true)
            {
                Indemnity = "Yes";
                txtIndemn.Text = Indemnity;
            }
            else
            {
                Indemnity = "No";
                txtIndemn.Text = Indemnity;
            }
        }

        private void cbMove_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMove.Checked == true)
            {
                Deplace = "Yes";
                txtDeplace.Text = Deplace;
            }
            else
            {
                Deplace = "No";
                txtDeplace.Text = Deplace;
            }
        }

        private void cbDanger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDanger.Checked == true)
            {
                Danger = "Yes";
                txtDanger.Text = Danger;
            }
            else
            {
                Danger = "No";
                txtDanger.Text = Danger;
            }
        }

        private void cbPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPhone.Checked == true)
            {
                Phone = "Yes";
                txtPhone.Text = Phone;
            }
            else
            {
                Phone = "No";
                txtPhone.Text = Phone;
            }
        }

        private void cbSeverty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeverty.Checked == true)
            {
                Penibilite = "Yes";
                txtPenibilite.Text = Penibilite;
            }
            else
            {
                Penibilite = "No";
                txtPenibilite.Text = Penibilite;
            }
        }

        private void cbInsalubrity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInsalubrity.Checked == true)
            {
                Insalub = "Yes";
                txtInsalub.Text = Insalub;
            }
            else
            {
                Insalub = "No";
                txtInsalub.Text = Insalub;
            }
        }

        private void cbFidelity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFidelity.Checked == true)
            {
                Fidelity = "Yes";
                txtFidelite.Text = Fidelity;
            }
            else
            {
                Fidelity = "No";
                txtFidelite.Text = Fidelity;
            }
        }

        private void cbPRI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPRI.Checked == true)
            {
                PRI = "Yes";
                txtPRI.Text = PRI;
            }
            else
            {
                PRI = "No";
                txtPRI.Text = PRI;
            }
        }

        private void cbPRC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPRC.Checked == true)
            {
                PRC = "Yes";
                txtPRC.Text = PRC;
            }
            else
            {
                PRC = "No";
                txtPRC.Text = PRC;
            }
        }

        private void cbPPI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPPI.Checked == true)
            {
                PPI = "Yes";
                txtPPI.Text = PPI;
            }
            else
            {
                PPI = "No";
                txtPPI.Text = PPI;
            }
        }

        private void cbIQ_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIQ.Checked == true)
            {
                IQ = "Yes";
                txtIQ.Text = IQ;
            }
            else
            {
                IQ = "No";
                txtIQ.Text = IQ;
            }
        }

        private void cbMission_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMission.Checked == true)
            {
                Mission = "Yes";
                txtMission.Text = Mission;
            }
            else
            {
                Mission = "No";
                txtMission.Text = Mission;
            }
        }

        private void cbIFRI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIFRI.Checked == true)
            {
                IFRI = "Yes";
                txtIFRI.Text = IFRI;
            }
            else
            {
                IFRI = "No";
                txtIFRI.Text = IFRI;
            }
        }

        public void initReward()
        {
            txtSalary.Text = Settings.Default.salaire;
            txtIEP.Text = Settings.Default.iep;
            Panier = Settings.Default.panier;
            if (Panier == "Yes")
            {
                cbPanier.Checked = true;
            }
            else if (Panier == "No")
            {
                cbPanier.Checked = false;
            }
            Transp = Settings.Default.trans;
            if (Transp == "Yes")
            {
                cbTransport.Checked = true;
            }
            else if (Transp == "No")
            {
                cbTransport.Checked = false;
            }
            Saliss = Settings.Default.saliss;
            if (Saliss == "Yes")
            {
                cbSoil.Checked = true;
            }
            else if (Saliss == "No")
            {
                cbSoil.Checked = false;
            }
            Indemnity = Settings.Default.indemnV;
            if (Indemnity == "Yes")
            {
                cbIndemnity.Checked = true;
            }
            else if (Indemnity == "No")
            {
                cbIndemnity.Checked = false;
            }
            Deplace = Settings.Default.deplace;
            if (Deplace == "Yes")
            {
                cbMove.Checked = true;
            }
            else if (Deplace == "No")
            {
                cbMove.Checked = false;
            }
            Danger = Settings.Default.danger;
            if (Danger == "Yes")
            {
                cbDanger.Checked = true;
            }
            else if (Danger == "No")
            {
                cbDanger.Checked = false;
            }
            Phone = Settings.Default.phone;
            if (Phone == "Yes")
            {
                cbPhone.Checked = true;
            }
            else if (Phone == "No")
            {
                cbPhone.Checked = false;
            }
            Penibilite = Settings.Default.penibilite;
            if (Penibilite == "Yes")
            {
                cbSeverty.Checked = true;
            }
            else if (Penibilite == "No")
            {
                cbSeverty.Checked = false;
            }
            Insalub = Settings.Default.insalub;
            if (Insalub == "Yes")
            {
                cbInsalubrity.Checked = true;
            }
            else if (Insalub == "No")
            {
                cbInsalubrity.Checked = false;
            }
            Fidelity = Settings.Default.fidelite;
            if (Fidelity == "Yes")
            {
                cbFidelity.Checked = true;
            }
            else if (Fidelity == "No")
            {
                cbFidelity.Checked = false;
            }
            PRI = Settings.Default.pri;
            if (PRI == "Yes")
            {
                cbPRI.Checked = true;
            }
            else if (PRI == "No")
            {
                cbPRI.Checked = false;
            }
            PRC = Settings.Default.prc;
            if (PRC == "Yes")
            {
                cbPRC.Checked = true;
            }
            else if (PRC == "No")
            {
                cbPRC.Checked = false;
            }
            PPI = Settings.Default.ppi;
            if (PPI == "Yes")
            {
                cbPPI.Checked = true;
            }
            else if (PPI == "No")
            {
                cbPPI.Checked = false;
            }
            IQ = Settings.Default.iq;
            if (IQ == "Yes")
            {
                cbIQ.Checked = true;
            }
            else if (IQ == "No")
            {
                cbIQ.Checked = false;
            }
            Mission = Settings.Default.mission;
            if (Mission == "Yes")
            {
                cbMission.Checked = true;
            }
            else if (Mission == "No")
            {
                cbMission.Checked = false;
            }
            IFRI = Settings.Default.ifri;
            if (IFRI == "Yes")
            {
                cbIFRI.Checked = true;
            }
            else if (IFRI == "No")
            {
                cbIFRI.Checked = false;
            }
            txtOther.Text = Settings.Default.autre;
        }
        private void UC_Rewards_Load(object sender, EventArgs e)
        {
            initReward();
        }

        private void UC_Rewards_Leave(object sender, EventArgs e)
        {
            Settings.Default.salaire = txtSalary.Text;
            Settings.Default.iep = txtIEP.Text;
            Settings.Default.panier = Panier;
            Settings.Default.trans = Transp;
            Settings.Default.saliss = Saliss;
            Settings.Default.indemnV = Indemnity;
            Settings.Default.deplace = Deplace;
            Settings.Default.danger = Danger;
            Settings.Default.phone = Phone;
            Settings.Default.penibilite = Penibilite;
            Settings.Default.insalub = Insalub;
            Settings.Default.fidelite = Fidelity;
            Settings.Default.pri = PRI;
            Settings.Default.prc = PRC;
            Settings.Default.ppi = PPI;
            Settings.Default.iq = IQ;
            Settings.Default.mission = Mission;
            Settings.Default.ifri = IFRI;
            Settings.Default.autre = txtOther.Text;
        }
    }
}
