using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cinema_131211
{
    public partial class Form1 : Form

    {
        //declaration class-level variables
        private int age;
        private Double fullPrice = 10.00;
        private Double total = 0;
        private Double price = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //The "ok" button method
        private void ok_Click_1(object sender, EventArgs e)
        {
            //Verifying it's an integer
            bool isNumber; 
            isNumber = Int32.TryParse(textBox1.Text, out age);

            if (!isNumber) 
            {
                MessageBox.Show("Please type in a number!");
            } 
            else 
            {     
                //Method that calculates price
                CalculatePrice(age,fullPrice);
            }  
        }

        private void CalculatePrice(int age,Double fullPrice)
        {
   
            //declaration local variables for CalculatePrice() method
            Double free = 0;
            Double underagePrice = fullPrice/2;
            Double adultPrice = fullPrice;


            /*age is compared to see which group it falls in and price is displayed 
            or message is displayed accordingly */
            if ((age < 0) || (age >100))    
            {
                MessageBox.Show("Typing error! Please re-type a valid age");
            }
            else if ((age >=0) && (age <=2))
            {
                MessageBox.Show("Babies are not allowed in!");
            }
            else if ((age>2)&&(age < 5) || (age >65)&&(age<=100))
            {
                price = free;
            }
            else if ((age >= 5) && (age < 18))
            {
                price = underagePrice;
            }
            else if ((age >= 18) && (age <=65))
            {
                price = adultPrice;
            }
         
            //Visualises price showing 2 digits after the decimal point
            PriceLabel.Text = "£ " + price.ToString("F2");

            total = total + price; // The price is added to the total

        }

        //TotalButton button method
        private void TotalButton_Click(object sender, EventArgs e)
        {

            //Visualises price showing 2 digits after the decimal point
            TotalLabel.Text = "£ " + total.ToString("F2");
            textBox1.Clear(); // The text box is cleared for another input
            price = 0;
            
        }
    }
}
