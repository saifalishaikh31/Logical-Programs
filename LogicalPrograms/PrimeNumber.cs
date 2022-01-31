using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public void CheckPrimeNumber()
        {
            int num, count = 0;
            Console.Write("Enter number to check whether its a Prime number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {

                Console.WriteLine("{0} is a Prime number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime number", num);
            }
        }
    }
}
