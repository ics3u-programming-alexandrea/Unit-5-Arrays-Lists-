
/*
 * Created by: Alex Ude
 * Created on: 05-December-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #40 - Deal Card
 * This program changes the card in a picture box when it is clicked
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

namespace DealCardAlex
{
    public partial class frmDealCard : Form
    {
        //global variables
        List<Image> ListCardImages = new List<Image>();
        List<int> ListCardValues = new List<int>();
        Random randnum = new Random();
        
        public frmDealCard()
        {
            InitializeComponent();
        }
        
        private void FrmDealCard_Load(object sender, EventArgs e)
        {
            CreateDeck();
        }
        //procedure: CreateDeck
        //input: void
        //output: void
        //Description:  this procedure populates the deck of cards and the values
        private void CreateDeck ()
        {
            ListCardImages.Clear();
            ListCardValues.Clear();
            //Add all cards to a list
           ListCardImages.Add(Properties.Resources.AC);
           ListCardImages.Add(Properties.Resources.AD);
           ListCardImages.Add(Properties.Resources.AH);
           ListCardImages.Add(Properties.Resources.AS);

           ListCardImages.Add(Properties.Resources._2C);
           ListCardImages.Add(Properties.Resources._2D);
           ListCardImages.Add(Properties.Resources._2H);
           ListCardImages.Add(Properties.Resources._2S);

           ListCardImages.Add(Properties.Resources._3C);
           ListCardImages.Add(Properties.Resources._3D);
           ListCardImages.Add(Properties.Resources._3H);
           ListCardImages.Add(Properties.Resources._3S);

           ListCardImages.Add(Properties.Resources._4C);
           ListCardImages.Add(Properties.Resources._4D);
           ListCardImages.Add(Properties.Resources._4H);
           ListCardImages.Add(Properties.Resources._4S);

           ListCardImages.Add(Properties.Resources._5C);
           ListCardImages.Add(Properties.Resources._5D);
           ListCardImages.Add(Properties.Resources._5H);
           ListCardImages.Add(Properties.Resources._5S);

           ListCardImages.Add(Properties.Resources._6C);
           ListCardImages.Add(Properties.Resources._6D);
           ListCardImages.Add(Properties.Resources._6H);
           ListCardImages.Add(Properties.Resources._6S);

           ListCardImages.Add(Properties.Resources._7C);
           ListCardImages.Add(Properties.Resources._7D);
           ListCardImages.Add(Properties.Resources._7H);
           ListCardImages.Add(Properties.Resources._7S);

           ListCardImages.Add(Properties.Resources._8C);
           ListCardImages.Add(Properties.Resources._8D);
           ListCardImages.Add(Properties.Resources._8H);
           ListCardImages.Add(Properties.Resources._8S);

           ListCardImages.Add(Properties.Resources._9C);
           ListCardImages.Add(Properties.Resources._9D);
           ListCardImages.Add(Properties.Resources._9H);
           ListCardImages.Add(Properties.Resources._9S);

            ListCardImages.Add(Properties.Resources._10C);
            ListCardImages.Add(Properties.Resources._10D);
            ListCardImages.Add(Properties.Resources._10H);
            ListCardImages.Add(Properties.Resources._10S);

            ListCardImages.Add(Properties.Resources.JC);
           ListCardImages.Add(Properties.Resources.JD);
           ListCardImages.Add(Properties.Resources.JS);
           ListCardImages.Add(Properties.Resources.JH);

           ListCardImages.Add(Properties.Resources.QC);
           ListCardImages.Add(Properties.Resources.QD);
           ListCardImages.Add(Properties.Resources.QH);
           ListCardImages.Add(Properties.Resources.QS);

           ListCardImages.Add(Properties.Resources.KC);
           ListCardImages.Add(Properties.Resources.KD);
           ListCardImages.Add(Properties.Resources.KH);
           ListCardImages.Add(Properties.Resources.KD);
                        
            //Add the values of the cards respectively to the list of cards
           ListCardValues.Add(1);
           ListCardValues.Add(1);
           ListCardValues.Add(1);
           ListCardValues.Add(1);

           ListCardValues.Add(2);
           ListCardValues.Add(2);
           ListCardValues.Add(2);
           ListCardValues.Add(2);

           ListCardValues.Add(3);
           ListCardValues.Add(3);
           ListCardValues.Add(3);
           ListCardValues.Add(3);

           ListCardValues.Add(4);
           ListCardValues.Add(4);
           ListCardValues.Add(4);
           ListCardValues.Add(4);

           ListCardValues.Add(5);
           ListCardValues.Add(5);
           ListCardValues.Add(5);
           ListCardValues.Add(5);

           ListCardValues.Add(6);
           ListCardValues.Add(6);
           ListCardValues.Add(6);
           ListCardValues.Add(6);

           ListCardValues.Add(7);
           ListCardValues.Add(7);
           ListCardValues.Add(7);
           ListCardValues.Add(7);

           ListCardValues.Add(8);
           ListCardValues.Add(8);
           ListCardValues.Add(8);
           ListCardValues.Add(8);

           ListCardValues.Add(9);
           ListCardValues.Add(9);
           ListCardValues.Add(9);
           ListCardValues.Add(9);

           ListCardValues.Add(10);
           ListCardValues.Add(10);
           ListCardValues.Add(10);
           ListCardValues.Add(10);

           ListCardValues.Add(10);
           ListCardValues.Add(10);
           ListCardValues.Add(10);
           ListCardValues.Add(10);

           ListCardValues.Add(10);
           ListCardValues.Add(10);
           ListCardValues.Add(10);
           ListCardValues.Add(10);

            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);
            ListCardValues.Add(10);

            //procedure: DealCard
            //input: ref picturebox aPictureBox, int randomIndex
            //output: int
            //Description:  this function deals the cards to each picture box

        }
        private int DealCard(ref PictureBox aPictureBox, int randomIndex)
        {
            Image Card;
            int Value;

            //get the image from the random index
            Card = ListCardImages[randomIndex];

            //put the card image in the picturebox passed by reference
            aPictureBox.Image = Card;

            //remove the image from the list of cards
            ListCardImages.RemoveAt(randomIndex);
            Console.WriteLine("***List of card images count = " + ListCardImages.Count());

            //get the value of the card
            Value = ListCardValues[randomIndex];
            ListCardValues.RemoveAt (randomIndex);
            Console.WriteLine("***List of card values count = " + ListCardValues.Count());
            return Value;
            
        }

        private void picDealercard3_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count()== 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randnum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picDealercard3, random);
            }
           

        }

        private void picDealercard1_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randnum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picDealercard1, random);
            }
        }

       

        private void picPlayercard3_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randnum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picPlayercard3, random);
            }
        }

        private void picDealercard2_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randnum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picDealercard2, random);
            }
        }

        

        private void picPlayercard2_Click(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
            }
            else
            {
                int random = randnum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picPlayercard2, random);
            }
        }

        private void picPlayercard1_Click_1(object sender, EventArgs e)
        {
            if (ListCardImages.Count() == 0)
            {
                CreateDeck();
                Console.WriteLine("***Created new deck.");
            }
            else
            {
                int random = randnum.Next(0, ListCardImages.Count() - 1);
                DealCard(ref this.picPlayercard1, random);
            }
        }
    }           
}               
                
                