using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UstALICI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int carpim = 1;
        int i = 0;
        int Ustal(int s1,int u1)
        {
            while (i< u1)
            {
                carpim = carpim * s1;
                i++;
            }

            return carpim;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Text != "-")
            {
                i = 0;

                carpim = 1;
            }
            int r1, r2;
            r1=Convert.ToInt32(textBox1.Text);
            r2 = Convert.ToInt32(textBox2.Text);
           int sonuc= Ustal(r1,r2);
            label4.Text=Convert.ToString(sonuc);   
            
           
       
            

        }
        void sifirla()
        {
            i= 0;
            carpim = 1;
            label4.Text = "-";
            textBox1.Focus();
            textBox1.Text = " ";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label4.Text!="-") {
                sifirla();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
