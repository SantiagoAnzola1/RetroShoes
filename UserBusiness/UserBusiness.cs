using UserDomain;
using UserDBModel;
namespace UserBusiness
{
    public class UserB
    {
        public UserB()
        { 
        }

        public User getUser (long userID, string ConnectionString)
        { 
                  
            UserDB userDB = new UserDB(ConnectionString);

            User Users = new User();
            Users =userDB.getUsersByid(userID);
            return Users;
        }
 

        public IEnumerable<User> getUsersDB(string ConnectionString)
        {
            UserDB userDB = new UserDB(ConnectionString);
            
            IEnumerable<User> users = new List<User>();
            users= userDB.getUsers();


            return users;
        }

        public void createUser(User user, string ConnectionString)
        {
            UserDB userDB = new UserDB(ConnectionString);
            userDB.createUser(user);
        }

        public void updateUser(User user, string ConnectionString)
        {
            UserDB userDB = new UserDB(ConnectionString);
            userDB.updateUser(user);
        }

        public void deleteUser(long userID, string ConnectionString)
        {
            UserDB userDB = new UserDB(ConnectionString);
            userDB.deleteUser(userID);
        }
        public Boolean isRegister(long userID, string ConnectionString)
        {
            UserDB userDB = new UserDB(ConnectionString);
            return userDB.getIsRegister(userID);
        }public Boolean isLogged(UserLog user, string ConnectionString)
        {
            UserDB userDB = new UserDB(ConnectionString);
            return userDB.isLogged(user);
        }
    }
}