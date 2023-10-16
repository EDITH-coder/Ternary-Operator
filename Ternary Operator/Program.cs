using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 20, secondNumber = 10;

            var result = firstNumber > secondNumber? "firstNumber is greater than secondNumber" : "firstNumber is less than secondNumber";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
