using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProductDomain;
using UserBusiness;
using UserDomain;
using Microsoft.AspNetCore.Cors;
namespace UserAPI.Controllers
{
    [EnableCors("ReglasCors")]
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private IConfiguration Configuration;

        public ProductController(ILogger<ProductController> logger, IConfiguration config)
        {
            _logger = logger;
            Configuration = config;
        }

        //[HttpPost("GetProductById")]
        //public IEnumerable<Product> GetProduct(Product product)
        //{
        //    ProductB productBusiness = new ProductB();
        //    return productBusiness.getProduct(product, Configuration.GetConnectionString("DefaultConnection"));

        //}

        [HttpGet("GetProductDB")]
        public IEnumerable<Product> GetProductDB()
        {
            ProductB productBusiness = new ProductB();
            return productBusiness.getProductDB(Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpGet("GetProductById/{id:int}")]
        public Product GetProduct(int id)
        {
            ProductB productBusiness = new ProductB();
            return productBusiness.getProduct(id, Configuration.GetConnectionString("DefaultConnection"));

        }




        [HttpGet("GetProductByCategory/{categoria}")]
        public IEnumerable<Product> GetProductByCategory(string categoria)
        {
            ProductB productBusiness = new ProductB();
            return productBusiness.getProductByCategoria(categoria, Configuration.GetConnectionString("DefaultConnection"));

        }
        [HttpGet("GetProductByGender/{gender}")]

        public IEnumerable<Product> GetProductByGenero(string gender)
        {
            ProductB productBusiness = new ProductB();
            return productBusiness.getProductByGenero(gender, Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpGet("GetStockById/{id:int}")]
        public Int32 GetStock(int id)
        {
            ProductB productBusiness = new ProductB();
            return productBusiness.getStock(id, Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpPost("CreateProduct")]
        public IEnumerable<Product> CreateUserDB(Product product)
        {
            ProductB productBusiness = new ProductB();
            productBusiness.createProduct(product, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getProductDB(Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpPut("UpdateProduct")]
        public Product UpdateProduct(Product product)
        {
            //Product oProducto = GetProduct(Int32.Parse(product.ProductId));
            //if (oProducto != null)
            //{
            //    oProducto.ProductName = product.ProductName is null ? oProducto.ProductName : product.ProductName;
            //    oProducto.Stock = product.Stock is null ? oProducto.Stock : product.Stock;
            //    oProducto.Precio = product.Precio is null? oProducto.Precio : product.Precio;
            //    oProducto.Categoria = product.Categoria is null ? oProducto.Categoria : product.Categoria;
            //    oProducto.Imagen = product.Imagen is null ? oProducto.Imagen : product.Imagen;
            //    oProducto.Marca = product.Marca is null ? oProducto.Marca : product.Marca;
            //    oProducto.Genero = product.Genero is null ? oProducto.Genero : product.Genero;
            //}
            ProductB productBusiness = new ProductB();
            productBusiness.updateProduct(product, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getProduct(Int32.Parse(product.ProductId), Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpPut("UpdateStock")]
        public IEnumerable<Product> UpdateStock(ProductStock product)
        {
            ProductB productBusiness = new ProductB();
            productBusiness.updateStock(product, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getProductDB(Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpDelete("DeleteProduct/{id:int}")]
        public IEnumerable<Product> DeleteUserDB(int id)
        {
            ProductB productBusiness = new ProductB();
            productBusiness.deleteProduct(id, Configuration.GetConnectionString("DefaultConnection"));
            return productBusiness.getProductDB( Configuration.GetConnectionString("DefaultConnection"));

        }

    }
}