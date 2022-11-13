using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRHApp.Classes;
using GRHApp.Properties;

namespace GRHApp.Forms
{
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();

        string fichRec;
        //string fichRecAdd;
        //string fichRecView;
        string fichRen;
        //string fichRenAdd;
        //string fichRenView;
        string attTra;
        //string attTraAdd;
        //string attTraView;
        string certTra;
        //string certTraAdd;
        //string certTraView;
        string titCon;
        //string titConAdd;
        //string titConView;
        
        public void clear()
        {
            foreach (var txt in this.Controls.OfType<TextBox>())
            {
                txt.Text = "";

            }
            foreach (var ckb in this.Controls.OfType<CheckBox>())
            {
                ckb.Checked = false;

            }
            cbStruct.Text = "";
        }
        private void ckbDocsManage_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbJournal_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbUsers_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Les modifications que vous avez apportées ne seront pas sauvegardées", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string user = Settings.Default.userName;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (rbFRecAll.Checked == false && rbFRecView.Checked == false)
                {
                    fichRec = "Non";
                }
                if (rbFRenAll.Checked == false && rbFRenView.Checked == false)
                {
                    fichRen = "Non";
                }
                if (rbAttestAll.Checked == false && rbAttestView.Checked == false)
                {
                    attTra = "Non";
                }
                if (rbCertAll.Checked == false && rbCertView.Checked == false)
                {
                    certTra = "Non";
                }
                if (rbCongAll.Checked == false && rbCongView.Checked == false)
                {
                    titCon = "Non";
                }
                if (txtUserN.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "")
                {
                    MessageBox.Show("Veuillez remplir les blans");
                }
                else
                {
                    if (crud.check_Id("T_Login", "name", txtUserN.Text) == "Code exists")
                    {
                        MessageBox.Show("Nom d'utilisateur existe déja");
                        clear();
                    }
                    else
                    {
                        crud.crudop("insert into T_Login values ('" + txtUserN.Text + "','" + txtEmail.Text + "','" + txtConfirm.Text + "','" + fichRec + "','" + fichRen + "','" + attTra + "','" + certTra + "','" + titCon + "', (select id_Struct from T_Structure where nom_Structure='" + cbStruct.Text + "'))");

                        crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Ajout de nouvel utilisateur','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                        MessageBox.Show("Vos données ont été enregistrées");
                        clear();
                    }
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirm.Text != txtPassword.Text)
            {
                lblAlert.Text = "Mot de passe incorrect";
            }
            else
            {
                lblAlert.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                crud.crudop("update T_Login set grh_DRec='" + fichRec + "', grh_FRen='" + fichRen + "', grh_ATravail='" + attTra + "', grh_CTravail='" + certTra + "', grh_TConge='" + titCon + "', id_Struct=(select id_Struct from T_Structure where nom_Structure='" + cbStruct.Text + "') where name='" + txtUserN.Text + "'");
                MessageBox.Show("Vos données ont été mises à jour");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbFRecAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbFRecView_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbFRenAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbFRenView_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbAttestAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbAttestView_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckbCertAdd_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckbCertView_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckbCongAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbCongView_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckbUsersAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbUsersView_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbFRecAll_CheckedChanged(object sender, EventArgs e)
        {

            fichRec = "Faire tout";
           
        }

        private void rbFRecView_CheckedChanged(object sender, EventArgs e)
        {
            fichRec = "Consultation";
        }

        private void rbFRenAll_CheckedChanged(object sender, EventArgs e)
        {
            fichRen = "Faire tout";
        }

        private void rbFRenView_CheckedChanged(object sender, EventArgs e)
        {
            fichRen = "Consultation";
        }

        private void rbAttestAll_CheckedChanged(object sender, EventArgs e)
        {
            attTra = "Faire tout";
        }

        private void rbAttestView_CheckedChanged(object sender, EventArgs e)
        {
            attTra = "Consultation";
        }

        private void rbCertAll_CheckedChanged(object sender, EventArgs e)
        {
            certTra = "Faire tout";
        }

        private void rbCertView_CheckedChanged(object sender, EventArgs e)
        {
            certTra = "Consultation";
        }

        private void rbCongAll_CheckedChanged(object sender, EventArgs e)
        {
            titCon = "Faire tout";
        }

        private void rbCongView_CheckedChanged(object sender, EventArgs e)
        {
            titCon = "Consultation";
        }

        private void lblAlert_Click(object sender, EventArgs e)
        {

        }

        private void cbStruct_Click(object sender, EventArgs e)
        {
            cbStruct.Items.Clear();

            try
            {
                SqlConnection cnx = new SqlConnection(@"Data Source=192.168.1.2,49170;Initial Catalog=GRHdb;User ID=sa;Password=02101996k+");

                if (cnx.State != ConnectionState.Open)
                    cnx.Open();

                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select nom_Structure from T_Structure";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cbStruct.Items.Add(dr["nom_Structure"].ToString());
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddStruct_Click(object sender, EventArgs e)
        {
            Form_Service _Service = new Form_Service();
            _Service.Show();
        }
    }
}
