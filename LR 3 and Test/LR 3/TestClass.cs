using System;
using System.Collections.Generic;
using System.Linq;

namespace LR_3.Tests
{
    class TestClass
    {
        public static void TestFunctionality()
        {
            Console.WriteLine(" ТЕСТИРОВАНИЕ LR_3\n");
            Console.WriteLine("1. Создание материалов:");
            var material1 = new Material
            {
                Id = 1,
                Name = "Древесина",
                PricePerUnit = 150.50m,
                Category = "Строительные"
            };

            var material2 = new Material
            {
                Id = 2,
                Name = "Металл",
                PricePerUnit = 300.75m,
                Category = "Металлы"
            };
            Console.WriteLine($"   {material1}");
            Console.WriteLine($"   {material2}");
            Console.WriteLine("\n2. Создание детали:");
            var part = new Part
            {
                Id = 1,
                Name = "Стол",
                Description = "Деревянный стол"
            };

            part.RequiredMaterials.Add(material1);
            part.RequiredMaterials.Add(material2);

            Console.WriteLine($"   Деталь: {part}");
            Console.WriteLine($"   Требуемые материалы: {part.RequiredMaterials.Count}");
            Console.WriteLine("\n3. Создание элемента заказа:");
            var orderItem = new OrderItem
            {
                Quantity = 5,
                Part = part,
                Quality = 1
            };
            orderItem.Materials.Add(material1);
            orderItem.Materials.Add(material2);
            orderItem.CalculateTotalCost();
            Console.WriteLine($"   {orderItem}");
            Console.WriteLine("\n4. Проверка ToString():");
            Console.WriteLine($"   Part.ToString(): {part}");
            Console.WriteLine($"   Material.ToString(): {material1}");
            Console.WriteLine($"   OrderItem.ToString(): {orderItem}");
            Console.WriteLine("\n ТЕСТИРОВАНИЕ ЗАВЕРШЕНО");
        }
    }
}