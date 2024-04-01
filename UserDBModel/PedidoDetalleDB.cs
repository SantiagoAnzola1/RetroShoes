using ProductDomain;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UserDomain;

namespace UserDBModel
{
    public class PedidoDetalleDB
    {

        private string ConnectionString;

        

        public PedidoDetalleDB(string ConnectionString) { 
            this.ConnectionString = ConnectionString;
        }

        public IEnumerable<PedidoDetalle> getPedidos()
        {
            
            var productList = new List<PedidoDetalle>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT CLIENTE_ID,PRODUCT_ID,CANTIDAD,PRECIO_INDIVIDUAL,PRECIO FROM DBO.PEDIDO_DETALLE";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            PedidoDetalle productTemp = new PedidoDetalle();
                                productTemp.Cedula = reader.GetDecimal(0).ToString();
                                productTemp.ProductId = reader.GetInt32(1).ToString();
                                productTemp.Cantidad = reader.GetInt32(2);
                                productTemp.PrecioIndividual = reader.GetDecimal(3);
                                productTemp.Precio= reader.GetDecimal(4);



                            productList.Add(productTemp);
                            }
                        }
                    }
                }
            
            return productList;
           
        }

        public IEnumerable<PedidoDetalle> getPedidoByUsername(PedidoDetalle pedido)
        {



            var productList = new List<PedidoDetalle>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                connection.Open();

                

                String sql = "SELECT CLIENTE_ID,PRODUCT_ID,CANTIDAD,PRECIO_INDIVIDUAL,PRECIO FROM DBO.PEDIDO_DETALLE WHERE CLIENTE_ID='" + pedido.Cedula+ "' ";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PedidoDetalle productTemp = new PedidoDetalle();
                            productTemp.Cedula = reader.GetDecimal(0).ToString();
                            productTemp.ProductId = reader.GetInt32(1).ToString();
                            productTemp.Cantidad = reader.GetInt32(2);
                            productTemp.PrecioIndividual = reader.GetDecimal(3);
                            productTemp.Precio = reader.GetDecimal(4);



                            productList.Add(productTemp);
                        }
                    }
                }
            }

            return productList;

        }


        public void createPedido(PedidoDetalle product)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                connection.Open();

                String sql = @"INSERT INTO DBO.PEDIDO_DETALLE VALUES 
                    ('" + product.Cedula + "'," +
                    "'" + product.ProductId + "'," +
                    "'" + product.Cantidad + "'," +
                    "'" + product.PrecioIndividual.ToString().Replace(',','.')+"')";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery(); 
                }
            }
        }



        public void updatePedido(PedidoDetalle product)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                connection.Open();

                String sql = @"UPDATE DBO.PEDIDO_DETALLE SET " +
                    
                    "PRODUCT_ID='" + product.ProductId + "'," +
                    "CANTIDAD='" + product.Cantidad + "'," +
                    "PRECIO_INDIVIDUAL='" + product.PrecioIndividual + "' WHERE CLIENTE_ID='" + product.Cedula + "'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void deleteProductinPedido(PedidoDetalle product)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                connection.Open();

                String sql = @"DELETE DBO.PEDIDO_DETALLE WHERE PRODUCT_ID='" + product.ProductId + "' AND CLIENTE_ID='" + product.Cedula + "' ";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}