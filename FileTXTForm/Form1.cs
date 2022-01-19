using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileTXTForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void FileOutput()
        {
            FileInfo fileF = new FileInfo(@"f.txt");
            string path = @"D:\KPYP_LECTION\KPYP_LECTION\FileTXTForm\f.txt";
            FileInfo fileinfo = new FileInfo(path);
            if (fileinfo.Exists)
            {
                StreamReader sr = new StreamReader(@"f.txt");
                string line;
                using (StreamWriter sw = new StreamWriter("g.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("Данного файла не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string FileReturn()
        {
            using (FileStream fstream = File.OpenRead(@"f.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.UTF8.GetString(array);
                return textFromFile;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileOutput();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(FileReturn());
        }
    }
}
