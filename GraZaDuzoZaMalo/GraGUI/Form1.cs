using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Gra g;

        private void labelod_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wczytaj zakres do losowania
            int a = int.Parse(textBoxod.Text);
            int b = int.Parse(textBoxdo.Text);

            //utworz gre
            g = new Gra(a, b);

            textBoxod.Enabled = false;
            textBoxdo.Enabled = false;
            buttonlosuj.Visible = false;
            groupboxSprawdzanie.Visible = true;
            ZrezygnujZGry.Visible = true;
            //wyswietl kolejne elementy formularza
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NowaGra_Click(object sender, EventArgs e)
        {
            groupboxLosuj.Visible = true;
            NowaGra.Enabled = false;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Liczba.Visible = true;

            int x = int.Parse(textBoxliczba.Text);
            if (Convert.ToString(g.Ocena(x)) == "ZaDuzo")
                Liczba.Text = "za duża";
            else if (Convert.ToString(g.Ocena(x)) == "ZaMalo")
                Liczba.Text = "za mała";
            else
            {
                string title = "Udało Ci się!";
                string body = $"Udało Ci się! Czy chcesz spróbować ponownie?";

                MessageBoxButtons YesOrNo = MessageBoxButtons.YesNo;
                DialogResult Wynik = MessageBox.Show(body, title, YesOrNo);

                if(Wynik == DialogResult.No)
                {
                    this.Close();
                }
                if(Wynik == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    //Wczytanie nowej gry
                    NowaGra.Enabled = true;

                    //Wyczyszczenie textboxów
                    textBoxod.Clear();
                    textBoxdo.Clear();
                    textBoxliczba.Clear();

                    //Odblokowanie wcześniej wpisanych textboxów
                    textBoxod.Enabled = true;
                    textBoxdo.Enabled = true;

                    //Odblokowanie Groupboxa z wprowadzeniem i losowaniem liczb
                    groupboxLosuj.Visible = false;
                    buttonlosuj.Visible = true;

                    groupboxSprawdzanie.Visible = false;
                }


            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupboxLosuj_Enter(object sender, EventArgs e)
        {

        }
    }
}
