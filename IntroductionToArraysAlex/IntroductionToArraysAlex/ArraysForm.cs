/*
 * Created by: Alex ude
 * Created on: 27-November-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program randomly generates numbers in a listbox and then calculates the average
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

namespace IntroductionToArraysAlex
{
    public partial class frmArrays : Form
    {
        //declear global variables  and constants
       
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayofNumbers = new int[MAX_ARRAY_SIZE];
        public frmArrays()
        {
            InitializeComponent();
        }

        private void FrmArrays_Load(object sender, EventArgs e)
        {
            this.lblAverage.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //declare local variables 
            int randomNumber;
            int counter;
            Random randomNumberGenerator = new Random();

            //clea items in list box 
            this.lstNumbers.Items.Clear();

            for( counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //generate a new random number to cell at position "counter in the array"
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);
                arrayofNumbers[counter] = randomNumber;
                //assign the random number to the listbox
                this.lstNumbers.Items.Add(randomNumber);
                //refresh the form to display the items in the list box 
                this.Refresh();
            }
        }

        private void BtnCalculateAverage_Click(object sender, EventArgs e)
        {
            double average = 10;
            double sum = 0;
            int counter;

            //caculate the sum of numbers in the array
            for(counter = 0; counter< arrayofNumbers.Length; counter++)
            {
                sum = sum + arrayofNumbers[counter];
                //calculate the average
                average = sum / arrayofNumbers.Length;
                 //display average
                  this.lblAverage.Text = "Average: " + average;
                this.lblAverage.Show();
            }
        }
    }
}
