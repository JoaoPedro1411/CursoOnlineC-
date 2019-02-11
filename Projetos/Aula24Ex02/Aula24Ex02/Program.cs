using System;
using System.Globalization;

namespace Aula24Ex02 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o valor do raio para calcular a área:");

            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double area = Math.Pow(raio, 2.0) * pi;

            Console.WriteLine("A = " + area.ToString("F4"));

        }
    }
}
