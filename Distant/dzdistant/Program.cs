using System;
using System.Collections.Generic;

namespace SimplePhoneShop
{
    // Простой класс для хранения продажи
    public class Sale
    {
        public DateTime Date;
        public string PhoneName;
        public int Count;
        public decimal Price;

        // Считаем сумму за эту продажу
        public decimal GetTotal()
        {
            return Count * Price;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("📱 АНАЛИЗ ПРОДАЖ ТЕЛЕФОНОВ");
            Console.WriteLine("===========================");

            // Создаем список продаж
            List<Sale> allSales = CreateSales();

            // а) Общая сумма за январь 2024
            decimal totalMoney = CalculateTotalMoney(allSales);
            Console.WriteLine($"💰 Общая выручка: {totalMoney} руб.");

            // б) Самый популярный и непопулярный телефон
            FindPopularPhones(allSales);

            // в) Два самых прибыльных телефона
            FindTopPhones(allSales);
        }

        // Создаем тестовые данные
        static List<Sale> CreateSales()
        {
            var sales = new List<Sale>();
            var random = new Random();

            // Модели телефонов и их цены
            string[] phoneModels = { "iPhone 15 pro", "Samsung S24", "Xiaomi 13", "Google Pixel", "OnePlus 12" };
            decimal[] prices = { 100000, 90000, 30000, 80000, 70000 };

            // Создаем продажи за 10 дней
            for (int day = 1; day <= 10; day++)
            {
                DateTime date = new DateTime(2024, 1, day);

                // Создаем 2-4 продажи в день
                int salesToday = random.Next(2, 5);
                for (int i = 0; i < salesToday; i++)
                {
                    int phoneIndex = random.Next(phoneModels.Length);

                    sales.Add(new Sale
                    {
                        Date = date,
                        PhoneName = phoneModels[phoneIndex],
                        Count = random.Next(1, 4), // 1-3 телефона
                        Price = prices[phoneIndex]
                    });
                }
            }

            return sales;
        }

        // а) Считаем общую выручку
        static decimal CalculateTotalMoney(List<Sale> sales)
        {
            decimal total = 0;
            foreach (Sale sale in sales)
            {
                total += sale.GetTotal();
            }
            return total;
        }

        // б) Ищем самые популярные и непопулярные телефоны
        static void FindPopularPhones(List<Sale> sales)
        {
            // Считаем сколько всего продано каждого телефона
            Dictionary<string, int> phoneCounts = new Dictionary<string, int>();

            foreach (Sale sale in sales)
            {
                if (phoneCounts.ContainsKey(sale.PhoneName))
                {
                    phoneCounts[sale.PhoneName] += sale.Count;
                }
                else
                {
                    phoneCounts[sale.PhoneName] = sale.Count;
                }
            }

            // Ищем телефон с максимальными и минимальными продажами
            string bestPhone = "";
            string worstPhone = "";
            int maxCount = 0;
            int minCount = int.MaxValue;

            foreach (var phone in phoneCounts)
            {
                if (phone.Value > maxCount)
                {
                    maxCount = phone.Value;
                    bestPhone = phone.Key;
                }

                if (phone.Value < minCount)
                {
                    minCount = phone.Value;
                    worstPhone = phone.Key;
                }
            }

            Console.WriteLine($"🏆 Самый продаваемый: {bestPhone} ({maxCount} шт.)");
            Console.WriteLine($"📉 Меньше всего продаж: {worstPhone} ({minCount} шт.)");
        }

        // в) Ищем два самых прибыльных телефона
        static void FindTopPhones(List<Sale> sales)
        {
            // Считаем общую выручку по каждому телефону
            Dictionary<string, decimal> phoneMoney = new Dictionary<string, decimal>();

            foreach (Sale sale in sales)
            {
                if (phoneMoney.ContainsKey(sale.PhoneName))
                {
                    phoneMoney[sale.PhoneName] += sale.GetTotal();
                }
                else
                {
                    phoneMoney[sale.PhoneName] = sale.GetTotal();
                }
            }

            // Сортируем телефоны по убыванию прибыли
            List<string> sortedPhones = new List<string>();
            foreach (var phone in phoneMoney)
            {
                sortedPhones.Add(phone.Key);
            }

            // Простая сортировка пузырьком
            for (int i = 0; i < sortedPhones.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedPhones.Count; j++)
                {
                    if (phoneMoney[sortedPhones[i]] < phoneMoney[sortedPhones[j]])
                    {
                        string temp = sortedPhones[i];
                        sortedPhones[i] = sortedPhones[j];
                        sortedPhones[j] = temp;
                    }
                }
            }

            Console.WriteLine("\n🎯 Два самых прибыльных телефона:");
            for (int i = 0; i < 2 && i < sortedPhones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedPhones[i]} - {phoneMoney[sortedPhones[i]]} руб.");
            }
        }
    }
}