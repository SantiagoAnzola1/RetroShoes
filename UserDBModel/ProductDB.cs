using ProductDomain;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using UserDomain;

namespace UserDBModel
{
    public class ProductDB
    {

        private string ConnectionString;

        

        public ProductDB(string ConnectionString) { 
            this.ConnectionString = ConnectionString;
        }

        public IEnumerable<Product> getProducts()
        {
            
            var productList = new List<Product>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                   

                    connection.Open();

                    String sql = "SELECT PRODUCTNAME,ID,STOCK,PRECIO,CATEGORIA,IMAGEN,MARCA,GENERO FROM DBO.PRODUCT ORDER BY STOCK DESC";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product productTemp = new Product();
                                productTemp.ProductName = reader.GetString(0);
                                productTemp.ProductId = reader.GetInt32(1).ToString();
                                productTemp.Stock = reader.GetInt32(2).ToString();
                                productTemp.Precio = reader.GetDecimal(3);
                                productTemp.Categoria= reader.GetString(4);
                                productTemp.Imagen=reader.GetString(5);
                                productTemp.Marca= reader.GetString(6);
                                productTemp.Genero=reader.GetString(7);
                                

                            productList.Add(productTemp);
                            }
                        }
                    }
                }
            
            return productList;
           
        }

        public Product getProductByid(int productID)
        {



            var product = new Product();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
               

                connection.Open();

                //String sql = "SELECT PRODUCTNAME,ID,STOCK,PRECIO,CATEGORIA,IMAGEN,MARCA,GENERO FROM DBO.PRODUCT WHERE ID='" + productID + "' ";
                String sql = "SELECT PRODUCTNAME,ID,STOCK,PRECIO,CATEGORIA,IMAGEN,MARCA,GENERO FROM DBO.PRODUCT WHERE ID=@ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", productID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Product productTemp = new Product();
                            productTemp.ProductName = reader.GetString(0);
                            productTemp.ProductId = reader.GetInt32(1).ToString();
                            productTemp.Stock = reader.GetInt32(2).ToString();
                            productTemp.Precio = reader.GetDecimal(3);
                            productTemp.Categoria = reader.GetString(4);
                            productTemp.Imagen = reader.GetString(5);
                            productTemp.Marca = reader.GetString(6);
                            productTemp.Genero = reader.GetString(7);
                            product= productTemp;
                           /* productList.Add(productTemp)*/;
                        }

                    }
                }
            }

            return product;

        }

        public IEnumerable<Product> getProductByCategoria(string categoria)
        {



            var productList = new List<Product>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                

                connection.Open();

                //String sql = "SELECT PRODUCTNAME,ID,STOCK,PRECIO,CATEGORIA,IMAGEN,MARCA,GENERO FROM DBO.PRODUCT WHERE CATEGORIA='" + product.Categoria + "' ";
                String sql = "SELECT PRODUCTNAME,ID,STOCK,PRECIO,CATEGORIA,IMAGEN,MARCA,GENERO FROM DBO.PRODUCT WHERE CATEGORIA=@Categoria";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Categoria", categoria);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Product productTemp = new Product();
                            productTemp.ProductName = reader.GetString(0);
                            productTemp.ProductId = reader.GetInt32(1).ToString();
                            productTemp.Stock = reader.GetInt32(2).ToString();
                            productTemp.Precio = reader.GetDecimal(3);
                            productTemp.Categoria = reader.GetString(4);
                            productTemp.Imagen = reader.GetString(5);
                            productTemp.Marca = reader.GetString(6);
                            productTemp.Genero = reader.GetString(7);

                            productList.Add(productTemp);
                        }

                    }
                }
            }

            return productList;

        }
        public IEnumerable<Product> getProductByGenero(string genero)
        {



            var productList = new List<Product>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
               

                connection.Open();

                //String sql = "SELECT PRODUCTNAME,ID,STOCK,PRECIO,CATEGORIA,IMAGEN,MARCA,GENERO FROM DBO.PRODUCT WHERE GENERO='" + product.Genero + "' ";
                String sql = "SELECT PRODUCTNAME,ID,STOCK,PRECIO,CATEGORIA,IMAGEN,MARCA,GENERO FROM DBO.PRODUCT WHERE GENERO=@Genero";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Genero", genero);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Product productTemp = new Product();
                            productTemp.ProductName = reader.GetString(0);
                            productTemp.ProductId = reader.GetInt32(1).ToString();
                            productTemp.Stock = reader.GetInt32(2).ToString();
                            productTemp.Precio = reader.GetDecimal(3);
                            productTemp.Categoria = reader.GetString(4);
                            productTemp.Imagen = reader.GetString(5);
                            productTemp.Marca = reader.GetString(6);
                            productTemp.Genero = reader.GetString(7);

                            productList.Add(productTemp);
                        }

                    }
                }
            }

            return productList;

        } public Int32 getStock(int id)
        {


                Int32 stock = 0;
                var productList = new List<Product>();

                SqlConnection conexion = new SqlConnection(this.ConnectionString);

               

                conexion.Open();

            //String sql = "SELECT STOCK FROM DBO.PRODUCT WHERE ID='" + product.ProductId + "' ";
            String sql = "SELECT STOCK FROM DBO.PRODUCT WHERE ID=@ID";


            SqlCommand cmd = new SqlCommand(sql, conexion)
            {

                    CommandType = System.Data.CommandType.Text

            };

            cmd.Parameters.AddWithValue("@ID", id);
            stock = Convert.ToInt32(cmd.ExecuteScalar());
                
                return stock;
        }





        public void createProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                

                connection.Open();

                //String sql = @"INSERT INTO DBO.PRODUCT VALUES 
                //    ('" + product.ProductName + "'," +
                //    "'" + product.Stock+ "'," +
                //    "'" + product.Precio + "'," +
                //    "'" + product.Categoria + "'," +
                //    "'" + product.Imagen + "'," +
                //    "'" + product.Marca + "'," +
                //    "'" + product.Genero + "')";
                String sql = @"INSERT INTO DBO.PRODUCT VALUES 
                            (@ProductName, @Stock, @Precio, 
                             @Categoria, @Imagen, @Marca, @Genero)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", product.ProductName);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.Parameters.AddWithValue("@Precio", product.Precio);
                    command.Parameters.AddWithValue("@Categoria", product.Categoria);
                    command.Parameters.AddWithValue("@Imagen", product.Imagen);
                    command.Parameters.AddWithValue("@Marca", product.Marca);
                    command.Parameters.AddWithValue("@Genero", product.Genero);
                    

                    command.ExecuteNonQuery(); 
                }
            }
        }


        public void updateProduct(Product product)
        {

            Product oProducto= getProductByid(Int32.Parse(product.ProductId));
            if (oProducto != null)
            {
                oProducto.ProductName = product.ProductName is null? oProducto.ProductName: product.ProductName;
                oProducto.Stock = product.Stock is null? oProducto.Stock: product.Stock;
                oProducto.Precio= product.Precio is null? oProducto.Precio: product.Precio;
                oProducto.Categoria=product.Categoria is null ? oProducto.Categoria: product.Categoria;
                oProducto.Imagen=product.Imagen is null? oProducto.Imagen: product.Imagen;
                oProducto.Marca=product.Marca is null? oProducto.Marca: product.Marca;
                oProducto.Genero=product.Genero is null? oProducto.Genero: product.Genero;
            }
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
               

                connection.Open();

                //String sql = @"UPDATE DBO.PRODUCT SET " +
                //    "PRODUCTNAME='" + oProducto.ProductName + "'," +
                //    "STOCK='" + oProducto.Stock + "'," +
                //    "PRECIO='" + oProducto.Precio.ToString().Replace(',', '.') + "'," +
                //    "CATEGORIA='" + oProducto.Categoria + "'," +
                //    "IMAGEN='" + oProducto.Imagen + "'," +
                //    "MARCA='" + oProducto.Marca + "'," +
                //    "GENERO='" + oProducto.Genero + "' WHERE ID='" + oProducto.ProductId + "'";
                String sql = @"UPDATE DBO.PRODUCT SET " +
                           "PRODUCTNAME=@ProductName," +
                           "STOCK=@Stock," +
                           "PRECIO=@Precio," +
                           "CATEGORIA=@Categoria," +
                           "IMAGEN=@Imagen," +
                           "MARCA=@Marca," +
                           "GENERO=@Genero WHERE ID=@ProductId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", oProducto.ProductName);
                    command.Parameters.AddWithValue("@Stock", oProducto.Stock);
                    command.Parameters.AddWithValue("@Precio", oProducto.Precio);
                    command.Parameters.AddWithValue("@Categoria", oProducto.Categoria);
                    command.Parameters.AddWithValue("@Imagen", oProducto.Imagen);
                    command.Parameters.AddWithValue("@Marca", oProducto.Marca);
                    command.Parameters.AddWithValue("@Genero", oProducto.Genero);
                    command.Parameters.AddWithValue("@ProductId", oProducto.ProductId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void updateStock(ProductStock product)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                

                connection.Open();

                //String sql = @"UPDATE DBO.PRODUCT SET " +

                //    "STOCK='" + product.Stock  + "' WHERE ID='" + product.ProductId + "'";
                String sql = @"UPDATE DBO.PRODUCT SET STOCK=@Stock WHERE ID=@ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.Parameters.AddWithValue("@ID", product.ProductId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void deleteProduct(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
               

                connection.Open();

                String sql = @"DELETE DBO.PRODUCT WHERE ID=@ProductId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", id);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}