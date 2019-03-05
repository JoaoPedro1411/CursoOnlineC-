using Aula206.Services;
using System;

namespace Aula206
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            double result2 = op.Invoke(a, b);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
