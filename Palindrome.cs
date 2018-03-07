using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int temp, num = 0;
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                int rem = n % 10;
                num = (num * 10) + rem;
                n = n / 10;
            }
            if (temp == num)
            {
                Console.WriteLine("Number is palindrome");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Number is not palindrome");
                Console.ReadKey();

            }
            Console.ReadKey();
        }
    }
}
