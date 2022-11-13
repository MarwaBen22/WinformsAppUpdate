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

namespace GRHApp.UserControls
{
    public partial class UC_UsersManage : UserControl
    {
        public UC_UsersManage()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        public void display()
        {
            dgvUsersList.DataSource = crud.getUser();
            dgvUsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_SignUp _SignUp = new Form_SignUp();
            _SignUp.btnUpdate.Visible = false;
            _SignUp.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Rechercher";
            
            display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvUsersList.DataSource = crud.searchUser("l.name", txtSearch.Text).Tables[0];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Form_SignUp _SignUp = new Form_SignUp();
            _SignUp.txtUserN.Text = dgvUsersList.CurrentRow.Cells[0].Value.ToString();
            _SignUp.txtEmail.Text = dgvUsersList.CurrentRow.Cells[1].Value.ToString();
            if (dgvUsersList.CurrentRow.Cells[2].Value.ToString() == "Faire tout")
            {
                _SignUp.rbFRecAll.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[2].Value.ToString() == "Consultation")
            {
                _SignUp.rbFRecView.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[2].Value.ToString() == "Non")
            {
                _SignUp.rbFRecView.Checked = false;
                _SignUp.rbFRecAll.Checked = false;
            }
            if (dgvUsersList.CurrentRow.Cells[3].Value.ToString() == "Faire tout")
            {
                _SignUp.rbFRenAll.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[3].Value.ToString() == "Consultation")
            {
                _SignUp.rbFRenView.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[3].Value.ToString() == "Non")
            {
                _SignUp.rbFRenView.Checked = false;
                _SignUp.rbFRenAll.Checked = false;
            }
            if (dgvUsersList.CurrentRow.Cells[4].Value.ToString() == "Faire tout")
            {
                _SignUp.rbAttestAll.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[4].Value.ToString() == "Consultation")
            {
                _SignUp.rbAttestView.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[4].Value.ToString() == "Non")
            {
                _SignUp.rbAttestView.Checked = false;
                _SignUp.rbAttestAll.Checked = false;
            }
            if (dgvUsersList.CurrentRow.Cells[5].Value.ToString() == "Faire tout")
            {
                _SignUp.rbCertAll.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[5].Value.ToString() == "Consultation")
            {
                _SignUp.rbCertView.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[5].Value.ToString() == "Non")
            {
                _SignUp.rbCertView.Checked = false;
                _SignUp.rbCertAll.Checked = false;
            }
            if (dgvUsersList.CurrentRow.Cells[6].Value.ToString() == "Faire tout")
            {
                _SignUp.rbCongAll.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[6].Value.ToString() == "Consultation")
            {
                _SignUp.rbCongView.Checked = true;
            }
            else if (dgvUsersList.CurrentRow.Cells[6].Value.ToString() == "Non")
            {
                _SignUp.rbCongView.Checked = false;
                _SignUp.rbCongAll.Checked = false;
            }
            _SignUp.cbStruct.SelectedItem = dgvUsersList.CurrentRow.Cells[7].Value.ToString();
            foreach (var txt in _SignUp.Controls.OfType<TextBox>())
            {
                txt.ReadOnly = true;
            }
            _SignUp.btnAdd.Visible = false;
            _SignUp.Show();
        }

        string user = Settings.Default.userName;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Etes-vous sur de vouloir supprimer cet enregistrement?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    string deleteRow = dgvUsersList.CurrentRow.Cells["name"].Value.ToString();
                    crud.crudop("delete from T_Login where name = '" + deleteRow + "'");

                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Suppression de titre de congé','" + user + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");

                }
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "Rechercher" )
            {
                txtSearch.Text = "";
            }
        }
    }
}
