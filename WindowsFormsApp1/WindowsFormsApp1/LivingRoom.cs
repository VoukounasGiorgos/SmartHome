using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LivingRoom : Form
    {
        public LivingRoom()
        {
            InitializeComponent();
            numericUpDown1.Value = 25;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main temp = new Main();
            temp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LightsOn.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LightsOn.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            HeaterLabel.Text = numericUpDown1.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HeaterLabel.Text = numericUpDown1.Value.ToString();         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HeaterLabel.Text = "OFF";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void LivingRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
