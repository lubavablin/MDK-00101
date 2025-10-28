using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{

    // Простое перечисление статусов
    enum Status
    {
        Red,    // 0
        Green,      // 1  
        Blue,    // 2

    }

    class Program
    {
        static void Main()
        {
            ConsoleColor favoriteColor;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Выберите ваш любимый цвет:");
                Console.WriteLine("1 - Красный");
                Console.WriteLine("2 - Зеленый");
                Console.WriteLine("3 - Синий");
                Console.Write("Введите номер (1-3): ");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    favoriteColor = ConsoleColor.Red;
                    validInput = true;
                    Console.WriteLine($"\nВаш любимый цвет: {favoriteColor}");
                }
                else if (input == "2")
                {
                    favoriteColor = ConsoleColor.Green;
                    validInput = true;
                    Console.WriteLine($"\nВаш любимый цвет: {favoriteColor}");
                }
                else if (input == "3")
                {
                    favoriteColor = ConsoleColor.Blue;
                    validInput = true;
                    Console.WriteLine($"\nВаш любимый цвет: {favoriteColor}");
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Попробуйте еще раз.\n");
                }
            }
        }
    }
}



            
