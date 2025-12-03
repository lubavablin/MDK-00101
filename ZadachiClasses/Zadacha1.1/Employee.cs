using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1._1
{
    class Employee
    {
        public abstract class Employees
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public ISystemAccess SystemRole { get; set; }

            protected Employees(int id, string fullName, string email, ISystemAccess systemRole)
            {
                Id = id;
                FullName = fullName;
                Email = email;
                SystemRole = systemRole;
            }

            public abstract decimal CalculateSalary();

        }
    }
