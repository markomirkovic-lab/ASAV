using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class PersonaDemo1
    {
        static void Main(string[] Args)
        {
            Persona p1 = new Persona();
            p1.Cognome = "Montemari";
            p1.Nome = "Mirko";
            p1.Nascita = new DateTime(1969, 03, 14);
            //p1.StatoCivile = StatoCivile("Sposato");
            p1.SessoMaschile = true;
            p1.Nap = 6672;

            double eta = p1.CalcolaEta();  // 51.46 anni
            string nomeCompleto = p1.CalcolaNomeCompleto(); // Montemari Mirko 

            // possiamo anche leggere il contenuto delle variabili (o attributi)
            string test = p1.Cognome;  // dopo questa riga, test vale "Montemari" 

            //possiamo anche cambiare il valore di una variabile
            p1.Cognome = "Pallino"; // il cognome dell'istanza p1 diventa Pallino


            Console.WriteLine(p1.Cognome);

        }
    }
}
