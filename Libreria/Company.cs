
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCorso
{
    internal class Company
    {
        internal Company()
        {
            Employees = new List<Employee>();
        }

        internal string Name { get; set; }
        internal List<Employee> Employees { get; set; }

        internal void ListAllEmployees()
        {
            if (Employees.Count == 0)
                Console.WriteLine("Non ci sono dipendenti");
            else
            {
                foreach (var item in Employees)
                {
                    item.DisplayBasicInfo();
                }
            }
        }

        internal void RemEmployeeByID(int id)
        {
            var element = Employees.Find(el => el.EmployeeId == id);
            if (element != null)
                Employees.Remove(element);
        }

        internal void RemEmployee(Employee item)
        {
            Employees.Remove(item);
        }

        internal void AddEmployee(Employee item)
        {
            Employees.Add(item);
        }

        internal Employee FindByID(int id)
        {
            var element = Employees.Find(el => el.EmployeeId == id);
            return element;
        }

        internal List<Employee> FindByName(string name)
        {
            var elements = Employees.FindAll(el => el.Nome == name);
            return elements;
        }
    }
}
