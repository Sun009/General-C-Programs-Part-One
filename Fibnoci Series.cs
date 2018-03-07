using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Fibnoci_Series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine("{0},{1}", n1, n2);
            for (int i = 2; i < n; ++i)
            {
                int n3 = n1 + n2;
                Console.WriteLine("{0}", n3);
                n1 = n2;
                n2 = n3;

            }
            Console.ReadKey();
             
        }
    }
}
