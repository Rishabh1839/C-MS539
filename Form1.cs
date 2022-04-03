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
    public partial class Form1 : Form
    {
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnswer(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            score--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
            score++;
            Form2 f2 = new Form2(score);
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            score--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
