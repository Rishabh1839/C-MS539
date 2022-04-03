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
    public partial class Form5 : Form
    {
        int sc5;
        public Form5(int score)
        {
            InitializeComponent();
            sc5 = score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc5++;
            MessageBox.Show("Correct!");
            MessageBox.Show("Your score is " + sc5.ToString());
            Form6 f6 = new Form6(sc5);
            f6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc5--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc5--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sc5--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
