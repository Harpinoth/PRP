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
using System.IO.Ports;

namespace PRP_Labo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        public void wczytaj_parametry()
        {

            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\plik.txt";
            
            if (File.Exists(@filepath))
            {
                string[] parameters = File.ReadAllLines(@filepath);
                
                    dane_port.Invoke(new Action(delegate () {
                        try  { dane_port.Text = parameters[0];  }
                        catch { MessageBox.Show("Port name is either missing or corrupted!"); }  }));
                    dane_szybkosc.Invoke(new Action(delegate () {
                        try { dane_szybkosc.Text = parameters[1]; }
                        catch { MessageBox.Show("Baudrate dara is either missing or corrupted!"); }  }));
                    dane_parzystosc.Invoke(new Action(delegate () {
                        try { dane_parzystosc.Text = parameters[2]; }
                        catch { MessageBox.Show("Parity data is either missing or corrupted!"); }  }));
                    dane_dlugosc.Invoke(new Action(delegate () {
                        try { dane_dlugosc.Text = parameters[3]; }
                        catch { MessageBox.Show("Amount of data bits is either missing or corrupted!"); }  }));
                    dane_bitystopu.Invoke(new Action(delegate () {
                        try { dane_bitystopu.Text = parameters[4]; }
                        catch { MessageBox.Show("Stopbits data is either missing or corrupted!"); }  }));
            }
            else MessageBox.Show("File does not exist!");
        }
        public void zapisz_parametry()
        {
            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\plik.txt";
            if (File.Exists(@filepath))
            {
                string[] t = new string[5];
                t[0] = dane_port.Text;
                t[1] = dane_szybkosc.Text;
                t[2] = dane_parzystosc.Text;
                t[3] = dane_dlugosc.Text;
                t[4] = dane_bitystopu.Text;
                File.WriteAllLines(@filepath, t);
            }
            else MessageBox.Show("File does not exist!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            wczytaj_parametry();
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            zapisz_parametry();
        }

        private void polacz_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = new SerialPort(dane_port.Text);
            port_lab.BaudRate = Convert.ToInt32(dane_szybkosc);

            if (dane_parzystosc.Text == "none") port_lab.Parity = Parity.None;
            else if (dane_parzystosc.Text == "odd") port_lab.Parity = Parity.Odd;
            else if (dane_parzystosc.Text == "even") port_lab.Parity = Parity.Even;
            else { MessageBox.Show("Wrong parity, setting parity to none!"); port_lab.Parity = Parity.None; }

            port_lab.DataBits = Convert.ToInt32(dane_dlugosc.Text);

            if (dane_bitystopu.Text == "one") port_lab.StopBits = StopBits.One;
            else if (dane_bitystopu.Text == "onepointfive") port_lab.StopBits = StopBits.OnePointFive;
            else if (dane_bitystopu.Text == "two") port_lab.StopBits = StopBits.Two;
            else
            {
                MessageBox.Show("Wrong stopbits, setting stopbits to default!");
                port_lab.StopBits = StopBits.One;
            }
        }
    }
}
