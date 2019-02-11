using System;

namespace Aula24Ex03 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o valor de 'A', 'B', 'C' e 'D' para calcular a diferença" +
                "dos produtos de 'A' e 'B' dos produtos de 'C' e 'D': ");
            int A, B, C, D;
            
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            int diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENÇA = {0}", diferenca);
        }
    }
}
