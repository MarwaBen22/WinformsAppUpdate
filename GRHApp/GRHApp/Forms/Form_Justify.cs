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
using GRHApp.Properties;

namespace GRHApp.Forms
{
    public partial class Form_Justify : Form
    {
        public Form_Justify()
        {
            InitializeComponent();
        }

        crudClass crud = new crudClass();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        string userName = Settings.Default.userName;
        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtComment.Text == "")
            {
                MessageBox.Show("Veuillez remplir les blans");
            }
            else
            {
                string chefStruct = crud.getChefStruct(Settings.Default.userName, "l.name").Item1;
                string ChefDAM = crud.getChefStruct("DAM", "nom_Structure").Item1;
                string ChefDG = crud.getChefStruct("DG", "nom_Structure").Item1;
                string fromUser = crud.getAlertInfo(txtAlertId.Text, "id_Alert").Item5;
                if (userName == chefStruct && userName != ChefDAM && userName != ChefDG)
                {
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','" + fromUser + "','Demande refusée', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtnumRef.Text + "')");
                    crud.crudop("delete from T_Alerts where id_Alert='" + txtAlertId.Text + "'");
                    crud.crudop("update T_DRecruit set visa_ChSt1='" + userName + "',dateChst1=CONVERT (datetime, '" + DateTime.Now + "', 121) ,etat='Refusée par chef structure ', statut='Refusé' where num_ref='" + txtnumRef.Text + "'");
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Refusé la demande','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
                }
                else if (userName == ChefDAM && userName != ChefDG)
                {
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','" + fromUser + "','Demande refusée', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtnumRef.Text + "')");
                    crud.crudop("delete from T_Alerts where id_Alert='" + txtAlertId.Text + "'");
                    crud.crudop("update T_DRecruit set visa_DAM='" + userName + "',dateDAM=CONVERT (datetime, '" + DateTime.Now + "', 121) ,etat='Refusée par DAM', statut='Refusé' where num_ref='" + txtnumRef.Text + "'");
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Refusé la demande','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
                }
                else if (userName == ChefDG)
                {
                    crud.crudop("insert into T_Alerts values (((select max(id_Alert) from T_Alerts) + 1),'" + userName + "','" + fromUser + "','Demande refusée', CONVERT (datetime, '" + DateTime.Now + "', 121),'En attente','" + txtnumRef.Text + "')");
                    crud.crudop("delete from T_Alerts where id_Alert='" + txtAlertId.Text + "'");
                    crud.crudop("update T_DRecruit set visa_DG='" + userName + "',date_DG=CONVERT (datetime, '" + DateTime.Now + "', 121),etat='Refusée par DG', statut='Refusé' where num_ref='" + txtnumRef.Text + "'");
                    crud.crudop("insert into T_Journal values (((select max(id_Journal) from T_Journal) + 1), 'Refusé la demande','" + userName + "',CONVERT (datetime, '" + DateTime.Now + "', 121))");
                }
                
                crud.crudop("update T_DRecruit set commentaire='" + txtComment.Text + "' where num_ref='" + txtnumRef.Text + "'");
                MessageBox.Show("Vos données ont été enregistrées");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
