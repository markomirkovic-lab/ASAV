using DemoOggettiSgt2B.Codice;

namespace DemoOggettiSgt2B
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      User[] users = new User[5];
      

      Teacher user2 = new Teacher()
      {
        FirstName = "Mirko",
        Lastname = "Montemari",
        Cid = 1234,
        Sede = "SSSE"
      };
      users[0] = user2;
      int cid = user2.Cid;

      string mail = user2.CalcolaMail();

      Teacher t1 = user2;
      t1.FirstName = "Simone";
      mail = t1.CalcolaMail();
      cid = t1.Cid;


      User u1 = user2;
  //    cid = u1.Cid;

      mail = u1.CalcolaMail();




      StudentSsse user1 = new StudentSsse();
      user1.FirstName = "Niccolò";
      user1.Lastname = "Naddei";
      user1.Classe = "SGT2B";
      users[1] = user1;

      mail = user1.CalcolaMail();
      //construttore annonimo
      StudentScc user3 = new StudentScc()
      {
        FirstName = "Niccolo",
        Lastname = "Naddei",
        Classe = "SCC4A",
        Opzioni = "Comunicazione"
      };
      users[2] = user3;


      //user1.setLastname("Naddei");
      //user1.setLastname("pippo");
      //user1.setLastname("Naddeiiii");
      //user1.getLastname();



      dvgUtenti.DataSource = users;

    }
  }
}