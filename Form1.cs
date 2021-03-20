using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        String[] ss = new String[30];
        public int N;




        void EmptyTextbox(params TextBox[] g)
        {
            foreach (TextBox j in g)
            {

                j.Text = string.Empty;
            
            }
        
        
        
        }




        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            {
                Random k = new Random();
               
                textBox3.Text = k.Next(10).ToString();
                textBox4.Text = k.Next(10).ToString();
                textBox5.Text = k.Next(10).ToString();
                textBox6.Text = k.Next(10).ToString();
                textBox7.Text = k.Next(10).ToString();
                textBox8.Text = k.Next(10).ToString();
                textBox9.Text = k.Next(10).ToString();
                textBox10.Text = k.Next(10).ToString();

            }



           






        }

        private void Stop_Click(object sender, EventArgs e)
        {
           
            {
                timer1.Enabled = false;
                int x = int.Parse(textBox3.Text);
                int r = int.Parse(textBox4.Text);
                int t = int.Parse(textBox5.Text);
                int y = int.Parse(textBox6.Text);
                int u = int.Parse(textBox7.Text);
                int i = int.Parse(textBox8.Text);
                int o = int.Parse(textBox9.Text);
                int p = int.Parse(textBox10.Text);
                MessageBox.Show("The Number of Winner is: " + x + r + t + y + u + i + o + p);
                Class1.f2.listBox1.Items.Add("The Number of Winner is: " + x + r + t + y + u + i + o + p).ToString(); 
            }

      
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.f1.Hide();
            Class1.f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app has been developed by Ali（阿里）693, Yahya（洛克）616 and Mohammed（莫汉）706");
        }
    }
}
