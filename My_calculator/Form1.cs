using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_calculator
{
    public partial class Form1 : Form
    {
       
        Double num2,n1=0;
        int varn, var2, var3;
        Double value = 0;
        String no1;
        String operation = " ";
        bool operation_pressed = false;
        Boolean nprClicked = false;
        Boolean ncr = false;
        double num1 = 0,num3 =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "1";
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "2";
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
           
            operation_pressed = true;
           equation.Text = value + " " + operation;
           textBox1.Text = " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            equation.Text = " ";
            if (ncr == true)//for combination
            {
                num2 = Convert.ToDouble(textBox1.Text);
                double fact1 = 1, fact2 = 1,fact3=1;
                for (double i = 1; i <= num1; i++)//6
                    fact1 *= i;
                for (double i = 1; i <= (num1 - num2); i++)
                    fact2 *= i;
                for (double i = 1; i <= num2; i++)
                    fact3 *= i;
                double ans = (fact1 /(fact3 * fact2));
                textBox1.Text = ans + "";
                ncr = false;
                return;
            }
            ////////////////////////////
            if(nprClicked==true)//for permutation
            {
               num2=Convert.ToDouble(textBox1.Text);
                double fact1=1,fact2=1;
                for(double i=1;i<=num1;i++)
                    fact1*=i;
                 for(double i=1;i<=(num1-num2);i++)
                    fact2*=i;
                double ans=(fact1/fact2);
                textBox1.Text=ans+"";
                nprClicked = false;
                return;
            }
           
            switch (operation)
            {
                case "+":
                    
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                   // equation.Text = value + " " + operation + value;
                    break;

                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    {
                        if (value == 0)
                        {
                           
                            
                            MessageBox.Show("Enter Valid Number");
                        }
                        else
                        {
                            textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                        }
                        break;
                    }
                case "x^y":
                    textBox1.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(no1), Convert.ToDouble(textBox1.Text))); 
                    break;
                case "%":
                    {
                       
                       

                            textBox1.Text = Convert.ToString(Convert.ToDouble(no1) % Convert.ToDouble(textBox1.Text)); 
                       
                        break;
                    }

                default:
                    textBox1.Text = " 0";
                    break;
                   


            }
        }
        private int factorial(int  x)
        {
            int v = 1;
            int i;
            for ( i = 1; i <=x; i++)
            {
                v = v * i; ;
            }
           
            return i;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
            textBox1.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
            textBox1.Text = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
            textBox1.Text = " ";
            
        }

        private void button25_Click(object sender, EventArgs e)//Sin 
        {
            if (radioButton2.Checked == true)//rad
            {
                
                
                value = System.Math.Sin(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(value);
                
                
            }
            else if (radioButton1.Checked == true)//deg
            {
                equation.Text = value + " " + operation;
                textBox1.Text = " ";
                textBox1.Text = (System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text)))).ToString();
            }
            else
                MessageBox.Show("Select Ans In (Radain Or Degree) And Try Later");
        }

        private void button19_Click(object sender, EventArgs e)
        {
           
            value = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(value);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            value = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(value);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            value = System.Math.Log(Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(value);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            value = Convert.ToDouble(1.0 / System.Math.Cos(Convert.ToDouble(textBox1.Text)));
            textBox1.Text = Convert.ToString(value); 

        }

        private void button21_Click(object sender, EventArgs e)
        {
             value = System.Math.Sqrt(Convert.ToDouble(textBox1.Text));
            textBox1.Text=Convert.ToString(value);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            no1 = textBox1.Text;
            textBox1.Text = ""; 
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;

            no1 = textBox1.Text;
            textBox1.Text = "";
            
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int var=1;
            for (int i = 1; i <= Convert.ToInt16(textBox1.Text); i++)
            {
                var = i * var;
            }
            textBox1.Text = Convert.ToString(var);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            value = System.Math.Exp(Convert.ToDouble(textBox1.Text));
            textBox1.Text=Convert.ToString(value);
        }

        private void button27_Click(object sender, EventArgs e)//tan
        {
            if (radioButton2.Checked == true)//radien
            {

                value = System.Math.Tan(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(value);
            }
            else
            {
                textBox1.Text = (System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text)))).ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)//cos
        {
            if (radioButton2.Checked == true)//radien
            {

                value = System.Math.Cos(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(value);
            }
            else if(radioButton2.Checked==true)//degree
            {
                textBox1.Text = (System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text)))).ToString();
            }
            else
                MessageBox.Show("Select Ans In (Radain Or Degree) And Try Later");
           
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)//radian
            {

                value = System.Math.Tanh(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(value);
            }
            else if(radioButton1.Checked==true)//degree
            {
                textBox1.Text = (System.Math.Tanh((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text)))).ToString();
            }
            else
                MessageBox.Show("Select Ans In (Radain Or Degree) And Try Later");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)//degree
            {

                value = System.Math.Cosh(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(value);
            }
            else
            {
                textBox1.Text = (System.Math.Cosh((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text)))).ToString();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)//d
            {

                value = System.Math.Sinh(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(value);
            }
            else
            {
                textBox1.Text = (System.Math.Sinh((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text)))).ToString();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14159 ";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            value = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(value);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            value = Convert.ToDouble(1.0 / System.Math.Sin(Convert.ToDouble(textBox1.Text)));
            textBox1.Text = Convert.ToString(value); 
        }

        private void button37_Click(object sender, EventArgs e)
        {
            value = Convert.ToDouble(1.0 / System.Math.Tan(Convert.ToDouble(textBox1.Text)));
            textBox1.Text = Convert.ToString(value); 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {


                String no1 = textBox1.Text;
                int n = no1.Length;
                textBox1.Text = (no1.Substring(0, n - 1));
            }
            else
            {
               
                MessageBox.Show("No Value For Deletion");
            }
           
        }

        private void equation_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1.Text))); 
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + "-";

        }

        private void button41_Click(object sender, EventArgs e)////permutation 
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
           
            nprClicked = true;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            value = System.Math.Round(Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(value); 
        }

        private void button42_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            ncr = true;
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/pages/Java-Projects/528280973960603");
        }

        private void button44_Click(object sender, EventArgs e)
        {
           double[] ar =new double[20];
           int count=0;
           String bin="";
           n1 = Convert.ToDouble(textBox1.Text);
          while(n1>=1){
            ar[count]=n1%2;
          n1/=2;
        count++;
         }
           for(int i=count-1;i>=0;i--)
            bin+=i;
           textBox1.Text = bin;
           
        }
    }
}
