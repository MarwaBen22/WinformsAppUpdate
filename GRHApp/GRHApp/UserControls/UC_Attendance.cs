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
    public partial class UC_Attendance : UserControl
    {
        public UC_Attendance()
        {
            InitializeComponent();
            display();
        }

        crudClass crud = new crudClass();

        public void display()
        {
            dgvAttendance.DataSource = crud.att_Table("c._date, c.partir, c.jusque", "T_Attendance");
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UC_Attendance_Load(object sender, EventArgs e)
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
            Form_Attend _Attend = new Form_Attend();
            _Attend.txtNumber.Text = dgvAttendance.CurrentRow.Cells[0].Value.ToString();
            _Attend.txtLName.Text = dgvAttendance.CurrentRow.Cells[1].Value.ToString();
            _Attend.txtName.Text = dgvAttendance.CurrentRow.Cells[2].Value.ToString();
            _Attend.btnAdd.Visible = true;
            _Attend.btnUpdate.Visible = false;
            _Attend.Show();
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

                            dgvAttendance.DataSource = crud.search_attTable("c._date, c.partir, c.jusque", "T_Attendance", "nom", txtSearch.Text).Tables[0];
                        }
                        break;

                    case 1:
                        if (txtSearch.Text != "")
                        {
                            dgvAttendance.DataSource = crud.search_attTable("c._date, c.partir, c.jusque", "T_Attendance", "_date", txtSearch.Text).Tables[0];
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
            Form_Attend _Attend = new Form_Attend();
            _Attend.txtNumber.Text = dgvAttendance.CurrentRow.Cells[0].Value.ToString();
            _Attend.txtLName.Text = dgvAttendance.CurrentRow.Cells[1].Value.ToString();
            _Attend.txtName.Text = dgvAttendance.CurrentRow.Cells[2].Value.ToString();
            _Attend.dtpToday.Text = dgvAttendance.CurrentRow.Cells[3].Value.ToString();
            _Attend.dtpFromTime.Text = dgvAttendance.CurrentRow.Cells[4].Value.ToString();
            _Attend.dtpToTime.Text = dgvAttendance.CurrentRow.Cells[5].Value.ToString();
            _Attend.btnAdd.Visible = false;
            _Attend.btnUpdate.Visible = true;
            _Attend.Show();
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
    }
}
