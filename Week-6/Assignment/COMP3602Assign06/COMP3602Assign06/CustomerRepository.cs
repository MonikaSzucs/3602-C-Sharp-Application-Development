using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign05
{
    class CustomerRepository
    {
        private static readonly string connString = @"Server=tcp:BUNKER3.EDU.BCIT.CA,1433;
                                                    Initial Catalog=TigerDB;
                                                    User ID=tiger; 
                                                    Password=T1gerM@ster;
                                                    Encrypt=True;
                                                    TrustServerCertificate=True; 
                                                    Connection Timeout=30;";

        public static List<Location> GetCustomerList(string choice)
        {
            //CustomerLocationList customerLocation = new CustomerLocationList();

            //List<int> primeNumbers = new List<int>();
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
                            while(reader.Read())
                            {
                                string companyName = reader["CompanyName"] as string;
                                string city = reader["City"] as string;
                                string province = reader["Province"] as string;
                                string postalCode = reader["PostalCode"] as string;

                                bool? isConfirmed = reader["CreditHold"] as bool?;
                                char hold = '\0';   // declare an empty hold indicating null val
                                if (isConfirmed == true) {
                                    hold = 'Y';
                                } 
                                else if (isConfirmed == false) {
                                    hold = 'N';
                                }

                                //Console.WriteLine(isConfirmed);

                                // ' ' -> looking for char value
                                // " " --> looking for a string value

                                // if (isConfirmed == null) {
                                //     Console.WriteLine("isConfirmed is null");
                                // }
                                // else if (isConfirmed == true) {
                                //     Console.WriteLine("isConfirmed is true");
                                // }
                                // else if (isConfirmed == false) {
                                //     Console.WriteLine("isConfirmed is false");
                                // }


                                // add to our list based on postal code
                                if (reader.IsDBNull(reader.GetOrdinal("PostalCode"))) {
                                    customerLocation.Add(new Location(companyName, city, province, hold));
                                } else {
                                    customerLocation.Add(new Location(companyName, city, province, postalCode, hold));
                                }

                                // if (reader.IsDBNull(reader.GetOrdinal("PostalCode")))
                                // {
                                //     if(choice == "1" && province == "AB")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     }
                                //     else if(choice == "2" && province == "BC")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     } else if(choice == "3" && province == "ON")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     } else if(choice == "4" && province == "SK")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     } else if(choice == "5")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     }
                                // } else
                                // {
                                //     if (choice == "1" && province == "AB")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, postalCode, (bool)isConfirmed));
                                //     }
                                // if (reader.IsDBNull(reader.GetOrdinal("PostalCode")))
                                // {
                                //     if(choice == "1" && province == "AB")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     }
                                //     else if(choice == "2" && province == "BC")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     } else if(choice == "3" && province == "ON")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     } else if(choice == "4" && province == "SK")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     } else if(choice == "5")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, (bool)isConfirmed));
                                //     }
                                // } else
                                // {
                                //     if (choice == "1" && province == "AB")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, postalCode, (bool)isConfirmed));
                                //     }
                                //     else if (choice == "2" && province == "BC")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, postalCode, (bool)isConfirmed));
                                //     }
                                //     else if (choice == "3" && province == "ON")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, postalCode, (bool)isConfirmed));
                                //     }
                                //     else if (choice == "4" && province == "SK")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, postalCode, (bool)isConfirmed));
                                //     } else if(choice == "5")
                                //     {
                                //         customerLocation.Add(new LocationDetails(companyName, city, province, postalCode, (bool)isConfirmed));
                                //     }
                                // }
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

            return customerLocation;
        }
    }
}
