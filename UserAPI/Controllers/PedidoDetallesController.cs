using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProductDomain;
using UserBusiness;
using UserDomain;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoDetallesController : ControllerBase
    {
        private readonly ILogger<PedidoDetallesController> _logger;
        private IConfiguration Configuration;

        public PedidoDetallesController(ILogger<PedidoDetallesController> logger, IConfiguration config)
        {
            _logger = logger;
            Configuration = config;
        }

        [HttpGet("GetPedidosDB")]
        public IEnumerable<PedidoDetalle> GetProduct()
        {
            PedidoDetallesB productBusiness = new PedidoDetallesB();
            return productBusiness.getPedidosDB( Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpPost("GetProductByUserID")]
        public IEnumerable<PedidoDetalle> GetProductByUserID(PedidoDetalle pedido)
        {
            PedidoDetallesB productBusiness = new PedidoDetallesB();
            return productBusiness.getPedidoByUsername(pedido,Configuration.GetConnectionString("DefaultConnection"));

        }


        [HttpPost("CreatePedido")]
        public IEnumerable<PedidoDetalle> CreatePedido(PedidoDetalle product)
        {
            PedidoDetallesB productBusiness = new PedidoDetallesB();
            productBusiness.createPedido(product, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getPedidosDB(Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpPost("UpdatePedido")]
        public IEnumerable<PedidoDetalle> UpdatePedido(PedidoDetalle product)
        {
            PedidoDetallesB productBusiness = new PedidoDetallesB();
            productBusiness.updatePedido(product, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getPedidosDB(Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpPost("DeleteProduct")]
        public IEnumerable<PedidoDetalle> DeleteProduct(PedidoDetalle product)
        {
            PedidoDetallesB productBusiness = new PedidoDetallesB();
            productBusiness.deleteProduct(product, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getPedidosDB( Configuration.GetConnectionString("DefaultConnection"));

        }

    }
}