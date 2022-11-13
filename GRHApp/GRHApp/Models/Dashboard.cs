using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRHApp.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    class Dashboard
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumDocs { get; set; }

        //public int NumDR { get; private set; }
        //public int NumFR { get; private set; }
        //public int NumCertificat { get; private set; }
        //public List<KeyValuePair<string, int>> ThreeFilesList { get; private set; }
        //public List<KeyValuePair<string, int>> DRList { get; private set; }
        public List<RevenueByDate> FRList { get; private set; }

        public Dashboard()
        {

        }

        SqlConnection cnx = new SqlConnection(@"Data Source=192.168.1.2,49170;Initial Catalog=GRHdb;Integrated Security=True");

        
        private void GetOrderAnalisys()
        {
            FRList = new List<RevenueByDate>();
            
            
                cnx.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = cnx;
                    command.CommandText = @"select créé_le, count(num_ref)
                                            from[T_DRecruit]
                                            where créé_le between @fromDate and @toDate
                                            group by créé_le";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
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

        private void GetNumberItems()
        {
            
                cnx.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = cnx;
                //Get Total Number of Customers
                //command.CommandText = "select count(id) from Customer";
                //NumCustomers = (int)command.ExecuteScalar();

                ////Get Total Number of Suppliers
                //command.CommandText = "select count(id) from Supplier";
                //NumSuppliers = (int)command.ExecuteScalar();

                ////Get Total Number of Products
                //command.CommandText = "select count(id) from Product";
                //NumProducts = (int)command.ExecuteScalar();

                //Get Total Number of Orders
                command.CommandText = @"select créé_le, count(num_ref)
                                            from[T_DRecruit]
                                            where créé_le between @fromDate and @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumDocs = (int)command.ExecuteScalar();
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

                GetNumberItems();
                //GetProductAnalisys();
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

    }
}
