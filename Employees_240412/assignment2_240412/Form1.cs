/***********************************************************************
 *                                                                     *
 * Angela Okonedo          Course: COMP1381, Programming Technologies  *
 *                         Assignment 2 to be handed in by 24/04/12    * 
 *                                                                     *
************************************************************************/
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
    public partial class RegistrationForm : Form
    {

        private Employee[] workers = new Employee[20]; //an array workers[] where each element of 
                                                      //the array is an instance of Employee class 
        int count = 0;                               //counter for number of employees entered

        int id;                                                           //employee details
        string name;
        string surname;
        double salary;
        
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DisplayForm dForm = new DisplayForm(); //creates instance of Display form;

           if(count<3) //Checks atleast 10 employees have been entered, otherwise it gives 
                        //an error message  
            {
                MessageBox.Show("You must enter atleast 10 employees!");
            }
            else   //if count is more than 10 or more than 10 employees have been entered
            for (int i = 0; i < count; i++)   //it takes the details of each employee
            {
                string workerString = workers[i].employeeToString() + "\r\n"; //and puts them in an
                                                                            //array - workers[]
          
                dForm.richTextBox2.AppendText(workerString); //the string of employee details is 
                                                           //sent to the display form's richtextbox
                dForm.Show();                              //this shows the display form with all 
                                                           //the details 
            } 
         }

        private void registerButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text; //gets the name entered in textbox 
            surname = surnameTextBox.Text; //gets the surname entered in textbox
            
           //throws a format exception where the format or type is different from expected
           // in this case an integer!
            try
            {
                id = Convert.ToInt32(idTextBox.Text);
            }
            catch (FormatException exceptionObject) //catches the exception showingan error message!
            {
                MessageBox.Show("Typing Error: re-enter a valid id number!");
                count--; //if the wrong data was put in, user needs to re-enter the details,
                         //the number of employees entered correctly should remain the same!
            }
            //throws a format exception where the format or type is different from expected
            // in this case a double!
            try
            {
                salary = Convert.ToDouble(salaryTextBox.Text);
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show("Typing Error: re-enter a valid salary!");
                count--;//if the wrong data was put in, user needs to re-enter the details,
                        //the number of employees entered correctly should remain the same!
            }

                workers[count] = new Employee(id, name,surname, salary); 
                
                
                count++; //increases for next employee
                label6.Text = Convert.ToString(count);//Shows the number of employees typed in 
                                                      //so far 
                
               //text boxes are cleared for next input
                idTextBox.Text = "";                
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
                salaryTextBox.Text = "";
            
        }

        private void lowestSalaryButton_Click(object sender, EventArgs e)
        {
            PrintLowestSalary(workers); //Print Lowest salary method is called
        }

        //Method that receives the array of workers and prints the ones with the lowest salary
        private void PrintLowestSalary(Employee[] workers)
        {
            DisplayForm dForm = new DisplayForm(); //instance of display form

            dForm.richTextBox2.AppendText("Lowest salary workers:" + "\r\n" + "\r\n");
            double minSalary = workers[0].Salary;  //sets the the first element of the array
                                                   //as the default minimum salary

            for (int i = 0; i < count; i++)
            {
                if (workers[i].Salary < minSalary) //compares the minimum salary with other salaries
                {
                    minSalary = workers[i].Salary; //saves the new minimum salary
                }
            }

            //prints the employees with the lowest salary
            for (int i = 0; i < count; i++)  //checks every employee in the array
            {
                if (workers[i].Salary == minSalary) // if his salary is the same as the 
                                                    //minimum salary 
                {
                    string workerString = workers[i].employeeToString() + "\r\n";
                    dForm.richTextBox2.AppendText(workerString);//it sends the string to the 
                                                                //display form

                    dForm.Show();                              //shows the display form
                }
            }
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
     }
}

