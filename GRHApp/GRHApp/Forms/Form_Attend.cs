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

namespace GRHApp.Forms
{
    public partial class Form_Attend : Form
    {
        public Form_Attend()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();

        public void clear()
        {
            dtpToday.ResetText();
            dtpFromTime.ResetText();
            dtpToTime.ResetText();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblLName_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                crud.crudop("update T_Attendance set id_Emp=(select id_Emp from T_Employe where nom='" + txtLName.Text + "'),_date='" + dtpToday.Value.ToShortDateString() + "',partir='" + dtpFromTime.Value.ToShortTimeString() + "',jusque='" + dtpToTime.Value.ToShortTimeString() + "' where id_Emp='" + txtNumber.Text + "'");
                MessageBox.Show("Vos données ont été mises à jour");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Les modifications que vous avez apportées ne seront pas sauvegardées", "Confirmation", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                crud.crudop("insert into T_Attendance values ('" + dtpToday.Value.ToShortDateString() + "','" + dtpFromTime.Value.ToShortTimeString() + "','" + dtpToTime.Value.ToShortTimeString() + "',(select id_Emp from T_Employe where nom='" + txtLName.Text + "'))");
                MessageBox.Show("Vos données ont été enregistrées");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Attend_Load(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
