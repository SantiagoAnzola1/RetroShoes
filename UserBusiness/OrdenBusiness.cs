using UserDomain;
using UserDBModel;
using ProductDomain;

namespace UserBusiness
{
    public class OrdenB
    {

        //public IEnumerable<Orden> getPedidosDB (string ConnectionString)
        //{

        //    OrdenDB pedidoDB = new OrdenDB(ConnectionString);

        //    IEnumerable<OrdenDB> pedido = new List<OrdenDB>();
        //    pedido = pedidoDB.();
        //    return pedido;
        //}

        public IEnumerable<Orden> getPedidosDB( string ConnectionString)
        {

            OrdenDB pedidoDB = new OrdenDB(ConnectionString);
            IEnumerable<Orden> Product = new List<Orden>();
            Product = pedidoDB.getPedidosDB();
            return Product;

        }
        public IEnumerable<Orden> getPedidoByUsername(Orden product, string ConnectionString)
        {

            OrdenDB pedidoDB = new OrdenDB(ConnectionString);
            IEnumerable<Orden> Product = new List<Orden>();
            Product = pedidoDB.getPedidosByClienteId(product);
            return Product;
            
        }
        public Decimal getSumaTotal(Orden product, string ConnectionString)
        {

            OrdenDB pedidoDB = new OrdenDB(ConnectionString);
            
            decimal Product = pedidoDB.GetSumaTotal(product);
            return Product;
        }

        public void createOrden(Orden product, string ConnectionString)
        {
            OrdenDB pedidoDB = new OrdenDB(ConnectionString);
            pedidoDB.createOrden(product);
        }

        public void updatePedido(Orden product, string ConnectionString)
        {
            OrdenDB pedidoDB = new OrdenDB(ConnectionString);
            pedidoDB.updateOrden(product);
        }

        public void deletePedido(Orden product, string ConnectionString)
        {
            OrdenDB pedidoDB = new OrdenDB(ConnectionString);
            pedidoDB.deleteOrden(product);
        }

    }
}