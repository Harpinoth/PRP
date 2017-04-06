using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Pomiar_temperatury
{
    public partial class Port : Form
    {
        public string WybranaPredkosc;
        public string WybranaParzystosc;
        public string WybranaDlugosc;
        public string WybraneBityStopu;
        public string Porty;
        public int predkosc = 9600;
        public int dlugosc = 8;
        public int bitystopu = 1;
        public string nrportu = "COM1";
        public char parzystosc = 'N';
        public bool stan = false;
        public Port()
        {
            InitializeComponent();
            PredkoscCB.SelectedIndex = 2;
            ParzystoscCB.SelectedIndex = 0;
            DlugoscCB.SelectedIndex = 0;
            BityStopuCB.SelectedIndex = 1;
            ParametryPortuL.Text = (this.nrportu + "  " + this.predkosc + "  " + this.dlugosc + "," + this.parzystosc + "," + this.bitystopu);
            getAvaiblePorts();
            StopB.Enabled = false;
            stanL.Text = "Zamknięty";
            stanL.ForeColor = Color.Red;
        }
        void getAvaiblePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            PortyCB.Items.AddRange(ports);
            PortyCB.SelectedIndex = PortyCB.Items.Count - 1;
        }

        private void ZaspiszB_Click(object sender, EventArgs e)
        {
            WybranaPredkosc = (PredkoscCB.SelectedItem.ToString());
            WybranaParzystosc = (ParzystoscCB.SelectedItem.ToString());
            WybranaDlugosc = (DlugoscCB.SelectedItem.ToString());
            WybraneBityStopu = (BityStopuCB.SelectedItem.ToString());
            Porty = PortyCB.Text;

            switch (WybranaParzystosc)
            {
                case "Brak":
                    WybranaParzystosc = "N";
                    break;
                case "Nieprzystość":
                    WybranaParzystosc = "O";
                    break;
                case "Parzystość":
                    WybranaParzystosc = "E";
                    break;
            }
            int.TryParse(this.WybranaPredkosc, out this.predkosc);
            int.TryParse(this.WybranaDlugosc, out this.dlugosc);
            int.TryParse(this.WybraneBityStopu, out this.bitystopu);
            this.parzystosc = WybranaParzystosc[0];
            this.nrportu = Porty;

            ParametryPortuL.Text = (this.nrportu + "  " + this.predkosc + "  " + this.dlugosc + "," + this.parzystosc + "," + this.bitystopu);
        }

        private void ZamknijB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartB_Click(object sender, EventArgs e)
        {
            /* Ustawienie parametrów portu przed wysłaniem*/
            /* Prędkość:*/
            serialPort1.BaudRate = predkosc;

            /*Parzystość*/
            switch (parzystosc)
            {
                case 'N':
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    break;
                case 'O':
                    serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    break;
                case 'E':
                    serialPort1.Parity = System.IO.Ports.Parity.Even;
                    break;
            }

            /*Długość*/
            serialPort1.DataBits = dlugosc;

            /*Bity stopu*/
            switch (bitystopu)
            {
                case 0:
                    serialPort1.StopBits = System.IO.Ports.StopBits.None;
                    break;
                case 1:
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    break;
                case 2:
                    serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                    break;
            }

            /*Numer Portu*/
            serialPort1.PortName = nrportu;

            /*Otwarcie Portu*/

            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    stan = true;
                    StopB.Enabled = true;
                    StartB.Enabled = false;
                    stanL.Text = "Otwarty";
                    stanL.ForeColor = Color.Green;
                }
            }
            catch
            {
                MessageBox.Show("Nie można użyć danego portu");
            }
        }

        private void StopB_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen)
            {
                stan = false;
                StopB.Enabled = false;
                StartB.Enabled = true;
                stanL.Text = "Zamknięty";
                stanL.ForeColor = Color.Red;
            }
        }

        private void Port_Load(object sender, EventArgs e)
        {

        }
    }
}
