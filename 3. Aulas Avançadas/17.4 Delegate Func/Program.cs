using Course.Entities;

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




            // ! Opção 1
            // Func<Product, string> func = StringToUpper;
            // List<string> result = list.Select(StringToUpper).ToList();

            // ! Opção 2
            Func<Product, string> func = (p => p.Name.ToUpper());
            List<string> result = list.Select(StringToUpper).ToList();

            //! Opção 3
            //List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        private static string StringToUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
