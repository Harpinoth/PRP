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
        public SerialPort port;
        public string a,indata;
        public int f,g;
      
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }      
            
         private void button1_Click(object sender, EventArgs e)
        {            
            port.Write(textBox1.Text);
            textBox4.Text = textBox1.Text;
        }
        public void dzialaj()
        {
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);            
            while (f == 1)
            {
                
            }
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        public delegate void UpdateTextDelegate(string text);

        public void UpdateText(string text) {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateTextDelegate(UpdateText, text));
            }
            else
            {
                this.textBox1.Text = text;
            }
        }
        // http://zurb.com/forrst/posts/C_Windows_Forms_Accessing_the_UI_Thread_in_a-6qU

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            indata = port.ReadExisting();            
            if (indata == "Ping") a = "Pong";
            else a = "Ping";         
        }     

        private void button3_Click(object sender, EventArgs e)
        {
            f = 0;
            port.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        public void button2_Click(object sender, EventArgs e)
        {
            a = textBox3.Text;
            port = new SerialPort(a);
            port.Open();
            f = 1;
            dzialaj();


        }
    }
}
