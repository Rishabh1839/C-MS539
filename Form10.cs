using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_MS549
{
    public partial class Form10 : Form
    {
        int sc10;
        public Form10(int score)
        {
            sc10 = score;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc10--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc10--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc10--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sc10++;
            MessageBox.Show("Your score is " + sc10.ToString());
            MessageBox.Show("Correct! End of the Quiz!");
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
