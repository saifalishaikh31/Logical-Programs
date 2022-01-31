using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
             bool flag = true;
             while (flag)
             {
                 Console.WriteLine("\n 1.Fibonacci Series."
                                 + "\n 2.Perfect Number."
                                 + "\n 3.Exit \n");
                 int option = Convert.ToInt32(Console.ReadLine());
                 switch (option)
                 {
                     case 1:
                         FibonacciSeries fibonacci = new FibonacciSeries();
                         fibonacci.FiboSeries();
                         break;
                     case 2:
                         PerfectNumber perfectnum = new PerfectNumber();
                         perfectnum.CheckPerfectNumber();
                         break;
                     case 3:
                         flag = false;
                         break;
                     default: Console.WriteLine("Choose Correct option");
                         break;
                 }
             }
        }
    }
}
