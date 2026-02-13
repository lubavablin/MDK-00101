using ClassLibrery.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrery.Models
{
    public class MemoryUserModel: IUsersModel
    {
        List<User> users = new List<User>();
        public MemoryUserModel()
        {
            users.Add(new User { Login = "abc", Password = "123", Name = " Vasily" });
            users.Add(new User { Login = "klm", Password = "567", Name = " KirillDura" });
            users.Add(new User { Login = "qqq", Password = "321", Name = " Gosha" });
        }
        public bool Register(User user)
        {
            int CountLeght = users.Count();
            users.Add(user);
            return CountLeght < users.Count();
        }

        public List<User> UpUserData()
        {
            return users;
        }
    }
}
