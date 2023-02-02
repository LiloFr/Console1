using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 10 \n7 см");
            Console.WriteLine("Введите 2 числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + "1\n" + "19" + " " + b);
            Console.WriteLine("Введите 2 числа:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " " + y + "\n5" + " " + y);


        }
    }
}
