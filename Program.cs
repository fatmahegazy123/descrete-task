using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number ");
            int end = int.Parse(Console.ReadLine());
            int sum;
            for (int i = start; i <= end; i++)
            {
                sum = 0;
                for (int x = 1; x <= i / 2; x++)
                {

                    if (i % x == 0)
                    {
                        sum += x;
                    }








                }
                if (sum == i)
                {
                    Console.WriteLine("the prime number is :" + sum);


                }

            }
        }
    }
}
