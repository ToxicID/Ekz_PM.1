using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(count == 1)
            {
                f1();
            }
            
        }
        bool flag = false;
        void f1()
        {
            if(!double.TryParse(textBox1.Text,out double x))
            {
                MessageBox.Show("Некорректный ввод данных. Повторите попытку ещё раз.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBox2.Text, out double y))
            {
                MessageBox.Show("Некорректный ввод данных. Повторите попытку ещё раз.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double a, b, c;
            double x1 = 1.0, x2 = 5.0, x3 = -5.0;
            double y1 = 4.0, y2 = -4.0, y3 = -3.0;
            a = (x1 - x) * (y2 - y1) - (x2 - x1) * (y1 - y);
            b = (x2 - x) * (y3 - y2) - (x3 - x2) * (y2 - y);
            c = (x3 - x) * (y1 - y3) - (x1 - x3) * (y3 - y);
            if (a == 0.0 || b == 0.0 || c== 0.0)
            {
                MessageBox.Show("Точка находится на границе треугольника");
                toolStripStatusLabel1.Text = "Точка находится на границе треугольника";
            }
            else if((a >= 0.0 && b >= 0.0 && c >= 0.0) || (a <= 0.0 && b <= 0.0 && c <= 0.0))
            {
                MessageBox.Show("Точка находится внутри треугольника");
                toolStripStatusLabel1.Text = "Точка находится внутри треугольника";
            }
            
            else
            {
                MessageBox.Show("Точка находится вне треугольника");
                toolStripStatusLabel1.Text = "Точка находится вне треугольника";
            }
        }
        
        int count = 0;
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "TextFiles(*.html)|*.html|AllFiles(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                string[] filename = openFileDialog1.FileName.Split('\\');
                string nameFile = filename[filename.Length - 1];
                if (!flag)
                {
                    this.Height += 65;
                    flag = true;
                }
                if(nameFile == "1.html")
                {
                    count = 1;
                    webBrowser1.Navigate(openFileDialog1.FileName);
                }
               
                else
                {
                    count = 0;
                    MessageBox.Show($"Нет решения для {nameFile}. Попробуйте выбрать файл 1.html");
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу создал ученик группы ПКсп-120\nНовожилов Илья Александрович\nВариант 4");
        }
    }
}
