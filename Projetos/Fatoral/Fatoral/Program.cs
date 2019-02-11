using System;

namespace Fatoral {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite 1 número: ");

            int n = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }
            Console.WriteLine(fat);
        }
    }
}
