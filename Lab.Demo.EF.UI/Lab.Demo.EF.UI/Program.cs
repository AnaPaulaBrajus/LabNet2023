using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductsLogic productsLogic = new ProductsLogic();

            //foreach(Products product in productsLogic.GetAll())
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}

            RegionLogic regionLogic = new RegionLogic();
            foreach(var item in regionLogic.GetAll())
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription} ");
            }

            regionLogic.Add(new Region
            {
                RegionID = 1,
                RegionDescription = "Sarasa"
            });

            foreach (var item in regionLogic.GetAll())
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription} ");
            }

            Console.WriteLine();
            //regionLogic.Delete(10);

            regionLogic.Update(new Region
            {
                RegionDescription = "Nueva Descripcion",
                RegionID = 10
            });
            Console.WriteLine();

            foreach (var item in regionLogic.GetAll())
            {
                Console.WriteLine($"{item.RegionID} - {item.RegionDescription} ");
            }

            Console.ReadLine();
        }
    }
}
