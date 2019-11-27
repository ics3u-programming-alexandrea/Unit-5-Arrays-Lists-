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

            //Function: GetMaxValue
            //Input: int[] tmpArrayOfIntergers - assume all values 
            //Output: 
            //Description:
        }
    }
}
