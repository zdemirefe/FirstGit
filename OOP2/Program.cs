using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndCustomer customer1 = new IndCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.CustomerName = "Efe";
            customer1.CustomerSurname = "Özdemir";
            customer1.IdNo = "1782456465";
            //Gerçek Müşteri ve Tüzel Müşteri birbirine benziyor diye beraber kullanılamaz, yanlış bir soyutlama olmuş olur.
            //so(L)id
            CoorpCustomer customer2 = new CoorpCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompName = "Getir";
            customer2.TaxNo = "9876543";

            Customer customer3 = new IndCustomer();
            Customer customer4 = new CoorpCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
