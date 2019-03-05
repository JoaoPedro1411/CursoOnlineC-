using System;
using System.IO;
using System.Collections.Generic;

namespace Aula187
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\CursoOnlineC-\MyFolder";

            try
            {
                // No lugar de "IEnumerable<string> folders" pode se utilizar "var folders"
                // Neste caso não sera necessário o "using System.Collections.Generic;"
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
