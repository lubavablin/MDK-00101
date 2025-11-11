using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AdvancedProjectSearch
    {
        // Поиск проектов с высокой оценкой по всем характеристикам
        public List<Project> FindBalancedTopProjects(List<Project> projects, int topCount = 10, double minScore = 80)
        {
            var balancedProjects = new List<Project>();

            foreach (var project in projects)
            {
                if (project.Complexity >= minScore && project.Innovation >= minScore && project.Impact >= minScore)
                {
                    balancedProjects.Add(project);
                }
            }

            return balancedProjects
                .OrderByDescending(p => (p.Complexity + p.Innovation + p.Impact) / 3)
                .Take(topCount)
                .ToList();
        }

        // Поиск лучших проектов по категориям
        public Dictionary<Category, List<Project>> FindTopProjectsByCategory(List<Project> projects, int projectsPerCategory = 5)
        {
            var result = new Dictionary<Category, List<Project>>();
            var categoryGroups = projects.GroupBy(p => p.Category);

            foreach (var group in categoryGroups)
            {
                var topProjects = group
                    .OrderByDescending(p => Math.Max(p.Complexity, Math.Max(p.Innovation, p.Impact)))
                    .Take(projectsPerCategory)
                    .ToList();

                result[group.Key] = topProjects;
            }

            return result;
        }

        // Поиск проектов с конкретной минимальной характеристикой
        public List<Project> FindProjectsWithMinCharacteristic(List<Project> projects,
            double minComplexity = 0, double minInnovation = 0, double minImpact = 0)
        {
            var filteredProjects = new List<Project>();

            foreach (var project in projects)
            {
                if (project.Complexity >= minComplexity && project.Innovation >= minInnovation && project.Impact >= minImpact)
                {
                    filteredProjects.Add(project);
                }
            }

            return filteredProjects
                .OrderByDescending(p => p.Complexity + p.Innovation + p.Impact)
                .ToList();
        }
    }
}
