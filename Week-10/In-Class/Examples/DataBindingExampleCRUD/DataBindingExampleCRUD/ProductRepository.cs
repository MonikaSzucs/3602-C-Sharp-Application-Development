using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingExampleCRUD
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

        private const string productTableName = "Product123456";


        public static ProductList GetProducts()
        {
            ProductList products;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"SELECT ProductId, Quantity, Sku, Description, Cost, Taxable
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
                        decimal cost;
                        bool taxable;

                        while (reader.Read())
                        {
                            productId = (int)reader["ProductId"];
                            quantity = (int)reader["Quantity"];
                            sku = reader["Sku"] as string;

                            if (!reader.IsDBNull(3))
                            {
                                description = reader["Description"] as string;
                            }
                            else
                            {
                                description = null;
                            }

                            cost = (decimal)reader["Cost"];
                            taxable = (bool)reader["Taxable"];

                            products.Add(new Product
                            {
                                ProductId = productId,
                                Quantity = quantity,
                                Sku = sku,
                                Description = description,
                                Cost = cost,
                                Taxable = taxable
                            });
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
                                 (Quantity, Sku, Description, Cost, Taxable)
                                  VALUES (@quantity, @sku, @description, @cost, @taxable)";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("sku", product.Sku);
                    cmd.Parameters.AddWithValue("description", (object)product.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("cost", product.Cost);
                    cmd.Parameters.AddWithValue("taxable", product.Taxable);

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
                                      Cost = @cost,
                                      Taxable = @taxable
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
                    cmd.Parameters.AddWithValue("cost", product.Cost);
                    cmd.Parameters.AddWithValue("taxable", product.Taxable);
                    

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
