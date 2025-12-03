using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1._1
{
    class FixedSalaryEmployee
    {
        public class FixedSalaryEmploye : Employee
        {
            public decimal MonthlySalary { get; set; }

            public FixedSalaryEmploye(int id, string fullName, string email, decimal monthlySalary, ISystemAccess systemRole)
                : base(id, fullName, email, systemRole)
            {
                MonthlySalary = monthlySalary;
            }

            public override decimal CalculateSalary()
            {
                return MonthlySalary;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                {
                    Console.WriteLine($"Тип оплаты: Фиксированная месячная оплата");
                    Console.WriteLine($"Месячный оклад: {MonthlySalary:C}");
                }
            }
        }
    }
}
