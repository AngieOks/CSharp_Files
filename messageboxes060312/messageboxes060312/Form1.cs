using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace messageboxes060312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //warning
            MessageBox.Show("The age must be over 18",
                            "Age is out of range", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

            //question
            if (MessageBox.Show("Do you want to buy this?",
                                "CD Purchase", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("User clicked Yes");
            }
            else
            {
                MessageBox.Show("User clicked No");
            }

        }
    }
}
