using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOggettiSgt2B.Codice
{
  public class StudentSsat : Student
  {
    public string Section { get; set; }

    public override string CalcolaMail()
    {
      return $"{FirstName}.{Lastname}@ssat.ch";
    }

  }
}
