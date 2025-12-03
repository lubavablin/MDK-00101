using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1._1
{
    class HourlySalaryEmployee
    {
        {
    public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public int OvertimeHours { get; set; }
        private const decimal OvertimeMultiplier = 1.5m; // Коэффициент сверхурочных

        public HourlySalaryEmployee(int id, string fullName, string email, decimal hourlyRate,
                                   int hoursWorked, int overtimeHours, ISystemAccess systemRole)
            : base(id, fullName, email, systemRole)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
            OvertimeHours = overtimeHours;
        }

        public override decimal CalculateSalary()
        {
            decimal regularPay = HoursWorked * HourlyRate;
            decimal overtimePay = OvertimeHours * HourlyRate * OvertimeMultiplier;
            return regularPay + overtimePay;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип оплаты: Почасовая оплата");
            Console.WriteLine($"Ставка в час: {HourlyRate:C}");
            Console.WriteLine($"Отработано часов: {HoursWorked}");
            Console.WriteLine($"Сверхурочные часы: {OvertimeHours}");
        }
    }
}
}
