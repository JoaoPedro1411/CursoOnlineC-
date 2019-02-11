using System;

namespace Aula27 {
    class Program {
        static void Main(string[] args) {

            /*int x = 10;
            Console.WriteLine("Bom dia");
            if (x > 5) {
                Console.WriteLine("Boa tarde");
            }
            Console.WriteLine("Boa noite");*/

            /* Console.WriteLine("Digite um número: (inteiro)");
             int x = int.Parse(Console.ReadLine());

             if (x % 2 == 0) {
                 Console.WriteLine("Par!");
             }
             else {
                 Console.WriteLine("Ímpar!");
             }*/

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
