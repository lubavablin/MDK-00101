using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika2
{
    internal class Program
    {
        static void Main(string[] args)
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
            int pairsCount = (n - 1) / 2;  // Для 4000 элементов: (4000-1)/2 = 1999 пар
            int[] sum = new int[pairsCount];

            for (int i = 0; i < pairsCount; i++)
            {
                int index1 = i * 2;      // первый элемент пары (четная позиция)
                int index2 = i * 2 + 2;  // второй элемент пары (следующая четная позиция)
                sum[i] = num[index1] + num[index2];
            }

            // выводим результат
            Console.WriteLine("[" + string.Join(",", sum) + "]");
        }
    }
}
