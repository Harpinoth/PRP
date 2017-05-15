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
        public string filename = "plik";    // Filename for connection data saving and reading
        public void load_parameters()       // Method for loading connection data from file
        {

            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename; // Universal pathname config
            //MessageBox.Show(filepath);    // Testing/debugging purposes
            
            if (File.Exists(@filepath))
            {
                string[] parameters = File.ReadAllLines(@filepath);
                /* Reading data from file */
                    data_port.Invoke(new Action(delegate () {
                        try  { data_port.Text = parameters[0];  }
                        catch { MessageBox.Show("Port name is either missing or corrupted!"); }  }));               // Port name loading
                    data_baud.Invoke(new Action(delegate () {
                        try { data_baud.Text = parameters[1]; }
                        catch { MessageBox.Show("Baudrate dara is either missing or corrupted!"); }  }));           // Baudrate loading
                    data_parity.Invoke(new Action(delegate () {
                        try { data_parity.Text = parameters[2]; }
                        catch { MessageBox.Show("Parity data is either missing or corrupted!"); }  }));             // Parity loading
                    data_bits.Invoke(new Action(delegate () {
                        try { data_bits.Text = parameters[3]; }
                        catch { MessageBox.Show("Amount of data bits is either missing or corrupted!"); }  }));     // Data bits loading
                    data_stopbits.Invoke(new Action(delegate () {
                        try { data_stopbits.Text = parameters[4]; }
                        catch { MessageBox.Show("Stopbits data is either missing or corrupted!"); }  }));           // Stopbits loading
            }
            else MessageBox.Show("File does not exist!");
        }
        public void save_parameters()   // Method for saving current connection data to file
        {
            // Saving data
            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename;
            /*  */
            if (File.Exists(@filepath))
            {
                string[] t = new string[5];
                t[0] = data_port.Text;              // Preparing to write port name to file
                t[1] = data_baud.Text;              // Preparing to write baudrate to file
                t[2] = data_parity.Text;            // Preparing to write parity to file
                t[3] = data_bits.Text;              // Preparing to write data bits to file
                t[4] = data_stopbits.Text;          // Preparing to write stopbits to file
                File.WriteAllLines(@filepath, t);   // Writing data to file
            }
            else MessageBox.Show("File does not exist!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            load_parameters();    // Upon entering this tab, load current connection data setting from file
        }

        private void save_Click(object sender, EventArgs e)
        {
            save_parameters();     // Save current connection data to file
        }

        private void connect_Click(object sender, EventArgs e)
        {
            // Connection data conversion to appropriate values and types
            SerialPort port_lab = new SerialPort(data_port.Text);               // Creates port instance with current port name
            port_lab.BaudRate = Convert.ToInt32(data_baud.Text);                // Sets the baudrate of port instance to current textbox value


            /* Code lines responsible for setting parity */
            if (data_parity.Text == "none" || data_parity.Text == "None") port_lab.Parity = Parity.None;            // Two possible input values in each if, 
            else if (data_parity.Text == "odd" || data_parity.Text == "Odd") port_lab.Parity = Parity.Odd;          // other values will prompt default "none" value
            else if (data_parity.Text == "even" || data_parity.Text == "Even") port_lab.Parity = Parity.Even;
            else { MessageBox.Show("Wrong parity, setting parity to none!"); port_lab.Parity = Parity.None; }
            /* Default parity set to avoid critical errors and their results */

            port_lab.DataBits = Convert.ToInt32(data_bits.Text);                // Sets the amount of data bits of port instance to current textbox value

            /* Code lines responsible for setting stopbits */
            if (data_stopbits.Text == "one" || data_stopbits.Text == "One") port_lab.StopBits = StopBits.One;               // Two possible input values in each if,
            else if (data_stopbits.Text == "onepointfive" || data_stopbits.Text == "OnePointFive") port_lab.StopBits = StopBits.OnePointFive;
            else if (data_stopbits.Text == "two" || data_stopbits.Text == "Two") port_lab.StopBits = StopBits.Two;          // other values will prompt default "one" value
            else { MessageBox.Show("Wrong stopbits, setting stopbits to default!"); port_lab.StopBits = StopBits.One; }
            /* Default stopbits set to avoid critical errors and their results */
        }
    }
}
