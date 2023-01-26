using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VK3_KT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tmrAika.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!tmrAika.Enabled) tmrAika.Start();

            // seconds = 60;
           // tmrAika.Start();
          // tmrAika.Enabled = true;
         //  btnHit
        }

        int count = 1;
        int timeleft = 10;

        private void btnHit_Click(object sender, EventArgs e)
        { 
            if (stlbPisteet != null)
            stlbPisteet.Text = "Hits: " + count.ToString();

            count = count + 1;

            Random x = new Random();
            
            Point pt = new Point(
                int.Parse(x.Next(400).ToString()),
                int.Parse(x.Next(250).ToString())
                );
            btnHit.Location = pt;
            // textBox1.Text = "Hits: " + i;

            if(timeleft == 0)
            {
                MessageBox.Show("Hits: " + count);
            }
        } 

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {            
            stlbPisteet.Text =count.ToString();

            // "Hits ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft -1;
                lbTime.Text = timeleft.ToString();
            }
            else
            {
                tmrAika.Stop();
                lbTime.Text = "Time is up!";
            }
        }

        private void tslbAloitus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tmrKello_Tick(object sender, EventArgs e)
        {
            tsslbAika.Text = "Time Now: " + DateTime.Now.ToString();
        } // okei, tein nyt harjoituksena ja muuten vaan kellon tuonne layoutin alle

        private void tsslbAika_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
