using System;
using System.Linq;

namespace pract2
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int n = 4000;
            int[] num = new int[n];
            /// Заполнение массива случайными числами от 1 до 5000
            for (int i = 0; i < n; i++)
            {
                num[i] = random.Next(1, 5001);
            }
            /// Количество пар находим
            int pairsCount = n / 2 - 1;
            int[] sum = new int[pairsCount];
            for (int i = 0, j = 0; i < pairsCount; i++, j += 2)
            {
                sum[i] = num[i] + num[j + 2];
            }
            /// выводим результат
            Console.WriteLine("[" + string.Join(",", sum) + "]");
        }
    }
}
