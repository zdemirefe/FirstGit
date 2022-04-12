using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyat = 10;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyat = 70;
            product2.Aciklama = "İran Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product item in products)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine(item.Fiyat);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------Metotlar------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

        }
    }
}
