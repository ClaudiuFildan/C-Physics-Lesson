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
namespace incerc7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //textBox1.Text = openFileDialog1.FileName;
            ///String filePath = openFileDialog1.teorie.txt;
            //pictureBox1.Image = incerc7.Properties.Resources.eunu;
            //textBox1.Text = filePath;
            textBox1.Text = incerc7.Properties.Resources.teorie1;
            label1.Text = "Lectia 1";
            //label1.Text = " Prin curent electric înţelegem o deplasare dirijată (ordonată) de sarcini electrice. Ex: fluxul de electroni care circulă printr-un conductor metalic; fluxul de ioni (pozitivi şi negativi)  dintr-o baie de electroliză; fluxul de particule încărcate (ioni pozitivi, ioni negativi şi electroni liberi) care alcătuiesc radiaţiile emise de Soare, etc.";
           // textBox1.Text = " Prin curent electric înţelegem o deplasare dirijată (ordonată) de sarcini electrice.\r\n Ex: fluxul de electroni care circulă printr-un conductor metalic; fluxul de ioni (pozitivi şi negativi) \r\n dintr-o baie de electroliză; fluxul de particule încărcate (ioni pozitivi, ioni negativi şi electroni liberi)\r\n care alcătuiesc radiaţiile emise de Soare, etc."; 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = incerc7.Properties.Resources.teorie2;
            label1.Text = "Lectia 2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = incerc7.Properties.Resources.teorie3;
            label1.Text = "Lectia 3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = incerc7.Properties.Resources.teorie4;
            label1.Text = "Lectia 4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = incerc7.Properties.Resources.teorie5;
            label1.Text = "Lectia 5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();
            this.Close();
        }

    }
}
