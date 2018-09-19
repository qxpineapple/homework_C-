using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[99];
            bool[] isPrime = new bool[intArray.Length+2];
            for(int i = 0; i < intArray.Length;i++)
            {
                intArray[i] = i + 2;
            }
            for(int i = 2; i <= intArray[98]; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i <= intArray[98]; i++)
            {
                if (isPrime[i])
                {
                    for (int x = 2; x  <= intArray[98]; x++)
                    {
                        if (intArray[x-2] % i == 0 && i != intArray[x-2])
                        {
                            isPrime[x] = false;
                          
                        }
                    }
                }
            }
               
            int[] pirmeArray = new int[intArray.Length];
            int newLength = 0;
            for (int i = 2; i <= 100; i++)
            {
                if(isPrime[i])
                {
                    //Console.WriteLine(intArray[i]);
                    pirmeArray[++newLength] = intArray[i-2];
                }
            }
            
            foreach(int i in pirmeArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
