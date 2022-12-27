using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lottoprogramm
{
    public partial class Form1 : Form
    {
        // Variablen
        int[] zahl = new int[7];
        int[] tippzahl = new int[7];
        bool treffer;

        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            // 6 Random Zahlen generieren
            for (int i = 0; i < 6; i++)
            {
                zahl[i] = random.Next(1, 49);
            }

            // Ausgabe
            Zahl1.Text = Convert.ToString(zahl[0]);
            Zahl2.Text = Convert.ToString(zahl[1]);
            Zahl3.Text = Convert.ToString(zahl[2]);
            Zahl4.Text = Convert.ToString(zahl[3]);
            Zahl5.Text = Convert.ToString(zahl[4]);
            Zahl6.Text = Convert.ToString(zahl[5]);

            treffer = false;

            // Überprüfung, ob die Tippzahlen mit den Zufallszahlen übereinstimmen
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (zahl[i] == tippzahl[j])
                    {
                        treffer = true;
                        break;
                    }
                }

                // Farbe der Tippzahl-Labels ändern, wenn ein Treffer vorliegt
                if (treffer)
                {
                    switch (i)
                    {
                        case 0:
                            if (tippzahl1.ForeColor != Color.Red)
                            {
                                tippzahl1.ForeColor = Color.Red;
                            }
                            break;
                        case 1:
                            if (tippzahl2.ForeColor != Color.Red)
                            {
                                tippzahl2.ForeColor = Color.Red;
                            }
                            break;
                        case 2:
                            if (tippzahl3.ForeColor != Color.Red)
                            {
                                tippzahl3.ForeColor = Color.Red;
                            }
                            break;
                        case 3:
                            if (tippzahl4.ForeColor != Color.Red)
                            {
                                tippzahl4.ForeColor = Color.Red;
                            }
                            break;
                        case 4:
                            if (tippzahl5.ForeColor != Color.Red)
                            {
                                tippzahl5.ForeColor = Color.Red;
                            }
                            break;
                        case 5:
                            if (tippzahl6.ForeColor != Color.Red)
                            {
                                tippzahl6.ForeColor = Color.Red;
                            }
                            break;
                    }
                }

                treffer = false;
            }
        }
    }
}