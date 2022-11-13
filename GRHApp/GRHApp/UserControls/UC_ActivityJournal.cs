using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using GRHApp.Classes;

namespace GRHApp.UserControls
{
    public partial class UC_ActivityJournal : UserControl
    {
        public UC_ActivityJournal()
        {
            InitializeComponent();
            display();
        }

        public void display()
        {
            dgvJournal.DataSource = crud.get();
            dgvJournal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        crudClass crud = new crudClass();
        private void UC_ActivityJournal_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtActNum.Text = "";
            txtActivity.Text = "";
            txtUserName.Text = "";
            dtpActivity.Value = DateTime.Now;
            dtpSearch.Value = DateTime.Now;
            display();
        }

        private void dgvJournal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtActNum.Text = dgvJournal.CurrentRow.Cells[0].Value.ToString();
            txtActivity.Text = dgvJournal.CurrentRow.Cells[1].Value.ToString();
            txtUserName.Text = dgvJournal.CurrentRow.Cells[2].Value.ToString();
            dtpActivity.Text = dgvJournal.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Journal d'activités";
            printer.SubTitle = string.Format(" La date:  {0} ", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Journal d'activités GRH.";
            printer.FooterSpacing = 15;
            //printer.printDocument.DefaultPageSettings.Landscape = true;
            //printer.ColumnWidths.Add("ر_موظف", 200);
            printer.PrintDataGridView(dgvJournal);
        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {
            //dgvJournal.DataSource = crud.searchJournal(dtpSearch.Value.ToString()).Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dateToday = dtpSearch.Value;
            string strDate = dateToday.ToString("yyyy-MM-dd");
            dgvJournal.DataSource = crud.searchJournal(strDate).Tables[0];
        }
    }
}
