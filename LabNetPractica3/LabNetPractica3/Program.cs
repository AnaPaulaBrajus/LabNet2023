using LabNetPractica3.Entities;
using LabNetPractica3.Logic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc;
            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("1-Consulta simple de las entidades Empleados y Clientes");
                Console.WriteLine("2-Alta de un nuevo cliente");
                Console.WriteLine("3-Baja de un cliente");
                Console.WriteLine("4-Modificación de un cliente");
                Console.WriteLine("0-Salir");
                Console.WriteLine("--------------------------------------------------------");
                Console.Write("Ingrese una opción: ");
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Quiere ver la lista de empleados o de clientes (E/C)?: ");
                        string rta = Console.ReadLine().ToUpper();
                        if (rta == "E")
                        {
                            ListaEmpleados();
                        }
                        else if (rta == "C") ListaClientes();
                        break;
                    case "2":
                        Alta();
                        break;
                    case "3":
                        Baja();
                        break;
                    case "4":
                        Modificacion();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opc!="0");
        }

        private static void ListaEmpleados()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de empleados: ");
            Console.WriteLine("---------------------");
            EmployeesLogic employeesLogic = new EmployeesLogic();
            foreach (Employees employee in employeesLogic.GetAll())
            {
                Console.WriteLine($"ID: {employee.EmployeeID}");
                Console.WriteLine($"Apellido: {employee.LastName}");
                Console.WriteLine($"Nombre: {employee.FirstName}");
                Console.WriteLine($"Título: {employee.Title}");
                Console.WriteLine($"Título de cortesía: {employee.TitleOfCourtesy}");
                Console.WriteLine($"Fecha de nacimiento: {employee.BirthDate}");
                Console.WriteLine($"Fecha de contratación: {employee.HireDate}");
                Console.WriteLine($"Dirección: {employee.Address}");
                Console.WriteLine($"Ciudad: {employee.City}");
                Console.WriteLine($"Región: {employee.Region}");
                Console.WriteLine($"Código postal: {employee.PostalCode}");
                Console.WriteLine($"País: {employee.Country}");
                Console.WriteLine($"Télefono fijo: {employee.HomePhone}");
                Console.WriteLine($"Extensión: {employee.Extension}");
                //Console.WriteLine($"Foto: {employee.Photo}");
                Console.WriteLine($"Notas: {employee.Notes}");
                Console.WriteLine($"Se reporta a: {employee.ReportsTo}");
                Console.WriteLine($"Dirección de foto: {employee.PhotoPath}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void ListaClientes()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Lista de clientes: ");
            Console.WriteLine("---------------------");
            CustomersLogic customersLogic = new CustomersLogic();
            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"ID: {customer.CustomerID}");
                Console.WriteLine($"Nombre de la compania: {customer.CompanyName}");
                Console.WriteLine($"Nombre de contacto: {customer.ContactName}");
                Console.WriteLine($"Titulo de contacto: {customer.ContactTitle}");
                Console.WriteLine($"Dirección: {customer.Address}");
                Console.WriteLine($"Ciudad: {customer.City}");
                Console.WriteLine($"Region: {customer.Region}");
                Console.WriteLine($"Código postal: {customer.PostalCode}");
                Console.WriteLine($"País: {customer.Country}");
                Console.WriteLine($"Teléfono: {customer.Phone}");
                Console.WriteLine($"Fax: {customer.Fax}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        private static void Alta()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            Console.WriteLine();
            Customers newCustomer = new Customers();
            Console.WriteLine("Ingrese los datos del nuevo cliente: ");
            Console.Write("Ingrese el ID del cliente (5 primeras letras del nombre de la compania): ");
            newCustomer.CustomerID = Console.ReadLine().ToUpper();
            Console.Write("Ingrese el nombre de la compania: ");
            newCustomer.CompanyName = Console.ReadLine();
            Console.Write("Ingrese el nombre de contacto: ");
            newCustomer.ContactName = Console.ReadLine();
            Console.Write("Ingrese el titulo del contacto: ");
            newCustomer.ContactTitle = Console.ReadLine();
            Console.Write("Ingrese la dirección: ");
            newCustomer.Address = Console.ReadLine();
            Console.Write("Ingrese la ciudad: ");
            newCustomer.City = Console.ReadLine();
            Console.Write("Ingrese la región: ");
            newCustomer.Region = Console.ReadLine();
            Console.Write("Ingrese el código postal: ");
            newCustomer.PostalCode = Console.ReadLine();
            Console.Write("Ingrese el país: ");
            newCustomer.Country = Console.ReadLine();
            Console.Write("Ingrese el teléfono: ");
            newCustomer.Phone = Console.ReadLine();
            Console.Write("Ingrese el fax: ");
            newCustomer.Fax = Console.ReadLine();
            customersLogic.Add(newCustomer);
            Console.WriteLine("Se ha dado de alta un nuevo cliente con exito...");
            Console.WriteLine("Lista actualizada: ");
            ListaClientes();
        }

        private static void Baja()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese ID del cliente a eliminar: ");
            string idToDelete = Console.ReadLine();
            CustomersLogic customersLogic = new CustomersLogic();
            customersLogic.Delete(idToDelete);
            Console.WriteLine("Se ha eliminado el cliente con éxito");
            ListaClientes();
        }

        private static void Modificacion()
        {
            do
            {
                Console.Write("Ingrese el Id del cliente a modificar: ");
                string idToUpdate = Console.ReadLine();
                CustomersLogic customerLogic = new CustomersLogic();
                Customers customerToUpdate = new Customers { CustomerID = idToUpdate };
                Console.WriteLine("Seleccione la propiedad que desea actualizar: ");
                Console.WriteLine("1-Nombre de la empresa ");
                Console.WriteLine("2-Nombre de contacto");
                Console.WriteLine("3-Titulo de contacto");
                Console.WriteLine("4-Dirección");
                Console.WriteLine("5-Ciudad");
                Console.WriteLine("6-Región");
                Console.WriteLine("7-Código postal");
                Console.WriteLine("8-País");
                Console.WriteLine("9-Teléfono");
                Console.WriteLine("10-Fax");
                Console.WriteLine("0-Salir");
                string opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
                        Console.Write("Ingrese nuevo nombre de la empresa:");
                        customerToUpdate.CompanyName = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Ingrese nuevo nombre de contacto:");
                        customerToUpdate.ContactName = Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Ingrese titulo de contacto: ");
                        customerToUpdate.ContactTitle = Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("Ingrese nueva dirección: ");
                        customerToUpdate.Address = Console.ReadLine();
                        break;
                    case "5":
                        Console.Write("Ingrese nueva ciudad: ");
                        customerToUpdate.City = Console.ReadLine();
                        break;
                    case "6":
                        Console.Write("Ingrese nueva región: ");
                        customerToUpdate.Region = Console.ReadLine();
                        break;
                    case "7":
                        Console.Write("Ingrese nuevo codigo postal");
                        customerToUpdate.PostalCode = Console.ReadLine();
                        break;
                    case "8":
                        Console.Write("Ingrese nuevo país: ");
                        customerToUpdate.Country = Console.ReadLine();
                        break;
                    case "9":
                        Console.Write("Ingrese nuevo teléfono: ");
                        customerToUpdate.Phone = Console.ReadLine();
                        break;
                    case "10":
                        Console.Write("Ingrese nuevo fax: ");
                        customerToUpdate.Fax = Console.ReadLine();
                        break;
                    default:
                        Console.Write("Opción inválida...");
                        break;
                }
                if (opc != "0")
                {
                    customerLogic.Update(customerToUpdate);
                    Console.WriteLine("¿Desea modificar otra propiedad? (S/N): ");
                    string continuar = Console.ReadLine();
                    if (continuar.Trim().ToUpper() != "S")
                    {
                        break;
                    }
                }
            } while (true);
        }

      
    }
}
