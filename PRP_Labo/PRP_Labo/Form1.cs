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
using System.Diagnostics;

namespace PRP_Labo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public static string[] myPort = System.IO.Ports.SerialPort.GetPortNames();
        string crlf = Convert.ToString(Convert.ToChar(13)) + Convert.ToString(Convert.ToChar(10));
        int linenumber = 10;
        public string pointter;
        public string step2;
        public string[] makro_list = new string[1001];
        public string[] points = new string[10];
        public string filename_port = "plik.txt";           // Filename for connection data saving and reading
        public string filename_macro = "program.txt";         // Filename for macro saving and reading
        public static double step = 0.1;
        public SerialPort port_lab;
        

        public void load_parameters()       // Method for loading connection data from file
        {

            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename_port; // Universal pathname config
            //MessageBox.Show(filepath);    // Testing/debugging purposes

            if (File.Exists(@filepath))
            {
                string[] parameters = File.ReadAllLines(@filepath);
                /* Reading data from file */
                data_port.Invoke(new Action(delegate () {
                    try { data_port.Text = parameters[0]; }
                    catch { MessageBox.Show("Nazwa portu nie istnieje lub dane są uszkodzone!"); }
                }));               // Port name loading
                data_baud.Invoke(new Action(delegate () {
                    try { data_baud.Text = parameters[1]; }
                    catch { MessageBox.Show("Dane o prędkości przesyłu nie istnieją lub są uszkodzone!"); }
                }));           // Baudrate loading
                data_parity.Invoke(new Action(delegate () {
                    try { data_parity.Text = parameters[2]; }
                    catch { MessageBox.Show("Dane o parzystości nie istnieją lub są uszkodzone!"); }
                }));             // Parity loading
                data_bits.Invoke(new Action(delegate () {
                    try { data_bits.Text = parameters[3]; }
                    catch { MessageBox.Show("Dane o ilości bitów danych nie istnieją lub są uszkodzone!"); }
                }));     // Data bits loading
                data_stopbits.Invoke(new Action(delegate () {
                    try { data_stopbits.Text = parameters[4]; }
                    catch { MessageBox.Show("Dane o ilości bitów stopu nie istnieją lub są uszkodzone!"); }
                }));           // Stopbits loading
            }
            else MessageBox.Show("File does not exist!");
        }
        public void save_parameters()   // Method for saving current connection data to file
        {
            // Saving data
            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename_port; // Universal pathname config
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
            else MessageBox.Show("Plik nie istnieje!");
        }

        private SerialPort port_call()              // Method responsible for initialising port in other methods
        {
            // Connection data conversion to appropriate values and types
            SerialPort port_lab = new SerialPort(data_port.Text);               // Creates port instance with current port name
            port_lab.BaudRate = Convert.ToInt32(data_baud.Text);                // Sets the baudrate of port instance to current textbox value


            /* Code lines responsible for setting parity */
            if (data_parity.Text == "none" || data_parity.Text == "None") port_lab.Parity = Parity.None;            // Two possible input values in each if, 
            else if (data_parity.Text == "odd" || data_parity.Text == "Odd") port_lab.Parity = Parity.Odd;          // other values will prompt default "none" value
            else if (data_parity.Text == "even" || data_parity.Text == "Even") port_lab.Parity = Parity.Even;
            else { MessageBox.Show("Zła parzystość, ustawianie parzystości na domyślną (brak)!"); port_lab.Parity = Parity.None; }
            /* Default parity set to avoid critical errors and their results */

            port_lab.DataBits = Convert.ToInt32(data_bits.Text);                // Sets the amount of data bits of port instance to current textbox value

            /* Code lines responsible for setting stopbits */
            if (data_stopbits.Text == "one" || data_stopbits.Text == "One") port_lab.StopBits = StopBits.One;               // Two possible input values in each if,
            else if (data_stopbits.Text == "onepointfive" || data_stopbits.Text == "OnePointFive") port_lab.StopBits = StopBits.OnePointFive;
            else if (data_stopbits.Text == "two" || data_stopbits.Text == "Two") port_lab.StopBits = StopBits.Two;          // other values will prompt default "one" value
            else { MessageBox.Show("Zła ilość bitów stopu, ustawianie wartości na domyślną (jeden)!"); port_lab.StopBits = StopBits.One; }
            /* Default stopbits set to avoid critical errors and their results */            

            return port_lab;
        }

        private void port_starting(SerialPort port_lab)         // Method responsible for opening port in other methods
        {
            try
            {
                port_lab.RtsEnable = true;
                port_lab.DtrEnable = true;
                if (port_lab.IsOpen) ;
                else port_lab.Open();
            }
            catch
            {
                MessageBox.Show("Brak dostępu do portu");
            }
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

        private void connect_Click(object sender, EventArgs e)          // Reaction to clicking connect button
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Close();
        }

        private void WH_button_Click(object sender, EventArgs e)                        // Acquisition of current position of manipulator
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            port_lab.Write(String.Format("WH"+"\r"));
            Thread.Sleep(750);                                                          // Synchronising delay
            pointter = port_lab.ReadExisting();
            WH_text.Invoke(new Action(delegate () { WH_text.Text = pointter; }));       // Writing data into debugging textbox
            point_maker(pointter);                                                      // Dividing data into separate textboxes
            port_lab.Close();
        }  
        
        private void point_maker(string wuha)               // Method responsible for dividing data received from manipulator into separate textboxes
        {
            points = new string[10];
            int j = 0;
            string worker = wuha.TrimEnd(new char[] {'\n', '\r', ' '});
            for (int i=0; i<worker.Length; i++)
            {
                if (worker[i] == ',') j++;                  // Using data separator to tell difference between different parameters
                else if (worker[i] == ' ') ;                // Ignoring spaces
                else
                {
                    if (String.IsNullOrEmpty(points[j])) points[j] += worker[i].ToString();
                    else points[j] = String.Concat(points[j],worker[i].ToString()); ;
                } 
            }
            // Setting proper textboxes
            x_pos.Invoke(new Action(delegate () { x_pos.ResetText(); x_pos.Text = points[0];  }));
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

        private void point_listadder_Click(object sender, EventArgs e)          // Method responsible for adding points to list
        {
            point_list.Text += x_pos.Text + " ; " + y_pos.Text + " ; " + z_pos.Text + " ; " + angle1_pos.Text + " ; " + angle2_pos.Text + " ; " + L1_pos.Text + " ; " + R_pos.Text + " ; " + A_pos.Text + " ; " + C_pos.Text + crlf;
        }

        private void change_Click(object sender, EventArgs e)                   // Method responsible for changing position to one specified in textboxes in "Pozycje" tab
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            Thread.Sleep(750);
            String wysylka = String.Format("MP " + x_pos.Text + "," + y_pos.Text + "," + z_pos.Text + "," + angle1_pos.Text + "," + angle2_pos.Text + "," + L1_pos.Text + "," + L2_pos.Text + "," + R_pos.Text + "," + A_pos.Text + "\r");
            port_lab.Write(wysylka);
            Console.Write(BitConverter.ToString(Encoding.Default.GetBytes(C_pos.Text)));
            port_lab.Close();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {           
            
        }

        private void add_command_Click(object sender, EventArgs e)                  // Method responsible for adding new command to macro
        {            
                makro_text.Text += linenumber + " " + text_command.Text + crlf;
                makro_list[(linenumber-1)/10] = text_command.Text;
                linenumber += 10;               
        }

        private void makro_reset_Click(object sender, EventArgs e)                  // Method responsible for resetting macro
        {
            makro_text.ResetText();
            makro_list = new string[1001];
        }

        private void send_single_command_Click(object sender, EventArgs e)          // Method responsible for sending one command
        {
            SerialPort port_lab = port_call();
            port_starting(port_lab);
            Thread.Sleep(500);
            port_lab.Write(String.Format(text_command.Text + "\r"));
            port_lab.Close();
        }

        private void save_macro_Click(object sender, EventArgs e)                   // Method responsible for saving macro command to file
        {
            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename_macro;
            if (File.Exists(@filepath))
            {
                string[] t = new string[makro_list.Count()];
                t = makro_list;
                File.WriteAllLines(@filepath, t);

            }
            else MessageBox.Show("Plik nie istnieje!");

        }

        private void load_macro_Click(object sender, EventArgs e)                   // Macro responsible for loading macro from to file
        {
            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename_macro;
            if (File.Exists(@filepath))
            {
                string[] t = new string[File.ReadLines(@filepath).Count()];
                t = File.ReadAllLines(@filepath);
                makro_text.ResetText();
                makro_list = new string[1001];
                makro_list = t;
                for(int i = 0; i<File.ReadLines(@filepath).Count(); i++)
                {
                    if (String.IsNullOrEmpty(makro_list[i])) break;
                    makro_text.Text += (10 * (i+1)) + " " + String.Format(makro_list[i]) + crlf;
                }

            }
            else MessageBox.Show("Plik nie istnieje!");
        }

        private void edit_macro_Click(object sender, EventArgs e)
        {
            string filepath;
            filepath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + filename_macro;
            Process.Start("notepad.exe", filepath);
        }

        private void send_command_Click(object sender, EventArgs e)                 // Method responsible for sending macro
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)       // Reaction at closing app, purpose: safety
        {
            
        }

        private void step_scroll_Scroll(object sender, EventArgs e)                 // Method responsible for setting move step in manual mode
        {
                step_text.Text = Convert.ToString((float)step_scroll.Value / 10);
                step_text2.Text = Convert.ToString((float)step_scroll.Value / 10);
                step_text3.Text = Convert.ToString((float)step_scroll.Value / 10);
                step_scroll2.Value = step_scroll.Value;
                step_scroll3.Value = step_scroll.Value;
        }

        private void speed_scroll_Scroll(object sender, EventArgs e)                // Method responsible for setting move speed in manual mode
        {
                  speed_text.Text = Convert.ToString(speed_scroll.Value);
        }

        private void override_scroll_Scroll_1(object sender, EventArgs e)           // Method responsible for setting override in manual mode
        {
            override_text.Text = Convert.ToString(override_scroll.Value);
        }

        private void confirm_Click(object sender, EventArgs e)                      // Method responsible for confirming step, speed and override values
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
        /* START OF SERIES OF REACTIONS TO ACTIONS MADE IN MANUAL MODE */

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

        /* END OF SERIES OF REACTIONS TO ACTIONS MADE IN MANUAL MODE */

        private void help_combo_SelectedIndexChanged_1(object sender, EventArgs e)              // Reaction to choosing any help item in "Pomoc" tab
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

        private void Form1_Load(object sender, EventArgs e)
        {
            step = Convert.ToDouble(step_scroll.Value) / 10;
            step2 = Convert.ToString(step);
            string helper2 = String.Empty;
            for (int i = 0; i < step2.Length; i++)
            {
                if (step2[i] == ',')
                {
                    helper2 += '.';
                }
                else helper2 += step2[i];
            }
            step2 = helper2;
            for (int i = 0; i < myPort.Length; i++)
            {
                porty_combo.Items.Add(myPort[i]);
            }
            porty_combo.Text = myPort[0];
        }

        private void porty_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            data_port.Invoke(new Action(delegate () { data_port.Text = porty_combo.Text; }));
        }

        private void parity_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            data_parity.Invoke(new Action(delegate () { data_parity.Text = parity_combo.Text; }));
        }

        private void stopbits_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            data_stopbits.Invoke(new Action(delegate () { data_stopbits.Text = stopbits_combo.Text; }));
        }

        private void confirm2_Click(object sender, EventArgs e)
        {
            step = Convert.ToDouble(step_scroll.Value) / 10;
            step2 = Convert.ToString(step);
            string helper2 = String.Empty;
            for (int i = 0; i < step2.Length; i++)
            {
                if (step2[i] == ',')
                {
                    helper2 += '.';
                }
                else helper2 += step2[i];
            }
            step2 = helper2;
        }

        private void confirm3_Click(object sender, EventArgs e)
        {
            step = Convert.ToDouble(step_scroll.Value) / 10;
            step2 = Convert.ToString(step);
            string helper2 = String.Empty;
            for (int i = 0; i < step2.Length; i++)
            {
                if (step2[i] == ',')
                {
                    helper2 += '.';
                }
                else helper2 += step2[i];
            }
            step2 = helper2;
        }

        private void step_scroll2_Scroll(object sender, EventArgs e)
        {
            step_text.Text = Convert.ToString((float)step_scroll.Value / 10);
            step_text2.Text = Convert.ToString((float)step_scroll.Value / 10);
            step_text3.Text = Convert.ToString((float)step_scroll.Value / 10);
            step_scroll.Value = step_scroll2.Value;
            step_scroll3.Value = step_scroll2.Value;
        }

        private void step_scroll3_Scroll(object sender, EventArgs e)
        {
            step_text.Text = Convert.ToString((float)step_scroll.Value / 10);
            step_text2.Text = Convert.ToString((float)step_scroll.Value / 10);
            step_text3.Text = Convert.ToString((float)step_scroll.Value / 10);
            step_scroll2.Value = step_scroll3.Value;
            step_scroll.Value = step_scroll3.Value;
        }

        
    }
}
