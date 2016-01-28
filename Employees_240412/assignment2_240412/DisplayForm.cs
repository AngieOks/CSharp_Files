using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace assignment2_240412
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            //In it's Properties, Modifiers was set to "Public"!! So it can be accessed from 
            //RegistrationForm!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //closes "this" object
        }
    }
}
