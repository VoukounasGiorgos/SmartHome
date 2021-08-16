using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LivingRoom temp = new LivingRoom();
            temp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitchen temp1 = new Kitchen();
            temp1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BedRoom temp4 = new BedRoom();
            temp4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.smarthome.com/");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
