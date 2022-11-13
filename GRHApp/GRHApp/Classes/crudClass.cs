using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRHApp.Classes
{
    class crudClass
    {
        //SqlConnection cnx = new SqlConnection(@"Data Source=INFORMATIQUE-PC\SQLEXPRESS;Initial Catalog=GRHdb;Integrated Security=True");
        SqlConnection cnx = new SqlConnection(@"Data Source=192.168.1.2,49170;Initial Catalog=GRHdb;User ID=sa;Password=02101996k+");


        public string check_PW(string userName, string password)
        {
            SqlCommand cmd = new SqlCommand("select * from T_Login where name='" + userName + "'AND user_PW='" + password + "'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                return "all correct";
            }
            else
            {
                return "something's wrong";
            }
        }

        public string check_Id(string table, string colName, string colValue)
        {
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select " + colName + " from " + table + " where " + colName + "='" + colValue + "'", cnx);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            cnx.Close();
            if (dt.Rows.Count >= 1)
            {
                return "Code exists";
            }
            else
            {
                return "Code doesn't exist";
            }
        }

        public void crudop(string query)
        {
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlCommand cmd = new SqlCommand(query, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public DataTable get()
        {
            DataTable dt = new DataTable();
            cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select * from T_Journal", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }
        public DataSet searchJournal(string searchTxt)
        {
            SqlCommand cmd = new SqlCommand("Select * from T_Journal where CAST(date_Activité as date) like N'" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }
        public DataSet search(string searchWith, string searchTxt)
        {
            SqlCommand cmd = new SqlCommand("Select id_Emp, nom, prenom, date_Naissance, lieu_Naissance, adresse, téléphone, num_Carte, délivré, déliv_Le, date_Doc from T_EmployeInfo where " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }

        public DataTable getCustom(string query)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter(query, cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }
        public DataTable get0(string table)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("Select * from " + table, cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }
        public DataTable get00(string table)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from " + table, cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }
        public DataTable get1(string chefDep)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from T_DRecruit where créé_par='" + chefDep + "' or visa_ChSt1='" + chefDep + "'", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }

        public DataTable get2(string currentUser)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from T_DRecruit where créé_par='" + currentUser + "'", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }

        public DataTable get3(string chefDAM)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from T_DRecruit where créé_par='" + chefDAM + "' or visa_DAM='" + chefDAM + "'", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }
        public DataTable get4(string DG)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from T_DRecruit where créé_par='" + DG + "' or visa_DG='" + DG + "'", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }
        public DataTable getUser()
        {
            DataTable dt = new DataTable();
            cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("Select l.name, l.user_Email, l.grh_DRec, l.grh_FRen, l.grh_ATravail, l.grh_CTravail, l.grh_TConge, s.nom_Structure from T_Login l left join T_Structure s on l.id_Struct=s.id_Struct", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }

        public DataSet searchUser(string searchWith, string searchTxt)
        {
            
            SqlCommand cmd = new SqlCommand("Select l.name, l.user_Email, l.grh_DRec, l.grh_FRen, l.grh_ATravail, l.grh_CTravail, l.grh_TConge, s.nom_Structure from T_Login l left join T_Structure s on l.id_Struct=s.id_Struct where " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }

        public DataSet searchCustom(string columns, string searchWith, string searchTxt, string table)
        {
            SqlCommand cmd = new SqlCommand("Select " + columns + " from " + table + " where " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }
        public DataSet search0(string searchWith, string searchTxt, string table)
        {
            SqlCommand cmd = new SqlCommand("Select * from " + table + " where " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }
        public DataSet search00(string searchWith, string searchTxt, string table)
        {
            SqlCommand cmd = new SqlCommand("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from " + table + " where " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }
        public DataSet search1(string searchWith, string searchTxt, string chefStr)
        {
            SqlCommand cmd = new SqlCommand("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from T_DRecruit where créé_par='" + chefStr + "' or visa_ChSt1='" + chefStr + "' and " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }
        public DataSet search2(string searchWith, string searchTxt, string currUsr)
        {
            SqlCommand cmd = new SqlCommand("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from T_DRecruit where créé_par='" + currUsr + "' and " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }

        public DataSet search4(string searchWith, string searchTxt, string dirGen)
        {
            SqlCommand cmd = new SqlCommand("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from T_DRecruit where créé_par='" + dirGen + "' or visa_DG='" + dirGen + "' and " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }
        public DataSet search3(string searchWith, string searchTxt, string chfDAM)
        {
            SqlCommand cmd = new SqlCommand("select num_ref, poste_Travail, nombre, formation, age, sexe, motif, nature_PostTravail, projets, lieu_Travail, formation_Base, expérience, langues, résidence, permis_Conduire, disponibilité, logiciels, autre_Compétence, opportunité, approbation_DG, créé_le, créé_par, modifié_le, modifié_par, etat, commentaire, dateChst1, visa_ChSt1, dateDAM, visa_DAM, date_CG, visa_CG, date_DG, visa_DG, date_GRH1, visa_GRH1, statut from T_DRecruit where créé_par='" + chfDAM + "' or visa_DAM='" + chfDAM + "' and " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }
        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getRecruitInfo(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_DRecruit r left join T_Condidats c on r.num_ref=c.num_ref where r." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var idCand = dt.Rows[0]["id_Candi"];
                    var cand = dt.Rows[0]["nom_Candidat"];
                    var idCand1 = dt.Rows[1]["id_Candi"];
                    var cand1 = dt.Rows[1]["nom_Candidat"];
                    var idCand2 = dt.Rows[2]["id_Candi"];
                    var cand2 = dt.Rows[2]["nom_Candidat"];
                    var idCand3 = dt.Rows[3]["id_Candi"];
                    var cand3 = dt.Rows[3]["nom_Candidat"];
                    var idCand4 = dt.Rows[4]["id_Candi"];
                    var cand4 = dt.Rows[4]["nom_Candidat"];
                    var idCand5 = dt.Rows[5]["id_Candi"];
                    var cand5 = dt.Rows[5]["nom_Candidat"];
                    var idCand6 = dt.Rows[6]["id_Candi"];
                    var cand6 = dt.Rows[6]["nom_Candidat"];
                    var idCand7 = dt.Rows[7]["id_Candi"];
                    var cand7 = dt.Rows[7]["nom_Candidat"];
                    var idCand8 = dt.Rows[8]["id_Candi"];
                    var cand8 = dt.Rows[8]["nom_Candidat"];
                    var idCand9 = dt.Rows[9]["id_Candi"];
                    var cand9 = dt.Rows[9]["nom_Candidat"];
                    var idCand10 = dt.Rows[10]["id_Candi"];
                    var cand10 = dt.Rows[10]["nom_Candidat"];
                    var idCand11 = dt.Rows[11]["id_Candi"];
                    var cand11 = dt.Rows[11]["nom_Candidat"];
                    var idCand12 = dt.Rows[12]["id_Candi"];
                    var cand12 = dt.Rows[12]["nom_Candidat"];
                    var idCand13 = dt.Rows[13]["id_Candi"];
                    var cand13 = dt.Rows[13]["nom_Candidat"];
                    var idCand14 = dt.Rows[14]["id_Candi"];
                    var cand14 = dt.Rows[14]["nom_Candidat"];
                    var idCand15 = dt.Rows[15]["id_Candi"];
                    var cand15 = dt.Rows[15]["nom_Candidat"];
                    var idCand16 = dt.Rows[16]["id_Candi"];
                    var cand16 = dt.Rows[16]["nom_Candidat"];
                    var idCand17 = dt.Rows[17]["id_Candi"];
                    var cand17 = dt.Rows[17]["nom_Candidat"];
                    var idCand18 = dt.Rows[18]["id_Candi"];
                    var cand18 = dt.Rows[18]["nom_Candidat"];
                    var idCand19 = dt.Rows[19]["id_Candi"];
                    var cand19 = dt.Rows[19]["nom_Candidat"];
                    var idCand20 = dt.Rows[20]["id_Candi"];
                    var cand20 = dt.Rows[20]["nom_Candidat"];
                    var idCand21 = dt.Rows[21]["id_Candi"];
                    var cand21 = dt.Rows[21]["nom_Candidat"];
                    var idCand22 = dt.Rows[22]["id_Candi"];
                    var cand22 = dt.Rows[22]["nom_Candidat"];
                    var idCand23 = dt.Rows[23]["id_Candi"];
                    var cand23 = dt.Rows[23]["nom_Candidat"];
                    var idCand24 = dt.Rows[24]["id_Candi"];
                    var cand24 = dt.Rows[24]["nom_Candidat"];
                    var idCand25 = dt.Rows[25]["id_Candi"];
                    var cand25 = dt.Rows[25]["nom_Candidat"];
                    var idCand26 = dt.Rows[26]["id_Candi"];
                    var cand26 = dt.Rows[26]["nom_Candidat"];
                    var idCand27 = dt.Rows[27]["id_Candi"];
                    var cand27 = dt.Rows[27]["nom_Candidat"];
                    var idCand28 = dt.Rows[28]["id_Candi"];
                    var cand28 = dt.Rows[28]["nom_Candidat"];
                    var idCand29 = dt.Rows[29]["id_Candi"];
                    var cand29 = dt.Rows[29]["id_Candi"];

                    return (idCand.ToString(), cand.ToString(), idCand1.ToString(), cand1.ToString(), idCand2.ToString(), cand2.ToString(), idCand3.ToString(), cand3.ToString(), idCand4.ToString(), cand4.ToString(), idCand5.ToString(), cand5.ToString(), idCand6.ToString(), cand6.ToString(), idCand7.ToString(), cand7.ToString(), idCand8.ToString(), cand8.ToString(), idCand9.ToString(), cand9.ToString(), idCand10.ToString(), cand10.ToString(), idCand11.ToString(), cand11.ToString(), idCand12.ToString(), cand12.ToString(), idCand13.ToString(), cand13.ToString(), idCand14.ToString(), cand14.ToString(), idCand15.ToString(), cand15.ToString(), idCand16.ToString(), cand16.ToString(), idCand17.ToString(), cand17.ToString(), idCand18.ToString(), cand18.ToString(), idCand19.ToString(), cand19.ToString(), idCand20.ToString(), cand20.ToString(), idCand21.ToString(), cand21.ToString(), idCand22.ToString(), cand22.ToString(), idCand23.ToString(), cand23.ToString(), idCand24.ToString(), cand24.ToString(), idCand25.ToString(), cand25.ToString(), idCand26.ToString(), cand26.ToString(), idCand27.ToString(), cand27.ToString(), idCand28.ToString(), cand28.ToString(), idCand29.ToString(), cand29.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");       
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getRecruitInfo0(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_DRecruit r left join T_RenseignCandidat c on r.num_ref=c.num_ref where r." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var candReId = dt.Rows[0]["id_Renseig"];
                    var candRe = dt.Rows[0]["cand_Retenue"];
                    var forBase = dt.Rows[0]["form_Base"];
                    var forComp = dt.Rows[0]["form_Comp"];
                    var residen = dt.Rows[0]["réside_Rensei"];
                    var sitFam = dt.Rows[0]["sit_Fam"];
                    var exp = dt.Rows[0]["expéri_Rensi"];
                    var candReId1 = dt.Rows[1]["id_Renseig"];
                    var candRe1 = dt.Rows[1]["cand_Retenue"];
                    var forBase1 = dt.Rows[1]["form_Base"];
                    var forComp1 = dt.Rows[1]["form_Comp"];
                    var residen1 = dt.Rows[1]["réside_Rensei"];
                    var sitFam1 = dt.Rows[1]["sit_Fam"];
                    var exp1 = dt.Rows[1]["expéri_Rensi"];
                    var candReId2 = dt.Rows[2]["id_Renseig"];
                    var candRe2 = dt.Rows[2]["cand_Retenue"];
                    var forBase2 = dt.Rows[2]["form_Base"];
                    var forComp2 = dt.Rows[2]["form_Comp"];
                    var residen2 = dt.Rows[2]["réside_Rensei"];
                    var sitFam2 = dt.Rows[2]["sit_Fam"];
                    var exp2 = dt.Rows[2]["expéri_Rensi"];
                    var candReId3 = dt.Rows[3]["id_Renseig"];
                    var candRe3 = dt.Rows[3]["cand_Retenue"];
                    var forBase3 = dt.Rows[3]["form_Base"];
                    var forComp3 = dt.Rows[3]["form_Comp"];
                    var residen3 = dt.Rows[3]["réside_Rensei"];
                    var sitFam3 = dt.Rows[3]["sit_Fam"];
                    var exp3 = dt.Rows[3]["expéri_Rensi"];

                    return (candReId.ToString(), candRe.ToString(), forBase.ToString(), forComp.ToString(), residen.ToString(), sitFam.ToString(), exp.ToString(), candReId1.ToString(), candRe1.ToString(), forBase1.ToString(), forComp1.ToString(), residen1.ToString(), sitFam1.ToString(), exp1.ToString(), candReId2.ToString(), candRe2.ToString(), forBase2.ToString(), forComp2.ToString(), residen2.ToString(), sitFam2.ToString(), exp2.ToString(), candReId3.ToString(), candRe3.ToString(), forBase3.ToString(), forComp3.ToString(), residen3.ToString(), sitFam3.ToString(), exp3.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }
        public DataTable two_tables(string colNames, string table2)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("Select e.id_Emp,e.nom, e.prenom, " + colNames + " from " + table2 + " c inner join T_EmployeInfo e on c.id_Emp=e.id_Emp", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }

        public DataSet search_twoTables(string colNames, string table2, string searchWith, string searchTxt)
        {
            SqlCommand cmd = new SqlCommand("select e.id_Emp,e.nom, e.prenom, " + colNames + " from " + table2 + " c left join T_EmployeInfo e on c.id_Emp=e.id_Emp where " + searchWith + " like '" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }

        public (string, string, string, string, string, string, string) getEmployee(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e left join T_Contrat t on e.id_Emp=t.id_Emp where " + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["nom"].ToString(), dr["prenom"].ToString(), dr["date_Naissance"].ToString(), dr["lieu_Naissance"].ToString(), dr["adresse"].ToString(), dr["fonction"].ToString(), dr["date_Engage"].ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "");
            }
        }

        public void saveFile(string filePath, string num, string id, string post,string salaire, DateTime dateD, DateTime dateFin)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string fileName = fi.Name;

                string query = "insert into T_Contract values (@num, @id_Emp, @post, @salaire, @dateD, @dateFin, @data, @extn, @fileName)";

                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
                cmd.Parameters.Add("@id_Emp", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@post", SqlDbType.VarChar).Value = post;
                cmd.Parameters.Add("@salaire", SqlDbType.VarChar).Value = salaire;
                cmd.Parameters.Add("@dateD", SqlDbType.Date).Value = dateD;
                cmd.Parameters.Add("@dateFin", SqlDbType.Date).Value = dateFin;
                cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                cmd.Parameters.Add("@fileName", SqlDbType.VarChar).Value = fileName;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void saveFile0(string filePath, string num, string table, string numRef)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string fileName = fi.Name;

                //string query = "insert into T_Contract values (@num, @id_Emp, @post, @salaire, @dateD, @dateFin, @data, @extn, @fileName)";
                string query = "update " + table + " set doc_Data=@data, doc_Extn=@extn, file_Name=@fileName where " + numRef + "=@num";

                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
                cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                cmd.Parameters.Add("@fileName", SqlDbType.VarChar).Value = fileName;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void openFile(string num, string table, string id)
        {
            string query = "select * from " + table + " where " + id + " = @num";
            SqlCommand cmd = new SqlCommand(query, cnx);
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var name = reader["file_Name"].ToString();
                var data = (byte[])reader["doc_Data"];
                var extn = reader["doc_Extn"].ToString();
                var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyy")) + extn;
                File.WriteAllBytes(newFileName, data);
                System.Diagnostics.Process.Start(newFileName);
            }
            cnx.Close();
        }

        public DataTable att_Table(string colNames, string table2)
        {
            DataTable dt = new DataTable();
            cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("Select e.id_Emp,e.nom, e.prenom, " + colNames + " from " + table2 + " c right join T_EmployeInfo e on c.id_Emp=e.id_Emp", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }

        public DataSet search_attTable(string colNames, string table2, string searchWith, string searchTxt)
        {
            SqlCommand cmd = new SqlCommand("select e.id_Emp,e.nom, e.prenom, " + colNames + " from " + table2 + " c right join T_EmployeInfo e on c.id_Emp=e.id_Emp where " + searchWith + " like N'" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }

        public DataTable multi_tables()
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("Select id_Emp, nom, prenom, date_Naissance, lieu_Naissance, adresse, téléphone, num_Carte, délivré, déliv_Le, date_Doc from T_EmployeInfo", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }

        public DataTable more_tables(string colNames, string secTable, string thirTable)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("Select e.id_Emp, e.nom, e.prenom, " + colNames + " from " + secTable + " c inner join T_EmployeInfo e on c.id_Emp=e.id_Emp "+ thirTable +"", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }

        public DataSet search_moreTables(string colNames, string secTable, string thirTable, string searchWith, string searchTxt)
        {
            SqlCommand cmd = new SqlCommand("Select e.id_Emp, e.nom, e.prenom, " + colNames + " from " + secTable + " c inner join T_EmployeInfo e on c.id_Emp=e.id_Emp " + thirTable + " where " + searchWith + " like N'" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }

        public DataSet search_multiTables(string colNames, string table2, string searchWith, string searchTxt)
        {
            SqlCommand cmd = new SqlCommand("select e.id_Emp,e.nom, e.prenom from " + table2 + " c left join T_EmployeInfo e on c.id_Emp=e.id_Emp where " + searchWith + " like N'" + searchTxt + "%'", cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeInfo(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_NiveauSco n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_NivSco = dt.Rows[0]["id_Niv"];
                    var eta = dt.Rows[0]["etablissement"];
                    var spe = dt.Rows[0]["spécialité"];
                    var per = dt.Rows[0]["période"];
                    var dip = dt.Rows[0]["diplome"];
                    var annObt = dt.Rows[0]["année_Obtention"];
                    var id_NivSco1 = dt.Rows[1]["id_Niv"];
                    var eta1 = dt.Rows[1]["etablissement"];
                    var spe1 = dt.Rows[1]["spécialité"];
                    var per1 = dt.Rows[1]["période"];
                    var dip1 = dt.Rows[1]["diplome"];
                    var annObt1 = dt.Rows[1]["année_Obtention"];
                    var id_NivSco2 = dt.Rows[2]["id_Niv"];
                    var eta2 = dt.Rows[2]["etablissement"];
                    var spe2 = dt.Rows[2]["spécialité"];
                    var per2 = dt.Rows[2]["période"];
                    var dip2 = dt.Rows[2]["diplome"];
                    var annObt2 = dt.Rows[2]["année_Obtention"];
                    var id_NivSco3 = dt.Rows[3]["id_Niv"];
                    var eta3 = dt.Rows[3]["etablissement"];
                    var spe3 = dt.Rows[3]["spécialité"];
                    var per3 = dt.Rows[3]["période"];
                    var dip3 = dt.Rows[3]["diplome"];
                    var annObt3 = dt.Rows[3]["année_Obtention"];
                    return (dr["id_Emp"].ToString(), dr["nom"].ToString(), dr["prenom"].ToString(), dr["nom_JeuneFille"].ToString(), dr["date_Naissance"].ToString(), dr["lieu_Naissance"].ToString(), dr["sit_Familiale"].ToString(), dr["nationalité"].ToString(), dr["adresse"].ToString(), dr["téléphone"].ToString(), dr["prenom_Pere"].ToString(), dr["nom_Mere"].ToString(), dr["gr_Sanguin"].ToString(), dr["prof_Pere"].ToString(), dr["prof_Mere"].ToString(), dr["nombre_Frères"].ToString(), dr["nom_Conjoint"].ToString(), dr["date_Mariage"].ToString(), dr["prof_Conjoint"].ToString(), dr["nombre_Enfants"].ToString(), dr["num_Compte"].ToString(), dr["num_Sécurité"].ToString(), dr["num_Carte"].ToString(), dr["délivré"].ToString(), dr["déliv_Le"].ToString(), dr["dagagé"].ToString(), dr["date_Immobilisation"].ToString(), dr["sursitaire_Du"].ToString(), dr["sursitaire_Au"].ToString(), dr["apte_NonIncorp"].ToString(), dr["origine_Deman"].ToString(), dr["date_Doc"].ToString(), dr["origine_Choi"].ToString(), eta.ToString(), spe.ToString(), per.ToString(), dip.ToString(), annObt.ToString(), eta1.ToString(), spe1.ToString(), per1.ToString(), dip1.ToString(), annObt1.ToString(), eta2.ToString(), spe2.ToString(), per2.ToString(), dip2.ToString(), annObt2.ToString(), eta3.ToString(), spe3.ToString(), per3.ToString(), dip3.ToString(), annObt3.ToString(), id_NivSco.ToString(), dr["nom_Utilisateur"].ToString(), id_NivSco1.ToString(), id_NivSco2.ToString(), id_NivSco3.ToString());
                }
                cnx.Close();
                return ("","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeProfStudy(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_EnseiProf n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_EnsProf = dt.Rows[0]["id_Ensei"];
                    var etab = dt.Rows[0]["etablissement"];
                    var spec = dt.Rows[0]["spécialité"];
                    var peri = dt.Rows[0]["période"];
                    var dipl = dt.Rows[0]["diplome"];
                    var annObte = dt.Rows[0]["année_Obtention"];
                    var id_EnsProf1 = dt.Rows[1]["id_Ensei"];
                    var etab1 = dt.Rows[1]["etablissement"];
                    var spec1 = dt.Rows[1]["spécialité"];
                    var peri1 = dt.Rows[1]["période"];
                    var dipl1 = dt.Rows[1]["diplome"];
                    var annObte1 = dt.Rows[1]["année_Obtention"];
                    var id_EnsProf2 = dt.Rows[2]["id_Ensei"];
                    var etab2 = dt.Rows[2]["etablissement"];
                    var spec2 = dt.Rows[2]["spécialité"];
                    var peri2 = dt.Rows[2]["période"];
                    var dipl2 = dt.Rows[2]["diplome"];
                    var annObte2 = dt.Rows[2]["année_Obtention"];
                    var id_EnsProf3 = dt.Rows[3]["id_Ensei"];
                    var etab3 = dt.Rows[3]["etablissement"];
                    var spec3 = dt.Rows[3]["spécialité"];
                    var peri3 = dt.Rows[3]["période"];
                    var dipl3 = dt.Rows[3]["diplome"];
                    var annObte3 = dt.Rows[3]["année_Obtention"];
                    return (etab.ToString(), spec.ToString(), peri.ToString(), dipl.ToString(), annObte.ToString(), etab1.ToString(), spec1.ToString(), peri1.ToString(), dipl1.ToString(), annObte1.ToString(), etab2.ToString(), spec2.ToString(), peri2.ToString(), dipl2.ToString(), annObte2.ToString(), etab3.ToString(), spec3.ToString(), peri3.ToString(), dipl3.ToString(), annObte3.ToString(), id_EnsProf.ToString(), id_EnsProf1.ToString(), id_EnsProf2.ToString(), id_EnsProf3.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeTrainings(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Stages n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Stage = dt.Rows[0]["id_Stag"];
                    var etabl = dt.Rows[0]["etablissement"];
                    var speci = dt.Rows[0]["spécialité"];
                    var perio = dt.Rows[0]["période"];
                    var diplo = dt.Rows[0]["diplome"];
                    var annObten = dt.Rows[0]["année_Obtention"];
                    var id_Stage1 = dt.Rows[1]["id_Stag"];
                    var etabl1 = dt.Rows[1]["etablissement"];
                    var speci1 = dt.Rows[1]["spécialité"];
                    var perio1 = dt.Rows[1]["période"];
                    var diplo1 = dt.Rows[1]["diplome"];
                    var annObten1 = dt.Rows[1]["année_Obtention"];
                    var id_Stage2 = dt.Rows[2]["id_Stag"];
                    var etabl2 = dt.Rows[2]["etablissement"];
                    var speci2 = dt.Rows[2]["spécialité"];
                    var perio2 = dt.Rows[2]["période"];
                    var diplo2 = dt.Rows[2]["diplome"];
                    var annObten2 = dt.Rows[2]["année_Obtention"];
                    var id_Stage3 = dt.Rows[3]["id_Stag"];
                    var etabl3 = dt.Rows[3]["etablissement"];
                    var speci3 = dt.Rows[3]["spécialité"];
                    var perio3 = dt.Rows[3]["période"];
                    var diplo3 = dt.Rows[3]["diplome"];
                    var annObten3 = dt.Rows[3]["année_Obtention"];
                    return (etabl.ToString(), speci.ToString(), perio.ToString(), diplo.ToString(), annObten.ToString(), etabl1.ToString(), speci1.ToString(), perio1.ToString(), diplo1.ToString(), annObten1.ToString(), etabl2.ToString(), speci2.ToString(), perio2.ToString(), diplo2.ToString(), annObten2.ToString(), etabl3.ToString(), speci3.ToString(), perio3.ToString(), diplo3.ToString(), annObten3.ToString(), id_Stage.ToString(), id_Stage1.ToString(), id_Stage2.ToString(), id_Stage3.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeCareer(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Carriere n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Carri = dt.Rows[0]["id_Carr"];
                    var emp = dt.Rows[0]["employeur"];
                    var job = dt.Rows[0]["emploi"];
                    var dateDebut = dt.Rows[0]["date_Debut"];
                    var dateFin = dt.Rows[0]["date_Fin"];
                    var MotifDep = dt.Rows[0]["motif_Depart"];
                    var id_Carri1 = dt.Rows[1]["id_Carr"];
                    var emp1 = dt.Rows[1]["employeur"];
                    var job1 = dt.Rows[1]["emploi"];
                    var dateDebut1 = dt.Rows[1]["date_Debut"];
                    var dateFin1 = dt.Rows[1]["date_Fin"];
                    var MotifDep1 = dt.Rows[1]["motif_Depart"];
                    var id_Carri2 = dt.Rows[2]["id_Carr"];
                    var emp2 = dt.Rows[2]["employeur"];
                    var job2 = dt.Rows[2]["emploi"];
                    var dateDebut2 = dt.Rows[2]["date_Debut"];
                    var dateFin2 = dt.Rows[2]["date_Fin"];
                    var MotifDep2 = dt.Rows[2]["motif_Depart"];
                    var id_Carri3 = dt.Rows[3]["id_Carr"];
                    var emp3 = dt.Rows[3]["employeur"];
                    var job3 = dt.Rows[3]["emploi"];
                    var dateDebut3 = dt.Rows[3]["date_Debut"];
                    var dateFin3 = dt.Rows[3]["date_Fin"];
                    var MotifDep3 = dt.Rows[3]["motif_Depart"];

                    return (emp.ToString(), job.ToString(), dateDebut.ToString(), dateFin.ToString(), MotifDep.ToString(), emp1.ToString(), job1.ToString(), dateDebut1.ToString(), dateFin1.ToString(), MotifDep1.ToString(), emp2.ToString(), job2.ToString(), dateDebut2.ToString(), dateFin2.ToString(), MotifDep2.ToString(), emp3.ToString(), job3.ToString(), dateDebut3.ToString(), dateFin3.ToString(), MotifDep3.ToString(), id_Carri.ToString(), id_Carri1.ToString(), id_Carri2.ToString(), id_Carri3.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }
        public (string, string, string, string, string, string) getEmployeeLanguages(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Langue n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["francais"].ToString(), dr["arabe"].ToString(), dr["anglais"].ToString(), dr["allemand"].ToString(), dr["autre"].ToString(), dr["niv_Autre"].ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "");
            }
        }
        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeSoftware(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Logiciel n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Logi = dt.Rows[0]["id_Log"];
                    var log = dt.Rows[0]["nom_Logiciel"];
                    var logForm = dt.Rows[0]["formation"];
                    var logNiv = dt.Rows[0]["niveau"];
                    var id_Logi1 = dt.Rows[1]["id_Log"];
                    var log1 = dt.Rows[1]["nom_Logiciel"];
                    var logForm1 = dt.Rows[1]["formation"];
                    var logNiv1 = dt.Rows[1]["niveau"];
                    var id_Logi2 = dt.Rows[2]["id_Log"];
                    var log2 = dt.Rows[2]["nom_Logiciel"];
                    var logForm2 = dt.Rows[2]["formation"];
                    var logNiv2 = dt.Rows[2]["niveau"];
                    var id_Logi3 = dt.Rows[3]["id_Log"];
                    var log3 = dt.Rows[3]["nom_Logiciel"];
                    var logForm3 = dt.Rows[3]["formation"];
                    var logNiv3 = dt.Rows[3]["niveau"];

                    return (log.ToString(), logForm.ToString(), logNiv.ToString(), log1.ToString(), logForm1.ToString(), logNiv1.ToString(), log2.ToString(), logForm2.ToString(), logNiv2.ToString(), log3.ToString(), logForm3.ToString(), logNiv3.ToString(), id_Logi.ToString(), id_Logi1.ToString(), id_Logi2.ToString(), id_Logi3.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public string getEmployeeProjects(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Projets n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["projets"].ToString());
                }
                cnx.Close();
                return ("");
            }
            else
            {
                return ("");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeIntersets(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Intéret n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Inter = dt.Rows[0]["id_Inter"];
                    var inter = dt.Rows[0]["centre_Intéret"];
                    var id_Inter1 = dt.Rows[1]["id_Inter"];
                    var inter1 = dt.Rows[1]["centre_Intéret"];
                    var id_Inter2 = dt.Rows[2]["id_Inter"];
                    var inter2 = dt.Rows[2]["centre_Intéret"];
                    var id_Inter3 = dt.Rows[3]["id_Inter"];
                    var inter3 = dt.Rows[3]["centre_Intéret"];
                    var id_Inter4 = dt.Rows[4]["id_Inter"];
                    var inter4 = dt.Rows[4]["centre_Intéret"];
                    var id_Inter5 = dt.Rows[5]["id_Inter"];
                    var inter5 = dt.Rows[5]["centre_Intéret"];
                    var id_Inter6 = dt.Rows[6]["id_Inter"];
                    var inter6 = dt.Rows[6]["centre_Intéret"];
                    var id_Inter7 = dt.Rows[7]["id_Inter"];
                    var inter7 = dt.Rows[7]["centre_Intéret"];

                    return (inter.ToString(), inter1.ToString(), inter2.ToString(), inter3.ToString(), inter4.ToString(), inter5.ToString(), inter6.ToString(), inter7.ToString(), id_Inter.ToString(), id_Inter1.ToString(), id_Inter2.ToString(), id_Inter3.ToString(), id_Inter4.ToString(), id_Inter5.ToString(), id_Inter6.ToString(), id_Inter7.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string) getEmployeeAcquitance(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Connaissance n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Conn = dt.Rows[0]["id_Con"];
                    var nom = dt.Rows[0]["nom_Con"];
                    var prenom = dt.Rows[0]["prenom_Con"];
                    var fonction = dt.Rows[0]["fonctio_Con"];
                    var id_Conn1 = dt.Rows[1]["id_Con"];
                    var nom1 = dt.Rows[1]["nom_Con"];
                    var prenom1 = dt.Rows[1]["prenom_Con"];
                    var fonction1 = dt.Rows[1]["fonctio_Con"];

                    return (nom.ToString(), prenom.ToString(), fonction.ToString(), nom1.ToString(), prenom1.ToString(), fonction1.ToString(), id_Conn.ToString(), id_Conn1.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "");
            }
        }

        public (string, string) getEmployeeTests(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Test n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["med_Test"].ToString(), dr["prof_Test"].ToString());
                }
                cnx.Close();
                return ("", "");
            }
            else
            {
                return ("", "");
            }
        }
        public (string, string, string, string, string) getEmployeeContract(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Contrat n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["date_Cont"].ToString(), dr["fonction"].ToString(), dr["direction"].ToString(), dr["date_Engage"].ToString(), dr["Etat"].ToString());
                }
                cnx.Close();
                return ("", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeRewards(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Primes n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["salaire"].ToString(), dr["iep"].ToString(), dr["panier"].ToString(), dr["transport"].ToString(), dr["salissure"].ToString(), dr["indemnité"].ToString(), dr["deplace"].ToString(), dr["danger"].ToString(), dr["phone"].ToString(), dr["penibilité"].ToString(), dr["insalubrité"].ToString(), dr["fidelité"].ToString(), dr["pri"].ToString(), dr["prc"].ToString(), dr["ppi"].ToString(), dr["iq"].ToString(), dr["mission"].ToString(), dr["ifri"].ToString(), dr["autre"].ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string) getEmployeeEndTrial(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_FinEssai n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["period_Essai"].ToString(), dr["date_Notif"].ToString(), dr["num_Ref"].ToString());
                }
                cnx.Close();
                return ("", "", "");
            }
            else
            {
                return ("", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeFormation(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Formation n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Form = dt.Rows[0]["id_Form"];
                    var exe = dt.Rows[0]["exercice"];
                    var the = dt.Rows[0]["theme"];
                    var lieuForm = dt.Rows[0]["lieu_Form"];
                    var dure = dt.Rows[0]["durée"];
                    var dateForm = dt.Rows[0]["date_Form"];
                    var objForm = dt.Rows[0]["objectif"];
                    var id_Form1 = dt.Rows[1]["id_Form"];
                    var exe1 = dt.Rows[1]["exercice"];
                    var the1 = dt.Rows[1]["theme"];
                    var lieuForm1 = dt.Rows[1]["lieu_Form"];
                    var dure1 = dt.Rows[1]["durée"];
                    var dateForm1 = dt.Rows[1]["date_Form"];
                    var objForm1 = dt.Rows[1]["objectif"];
                    var id_Form2 = dt.Rows[2]["id_Form"];
                    var exe2 = dt.Rows[2]["exercice"];
                    var the2 = dt.Rows[2]["theme"];
                    var lieuForm2 = dt.Rows[2]["lieu_Form"];
                    var dure2 = dt.Rows[2]["durée"];
                    var dateForm2 = dt.Rows[2]["date_Form"];
                    var objForm2 = dt.Rows[2]["objectif"];
                    var id_Form3 = dt.Rows[3]["id_Form"];
                    var exe3 = dt.Rows[3]["exercice"];
                    var the3 = dt.Rows[3]["theme"];
                    var lieuForm3 = dt.Rows[3]["lieu_Form"];
                    var dure3 = dt.Rows[3]["durée"];
                    var dateForm3 = dt.Rows[3]["date_Form"];
                    var objForm3 = dt.Rows[3]["objectif"];
                    var id_Form4 = dt.Rows[4]["id_Form"];
                    var exe4 = dt.Rows[4]["exercice"];
                    var the4 = dt.Rows[4]["theme"];
                    var lieuForm4 = dt.Rows[4]["lieu_Form"];
                    var dure4 = dt.Rows[4]["durée"];
                    var dateForm4 = dt.Rows[4]["date_Form"];
                    var objForm4 = dt.Rows[4]["objectif"];

                    return (exe.ToString(), the.ToString(), lieuForm.ToString(), dure.ToString(), dateForm.ToString(), objForm.ToString(), exe1.ToString(), the1.ToString(), lieuForm1.ToString(), dure1.ToString(), dateForm1.ToString(), objForm1.ToString(), exe2.ToString(), the2.ToString(), lieuForm2.ToString(), dure2.ToString(), dateForm2.ToString(), objForm2.ToString(), exe3.ToString(), the3.ToString(), lieuForm3.ToString(), dure3.ToString(), dateForm3.ToString(), objForm3.ToString(), exe4.ToString(), the4.ToString(), lieuForm4.ToString(), dure4.ToString(), dateForm4.ToString(), objForm4.ToString(), id_Form.ToString(), id_Form1.ToString(), id_Form2.ToString(), id_Form3.ToString(), id_Form4.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeDiscipline(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Discipline n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Descip = dt.Rows[0]["id_Discip"];
                    var qualif = dt.Rows[0]["qualif"];
                    var natSanc = dt.Rows[0]["nature_Sanc"];
                    var dateSanc = dt.Rows[0]["date_Sanc"];
                    var motiSanc = dt.Rows[0]["motif"];
                    var observ = dt.Rows[0]["observation"];
                    var id_Descip1 = dt.Rows[1]["id_Discip"];
                    var qualif1 = dt.Rows[1]["qualif"];
                    var natSanc1 = dt.Rows[1]["nature_Sanc"];
                    var dateSanc1 = dt.Rows[1]["date_Sanc"];
                    var motiSanc1 = dt.Rows[1]["motif"];
                    var observ1 = dt.Rows[1]["observation"];
                    var id_Descip2 = dt.Rows[2]["id_Discip"];
                    var qualif2 = dt.Rows[2]["qualif"];
                    var natSanc2 = dt.Rows[2]["nature_Sanc"];
                    var dateSanc2 = dt.Rows[2]["date_Sanc"];
                    var motiSanc2 = dt.Rows[2]["motif"];
                    var observ2 = dt.Rows[2]["observation"];
                    var id_Descip3 = dt.Rows[3]["id_Discip"];
                    var qualif3 = dt.Rows[3]["qualif"];
                    var natSanc3 = dt.Rows[3]["nature_Sanc"];
                    var dateSanc3 = dt.Rows[3]["date_Sanc"];
                    var motiSanc3 = dt.Rows[3]["motif"];
                    var observ3 = dt.Rows[3]["observation"];

                    return (qualif.ToString(), natSanc.ToString(), dateSanc.ToString(), motiSanc.ToString(), observ.ToString(), qualif1.ToString(), natSanc1.ToString(), dateSanc1.ToString(), motiSanc1.ToString(), observ1.ToString(), qualif2.ToString(), natSanc2.ToString(), dateSanc2.ToString(), motiSanc2.ToString(), observ2.ToString(), qualif3.ToString(), natSanc3.ToString(), dateSanc3.ToString(), motiSanc3.ToString(), observ3.ToString(), id_Descip.ToString(), id_Descip1.ToString(), id_Descip2.ToString(), id_Descip3.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeSurveillance(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Surveille n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Survi = dt.Rows[0]["id_Surv"];
                    var etapeChoisi = dt.Rows[0]["etape_Choisi"];
                    var dateSurv = dt.Rows[0]["date_Surv"];
                    var etapSurv = dt.Rows[0]["etape"];
                    var technic = dt.Rows[0]["technique"];
                    var note = dt.Rows[0]["notation"];
                    var remarque = dt.Rows[0]["remarque"];
                    var id_Survi1 = dt.Rows[1]["id_Surv"];
                    var dateSurv1 = dt.Rows[1]["date_Surv"];
                    var etapSurv1 = dt.Rows[1]["etape"];
                    var technic1 = dt.Rows[1]["technique"];
                    var note1 = dt.Rows[1]["notation"];
                    var remarque1 = dt.Rows[1]["remarque"];
                    var id_Survi2 = dt.Rows[2]["id_Surv"];
                    var dateSurv2 = dt.Rows[2]["date_Surv"];
                    var etapSurv2 = dt.Rows[2]["etape"];
                    var technic2 = dt.Rows[2]["technique"];
                    var note2 = dt.Rows[2]["notation"];
                    var remarque2 = dt.Rows[2]["remarque"];
                    var id_Survi3 = dt.Rows[3]["id_Surv"];
                    var dateSurv3 = dt.Rows[3]["date_Surv"];
                    var etapSurv3 = dt.Rows[3]["etape"];
                    var technic3 = dt.Rows[3]["technique"];
                    var note3 = dt.Rows[3]["notation"];
                    var remarque3 = dt.Rows[3]["remarque"];
                    var id_Survi4 = dt.Rows[4]["id_Surv"];
                    var dateSurv4 = dt.Rows[4]["date_Surv"];
                    var etapSurv4 = dt.Rows[4]["etape"];
                    var technic4 = dt.Rows[4]["technique"];
                    var note4 = dt.Rows[4]["notation"];
                    var remarque4 = dt.Rows[4]["remarque"];
                    var id_Survi5 = dt.Rows[5]["id_Surv"];
                    var dateSurv5 = dt.Rows[5]["date_Surv"];
                    var etapSurv5 = dt.Rows[5]["etape"];
                    var technic5 = dt.Rows[5]["technique"];
                    var note5 = dt.Rows[5]["notation"];
                    var remarque5 = dt.Rows[5]["remarque"];
                    var id_Survi6 = dt.Rows[6]["id_Surv"];
                    var dateSurv6 = dt.Rows[6]["date_Surv"];
                    var etapSurv6 = dt.Rows[6]["etape"];
                    var technic6 = dt.Rows[6]["technique"];
                    var note6 = dt.Rows[6]["notation"];
                    var remarque6 = dt.Rows[6]["remarque"];

                    return (etapeChoisi.ToString(), dateSurv.ToString(), etapSurv.ToString(), technic.ToString(), note.ToString(), remarque.ToString(), dateSurv1.ToString(), etapSurv1.ToString(), technic1.ToString(), note1.ToString(), remarque1.ToString(), dateSurv2.ToString(), etapSurv2.ToString(), technic2.ToString(), note2.ToString(), remarque2.ToString(), dateSurv3.ToString(), etapSurv3.ToString(), technic3.ToString(), note3.ToString(), remarque3.ToString(), dateSurv4.ToString(), etapSurv4.ToString(), technic4.ToString(), note4.ToString(), remarque4.ToString(), dateSurv5.ToString(), etapSurv5.ToString(), technic5.ToString(), note5.ToString(), remarque5.ToString(), dateSurv6.ToString(), etapSurv6.ToString(), technic6.ToString(), note6.ToString(), remarque6.ToString(), id_Survi.ToString(), id_Survi1.ToString(), id_Survi2.ToString(), id_Survi3.ToString(), id_Survi4.ToString(), id_Survi5.ToString(), id_Survi6.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeEvaluation(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Evaluation n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Eva = dt.Rows[0]["id_Eval"];
                    var exer = dt.Rows[0]["exercice"];
                    var notGlob = dt.Rows[0]["not_Glob"];
                    var apprec = dt.Rows[0]["appreciation"];
                    var id_Eva1 = dt.Rows[1]["id_Eval"];
                    var exer1 = dt.Rows[1]["exercice"];
                    var notGlob1 = dt.Rows[1]["not_Glob"];
                    var apprec1 = dt.Rows[1]["appreciation"];
                    var id_Eva2 = dt.Rows[2]["id_Eval"];
                    var exer2 = dt.Rows[2]["exercice"];
                    var notGlob2 = dt.Rows[2]["not_Glob"];
                    var apprec2 = dt.Rows[2]["appreciation"];
                    var id_Eva3 = dt.Rows[3]["id_Eval"];
                    var exer3 = dt.Rows[3]["exercice"];
                    var notGlob3 = dt.Rows[3]["not_Glob"];
                    var apprec3 = dt.Rows[3]["appreciation"];
                    var id_Eva4 = dt.Rows[4]["id_Eval"];
                    var exer4 = dt.Rows[4]["exercice"];
                    var notGlob4 = dt.Rows[4]["not_Glob"];
                    var apprec4 = dt.Rows[4]["appreciation"];
                    var id_Eva5 = dt.Rows[5]["id_Eval"];
                    var exer5 = dt.Rows[5]["exercice"];
                    var notGlob5 = dt.Rows[5]["not_Glob"];
                    var apprec5 = dt.Rows[5]["appreciation"];
                    var id_Eva6 = dt.Rows[6]["id_Eval"];
                    var exer6 = dt.Rows[6]["exercice"];
                    var notGlob6 = dt.Rows[6]["not_Glob"];
                    var apprec6 = dt.Rows[6]["appreciation"];

                    return (exer.ToString(), notGlob.ToString(), apprec.ToString(), exer1.ToString(), notGlob1.ToString(), apprec1.ToString(), exer2.ToString(), notGlob2.ToString(), apprec2.ToString(), exer3.ToString(), notGlob3.ToString(), apprec3.ToString(), exer4.ToString(), notGlob4.ToString(), apprec4.ToString(), exer5.ToString(), notGlob5.ToString(), apprec5.ToString(), exer6.ToString(), notGlob6.ToString(), apprec6.ToString(), id_Eva.ToString(), id_Eva1.ToString(), id_Eva2.ToString(), id_Eva3.ToString(), id_Eva4.ToString(), id_Eva5.ToString(), id_Eva6.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getEmployeeEmprove(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Amelioration n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    var id_Amel = dt.Rows[0]["id_Amelio"];
                    var exeEm = dt.Rows[0]["exercice"];
                    var promo = dt.Rows[0]["promotion"];
                    var reaff = dt.Rows[0]["reaffec"];
                    var formEm = dt.Rows[0]["formation"];
                    var autres = dt.Rows[0]["autres"];
                    var id_Amel1 = dt.Rows[1]["id_Amelio"];
                    var exeEm1 = dt.Rows[1]["exercice"];
                    var promo1 = dt.Rows[1]["promotion"];
                    var reaff1 = dt.Rows[1]["reaffec"];
                    var formEm1 = dt.Rows[1]["formation"];
                    var autres1 = dt.Rows[1]["autres"];
                    var id_Amel2 = dt.Rows[2]["id_Amelio"];
                    var exeEm2 = dt.Rows[2]["exercice"];
                    var promo2 = dt.Rows[2]["promotion"];
                    var reaff2 = dt.Rows[2]["reaffec"];
                    var formEm2 = dt.Rows[2]["formation"];
                    var autres2 = dt.Rows[2]["autres"];
                    var id_Amel3 = dt.Rows[3]["id_Amelio"];
                    var exeEm3 = dt.Rows[3]["exercice"];
                    var promo3 = dt.Rows[3]["promotion"];
                    var reaff3 = dt.Rows[3]["reaffec"];
                    var formEm3 = dt.Rows[3]["formation"];
                    var autres3 = dt.Rows[3]["autres"];
                    var id_Amel4 = dt.Rows[4]["id_Amelio"];
                    var exeEm4 = dt.Rows[4]["exercice"];
                    var promo4 = dt.Rows[4]["promotion"];
                    var reaff4 = dt.Rows[4]["reaffec"];
                    var formEm4 = dt.Rows[4]["formation"];
                    var autres4 = dt.Rows[4]["autres"];
                    var id_Amel5 = dt.Rows[5]["id_Amelio"];
                    var exeEm5 = dt.Rows[5]["exercice"];
                    var promo5 = dt.Rows[5]["promotion"];
                    var reaff5 = dt.Rows[5]["reaffec"];
                    var formEm5 = dt.Rows[5]["formation"];
                    var autres5 = dt.Rows[5]["autres"];
                    var id_Amel6 = dt.Rows[6]["id_Amelio"];
                    var exeEm6 = dt.Rows[6]["exercice"];
                    var promo6 = dt.Rows[6]["promotion"];
                    var reaff6 = dt.Rows[6]["reaffec"];
                    var formEm6 = dt.Rows[6]["formation"];
                    var autres6 = dt.Rows[6]["autres"];

                    return (exeEm.ToString(), promo.ToString(), reaff.ToString(), formEm.ToString(), autres.ToString(), exeEm1.ToString(), promo1.ToString(), reaff1.ToString(), formEm1.ToString(), autres1.ToString(), exeEm2.ToString(), promo2.ToString(), reaff2.ToString(), formEm2.ToString(), autres2.ToString(), exeEm3.ToString(), promo3.ToString(), reaff3.ToString(), formEm3.ToString(), autres3.ToString(), exeEm4.ToString(), promo4.ToString(), reaff4.ToString(), formEm4.ToString(), autres4.ToString(), exeEm5.ToString(), promo5.ToString(), reaff5.ToString(), formEm5.ToString(), autres5.ToString(), exeEm6.ToString(), promo6.ToString(), reaff6.ToString(), formEm6.ToString(), autres6.ToString(), id_Amel.ToString(), id_Amel1.ToString(), id_Amel2.ToString(), id_Amel3.ToString(), id_Amel4.ToString(), id_Amel5.ToString(), id_Amel6.ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string, string, string) getEmployeeEndContract(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_FinContrat n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["contrat"].ToString(), dr["date_Renouv"].ToString(), dr["date_Notif"].ToString(), dr["nRef"].ToString());
                }
                cnx.Close();
                return ("", "", "", "");
            }
            else
            {
                return ("", "", "", "");
            }
        }

        public (string, string, string, string) getEmployeeDepart(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_EmployeInfo e inner join T_Depart n on e.id_Emp=n.id_Emp where e." + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["date_Depa"].ToString(), dr["cate_Dep"].ToString(), dr["cause_Dep"].ToString(), dr["autreCause"].ToString());
                }
                cnx.Close();
                return ("", "", "", "");
            }
            else
            {
                return ("", "", "", "");
            }
        }
        public void updateMultiRows(string table, string colName, string recUpdated, string colIdName, string idValue)
        {
            string query = "update " + table + " set " + colName + " = case when " + colIdName + " = '" + idValue + "' then '" + recUpdated + "' end where " + colIdName + " in ('" + idValue + "')";
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlCommand cmd = new SqlCommand(query, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public (string, string, string, string, string) getUserInfo(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_Login where " + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["grh_DRec"].ToString(), dr["grh_FRen"].ToString(), dr["grh_ATravail"].ToString(), dr["grh_CTravail"].ToString(), dr["grh_TConge"].ToString());
                }
                cnx.Close();
                return ("", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "");
            }
        }

        public string getUserPerm(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_Permissions where " + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["qlt_Perm"].ToString());
                }
                cnx.Close();
                return ("");
            }
            else
            {
                return ("");
            }
        }
        public (string, string) getUserName(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_Login  where " + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["id"].ToString(), dr["name"].ToString());
                }
                cnx.Close();
                return ("", "");
            }
            else
            {
                return ("", "");
            }
        }

        public (string, string, string) getAccountInfo(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_Login where " + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["name"].ToString(), dr["user_Email"].ToString(), dr["user_PW"].ToString());
                }
                cnx.Close();
                return ("", "", "");
            }
            else
            {
                return ("", "", "");
            }
        }

        public (string, string, string, string, string) getAlertInfo(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_Alerts where " + searchWith + " ='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["alrt_To"].ToString(), dr["alrt_Stat"].ToString(), dr["alrt_Doc"].ToString(), dr["id_Alert"].ToString(), dr["alrt_From"].ToString());
                }
                cnx.Close();
                return ("", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "");
            }
        }

        public DataTable getAlertsPers(string colNames, string table2, string AlrtTo)
        {
            DataTable dt = new DataTable();
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            SqlDataAdapter dp = new SqlDataAdapter("Select e.id_Alert, e.alrt_From, e.alrt_date, e.alrt_Stat, " + colNames + " from " + table2 + " c inner join T_Alerts e on c.num_ref=e.num_ref where alrt_To='" + AlrtTo + "'", cnx);
            dp.Fill(dt);
            cnx.Close();
            return dt;
        }

        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string) getDRecInfo(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_DRecruit  where " + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["poste_Travail"].ToString(), dr["nombre"].ToString(), dr["formation"].ToString(), dr["age"].ToString(), dr["sexe"].ToString(), dr["motif"].ToString(), dr["formation_Base"].ToString(), dr["expérience"].ToString(), dr["résidence"].ToString(), dr["permis_Conduire"].ToString(), dr["disponibilité"].ToString(), dr["opportunité"].ToString(), dr["approbation_DG"].ToString(), dr["commentaire"].ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public (string, string,string, string, string, string, string, string, string, string, string, string, string) getRecSignatures(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_DRecruit where " + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["visa_ChSt1"].ToString(), dr["visa_DAM"].ToString(), dr["date_CG"].ToString(), dr["visa_CG"].ToString(), dr["date_DG"].ToString(), dr["visa_DG"].ToString(), dr["date_GRH1"].ToString(), dr["visa_GRH1"].ToString(), dr["visa_ChS2"].ToString(), dr["dateChst1"].ToString(), dr["dateDAM"].ToString(), dr["visa"].ToString(), dr["dateVisa"].ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }

        public string getStruct()
        {
            if (cnx.State != ConnectionState.Open)
                cnx.Open();

            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nom_Structure from T_Structure";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                return dr["nom_Structure"].ToString();
            }
            cnx.Close();
            return "";
        }

        public (string, string, string) getChefStruct(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select s.chef_Struct, s.nom_Structure, s.id_Struct from T_Structure s left join T_Login l on l.id_Struct=s.id_Struct  where " + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["chef_Struct"].ToString(), dr["nom_Structure"].ToString(), dr["id_Struct"].ToString());
                }
                cnx.Close();
                return ("", "", "");
            }
            else
            {
                return ("", "", "");
            }
        }
        public (string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string) getInfoForANEM(string searchVlue, string searchWith)
        {
            SqlCommand cmd = new SqlCommand("select * from T_DRecruit where " + searchWith + "='" + searchVlue + "'", cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    return (dr["num_ref"].ToString(), dr["nombre"].ToString(), dr["nature_PostTravail"].ToString(), dr["sexe"].ToString(), dr["poste_Travail"].ToString(), dr["formation"].ToString(), dr["formation_Base"].ToString(), dr["age"].ToString(), dr["langues"].ToString(), dr["expérience"].ToString(), dr["logiciels"].ToString(), dr["autre_Compétence"].ToString(), dr["projets"].ToString(), dr["lieu_Travail"].ToString(), dr["permis_Conduire"].ToString(), dr["résidence"].ToString());
                }
                cnx.Close();
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
            else
            {
                return ("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }
        }
        public void saveFiles(string filePath, string num, string titre, string revision, DateTime date, string catgorie, DateTime creeLe, string creePar, string table)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string fileName = fi.Name;

                string query = "insert into T_Qualité (refNum, titre, révision, _date, doc_Data, doc_Extn, file_Name, categorie, créé_le, créé_par) values (@num, @titre, @révision, @_date, @data, @extn, @fileName, @catg, @créé_le, @créé_par)";
                //string query = "update " + table + " set doc_Data=@data, doc_Extn=@extn, file_Name=@fileName where " + numRef + "=@num";

                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
                cmd.Parameters.Add("@titre", SqlDbType.VarChar).Value = titre;
                cmd.Parameters.Add("@révision", SqlDbType.VarChar).Value = revision;
                cmd.Parameters.Add("@_date", SqlDbType.Date).Value = date;
                cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                cmd.Parameters.Add("@fileName", SqlDbType.VarChar).Value = fileName;
                cmd.Parameters.Add("@catg", SqlDbType.VarChar).Value = catgorie;
                cmd.Parameters.Add("@créé_le", SqlDbType.DateTime).Value = creeLe;
                cmd.Parameters.Add("@créé_par", SqlDbType.VarChar).Value = creePar;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
