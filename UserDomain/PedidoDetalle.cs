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

    
    public class PedidoDetalle
    {
        public string Cedula { get; set; }
        public string ProductId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioIndividual { get; set; }
        public decimal Precio { get; set; }
       
    }

}