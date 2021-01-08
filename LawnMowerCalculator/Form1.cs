using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawnMowerCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Added a button click event handler to calculate all the variables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateCmd_Click(object sender, EventArgs e)
        {
            // all the variables needed for the calculation
            double squareFeet = Convert.ToDouble(sqftTxt.Text);
            double tempsquareFeet = 0;
            double hours = 0;
            double minutes = 0;
            double price = 0;
            
            // a while loop to keep adding the amount of time until job is done.
            while(tempsquareFeet < squareFeet)
            {
                tempsquareFeet += 50;
                minutes += .05;
                if(minutes > .60)
                {
                    hours++;
                    minutes = 0;
                }
            }

            // the if statement is used to get the price for the amount of square feet that needs to be mowed
            if(squareFeet >= 1)
            {
                price = .10 * squareFeet;
            }

            hoursTxt.Text = Convert.ToString(hours + minutes);
            priceTxt.Text = Convert.ToString(price);
        }
    }
}
