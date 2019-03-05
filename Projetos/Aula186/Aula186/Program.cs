using System;
using System.IO;

namespace Aula186
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\CursoOnlineC-\Projetos\file1.txt";
            string targetPath = @"C:\temp\CursoOnlineC-\Projetos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
