using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRHApp.Classes
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    class dashboardClass
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumDocs { get; set; }

        public List<KeyValuePair<string, int>> TopStructList { get; private set; }

        public List<KeyValuePair<string, int>> StututList { get; private set; }

        public List<KeyValuePair<string, int>> FiRensEtatList { get; private set; }

        public List<KeyValuePair<string, int>> DocsList { get; private set; }

        public List<KeyValuePair<string, int>> TurnOverList { get; private set; }

        public List<RevenueByDate> FRList { get; private set; }

        public List<RevenueByDate> AttesList { get; private set; }

        public List<RevenueByDate> CertList { get; private set; }

        public List<RevenueByDate> CongList { get; private set; }

        public dashboardClass()
        {

        }

        
        SqlConnection cnx = new SqlConnection(@"Data Source=192.168.1.2,49170;Initial Catalog=GRHdb;User ID=sa;Password=02101996k+");

        public DataTable getData()
        {
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            
                DataTable dt = new DataTable();
                //cnx.Open();
                SqlDataAdapter dp = new SqlDataAdapter("select num_ref, poste_Travail, nombre, age, sexe, créé_le, créé_par, etat from T_DRecruit where etat in ('En cours', 'Validé par chef structure', 'Validé par DAM')", cnx);
                dp.Fill(dt);
                cnx.Close();
                return dt;
        }
        private void GetOrderAnalisys()
        {
            FRList = new List<RevenueByDate>();

            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = cnx;
                command.CommandText = @"select créé_le, count(num_ref)
                                            from[T_DRecruit]
                                            where créé_le between CONVERT (datetime, @fromDate, 121) and CONVERT (datetime, @toDate, 121)
                                            group by créé_le";
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                var reader = command.ExecuteReader();
                var resultTable = new List<KeyValuePair<DateTime, int>>();
                while (reader.Read())
                {
                    resultTable.Add(
                        new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1])
                        );
                }

                reader.Close();

                //Group by Hours
                if (numberDays <= 1)
                {
                    FRList = (from orderList in resultTable
                              group orderList by orderList.Key.ToString("hh tt")
                                       into order
                              select new RevenueByDate
                              {
                                  Date = order.Key,
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }
                //Group by Days
                else if (numberDays <= 30)
                {
                    FRList = (from orderList in resultTable
                              group orderList by orderList.Key.ToString("dd MMM")
                                       into order
                              select new RevenueByDate
                              {
                                  Date = order.Key,
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }

                //Group by Weeks
                else if (numberDays <= 92)
                {
                    FRList = (from orderList in resultTable
                              group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                  orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                              select new RevenueByDate
                              {
                                  Date = "Week " + order.Key.ToString(),
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }

                //Group by Months
                else if (numberDays <= (365 * 2))
                {
                    bool isYear = numberDays <= 365 ? true : false;
                    FRList = (from orderList in resultTable
                              group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                              select new RevenueByDate
                              {
                                  Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }

                //Group by Years
                else
                {
                    FRList = (from orderList in resultTable
                              group orderList by orderList.Key.ToString("yyyy")
                                           into order
                              select new RevenueByDate
                              {
                                  Date = order.Key,
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }
            }

        }
        private void GetProductAnalisys()
        {
            TopStructList = new List<KeyValuePair<string, int>>();

            if (cnx.State != ConnectionState.Open)
                cnx.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = cnx;
                    //Get Top 5 products
                    command.CommandText = @"select top 5 s.nom_Structure, count(d.num_ref) as q from T_Structure s inner join T_DRecruit d on s.id_Struct=d.id_Struct where créé_le between CONVERT (datetime, @fromDate, 121) and CONVERT (datetime, @toDate, 121) group by nom_Structure order by q";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                    TopStructList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    
                }
            
        }
        private void GetDRStatutAnalisys()
        {
            StututList = new List<KeyValuePair<string, int>>();

            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            using (var command = new SqlCommand())
            {
                SqlDataReader reader;
                command.Connection = cnx;
                //Get Top 5 products
                command.CommandText = @"select top 5 statut, count(num_ref) as q from T_DRecruit where créé_le between CONVERT (datetime, @fromDate, 121) and CONVERT (datetime, @toDate, 121) group by statut order by q";
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    StututList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                }
                reader.Close();
            }
        }
        private void GetFiRensEtaAnalisys()
        {
            FiRensEtatList = new List<KeyValuePair<string, int>>();

            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            using (var command = new SqlCommand())
            {
                SqlDataReader reader;
                command.Connection = cnx;
                //Get Top 5 products
                command.CommandText = @"select top 5 c.Etat, count(e.id_Emp) as q from T_Contrat c inner join T_EmployeInfo e on e.id_Emp=c.id_Emp where e.date_Doc between CONVERT (datetime, @fromDate, 121) and CONVERT (datetime, @toDate, 121) and c.Etat <> '' group by c.Etat order by q";
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    FiRensEtatList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                }
                reader.Close();
            }
        }
        private void GetDocsAnalisys()
        {
            DocsList = new List<KeyValuePair<string, int>>();

            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            using (var command = new SqlCommand())
            {
                SqlDataReader reader;
                command.Connection = cnx;
                //Get Top 5 products
                command.CommandText = @"select top 10 categorie, count(refNum) as q from T_Qualité where créé_le between CONVERT (datetime, @fromDate, 121) and CONVERT (datetime, @toDate, 121) and categorie <> '' group by categorie order by q";
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DocsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                }
                reader.Close();
            }
        }
        private void GetTurnOverAnalisys()
        {
            TurnOverList = new List<KeyValuePair<string, int>>();

            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            using (var command = new SqlCommand())
            {
                SqlDataReader reader;
                command.Connection = cnx;
                //Get Top 5 products
                command.CommandText = @"  select top 5 cate_Dep, count(id_Emp) as q from T_Depart where date_Depa between CONVERT (datetime, @fromDate, 121) and CONVERT (datetime, @toDate, 121) and cate_Dep <> '' group by cate_Dep order by q";
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TurnOverList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                }
                reader.Close();
            }
        }
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetProductAnalisys();
                GetDRStatutAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }

        private void GetAttesAnalisys()
        {
            AttesList = new List<RevenueByDate>();

            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = cnx;
                command.CommandText = @"select créé_le, count(num_Ref)
                                            from[T_AttesCert]
                                            where créé_le between CONVERT (datetime, @fromDate, 121) and CONVERT (datetime, @toDate, 121)
                                            group by créé_le";
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                var reader = command.ExecuteReader();
                var resultTable = new List<KeyValuePair<DateTime, int>>();
                while (reader.Read())
                {
                    resultTable.Add(
                        new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1])
                        );
                }

                reader.Close();

                //Group by Hours
                if (numberDays <= 1)
                {
                    AttesList = (from orderList in resultTable
                              group orderList by orderList.Key.ToString("hh tt")
                                       into order
                              select new RevenueByDate
                              {
                                  Date = order.Key,
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }
                //Group by Days
                else if (numberDays <= 30)
                {
                    AttesList = (from orderList in resultTable
                              group orderList by orderList.Key.ToString("dd MMM")
                                       into order
                              select new RevenueByDate
                              {
                                  Date = order.Key,
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }

                //Group by Weeks
                else if (numberDays <= 92)
                {
                    AttesList = (from orderList in resultTable
                              group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                  orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                              select new RevenueByDate
                              {
                                  Date = "Week " + order.Key.ToString(),
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }

                //Group by Months
                else if (numberDays <= (365 * 2))
                {
                    bool isYear = numberDays <= 365 ? true : false;
                    AttesList = (from orderList in resultTable
                              group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                              select new RevenueByDate
                              {
                                  Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }

                //Group by Years
                else
                {
                    AttesList = (from orderList in resultTable
                              group orderList by orderList.Key.ToString("yyyy")
                                           into order
                              select new RevenueByDate
                              {
                                  Date = order.Key,
                                  TotalAmount = order.Sum(amount => amount.Value)
                              }).ToList();
                }
            }

        }

        private void GetCertAnalisys()
        {
            CertList = new List<RevenueByDate>();

            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = cnx;
                command.CommandText = @"select créé_le, count(numRef)
                                            from[T_Cert]
                                            where créé_le between CONVERT (datetime, @fromDate, 121) and CONVERT (datetime, @toDate, 121)
                                            group by créé_le";
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                var reader = command.ExecuteReader();
                var resultTable = new List<KeyValuePair<DateTime, int>>();
                while (reader.Read())
                {
                    resultTable.Add(
                        new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1])
                        );
                }

                reader.Close();

                //Group by Hours
                if (numberDays <= 1)
                {
                    CertList = (from orderList in resultTable
                                 group orderList by orderList.Key.ToString("hh tt")
                                       into order
                                 select new RevenueByDate
                                 {
                                     Date = order.Key,
                                     TotalAmount = order.Sum(amount => amount.Value)
                                 }).ToList();
                }
                //Group by Days
                else if (numberDays <= 30)
                {
                    CertList = (from orderList in resultTable
                                 group orderList by orderList.Key.ToString("dd MMM")
                                       into order
                                 select new RevenueByDate
                                 {
                                     Date = order.Key,
                                     TotalAmount = order.Sum(amount => amount.Value)
                                 }).ToList();
                }

                //Group by Weeks
                else if (numberDays <= 92)
                {
                    CertList = (from orderList in resultTable
                                 group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                     orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                 select new RevenueByDate
                                 {
                                     Date = "Week " + order.Key.ToString(),
                                     TotalAmount = order.Sum(amount => amount.Value)
                                 }).ToList();
                }

                //Group by Months
                else if (numberDays <= (365 * 2))
                {
                    bool isYear = numberDays <= 365 ? true : false;
                    CertList = (from orderList in resultTable
                                 group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                 select new RevenueByDate
                                 {
                                     Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                     TotalAmount = order.Sum(amount => amount.Value)
                                 }).ToList();
                }

                //Group by Years
                else
                {
                    CertList = (from orderList in resultTable
                                 group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                 select new RevenueByDate
                                 {
                                     Date = order.Key,
                                     TotalAmount = order.Sum(amount => amount.Value)
                                 }).ToList();
                }
            }

        }
        private void GetCongAnalisys()
        {
            CongList = new List<RevenueByDate>();

            if (cnx.State != ConnectionState.Open)
                cnx.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = cnx;
                command.CommandText = @"select créé_le, count(nom_Ref)
                                            from[T_Conge]
                                            where créé_le between CONVERT (datetime, @fromDate, 121) and CONVERT (datetime, @toDate, 121)
                                            group by créé_le";
                command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                var reader = command.ExecuteReader();
                var resultTable = new List<KeyValuePair<DateTime, int>>();
                while (reader.Read())
                {
                    resultTable.Add(
                        new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1])
                        );
                }

                reader.Close();

                //Group by Hours
                if (numberDays <= 1)
                {
                    CongList = (from orderList in resultTable
                                group orderList by orderList.Key.ToString("hh tt")
                                       into order
                                select new RevenueByDate
                                {
                                    Date = order.Key,
                                    TotalAmount = order.Sum(amount => amount.Value)
                                }).ToList();
                }
                //Group by Days
                else if (numberDays <= 30)
                {
                    CongList = (from orderList in resultTable
                                group orderList by orderList.Key.ToString("dd MMM")
                                       into order
                                select new RevenueByDate
                                {
                                    Date = order.Key,
                                    TotalAmount = order.Sum(amount => amount.Value)
                                }).ToList();
                }

                //Group by Weeks
                else if (numberDays <= 92)
                {
                    CongList = (from orderList in resultTable
                                group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                    orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                select new RevenueByDate
                                {
                                    Date = "Week " + order.Key.ToString(),
                                    TotalAmount = order.Sum(amount => amount.Value)
                                }).ToList();
                }

                //Group by Months
                else if (numberDays <= (365 * 2))
                {
                    bool isYear = numberDays <= 365 ? true : false;
                    CongList = (from orderList in resultTable
                                group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                select new RevenueByDate
                                {
                                    Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                    TotalAmount = order.Sum(amount => amount.Value)
                                }).ToList();
                }

                //Group by Years
                else
                {
                    CongList = (from orderList in resultTable
                                group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                select new RevenueByDate
                                {
                                    Date = order.Key,
                                    TotalAmount = order.Sum(amount => amount.Value)
                                }).ToList();
                }
            }

        }
        public bool LoadDataAttes(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetAttesAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
        public bool LoadDataCert(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetCertAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
        public bool LoadDataCong(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetCongAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
        public bool LoadDataFRens(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetFiRensEtaAnalisys();
                GetTurnOverAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
        public bool LoadDataDocs(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetDocsAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
