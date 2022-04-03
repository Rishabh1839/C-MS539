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
    public partial class Form2 : Form
    {
        // integer score = sc
        int sc2;
        public Form2(int score)
        {
            InitializeComponent();
            sc2 = score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc2--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc2--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc2--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sc2++;
            MessageBox.Show("Correct!");
            MessageBox.Show("Your score is " + sc2.ToString());
            Form3 f3 = new Form3(sc2);
            f3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
