using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Pomiar_temperatury
{

    public partial class Odczyt : Form
    {
        private static string RxString = "";
        Port port = new Port();
        public Odczyt()
        {
            InitializeComponent();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                RxString = serialPort1.ReadExisting();
                this.Invoke(new EventHandler(DisplayText));
            }

            catch (System.TimeoutException) { }
        }
        private void DisplayText(object s, EventArgs e)
        {
            textBox1.AppendText(RxString);
        }

    }
}
