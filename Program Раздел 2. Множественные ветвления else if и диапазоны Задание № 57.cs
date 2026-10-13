using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program57
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Координата X: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                string pos;
                if (x == 0) pos = "На нуле";
                else if (x > 0) pos = "Положительная полуось";
                else pos = "Отрицательная полуось";

                Console.WriteLine(pos);
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}