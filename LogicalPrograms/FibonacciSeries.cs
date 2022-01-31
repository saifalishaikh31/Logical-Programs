using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public void FiboSeries()
        {
            int firstNum = 0, seconNum = 1, thirdNum, number;
            Console.Write("Enter the number of Elements : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe Fibonacci Series of : " + number + " Elements\n");
            Console.Write(firstNum + "\t" + seconNum);
            for (int i = 3; i <= number; i++)
            {
                thirdNum = firstNum + seconNum;
                firstNum = seconNum;
                seconNum = thirdNum;
                Console.Write("\t" + thirdNum );
                
            }
            Console.WriteLine("\n");
        }
    }
}
