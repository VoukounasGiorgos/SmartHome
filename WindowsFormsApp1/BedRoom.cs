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
    public partial class BedRoom : Form
    {
        int weather = 0;
        int activity = 0;
        public BedRoom()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
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
            
            button2.Visible = false;
            button3.Visible = false;
            weather = 1;
            //sunny

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            weather = 2;
            //rain
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = false;
            weather = 3;
            //cold
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            activity = 1;
            //run
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button6.Visible = false;
            activity = 2;
            //job
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (weather==1 && activity == 1)
            {
                pictureBox2.Visible = true;
                label3.Visible = true;
            }
            if (weather == 1 && activity == 2)
            {
                pictureBox3.Visible = true;
                label3.Visible = true;
            }
            if (weather == 1 && activity == 3)
            {
                pictureBox10.Visible = true;
                label3.Visible = true;
            }
            if (weather == 2 && activity == 1)
            {
                pictureBox4.Visible = true;
                label3.Visible = true;
            }
            if (weather == 2 && activity == 2)
            {
                pictureBox5.Visible = true;
                label3.Visible = true;
            }
            if (weather == 2 && activity == 3)
            {
                pictureBox6.Visible = true;
                label3.Visible = true;
            }
            if (weather == 3 && activity == 1)
            {
                pictureBox7.Visible = true;
                label3.Visible = true;
            }
            if (weather == 3 && activity == 2)
            {
                pictureBox8.Visible = true;
                label3.Visible = true;
            }
            if (weather == 3 && activity == 3)
            {
                pictureBox9.Visible = true;
                label3.Visible = true;
            }
            if(weather == 0)
            {
                label4.Visible = true;
            }
            if(activity == 0)
            {
                label5.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            activity = 3;
            //fun
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void BedRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
