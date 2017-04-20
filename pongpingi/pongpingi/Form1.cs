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
        public int c,f;
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }       
        
        private void button1_Click(object sender, EventArgs e)
        {
            b = textBox1.Text;
            c = 1;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (c == 1)
            {
                if (a == "COM1")
                {
                    d = "COM2";
                }
                else d = "COM1";
                port2 = new SerialPort(d);
                port2.Write(b);
                textBox4.Text = b;
                c = 0;
            }
            if (f == 1)
            {
                
                port1 = new SerialPort(a);
                if (port1.ReadExisting() == "Ping" || port1.ReadExisting() == "Pong")
                {
                    if (port1.ReadExisting() == "Ping")
                    {
                        b = "Pong";
                    }
                    else b = "Ping";

                    textBox2.Text = port1.ReadExisting();
                    textBox4.Text = "";
                }
            }
            Thread.Sleep(50);
            if (textBox4.Text=="")
            {
                port2 = new SerialPort(d);
                port2.Write(b);
                textBox4.Text = b;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = 0;
            f = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = textBox3.Text;
            port1 = new SerialPort(a);
            f = 1;
        }
    }
}
