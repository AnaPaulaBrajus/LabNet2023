using LabNetPractica3.Entities;
using LabNetPractica3.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoriesLogic categoriesLogic=new CategoriesLogic();
            CustomersLogic customersLogic=new CustomersLogic();

            foreach (Categories categorie in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{categorie.CategoryName} - {categorie.Description}");
            }

            Console.WriteLine();

            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"{customer.ContactName} - {customer.CompanyName}");
            }

            Console.ReadLine();
        }
    }
}
