using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRHApp.Classes;
using GRHApp.Forms;

namespace GRHApp.UserControls
{
    public partial class UC_Employe : UserControl
    {
        public UC_Employe()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        public void display()
        {
            //dgvEmp.DataSource = crud.get("T_Service");
            //dgvEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void UC_Employe_Load(object sender, EventArgs e)
        {
            try
            {
                cbSearch.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Emp _Emp = new Form_Emp();
            _Emp.cbCivility.SelectedIndex = 3;
            _Emp.cbFamSit.SelectedIndex = 4;
            _Emp.cbService.SelectedIndex = 0;
            _Emp.btnAdd.Visible = true;
            _Emp.btnUpdate.Visible = false;
            _Emp.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Text = "Rechercher";
                txtSearch.ReadOnly = true;
                cbSearch.Items.Insert(2, "Recherche par");
                cbSearch.SelectedIndex = 2;

                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbSearch.SelectedIndex)
                {
                    case 0:
                        if (txtSearch.Text != "")
                        {

                            //dgvEmp.DataSource = crud.search("T_Service", "id_Emp", txtSearch.Text).Tables[0];
                        }
                        break;

                    case 1:
                        if (txtSearch.Text != "")
                        {
                            //dgvEmp.DataSource = crud.search("T_Service", "nom", txtSearch.Text).Tables[0];
                        }
                        break;


                    default:
                        MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Etes-vous sur de vouloir supprimer cet enregistrement?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    string deleteRow = dgvEmp.CurrentRow.Cells["id_Emp"].Value.ToString();
                    crud.crudop("delete from T_Employe where id_Emp = '" + deleteRow + "'");
                }
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtSearch.Text == "Rechercher" && cbSearch.SelectedIndex != 2)
                {
                    txtSearch.Text = "";
                    txtSearch.ReadOnly = false;
                }
                else if (cbSearch.SelectedIndex == 2)
                {
                    MessageBox.Show("Choisissez votre option de recherche s'il vous plait");
                    txtSearch.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form_Emp form_Emp = new Form_Emp();
            form_Emp.txtNumber.Text = dgvEmp.CurrentRow.Cells[0].Value.ToString();
            form_Emp.txtLName.Text = dgvEmp.CurrentRow.Cells[1].Value.ToString();
            form_Emp.txtName.Text = dgvEmp.CurrentRow.Cells[2].Value.ToString();
            form_Emp.dtpBirth.Text = dgvEmp.CurrentRow.Cells[3].Value.ToString();
            form_Emp.txtPBirth.Text = dgvEmp.CurrentRow.Cells[4].Value.ToString();
            form_Emp.cbCivility.Text = dgvEmp.CurrentRow.Cells[5].Value.ToString();
            form_Emp.cbFamSit.Text = dgvEmp.CurrentRow.Cells[6].Value.ToString();
            form_Emp.txtAddress.Text = dgvEmp.CurrentRow.Cells[7].Value.ToString();
            form_Emp.txtEmail.Text = dgvEmp.CurrentRow.Cells[8].Value.ToString();
            form_Emp.txtPhone.Text = dgvEmp.CurrentRow.Cells[9].Value.ToString();
            form_Emp.txtJob.Text = dgvEmp.CurrentRow.Cells[10].Value.ToString();
            form_Emp.cbService.Text = dgvEmp.CurrentRow.Cells[11].Value.ToString();
            form_Emp.dtpJobStart.Text = dgvEmp.CurrentRow.Cells[12].Value.ToString();
            form_Emp.btnAdd.Visible = false;
            form_Emp.btnUpdate.Visible = true;
            form_Emp.Show();
        }

        private void cbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (cbSearch.SelectedIndex == 2)
                    cbSearch.Items.RemoveAt(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
