using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isseisevtoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] nums1 = { 5, 4, 3, 2, 1 };
            int[] nums2 = { 2, 5, 4, 1, 3 };
            bool n = false;
            bool n1 = false;
            bool n3 = false;
            n3 = Correct(nums2);
            n1 = Correct(nums1);
            n = Correct(nums);

            Console.WriteLine("Массив {0} упорядочен по возрастанию.", (n == true) ? "" : "не");
            Console.WriteLine("Массив {0} упорядочен по возрастанию.", (n1 == true) ? "" : "не");
            Console.WriteLine("Массив {0} упорядочен.", (n3 == true) ? "" : "не");
            Console.Read();
        }
        static bool Correct(int[] data)
        {
            if (data.Length < 2)
                return false;
            for (int i = 0; i < data.Length; i++)
            {
                if (i == data.Length - 1)
                    if (data[data.Length - 1] > data[data.Length - 2])
                        return true;
                    else
                        return false;
                if (data[i] < data[i + 1])
                    continue;
                else
                    return false;
            }
            return true;
        }
    }

}
