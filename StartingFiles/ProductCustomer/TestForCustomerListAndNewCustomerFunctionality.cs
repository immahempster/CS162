using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerProductClasses;

namespace CustomerListTests
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerList list = new CustomerList();

            // Test GetCount
            Console.WriteLine("Testing GetCount");
            Console.WriteLine("Expecting 0. " + list.Count);

            // Test AddCustomer
            list.AddCustomer(new Customer { Id = 1, Email = "customer1@example.com", FirstName = "John", LastName = "Doe", Phone = "123-456-7890" });
            list.AddCustomer(new Customer { Id = 2, Email = "customer2@example.com", FirstName = "Jane", LastName = "Doe", Phone = "987-654-3210" });

            // Test GetCustomer by index
            Customer customer = list[0];
            Console.WriteLine("Testing GetCustomer by index");
            Console.WriteLine("Expecting customer1@example.com. " + customer.Email);

            // Test GetCustomer by email
            customer = list.GetCustomer("customer2@example.com");
            Console.WriteLine("Testing GetCustomer by email");
            Console.WriteLine("Expecting Jane. " + customer.FirstName);

            // Test SetCustomer
            list[0] = new Customer { Id = 1, Email = "customer1@example.com", FirstName = "John", LastName = "Doe", Phone = "123-456-7890" };
            customer = list[0];
            Console.WriteLine("Testing SetCustomer");
            Console.WriteLine("Expecting John. " + customer.FirstName);

            // Test AddCustomer with individual attributes
            list.AddCustomer(3, "customer3@example.com", "Bob", "Smith", "555-123-4567");
            customer = list[2];
            Console.WriteLine("Testing AddCustomer with individual attributes");
            Console.WriteLine("Expecting Bob. " + customer.FirstName);

            // Test Save and Fill
            list.Save("customers.xml");
            list.Fill("customers.xml");

            // Test RemoveCustomer
            list.RemoveCustomer(list[0]);
            Console.WriteLine("Testing RemoveCustomer");
            Console.WriteLine("Expecting 1. " + list.Count);

            // Test - operator
            list -= list[0];
            Console.WriteLine("Testing - operator");
            Console.WriteLine("Expecting 0. " + list.Count);

            // Test ToString
            Console.WriteLine("Testing ToString");
            Console.WriteLine(list.ToString());
        }
    }
}