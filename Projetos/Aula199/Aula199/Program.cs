﻿using System;
using System.IO;
using System.Collections.Generic;
using Aula199.Entites;

namespace Aula199
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\CursoOnlineC-\MyFolder\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
