using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bankcustomer030612
{
    public partial class Form1 : Form
    {
        BankCustomer[] bc = new BankCustomer[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bc[0] = new BankCustomer();
            bc[1] = new BankCustomer(1234, "Mary", "Ford");
            bc[2] = new BankCustomer(1254, "Andrew", "White");
            bc[3] = new BankCustomer(1256, "Liam", "Sharp", 3500.0);
            bc[4] = new BankCustomer(1266, "Michael", "Brown", 500.0);

            for (int i = 0; i < 5; i++)
            {
                string bcString = bc[i].bankCustomerToString() + "\r\n";
                richTextBox1.AppendText(bcString);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
