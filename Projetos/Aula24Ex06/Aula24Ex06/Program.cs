﻿using System;
using System.Globalization;

namespace Aula24Ex06 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe 3 números: (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double areaTrianguloRetangulo = (A * C) / 2;
            double areaCirculo = Math.Pow(C, 2.0) * pi;
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = Math.Pow(B, 2.0);
            double areaRetangulo = A * B;
            Console.WriteLine();
            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
