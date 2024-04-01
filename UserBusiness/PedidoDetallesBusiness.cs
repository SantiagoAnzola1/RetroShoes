using UserDomain;
using UserDBModel;
using ProductDomain;

namespace UserBusiness
{
    public class PedidoDetallesB
    {
       
        public IEnumerable<PedidoDetalle> getPedidosDB (string ConnectionString)
        {

            PedidoDetalleDB pedidoDB = new PedidoDetalleDB(ConnectionString);

            IEnumerable<PedidoDetalle> pedido = new List<PedidoDetalle>();
            pedido = pedidoDB.getPedidos();
            return pedido;
        }
 

        public IEnumerable<PedidoDetalle> getPedidoByUsername(PedidoDetalle product, string ConnectionString)
        {

            PedidoDetalleDB pedidoDB = new PedidoDetalleDB(ConnectionString);
            IEnumerable<PedidoDetalle> Product = new List<PedidoDetalle>();
            Product = pedidoDB.getPedidoByUsername(product);
            return Product;
            
        }

        public void createPedido(PedidoDetalle product, string ConnectionString)
        {
            PedidoDetalleDB pedidoDB = new PedidoDetalleDB(ConnectionString);
            pedidoDB.createPedido(product);
        }

        public void updatePedido(PedidoDetalle product, string ConnectionString)
        {
            PedidoDetalleDB pedidoDB = new PedidoDetalleDB(ConnectionString);
            pedidoDB.updatePedido(product);
        }

        public void deleteProduct(PedidoDetalle product, string ConnectionString)
        {
            PedidoDetalleDB pedidoDB = new PedidoDetalleDB(ConnectionString);
            pedidoDB.deleteProductinPedido(product);
        }

    }
}