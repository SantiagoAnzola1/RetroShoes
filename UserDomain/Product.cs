using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ProductDomain
{

    //CREATE TABLE UMUSER
    //(
    //USERNAME VARCHAR(50),
    //PASSWORD VARCHAR(50),
    //FSNAME VARCHAR(100),
    //LASTNAME VARCHAR(100),
    //EMAIL VARCHAR(200),
    //PHONE NUMERIC(18,0),
    //DOBIRTHDAY DATE
    //)

    
    public class Product
    {
        //public string ProductName { get; set; }
        //public string ProductId { get; set; }
        //public string Stock { get; set; }
        //public decimal Precio { get; set; }
        //public string Categoria { get; set; }
        //public string Imagen { get; set; }
        //public string Marca { get; set; }
        //public string Genero { get; set; }
        public string ProductName { get; set; } = null;
        public string ProductId { get; set; }
        public string Stock { get; set; } = null;
        public decimal? Precio { get; set; } = null; // Ahora Precio es nullable
        public string Categoria { get; set; } = null;
        public string Imagen { get; set; } = null;
        public string Marca { get; set; } = null;
        public string Genero { get; set; } = null;
    }
    public class ProductStock
    {
        public string ProductId { get; set; }
        public string Stock { get; set; } = null;

    }

}