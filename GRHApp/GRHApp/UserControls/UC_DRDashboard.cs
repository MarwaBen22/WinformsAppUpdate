using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRHApp.Classes;

namespace GRHApp.UserControls
{
    public partial class UC_DRDashboard : UserControl
    {
        private dashboardClass model;
        public UC_DRDashboard()
        {
            InitializeComponent();
            DisableCustomDates();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            model = new dashboardClass();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                
                chartDRTotal.DataSource = model.FRList;
                chartDRTotal.Series[0].XValueMember = "Date";
                chartDRTotal.Series[0].YValueMembers = "TotalAmount";
                chartDRTotal.DataBind();

                chartDRStruct.DataSource = model.TopStructList;
                chartDRStruct.Series[0].XValueMember = "Key";
                chartDRStruct.Series[0].YValueMembers = "Value";
                chartDRStruct.DataBind();

                chartDRStatut.DataSource = model.StututList;
                chartDRStatut.Series[0].XValueMember = "Key";
                chartDRStatut.Series[0].YValueMembers = "Value";
                chartDRStatut.DataBind();

                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }
        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void UC_DRDashboard_Load(object sender, EventArgs e)
        {
            
        }

        void PrintChart(object sender, PrintPageEventArgs ev)
        {
            using (var f = new System.Drawing.Font("Arial", 10))
            {
                var size = ev.Graphics.MeasureString(Text, f);
                ev.Graphics.DrawString("La date" + DateTime.Now, f, Brushes.Black, ev.PageBounds.X + (ev.PageBounds.Width - size.Width) / 2, ev.PageBounds.Y);
            }

            //Note, the chart printing code wants to print in pixels.
            Rectangle marginBounds = ev.MarginBounds;
            if (ev.Graphics.PageUnit != GraphicsUnit.Pixel)
            {
                ev.Graphics.PageUnit = GraphicsUnit.Pixel;
                marginBounds.X = (int)(marginBounds.X * (ev.Graphics.DpiX / 100f));
                marginBounds.Y = (int)(marginBounds.Y * (ev.Graphics.DpiY / 100f));
                marginBounds.Width = (int)(marginBounds.Width * (ev.Graphics.DpiX / 100f));
                marginBounds.Height = (int)(marginBounds.Height * (ev.Graphics.DpiY / 100f));
            }
            if (combCharts.SelectedIndex == 0)
            {
                chartDRTotal.Printing.PrintPaint(ev.Graphics, marginBounds);
            }
            else if (combCharts.SelectedIndex == 1)
            {
                chartDRStatut.Printing.PrintPaint(ev.Graphics, marginBounds);
            }
            else if (combCharts.SelectedIndex == 2)
            {
                chartDRStruct.Printing.PrintPaint(ev.Graphics, marginBounds);
            }
            else
            {
                MessageBox.Show("Veuillez choisir un diagramme à imprimer");
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            var pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintChart);

            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
                pdi.Document.Print();
        }
    }
}
