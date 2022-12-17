using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int end = int.Parse(Console.ReadLine());
            bool prime = true;
            Console.WriteLine("the prime number is :");

            for (int i = start; i <= end; i++)
            {
                for (int x = 2; x < end ; x++)
                {
                    if (i != x && i % x == 0)
                    {
                        prime = false;
                        break;
                    }
                  if (i==1)
                        prime = false;
                   
                }
                if (prime)
              Console.WriteLine(i);
                
                prime = true;







               
            }
        }
    }
}
