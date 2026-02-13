using ClassLibrery.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrery.Views
{
    class UserTableView1 : DataGridView, IUserView
    {
        public void ShowUsers(List<User> users)
        {
            DataSource = users;
        }
    }
}
