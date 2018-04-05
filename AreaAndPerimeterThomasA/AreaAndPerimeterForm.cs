/*
 * Created by: Thomas Aubin
 * Created on: 5 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Area and Perimeter
 * This program calculates the area and perimeter of a rectangle and displays the result 
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

namespace AreaAndPerimeterThomasA
{
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();
        }

        // Calculate and display the area and perimeter of the rectangle of 5 by 3 cm
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            lblAreaAnswer.Text = "Area = " + Convert.ToString(5 * 3) + "cm";
            lblPerimeterAnswer.Text = "Perimeter = " + Convert.ToString((2 * 5) + (2 * 3)) + "cm";
        }
    }
}