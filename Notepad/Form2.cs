using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp18
{
    public partial class Form2 : Form
    {
        int a = 1;
        Boolean b;

        public Form2()
        {

            InitializeComponent();

        }
        public Form2(Boolean a)
        {

            InitializeComponent();
            b = a;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 99)
            {
                progressBar1.Value += a;

            }
            else
            {
                if (b == true) { Application.ExitThread(); }
                this.Visible = false;

                timer1.Stop();
                timer2.Stop();
                a = 0;

            }





        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Saveing.Text += ".";
            if (Saveing.Text == "Saveing......")
            {

                Saveing.Text = "Saveing";

            }
        }


    }
}
