using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int sayac = 0;
        int a = 0;
       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 1000;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (a==3)
            {
                a = 0;
            }

            
                a++;
                sayac = 0;
                timer1.Enabled = true;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = false;


            if (comboBox1.Text == "Ürün A")
            {


                if (a == 1)
                {
                    listBox2.Items.Add(sayac + " Sn");
                    listBox5.Items.Add("-");
                    listBox8.Items.Add("-");
                }

                else if (a == 2)
                {
                    listBox3.Items.Add(sayac + " Sn");
                    listBox6.Items.Add("-");
                    listBox9.Items.Add("-");
                }

                else if (a == 3)
                {
                    listBox4.Items.Add(sayac + " Sn");
                    listBox7.Items.Add("-");
                    listBox10.Items.Add("-");
                }
            }

            else if (comboBox1.Text == "Ürün B")
            {

                if (a == 1)
                {
                    listBox5.Items.Add(sayac + " Sn");
                    listBox2.Items.Add("-");
                    listBox8.Items.Add("-");
                }

                else if (a == 2)
                {
                    listBox6.Items.Add(sayac + " Sn");
                    listBox3.Items.Add("-");
                    listBox9.Items.Add("-");
                }

                else if (a == 3)
                {
                    listBox7.Items.Add(sayac + " Sn");
                    listBox4.Items.Add("-");
                    listBox10.Items.Add("-");
                }
            }

            else if (comboBox1.Text == "Ürün C")
            {


                if (a == 1)
                {
                    listBox8.Items.Add(sayac + " Sn");
                    listBox2.Items.Add("-");
                    listBox5.Items.Add("-");
                }

                else if (a == 2)
                {
                    listBox9.Items.Add(sayac + " Sn");
                    listBox3.Items.Add("-");
                    listBox6.Items.Add("-");
                }

                else if (a == 3)
                {
                    listBox10.Items.Add(sayac + " Sn");
                    listBox4.Items.Add("-");
                    listBox7.Items.Add("-");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (a==1)
            {
                sayac++;
                textBox1.Text = sayac.ToString();
            }

           else if (a == 2)
            {
                sayac++;
                textBox2.Text = sayac.ToString();
            }

            else if (a == 3)
            {
                sayac++;
                textBox3.Text = sayac.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            
        }
    }
}
