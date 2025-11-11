using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProjectGenerator
    {
        private readonly Random _random = new Random();
        private readonly string[] _techNames;
        private readonly string[] _scienceNames;
        private readonly string[] _artNames;
        private readonly string[] _natureNames;
        private readonly string[] _sportsNames;
        private readonly string[] _businessNames;

        public ProjectGenerator()
        {
            _techNames = new string[] {
            "Квантовый компьютер", "ИИ-ассистент", "Бионический протез",
            "Виртуальная реальность", "Блокчейн платформа", "Робот-хирург",
            "Умный город", "Автономный транспорт", "Нейроинтерфейс",
            "Квантовые вычисления", "Машинное обучение", "Компьютерное зрение"
        };

            _scienceNames = new string[] {
            "Генная терапия", "Термоядерный реактор", "Крионика",
            "Нанотехнологии", "Космический телескоп", "Биотопливо",
            "Клонирование", "Стволовые клетки", "Генная инженерия"
        };

            _artNames = new string[] {
            "Интерактивная инсталляция", "Цифровая живопись", "3D анимация",
            "Виртуальный музей", "Голографическое искусство", "Цифровая скульптура"
        };

            _natureNames = new string[] {
            "Сохранение биоразнообразия", "Экологический мониторинг",
            "Восстановление лесов", "Защита океанов", "Чистая энергия"
        };

            _sportsNames = new string[] {
            "Биомеханика движений", "Анализ производительности",
            "Умная экипировка", "Тренировочные симуляторы"
        };

            _businessNames = new string[] {
            "Платформа электронной коммерции", "Финтех решение",
            "Система аналитики", "Управление цепочками поставок"
        };
        }

        public Project GenerateProject(int id)
        {
            Category category = (Category)_random.Next(0, 6);
            string name = GenerateName(category);

            double complexity = Math.Round(_random.NextDouble() * 100, 1);
            double innovation = Math.Round(_random.NextDouble() * 100, 1);
            double impact = Math.Round(_random.NextDouble() * 100, 1);

            return new Project(id, name, category, complexity, innovation, impact);
        }

        private string GenerateName(Category category)
        {
            string[] names;

            switch (category)
            {
                case Category.Technology:
                    names = _techNames;
                    break;
                case Category.Science:
                    names = _scienceNames;
                    break;
                case Category.Art:
                    names = _artNames;
                    break;
                case Category.Nature:
                    names = _natureNames;
                    break;
                case Category.Sports:
                    names = _sportsNames;
                    break;
                case Category.Business:
                    names = _businessNames;
                    break;
                default:
                    names = _techNames;
                    break;
            }

            string baseName = names[_random.Next(names.Length)];
            return $"{baseName} v{_random.Next(1, 6)}.{_random.Next(0, 10)}";
        }

        public List<Project> GenerateProjects(int count)
        {
            var projects = new List<Project>();
            for (int i = 1; i <= count; i++)
            {
                projects.Add(GenerateProject(i));
            }
            return projects;
        }
    }
}
