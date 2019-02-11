using System;
using System.Globalization;

namespace ExAula23 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] dadoPessoal = Console.ReadLine().Split(' ');
            string ultimoNome = dadoPessoal[0];
            int idade = int.Parse(dadoPessoal[1]);
            double altura = double.Parse(dadoPessoal[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Seu nome completo:");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine("Quantidade de quartos na sua casa:");
            Console.WriteLine(quarto);
            Console.WriteLine("Preço informado:");
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu último nome:");
            Console.WriteLine(ultimoNome);
            Console.WriteLine("Sua idade:");
            Console.WriteLine(idade);
            Console.WriteLine("Sua altura:");
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
