u
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCorso
{
    internal class ProjectManager : Employee
    {
        internal int TeamSize { get; set; }
        internal ProjectTypes Project { get; set; }

        internal ProjectManager(string Name, string LastName, DateOnly BirthDate,
            int EmployeeId, string JobTitle, decimal GrossSalary)
            : base(Name, LastName, BirthDate, EmployeeId, JobTitle, GrossSalary)
        {

        }

        internal override void DisplayBasicInfo()
        {
            Console.WriteLine($"Nome: {this.Nome} - Cognome: {this.Cognome} - Data di nascita: {this.DataDiNascita} - Posizione: {this.JobTitle} - Dimensione team: {this.TeamSize}");
        }
    }
}

