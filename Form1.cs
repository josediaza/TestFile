using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Uranus is button8_Click
        private void button8_Click(object sender, EventArgs e)
        {
            double outputValue=0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");
            }
            else
            {
                double userWeight;
                double uranusWeight = 0;
                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    uranusWeight = userWeight * 1.15;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + uranusWeight.ToString()+ " pounds on Uranus","Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }

                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();  
                }
                textBox1.Clear();
            }
        }

                
        //The User weight on Earth
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        //Mars is button7 
        private void button7_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");
            }
            else
            {
                double userWeight;
                double marsWeight = 0;
                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    marsWeight = userWeight * 0.38;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + marsWeight.ToString() + " pounds on Mars","Result");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Saturn is button5
        private void button5_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");
            }
            else
            {
                double userWeight;
                double saturnWeight = 0;
                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    saturnWeight = userWeight * 1.15;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + saturnWeight.ToString() + " pounds on Saturn", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Pluto is button6
        private void button6_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");
                
            }
            else
            {
                double userWeight;
                double plutoWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    plutoWeight = userWeight * 0.05;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + plutoWeight.ToString() + " pounds on Pluto", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Mercury is button1
        private void button1_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");

            }
            else
            {
                double userWeight;
                double mercuryWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    mercuryWeight = userWeight * 0.37;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + mercuryWeight.ToString() + " pounds on Mercury", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Neptune is button3
        private void button3_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");

            }
            else
            {
                double userWeight;
                double neptuneWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    neptuneWeight = userWeight * 1.12;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + neptuneWeight.ToString() + " pounds on Neptune", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Jupiter is button2
        private void button2_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");

            }
            else
            {
                double userWeight;
                double jupiterWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    jupiterWeight = userWeight * 2.64;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + jupiterWeight.ToString() + " pounds on Jupiter", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();
            }
        }
        //Venus is button4
        private void button4_Click(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isNumber = false;

            isNumber = double.TryParse(textBox1.Text, out outputValue);
            if (!isNumber)
            {
                MessageBox.Show("Please type a real weight in pounds");

            }
            else
            {
                double userWeight;
                double venusWeight = 0;

                {
                    userWeight = double.Parse(textBox1.Text);
                }
                if (userWeight > 0)
                {
                    venusWeight = userWeight * 0.88;
                    MessageBox.Show("Your weight of " + userWeight.ToString() + " pounds on Earth would be " + venusWeight.ToString() + " pounds on Venus", "Done");
                }
                else
                {
                    MessageBox.Show("Enter a real weight in pounds");
                }
                if (MessageBox.Show("Continue calculating other planets?", "Done", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    Application.Exit();
                }
                textBox1.Clear();

            }

        }
        //Quit is button9
        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }
    }
}
