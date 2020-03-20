using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incerc7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float ra, rb, rc, rd, re, rf, red, eg, r, u2;
                float i, i2;
                ra = float.Parse(textBox1.Text);
                rb = float.Parse(textBox2.Text);
                rc = float.Parse(textBox3.Text);
                rd = float.Parse(textBox4.Text);
                re = float.Parse(textBox5.Text);
                eg = float.Parse(textBox8.Text);
                r = float.Parse(textBox9.Text);
                red = (rb + rc) * (rd + re) / (ra + rb + rc + rd) + ra;
                textBox6.Text = Convert.ToString(re);
                i = eg / (red + r);
                float rapi1i2 = (rb + rc) / (rd + re);

                textBox7.Text = Convert.ToString(i);
                i2 = i / (1 + rapi1i2);
                textBox10.Text = Convert.ToString(i2);
                u2 = i2 * red;
                textBox11.Text = Convert.ToString(u2);
            }
            catch
            {
                MessageBox.Show("Introduceti datele!");
            }
            /*
            float ra,rb,rc,rd,re,rf,red,eg,r,u2;
            float i, i2;
           
            ra = float.Parse(textBox1.Text);
            rb = float.Parse(textBox2.Text);
            rc = float.Parse(textBox3.Text);
            rd = float.Parse(textBox4.Text);
            re = float.Parse(textBox5.Text);
            rf = float.Parse(textBox12.Text);
            eg = float.Parse(textBox8.Text);
            r = float.Parse(textBox9.Text);
            red = (rb + rc) * (rf + re) / (re + rb + rc + rf) + ra+rd;
            textBox6.Text = Convert.ToString(re);
            
            i = eg / (red + r);
            float rapi1i2 = (rb + rc) / (rf + re);

            textBox7.Text = Convert.ToString(i);
            i2 = i / (1 + rapi1i2);
            textBox10.Text = Convert.ToString(i2);
            u2 = i2 * red;
            textBox11.Text = Convert.ToString(u2);
            */
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

            textBox10.Clear();
            textBox11.Clear();
        


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Form1 f = new Form1();
           // f.Show();
            this.Close();
        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
