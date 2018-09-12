using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int a = 0;
            string s = "";
            Console.Write("Please input first number: ");
            s = Console.ReadLine();
            x = Int32.Parse(s);
            Console.Write("Please input second number: ");
            s = Console.ReadLine();
            y = Int32.Parse(s);
            a = x * y;
            Console.WriteLine("The multiplying of two numbers: " + a);
        }
    }
}
