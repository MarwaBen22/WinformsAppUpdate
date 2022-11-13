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
    public partial class UC_Projects : UserControl
    {
        public UC_Projects()
        {
            InitializeComponent();
            txtProjects.TextChanged += MyTextClickHandler;
        }

        public Delegate Mat8;
        private void MyTextClickHandler(object sender, EventArgs e)
        {
            TextBox ClickedText = (TextBox)sender;
            Mat8.DynamicInvoke(txtProjects.Text);
        }

        private void txtProjects_Click(object sender, EventArgs e)
        {
            txtProjects.TextChanged += MyTextClickHandler;
        }

        private void UC_Projects_Load(object sender, EventArgs e)
        {
            txtProjects.Text = Settings.Default.trax;
        }

        private void UC_Projects_Leave(object sender, EventArgs e)
        {
            Settings.Default.trax = txtProjects.Text;
        }
    }
}
