using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UserDomain;

namespace UserDBModel
{
    public class UserDB
    {

        private string ConnectionString;

        

        public UserDB(string ConnectionString) { 
            this.ConnectionString = ConnectionString;
        }

        public IEnumerable<User> getUsers()
        {
            
            var userList = new List<User>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    
                    connection.Open();

                    String sql = "SELECT USERNAME,EMAIL,PASSWORD,ID FROM DBO.UMUSER";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User userTemp = new User();
                                userTemp.UserName = reader.GetString(0);
                                userTemp.Email = reader.GetString(1);
                                userTemp.Password = reader.GetString(2);
                                userTemp.Cedula = reader.GetDecimal(3).ToString();

                            userList.Add(userTemp);
                            }
                        }
                    }
                }
            
            return userList;
           
        }

        public User getUsersByid(long userId)
        {

     

            User user = new User();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
             
                connection.Open();

                String sql = "SELECT USERNAME,EMAIL,PASSWORD,ID FROM DBO.UMUSER WHERE ID=@ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", userId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) {

                            User userTemp = new User();
                            userTemp.UserName = reader.GetString(0);
                            userTemp.Email = reader.GetString(1);
                            userTemp.Password = reader.GetString(2);
                            userTemp.Cedula = reader.GetDecimal(3).ToString();
                            user=(userTemp);
                        }
                     
                    }
                }
            }

            return user;

        }



        //public Int32 getIsRegister(int userId)
        public Boolean getIsRegister(long userId)
        {

            Int32 usuario=0;
            SqlConnection conexion = new SqlConnection(this.ConnectionString);

                conexion.Open();

              String sql = "SELECT COUNT(*) FROM DBO.UMUSER WHERE ID=@ID";




            SqlCommand cmd = new SqlCommand(sql, conexion)
                {
                    CommandType = System.Data.CommandType.Text
                    
                };
            cmd.Parameters.AddWithValue("@ID", userId);
            usuario = Convert.ToInt32(cmd.ExecuteScalar());


            if (usuario < 1) { return false; } else { return true; }
            //return usuario;


        }
         public Boolean isLogged(UserLog user)
        {

            Int32 usuario=0;
            SqlConnection conexion = new SqlConnection(this.ConnectionString);

                conexion.Open();

            String sql = "SELECT COUNT(*) FROM DBO.UMUSER WHERE ID=@ID AND PASSWORD=@Password COLLATE SQL_Latin1_General_CP1_CS_AS";


            SqlCommand cmd = new SqlCommand(sql, conexion)
                {


                    CommandType = System.Data.CommandType.Text
                    
                };
            cmd.Parameters.AddWithValue("@ID", user.Cedula);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            usuario = Convert.ToInt32(cmd.ExecuteScalar());
                
                Console.WriteLine("InfoToolsSV"+usuario);
            if (usuario < 1) { return false; } else { return true; }
            
        }

        public void createUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                

                connection.Open();

                String sql = @"INSERT INTO DBO.UMUSER (USERNAME,EMAIL,PASSWORD,ID) VALUES 
                             (@UserName, @Email, @Password, @Cedula)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Cedula", user.Cedula);

                    command.ExecuteNonQuery(); 
                }
            }
        }


        public void updateUser(User user)
        {

            User oUser = getUsersByid(Int64.Parse(user.Cedula));
            if (oUser != null)
            {
                oUser.UserName = user.UserName is null? oUser.UserName:user.UserName;
                oUser.Email=user.Email is null? oUser.Email:user.Email;
                oUser.Password=user.Password is null? oUser.Password:user.Password;
                oUser.Cedula=user.Cedula is null? oUser.Cedula:user.Cedula;
            }
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                

                connection.Open();

                String sql = @"UPDATE DBO.UMUSER SET USERNAME=@UserName, EMAIL=@Email, PASSWORD=@Password WHERE ID=@Cedula";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserName", oUser.UserName);
                    command.Parameters.AddWithValue("@Email", oUser.Email);
                    command.Parameters.AddWithValue("@Password", oUser.Password);
                    command.Parameters.AddWithValue("@Cedula", oUser.Cedula);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void deleteUser( long userId)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
              

                connection.Open();

                String sql = @"DELETE DBO.UMUSER WHERE ID=@ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}