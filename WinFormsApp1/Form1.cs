using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPPGParserScanner;
using SimplePascalParser;
using PascalABCCompiler.SimplePascalParser;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string filename="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "PASCAL programm(*.pas)|*.pas" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                filename = openFileDialog1.FileName;
                label2.Text = filename;

            }
                

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filename == "") 
            {
                MessageBox.Show(
            "Не выбран файл программы",
            "Ошибка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            GPPGParser parse = PascalABCCompiler.SimplePascalParser.SimplePascalLanguageParser.parse(filename);
            PrintNode(parse.root)
        }
    }
}
