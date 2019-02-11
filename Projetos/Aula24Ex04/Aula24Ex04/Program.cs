using System;
using System.Globalization;

namespace Aula24Ex04 {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Informe o número do funcionário:");
            int numDoFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas trabalhadas:");
            double horaTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor por hora trabalhada:");
            double valorPorHoraTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horaTrabalhada * valorPorHoraTrabalhada;
            Console.WriteLine();
            Console.WriteLine("NUMBER = {0}", numDoFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
