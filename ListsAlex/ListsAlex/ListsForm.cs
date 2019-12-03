/*
 * Created by: Alex Ude
 * Created on: 03-12-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - lists
 * This program stores marks entered by a user and calculates the average
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsAlex
{
    public partial class frmLists : Form
    {
        List<int> myListOfIntegers = new List<int>();
        
        public frmLists()
        {
            InitializeComponent();
            this.lblAverage.Hide();
        }

        private void FrmLists_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            //declare local variables
            int userMark = -1;
            //convert the value in the textbox to an integer
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            //if the user did not enter a valid number, write the error to the command line
            catch(Exception parseError)
            {
                Console.WriteLine("An error occured:  '{0}'", parseError);
            }
            //check if the user entered a number between 0 and 100
            if ((userMark >= 0) && (userMark<= 100) )
            {
                //add the mark to the listbox 
                this.lstMarks.Items.Add(userMark);
                //add the mark to the list
                myListOfIntegers.Add(userMark);
            }
            //otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }
        }
       

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int sum = 0;
            double average;
            int counter;
            for(counter = 0; counter< myListOfIntegers.Count(); counter++)
            {
                sum = myListOfIntegers[counter] + sum;

            }
            average = sum / myListOfIntegers.Count();
            this.lblAverage.Text = "Average = "+ average;
            this.lblAverage.Show();
        }
    }
}
