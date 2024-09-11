
using System.Text;
using CSharpCorso; // Userà le nostre librerie
// Dichiarazione di variabile di tipo intero + assegnazione
int a = 5;
int c = 1;
// char d = 'a';
string nome = "pluto";
string cognome = "paperino";
// "b" sarà vero solo se "a" è diverso da 10 OPPURE se "c" è uguale a 5
bool b = a != 10 || c == 10;

// ESEMPIO WriteLine:
Console.WriteLine(b); // Sarà true

// ESEMPIO SWITCH:
switch (b)
{
    case true:
        Console.WriteLine("True!"); //<-- Uscirà true
        break;
    case false:
        Console.WriteLine("False!");
        break;
}

// ESEMPIO WHILE
int i = 0;
while (i < 10)
{
    if (i % 2 != 0)
    {
        i++;
        continue;
    }
    Console.WriteLine(i); //Printerà solo numeri pari fino all'8
    i++;
}

string valori = "1,2,3,4,5";
// Separatore, in questo caso da ogni virgola
string[] result = valori.Split(',');
// Printerà il valore 4, che in questo caso è 5
Console.WriteLine(result[4]);

// Stessa cosa ma con il nome pluto
string[] resultNome = nome.Split('u');
// Printerà "pl" essendo diviso dalla u, ma se metto 1 printerà "to"
Console.WriteLine(resultNome[0]);

// Sempre un metodo per creare un array ma con "ToArray()"
string caratteri = "a b c d e";
// Sostituisce il primo valore (che sarebbe lo spazio) con il secondo valore (che sarebbe nulla, quindi cancellando gli spazi)
string carPulizia = caratteri.Replace(" ", "");
char[] caratteriArray = carPulizia.ToArray();
// Viene divisa automanticamente ogni lettera, in questo caso printerà "c"
Console.WriteLine(caratteriArray[2]);

// ESEMPIO FOR
// Printerà ogni lettera di "caratteriArray", assegnandogli un valore numerico
for (int j = 0; j < caratteriArray.Length; j++)
{
    Console.WriteLine("Il valore di [" + j + "] è: " + caratteriArray[j]);
}

// ESEMPIO FOREACH
foreach (string item in result)
{
    Console.WriteLine("Il valore dell'elemento corrente è: " + item);
}

// Metodo per creare una serie di stringhe
StringBuilder myBuilder = new StringBuilder(); //Dichiarazione di una variabile
myBuilder.Append(nome);
myBuilder.Append(" - ");
myBuilder.Append(cognome);
Console.WriteLine(myBuilder.ToString());

// typeof ci dice il corso della determinata classe, in questo caso creata da me
Console.WriteLine(typeof(Persona));

// Creo l'oggetto e gli assegno dei dati
Persona persona1 = new Persona("Massimo", "Dolore", new DateOnly(2001, 7, 23));
// In questo caso lo sto assegnando manualmente
persona1.CF = "AF3FS3SCNG54HI5";
persona1.Email = "gianmarchini82@gmail.com";

// Adesso printo tutto, con un metodo scritto in person.cs
persona1.DisplayBasicInfo();

/* Una volta creata la funzione sarà possibile usarla per
 * calcolare l'età della persona, tuttavia ho scelto di
 * rendere la funzione privata e di trasformarla in
 * una proprietà dell'oggetto.
 */
// Così è come sarebbe con la funzione
// Console.WriteLine(persona1.GetAge());

// Così invece chiamiamo la funzione attraverso la proprietà
Console.WriteLine(persona1.Age);

// Andiamo a definire un employee
Employee employee1 = new Employee("Samuele", "Pescatore", new DateOnly(2002, 11, 18), 1, "Spy Agency", 100000.00M);

// Questo comando triggera l'ArgumentException come prova
// employee.CompanyName = "";

// Andiamo a stampare tutto
employee1.DisplayBasicInfo();
Console.WriteLine("Età: " + employee1.Age);

Developer dev = new Developer("Paolo", "De Paolis", new DateOnly(1980, 7, 31), 1, "Senior .NET Developer", 100000.00M);
dev.Skills = DevSkills.CSharp;
//dev.DisplayBasicInfo(); // Polimorfismo Developer

SalesPerson salesPerson = new SalesPerson("Gino", "De Gino", new DateOnly(1970, 4, 19), 2, "Head of Sales", 200000.00M);
salesPerson.SalesAmount = 1500000;
//salesPerson.DisplayBasicInfo(); // Polimorfismo SalesPerson

ProjectManager projectManager = new ProjectManager("Pino", "De Pinis", new DateOnly(1977, 8, 23), 3, "PA Administrator", 200000.00M);
projectManager.Project = ProjectTypes.PA;
projectManager.TeamSize = 20;
//projectManager.DisplayBasicInfo(); // Polimorfismo ProjectManager

// Creo un array di tre elementi 
Employee[] employee2 = new Employee[3]; // dimensione predeterminata
// Popolo l'array con gli oggetti
employee2[0] = dev;
employee2[1] = salesPerson;
employee2[2] = projectManager;

for (int z = 0; z < employee2.Length; z++)
{
    employee2[z].DisplayBasicInfo();
}

// Creo una lista vuota di oggetti di tipo Employee
List<Employee> employees = new List<Employee>();
// Aggiungo oggetti
employees.Add(dev);
employees.Add(salesPerson);
employees.Add(projectManager);
foreach (Employee item in employees)
{
    item.DisplayBasicInfo();
}
// Creo un dictionary com chiave pari ad EmployeeId (1,2,3)
Dictionary<int, Employee> dictemployees = new Dictionary<int, Employee>();
dictemployees.Add(dev.EmployeeId, dev);
dictemployees.Add(salesPerson.EmployeeId, salesPerson);
dictemployees.Add(projectManager.EmployeeId, projectManager);
foreach (KeyValuePair<int, Employee> item in dictemployees)
{
    item.Value.DisplayBasicInfo();
}

// Uso la classe Company
Console.WriteLine("Utilizzo la classe Company");
Company company = new Company();

company.AddEmployee(dev);
company.AddEmployee(salesPerson);
company.AddEmployee(projectManager);
company.ListAllEmployees();

// Ora cerchiamo i dipendenti dal nostro input
/* Messo tra commenti per non interferire con il seguente esempio
 * var items = company.FindByName("Gino");
 * Console.WriteLine("Trovati: " + items.Count + " dipendenti di nome Gino.");
 */

// Invece adesso lo cerchiamo attraverso un input esterno
Console.WriteLine("Inserisci il nome da cercare: "); // Per test scrivere Paolo
string search = Console.ReadLine();
if (search != null)
{
    var items = company.FindByName(search);
    Console.WriteLine("Trovati: " + items.Count + " dipendenti di nome " + search);
}

