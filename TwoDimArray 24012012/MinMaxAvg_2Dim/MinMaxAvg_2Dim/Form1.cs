using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinMaxAvg_2Dim
{
    public partial class Form1 : Form
    {
        int[,] twodimarray = 
            {{9, 7, 6, 5, 4, 5, 11},
             {5, 6, 8, 45, 10, 14, 23},
             {12, 5, 6, 7, 3, 19, 8},
            {11, 5, 0, 7, 1, 19, 6} };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {

            Display_array();
        }

        private void Max()
        {
            int rows = twodimarray.GetLength(0);
            int columns = twodimarray.GetLength(1);

            int max = twodimarray[0, 0];
            for (int r = 0; r < rows; r++)
                {
                for (int c = 0; c < columns; c++)
                    {
                    if (max < twodimarray[r, c]) max = twodimarray[r, c];
                    }
                }
            maxTextBox.Text = Convert.ToString(max);
        }

       private void Min()
        {
            int rows = twodimarray.GetLength(0);
            int columns = twodimarray.GetLength(1);

            int min = twodimarray[0, 0];
            for (int r = 0; r < rows; r++)
                 
            {
                for (int c = 0; c < columns; c++)
                 {    
                    if (min > twodimarray[r, c]) min = twodimarray[r, c];
                  }
            }
            minTextBox.Text = Convert.ToString(min);
        }

        private void Average()
        {
            int rows = twodimarray.GetLength(0);
            int columns = twodimarray.GetLength(1);

            int total = 0;
            for (int r = 0; r < rows; r++)
                {
                for (int c = 0; c < columns; c++)
                  {
                    total = total + twodimarray[r, c];
                  }
                   // int avg = total / (rows * columns);
                }
            averageTextBox.Text = Convert.ToString(total / (rows * columns));
        }
        private void Display_array()
        {
            richTextBox1.Clear();

            int rows = twodimarray.GetLength(0);
            int columns = twodimarray.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                  {
                    richTextBox1.AppendText(Convert.ToString(twodimarray[r, c]) + "\t");
                }
                richTextBox1.AppendText("\n");
                  }

            }

        private void minButton_Click(object sender, EventArgs e)
        {
         Min();
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            Max();
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
             Average();
        }
        
    }
  }

