using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroupProject32D

{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        int Dollar = 74;
        int Euro = 88;
        int Frank = 79;
        int Funt = 102;
        int Chinese = 11;
        int Shekel = 22;
        int Rupii = 1;
        int Lira = 8;
        int Krone = 8;
        int byRub = 28;
        int AuDlr = 57;
        int Zloty = 19;
        int CZcrone = 3;
        int Real = 13;

        int x;
        int z;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            //wallet
            if (this.radioButton1.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Dollar * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton2.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Euro * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton3.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Frank * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton4.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Funt * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton5.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Chinese * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton6.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Shekel * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton7.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Rupii * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton8.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Lira * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton9.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Krone * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton10.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = byRub * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton11.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = AuDlr * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton12.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Zloty * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton13.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = CZcrone * x;
                textBox2.Text = z.ToString();
            }
            else if (this.radioButton14.Checked)
            {
                x = Convert.ToInt32(textBox1.Text);
                z = Real * x;
                textBox2.Text = z.ToString();
            }

        }


        /////////////////////////////////////////////SECOND_CONVENTER////////////////////////////////////////////////////////////

        //Не удалять
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        string metr;
        string mile;
        string yard;
        string fot;

  

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*
            string userName = textBox3.Text;
            label4.Text = userName;
            */



            switch (comboBox1.SelectedItem.ToString().Trim())
            {
                case "Метр":
                    metr = textBox3.Text;
                    double metr1 = double.Parse(metr);
                    metr1 *= 1;
                    double metr2 = metr1;
                    string res = metr1.ToString();
                    label7.Text = res;

                    mile = textBox3.Text;
                    double mile1 = double.Parse(mile);
                    mile1 = metr2 / 1609;
                    string res1 = mile1.ToString();
                    label8.Text = res1;

                    yard = textBox3.Text;
                    double yard1 = double.Parse(yard);
                    yard1 = metr2 * 1.094;
                    string res2 = yard1.ToString();
                    label9.Text = res2;


                    fot = textBox3.Text;
                    double fot1 = double.Parse(fot);
                    fot1 = metr2 * 3.281;
                    string res3 = fot1.ToString();
                    label10.Text = res3;
                    break;


                case "Миля":
                    //-----------------MILE----------------//

                    mile = textBox3.Text;
                    double mileTwo1 = double.Parse(mile);
                    mileTwo1 *= 1;
                    double mileTwo2 = mileTwo1;
                    string resTwo1 = mileTwo1.ToString();
                    label8.Text = resTwo1;
                    //----------------EndSelection--------//

                    //-----FirstElement
                    metr = textBox3.Text;
                    double metrTwo1 = double.Parse(metr);
                    metrTwo1 = mileTwo2 * 1609;
                    string resTwo = metrTwo1.ToString();
                    label7.Text = resTwo;

                    yard = textBox3.Text;
                    double yardTwo1 = double.Parse(yard);
                    yardTwo1 = mileTwo2 * 1760;
                    string resTwo2 = yardTwo1.ToString();
                    label9.Text = resTwo2;


                    fot = textBox3.Text;
                    double fotTwo1 = double.Parse(fot);
                    fotTwo1 = mileTwo2 * 5280;
                    string resTwo3 = fotTwo1.ToString();
                    label10.Text = resTwo3; ;
                    break;



                case "Ярд":
                    //-----------------YARD----------------//

                    yard = textBox3.Text;
                    double yardThree1 = double.Parse(yard);
                    yardThree1 *= 1;
                    double yardThree2 = yardThree1;
                    string resThree2 = yardThree1.ToString();
                    label9.Text = resThree2;

                    //----------------EndSelection--------//

                    //-----FirstElement
                    metr = textBox3.Text;
                    double metrThree1 = double.Parse(metr);
                    metrThree1 = yardThree2 / 1.094;
                    string resThree = metrThree1.ToString();
                    label7.Text = resThree;

                    mile = textBox3.Text;
                    double mileThree1 = double.Parse(mile);
                    mileThree1 = yardThree2 / 1760;
                    string resThree1 = mileThree1.ToString();
                    label8.Text = resThree1;

                    fot = textBox3.Text;
                    double fotThree1 = double.Parse(fot);
                    fotThree1 = yardThree2 * 3;
                    string resThree3 = fotThree1.ToString();
                    label10.Text = resThree3;
                    break;



                case "Фут":
                    //-----------------fot----------------//

                    fot = textBox3.Text;
                    double fotFour1 = double.Parse(fot);
                    fotFour1 *= 1;
                    double fotFour2 = fotFour1;
                    string resFour3 = fotFour1.ToString();
                    label10.Text = resFour3;

                    //----------------EndSelection--------//

                    //-----FirstElement
                    metr = textBox3.Text;
                    double metrFour1 = double.Parse(metr);
                    metrFour1 = fotFour2 / 3.281;
                    string resFour = metrFour1.ToString();
                    label7.Text = resFour;

                    mile = textBox3.Text;
                    double mileFour1 = double.Parse(mile);
                    mileFour1 = fotFour2 / 5280;
                    string resFour1 = mileFour1.ToString();
                    label8.Text = resFour1;

                    yard = textBox3.Text;
                    double yardFour1 = double.Parse(yard);
                    yardFour1 = fotFour2 / 3;
                    double yardFour2 = yardFour1;
                    string resFour2 = yardFour1.ToString();
                    label9.Text = resFour2;
                       break;
            }

        }
        /////////////////////////////////////////////THIRD_CONVENTER////////////////////////////////////////////////////////////
        private void button3_Click(object sender, EventArgs e)
        {

            string kilogramm;
            string tonna;
            string funt;
            string uncii;



            switch (comboBox2.SelectedItem.ToString().Trim())
            {
                case "Килограмм":
                    kilogramm = textBox4.Text;
                    double kilogramm1 = double.Parse(kilogramm);
                    kilogramm1 *= 1;
                    double kilogramm2 = kilogramm1;
                    string res = kilogramm1.ToString();
                    label15.Text = res;

                    tonna = textBox4.Text;
                    double tonna1 = double.Parse(tonna);
                    tonna1 = kilogramm2 / 1000;
                    string res1 = tonna1.ToString();
                    label16.Text = res1;

                    funt = textBox4.Text;
                    double funt1 = double.Parse(funt);
                    funt1 = kilogramm2 * 2.205;
                    string res2 = funt1.ToString();
                    label17.Text = res2;


                    uncii = textBox4.Text;
                    double uncii1 = double.Parse(uncii);
                    uncii1 = kilogramm2 * 35.274;
                    string res3 = uncii1.ToString();
                    label18.Text = res3;
                        break;


                case "Тонна":
                    tonna = textBox4.Text;
                    double tonnaTwo1 = double.Parse(tonna);
                    tonnaTwo1 *= 1;
                    double tonnaTwo2 = tonnaTwo1; 
                    string resTwo1 = tonnaTwo1.ToString();
                    label16.Text = resTwo1;

                    //---------------------------
                    
                    kilogramm = textBox4.Text;
                    double kilogrammTwo1 = double.Parse(kilogramm);
                    kilogrammTwo1 = tonnaTwo2 * 1000;
                    string resTwo = kilogrammTwo1.ToString();
                    label15.Text = resTwo;

                    

                    funt = textBox4.Text;
                    double funtTwo1 = double.Parse(funt);
                    funtTwo1 = tonnaTwo2 * 2205;
                    string resTwo2 = funtTwo1.ToString();
                    label17.Text = resTwo2;


                    uncii = textBox4.Text;
                    double unciiTwo1 = double.Parse(uncii);
                    unciiTwo1 = tonnaTwo2 * 35274;
                    string resTwo3 = unciiTwo1.ToString();
                    label18.Text = resTwo3;
                    break;


                case "Фунт":

                    funt = textBox4.Text;
                    double funtThree1 = double.Parse(funt);
                    funtThree1 *= 1;
                    double funtThree2 = funtThree1;
                    string resThree2 = funtThree1.ToString();
                    label17.Text = resThree2;

                    //---------------------------

                    kilogramm = textBox4.Text;
                    double kilogrammThree1 = double.Parse(kilogramm);
                    kilogrammThree1 = funtThree2 / 2.205;
                    string resThree = kilogrammThree1.ToString();
                    label15.Text = resThree;

                    tonna = textBox4.Text;
                    double tonnaThree1 = double.Parse(tonna);
                    tonnaThree1 = funtThree2 / 2205;
                    string resThree1 = tonnaThree1.ToString();
                    label16.Text = resThree1;

                    uncii = textBox4.Text;
                    double unciiThree1 = double.Parse(uncii);
                    unciiThree1 = funtThree2 * 16;
                    string resTree3 = unciiThree1.ToString();
                    label18.Text = resTree3;
                    break;



                case "Унция":

                    uncii = textBox4.Text;
                    double unciiFour1 = double.Parse(uncii);
                    unciiFour1 *= 1;
                    double unciiFour2 = unciiFour1;
                    string resFour3 = unciiFour1.ToString();
                    label18.Text = resFour3;

                    //---------------------------

                    kilogramm = textBox4.Text;
                    double kilogrammFour1 = double.Parse(kilogramm);
                    kilogrammFour1 = unciiFour2 / 35.274;
                    string resFour = kilogrammFour1.ToString();
                    label15.Text = resFour;

                    tonna = textBox4.Text;
                    double tonnaFour1 = double.Parse(tonna);
                    tonnaFour1 = unciiFour2 / 35274;
                    string resFour1 = tonnaFour1.ToString();
                    label16.Text = resFour1;

                    funt = textBox4.Text;
                    double funtFour1 = double.Parse(funt);
                    funtFour1 = unciiFour2 / 16;
                    string resFour2 = funtFour1.ToString();
                    label17.Text = resFour2;
                        break;
                    

            }
        }
    }
}