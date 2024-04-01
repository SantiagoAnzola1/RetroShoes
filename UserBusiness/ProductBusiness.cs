using UserDomain;
using UserDBModel;
using ProductDomain;

namespace UserBusiness
{
    public class ProductB
    {

        //public IEnumerable<Product> getProduct (Product product, string ConnectionString)
        //{ 

        //    ProductDB productDB = new ProductDB(ConnectionString);

        //    IEnumerable<Product> Product = new List<Product>();
        //    Product = productDB.getProductByid(product);
        //    return Product;
        //}
        public Product getProduct(int productId, string ConnectionString)
        {

            ProductDB productDB = new ProductDB(ConnectionString);

            Product Product = new Product();
            Product = productDB.getProductByid(productId);
            return Product;
        }


        public IEnumerable<Product> getProductDB(string ConnectionString)
        {

            ProductDB productDB = new ProductDB(ConnectionString);

            IEnumerable<Product> Product = new List<Product>();
            Product = productDB.getProducts();
            return Product;
            
        }

        public IEnumerable<Product> getProductByCategoria(string categoria, string ConnectionString)
        {

            ProductDB productDB = new ProductDB(ConnectionString);

            IEnumerable<Product> Product = new List<Product>();
            Product = productDB.getProductByCategoria(categoria);
            return Product;
        }
        public IEnumerable<Product> getProductByGenero(string genero, string ConnectionString)
        {

            ProductDB productDB = new ProductDB(ConnectionString);

            IEnumerable<Product> Product = new List<Product>();
            Product = productDB.getProductByGenero(genero);
            return Product;
        }
        public Int32 getStock(int id, string ConnectionString)
        {
            ProductDB productDB = new ProductDB(ConnectionString);
            return productDB.getStock(id);
        }

        public void createProduct(Product product, string ConnectionString)
        {
            ProductDB productDB = new ProductDB(ConnectionString);
            productDB.createProduct(product);
        }

        public void updateProduct(Product product, string ConnectionString)
        {
            ProductDB productDB = new ProductDB(ConnectionString);
            productDB.updateProduct(product);
        }
        public void updateStock(ProductStock product, string ConnectionString)
        {
            ProductDB productDB = new ProductDB(ConnectionString);
            productDB.updateStock(product);
        }

        public void deleteProduct(int id, string ConnectionString)
        {
            ProductDB productDB = new ProductDB(ConnectionString);
            productDB.deleteProduct(id);
        }

    }
}