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
    public partial class Form2 : Form
    {
        int n, i;
        int nr = 0;
        bool ver = false;
        int timeLeft;
        int ad;
        string fisier1 = "intrebari.rtf";
        string fisier2 = "intrebari2.rtf";
        string fisier3 = "intrebari3.rtf";
        string[] intrebr1 = new string[100];
        string[] intrebr2 = new string[100];
        string[] ras1 = new string[30];
        string[] ras2 = new string[30];
        string[] ras3 = new string[30];
        string[] ras4 = new string[30];
        string[] rascor = new string[30];
        string[] ajut = new string[30];
       

        public Form2()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible =false;
            label2.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            timeLabel.Visible = false;
             button1.Visible=false;
             button2.Visible = false;
             button3.Visible = false;
             button11.Visible = false;
             button12.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ver = true;
            if (radioButton1.Checked == true && string.Equals(ras1[i],rascor[i]))
            {
                nr++;
                MessageBox.Show("Esti destept! ");
            }
            else
                if (radioButton2.Checked == true && string.Equals(ras2[i],rascor[i]))
                {
                    nr++;
                    MessageBox.Show("Bravo ai reusit! ");
                }
                else
                    if (radioButton3.Checked == true && string.Equals(ras3[i],rascor[i]))
                    {
                        nr++;
                        MessageBox.Show(" Cineva stie aici");
                    }
                    else
                        if (radioButton4.Checked == true && string.Equals(ras4[i],rascor[i]))
                        {
                            nr++;
                            MessageBox.Show(" ;) ");
                        }
                        else
                            MessageBox.Show("Sorry mai incearca ");

            button1.Visible = false;
         
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            i++; //trec la intrebarea urmatoare
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (ver == false && i <= n)
            {
                if (radioButton1.Checked == true && string.Equals(ras1[i],rascor[i]))
                    nr++;
                else
                    if (radioButton2.Checked == true && string.Equals(ras2[i],rascor[i]))
                        nr++;
                    else
                        if (radioButton3.Checked == true && string.Equals(ras3[i],rascor[i]))
                            nr++;
                        else
                            if (radioButton4.Checked == true && string.Equals(ras4[i],rascor[i]))
                                nr++;

                i++;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            else
            {
                ver = false;
                if (i <= n)
                    button1.Visible = true;

            }
            if (i <= n)
            {
                label1.Text = intrebr1[i];
                label3.Text = intrebr2[i];
                radioButton1.Text = ras1[i];
                radioButton2.Text = ras2[i];
                radioButton3.Text = ras3[i];
                radioButton4.Text = ras4[i];
            }
            else
            {
                if (i == n + 2)
                {
                    this.Hide();
                    //Form1 f = new Form1();
                    //f.Show();
                }
                button1.Visible = false;
                button3.Visible = false;
                label2.Visible = true;
                timer1.Stop();
                if (nr == 1)
                    label2.Text = " Ati obtinut " + nr.ToString() + " punct";
                else
                    label2.Text = " Ati obtinut " + nr.ToString() + " puncte"; ;


                if (nr >= 4 && nr <= 5)
                {                    
                    button11.Visible = true;
                }                             
                if (nr >= 8 && nr <= 10)
                {
                    button12.Visible = true;
                }

                button2.Text = "Iesire";
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;

                label1.Visible = false;
                label3.Visible = false;
                i++;
                     
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(ver==false)
                MessageBox.Show("Hai ca te ajut un pic " + ajut[i]);
            else
                MessageBox.Show("Hai ca te ajut un pic " + ajut[i-1]);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form1 f = new Form1();
            //f.Show();
            //this.Close();

        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (StreamReader f = new StreamReader(Path.GetFullPath(fisier1)))
            {


                button10.Visible = false;
                timeLeft = 300;
                timeLabel.Text = " 300 ";//"300 seconds";
                timer1.Start();
                this.BackColor = System.Drawing.Color.Turquoise;
                timeLabel.BackColor = Color.Green;
                label4.Visible = true;
                timeLabel.Visible = true;
                pictureBox1.Image = incerc7.Properties.Resources.edoi;
                button2.Visible = true;
                button3.Visible = true;
                n = 5;
                for (i = 1; i <= n; i++)
                {
                    intrebr1[i] = f.ReadLine();
                    intrebr2[i] = f.ReadLine();
                    ras1[i] = f.ReadLine();
                    ras2[i] = f.ReadLine();
                    ras3[i] = f.ReadLine();
                    ras4[i] = f.ReadLine();
                    rascor[i] = f.ReadLine();
                    ajut[i] = f.ReadLine();
                }
                f.Close();
            }
            label2.Visible = false;
            button1.Visible = true;
            button2.Text = "Mai departe";
            radioButton1.Visible =true;
            radioButton2.Visible =true;
            radioButton3.Visible =true;
            radioButton4.Visible =true;
            label1.Visible = true;
            label3.Visible = true;
            label1.Text = intrebr1[1];
            label3.Text = intrebr2[1];
            radioButton1.Text = ras1[1];
            radioButton2.Text = ras2[1];
            radioButton3.Text = ras3[1];
            radioButton4.Text = ras4[1];
            i = 1;//punem prima intrebare;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (StreamReader g = new StreamReader(Path.GetFullPath(fisier2)))
            {
                button11.Visible = false;
                pictureBox1.Image =incerc7.Properties.Resources.eunu;
                timeLeft = 140;// 10;//300;
                timeLabel.Text = " 140 ";
                timer1.Start();
                this.BackColor = System.Drawing.Color.Turquoise;
                timeLabel.BackColor = Color.Green;
                label4.Visible = true;
                timeLabel.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                n = 5;
                for (i = 1; i <= n; i++)
                {
                    intrebr1[i] = g.ReadLine();
                    intrebr2[i] = g.ReadLine();
                    ras1[i] = g.ReadLine();
                    ras2[i] = g.ReadLine();
                    ras3[i] = g.ReadLine();
                    ras4[i] = g.ReadLine();
                    rascor[i] = g.ReadLine();
                    ajut[i] = g.ReadLine();
                }
                g.Close();
            }
            label2.Visible = false;
            button1.Visible = true;
            button2.Text = "Mai departe";
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label1.Text = intrebr1[1];
            label3.Text = intrebr2[1];
            radioButton1.Text = ras1[1];
            radioButton2.Text = ras2[1];
            radioButton3.Text = ras3[1];
            radioButton4.Text = ras4[1];
            i = 1;//punem prima intrebare;

            timeLeft = 300;
            timeLabel.Text = "300 seconds";
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft <= 5)
            {
                ad = 15;
                timer2.Start();
           
            }
           
            
            
            if (timeLeft > 0)
            {
                // arata timp 
                
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " secunde";
            }
            else
            {
               
                timer1.Stop();
                timeLabel.Text = "Timpul sa terminat";
                MessageBox.Show("Imi pare rau esti prea incet", "Pacat");
                
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft <= 5)
            {
                if (ad > 0)
                {
                   ad = ad - 1;                    
                   timeLabel.BackColor = Color.Red;
                    if (ad % 2 == 0)
                        this.BackColor = System.Drawing.Color.White;
                    else
                        this.BackColor = System.Drawing.Color.Tomato;
                }
            }

           
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
              using (StreamReader h = new StreamReader(Path.GetFullPath(fisier3)))
            {
                button12.Visible = false;
                pictureBox1.Image =incerc7.Properties.Resources.etrei;
                timeLeft = 250;
                timeLabel.Text = " 250 ";
                timer1.Start();
                this.BackColor = System.Drawing.Color.Turquoise;
                timeLabel.BackColor = Color.Green;
                label4.Visible = true;
                timeLabel.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                n = 5;
                for (i = 1; i <= n; i++)
                {
                    intrebr1[i] = h.ReadLine();
                    intrebr2[i] = h.ReadLine();
                    ras1[i] = h.ReadLine();
                    ras2[i] = h.ReadLine();
                    ras3[i] = h.ReadLine();
                    ras4[i] = h.ReadLine();
                    rascor[i] = h.ReadLine();
                    ajut[i] = h.ReadLine();
                }
                h.Close();
            }
            label2.Visible = false;
            button1.Visible = true;
            button2.Text = "Mai departe";
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label1.Text = intrebr1[1];
            label3.Text = intrebr2[1];
            radioButton1.Text = ras1[1];
            radioButton2.Text = ras2[1];
            radioButton3.Text = ras3[1];
            radioButton4.Text = ras4[1];
            i = 1;//punem prima intrebare;

            timeLeft = 300;
            timeLabel.Text = "300 seconds";
            timer1.Start();




            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}

