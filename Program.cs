//calculate the sum of the elements in an array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPracticeProblemsProblem_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of the example array is {0}", Sum(example));

        }

        static int Sum(int[] numbers)//calculates and returns the sum of an array
        {
            int totalSum = 0;

            for(int i = 0; i<numbers.Length; i++)
            {
                totalSum = totalSum + numbers[i];
            }

            return totalSum;
        }
    }
}
