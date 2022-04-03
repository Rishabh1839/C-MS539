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
    public partial class Form6 : Form
    {
        int sc6;
        public Form6(int score)
        {
            InitializeComponent();
            sc6 = score;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc6--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc6++;
            MessageBox.Show("Correct!");
            MessageBox.Show("Your score is " + sc6.ToString());
            Form7 f7 = new Form7(sc6);
            f7.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc6--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sc6--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
