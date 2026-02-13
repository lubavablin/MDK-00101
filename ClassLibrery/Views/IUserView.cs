using ClassLibrery.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrery.Views
{
    public interface IUserView
    {
        void ShowUsers (List<User> users);
    }
}
