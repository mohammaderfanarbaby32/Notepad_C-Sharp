using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp18;
using System.IO;


namespace Form1
{

    public partial class Form1 : Form
    {

        int a = 0;
        int b = 0;
        String s;
        String s1;
        String fn;
        String textBox;
        Boolean save;
        Boolean B;
        String Lan="";
        String password = "";
        String masir = "";
        String matn = "";
        Boolean B1;
        public Form1()
        {
            InitializeComponent();
        }


        private void white_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            a = 1; backColor();
        }

        private void red_Click(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.Red;
            a = 2; backColor();
        }

        private void blue_Click(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.Blue;
            a = 3; backColor();
        }

        private void green_Click(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.Green;
            a = 4; backColor();
        }

        private void yellow_Click(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.Yellow;
            a = 5; backColor();
        }

        private void orange_Click(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.Orange;
            a = 6; backColor();
        }

        private void black_Click(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.Black;
            a = 7; backColor();
        }



        public void backColor()
        {



            if (a == 1)
            {
                white.Checked = true;
                redToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = false;
                greenToolStripMenuItem.Checked = false;
                yellowToolStripMenuItem.Checked = false;
                Black.Checked = false;
                orangeToolStripMenuItem.Checked = false;
            }
            else if (a == 2)
            {
                white.Checked = false;
                redToolStripMenuItem.Checked = true;
                blueToolStripMenuItem.Checked = false;
                greenToolStripMenuItem.Checked = false;
                yellowToolStripMenuItem.Checked = false;
                Black.Checked = false;
                orangeToolStripMenuItem.Checked = false;
            }
            else if (a == 3)
            {
                white.Checked = false;
                redToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = true;
                greenToolStripMenuItem.Checked = false;
                yellowToolStripMenuItem.Checked = false;
                Black.Checked = false;
                orangeToolStripMenuItem.Checked = false;
            }
            else if (a == 4)
            {
                white.Checked = false;
                redToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = false;
                greenToolStripMenuItem.Checked = true;
                yellowToolStripMenuItem.Checked = false;
                orangeToolStripMenuItem.Checked = false;
                Black.Checked = false;
            }
            else if (a == 5)
            {
                white.Checked = false;
                redToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = false;
                greenToolStripMenuItem.Checked = false;
                yellowToolStripMenuItem.Checked = true;
                orangeToolStripMenuItem.Checked = false;
                Black.Checked = false;
            }
            else if (a == 6)
            {
                white.Checked = false;
                redToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = false;
                greenToolStripMenuItem.Checked = false;
                yellowToolStripMenuItem.Checked = false;
                orangeToolStripMenuItem.Checked = true;
                Black.Checked = false;
            }
            else if (a == 7)
            {
                white.Checked = false;
                redToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = false;
                greenToolStripMenuItem.Checked = false;
                yellowToolStripMenuItem.Checked = false;
                orangeToolStripMenuItem.Checked = false;
                Black.Checked = true;
            }
            else if (a == 8)
            {
                white.Checked = false;
                redToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = false;
                greenToolStripMenuItem.Checked = false;
                yellowToolStripMenuItem.Checked = false;
                orangeToolStripMenuItem.Checked = false;
                Black.Checked = false;
            }

        }

        public void foreColor()
        {
            if (b == 1)
            {
                Black.Checked = true;
                whatToolStripMenuItem.Checked = false;
                gleerToolStripMenuItem.Checked = false;
                yeToolStripMenuItem.Checked = false;
                redToolStripMenuItem1.Checked = false;
                blueToolStripMenuItem1.Checked = false;
                goldToolStripMenuItem.Checked = false;

            }
            else if (b == 2)
            {
                Black.Checked = false;
                whatToolStripMenuItem.Checked = true;
                gleerToolStripMenuItem.Checked = false;
                yeToolStripMenuItem.Checked = false;
                redToolStripMenuItem1.Checked = false;
                blueToolStripMenuItem1.Checked = false;
                goldToolStripMenuItem.Checked = false;
            }
            else if (b == 3)
            {
                Black.Checked = false;
                whatToolStripMenuItem.Checked = false;
                gleerToolStripMenuItem.Checked = true;
                yeToolStripMenuItem.Checked = false;
                redToolStripMenuItem1.Checked = false;
                blueToolStripMenuItem1.Checked = false;
                goldToolStripMenuItem.Checked = false;
            }
            else if (b == 4)
            {
                Black.Checked = false;
                whatToolStripMenuItem.Checked = false;
                gleerToolStripMenuItem.Checked = false;
                yeToolStripMenuItem.Checked = true;
                redToolStripMenuItem1.Checked = false;
                blueToolStripMenuItem1.Checked = false;
                goldToolStripMenuItem.Checked = false;
            }
            else if (b == 5)
            {
                Black.Checked = false;
                whatToolStripMenuItem.Checked = false;
                gleerToolStripMenuItem.Checked = false;
                yeToolStripMenuItem.Checked = false;
                redToolStripMenuItem1.Checked = true;
                blueToolStripMenuItem1.Checked = false;
                goldToolStripMenuItem.Checked = false;
            }
            else if (b == 6)
            {
                Black.Checked = false;
                whatToolStripMenuItem.Checked = false;
                gleerToolStripMenuItem.Checked = false;
                yeToolStripMenuItem.Checked = false;
                redToolStripMenuItem1.Checked = false;
                blueToolStripMenuItem1.Checked = true;
                goldToolStripMenuItem.Checked = false;
            }
            else if (b == 7)
            {
                Black.Checked = false;
                whatToolStripMenuItem.Checked = false;
                gleerToolStripMenuItem.Checked = false;
                yeToolStripMenuItem.Checked = false;
                redToolStripMenuItem1.Checked = false;
                blueToolStripMenuItem1.Checked = false;
                goldToolStripMenuItem.Checked = true;
            }
            else if (b == 8)
            {
                Black.Checked = false;
                whatToolStripMenuItem.Checked = false;
                gleerToolStripMenuItem.Checked = false;
                yeToolStripMenuItem.Checked = false;
                redToolStripMenuItem1.Checked = false;
                blueToolStripMenuItem1.Checked = false;
                goldToolStripMenuItem.Checked = false;
            }
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.ForeColor = Color.Black;
            b = 1; foreColor();
        }

        private void whatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.ForeColor = Color.White;
            b = 2; foreColor();
        }

        private void gleerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.ForeColor = Color.Green;
            b = 3; foreColor();
        }

        private void yeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.ForeColor = Color.Yellow;
            b = 4; foreColor();
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
            b = 5; foreColor();
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
            b = 6; foreColor();
        }

        private void goldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gold;
            b = 7; foreColor();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked == true) { statusStrip1.Visible = true; }
            else if (statusBarToolStripMenuItem.Checked == false) { statusStrip1.Visible = false; }
        }



        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox = textBox1.Text;
            System.IO.File.WriteAllText("NotepadB.dll", textBox1.BackColor.Name);
            System.IO.File.WriteAllText("NotepadF.dll", textBox1.ForeColor.Name);
            System.IO.File.WriteAllText("NotepadF.dll", textBox1.ForeColor.Name);
            System.IO.File.WriteAllText("زبان.dll", Lan);
            backColor();


            Form3 form3 = new Form3(save, fn, textBox1.Text,Lan);
            form3.ShowDialog();
            e.Cancel = true;
            Form2 form2 = new Form2(B);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (System.IO.File.Exists("NotepadB.dll") == true)
            {
                s = System.IO.File.ReadAllText("NotepadB.dll");
                textBox1.BackColor = Color.FromName(s);

            }
            if (System.IO.File.Exists("NotepadF.dll") == true)
            {
                s1 = System.IO.File.ReadAllText("NotepadF.dll");

                textBox1.ForeColor = Color.FromName(s1);

            }
            if (System.IO.File.Exists("Notepada.txt") == true)
            {
                a = Convert.ToInt32(System.IO.File.ReadAllText("Notepada.txt"));
                backColor();


            }
            if (System.IO.File.Exists("Notepadb.txt") == true)
            {
                b = Convert.ToInt32(System.IO.File.ReadAllText("Notepadb.txt"));
                foreColor();


            }
            if (System.IO.File.Exists("زبان.dll") == true)
            {
                Lan = System.IO.File.ReadAllText("زبان.dll");
            }
            if (Lan == "فارسی")
            {
                فارسی();
            }
            if (Lan == "انگلیسی")
            {
                انگلیسی();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lan == "فارسی")
            {
                saveFileDialog1.Filter = "ذخیره به صورت متن|*.txt";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Title = "ذخیره فایل";
                saveFileDialog1.ShowDialog();
                fn = saveFileDialog1.FileName;
            }
            if (Lan == "انگلیسی")
            {
                saveFileDialog1.Filter = "Save Text|*.txt";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();
                fn = saveFileDialog1.FileName;
            }

            try
            {
                System.IO.File.WriteAllText(fn, textBox1.Text); save = true;
                this.Text = fn;
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            catch { SaveFileDialog saveFileDialog1 = new SaveFileDialog(); }
            try
            {
                if (Lan == "فارسی")
                {
                openFileDialog1.Filter = "فایل متنی|*.txt";
                saveFileDialog1.Title = "باز کردن فایل";
                openFileDialog1.ShowDialog();
                Stream fs = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(fs);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
                }
                if (Lan == "انگلیسی")
                {
                    openFileDialog1.Filter = "Text File|*.txt";
                    saveFileDialog1.Title = "Open File";
                    openFileDialog1.ShowDialog();
                    Stream fs = openFileDialog1.OpenFile();
                    StreamReader reader = new StreamReader(fs);
                    textBox1.Text = reader.ReadToEnd();
                    reader.Close();
                }

            }
            catch
            {

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

                if (Lan == "فارسی")
                {
                    saveFileDialog1.Filter = "ذخیره به صورت متن|*.txt";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Title = "ذخیره فایل";
                    saveFileDialog1.ShowDialog();
                    fn = saveFileDialog1.FileName;
                }
                if (Lan == "انگلیسی")
                {
                    saveFileDialog1.Filter = "Save Text|*.txt";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Title = "Save File";
                    saveFileDialog1.ShowDialog();
                    fn = saveFileDialog1.FileName;
                }

            try { System.IO.File.WriteAllText(fn, textBox1.Text); save = true;
                this.Text = fn;
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            catch { SaveFileDialog saveFileDialog1 = new SaveFileDialog(); }








        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveAndCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

                if (Lan == "انگلیسی")
                {
                saveFileDialog1.Filter = "Text save|*.txt";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();
                fn = saveFileDialog1.FileName;
                }
                if (Lan == "فارسی")
                {
                    saveFileDialog1.Filter = "ذخیره به صورت متن|*.txt";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Title = "ذخیره ی فایل";
                    saveFileDialog1.ShowDialog();
                    fn = saveFileDialog1.FileName;
                }



            try
            {
                System.IO.File.WriteAllText(fn, textBox1.Text); save = true;
                this.Text = fn;
                Form2 frm2 = new Form2();
                frm2.ShowDialog(); Application.ExitThread();
            }
            catch { SaveFileDialog saveFileDialog1 = new SaveFileDialog(); }

                B = false;


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }



        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void redoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void erorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDialog1.AllowPrintToFile = true;
        }



        private void فارسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
              فارسی();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

              انگلیسی();
        }
    
        public void فارسی()
        {
            Lan = "فارسی";
            englishToolStripMenuItem.Checked = false;
            فارسیToolStripMenuItem.Checked = true;
            عربیToolStripMenuItem.Checked = false;
            menuStrip1.RightToLeft = RightToLeft.Yes;
            fileToolStripMenuItem.Text = "فایل";
            editToolStripMenuItem.Text = "ویرایش";
            formatToolStripMenuItem.Text = "فرمت";
            helpToolStripMenuItem.Text = "کمک";
            viweToolStripMenuItem.Text = "ویو";
            newToolStripMenuItem.Text = "سند جدید";
            openToolStripMenuItem.Text = "باز کردن سند";
            saveToolStripMenuItem.Text = "ذخیره";
            saveAndCloseToolStripMenuItem.Text = "ذخیره و خروج";
            printToolStripMenuItem.Text = "چاپ کردن";
            exitToolStripMenuItem.Text = "خروج";
            undoToolStripMenuItem.Text = "عقب رفتن";
            redoToolStripMenuItem.Text = "جلو رفتن";
            cutToolStripMenuItem.Text = "برش";
            copyToolStripMenuItem.Text = "کپی";
            pasteToolStripMenuItem.Text = "جای گذاری";
            selectAllToolStripMenuItem.Text = "انتخاب همه";
            fontToolStripMenuItem.Text = "نوع قلم";
            backColorToolStripMenuItem.Text = "رنگ پس زمینه";
            freToolStripMenuItem.Text = "رنگ قلم";
            langoigToolStripMenuItem.Text = "زبان";
            white.Text = "سفید";
            redToolStripMenuItem.Text = "قرمز";
            orangeToolStripMenuItem.Text = "نارنجی";
            greenToolStripMenuItem.Text = "سبز";
            yellowToolStripMenuItem.Text = "زرد";
            blueToolStripMenuItem.Text = "آبی";
            Black.Text = "سیاه";
            detailToolStripMenuItem.Text = "جزیات";
            //////////////////////////////////////فور کالر
            blackToolStripMenuItem1.Text = "سیاه";
            whatToolStripMenuItem.Text = "سفید";
            redToolStripMenuItem1.Text = "قرمز";
            blueToolStripMenuItem1.Text = "آبی";
            goldToolStripMenuItem.Text = "طلایی";
            gleerToolStripMenuItem.Text = "سبز";
            yeToolStripMenuItem.Text = "زرد";
            orengToolStripMenuItem1.Text = "نارنجی";
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(20)));

            this.textBox1.TextAlign = HorizontalAlignment.Right;
        }
        public void انگلیسی()
        {
            Lan = "انگلیسی";
            englishToolStripMenuItem.Checked = true;
            فارسیToolStripMenuItem.Checked = false;
            عربیToolStripMenuItem.Checked = false;
            fileToolStripMenuItem.Text = "File";
            editToolStripMenuItem.Text = "Edit";
            formatToolStripMenuItem.Text = "Format";
            helpToolStripMenuItem.Text = "Help";
            viweToolStripMenuItem.Text = "Veiw";
            newToolStripMenuItem.Text = "New";
            openToolStripMenuItem.Text = "Open";
            saveToolStripMenuItem.Text = "Save";
            saveAndCloseToolStripMenuItem.Text = "Save And Close";
            printToolStripMenuItem.Text = "Print";
            exitToolStripMenuItem.Text = "Exit";
            undoToolStripMenuItem.Text = "Undo";
            redoToolStripMenuItem.Text = "Redo";
            cutToolStripMenuItem.Text = "Cut";
            copyToolStripMenuItem.Text = "Cope";
            pasteToolStripMenuItem.Text = "Paste";
            selectAllToolStripMenuItem.Text = "Select All";
            fontToolStripMenuItem.Text = "Font...";
            backColorToolStripMenuItem.Text = "Back Color";
            freToolStripMenuItem.Text = "Fore Color";
            langoigToolStripMenuItem.Text = "Language";
            white.Text = "White";
            redToolStripMenuItem.Text = "Red";
            orangeToolStripMenuItem.Text = "Orenge";
            greenToolStripMenuItem.Text = "Green";
            yellowToolStripMenuItem.Text = "Yelow";
            blueToolStripMenuItem.Text = "Blue";
            Black.Text = "Black";
            detailToolStripMenuItem.Text = "detail";
            //////////////////////////////////////فور کالر
            blackToolStripMenuItem1.Text = "Black";
            whatToolStripMenuItem.Text = "White";
            redToolStripMenuItem1.Text = "Red";
            blueToolStripMenuItem1.Text = "Blue";
            goldToolStripMenuItem.Text = "Gold";
            gleerToolStripMenuItem.Text = "Green";
            yeToolStripMenuItem.Text = "Yelow";
            orengToolStripMenuItem1.Text = "Orenge";
            this.textBox1.TextAlign = HorizontalAlignment.Left;
            menuStrip1.RightToLeft = RightToLeft.No;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(20)));
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 =new Form4(Lan);
            frm4.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            matn = textBox1.Text;
            Form5 form5 = new Form5(B1);
            form5.ShowDialog();
            if (B1)
            {
               if (Lan == "فارسی")
                {
                    saveFileDialog1.Filter = "ذخیره به صورت متن|*.txt";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Title = "ذخیره فایل";
                    saveFileDialog1.ShowDialog();
                    fn = saveFileDialog1.FileName;
                }
                if (Lan == "انگلیسی")
                {
                    saveFileDialog1.Filter = "Save Text|*.txt";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Title = "Save File";
                    saveFileDialog1.ShowDialog();
                    fn = saveFileDialog1.FileName;
                }
            try
            {

                System.IO.File.WriteAllText(fn, textBox1.Text); save = true;
                this.Text = fn;
                Form2 frm2 = new Form2();
                frm2.ShowDialog();



            }
            catch { SaveFileDialog saveFileDialog1 = new SaveFileDialog(); }
            }




        }
    }
}



