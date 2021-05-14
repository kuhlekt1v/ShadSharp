using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhackAMole
{
    public partial class Form1 : Form
    {
        private Stopwatch watch = new Stopwatch();
        private Random rng = new Random();

        private int timerInterval = 1000;

        private int hits = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = timerInterval;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            watch.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            watch.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            watch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = watch.Elapsed.ToString();
            btnTarget.Top = rng.Next(0, this.Height);
            btnTarget.Left = rng.Next(0, this.Width);
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            hits++;
            label2.Text = hits.ToString();
        }
    }
}
