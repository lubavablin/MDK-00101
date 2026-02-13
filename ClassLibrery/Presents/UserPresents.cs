using ClassLibrery.Models;
using ClassLibrery.ModelViews;
using ClassLibrery.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrery.Presents
{
    class UserPresents
    {
        private IUsersModel model_;
        private IUserView view_;

        public UserPresents(IUsersModel model, IUserView view)
        {
            model_ = model;
            view_ = view;
            List<User> userModel = model_.UpUserData();
            view_.ShowUsers(userModel);
        }

    }
}
