using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    // Класс для сотрудника с фиксированной зарплатой
    public class FixedSalaryEmployee
    {
        private int id_;
        private string fullName_;
        private string email_;
        private decimal monthlySalary_;

        // Конструктор - метод, который вызывается при создании объекта
        public FixedSalaryEmployee(int id, string fullName, string email, decimal salary)
        {
            id_ = id;
            fullName_ = fullName;
            email_ = email;
            monthlySalary_ = salary;
        }

        // Метод для расчета зарплаты
        public decimal CalculateSalary()
        {
            return monthlySalary_;
        }

        // Метод для вывода информации о сотруднике
        public void PrintInfo()
        {
            Console.WriteLine($"Сотрудник: {fullName_}");
            Console.WriteLine($"ID: {id_}, Email: {email_}");
            Console.WriteLine($"Фиксированная зарплата: {CalculateSalary()} руб.");
        }
    }
}
