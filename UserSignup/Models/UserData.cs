using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        static private User validUser = new User();

        public static User GetUser()
        {
            return validUser;
        }

        public static void SetValues(string username, string email, string password)
        {
            validUser.Username = username;
            validUser.Email = email;
            validUser.Password = password;
        }
    }
}
