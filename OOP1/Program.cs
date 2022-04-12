using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 1, CategoryId = 2, ProductName = "Masa", UnitPrice = 500, UnitsinStock = 3 };

            ProductManager productManager = new ProductManager();
            int toplamsonucu = productManager.Topla(3,6);
        
        }
    }
}
