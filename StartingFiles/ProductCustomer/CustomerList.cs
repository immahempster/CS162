using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CustomerProductClasses
{
    public class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public int Count
        {
            get { return customers.Count; }
        }

        public Customer GetCustomer(int index)
        {
            return customers[index];
        }

        public void SetCustomer(int index, Customer customer)
        {
            customers[index] = customer;
        }

        public Customer GetCustomer(string email)
        {
            return customers.FirstOrDefault(c => c.Email == email);
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddCustomer(int id, string email, string firstName, string lastName, string phone)
        {
            Customer customer = new Customer
            {
                Id = id,
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Phone = phone
            };
            customers.Add(customer);
        }

        public static CustomerList operator +(CustomerList list, Customer customer)
        {
            list.AddCustomer(customer);
            return list;
        }

        public static CustomerList operator -(CustomerList list, Customer customer)
        {
            list.RemoveCustomer(customer);
            return list;
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public void Save(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                serializer.Serialize(stream, customers);
            }
        }

        public void Fill(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (FileStream stream = new FileStream(filename, FileMode.Open))
            {
                customers = (List<Customer>)serializer.Deserialize(stream);
            }
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, customers.Select(c => $"{c.Id} {c.Email} {c.FirstName} {c.LastName} {c.Phone}"));
        }
    }
}