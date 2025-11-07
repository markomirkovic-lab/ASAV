using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class Automobile
    {
        String marca = "Audi";
        String modello = "A3";
        String targa = "TI12345";
        int cilindrata = 3000;
        int porte = 1;

        //String marca;
        //String modello;
        //String targa;
        //int cilindrata;
        //int porte;

        public Automobile()
        {

        }

        public Automobile(string marca, string modello, string targa, int cilindrata, int porte)
        {
            this.marca = marca;
            this.modello = modello;
            this.targa = targa;
            this.cilindrata = cilindrata;
            this.porte = porte;
        }

        public void SetMarca(String nuovaMarca)
        {
            this.marca = nuovaMarca;
        }

        public String GetMarca()
        {
            return this.marca;
        }

        public void SetModello(String nuovoModello)
        {
            if(nuovoModello.Length >= modello.Length)
            {
                this.modello = nuovoModello;
            }
        }

        public String GetModello()
        {
            return this.modello;
        }

        public void SetTarga(String nuovaTarga)
        {
            if(nuovaTarga.Substring(0,2)=="TI")
            {
                this.targa = nuovaTarga;
            }
        }

        public String GetTarga()
        {
            return this.targa;
        }

        public void SetCilindrata(int nuovaCilindrata)
        {
            if(nuovaCilindrata < cilindrata)
            {
                this.cilindrata = nuovaCilindrata;
            }
        }

        public int GetCilindrata()
        {
            return this.cilindrata;
        }

        public void SetPorte(int nuovePorte)
        {
            if (nuovePorte > porte)
            {
                this.porte = nuovePorte;
            }
        }

        public int GetPorte()
        {
            return this.porte;
        }

    }
}
