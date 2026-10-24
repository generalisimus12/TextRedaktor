using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextRedaktor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string file_name = "text.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                file_name = openFileDialog1.FileName.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(file_name , textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                file_name = saveFileDialog1.FileName.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.Width < 825)
            {
                this.Width = 825;
            }
            if(this.Height < 500)
            {
                this.Height = 500;
            }
        }
    }
}
