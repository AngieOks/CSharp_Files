﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace classes060312
{
    public partial class Form1 : Form
    {
        private Baloon bal;
        private Sphere s;
        Graphics drawArea;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawArea = pictureBox1.CreateGraphics();
            bal = new Baloon();
            s = new Sphere();
            bal.Display(drawArea);
            s.Display(drawArea);

        }
    }
}
