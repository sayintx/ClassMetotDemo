using System;
using System.Collections.Generic;
using System.Text;

namespace ClasMetotDemo
{
    class CustomerManager
    {
        public void Adding(Musteri customer)
        {
            Console.WriteLine(customer.CustomerName + " isimli müşteri başarıyla eklendi!");
        }

        public void Listing(string CustomerName, string CustomerSurname, int CustomerID, int CustomerAccount)
        {
            Console.WriteLine(CustomerName + " " + CustomerSurname + " " + CustomerID + " " + CustomerAccount + " bilgilerine sahip müşteriler başarıyla listelendi!");
        }

        public void Delete(string CustomerName, string CustomerSurname, int CustomerID, int CustomerAccount)
        {
            Console.WriteLine(CustomerName + " " + CustomerSurname + " " + CustomerID + " " + CustomerAccount + " bilgilerine sahip müşteriler başarıyla silindi!");
        }
    }
}
