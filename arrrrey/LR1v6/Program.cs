using System;
using System.Linq;

namespace praktika
{
    internal class Program
    {
        static void Main()
        {
            ///вводим  массив с клавиатуры
            Console.WriteLine("Введите колличество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Вывод массива на экран
            Console.WriteLine("Введенный массив: " + string.Join(" ", arr));
            /// находим повторяющие элементы массива
            bool hasDuplicates = arr.Length != arr.Distinct().Count();
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
