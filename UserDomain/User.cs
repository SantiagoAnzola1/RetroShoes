using System.ComponentModel.DataAnnotations;

namespace UserDomain
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

    public class User
    {
        public string UserName { get; set; } = null;
        public string Email { get; set; } = null;
        public string Password { get; set; } = null;
        [RegularExpression("^[0-9]*", ErrorMessage = "Ingrese valores tipo Cedula/ID")]
        public string Cedula { get; set; } = null;

    }

    public class UserLog
    {
        
        public string Cedula { get; set; } = null;
        public string Password { get; set; } = null;


    }
}