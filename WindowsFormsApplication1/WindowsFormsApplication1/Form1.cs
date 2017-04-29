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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
            {
                InitializeComponent();
            }
        public SerialPort port;
        public string com;
        public string[][] indata, outdata;
        public bool flaga1=false, flaga2 = false;        

        public void CONNECT_Click(object sender, EventArgs e)
            {
                com = COMTEXT.Text;
                port = new SerialPort(com);
                port.Open();
            }

        public void polaczenie()
            {
                port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            if (port.ReadExisting() == "w") { flaga1 = true; }
            if (port.ReadExisting() == "r") { flaga2 = true; }
            if (flaga1)
            {
                port.Write("r");
                for (int i = 0; i <= 7; i++)
                {
                    for (int j = 0; i <= 7; i++)
                    {
                        indata[i][j] = port.ReadExisting();
                        port.Write("1");
                        Thread.Sleep(10);
                    }
                }
                Thread.Sleep(100);
                flaga1 = false;
            }
            if (flaga2)
            {
                for (int i = 0; i <= 7; i++)
                {
                    for (int j = 0; i <= 7; i++)
                    {
                        if (port.ReadExisting() == "1")
                        {                            
                            port.Write(outdata[i][j]);
                        }
                    }
                }
                Thread.Sleep(100);
                flaga2 = false;
            }
        }
            
    }
}
