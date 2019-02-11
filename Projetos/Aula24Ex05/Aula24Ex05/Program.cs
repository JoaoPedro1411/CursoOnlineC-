using System;
using System.Globalization;

namespace Aula24Ex05 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o código da peça 1, quantidade de peças e o valor unitário da peça: (na mesma linha)");
            string[] vet1 = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(vet1[0]);
            int unidade1 = int.Parse(vet1[1]);
            double valorUnitario1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o código da peça 2, quantidade de peças e o valor unitário da peça: (na mesma linha)");
            string[] vet2 = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(vet2[0]);
            int unidade2 = int.Parse(vet2[1]);
            double valorUnitario2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            Console.WriteLine();
            double valorTotal = (unidade1 * valorUnitario1) + (unidade2 * valorUnitario2);
            Console.WriteLine("VALOR À PAGAR : R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
