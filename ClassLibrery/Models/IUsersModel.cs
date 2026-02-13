using ClassLibrery.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrery.Models
{
    internal interface IUsersModel
    {
        List<User> UpUserData();
        bool Register(User users);
    }
}
