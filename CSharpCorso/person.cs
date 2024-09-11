
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCorso
{
    internal class Persona
    {
        protected DateOnly DataDiNascita { get; set; } // Private field	

        internal Persona() // Fatto per employee.cs
        {

        }

        internal Persona(string Nome, string Cognome, DateOnly DataDiNascita)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.DataDiNascita = DataDiNascita;
        }

        internal string Nome { get; set; } // Proprietà, permettere di leggere e scrivere (get e set)
        internal string Cognome { get; set; }
        internal string CF { get; set; }
        internal string Email { get; set; }
        internal string Indirizzo { get; set; }
        // internal DateOnly DataDiNascita { get; set; }

        internal int Age
        {
            get
            {
                return GetAge();
            }
        }

        // Essendo private non possiamo usarla fuori da qui, perciò lo useremo per calcolare la proprietà "Age"
        private int GetAge() // Funzione per calcolare l'età
        {
            int age = DateTime.Now.Year - DataDiNascita.Year;
            DateTime compleanno = new DateTime(DateTime.Now.Year, DataDiNascita.Month, DataDiNascita.Day);
            if (DateTime.Now < compleanno)
            {
                age--;
            }
            return age;
        }

        // Useremo questa funzione per printare le 3 info principali
        internal virtual void DisplayBasicInfo()
        {
            Console.WriteLine("Nome: " + this.Nome + "\n" + "Cognome: " + this.Cognome + "\n" + "Data di Nascita: " + this.DataDiNascita);
        }

        // Overloading metodo
        /// <summary>
        /// Stampa sulla console Nome, cognome e data di nascita con prefisso
        /// </summary>
        /// <param name="prefix">Prefisso del messaggio mostrato</param>
        internal virtual void DisplayBasicInfo(string prefix)
        {
            Console.WriteLine("Nome: " + prefix + this.Nome + "\n" + "Cognome: " + this.Cognome + "\n" + "Data di Nascita: " + this.DataDiNascita);
        }

        // Overloading metodo
        /// <summary>
        /// Stampa sulla console Nome, cognome e data di nascita con prefisso e postfisso
        /// </summary>
        /// <param name="prefix">Prefisso del messaggio mostrato</param>
        /// <param name="postfix">Postfisso del messaggio mostrato</param>
        internal virtual void DisplayBasicInfo(string prefix, string postfix)
        {
            Console.WriteLine("Nome: " + prefix + this.Nome + "\n" + "Cognome: " + this.Cognome + "\n" + "Data di Nascita: " + this.DataDiNascita + postfix);
        }
    }
}
