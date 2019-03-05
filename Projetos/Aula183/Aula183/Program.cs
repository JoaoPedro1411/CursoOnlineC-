using System;
using System.IO;

namespace Aula183
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\CursoOnlineC-\Projetos\file1.txt";
            string targetPath = @"C:\temp\CursoOnlineC-\Projetos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
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
