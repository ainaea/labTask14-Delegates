using System;
using System.Collections.Generic;

namespace DesmondLimited
{
    public delegate void InterestDel(Customers client);
    class Program
    {
        static void Main(string[] args)
        {
            InterestDel allInterest = Consoler;

            // Console.WriteLine("Hello World!");
            IEnumerable<Customers> someCustomers = new List<Customers>(){
                new Customers("James Stuart", 5000M, 5, 10),
                new Customers("Janet Stuart", 6500M, 4, 7),
                new Customers("Janet Wallace", 15000M, 3, 15),
                new Customers("John Wallace", 25000M, 5, 2),
                new Customers("Mark Armstrong", 20900M, 3, 8),
                new Customers("Mike Craig", 5500M, 4, 10),
                new Customers("Mitchell Craig", 11000M, 5, 8),
                new Customers("Donald Lawrence", 8500M, 6, 6),
                new Customers("Mary Lawrence", 9000M, 5, 4),
                new Customers("Henry Stuart", 2450M, 2, 22),
            };

            EvaluateAll(allInterest, someCustomers); 
        }

        static void Consoler(Customers customer)
        {
            Console.WriteLine($"Name: {customer.Name}\tAmount to borrow: {customer.Principal:C}\tSimpleInterest: {customer.GetSimpleInterest():C}\tCompundInterest: {customer.GetCompoundInterest():C}");
        }

        static void EvaluateAll(InterestDel method, IEnumerable<Customers> customerList)
        {
            foreach (var customer in customerList)
            {
                method(customer);
            }
        }

    }
}
