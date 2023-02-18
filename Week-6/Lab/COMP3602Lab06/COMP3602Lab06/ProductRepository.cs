using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class ProductRepository
    {

        private const string connString = @"Server=tcp:BUNKER3.EDU.BCIT.CA,1433; 
                                                      Initial Catalog=TigerDB;
                                                      User ID=tiger;
                                                      Password=T1gerM@ster;
                                                      Encrypt=True;
                                                      TrustServerCertificate=True;
                                                      Connection Timeout=30;";

        private const string productTableName = "ProductDemo";

        public static ProductList GetProducts()
        {
            ProductList products;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"SELECT ProductId, Quantity, Sku, Description, Cost, Taxable, SellPrice
                                  FROM {productTableName}
                                  ORDER BY Sku";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    products = new ProductList();

                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        int productId;
                        int quantity;
                        string sku;
                        string description;
                        decimal? sellPrice;

                        while (reader.Read())
                        {
                            productId = (int)reader["ProductId"];
                            quantity = (int)reader["Quantity"];
                            sku = reader["Sku"] as string;
                            description = reader["Description"] as string;

                            //if (!reader.IsDBNull(reader.GetOrdinal("SellPrice")))
                            //{
                            //    sellPrice = (decimal)reader["SellPrice"];
                            //}
                            //else
                            //{
                            //    sellPrice = 0.0m;
                            //}

                            sellPrice = reader["SellPrice"] as decimal?;

                            products.Add(new Product(productId, quantity, sku, description, sellPrice ?? 0.0m));
                        }
                    }
                }
            }

            return products;
        }

    }
}
