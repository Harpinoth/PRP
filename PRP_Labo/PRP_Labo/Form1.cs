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
        
        public void load_parameters()
        {

            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "plik.txt"; // Universal pathname config
            //MessageBox.Show(filepath); // Testing/debugging purposes
            
            if (File.Exists(@filepath))
            {
                string[] parameters = File.ReadAllLines(@filepath);
                /* Reading data from file, try-catching the shit out of it */
                    data_port.Invoke(new Action(delegate () {
                        try  { data_port.Text = parameters[0];  }
                        catch { MessageBox.Show("Port name is either missing or corrupted!"); }  }));
                    data_baud.Invoke(new Action(delegate () {
                        try { data_baud.Text = parameters[1]; }
                        catch { MessageBox.Show("Baudrate dara is either missing or corrupted!"); }  }));
                    data_parity.Invoke(new Action(delegate () {
                        try { data_parity.Text = parameters[2]; }
                        catch { MessageBox.Show("Parity data is either missing or corrupted!"); }  }));
                    data_bits.Invoke(new Action(delegate () {
                        try { data_bits.Text = parameters[3]; }
                        catch { MessageBox.Show("Amount of data bits is either missing or corrupted!"); }  }));
                    data_stopbits.Invoke(new Action(delegate () {
                        try { data_stopbits.Text = parameters[4]; }
                        catch { MessageBox.Show("Stopbits data is either missing or corrupted!"); }  }));
            }
            else MessageBox.Show("File does not exist!");
        }
        public void save_parameters()
        {
            // Saving data
            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\plik.txt";
            if (File.Exists(@filepath))
            {
                string[] t = new string[5];
                t[0] = data_port.Text;
                t[1] = data_baud.Text;
                t[2] = data_parity.Text;
                t[3] = data_bits.Text;
                t[4] = data_stopbits.Text;
                File.WriteAllLines(@filepath, t);
            }
            else MessageBox.Show("File does not exist!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            load_parameters();    // Upon entering tab with connection data load current setting from file
        }

        private void save_Click(object sender, EventArgs e)
        {
            save_parameters();     // Save to file
        }

        private void connect_Click(object sender, EventArgs e)
        {
            // Connection data conversion to appropriate values and types
            SerialPort port_lab = new SerialPort(data_port.Text);
            port_lab.BaudRate = Convert.ToInt32(data_baud.Text);

            if (data_parity.Text == "none") port_lab.Parity = Parity.None;
            else if (data_parity.Text == "odd") port_lab.Parity = Parity.Odd;
            else if (data_parity.Text == "even") port_lab.Parity = Parity.Even;
            else { MessageBox.Show("Wrong parity, setting parity to none!"); port_lab.Parity = Parity.None; }
            /* Default parity set to avoid critical errors and their results */

            port_lab.DataBits = Convert.ToInt32(data_bits.Text);

            if (data_stopbits.Text == "one") port_lab.StopBits = StopBits.One;
            else if (data_stopbits.Text == "onepointfive") port_lab.StopBits = StopBits.OnePointFive;
            else if (data_stopbits.Text == "two") port_lab.StopBits = StopBits.Two;
            else
            {
                MessageBox.Show("Wrong stopbits, setting stopbits to default!");
                port_lab.StopBits = StopBits.One;
            }
            /* Default stopbits set to avoid critical errors and their results */
        }
    }
}
