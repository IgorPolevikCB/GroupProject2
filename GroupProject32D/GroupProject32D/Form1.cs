using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GroupProject32D
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);

        }

        void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;

        }

        [STAThread]
        private void времяИДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("HH:mm dd.MM.yyyy");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.Show(this);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*
            SearchForm f = new SearchForm();
            Show(this);
            SearchForm f1 = new SearchForm(textBox1.Text);
            

            SearchForm f = new SearchForm();
            f.Show(this);
            */
            Regex reg = new Regex(findTextBox.Text);
            MatchCollection math = reg.Matches(textBox1.Text);
            MessageBox.Show("Найдено совпадений: " + math.Count);


        }

        void toolStripTextBoxColor_LostFocus(object sender, EventArgs e)
        {

            try
            {

                BackColor = Color.FromName(findTextBox.Text);

            }
            catch { } // Просто игнорировать неправильные данные.

        }
        public void find()
        {
            
            int idx = 0;
            while ((idx = textBox1.Text.IndexOf(Text)) != 1)
            {
                textBox1.Select(idx, Text.Length);

            }

        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Show(this);
        }

        private void конвентерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Converter Romanenko = new Converter();
            Romanenko.Show(this);
        }
    }
}
