using System.Linq.Expressions;

namespace Automobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Automobile auto = new Automobile();

        private void UpdateInteface()
        {
            lMarca2.Text = auto.GetMarca();
            lModello2.Text = auto.GetModello();
            lTarga2.Text = auto.GetTarga();
            lCilindrata2.Text = auto.GetCilindrata().ToString();
            lPorte2.Text = auto.GetPorte().ToString();

        }

        private void bAggiorna_Click(object sender, EventArgs e)
        {
            try
            {
                // leggo i valori e li carica nelle varie proprietà della classe

                int cilindrata = int.Parse(tbCilindrata.Text);
                int porte = int.Parse(tbPorte.Text);

                auto.SetMarca(tbMarca.Text);
                auto.SetModello(tbModello.Text);
                auto.SetTarga(tbTarga.Text);
                auto.SetCilindrata(cilindrata);
                auto.SetPorte(porte);


                // aggiorno l'intefraccia
                UpdateInteface();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("controlla attentamente i valori numerici! "
                                + ex.Message);
            }
            
        }
    }
}