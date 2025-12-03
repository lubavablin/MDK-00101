using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1._1
{
    class ISystemAccess
    {
        public interface ISystemAcces
        {
            void Login();
            void Logout();
            bool HasAccessToModule(string moduleName);
        }
    }
}
