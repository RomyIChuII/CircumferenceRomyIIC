/*
 * Created by: Romy I. Chu II
 * Created on: 21-Feb-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Circumference
 * This program calculates circumference given radius
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

namespace CircumferenceRomyIIC
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
        }

        private void btnCalculateRadius_Click(object sender, EventArgs e)
        {
            //Declaring that Pi is a constant
            const Double PI = 3.14159;
            
            //Creating a variable for radius
            Double radiusinput = Double.Parse(txtRadiusInput.Text);

            //Calculating circumference
            lblCircumference.Text = Convert.ToString(PI * (radiusinput * 2)) + "cm";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the Program
            this.Close();
        }
    }
}
