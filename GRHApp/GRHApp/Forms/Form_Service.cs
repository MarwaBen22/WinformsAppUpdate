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
    public partial class Form_Service : Form
    {
        public Form_Service()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();

        public void clear()
        {
            txtStructName.Text = "";
            txtChefStruct.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStructName.Text == "" || txtChefStruct.Text == "")
            {
                MessageBox.Show("Veuillez remplir les blans");
            }
            else
            {
                if (crud.check_Id("T_Structure", "nom_Structure", txtStructName.Text) == "Code exists")
                {
                    MessageBox.Show("Nom de structure existe déja");
                    clear();
                }
                else
                {
                    crud.crudop("insert into T_Structure values (((select max(id_Struct) from T_Structure) + 1),'" + txtChefStruct.Text + "','" + txtStructName.Text + "')");
                    MessageBox.Show("Vos données ont été enregistrées");
                    clear();
                }
            }
        }
    }
}
