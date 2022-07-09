using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            floor_plan fp = new floor_plan();
            this.Hide();
            fp.Show();
            


        }

        private void panel7_Click(object sender, EventArgs e)
        {
            floor_plan fp = new floor_plan();
            this.Hide();
            fp.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            floor_plan fp = new floor_plan();
            this.Hide();
            fp.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            schedule sched = new schedule();
            this.Hide();
            sched.Show();
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            schedule sched = new schedule();
            this.Hide();
            sched.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            schedule sched = new schedule();
            this.Hide();
            sched.Show();
        }
    }
}
