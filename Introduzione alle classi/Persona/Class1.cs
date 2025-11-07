using System;
using System.Windows.Media.Imaging;

namespace Persona
{
    /// <summary>   
    /// Definiamo una classe persona, con un attributo di visibilità public   
    /// </summary>
    public class Persona
    {
        public string Nome; 
        public string Cognome; 
        public DateTime Nascita; 
        public Enum StatoCivile; 
        public bool SessoMaschile; 
        public int Nap;

        public double CalcolaEta() 
        { 
            double eta = ((DateTime.Now - Nascita).TotalDays) / 365.25; 
            return eta; 
        }

        public string CalcolaNomeCompleto() 
        { 
            return this.Cognome + " " + this.Nome; 
        }

        public Persona()
        {
            Nascita = DateTime.Now;  // associamo un valore di default
        } 

        public Persona(string nome, string cognome, bool sessoMaschile = true)       
            // l'istruzione che segue fa in modo che quando uso questo costruttore,        
            // richiama il costruttore di base che inizializza la data di nascita
        : this()  
        {       // nelle righe che seguono associo i valori alle variabili interne
            Nome = nome;       
            Cognome = cognome;       
            SessoMaschile = sessoMaschile;     
        }

        static void Main()
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
