
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.ComponentModel.DataAnnotations;

namespace WebAppV2.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductId { get; set; }
        [Key]
        public string Stock { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public string Marca { get; set; }
        public string Genero { get; set; }

        public Product(string productName, string productId, string stock, decimal precio, string categoria, string imagen, string marca, string genero) 
        {
            ProductName = productName;
            ProductId = productId;
            Stock = stock;
            Precio = precio;
            Categoria = categoria;
            Imagen= imagen;
            Marca = marca;
            Genero = genero;
        }
        public Product() 
        {
            
        }

    }

    public class ProductStock
    {
        public string ProductId { get; set; }
        public string Stock { get; set; } = null;

    }

}
