using ProductDomain;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UserDomain;

namespace UserDBModel
{
    public class OrdenDB
    {

        private string ConnectionString;

        

        public OrdenDB(string ConnectionString) { 
            this.ConnectionString = ConnectionString;
        }

        public IEnumerable<Orden> getPedidosDB()
        {

            var productList = new List<Orden>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                connection.Open();

                String sql = "SELECT  PEDIDO_DETALLE.CLIENTE_ID, PEDIDO_DETALLE.PRODUCT_ID,PEDIDO_DETALLE.CANTIDAD , PEDIDO_DETALLE.PRECIO_INDIVIDUAL, PEDIDO_DETALLE.PRECIO,  PRODUCT.PRODUCTNAME, PRODUCT.IMAGEN,PRODUCT.CATEGORIA,PRODUCT.GENERO, PRODUCT.MARCA, PEDIDOS.PEDIDOSID, PEDIDOS.TOTAL, PEDIDOS.ENTREGA, PEDIDOS.ES_ENTREGADO FROM DBO.PRODUCT INNER JOIN  PEDIDO_DETALLE ON PRODUCT.ID=PEDIDO_DETALLE.PRODUCT_ID INNER JOIN  UMUSER ON PEDIDO_DETALLE.CLIENTE_ID=UMUSER.ID INNER JOIN PEDIDOS ON PEDIDOS.CLIENTE_ID=PEDIDO_DETALLE.CLIENTE_ID ";


                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Orden productTemp = new Orden();
                            productTemp.ClienteId = reader.GetDecimal(0).ToString();
                            productTemp.ProductId = reader.GetInt32(1).ToString();
                            productTemp.Cantidad = reader.GetInt32(2);
                            productTemp.PrecioIndividual = reader.GetDecimal(3);
                            productTemp.Precio = reader.GetDecimal(4);
                            productTemp.ProductName = reader.GetString(5);
                            productTemp.Imagen = reader.GetString(6);
                            productTemp.Categoria = reader.GetString(7);
                            productTemp.Genero = reader.GetString(8);
                            productTemp.Marca = reader.GetString(9);
                            productTemp.PedidosId = reader.GetInt32(10);
                            productTemp.PrecioTotal = reader.GetDecimal(11);
                            productTemp.Entrega = reader.GetString(12);
                            productTemp.EsEntregado = reader.GetBoolean(13);


                            productList.Add(productTemp);
                        }
                    }
                }
            }

            return productList;

        }

        public IEnumerable<Orden> getPedidosByClienteId(Orden orden)
        {
            
            var productList = new List<Orden>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT  PEDIDO_DETALLE.CLIENTE_ID, PEDIDO_DETALLE.PRODUCT_ID,PEDIDO_DETALLE.CANTIDAD , PEDIDO_DETALLE.PRECIO_INDIVIDUAL, PEDIDO_DETALLE.PRECIO,  PRODUCT.PRODUCTNAME, PRODUCT.IMAGEN,PRODUCT.CATEGORIA,PRODUCT.GENERO, PRODUCT.MARCA, PEDIDOS.PEDIDOSID, PEDIDOS.TOTAL, PEDIDOS.ENTREGA, PEDIDOS.ES_ENTREGADO FROM DBO.PRODUCT INNER JOIN  PEDIDO_DETALLE ON PRODUCT.ID=PEDIDO_DETALLE.PRODUCT_ID INNER JOIN  UMUSER ON PEDIDO_DETALLE.CLIENTE_ID=UMUSER.ID INNER JOIN PEDIDOS ON PEDIDOS.CLIENTE_ID=PEDIDO_DETALLE.CLIENTE_ID  WHERE PEDIDO_DETALLE.CLIENTE_ID='" + orden.ClienteId + "' ";


                using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               Orden productTemp = new Orden();
                                productTemp.ClienteId = reader.GetDecimal(0).ToString();
                                productTemp.ProductId = reader.GetInt32(1).ToString();
                                productTemp.Cantidad = reader.GetInt32(2);
                                productTemp.PrecioIndividual = reader.GetDecimal(3);
                                productTemp.Precio= reader.GetDecimal(4);
                                productTemp.ProductName= reader.GetString(5);
                                productTemp.Imagen= reader.GetString(6);
                                productTemp.Categoria= reader.GetString(7);
                                productTemp.Genero = reader.GetString(8);
                                productTemp.Marca = reader.GetString(9);
                                productTemp.PedidosId= reader.GetInt32(10);
                                productTemp.PrecioTotal= reader.GetDecimal(11);
                                productTemp.Entrega= reader.GetString(12);
                                productTemp.EsEntregado= reader.GetBoolean(13);



                            productList.Add(productTemp);
                            }
                        }
                    }
                }
            
            return productList;
           
        }


        public decimal GetSumaTotal(Orden orden)
        {
            decimal Precio = 0;

                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT SUM(PEDIDO_DETALLE.PRECIO) from PEDIDO_DETALLE INNER JOIN  PRODUCT ON PRODUCT.ID=PEDIDO_DETALLE.PRODUCT_ID INNER JOIN  UMUSER ON PEDIDO_DETALLE.CLIENTE_ID=UMUSER.ID WHERE CLIENTE_ID='" + orden.ClienteId + "' ";


                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Orden productTemp = new Orden();
                               
                                productTemp.PrecioTotal = reader.GetDecimal(0);
                                Precio= reader.GetDecimal(0);
                        }
                        }
                    }
                }
                
               
            
            return Precio;
        }



        public void createOrden(Orden orden)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                connection.Open();

                String sql = @"INSERT INTO DBO.PEDIDOS VALUES 
                    ('" + orden.ClienteId + "'," +
                    "'" + orden.PrecioTotal.ToString().Replace(',', '.') + "'," +
                    "'" + orden.Entrega + "'," +
                    "'" + orden.EsEntregado+"')";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery(); 
                }
            }
        }



        public void updateOrden(Orden product)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                connection.Open();

                String sql = @"UPDATE DBO.PEDIDOS SET " +
                    
                    "CLIENTE_ID='" + product.ProductId + "'," +
                    "TOTAL='" + product.PrecioTotal.ToString().Replace(',', '.') + "'," +
                    "ENTREGA='" + product.Entrega + "'," +
                    "ES_ENTREGADO='" + product.EsEntregado + "' WHERE CLIENTE_ID='" + product.ClienteId + "'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void deleteOrden(Orden product)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                connection.Open();

                String sql = @"DELETE DBO.PEDIDOS WHERE CLIENTE_ID='" + product.ClienteId + "'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}