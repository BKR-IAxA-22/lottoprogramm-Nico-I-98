﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }
    }
}
