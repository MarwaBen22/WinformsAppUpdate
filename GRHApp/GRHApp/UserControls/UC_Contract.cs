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

namespace GRHApp.UserControls
{
    public partial class UC_Contract : UserControl
    {
        public UC_Contract()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        public void display()
        {
            dgvContract.DataSource = crud.two_tables("c.num_Contract, c.poste, c.salaire_Base, c.date_Debut, c.date_Fin", "T_Contract");
            dgvContract.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UC_Contract_Load(object sender, EventArgs e)
        {
            try
            {
                cbSearch.SelectedIndex = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_SearchEmp _SearchEmp = new Form_SearchEmp();
            _SearchEmp.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Text = "Rechercher";
                txtSearch.ReadOnly = true;
                cbSearch.Items.Insert(3, "Recherche par");
                cbSearch.SelectedIndex = 3;

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

                            dgvContract.DataSource = crud.search_twoTables("c.num_Contract, c.poste, c.salaire_Base, c.date_Debut, c.date_Fin", "T_Contract", "num_Contract", txtSearch.Text).Tables[0];
                        }
                        break;

                    case 1:
                        if (txtSearch.Text != "")
                        {
                            dgvContract.DataSource = crud.search_twoTables("c.num_Contract, c.poste, c.salaire_Base, c.date_Debut, c.date_Fin", "T_Contract", "nom", txtSearch.Text).Tables[0];
                        }
                        break;

                    case 2:
                        if (txtSearch.Text != "")
                        {
                            dgvContract.DataSource = crud.search_twoTables("c.num_Contract, c.poste, c.salaire_Base, c.date_Debut, c.date_Fin", "T_Contract", "date_Debut", txtSearch.Text).Tables[0];
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
                    string deleteRow = dgvContract.CurrentRow.Cells["num_Contract"].Value.ToString();
                    crud.crudop("delete from T_Contract where num_Contract = '" + deleteRow + "'");
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
                if (txtSearch.Text == "Rechercher" && cbSearch.SelectedIndex != 3)
                {
                    txtSearch.Text = "";
                    txtSearch.ReadOnly = false;
                }
                else if (cbSearch.SelectedIndex == 3)
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
            Form_Contract _Contract = new Form_Contract();
            _Contract.txtMatr.Text = dgvContract.CurrentRow.Cells[0].Value.ToString();
            _Contract.txtLName.Text = dgvContract.CurrentRow.Cells[1].Value.ToString();
            _Contract.txtName.Text = dgvContract.CurrentRow.Cells[2].Value.ToString();
            _Contract.txtNumber.Text = dgvContract.CurrentRow.Cells[3].Value.ToString();
            _Contract.txtPost.Text = dgvContract.CurrentRow.Cells[4].Value.ToString();
            _Contract.txtSalary.Text = dgvContract.CurrentRow.Cells[5].Value.ToString();
            _Contract.dtpConStart.Text = dgvContract.CurrentRow.Cells[6].Value.ToString();
            _Contract.dtpEnd.Text = dgvContract.CurrentRow.Cells[7].Value.ToString();
            _Contract.btnAdd.Visible = false;
            _Contract.btnUpdate.Visible = true;
            _Contract.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string num = dgvContract.CurrentRow.Cells["num_Contract"].Value.ToString();
            crud.openFile(num, "T_Contract", "num_Contract");
        }

        private void cbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (cbSearch.SelectedIndex == 3)
                    cbSearch.Items.RemoveAt(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
