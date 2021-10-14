using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGamePractice
{
    public partial class Form1 : Form
    {
        int secretNumber;
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
            secretNumber = randGen.Next(1, 101);

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(inputBox.Text);
            if (guess > secretNumber)
            {
                outputLabel.Text = "Too high! Try again.";
            }
            else if (guess < secretNumber)
            {
                outputLabel.Text = "Too low! Try again.";
            }
            else if (guess == secretNumber)
            {
                outputLabel.Text = "You got it!";
            }
        }
    }
}
