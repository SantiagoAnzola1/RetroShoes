
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.ComponentModel.DataAnnotations;

namespace WebAppV2.Models
{

    public class PedidoDetalle
    {
        public string Cedula { get; set; }
        public string ProductId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioIndividual { get; set; }
        public decimal Precio { get; set; }

    }
}
