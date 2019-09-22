using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            int pos = 0;
            int neg = 0;
            int zero = 0;

            foreach (var number in arr)
            {
                if (number > 0)
                {
                    pos++;
                }
                else if (number < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine((double)pos/arr.Length);
            Console.WriteLine((double)neg/arr.Length);
            Console.WriteLine((double)zero/arr.Length);
        }
        static void Main(string[] args)
        {
            int[] arr = {1,1,0,-1,-1};
            plusMinus(arr);
            Console.ReadLine();
        }
    }
}
