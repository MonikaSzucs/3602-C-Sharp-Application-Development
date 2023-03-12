using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign07
{
    class ClientRepository
    {
        private static readonly string connString = @"Server=tcp:BUNKER3.EDU.BCIT.CA,1433;
                                                    Initial Catalog=TigerDB;
                                                    User ID=tiger; 
                                                    Password=T1gerM@ster;
                                                    Encrypt=True;
                                                    TrustServerCertificate=True; 
                                                    Connection Timeout=30;";

        public static ClientList GetClients(decimal gstRate, decimal pstRate)
        {
            ClientList clients = new ClientList();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes, IsTaxable
                                    FROM Client01";

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
                                string province = reader["Province"] as string;
                                string? postalCode = reader["PostalCode"] as string;
                                decimal ytdSales = (decimal)reader["YTDSales"];

                                bool? creditHold = reader["CreditHold"] as bool?;
                                char isCreditHold = '\0';
                                if (creditHold == true)
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
                                if (taxable == true)
                                {
                                    isTaxable = 'Y';
                                }
                                else if (taxable == false)
                                {
                                    isTaxable = 'N';
                                }

                                if(isTaxable == 'N')
                                {
                                    clients.Add(new Client(0.0m, 0.0m) { CompanyName = companyName, Address1 = address1, Address2 = address2, City = city, Province = province, PostalCode = postalCode, YTDSales = ytdSales, CreditHold = isCreditHold, Notes = notes, IsTaxable = isTaxable });
                                } else
                                {
                                    clients.Add(new Client(gstRate, pstRate) { CompanyName = companyName, Address1 = address1, Address2 = address2, City = city, Province = province, PostalCode = postalCode, YTDSales = ytdSales, CreditHold = isCreditHold, Notes = notes, IsTaxable = isTaxable });
                                }


                                /*if (reader.IsDBNull(reader.GetOrdinal("PostalCode")))
                                {
                                    customerLocation.Add(new Client(companyName, address1, address2, city, province, hold));
                                }
                                else
                                {
                                    customerLocation.Add(new Client(companyName, city, province, postalCode, hold));
                                }*/
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

            return clients;
        }
    }
}
