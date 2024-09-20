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

            List<int> numbers = new List<int> { 23, 25, 28, 22, 28 };

            bool isAnyNumberGreaterThan10 = numbers.All(number=>number>10);
            Console.WriteLine(isAnyNumberGreaterThan10);

           
        }
    }
}
