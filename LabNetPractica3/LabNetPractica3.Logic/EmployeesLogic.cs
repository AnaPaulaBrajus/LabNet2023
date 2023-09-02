using LabNetPractica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica3.Logic
{
    public class EmployeesLogic: BaseLogic
    {

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }
    }
}

