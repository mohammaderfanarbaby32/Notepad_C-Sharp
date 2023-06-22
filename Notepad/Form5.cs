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
namespace WindowsFormsApp18
{
    public partial class Form5 : Form
    { String a;
      String b;
      bool b1=true;

        public Form5(bool a)
        {
            InitializeComponent();

            a=b1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer", "");
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (a != b)
            {
                e.Cancel = true;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            b1 = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
