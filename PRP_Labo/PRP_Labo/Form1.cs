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
        public SerialPort port_lab; 
        string line;
        string crlf = Convert.ToString(Convert.ToChar(10));
        int linenumber = 10;
        public string filename = "plik.txt";    // Filename for connection data saving and reading

        /* TODO: Consider changing the load and save methods to make them save everything, depending on context - 
         * TODO: they can be remade so they take in input parameters and just save shit they are told to save 
         * TODO: into files they are told to save into, also loaders can load what is required from them
         * TODO: at any time, not only connection data 
         * TODO: possible solution: make separate load and save methods and appropriate data handling methods */

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
                    try { data_port.Text = parameters[0]; }
                    catch { MessageBox.Show("Port name is either missing or corrupted!"); }
                }));               // Port name loading
                data_baud.Invoke(new Action(delegate () {
                    try { data_baud.Text = parameters[1]; }
                    catch { MessageBox.Show("Baudrate data is either missing or corrupted!"); }
                }));           // Baudrate loading
                data_parity.Invoke(new Action(delegate () {
                    try { data_parity.Text = parameters[2]; }
                    catch { MessageBox.Show("Parity data is either missing or corrupted!"); }
                }));             // Parity loading
                data_bits.Invoke(new Action(delegate () {
                    try { data_bits.Text = parameters[3]; }
                    catch { MessageBox.Show("Amount of data bits is either missing or corrupted!"); }
                }));     // Data bits loading
                data_stopbits.Invoke(new Action(delegate () {
                    try { data_stopbits.Text = parameters[4]; }
                    catch { MessageBox.Show("Stopbits data is either missing or corrupted!"); }
                }));           // Stopbits loading
            }
            else MessageBox.Show("File does not exist!");
        }
        public void save_parameters()   // Method for saving current connection data to file
        {
            // Saving data
            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename; // Universal pathname config
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

        private void WH_button_Click(object sender, EventArgs e)
        {
            if (port_lab.IsOpen) ;
            else port_lab.Open();
            port_lab.Write(String.Format("WH" + "\r\n"));
            port_lab.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {      
            byte[] bytes = new byte[port_lab.BytesToRead];
            port_lab.Read(bytes, 0, bytes.Length);

            line = System.Text.Encoding.ASCII.GetString(bytes);

            if (line.EndsWith(crlf))
            {
                WH_text.Invoke(new Action(delegate () { WH_text.Text = line; }));
            }
            else MessageBox.Show("Zły format przychodzących danych!");
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {           
            
        }

        private void add_command_Click(object sender, EventArgs e)
        {
            if (linenumber < 360)
            {
                if (linenumber < 190)
                {
                    makro_text.Text += linenumber + " " + text_command.Text + crlf;
                    linenumber += 10;
                }
                else
                {
                    makro_text2.Text += linenumber + " " + text_command.Text + crlf;
                    linenumber += 10;
                }
            }
            else
            {
                MessageBox.Show("Osiągnięto maksymalną długość makra!");
                makro_text2.Text += linenumber + " " + "ED" + crlf;
            }
        }

        private void makro_reset_Click(object sender, EventArgs e)
        {
            makro_text.ResetText();
            makro_text2.ResetText();
        }
    }
}
