using System;
using Aula202Demo01.Extensions;

namespace Aula202Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 14, 00, 00, 00);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
