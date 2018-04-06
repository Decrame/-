using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSproject
{
    static class UserData
    {
        //class methods
        static public void GenerateTestUserData()
        {
            defaultUsers = new List<User>();
            defaultUsers.Add(new User("admin","admin",UserType.ADMIN));
            defaultUsers.Add(new User("seller","seller",UserType.SELLER));
            defaultUsers.Add(new User("customer","customer",UserType.CUSTOMER));
        }

        static public User IsUserPassCorrect(string username, string password)
        {
            User user = null;
            user = (from userFromList in TestUsers
                    where userFromList.username.Equals(username) && userFromList.password.Equals(password)
                    select userFromList).SingleOrDefault();
            return user;
        }

        //class properties 
        static public List<User> TestUsers
        {
            get
            {
                return defaultUsers;
            }
            set { }
        }

        //class members
        static private List<User> defaultUsers;
    }
}
