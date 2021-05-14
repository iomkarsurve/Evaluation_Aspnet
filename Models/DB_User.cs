using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApp.Models
{
    public class DB_User
    {
        List<User> userList = new List<User>()
        {
            new User(){Userid=1,firstname="admin",lastname="admin",Pass="1234",Email="admin@gmail.com"},
            new User(){Userid=2,firstname="Omkar",lastname="Surve",Pass="1234",Email="user@gmail.com"},

        };

        public List<User> GetAllUsers()
        {
            return userList;
        }

        public List<User> Add(User objUser)
        {
            userList.Add(objUser);
            return userList;
        }
    }
}
