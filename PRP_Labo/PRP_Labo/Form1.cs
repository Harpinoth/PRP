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
using System.Threading;

namespace PRP_Labo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
         
        string crlf = Convert.ToString(Convert.ToChar(13)) + Convert.ToString(Convert.ToChar(10));
        int linenumber = 10;
        public string pointter;
        public string step2;
        public string[] makro_list = new string[1001];
        public string[] points = new string[10];
        public string filename = "plik.txt";    // Filename for connection data saving and reading
        public static double step = 0.1;
        public SerialPort port_lab;

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

        private SerialPort port_call()
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

            return port_lab;
        }

        private void port_starting(SerialPort port_lab)
        {
            port_lab.RtsEnable = true;
            port_lab.DtrEnable = true;
            if (port_lab.IsOpen);
            else port_lab.Open();
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
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Close();
        }

        private void WH_button_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("WH"+"\r"));
            Thread.Sleep(750);
            pointter = port_lab.ReadExisting();
            WH_text.Invoke(new Action(delegate () { WH_text.Text = pointter; }));
            point_maker(pointter);
            port_lab.Close();
        }  
        
        private void point_maker(string wuha)
        {
            int j = 0;
            string worker = wuha.TrimEnd(new char[] {'\n', '\r', ' '});
            for (int i=0; i<worker.Length; i++)
            {
                if (worker[i] == ',') j++;
                else if (worker[i] == ' ') ;
                else
                {
                    if (String.IsNullOrEmpty(points[j])) points[j] += worker[i].ToString();
                    else points[j] = String.Concat(points[j],worker[i].ToString()); ;
                } 
            }
            x_pos.Invoke(new Action(delegate () { x_pos.ResetText(); x_pos.Text = points[0]; }));
            y_pos.Invoke(new Action(delegate () { y_pos.ResetText();  y_pos.Text = points[1]; }));
            z_pos.Invoke(new Action(delegate () { z_pos.ResetText();  z_pos.Text = points[2]; }));
            angle1_pos.Invoke(new Action(delegate () { angle1_pos.ResetText();  angle1_pos.Text = points[3]; }));
            angle2_pos.Invoke(new Action(delegate () { angle2_pos.ResetText(); angle2_pos.Text = points[4]; }));
            L1_pos.Invoke(new Action(delegate () { L1_pos.ResetText();  L1_pos.Text = points[5]; }));
            L2_pos.Invoke(new Action(delegate () { L2_pos.ResetText(); L2_pos.Text = points[6]; }));
            R_pos.Invoke(new Action(delegate () { R_pos.ResetText();  R_pos.Text = points[7]; }));
            A_pos.Invoke(new Action(delegate () { A_pos.ResetText();  A_pos.Text = points[8]; }));
            C_pos.Invoke(new Action(delegate () { C_pos.ResetText();  C_pos.Text = points[9]; }));
        }      

        private void tabPage3_Enter(object sender, EventArgs e)
        {           
            
        }

        private void add_command_Click(object sender, EventArgs e)
        {            
                makro_text.Text += linenumber + " " + text_command.Text + crlf;
                makro_list[(linenumber-1)/10] = text_command.Text;
                linenumber += 10;               
        }

        private void makro_reset_Click(object sender, EventArgs e)
        {
            makro_text.ResetText();
            makro_list = new string[1001];
        }

        private void send_single_command_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            Thread.Sleep(500);
            port_lab.Write(String.Format(text_command.Text + "\r"));
            port_lab.Close();
        }

        private void send_command_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            for (int i = 0; i < makro_list.Length; i++)
            {
                Thread.Sleep(750);
                if (string.IsNullOrEmpty(makro_list[i])) break;
                port_lab.Write(String.Format(makro_list[i]+crlf));                
            }
            port_lab.Write(String.Format("ED" + "\r"));
            port_lab.Close();        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPort port_lab = port_call();
            if(port_lab.IsOpen)  port_lab.Close();
        }

        private void step_scroll_Scroll(object sender, EventArgs e)
        {
                  step_text.Text = Convert.ToString((float)step_scroll.Value / 10);
        }

        private void speed_scroll_Scroll(object sender, EventArgs e)
        {
                  speed_text.Text = Convert.ToString(speed_scroll.Value);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            step = Convert.ToDouble(step_scroll.Value) / 10;
            step2 = Convert.ToString(step);
            string helper2 = String.Empty;
            for (int i = 0; i<step2.Length; i++)
            {
                if (step2[i] == ',')
                {
                    helper2 += '.';
                }
                else helper2 += step2[i];
            }
            step2 = helper2;
            port_lab.Write(String.Format("SP " + speed_text.Text + "\r" + "\n"));
            Thread.Sleep(550);
            port_lab.Write(String.Format("OVR " + override_text.Text + "\r"));
            port_lab.Close();
        }

        private void DJ1_plus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 1," + step2 + "\r"));
            port_lab.Close();
        }

        private void DJ1_minus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 1,-" + step2 + "\r"));
            port_lab.Close();
        }

        private void DJ2_plus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 2," + step2 + "\r"));
            port_lab.Close();
        }

        private void DJ2_minus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 2,-" + step2 + "\r"));
            port_lab.Close();
        }

        private void DJ3_plus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 3," + step2 + "\r"));
            port_lab.Close();
        }

        private void DJ3_minus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 3,-" + step2 + "\r"));
            port_lab.Close();
        }

        private void DJ4_plus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 4," + step2 + "\r"));
            port_lab.Close();
        }

        private void DJ4_minus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 4,-" + step2 + "\r"));
            port_lab.Close();
        }

        private void DJ5_plus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 5," + step2 + "\r"));
            port_lab.Close();
        }

        private void DJ5_minus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DJ 5,-" + step2 + "\r"));
            port_lab.Close();
        }

        private void x_plus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DS " + step2 + ",0,0" + "\r"));
            port_lab.Close();
        }

        private void x_minus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DS -" + step2 + ",0,0" + "\r"));
            port_lab.Close();
        }

        private void y_plus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DS 0," + step2 + ",0" + "\r"));
            port_lab.Close();
        }

        private void y_minus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DS 0,-" + step2 + ",0" + "\r"));
            port_lab.Close();
        }

        private void z_plus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DS 0,0," + step2 +  "\r"));
            port_lab.Close();
        }

        private void z_minus_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("DS 0,0,-" + step2 + "\r"));
            port_lab.Close();
        }

        private void point_listadder_Click(object sender, EventArgs e)
        {
            point_list.Text += x_pos.Text + " ; " + y_pos.Text + " ; " + z_pos.Text + " ; " + angle1_pos.Text + " ; " + angle2_pos.Text + " ; " + L1_pos.Text + " ; " + R_pos.Text + " ; " + A_pos.Text + " ; " + C_pos.Text + crlf;
        }

        private void override_scroll_Scroll_1(object sender, EventArgs e)
        {
            override_text.Text = Convert.ToString(override_scroll.Value);
        }

        private void change_Click(object sender, EventArgs e)
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            Thread.Sleep(750);
            String wysylka = String.Format("MP " + x_pos.Text + "," + y_pos.Text + "," + z_pos.Text + "," + angle1_pos.Text + "," + angle2_pos.Text + "," + L1_pos.Text + "," + L2_pos.Text + "," + R_pos.Text + "," + A_pos.Text + "\r");
            port_lab.Write(wysylka);
            Console.Write(BitConverter.ToString(Encoding.Default.GetBytes(C_pos.Text)));
            port_lab.Close();
        }

        private void help_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (help_combo.Text)
            {
                case "OVR":
                    help_text.Text = "Override, dokonuje procentowego przeskalowania prędkości poruszania się" + crlf + "Przykład komendy: OVR 60";
                    break;
                case "SP":
                    help_text.Text = "Speed, pozwala na wybranie jednego z ustawień prędkości manipulatora" + crlf + "Przykład komendy: SP 6";
                    break;
                case "PD":
                    help_text.Text = "Point define, pozwala na zdefiniowanie punktu, podanego przez użytkownika, o danym numerze w liście punktów" + crlf + "Przykład komendy: PD 5, 420, -246.2, 208.11, 190.42, 155.30, 1650.85, R, A, C";
                    break;
                case "HE":
                    help_text.Text = "Here, pozwala na zdefiniowanie aktualnego położenia jako punkt o danym numerze w liście punktów" + crlf + "Przykład komendy: HE 8";
                    break;
                case "WH":
                    help_text.Text = "Where, pozwala na odczytanie aktualnego położenia" + crlf + "Przykład komendy: WH" + crlf + "Funkcjonalność zaimplementowana w zakładce \"Pozycje\"";
                    break;
                case "DJ":
                    help_text.Text = "Draw joint, pozwala na obrót wybranego przegubu o zadany kąt" + crlf + "Przykład komendy: DJ 2,45";
                    break;
                case "DS":
                    help_text.Text = "Draw straight, pozwala na przesunięcie o zadaną wartość w układzie kartezjańskim, dokonując interpolacji liniowej" + crlf + "Przykład komendy: DS 10,0,0";
                    break;
                case "DW":
                    help_text.Text = "Draw, pozwala na przesunięcie o zadaną wartość w układzie kartezjańskim, dokonując interpolacji przegubowej" + crlf + "Przykład komendy: DW 10,0,0";
                    break;
                case "IP":
                    help_text.Text = "Increment position, pozwala na przemieszczenie się do następnej w kolejności pozycji, dokonując interpolacji przegubowej" + crlf + "Przykład komendy: IP";
                    break;
                case "DP":
                    help_text.Text = "Decrement position, pozwala na przemieszczenie się do poprzedniej w kolejności pozycji, dokonując interpolacji przegubowej" + crlf + "Przykład komendy: DP";
                    break;
                case "MP":
                    help_text.Text = "Move position, pozwala na przemieszczenie się do podanej pozycji, dokonując interpolacji przegubowej" + crlf + "Przykład komendy: MP 420, -246.2, 208.11, 190.42, 155.30, 1650.85, R, A, C";
                    break;
                case "MO":
                    help_text.Text = "Move, pozwala na przemieszczenie się do pozycji z listy, o podanym numerze" + crlf + "Przykład komendy: MO 13";
                    break;
                case "MS":
                    help_text.Text = "Move straight, pozwala na przemieszczenie się do pozycji z listy, dokonując interpolacji liniowej" + crlf + "Przykład komendy: MS 18";
                    break;
                case "MA":
                    help_text.Text = "Move approach, pozwala na przemieszczenie się pomiędzy dwoma pozycjami" + crlf + "Przykład komendy: MA 6,13";
                    break;
                case "MC":
                    help_text.Text = "Move continuous, pozwala na przemieszczenie się po kolei po wszystkich pozycjach między dwoma podanymi pozycjami z listy" + crlf + "Przykład komendy: MC 1, 45";
                    break;
                case "MJ":
                    help_text.Text = "Move joint, pozwala na obrócenie przegubu od obecnej pozycji o zadany kąt" + crlf + "Przykład komendy: MJ 10,0,0,0,0,0";
                    break;
                case "MR":
                    help_text.Text = "Pozwala na przemieszczenie się po łuku określonym na podstawie trzech podanych pozycji z listy" + crlf + "Przykład komendy: MR 1,5,77";
                    break;
                case "MRA":
                    help_text.Text = "Pozwala na wykonanie łuku, gdzie poprzednie wywołanie tej funkcji będzie pierwszym punktem łuku, a następne ostatnim" + crlf + "Przykład komendy: MRA 12";
                    break;
                case "GC":
                    help_text.Text = "Grip close, pozwala na zamknięcie chwytaka" + crlf + "Przykład komendy: GC";
                    break;
                case "GO":
                    help_text.Text = "Grip open, pozwala na otwarcie chwytaka" + crlf + "Przykład komendy: GO";
                    break;
                default:
                    help_text.Text = "";
                    break;
            }
        }
    }
}
