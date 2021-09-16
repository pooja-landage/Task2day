using System;

namespace Pratice10Task2day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("=============Task 2(1)==============");

            int days,weeks,remdays;

            Console.WriteLine("Enter the value of days");
            days = Convert.ToInt32(Console.ReadLine());

            weeks = days / 7;
            Console.WriteLine("Weeks are = "+weeks);

            remdays = days % 7;
            Console.WriteLine("Remdays are = "  + remdays);

            int s, t, u;
            Console.WriteLine("Enter your value of s and t");
            s = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());
            u = s % t;
            Console.WriteLine("Module of s and t is =" + u);

            int p, q, r;
            Console.WriteLine("Enter your value of p and q \n ");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
             r = p * q;
             r = p / q;
             r = p - q;

            Console.WriteLine("Module of s and t is =" + r);



        }
    }
}
