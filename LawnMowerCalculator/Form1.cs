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

        private void calculateCmd_Click(object sender, EventArgs e)
        {
            double squareFeet = Convert.ToDouble(sqftTxt.Text);
            double tempsquareFeet = 0;
            double hours = 0;
            double minutes = 0;
            double price = 0;

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

            if(squareFeet >= 1)
            {
                price = .10 * squareFeet;
            }

            hoursTxt.Text = Convert.ToString(hours);
            priceTxt.Text = Convert.ToString(price);
        }
    }
}
