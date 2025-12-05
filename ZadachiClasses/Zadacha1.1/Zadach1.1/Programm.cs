using ManyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadach1._1
{
    internal class Programm
    {
            static void Main()
            {
                Product mers = new Product();
                mers.SetName("Audi");
                mers.SetPrice(1234000);

                Product yaz = new Product();
                yaz.SetName("Lefan");
                yaz.SetPrice(12345678);

                Storage storage = new Storage();
                storage.SetId(123);
                storage.SetLocation("Торжок, Ул. Студенческая 1");
                storage.SetProductQuantity(mers, 2);
                storage.SetProductQuantity(yaz, 5);

                storage.GetProductQuantity();
                storage.CalculateMoney();

                Console.WriteLine();

                Report report = new Report();

                ReportRow row1 = new ReportRow();
                row1.Product = "ВАУВЕЩИ";
                row1.Quantity = 200;
                row1.Price = 10;

                ReportRow row2 = new ReportRow();
                row2.Product = "ВАУПРОДУКТЫ";
                row2.Quantity = 300;
                row2.Price = 3208;

                ReportRow row3 = new ReportRow();
                row3.Product = "ВАУВСЁ";
                row3.Quantity = 100;
                row3.Price = 232;

                report.AddRecord(row1);
                report.AddRecord(row2);
                report.AddRecord(row3);

                report.overrideToString();
                Console.WriteLine();

                report.CalculateSum();
            }
    }
}
