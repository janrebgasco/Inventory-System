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

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            floor_plan fp = new floor_plan();
            this.Hide();
            fp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int NumberOfClick = 0;
        private void panel18_Click(object sender, EventArgs e)
        {
            NumberOfClick++;
            switch (NumberOfClick)
            {
                case 1:
                    panel2.Visible = true;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 2:
                    panel3.Visible = true;
                    panel2.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 3:
                    panel5.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 4:
                    panel6.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    
                    break;
                case 5:
                    panel7.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 6:
                    panel8.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 7:
                    panel9.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 8:
                    panel10.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 9:
                    panel11.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 10:
                    
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    panel12.Visible = true;
                    break;
                case 11:
                    panel13.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 12:
                    panel14.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 13:
                    panel15.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel16.Visible = false;
                    break;
                case 14:
                    panel16.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    break;
                default:
                    NumberOfClick = 1;
                    break;
            }

            label2.Text = NumberOfClick.ToString();
        }

        private void panel17_VisibleChanged(object sender, EventArgs e)
        {

        }
        
        private void panel17_Click(object sender, EventArgs e)
        {
            NumberOfClick--;
            switch (NumberOfClick)
            {
                case 1:
                    panel2.Visible = true;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 2:
                    panel3.Visible = true;
                    panel2.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 3:
                    panel5.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 4:
                    panel6.Visible = true;
                    panel4.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    
                    break;
                case 5:
                    panel7.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 6:
                    panel8.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 7:
                    panel9.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 8:
                    panel10.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 9:
                    panel11.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 10:

                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    panel12.Visible = true;
                    break;
                case 11:
                    panel13.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 12:
                    panel14.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    break;
                case 13:
                    panel15.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel16.Visible = false;
                    break;
                case 14:
                    panel16.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    panel10.Visible = false;
                    panel11.Visible = false;
                    panel12.Visible = false;
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    break;
                default:
                    NumberOfClick = 14;
                    break;
            }
            label2.Text = NumberOfClick.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
