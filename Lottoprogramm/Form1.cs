using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottoprogramm
{
    public partial class Form1 : Form
    {
        //Variablen
        int[] zahl = new int[7];
        int[] tippzahl = new int[7];
        Boolean treffer;
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            //6 Random Zahlen Generieren 
            for (int i = 0; i < 6; i++)
            {
                zahl[i] = random.Next(1, 49);

            }
            //Ausgabe 
            Zahl1.Text = Convert.ToString(zahl[0]);
            Zahl2.Text = Convert.ToString(zahl[1]);
            Zahl3.Text = Convert.ToString(zahl[2]);
            Zahl4.Text = Convert.ToString(zahl[3]);
            Zahl5.Text = Convert.ToString(zahl[4]);
            Zahl6.Text = Convert.ToString(zahl[5]);

            for(int i=0; i < 6; i++)
            {
                for(int j=0; j < 6; j++)
                {
                    if (zahl[i] == tippzahl[j])
                        treffer = true;
                }
                if (treffer = true)
                {
                    if ()
                    {
                        tippzahl1.ForeColor = System.Drawing.Color.Red;
                    }
                }

            }
        }
    }
}
