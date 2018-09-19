using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLength = 5;
            Console.WriteLine("Input {0} numbers:", maxLength);
            int[] iPrime = new int[maxLength];
            for(int i = 0; i < maxLength; i++)
            {
                bool isLoop = true;
                bool isRight = true;
                string s = Console.ReadLine();
                isRight = int.TryParse(s, out iPrime[i]);
                if (!isRight)
                {
                    Console.WriteLine("Wrong Input");
                    break;
                }
                if (!isLoop)
                    break;
          
            }
            int x = 0;
            Console.WriteLine();
            Console.WriteLine("priem in your input: ");
            do
            {
                bool isPrime = true;
                if (iPrime[x] == 1 || iPrime[x] == 0)
                    isPrime = false;
                for (int i = 2; i < iPrime[x]; i++)
                {
                    if (iPrime[x] % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine(iPrime[x]);
                x++;
            } while (x < maxLength);

        }
    }
}
