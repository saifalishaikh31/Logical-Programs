using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumbers
    {
        public void GenerateCoupunNumbers()
        {
            Console.Write("Enter the number of distinct coupons you want to generate :");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            Random random = new Random();
            int[] couponCollection = new int[N];
            for (int i = 0; i <= N - 1; i++)
            {
                int coupon = random.Next(1001, 2001);
                if ((coupon.CompareTo(couponCollection[i])) != 0)
                {
                    int[] coupunCollection = new int[i];
                    couponCollection[i] = coupon;
                    count++;
                }
            }
            foreach (int i in couponCollection)
            {
                Console.WriteLine("Coupons Collection : {0}", i);
            }
            Console.WriteLine("\nNumber of Coupons Generated : {0}",count);
                
        }
    }
}
