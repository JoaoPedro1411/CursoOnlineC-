using System;
using System.Collections.Generic;
using Aula209.Entities;

namespace Aula209
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            //Action<Product> act = p => { p.Price += p.Price * 0.1; };
            //Action<Product> act = UpdatePrice;

            /*list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }*/

            /*list.ForEach(UpdatePrice);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }*/

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        /*static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }*/
    }
}
