using System;
using System.Collections.Generic;

namespace Aula82 {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(5);
            A.Add(3);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //B.Remove(4);

            //A.ExceptWith(B);

            //A.UnionWith(B);

            //A.IntersectWith(B);

            Console.WriteLine("Conjunto A:");
            foreach (int x in A) {
                Console.WriteLine(x);
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Conjunto B:");
            foreach (int x in B) {
                Console.WriteLine(x);
            }

            /*Console.WriteLine("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (B.Contains(n)) {
                Console.WriteLine(n + " Pertemcence ao conjunto B");
            }
            else if (A.Contains(n)) {
                Console.WriteLine(n + " Pertence ao conjunto A");
            }
            else {
                Console.WriteLine(n + " Não pertence a nenhum conjunto");
            }*/
        }
    }
}
