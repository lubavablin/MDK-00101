using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProjectSearchSystem
    {
        public List<Project> FindTopProjectsByAnyCharacteristic(List<Project> projects, int topCount = 10)
        {
            // Создаем временный класс для хранения проектов с максимальной оценкой
            var projectsWithMaxScore = new List<ProjectWithScore>();

            foreach (var project in projects)
            {
                double maxScore = Math.Max(project.Complexity, Math.Max(project.Innovation, project.Impact));
                projectsWithMaxScore.Add(new ProjectWithScore { Project = project, MaxScore = maxScore });
            }

            // Сортируем по убыванию максимальной характеристики и берем топ-N
            return projectsWithMaxScore
                .OrderByDescending(x => x.MaxScore)
                .Take(topCount)
                .Select(x => x.Project)
                .ToList();
        }

        // Вспомогательный класс для хранения проектов с их максимальной оценкой
        private class ProjectWithScore
        {
            public Project Project { get; set; }
            public double MaxScore { get; set; }
        }

        public void PrintTopProjects(List<Project> topProjects, string title)
        {
            Console.WriteLine($"\n{title}:");
            Console.WriteLine(new string('=', 80));

            foreach (var project in topProjects)
            {
                Console.WriteLine(project);
                double maxChar = Math.Max(project.Complexity, Math.Max(project.Innovation, project.Impact));
                Console.WriteLine($"  Макс. характеристика: {maxChar:F1}");
                Console.WriteLine(new string('-', 80));
            }
        }

        public void PrintStatistics(List<Project> projects)
        {
            Console.WriteLine("\nСтатистика по всем проектам:");
            Console.WriteLine($"Общее количество проектов: {projects.Count}");
            Console.WriteLine($"Средняя сложность: {projects.Average(p => p.Complexity):F1}");
            Console.WriteLine($"Средняя инновационность: {projects.Average(p => p.Innovation):F1}");
            Console.WriteLine($"Среднее влияние: {projects.Average(p => p.Impact):F1}");

            Console.WriteLine("\nРаспределение по категориям:");
            var categoryGroups = projects.GroupBy(p => p.Category);

            foreach (var group in categoryGroups)
            {
                Console.WriteLine($"  {group.Key}: {group.Count()} проектов");
            }
        }
    }
}
