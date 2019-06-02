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
            buttonlosuj.Enabled = false;


            //wyswietl kolejne elementry formularza
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NowaGra_Click(object sender, EventArgs e)
        {
            groupboxLosuj.Visible = true;
            NowaGra.Enabled = false;
        }
    }
}
