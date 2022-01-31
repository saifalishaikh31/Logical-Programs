using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
    class ReverseANumber
    {
        public void CheckReverseANumber()
        {
            int num, remainder = 0, sum = 0;
            Console.Write("Enter number to Reverse it : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                remainder = num % 10;
                sum = sum * 10 + remainder;
                num = num / 10;
            }

            Console.WriteLine("Number in Reverse Order : {0}", sum);
        }
    }
}
