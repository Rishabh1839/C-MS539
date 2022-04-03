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
    public partial class Form3 : Form
    {
        int sc3;
        public Form3(int score)
        {
            InitializeComponent();
            sc3 = score;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc3--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc3--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sc3--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc3++; 
            MessageBox.Show("Correct!");
            MessageBox.Show("Your score is " + sc3.ToString());
            Form4 f4 = new Form4(sc3);
            f4.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
