using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form4 : Form
    {
        String a1;
        public Form4()
        {
            InitializeComponent();
           
        }
        public Form4(String a)
        {
            InitializeComponent();
            a1 = a;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (a1 =="فارسی") 
            {
                label1.Text = "سازندگان :";
                label3.Text = "محمد عرفان اربابی";
                label2.Text = "ورژن:";
                label5.Text = "زبان برنامه نویسی"+":";
                label8.Text = "نام برنامه :";
                label9.Text = "نوت پد سی شارپ";
                label3.Location = new System.Drawing.Point(123, 30);
                label4.Location = new System.Drawing.Point(133, 135);
                label6.Location = new System.Drawing.Point(197, 224);
                label9.Location = new System.Drawing.Point(172, 330);

            }
            if (a1 == "انگلیسی")
            {
                label1.Text = "builders :";
                label3.Text = "Mohammad erfan arbaby";
                label2.Text = "Version :";
                label5.Text = "Development Language :";
                label8.Text = "Program Name : ";
                label9.Text = "NotepadC#";

            }
        }
    }
}
