using LabNetPractica3.Data;
using LabNetPractica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3.Logic
{
    public class CustomersLogic: BaseLogic
    {
        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var customerToDelete = context.Customers.Find(id);
            context.Customers.Remove(customerToDelete);
            context.SaveChanges();
        }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Update(Customers customer)
        {
            var customerUpdate = context.Customers.Find(customer.CustomerID);
            customerUpdate.CompanyName = customer.CompanyName;
            customerUpdate.ContactName=customer.ContactName;
            customerUpdate.ContactTitle = customer.ContactTitle;
            customerUpdate.Address = customer.Address;
            customerUpdate.City = customer.City;
            customerUpdate.Region = customer.Region;    
            customerUpdate.PostalCode = customer.PostalCode;    
            customerUpdate.Country = customer.Country;
            customerUpdate.Phone = customer.Phone;
            customerUpdate.Fax = customer.Fax;
            context.SaveChanges();
        }
    }
}
