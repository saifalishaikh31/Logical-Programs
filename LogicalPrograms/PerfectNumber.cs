using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public void CheckPerfectNumber()
        {
            int num, sum = 0;
            Console.Write("Enter a number to check whether its perfect or not : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                
                Console.WriteLine("{0} is a Perfect number", num);
            }
            else
            {
                Console.WriteLine("{0} is a not Perfect number", num);
            }
        }
    }
}
