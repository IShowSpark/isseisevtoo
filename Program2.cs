using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isseisevtoo
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var r = new Random();
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                a[i] = r.Next(-2000, 2000);
                if (a[i]>-10 && a[i] <10) count++;
            }
            Console.WriteLine("Count {0}", count);
            Console.ReadKey();

        }
    }
}
