using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2dimArray240212
{
    public partial class Form1 : Form
    {
        int[,] rainData = 
            {{10, 7, 6, 5, 4, 8, 11},
             {5, 6, 8, 9, 10, 14, 23},
             {12, 15, 6, 7, 3, 19, 8}};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void ChangeValue()
        {
            int location;
            int dayNumber;
            int dataValue;

            location = Convert.ToInt32(locationTextBox.Text);
            dayNumber = Convert.ToInt32(dayTextBox.Text);
            dataValue = Convert.ToInt32(valueTextBox.Text);

            rainData[location, dayNumber] = dataValue;

            Display();
            CalculateTotal();
        }


        private void Display()
        {
            richTextBox1.Clear();

            for (int location = 0; location <= 2; location++)
            {
                for (int dayNumber = 0; dayNumber <= 6; dayNumber++)
                {
                    richTextBox1.AppendText(Convert.ToString(
      rainData[location, dayNumber]) + "\t");
                }
                richTextBox1.AppendText("\n");
            }
        }

        private void CalculateTotal()
        {
            int total = 0;
            for (int location = 0; location <= 2; location++)
            {
                for (int dayNumber = 0; dayNumber <= 6; dayNumber++)
                {
                    total = total + rainData[location, dayNumber];
                }
            }
            totalLabel.Text = "total rainfall is: " +
                  Convert.ToString(total);
        }

        private void dayTextBox_TextChanged(object sender, EventArgs e)
        {

        } 

    }
}
