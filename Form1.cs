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


namespace NumbConverter
{
    public partial class Form1 : Form
    {

        private static int RomanToArabic(string roman)
        {           
            int i;
            char ch;
            int result = 0;
            int new_value = 0;
            int old_value = 0;
            roman= roman.ToUpper();

            for (i = 0; (i < roman.Length); i++)
            {
                ch = roman[i];

                switch (ch)
                {
                    case 'I':
                        new_value = 1;
                        break;
                    case 'V':
                        new_value = 5;
                        break;
                    case 'X':
                        new_value = 10;
                        break;
                    case 'L':
                        new_value = 50;
                        break;
                    case 'C':
                        new_value = 100;
                        break;
                    case 'D':
                        new_value = 500;
                        break;
                    case 'M':
                        new_value = 1000;
                        break;
                    default:                      
                        throw new Exception("Введено неправильное значение");
                }

                if (new_value > old_value)
                {
                    result += new_value - 2 * old_value;
                }
                else
                {
                    result += new_value;
                }

                old_value = new_value;               
            }

            return result;
        }

        public static string ArabianToRome(int arabValue)
        {
       
            string result = "";
            int m1 = arabValue / 1000;
            for (int i = 0; i < m1; i++)
            {
                //Console.Write("M");
                result += "M";
            }
            int m2 = arabValue % 1000;
            int d1 = m2 / 500;
            if (m2 >= 900 && m2 < 1000)
            {
                result += "CM";
                m2 -= 900;
            }
            else
            {
                for (int i = 0; i < d1; i++)
                {
                    //Console.Write("D");
                    result += "D";

                }
            }
            int d2 = m2 % 500;
            int c1 = d2 / 100;
            if (c1 == 4)
            {
                result += "CD";

            }
            else
            {
                for (int i = 0; i < c1 && i < 4; i++)
                {
                    //Console.Write("C");
                    result += "C";
                }
            }
            int c2 = d2 % 100;
            int l1 = c2 / 50;
            if (c2 >= 90 && c2 < 100)
            {
                result += "XC";
                c2 -= 90;
            }
            else
            {
                for (int i = 0; i < l1; i++)
                {
                    //Console.Write("L");
                    result += "L";
                }
            }
            int l2 = c2 % 50;
            int x1 = l2 / 10;
            if (x1 == 4)
            {
                result += "XL";

            }
            else
            {
                for (int i = 0; i < x1; i++)
                {
                    //Console.Write("X");
                    result += "X";
                }
            }
            int x2 = l2 % 10;
            int v1 = x2 / 5;
            if (x2 == 9)
            {
                result += "IX";
                x2 -= 9;
            }
            else
            {
                for (int i = 0; i < v1; i++)
                {
                    //Console.Write("V");
                    result += "V";
                }
            }
            int v2 = x2 % 5;
            if (v2 == 4)
            {
                //Console.Write("IV");
                result += "IV";
            }
            else
            {
                for (int i = 0; i < v2; i++)
                {
                    //Console.Write("I");
                    result += "I";
                }
            }

            return result;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
       
        //I = 1; V = 5; X = 10; L = 50; C = 100; D = 500; M = 1000.
      
        private void bRomeConvert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
            }

            try
            {              
                textBox2.Text = ArabianToRome(int.Parse(textBox1.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Введено неправильное значение");
                return;

            } 
        }

        private void bArabConver_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= 100; j++)
            {
                progressBar1.Value = j;
            }

            try
            {
                textBox2.Text = RomanToArabic(textBox1.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }          
        }
    }
}
