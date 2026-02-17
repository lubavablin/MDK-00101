using ClassLibrery.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrery.Views
{
    public class UserTableView1 : DataGridView, IUserView
    {
        public List<User> GetSelectedUsers()
        {
            List<User> result = new List<User>();
            foreach (DataGridViewRow row in SelectedRows)
            {
                result.Add(row.DataBoundItem as User);
            }
           // MessageBox.Show(result[0].Name);

            return result;
        }
        public void ShowUsers(List<User> users)
        {
            DataSource = null;
            DataSource = users;
        }
    }
}
