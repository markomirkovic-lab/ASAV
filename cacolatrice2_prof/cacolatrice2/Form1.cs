using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cacolatrice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        // condition x = 26
        /*

        int z = -100;
        for(int i = 0; i < 1000; i++)
        {
            if(i % 20 == 3)
            {
                z -= 10;
            }
            else
            {
                z++;
            }
        }
        */

        private void bPlus_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(tbA.Text);
                double b = double.Parse(tbB.Text);
                double ris = a + b;
                lRis.Text = ris.ToString();
                //questo funziona e fa +

                //try tab tab
            }
            catch (Exception ex)
            {
                //MessageBox e' una classe
                //Show e' un metodo
                var t = MessageBox.Show("Controlla bene i numeri che hai inserito.", 
                    "Errore", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);

                //MessageBox.Show("Controlla bene i numeri che hai inserito." : e' il messggio nel message box
                //"Errore" e' il titolo del message box
                //MessageBoxButtons.OKCancel : sono 2 bottoni del message box OK e Cancel
                //MessageBoxIcon.Error : fa vedere l'icona error nel message box



                //string s = "";


                //throw new Exception("Attenzione: non esiste il padre per questo uttente");
                //propaga l'eccezzione a livello piu' alto
            }



            /*
            catch (FormatException ex1)
            {

            }

            //...

            catch (Exception ex)
            */

            /*
            finally
            {

            }
            */

        }

        private void bMinus_Click(object sender, EventArgs e)
        {

            try
            {
                double a = double.Parse(tbA.Text);
                double b = double.Parse(tbB.Text);
                double ris = a - b;
                lRis.Text = ris.ToString();
                //questo funziona e fa -

                //try tab tab
            }
            catch (Exception ex)
            {
                //MessageBox e' una classe
                //Show e' un metodo
                var t = MessageBox.Show("Controlla bene i numeri che hai inserito.",
                    "Errore", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //string s = "";


                //throw new Exception("Attenzione: non esiste il padre per questo uttente");
                //propaga l'eccezzione a livello piu' alto
            }




        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(tbA.Text);
                double b = double.Parse(tbB.Text);
                double ris = a / b;
                lRis.Text = ris.ToString();
                //questo funziona e fa /

                //try tab tab
            }
            catch (Exception ex)
            {
                //MessageBox e' una classe
                //Show e' un metodo
                var t = MessageBox.Show("Controlla bene i numeri che hai inserito.",
                    "Errore", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //string s = "";


                //throw new Exception("Attenzione: non esiste il padre per questo uttente");
                //propaga l'eccezzione a livello piu' alto
            }

        }

        private void bMoltiply_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(tbA.Text);
                double b = double.Parse(tbB.Text);
                double ris = a * b;
                lRis.Text = ris.ToString();
                //questo funziona e fa *

                //try tab tab
            }
            catch (Exception ex)
            {
                //MessageBox e' una classe
                //Show e' un metodo
                var t = MessageBox.Show("Controlla bene i numeri che hai inserito.",
                    "Errore", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //string s = "";


                //throw new Exception("Attenzione: non esiste il padre per questo uttente");
                //propaga l'eccezzione a livello piu' alto
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
