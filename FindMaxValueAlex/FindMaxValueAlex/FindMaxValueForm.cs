/*
 * Created by: Alex Ude
 * Created on: 2-12-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program creats and array made up of random numbers and finds the greatest
 * value in the array
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

namespace FindMaxValueAlex
{
    public partial class frmFindMaxValue : Form
    {
        public frmFindMaxValue()
        {
            InitializeComponent();
        }

        private void FrmFindMaxValue_Load(object sender, EventArgs e)
        {
            lblMaxValue.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //declear local variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntergers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;
            Random numGen = new Random();
            //clear items in the listbox
            lstNumbers.Items.Clear();
            for (counter = 0; counter< arrayOfIntergers.Length; counter++)
            {
                //generate random numbers
                randomNumber = numGen.Next(0, MAX_RANDOM_NUMBER + 1);
                lstNumbers.Items.Add(randomNumber);
                arrayOfIntergers[counter] = randomNumber;
            }
            maxValue = MaxValue(arrayOfIntergers);
            //show the label , and display the max value
            lblMaxValue.Text = "Max Value; " + maxValue;
            lblMaxValue.Show();
        }

        //Function: GetMaxValue
        //Input: int[] tmpArray - assume all values 
        //Output: 
        //Description:this function takes an array of integers and gets the greatest value in the array
        private int MaxValue(int[]tmpArray)
        {
            //declear variables
            int maxValue = tmpArray[0];
            //check the numbers in the array if a number is bigger than the other, it is the max value
            foreach(int value in tmpArray)
            {
                if(value> maxValue)
                {
                    maxValue = value;
                }
            }
            return maxValue;
        }
    }
}
