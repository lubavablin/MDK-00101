using System;
using System.Windows.Forms;


namespace LR_3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            Console.WriteLine("\nНажмите любую клавишу для запуска приложения...");
            //Console.ReadKey();
           // Console.Clear();

            // 2. Запускаем форму (строго один раз, как требует WinForms)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}