using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1._1
{
    class Program
    {
     
            public class ManagerRole : ISystemAccess
        {
            private readonly List<string> _accessibleModules = new List<string>
    {
        "Dashboard", "Reports", "EmployeeManagement", "Analytics"
    };

            public void Login()
            {
                Console.WriteLine("Менеджер выполнил вход в систему");
            }

            public void Logout()
            {
                Console.WriteLine("Менеджер выполнил выход из системы");
            }

            public bool HasAccessToModule(string moduleName)
            {
                return _accessibleModules.Contains(moduleName);
            }
        }

        public class AccountantRole : ISystemAccess
        {
            private readonly List<string> _accessibleModules = new List<string>
    {
        "Dashboard", "Payroll", "Invoices", "TaxReports"
    };

            public void Login()
            {
                Console.WriteLine("Бухгалтер выполнил вход в систему");
            }

            public void Logout()
            {
                Console.WriteLine("Бухгалтер выполнил выход из системы");
            }

            public bool HasAccessToModule(string moduleName)
            {
                return _accessibleModules.Contains(moduleName);
            }
        }

        public class DeveloperRole : ISystemAccess
        {
            private readonly List<string> _accessibleModules = new List<string>
    {
        "Dashboard", "CodeRepository", "Tasks", "Documentation"
    };

            public void Login()
            {
                Console.WriteLine("Разработчик выполнил вход в систему");
            }

            public void Logout()
            {
                Console.WriteLine("Разработчик выполнил выход из системы");
            }

            public bool HasAccessToModule(string moduleName)
            {
                return _accessibleModules.Contains(moduleName);
            }
        }

    }
}

