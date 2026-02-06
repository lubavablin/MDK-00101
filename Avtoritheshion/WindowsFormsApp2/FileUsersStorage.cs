using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class FileUsersStorage : IUserInterface
    {
        public List<User> Load()
        {
            List<User> result = new List<User>();
            StreamReader Sr = new StreamReader("D:\\п30\\rep\\Avtoritheshion\\Parolle.txt");
            string line;
            while ((line = Sr.ReadLine()) !=null)
            {
                string[] UserInformation = line.Split('-');
                User user = new User(UserInformation[0], UserInformation[1]);
                result.Add(user);
            }
            return result;
        }
        public bool CheckUser(string User)
        {
            return true;
        }
        public string AddUsers(User X)
        {
            return ("Пользователь зарегестрирован, Поздравляю!!!");
        }
    }
}
