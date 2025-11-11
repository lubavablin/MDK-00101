using System;
using System.Collections.Generic;
using System.Linq;

namespace praktika
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Вывод массива на экран
            Console.WriteLine("Введенный массив: " + string.Join(" ", arr));

            // Проверка на дубликаты с помощью HashSet
            bool hasDuplicates = false;
            HashSet<int> uniqueElements = new HashSet<int>();

            foreach (int element in arr)
            {
                if (uniqueElements.Contains(element))
                {
                    hasDuplicates = true;
                    break;
                }
                uniqueElements.Add(element);
            }

            if (hasDuplicates)
            {
                Console.WriteLine("В массиве есть одинаковые элементы");
            }
            else
            {
                Console.WriteLine("В массиве нет одинаковых элементов");
            }
        
        }
    }
}
