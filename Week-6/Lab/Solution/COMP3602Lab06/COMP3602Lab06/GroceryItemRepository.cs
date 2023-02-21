using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class GroceryItemRepository
    {
        private static readonly string connString = @"Server=tcp:BUNKER3.EDU.BCIT.CA,1433;
                                                    Initial Catalog=TigerDB;
                                                    User ID=tiger; 
                                                    Password=T1gerM@ster;
                                                    Encrypt=True;
                                                    TrustServerCertificate=True; 
                                                    Connection Timeout=30;";

        public static ItemList GetGroceryItems()
        {
            ItemList groceries = new ItemList();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT Description, Sku, Price, ExpirationDate
                                     FROM GroceryItem";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Connection = conn;

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string description = reader["Description"] as string;
                                string sku = reader["Sku"] as string;
                                decimal price = (decimal)reader["Price"];
                                DateTime expirationDate = DateTime.MaxValue;

                                if (reader.IsDBNull(reader.GetOrdinal("ExpirationDate"))) //This way it is correct, even if the column order changes
                                {
                                    groceries.Add(new GroceryItem(description, sku, price));
                                }
                                else
                                {
                                    expirationDate = (DateTime)reader["ExpirationDate"];
                                    groceries.Add(new GroceryItem(description, sku, price, expirationDate));
                                }
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

            return groceries;
        }
    }
}
