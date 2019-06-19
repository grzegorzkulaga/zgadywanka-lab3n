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
            string check1 = textBoxod.Text;
            string check2 = textBoxdo.Text;

            if(check1.Length == 0 || check2.Length == 0 )
            {
                MessageBox.Show("Nie wprowadziłeś prawidłowego zakresu.");
            }
            else
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
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[0];
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
            LiczbaRuchow.Visible = true;
            Liczba.Visible = true;
            string check3 = textBoxliczba.Text;

            if (check3.Length == 0)
            {
                MessageBox.Show("Nie wprowadziłeś liczby!");
            }
            else
            { 
            int x = int.Parse(textBoxliczba.Text);
                if (Convert.ToString(g.Ocena(x)) == "ZaDuzo")
                    Liczba.Text = "za duża";
                else if (Convert.ToString(g.Ocena(x)) == "ZaMalo")
                    Liczba.Text = "za mała";
                else
                {
                    string title = "Udało Ci się!";
                    string body = $"Udało Ci się! Czy chcesz spróbować ponownie?";
                    LiczbaRuchow.Text = Convert.ToString((g.LicznikRuchow / 2));

                    MessageBoxButtons YesOrNo = MessageBoxButtons.YesNo;
                    DialogResult Wynik = MessageBox.Show(body, title, YesOrNo);

                    if (Wynik == DialogResult.No)
                    {
                        Close();
                    }
                    if (Wynik == DialogResult.Cancel)
                    {
                        Close();
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
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupboxLosuj_Enter(object sender, EventArgs e)
        {

        }

        private void Liczba_Click(object sender, EventArgs e)
        {

        }

        private void LabelRuch_Click(object sender, EventArgs e)
        {

        }

        private void LiczbaRuchow_Click(object sender, EventArgs e)
        {
            
        }

        private void ZrezygnujZGry_Click(object sender, EventArgs e)
        {
            string title = "Poddałeś się!";
            string body = "Czy na pewno chcesz się poddać? Nigdy się nie poddawaj! Zastanów się i kliknij anuluj!";

            MessageBoxButtons YesNoCancel = MessageBoxButtons.YesNoCancel;
            DialogResult Wynik = MessageBox.Show(body, title, YesNoCancel);

            if (Wynik == DialogResult.Yes)
            {
                Close();
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
}
