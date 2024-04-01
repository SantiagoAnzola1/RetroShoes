namespace WebAppV2.Models
{



        public class Orden
        {
            public int PedidosId { get; set; }//1 SI //2 NO
            public string ClienteId { get; set; }
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioIndividual { get; set; }
            public decimal Precio { get; set; }
            public decimal PrecioTotal { get; set; }

            public string Categoria { get; set; }
            public string Imagen { get; set; }
            public string Marca { get; set; }
            public string Genero { get; set; }
            public string Entrega { get; set; }//1 SI //2 NO
            public Boolean EsEntregado { get; set; }//1 SI //2 NO


        }
        public class OrdenBasic
        {
            public int PedidosId { get; set; }//1 SI //2 NO
            public string ClienteId { get; set; }
            public decimal PrecioTotal { get; set; }
            public string Entrega { get; set; }//1 SI //2 NO
            public Boolean EsEntregado { get; set; }//1 SI //2 NO


        }
   
}
