using System;

namespace Aula80 {
    class Program {
        static void Main(string[] args) {

            Console.Write("REPORT THE NUMBER THAT WILL BE THE SIZE OF THE MATRIX: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine("WRITE THE NUMBERS THAT WIL BE INSIDE INSIDE THE MATRIX:");
            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split();
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.Write("MAIN DIAGONAL: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("QUANTITY OF NEGATIVE NUMBERS: " + count);
            Console.WriteLine();
        }

    }
}
