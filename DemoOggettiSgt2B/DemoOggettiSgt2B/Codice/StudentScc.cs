using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOggettiSgt2B.Codice
{
    public class StudentScc : Student
    {
        public string Opzioni { get; set; }
    
    public override string CalcolaMail()
    {
      return $"{Lastname.Substring(0, Math.Min(6, Lastname.Length))}" +
        $"{FirstName.Substring(0, 2)}@sccbellinzona.ch";
    }
    }
}
