using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class programperech
    {
        static void Main(string[] args)
        {
            // Создаем генератор и генерируем 1000 проектов
            var generator = new ProjectGenerator();
            var projects = generator.GenerateProjects(1000);

            // Создаем систему поиска
            var searchSystem = new ProjectSearchSystem();

            // Выводим статистику
            searchSystem.PrintStatistics(projects);

            // Находим топ-10 проектов по любой характеристике
            var topProjects = searchSystem.FindTopProjectsByAnyCharacteristic(projects, 10);

            // Выводим результаты
            searchSystem.PrintTopProjects(topProjects, "ТОП-10 ПРОЕКТОВ ПО МАКСИМАЛЬНОЙ ХАРАКТЕРИСТИКЕ");

            // Дополнительно: поиск топ-проектов по конкретным характеристикам
            Console.WriteLine("\nДОПОЛНИТЕЛЬНАЯ ИНФОРМАЦИЯ:");

            var topComplexity = projects.OrderByDescending(p => p.Complexity).Take(5).ToList();
            var topInnovation = projects.OrderByDescending(p => p.Innovation).Take(5).ToList();
            var topImpact = projects.OrderByDescending(p => p.Impact).Take(5).ToList();

            Console.WriteLine("\nТоп-5 по сложности:");
            foreach (var project in topComplexity)
            {
                Console.WriteLine($"  {project.Name} - Сложность: {project.Complexity:F1}");
            }

            Console.WriteLine("\nТоп-5 по инновационности:");
            foreach (var project in topInnovation)
            {
                Console.WriteLine($"  {project.Name} - Инновационность: {project.Innovation:F1}");
            }

            Console.WriteLine("\nТоп-5 по влиянию:");
            foreach (var project in topImpact)
            {
                Console.WriteLine($"  {project.Name} - Влияние: {project.Impact:F1}");
            }

            // Использование расширенного поиска
            var advancedSearch = new AdvancedProjectSearch();
            var balancedProjects = advancedSearch.FindBalancedTopProjects(projects, 5, 85);

            Console.WriteLine("\nСБАЛАНСИРОВАННЫЕ ПРОЕКТЫ (все характеристики ≥ 85):");
            foreach (var project in balancedProjects)
            {
                Console.WriteLine($"  {project.Name} - C:{project.Complexity:F1} I:{project.Innovation:F1} Im:{project.Impact:F1}");
            }
        }
    }
}
