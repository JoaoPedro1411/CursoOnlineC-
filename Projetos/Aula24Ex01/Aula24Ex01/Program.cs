using System;

namespace Aula24Ex01 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite dois números inteiros:");
            int num1, num2;
            int soma;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
