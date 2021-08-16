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
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main temp = new Main();
            temp.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoilerLabel.Text = "ON";
            BoilerLabel.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BoilerLabel.Text = "OFF";
            BoilerLabel.BackColor = Color.DimGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Heaterl.Text = "ON";
            Heaterl.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Heaterl.Text = "OFF";
            Heaterl.BackColor = Color.DimGray;
        }

        private void Kitchen_Load(object sender, EventArgs e)
        {

        }
    }
}
