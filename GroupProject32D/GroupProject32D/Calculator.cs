using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject32D
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true;


        private void btnZero_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + ",";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 7;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 8;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = resTextBox1.Text + 9;
        }


        private void btnPlusOrMinus_Click(object sender, EventArgs e)
        {

            if (znak == true)
            {
                resTextBox1.Text = "-" + resTextBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                resTextBox1.Text = resTextBox1.Text.Replace("-", "");
                znak = true;
            }
        }


        private void calculate()
        {

            switch (count)
            {
                case 1:
                    b = a + float.Parse(resTextBox1.Text);
                    resTextBox1.Text = b.ToString();
                    break;

                case 2:
                    b = a - float.Parse(resTextBox1.Text);
                    resTextBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(resTextBox1.Text);
                    resTextBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(resTextBox1.Text);
                    resTextBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            a = float.Parse(resTextBox1.Text);
            resTextBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }
        

        private void btnMinus_Click(object sender, EventArgs e)
        {
            a = float.Parse(resTextBox1.Text);
            resTextBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(resTextBox1.Text);
            resTextBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }


        private void btnSplit_Click(object sender, EventArgs e)
        {
            a = float.Parse(resTextBox1.Text);
            resTextBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

       

        private void btnSolve_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
            hisRichTextBox1.AppendText(resTextBox1.Text + "\n");
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            resTextBox1.Text = "";
            label1.Text = "";
            hisRichTextBox1.Clear();
        }

   

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int lenght = resTextBox1.Text.Length - 1;
            string text = resTextBox1.Text;
            resTextBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                resTextBox1.Text = resTextBox1.Text + text[i];
            }

        }












    }
}

