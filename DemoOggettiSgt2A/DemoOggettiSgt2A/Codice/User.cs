using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOggettiSgt2A.Codice
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public int UserId { get; set; }

        public User()
        {

        }

        public User(string firstName, string lastName )           
        {
            FirstName = firstName;
            this.LastName = lastName;
        }
        public User(int userId,string firstName, string lastName)
        {
            UserId = userId;
            FirstName = firstName;
            this.LastName = lastName;
        }



        private string _lastName = "";
        public string LastName
        {
            get { 
                return _lastName;
            }
            set { 
                if (value.Length >= 3)
                  _lastName = value;
            }
        }

        

        public DateTime DateOfBirth { get;  set; }


        
    }
}
