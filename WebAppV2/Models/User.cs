using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.ComponentModel.DataAnnotations;

namespace WebAppV2.Models
{
    public class User
    {

        public string UserName { get; set; } = null;
        public string Email { get; set; } = null;
        public string Password { get; set; } = null;

        [Key]
        //[Range(0, int.MaxValue, ErrorMessage ="Ingrese valores tipo Cedula/ID")]
        //[RegularExpression("^[0-9]*", ErrorMessage = "Ingrese valores tipo Cedula/ID")]
        //[RegularExpression(@"^\[0-9]\d{0,2}(\.\d{0,1})?$", ErrorMessage = "Valor invalido")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered CONTACT_NUMBER format is not valid.")]
        public string Cedula { get; set; } = null;

    }
    public class UserLog
    {

        public string Cedula { get; set; } = null;
        public string Password { get; set; } = null;


    }
}