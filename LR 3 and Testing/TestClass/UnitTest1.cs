using System;
using LR_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() { }




        public class TestClass
        {
            public static void TestFunctionality()
            {
                Console.WriteLine("=== АВТОМАТИЧЕСКОЕ ТЕСТИРОВАНИЕ ===");
                int passed = 0, failed = 0;

                // Тест 1: Корректный расчёт стоимости
                try
                {
                    var mat1 = new LR_3.Material { Name = "Древесина", PricePerUnit = 150.50m };
                    var mat2 = new LR_3.Material { Name = "Металл", PricePerUnit = 300.75m };
                    var order = new LR_3.OrderItem { Quantity = 2, Part = new Part() };
                    order.Materials.Add(mat1);
                    order.Materials.Add(mat2);
                    order.CalculateTotalCost();

                    decimal expected = (150.50m + 300.75m) * 2; // 902.50
                    if (order.TotalCost != expected)
                        throw new Exception($"Ожидалось {expected:C}, получено {order.TotalCost:C}");

                    Console.WriteLine("[✓] Тест 1: Расчёт стоимости пройден");
                    passed++;
                }
                catch (Exception ex) { Console.WriteLine($"[✗] Тест 1: ОШИБКА - {ex.Message}"); failed++; }

                // Тест 2: Пустой список материалов
                try
                {
                    var order = new OrderItem { Quantity = 5, Part = new Part() };
                    order.CalculateTotalCost();
                    if (order.TotalCost != 0m) throw new Exception("Стоимость должна быть 0");
                    Console.WriteLine("[✓] Тест 2: Пустые материалы пройдены");
                    passed++;
                }
                catch (Exception ex) { Console.WriteLine($"[✗] Тест 2: ОШИБКА - {ex.Message}"); failed++; }

                // Тест 3: Проверка ToString()
                try
                {
                    var part = new Part { Name = "Стул" };
                    var order = new OrderItem { Quantity = 1, Part = part };
                    order.Materials.Add(new Material { Name = "Пластик", PricePerUnit = 50m });
                    order.CalculateTotalCost();

                    string result = order.ToString();
                    if (!result.Contains("Стул") || !result.Contains("1 шт.") || !result.Contains("50"))
                        throw new Exception("Формат строки не соответствует ожидаемому");

                    Console.WriteLine("[✓] Тест 3: Форматирование ToString() пройдено");
                    passed++;
                }
                catch (Exception ex) { Console.WriteLine($"[✗] Тест 3: ОШИБКА - {ex.Message}"); failed++; }

                Console.WriteLine($"\n=== ИТОГ: Пройдено {passed}, Не пройдено {failed} ===");
                if (failed == 0) Console.WriteLine("Все тесты успешны.");
            }
        }
                                 
    }
}
    

