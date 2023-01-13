using System;
using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //! Opção 1
            // Action<Product> action = UpdatePrice;
            // list.ForEach(action);

            //! Opção 2
            // list.ForEach(UpdatePrice);

            //! Opção 3
            Action<Product> action = (p => { p.Price += p.Price * 0.1; });
            list.ForEach(action);

            //! Opção 4
            // list.ForEach(p => { p.Price += p.Price * 0.1; });


            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static void UpdatePrice(Product p)
        {
            p.Price *= 1.1;
        }
    }
}
