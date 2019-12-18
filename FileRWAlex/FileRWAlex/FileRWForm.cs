/*
 * Created by: Alex Ude
 * Created on: 18-December-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program generates the output of lines in an input txt file
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

namespace FileRWAlex
{
    public partial class FileRWForm : Form
    {
        
        public FileRWForm()
        {
            InitializeComponent();
            this.lblOuput.Hide();
        }
        //Function: StringsAreEqual
        //Input: string string1, string string2
        //Output: bool
        //Description: this function checks if to see if two given strings are equal without considering the cases
        private bool StringsAreEqual(string string1, string string2)
        {
            // set boolen variable to false 
            bool isEqual = false;
            // declear local variables
            int stringLength1, stringLength2;
            //get the lengths of the strings 
            stringLength1 = string1.Length;
            stringLength2 = string2.Length;
            //check if the strings are equal in length
            if (stringLength1 == stringLength2)
            {
                //declear local variables
                string stringCase1, stringCase2;
                //convert strings to uppercase
                stringCase1 = string1.ToUpper();
                stringCase2 = string2.ToUpper();
                //check if the strings are equal
                if (stringCase1 == stringCase2)
                {
                    //set the boolean variable to true
                    isEqual = true;
                }
            }
            //return boolean variable equal to true 
            return isEqual;
        }


        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Read Each line of the file into a string array
            //Each element of the array is one line of the file
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            //array of characters that i want to take out when i split into words (spaces, tabs)
            char[] charSepartors = new char[] { ' ', '\t' };

            //the output string where i will put my results 
            string output = "";

            //go through and compare each string on each line of the file 
            foreach(string line in lines )
            {
                //split each line into words and put them into an array. 
                //i am assuming ther are only two words on the line 
                string[] words = line.Split(charSepartors, StringSplitOptions.RemoveEmptyEntries);

                if(StringsAreEqual(words[0], words[1]) == true)
                {
                    //concatenate the output to the string. there must be \r\n so that it goes onto a new line in the text file.
                    output = output + "True\r\n";
                }
                else
                {
                    //concatenate the output to the string. there must be \r\n so that it goes onto a new line in the text file.
                    output = output + "False\r\n";
                }
            }

            //WriteAllText creates a file writes the specific string to the file
            //and the close the file. You do Not need to call Flush() or close().
            //if  the file already exists, it overwrites the file.
            System.IO.File.WriteAllText(@"output.txt", output);

            //show the label that tells the use rthat the process is done
            this.lblOuput.Text = ("Output has been generated to text file ");
            this.lblOuput.Show();
        }
    }
   

}
