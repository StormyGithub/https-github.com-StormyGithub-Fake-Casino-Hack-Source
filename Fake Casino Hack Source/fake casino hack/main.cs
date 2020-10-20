using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this fake casino hack is made by Storm#4684
//if you have any bugs dm Storm#4684!
namespace fake_casino_hack
{
    public partial class main : MetroFramework.Forms.MetroForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 350; //control text speed flashig
            timer2.Start();
            timer2.Interval = 350; //control text speed flashig
            timer3.Interval = 350; //control text speed flashig
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int A = r.Next(0, 255);
            int R = r.Next(0, 255);
            int G = r.Next(0, 255);
            int B = r.Next(0, 255);

            label1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int A = r.Next(0, 255);
            int R = r.Next(0, 255);
            int G = r.Next(0, 255);
            int B = r.Next(0, 255);

            label2.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int A = r.Next(0, 255);
            int R = r.Next(0, 255);
            int G = r.Next(0, 255);
            int B = r.Next(0, 255);

            label3.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            return;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            (metroProgressBar2).Value = (0);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");
            (metroProgressBar2).Value = (100);
            MessageBox.Show("The Growtopia.exe Has Been injected!");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");
            (metroProgressBar1).Value = (100);
            MessageBox.Show("The Casino Hack Has Started!");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");
            (metroProgressBar1).Value = (0);
            MessageBox.Show("The Casino Hack Has Stopped!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
