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
        int guess;
        int secretNumber;

        public Form1()
        {
            InitializeComponent();
            Random secretNumber = new Random();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
