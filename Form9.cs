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
    public partial class Form9 : Form
    {
        int sc9;
        public Form9(int score)
        {
            sc9 = score;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc9++;
            MessageBox.Show("Correct!");
            MessageBox.Show("Your score is " + sc9.ToString());
            Form10 f10 = new Form10(sc9);
            f10.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc9--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc9--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sc9--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
