using System;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = SumOfTwoVariables(1, 2);

            Console.WriteLine(a);
        }

        static int SumOfTwoVariables(int value1, int value2)
        {
            int result = 0;

            result = result + value1 + value2;

            return result;

        }
    }
}
