using ClassLibrery.Models;
using ClassLibrery.ModelViews;
using ClassLibrery.Presents;
using ClassLibrery.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrery
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserTableView1 tableView = new UserTableView1();
            Controls.Add(tableView);
            tableView.Dock = DockStyle.Fill;
            UserPresenter user = new UserPresenter(new MemoryUserModel(), tableView);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
          //  List<User> selectedUsers = IUserView.
        }
    }
}
