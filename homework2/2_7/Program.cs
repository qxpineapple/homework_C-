using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 5, 6, 1, 9, 8, 7, 10 };
            int maxNumber = intArray[0];
            int minNumber = intArray[0];
            double avgNumber = 0;
            int addAll = 0;
            int length = intArray.Length;
            foreach(int i in intArray)
            {
                addAll += i;
            }
            avgNumber = addAll / (double)length;
            for(int i = 0; i < length; i++)
            {
                if(minNumber > intArray[i])
                { 
                    minNumber = intArray[i];
                }
                else if (maxNumber < intArray[i])
                {
                    maxNumber = intArray[i];
                }

            }
            Console.Write($"MAX = {maxNumber}" +
            $" MIN = {minNumber}" +
            $" Average = {avgNumber}" +
            $" SUM = {addAll}");
        }
    }
}
