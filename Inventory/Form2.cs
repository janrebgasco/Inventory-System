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
    public partial class floor_plan : Form
    {
        public floor_plan()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void floor_plan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            home hm = new home();
            this.Hide();
            hm.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Form3 fp3d = new Form3();
            this.Hide();
            fp3d.Show();
        }
    }
}
