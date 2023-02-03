using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace SQLCrudExample
{
    class ProductRepository
    {
        private const string connString = @"Server=tcp:comp2614.database.windows.net,1433;
                                            Initial Catalog=comp2614;
                                            User ID=student;
                                            Password=iLOVEpho!;
                                            Encrypt=True;
                                            TrustServerCertificate=False;
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

        public static int AddProduct(Product product)
        {
            int rowsAffected;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"INSERT INTO {productTableName}
                                 (Quantity, Sku, Description, SellPrice)
                                  VALUES (@quantity, @sku, @description, @sellPrice)";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("sku", product.Sku);
                    cmd.Parameters.AddWithValue("description", (object)product.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("sellPrice", product.SellPrice);

                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public static int UpdateProduct(Product product)
        {
            int rowsAffected;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"UPDATE {productTableName}
                                  SET Quantity = @quantity,
                                      Sku = @sku,
                                      Description = @description,
                                      SellPrice = @sellPrice
                                  WHERE ProductId = @productId";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("productId", product.ProductId);
                    cmd.Parameters.AddWithValue("quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("sku", product.Sku);
                    cmd.Parameters.AddWithValue("description", (object)product.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("sellPrice", product.SellPrice);
                    

                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public static int DeleteProduct(Product product)
        {
            int rowsAffected;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"DELETE {productTableName}
                                  WHERE ProductId = @productId";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("productId", product.ProductId);
                   
                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }
    }
}
