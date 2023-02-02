using LoginAndRegistration.Models;
using System.Data.SqlClient;

namespace LoginAndRegistration.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();

       

        public SecurityService()
        {
            
        }

        public bool IsValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);
        }

    }
    public class MoreSecurityServices
    {
        NewUsersDAO newUsersDAO = new NewUsersDAO();

        public MoreSecurityServices()
        {
        }

        public bool IsValid(UserModel user)
        {
            return newUsersDAO.SaveUser(user);
        }
    }
}
