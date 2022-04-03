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
    public partial class Form7 : Form
    {
        int sc7;
        public Form7(int score)
        {
            InitializeComponent();
            sc7 = score;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc7--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc7--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc7--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
            MessageBox.Show("Your score is " + sc7.ToString());
            Form8 f8 = new Form8(sc7);
            f8.Show(); 
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
