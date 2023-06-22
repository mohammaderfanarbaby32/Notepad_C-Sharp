using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp18
{
    public partial class Form3 : Form
    {
        Boolean save2;
        String fn2;
        String textBox1;
        String lan;
        bool b = false;


        public Form3()
        {
            InitializeComponent();

        }
        public Form3(Boolean save, String fn, String textBox , String q)
        {
            InitializeComponent();
            save2 = save;
            fn2 = fn;
            textBox1 = textBox;
            lan = q;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fn2 == null)
            {
                if (lan == "فارسی")
                {
                    saveFileDialog1.Filter = "ذخیره ی به صورت متن|*.txt";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Title = "ذخیره ی فایل";
                    saveFileDialog1.ShowDialog();
                    fn2 = saveFileDialog1.FileName;
                }
                if (lan == "انگلیسی")
                {
                saveFileDialog1.Filter = "savefile|*.txt";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();
                fn2 = saveFileDialog1.FileName;
                }



            }

            try
            {
                System.IO.File.WriteAllText(fn2, textBox1);
                save2 = true;
                this.Text = fn2;
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
                this.Visible = false;
            }
            catch
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {

            Close();
            b = true;
        }

        private void Save_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (b == true)
            {

                e.Cancel = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Save_Load(object sender, EventArgs e)
        {
        
            if (lan == "فارسی")
            {
                label1.Text = " آیا میخواهید متن نوشته شده ذخیره شود ؟";
                button2.Text = "بله";
                button1.Text = "خیر";
                button3.Text = "بازگشت";

            }
            if (lan == "انگلیسی")
            {
                label1.Text = "Do you want the written text to be Saved ?";
                button2.Text = "Yes";
                button1.Text = "No";
                button3.Text = "return";

            }
        }
    }
}
