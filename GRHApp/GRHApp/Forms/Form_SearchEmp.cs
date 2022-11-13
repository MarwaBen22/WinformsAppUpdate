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

namespace GRHApp.Forms
{
    public partial class Form_SearchEmp : Form
    {
        public Form_SearchEmp()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();

        public void clear()
        {
            txtSearch.Text = "Rechercher";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (crud.check_Id("T_Employe", "id_Emp", txtSearch.Text) == "Code exists")
                {
                    if (txtSearch.Text != "")
                    {
                        txtLName.Text = crud.getEmployee(txtSearch.Text, "id_Emp").Item1;
                        txtName.Text = crud.getEmployee(txtSearch.Text, "id_Emp").Item2;
                    }
                }
                else
                {
                    MessageBox.Show("Matricule n'existe pas");
                    clear();
                }
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
                if (txtSearch.Text == "Rechercher")
                {
                    txtSearch.Text = "";
                    txtSearch.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (txtLName.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Veuilez remplir les blans");
            }
            else
            {
                Form_Contract _Contract = new Form_Contract();
                _Contract.txtMatr.Text = txtSearch.Text;
                _Contract.txtLName.Text = txtLName.Text;
                _Contract.txtName.Text = txtName.Text;
                _Contract.Show();
            }
        }
    }
}
