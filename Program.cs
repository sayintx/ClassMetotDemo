using System;

namespace ClasMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.CustomerName = "İsmail";
            customer1.CustomerSurname = "Hakça";
            customer1.CustomerId = 27496;
            customer1.CustomerAccount = 375489;

            Musteri customer2 = new Musteri();
            customer2.CustomerName = "Nevzat";
            customer2.CustomerSurname = "Gökçen";
            customer2.CustomerId = 26598;
            customer2.CustomerAccount = 278932;

            Musteri customer3 = new Musteri();
            customer3.CustomerName = "Feyza";
            customer3.CustomerSurname = "İlgeçti";
            customer3.CustomerId = 96354;
            customer3.CustomerAccount = 854796;

            Musteri[] customers = new Musteri[] { customer1, customer2, customer3 };

            Console.WriteLine("Dostluk Bankası Müşteri Takip Sayfası");

            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri Adı    : " + customer.CustomerName);
                Console.WriteLine("Müşteri Soyadı : " + customer.CustomerSurname);
                Console.WriteLine("Müşteri ID     : " + customer.CustomerId);
                Console.WriteLine("Müşteri Hesap  : " + customer.CustomerAccount);
                Console.WriteLine("**************");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Adding(customer1);
            customerManager.Adding(customer2);
            customerManager.Adding(customer3);

            Console.WriteLine("------------------");

            customerManager.Listing("İsmail", "Hakça", 27496, 375489);
            customerManager.Listing("Nevzat", "Gökçen", 26598, 278932);
            customerManager.Listing("Feyza", "İlgeçti", 96354, 854796);

            Console.WriteLine("------------------");

            customerManager.Delete ("İsmail", "Hakça", 27496, 375489);
            customerManager.Delete ("Nevzat", "Gökçen", 26598, 278932);
            customerManager.Delete ("Feyza", "İlgeçti", 96354, 854796);
            Console.ReadKey();
        }
    }
}
