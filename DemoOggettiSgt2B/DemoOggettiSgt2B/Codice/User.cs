using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOggettiSgt2B.Codice
{
    public abstract class User
    {
        public User(string FirstName)
        {
            FirstName = this.FirstName;
        }
        public User(string firstname, string lastname)
        {
            FirstName = firstname;
            Lastname = lastname;
        }
        public User()
        {

        }
        private string _lastname = "";
        public string Lastname { 
            get 
            { 
                return _lastname; 
            } 
            set 
            { 
                _lastname = value;
                //if (value.Length >= _lastname.Length)
                //{
                //   _lastname = value;
                //}
            }
        }
        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                //if (value.Length >= _lastname.Length)
                //{
                //    _lastname = value;
                //}
            }
        }

    //public void setLastname(string lastName)
    //{
    //    if (lastName.Length >= _lastname.Length)
    //    {
    //        _lastname = lastName;
    //    }

    //}
    //public string getLastname()
    //{
    //    return _lastname;
    //}



    //public String FullName()
    //{
    //    String User = FirstName + " " + LastName;
    //    return User;
    //}


    public string Mail { 
      get
      {
        return CalcolaMail();
      } 
    }

    public string test;

    protected string MailDomain { get;  set; } = "??";

    public virtual string CalcolaMail()
    {
      return $"{FirstName}.{Lastname}@{MailDomain}";
    }

  }
}
