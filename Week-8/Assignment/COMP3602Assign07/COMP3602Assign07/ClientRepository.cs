using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign07
{
    class ClientRepository
    {
        // connect to database
        private static readonly string connString = @"Server=tcp:BUNKER3.EDU.BCIT.CA,1433;
                                                    Initial Catalog=TigerDB;
                                                    User ID=tiger; 
                                                    Password=T1gerM@ster;
                                                    Encrypt=True;
                                                    TrustServerCertificate=True; 
                                                    Connection Timeout=30;";

        public static List<Collection> GetClientList(string choice) 
        {
            List<Collection> clientData = new List<Collection>();

            try
            {
                // Must right click the project Manage Nuget Packages > Search & Install 'System.Data.SqlClient'
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes, IsTaxable";
                    
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Connection = conn;

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
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
                                bool? isCreditHold = reader["CreditHold"] as bool?;
                                char creditHold = '\0';
                                if(isCreditHold == true)
                                {
                                    creditHold = 'Y';
                                }
                                else if (isCreditHold == false)
                                {
                                    creditHold = 'N';
                                }

                                string? notes = reader["Notes"] as string;

                                bool? isTaxable = reader["IsTaxable"] as bool?;
                                char taxable = '\0';
                                if(isTaxable == true)
                                {
                                    taxable = 'Y';
                                }
                                else if (isTaxable == false)
                                {
                                    taxable = 'N';
                                }

                                clientData.Add(new Collection(companyName, address1, address2, city, province, postalCode, ytdSales, creditHold, notes, taxable));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ConsolePrinter.PrintError($"Data Access Error\n\n{ex.Message}");
            }
            catch (Exception ex)
            {
                ConsolePrinter.PrintError($"Processing Error\n\n{ex.Message}");
            }

            return clientData;
        }
    }
}
