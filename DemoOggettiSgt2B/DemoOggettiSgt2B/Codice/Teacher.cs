using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOggettiSgt2B.Codice
{
    internal class Teacher : User
    {
        public int Cid { get; set; }
        public string Sede { get; set; }
        public Teacher():base()
        {
      MailDomain = "edu.ti.ch";
        }

   // public override string CalcolaMail()
   // {

   ////   return (($"{FirstName}.{Lastname}@edu.ti.ch").ToLower()).ToLower();
   //  // return FirstName + "." + Lastname + "@edu.ti.ch";
   // }
    }
}
