using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем сотрудников
            Console.WriteLine("=== Система учета сотрудников ===\n");

            Console.WriteLine("1. Информация о сотрудниках:");
            Console.WriteLine("----------------------------");

            FixedSalaryEmployee emp1 = new FixedSalaryEmployee(1, "Иван Иванов", "ivan@company.com", 50000);
            HourlySalaryEmployee emp2 = new HourlySalaryEmployee(2, "Петр Петров", "petr@company.com", 500, 160, 20);
            FreelancerEmployee emp3 = new FreelancerEmployee(3, "Анна Сидорова", "anna@freelance.com", 10000);

            // Выводим информацию о каждом сотруднике
            Console.WriteLine("\n--- Сотрудник с фиксированной зарплатой ---");
            emp1.PrintInfo();

            Console.WriteLine("\n--- Сотрудник с почасовой оплатой ---");
            emp2.PrintInfo();

            Console.WriteLine("\n--- Фрилансер ---");
            emp3.PrintInfo();

            // 2. Рассчет общей зарплаты
            Console.WriteLine("\n\n2. Ррасчет общей зарплаты:");
            Console.WriteLine("-------------------------");

            decimal salary1 = emp1.CalculateSalary();
            decimal salary2 = emp2.CalculateSalary();
            decimal salary3 = emp3.CalculateSalary();

            decimal totalSalary = salary1 + salary2 + salary3;

            Console.WriteLine($"Зарплата Ивана: {salary1} руб.");
            Console.WriteLine($"Зарплата Петра: {salary2} руб.");
            Console.WriteLine($"Зарплата Анны: {salary3} руб.");
            Console.WriteLine($"\nОбщая сумма: {totalSalary} руб.");

            // 3. Добавляем еще сотрудников
            Console.WriteLine("\n\n3. Дополнительные сотрудники:");
            Console.WriteLine("----------------------------");

            FixedSalaryEmployee emp4 = new FixedSalaryEmployee(4, "Сергей Сергеев", "sergey@company.com", 60000);
            HourlySalaryEmployee emp5 = new HourlySalaryEmployee(5, "Мария Петрова", "maria@company.com", 450, 150);

            Console.WriteLine("\n--- Новый сотрудник с фиксированной зарплатой ---");
            emp4.PrintInfo();

            Console.WriteLine("\n--- Новый сотрудник с почасовой оплатой ---");
            emp5.PrintInfo();

            // 4. Итоговый отчет
            Console.WriteLine("\n\n4. Итоговый отчет:");
            Console.WriteLine("------------------");

            decimal salary4 = emp4.CalculateSalary();
            decimal salary5 = emp5.CalculateSalary();

            totalSalary = salary1 + salary2 + salary3 + salary4 + salary5;

            Console.WriteLine($"Всего сотрудников: 5");
            Console.WriteLine($"Общая зарплата всех сотрудников: {totalSalary} руб.");
            Console.WriteLine($"Средняя зарплата: {totalSalary / 5:F0} руб.");

            // 5. Простой пример изменения зарплаты
            Console.WriteLine("\n\n5. Пример изменения:");
            Console.WriteLine("-------------------");

            FixedSalaryEmployee emp6 = new FixedSalaryEmployee(6, "Алексей Алексеев", "alex@company.com", 40000);

            Console.WriteLine("Первоначальная зарплата:");
            emp6.PrintInfo();
        }
    }
}
