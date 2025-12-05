using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    // Класс для сотрудника с почасовой оплатой
    public class HourlySalaryEmployee
    {
        private int id_;
        private string fullName_;
        private string email_;
        private decimal hourlyRate_;
        private int hoursWorked_;
        private int overtimeHours_;

        // Конструктор с параметрами
        public HourlySalaryEmployee(int id, string fullName, string email, decimal hourlyRate, int hoursWorked, int overtimeHours = 0)
        {
            id_ = id;
            fullName_ = fullName;
            email_ = email;
            hourlyRate_ = hourlyRate;
            hoursWorked_ = hoursWorked;
            overtimeHours_ = overtimeHours;
        }

        // Метод расчета зарплаты для почасового сотрудника
        public decimal CalculateSalary()
        {
            decimal regularHoursPay = hourlyRate_ * hoursWorked_;
            decimal overtimePay = overtimeHours_ * hourlyRate_ * 1.5m;
            return regularHoursPay + overtimePay;
        }

        // Метод вывода информации
        public void PrintInfo()
        {
            Console.WriteLine($"Сотрудник: {fullName_}");
            Console.WriteLine($"ID: {id_}, Email: {email_}");
            Console.WriteLine($"Почасовая ставка: {hourlyRate_} руб./час");
            Console.WriteLine($"Отработано часов: {hoursWorked_}");
            Console.WriteLine($"Сверхурочные часы: {overtimeHours_}");
            Console.WriteLine($"Зарплата: {CalculateSalary()} руб.");
        }
    }
}
