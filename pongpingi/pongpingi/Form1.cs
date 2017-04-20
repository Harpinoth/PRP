using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace pongpingi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SerialPort port1, port2;
        public string a,b,d;
        public int c;
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }       
        
        private void button1_Click(object sender, EventArgs e)
        {
            b = textBox1.Text;
            c = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(c==1)
            {
                if (b == "COM1")
                {
                    d = "COM2";
                }
                else d = "COM1";
                port2 = new SerialPort(d);
                port2.Write(b);
                textBox4.Text = b;
                Thread.Sleep(100);
                
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = textBox3.Text;
            port1 = new SerialPort(a);
        }
    }
}
