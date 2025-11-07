using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOggettiSgt2A.Codice
{
    public class Teacher : User
    {

        public Teacher()
        {

        }

        public Teacher(int userId, string firstName,
            string lastName, int cid, string mainSchool)
            : base(userId, firstName, lastName)
        {
            //UserId = userId;
            //FirstName = firstName;
            //this.LastName = lastName;
            Cid = cid;
            mainSchool = MainSchool;
        }



        private int _cid = 0;
        public int Cid { 
            get
            {
                return _cid;
            }
            set
            {
                if (value > 0)
                    _cid = value;
            }
        }

        public string MainSchool { get; set; }

    }
}
