/*
 * Created by: Alex Ude
 * Created on: 2-December-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program gets the smallest value in and array of numbers
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

namespace FindMinValueAlex
{
    public partial class frmFindMinValue : Form
    {
        public frmFindMinValue()
        {
            InitializeComponent();
            this.lblAnswer.Hide();
        }

      

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declear local variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntergers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;
            Random numGen = new Random();
            //clear items in the listbox
            lstNumbers.Items.Clear();

            for (counter = 0; counter < arrayOfIntergers.Length; counter++)
            {
                //generate random numbers
                randomNumber = numGen.Next(0, MAX_RANDOM_NUMBER + 1);
                lstNumbers.Items.Add(randomNumber);
                arrayOfIntergers[counter] = randomNumber;
            }
            minValue = MinValue(arrayOfIntergers);
            //show the label , and display the max value
            lblAnswer.Text = "Min Value: " + minValue;
            lblAnswer.Show();
        }
        //Function: MinValue
        //Input: int[] tmpArray - assume all values 
        //Output: int
        //Description:this function takes an array of integers and gets the smallest value in the array
        private int MinValue(int[] tmpArray)
        {
            //declear variables
            int minValue = tmpArray[0];
            //check the numbers in the array if a number is smaller than the other, it is the min value
            foreach (int value in tmpArray)
            {
                if (value < minValue)
                {
                    minValue = value;
                }
          
                
            }
            return minValue;
        }
      
    }
}
   
            
         

