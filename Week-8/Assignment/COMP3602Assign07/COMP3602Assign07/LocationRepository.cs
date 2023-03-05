using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign07
{
    class LocationRepository
    {
        private static readonly string connString = @"Server=tcp:BUNKER3.EDU.BCIT.CA,1433;
                                                    Initial Catalog=TigerDB;
                                                    User ID=tiger; 
                                                    Password=T1gerM@ster;
                                                    Encrypt=True;
                                                    TrustServerCertificate=True; 
                                                    Connection Timeout=30;";

        public static List<Location> GetCustomerLocations()
        {
            List<Location> customerLocation = new List<Location>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT CompanyName, City, Province, PostalCode, CreditHold
                                    FROM Customer";

                    using (SqlCommand cmd = conn.CreateCommand()) 
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Connection = conn;

                        conn.Open();

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string companyName = reader["CompanyName"] as string;
                                string address1 = reader["Address1"] as string;
                                string? address2 = reader["Address2"] as string;
                                string? city = reader["City"] as string;
                                char province = (char)reader["Province"];
                                string? postalCode = reader["PostalCode"] as string;
                                decimal ytdSales = (decimal)reader["YTDSales"];

                                bool? creditHold = reader["CreditHold"] as bool?;
                                char isCreditHold = '\0';
                                if(creditHold == true)
                                {
                                    isCreditHold = 'Y';
                                }
                                else if (creditHold == false)
                                {
                                    isCreditHold = 'N';
                                }

                                string notes = reader["Notes"] as string;

                                bool? taxable = reader["IsTaxable"] as bool?;
                                char isTaxable = '\0';
                                if(taxable == true)
                                {
                                    isTaxable = 'Y';
                                } else if(taxable == false)
                                {
                                    isTaxable = 'N';
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return customerLocation;
        }
    }
}
