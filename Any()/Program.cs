using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 1.Any() with a Condition

            List<int> numbers = new List<int> { 3, 5, 8, 12, 18 };

            bool isAnyNumberGreaterThan10 = numbers.Any(number=>number>10);
            Console.WriteLine(isAnyNumberGreaterThan10);


            //2. Any() without a Condition
            bool isAnyNumberPresent = numbers.Any();
            Console.WriteLine(isAnyNumberPresent);
            Console.ReadLine();
        }
    }
}
