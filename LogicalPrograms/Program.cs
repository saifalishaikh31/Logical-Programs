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
                                 + "\n 3.Prime Number."
                                 + "\n 4.Reverse A Number."
                                 + "\n 5.Generate Coupon Numbers."
                                 + "\n 6.Simulate Stop Watch."
                                 + "\n 7.Exit \n");
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
                         PrimeNumber primenum = new PrimeNumber();
                         primenum.CheckPrimeNumber();
                         break;
                     case 4:
                         ReverseANumber reversenum = new ReverseANumber();
                         reversenum.CheckReverseANumber();
                         break;
                     case 5:
                         CouponNumbers couponnum = new CouponNumbers();
                         couponnum.GenerateCoupunNumbers();
                         break;
                     case 6:
                         SimulateStopWatch stopwatch = new SimulateStopWatch();
                         stopwatch.StopWatch();
                         break;
                     case 7:
                         flag = false;
                         break;
                     default: Console.WriteLine("Choose Correct option");
                         break;
                 }
             }
        }
    }
}
