
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCorso
{
    internal class SalesPerson : Employee
    {
        internal decimal SalesAmount { get; set; } // Proprietà

        internal SalesPerson(string Name, string LastName, DateOnly BirthDate,
            int EmployeeId, string JobTitle, decimal GrossSalary)
            : base(Name, LastName, BirthDate, EmployeeId, JobTitle, GrossSalary)
        {

        }

        internal override void DisplayBasicInfo()
        {
            Console.WriteLine($"Nome: {this.Nome} - Cognome: {this.Cognome} - Data di nascita: {this.DataDiNascita} - Posizione: {this.JobTitle} - Ammontare vendite: {this.SalesAmount.ToString()}");
        }
    }
}
