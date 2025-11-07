using DemoOggettiSgt2A.Codice;

namespace DemoOggettiSgt2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Teacher user1 = new Teacher();
            user1.FirstName = "Mirko";
            user1.LastName = "Montemari";

            Teacher user5 = new Teacher()
            {
                FirstName = "Roberto",
                LastName = "Taglialatela",
                UserId = 234
            };


            user1.FirstName = "Mirko";
            string t = user1.FirstName;

            user1.LastName = "Montemari";
            user1.LastName = "Jo";
            user1.LastName = "Rey";
            string a = user1.LastName;
            //user1.SetLastName("Montemari");
            //user1.SetLastName("Jo");
            //user1.SetLastName("Rey");
            //string a = user1.GetLastName();

            DateTime d = user1.DateOfBirth;
            user1.DateOfBirth = DateTime.Now;



            
            Teacher user4 = new Teacher(
                124, "Nello", "Otupacca", 1000, "SIG");

            Teacher user2 = new Teacher();
            user2.Cid = 30;
            user2.Cid = 20;
            user2.Cid = -10;
            user2.Cid = 100;

            StudentSsse ssig1 = new StudentSsse()
            {
                FirstName = "Ilias", LastName = "Donadoni",
                Class = "SGT2A", 
                DateOfBirth = new DateTime(2003,09,04),
                UserId = 1000
                 
            };

            StudentSsse ssig2 = new StudentSsse()
            {
                FirstName = "Alessandra",
                LastName = "Rodoni",
                Class = "SGT2A",
                DateOfBirth = new DateTime(1996, 08, 22),
                HasAComputer = true
            };

            StudentSsse test = ssig2;
            string u = test.LastName + " " + test.FirstName;

            string c = test.Class;

            User test1 = ssig2;
            u = test1.LastName + " " + test1.FirstName;
            c = test1.Class;

        }

      


    }
}