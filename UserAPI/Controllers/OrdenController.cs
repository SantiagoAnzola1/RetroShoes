using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProductDomain;
using UserBusiness;
using UserDomain;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdenController : ControllerBase
    {
        private readonly ILogger<OrdenController> _logger;
        private IConfiguration Configuration;

        public OrdenController(ILogger<OrdenController> logger, IConfiguration config)
        {
            _logger = logger;
            Configuration = config;
        }

        [HttpPost("GetOrdenByCLienteID")]
        public IEnumerable<Orden> GetOrdenByCLienteID(Orden orden)
        {
            OrdenB productBusiness = new OrdenB();
            return productBusiness.getPedidoByUsername(orden, Configuration.GetConnectionString("DefaultConnection"));

        }        
        
        [HttpGet("GetOrdenDB")]
        public IEnumerable<Orden> GetOrdenDB()
        {
            OrdenB productBusiness = new OrdenB();
            return productBusiness.getPedidosDB( Configuration.GetConnectionString("DefaultConnection"));

        }        
        [HttpPost("GetSumaTotal")]
        public Decimal GetSumaTotal(Orden orden)
        {
            OrdenB productBusiness = new OrdenB();
            return productBusiness.getSumaTotal(orden, Configuration.GetConnectionString("DefaultConnection"));

        }



        [HttpPost("CreateOrden")]
        public IEnumerable<Orden> CreateOrden(Orden product)
        {
            OrdenB productBusiness = new OrdenB();
            productBusiness.createOrden(product, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getPedidosDB(Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpPost("UpdateOrden")]
        public IEnumerable<Orden> UpdateOrden(Orden product)
        {
            OrdenB productBusiness = new OrdenB();
            productBusiness.updatePedido(product, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getPedidosDB(Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpPost("DeleteOrden")]
        public IEnumerable<Orden> DeleteOrden(Orden product)
        {
            OrdenB productBusiness = new OrdenB();
            productBusiness.deletePedido(product, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getPedidosDB( Configuration.GetConnectionString("DefaultConnection"));

        }

    }
}