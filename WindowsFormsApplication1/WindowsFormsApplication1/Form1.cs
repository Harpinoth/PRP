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
                MessageBox.Show("Skonfiguruj połączenie");
            }
        public SerialPort port;
        public string com, flaga3="0",p="p";
        public string[,] indata = new string [8,8]{ {"0","0","0","0","0","0","0","0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" } };
        public string[,] outdata = new string[8,8]{ {"0","0","0","0","0","0","0","0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" } };
        public bool flaga1=false, flaga2 = false, readyclicked=true, connclicked = true,iwasnthere=true;
        public int index,status=0,count=0; 
        
        // Przysłanie danych w trakcie gry

        public void gra()
        {
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler2);
        }

        public void DataReceivedHandler2(object sender, SerialDataReceivedEventArgs e)
        {
            index = Convert.ToInt32(port.ReadExisting());
            invokemaster(index);
        }

        public void invokemaster(int a)
        {
            switch(a)
            {
                case 1:
                    if (outdata[0, 0] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 2:
                    if (outdata[0, 1] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 3:
                    if (outdata[0, 2] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 4:
                    if (outdata[0, 3] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 5:
                    if (outdata[0, 4] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 6:
                    if (outdata[0, 5] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 7:
                    if (outdata[0, 6] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 8:
                    if (outdata[0, 7] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 9:
                    if (outdata[1, 0] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 10:
                    if (outdata[1, 1] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 11:
                    if (outdata[1, 2] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 12:
                    if (outdata[1, 3] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 13:
                    if (outdata[1, 4] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 14:
                    if (outdata[1, 5] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 15:
                    if (outdata[1, 6] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 16:
                    if (outdata[1, 7] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 17:
                    if (outdata[2, 0] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 18:
                    if (outdata[2, 1] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 19:
                    if (outdata[2, 2] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 20:
                    if (outdata[2, 3] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 21:
                    if (outdata[2, 4] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 22:
                    if (outdata[2, 5] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 23:
                    if (outdata[2, 6] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 24:
                    if (outdata[2, 7] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 25:
                    if (outdata[3, 0] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 26:
                    if (outdata[3, 1] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 27:
                    if (outdata[3, 2] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 28:
                    if (outdata[3, 3] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 29:
                    if (outdata[3, 4] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 30:
                    if (outdata[3, 5] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 31:
                    if (outdata[3, 6] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 32:
                    if (outdata[3, 7] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 33:
                    if (outdata[4, 0] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 34:
                    if (outdata[4, 1] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 35:
                    if (outdata[4, 2] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 36:
                    if (outdata[4, 3] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 37:
                    if (outdata[4, 4] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 38:
                    if (outdata[4, 5] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 39:
                    if (outdata[4, 6] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 40:
                    if (outdata[4, 7] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 41:
                    if (outdata[5, 0] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 42:
                    if (outdata[5, 1] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 43:
                    if (outdata[5, 2] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 44:
                    if (outdata[5, 3] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 45:
                    if (outdata[5, 4] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 46:
                    if (outdata[5, 5] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 47:
                    if (outdata[5, 6] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 48:
                    if (outdata[5, 7] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 49:
                    if (outdata[6, 0] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 50:
                    if (outdata[6, 1] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 51:
                    if (outdata[6, 2] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 52:
                    if (outdata[6, 3] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 53:
                    if (outdata[6, 4] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 54:
                    if (outdata[6, 5] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 55:
                    if (outdata[6, 6] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 56:
                    if (outdata[6, 7] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 57:
                    if (outdata[7, 0] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 58:
                    if (outdata[7, 1] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 59:
                    if (outdata[7, 2] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 60:
                    if (outdata[7, 3] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 61:
                    if (outdata[7, 4] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 62:
                    if (outdata[7, 5] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 63:
                    if (outdata[7, 6] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case 64:
                    if (outdata[7, 7] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
            }
        }

        // Początkowa wymiana macierzy statków

        public void CONNECT_Click(object sender, EventArgs e)
        {
            if (connclicked)
            {
                com = COMTEXT.Text;
                MessageBox.Show("Zaznacz swoje statki!");
                port = new SerialPort(com);
                port.Open();
                connclicked = false;
            }
        }

        private void DISCONNECT_Click(object sender, EventArgs e)
        {
            port.Close();
            connclicked = true;
        }


        private void READY_Click(object sender, EventArgs e)
        {
            if (readyclicked)
            {
                if (com != string.Empty && count == 8)
                {
                    polaczenie();
                    readyclicked = false;
                }
                else MessageBox.Show("Brak konfiguracji połączenia/Brak ośmiu statków");
            }
        }

        public void polaczenie()
        {
            port.Write("1");
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            MessageBox.Show("Poczekaj na swojego przeciwnika!");
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {           
            if (port.ReadExisting() == "1" && iwasnthere)
            {
                MessageBox.Show("Łączenie z przeciwnikiem!");
                if (com == "COM4") flaga3 = "pierwszy";
                else flaga3 = "drugi";
                if (flaga3 == "pierwszy") flaga1 = true;
                else flaga2 = true;
                status = 2;
                iwasnthere = false;
               
            }
            Thread.Sleep(15);
            while (status > 0)
            {
                if (flaga1)
                {
                    for (int i = 0; i <= 7; i++)
                    {
                        for (int j = 0; j <= 7; j++)
                        {
                            indata[i, j] = port.ReadExisting();
                            port.Write("OK");
                            Thread.Sleep(10);
                            port.Write("STOP");
                        }
                    }
                    flaga2 = true;
                    flaga1 = false;
                    status = status - 1;
                    Thread.Sleep(100);
                }
                if (flaga2)
                {
                    for (int i = 0; i <= 7; i++)
                    {
                        for (int j = 0; j <= 7; j++)
                        {
                            while(port.ReadExisting() != "OK") {; }                                                        
                            port.Write(outdata[i, j]);                            
                            Thread.Sleep(15);
                        }
                    }
                    flaga1 = true;
                    flaga2 = false;
                    status=status-1;
                    Thread.Sleep(100);
                }
            }
            MessageBox.Show("Gra się zaczęła!");
            port.Close();
            port.Open();
            gra();                  
        }
        // Tworzenie macierzy własnych statków

        private void AA11_Click(object sender, EventArgs e)
        {
            if (outdata[0, 0] == "0" && outdata[0, 1] == "0" && outdata[1, 0] == "0" && outdata[1, 1] == "0" && count<8) { outdata[0, 0] = "1"; count++; AA11.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void AA22_Click(object sender, EventArgs e)
        {
            if (outdata[0, 1] == "0" && outdata[0, 0] == "0" && outdata[1, 0] == "0" && outdata[1, 1] == "0" && outdata[1, 2] == "0" && outdata[0, 2] == "0" && count <8) { outdata[0, 1] = "1"; count++; AA22.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void AA33_Click(object sender, EventArgs e)
        {
            if (outdata[0, 2] == "0" && outdata[0, 1] == "0" && outdata[0, 3] == "0" && outdata[1, 1] == "0" && outdata[1, 2] == "0" && outdata[1, 3] == "0" && count < 8) { outdata[0, 2] = "1"; count++; AA33.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void AA44_Click(object sender, EventArgs e)
        {
            if (outdata[0, 3] == "0" &&  outdata[0, 2] == "0" && outdata[0, 4] == "0" && outdata[1, 2] == "0" && outdata[1, 3] == "0" && outdata[1, 4] == "0" && count < 8) { outdata[0, 3] = "1"; count++; AA44.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void AA55_Click(object sender, EventArgs e)
        {
            if (outdata[0, 4] == "0" && outdata[0, 3] == "0" && outdata[0, 5] == "0" && outdata[1, 3] == "0" && outdata[1, 4] == "0" && outdata[1, 5] == "0" && count < 8) { outdata[0, 4] = "1"; count++; AA55.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void AA66_Click(object sender, EventArgs e)
        {
            if (outdata[0, 5] == "0" && outdata[0,4] == "0" && outdata[0, 5] == "0" && outdata[1, 4] == "0" && outdata[1, 5] == "0" && outdata[1, 6] == "0" && count < 8) { outdata[0, 5] = "1"; count++; AA66.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void AA77_Click(object sender, EventArgs e)
        {
            if (outdata[0, 6] == "0" && (outdata[0, 5] == "0" && outdata[0, 7] == "0" && outdata[1, 5] == "0" && outdata[1, 6] == "0" && outdata[1, 7] == "0" && count < 8) ){ outdata[0, 6] = "1"; count++; AA77.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void AA88_Click(object sender, EventArgs e)
        {
            if (outdata[0, 7] == "0" && outdata[0, 6] == "0" && outdata[1, 6] == "0" && outdata[1, 7] == "0"  && count < 8) { outdata[0, 7] = "1"; count++; AA88.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void BB11_Click(object sender, EventArgs e)
        {
            if (outdata[1, 0] == "0" && (outdata[0, 0] == "0" && outdata[0, 1] == "0" && outdata[1, 1] == "0" && outdata[2, 0] == "0" && outdata[2, 1] == "0" && count < 8)) { outdata[1, 0] = "1"; count++; BB11.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (outdata[1, 1] == "0" && (outdata[0, 0] == "0" && outdata[0, 1] == "0" && outdata[0, 2] == "0" && outdata[1, 0] == "0" && outdata[1, 2] == "0" && outdata[2, 0] == "0" && outdata[2, 1] == "0" && outdata[2, 2] == "0" && count < 8)) { outdata[1, 1] = "1"; count++; B.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");

        }

        private void B33_Click(object sender, EventArgs e)
        {
            if (outdata[1, 2] == "0" && (outdata[0, 1] == "0" && outdata[0, 2] == "0" && outdata[0, 3] == "0" && outdata[1, 1] == "0" && outdata[1, 3] == "0" && outdata[2, 1] == "0" && outdata[2, 2] == "0" && outdata[2, 3] == "0" && count < 8)) { outdata[1, 2] = "1"; count++; B33.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void BB44_Click(object sender, EventArgs e)
        {
            if (outdata[1, 3] == "0" && (outdata[0, 2] == "0" && outdata[0, 3] == "0" && outdata[0, 4] == "0" && outdata[1, 2] == "0" && outdata[1, 4] == "0" && outdata[2, 2] == "0" && outdata[2, 3] == "0" && outdata[2, 4] == "0" && count < 8)) { outdata[1, 3] = "1"; count++; BB44.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void BB55_Click(object sender, EventArgs e)
        {
            if (outdata[1, 4] == "0" && (outdata[0, 3] == "0" && outdata[0, 4] == "0" && outdata[0, 5] == "0" && outdata[1, 3] == "0" && outdata[1, 5] == "0" && outdata[2, 3] == "0" && outdata[2, 4] == "0" && outdata[2, 5] == "0" && count < 8)) { outdata[1, 4] = "1"; count++; BB55.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void BB66_Click(object sender, EventArgs e)
        {
            if (outdata[1, 5] == "0" && (outdata[0, 4] == "0" && outdata[0, 5] == "0" && outdata[0, 6] == "0" && outdata[1, 4] == "0" && outdata[1, 6] == "0" && outdata[2, 4] == "0" && outdata[2, 5] == "0" && outdata[2, 6] == "0" && count < 8)) { outdata[1, 5] = "1"; count++; BB66.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void BB77_Click(object sender, EventArgs e)
        {
            if (outdata[1, 6] == "0" && (outdata[0, 5] == "0" && outdata[0, 6] == "0" && outdata[0, 7] == "0" && outdata[1, 5] == "0" && outdata[1, 7] == "0" && outdata[2, 5] == "0" && outdata[2, 6] == "0" && outdata[2,7] == "0" && count < 8)) { outdata[1, 6] = "1"; count++; BB77.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void BB88_Click(object sender, EventArgs e)
        {
            if (outdata[1, 7] == "0" && (outdata[0, 6] == "0" && outdata[0, 7] == "0" && outdata[1, 6] == "0" && outdata[2, 6] == "0" && outdata[2, 7] == "0" && count < 8)) { outdata[1, 7] = "1"; count++; BB88.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void CC11_Click(object sender, EventArgs e)
        {
            if (outdata[2, 0] == "0" && (outdata[1, 0] == "0" && outdata[1, 1] == "0" && outdata[2, 1] == "0" && outdata[3, 0] == "0" && outdata[3, 1] == "0" && count < 8)) { outdata[2, 0] = "1"; count++; CC11.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void CC22_Click(object sender, EventArgs e)
        {
            if (outdata[2, 1] == "0" && (outdata[1, 0] == "0" && outdata[1, 1] == "0" && outdata[1, 2] == "0" && outdata[2, 0] == "0" && outdata[2, 2] == "0" && outdata[3, 0] == "0" && outdata[3, 1] == "0" && outdata[3, 2] == "0" && count < 8)) { outdata[2, 1] = "1"; count++; CC22.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void CC33_Click(object sender, EventArgs e)
        {
            if (outdata[2, 2] == "0" && (outdata[1, 1] == "0" && outdata[1, 2] == "0" && outdata[1, 3] == "0" && outdata[2,1] == "0" && outdata[2, 3] == "0" && outdata[3, 1] == "0" && outdata[3, 2] == "0" && outdata[3,3] == "0" && count < 8)) { outdata[2, 2] = "1"; count++; CC33.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void CC44_Click(object sender, EventArgs e)
        {
            if (outdata[2, 3] == "0" && (outdata[1, 2] == "0" && outdata[1, 3] == "0" && outdata[1, 4] == "0" && outdata[2, 2] == "0" && outdata[2, 4] == "0" && outdata[3, 2] == "0" && outdata[3, 3] == "0" && outdata[3, 4] == "0" && count < 8)) { outdata[2, 3] = "1"; count++; CC44.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void CC55_Click(object sender, EventArgs e)
        {
            if (outdata[2, 4] == "0" && (outdata[1, 3] == "0" && outdata[1, 4] == "0" && outdata[1, 5] == "0" && outdata[2, 3] == "0" && outdata[2, 5] == "0" && outdata[3, 3] == "0" && outdata[3, 4] == "0" && outdata[3, 5] == "0" && count < 8)) { outdata[2, 4] = "1"; count++; CC55.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void CC66_Click(object sender, EventArgs e)
        {
            if (outdata[2, 5] == "0" && (outdata[1, 4] == "0" && outdata[1, 5] == "0" && outdata[1, 6] == "0" && outdata[2, 4] == "0" && outdata[2, 6] == "0" && outdata[3, 4] == "0" && outdata[3, 5] == "0" && outdata[3, 6] == "0" && count < 8)) { outdata[2, 5] = "1"; count++; CC66.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void CC77_Click(object sender, EventArgs e)
        {
            if (outdata[2, 6] == "0" && (outdata[1, 5] == "0" && outdata[1, 6] == "0" && outdata[1, 7] == "0" && outdata[2, 5] == "0" && outdata[2, 7] == "0" && outdata[3, 5] == "0" && outdata[3, 6] == "0" && outdata[3, 7] == "0" && count < 8)) { outdata[2, 6] = "1"; count++; CC77.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void CC88_Click(object sender, EventArgs e)
        {
            if (outdata[2, 7] == "0" && (outdata[1, 6] == "0" && outdata[1, 7] == "0" && outdata[2, 6] == "0" && outdata[3, 6] == "0" && outdata[3, 7] == "0" && count < 8)) { outdata[2, 7] = "1"; count++; CC88.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void DD11_Click(object sender, EventArgs e)
        {
            if (outdata[3, 0] == "0" && (outdata[2, 0] == "0" && outdata[2, 1] == "0" && outdata[3, 1] == "0" && outdata[4, 0] == "0" && outdata[4, 1] == "0" && count < 8)) { outdata[3, 0] = "1"; count++; DD11.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void DD22_Click(object sender, EventArgs e)
        {
            if (outdata[3, 1] == "0" && (outdata[2, 0] == "0" && outdata[2, 1] == "0" && outdata[2, 2] == "0" && outdata[3, 0] == "0" && outdata[3, 2] == "0" && outdata[4, 0] == "0" && outdata[4, 1] == "0" && outdata[4, 2] == "0" && count < 8)) { outdata[3, 1] = "1"; count++; DD22.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void DD33_Click(object sender, EventArgs e)
        {
            if (outdata[3, 2] == "0" && (outdata[2, 1] == "0" && outdata[2, 2] == "0" && outdata[2, 3] == "0" && outdata[3, 1] == "0" && outdata[3, 3] == "0" && outdata[4, 1] == "0" && outdata[4, 2] == "0" && outdata[4, 3] == "0" && count < 8)) { outdata[3, 2] = "1"; count++; DD33.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void DD44_Click(object sender, EventArgs e)
        {
            if (outdata[3, 3] == "0" && (outdata[2, 2] == "0" && outdata[2, 3] == "0" && outdata[2, 4] == "0" && outdata[3, 2] == "0" && outdata[3, 4] == "0" && outdata[4, 2] == "0" && outdata[4, 3] == "0" && outdata[4, 4] == "0" && count < 8)) { outdata[3, 3] = "1"; count++; DD44.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void DD55_Click(object sender, EventArgs e)
        {
            if (outdata[3, 4] == "0" && (outdata[2, 3] == "0" && outdata[2, 4] == "0" && outdata[2, 5] == "0" && outdata[3, 3] == "0" && outdata[3, 5] == "0" && outdata[4, 3] == "0" && outdata[4, 4] == "0" && outdata[4, 5] == "0" && count < 8)) { outdata[3, 4] = "1"; count++; DD55.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void DD66_Click(object sender, EventArgs e)
        {
            if (outdata[3, 5] == "0" && (outdata[2, 4] == "0" && outdata[2, 5] == "0" && outdata[2, 6] == "0" && outdata[3, 4] == "0" && outdata[3, 6] == "0" && outdata[4, 4] == "0" && outdata[4, 5] == "0" && outdata[4, 6] == "0" && count < 8)) { outdata[3, 5] = "1"; count++; DD66.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void DD77_Click(object sender, EventArgs e)
        {
            if (outdata[3, 6] == "0" && (outdata[2, 5] == "0" && outdata[2, 6] == "0" && outdata[2, 7] == "0" && outdata[3, 5] == "0" && outdata[3, 7] == "0" && outdata[4, 5] == "0" && outdata[4, 6] == "0" && outdata[4, 7] == "0" && count < 8)) { outdata[3, 6] = "1"; count++; DD77.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void DD88_Click(object sender, EventArgs e)
        {
            if (outdata[3, 7] == "0" && (outdata[2, 6] == "0" && outdata[2, 7] == "0" && outdata[3, 6] == "0" && outdata[4, 6] == "0" && outdata[4, 7] == "0" && count < 8)) { outdata[3, 7] = "1"; count++; DD88.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void EE11_Click(object sender, EventArgs e)
        {
            if (outdata[4, 0] == "0" && (outdata[3, 0] == "0" && outdata[3, 1] == "0" && outdata[4, 1] == "0" && outdata[5, 0] == "0" && outdata[5, 1] == "0" && count < 8)) { outdata[4, 0] = "1"; count++; EE11.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void EE22_Click(object sender, EventArgs e)
        {
            if (outdata[4, 1] == "0" && (outdata[3, 0] == "0" && outdata[3, 1] == "0" && outdata[3, 2] == "0" && outdata[4, 0] == "0" && outdata[4, 2] == "0" && outdata[5, 0] == "0" && outdata[5, 1] == "0" && outdata[5, 2] == "0" && count < 8)) { outdata[4, 1] = "1"; count++; EE22.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void EE33_Click(object sender, EventArgs e)
        {
            if (outdata[4, 2] == "0" && (outdata[3, 1] == "0" && outdata[3, 2] == "0" && outdata[3, 3] == "0" && outdata[4, 1] == "0" && outdata[4, 3] == "0" && outdata[5, 1] == "0" && outdata[5, 2] == "0" && outdata[5, 3] == "0" && count < 8)) { outdata[4, 2] = "1"; count++; EE33.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void EE44_Click(object sender, EventArgs e)
        {
            if (outdata[4, 3] == "0" && (outdata[3, 2] == "0" && outdata[3, 3] == "0" && outdata[3, 4] == "0" && outdata[4, 2] == "0" && outdata[4, 4] == "0" && outdata[5, 2] == "0" && outdata[5, 3] == "0" && outdata[5, 4] == "0" && count < 8)) { outdata[4, 3] = "1"; count++; EE44.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void EE55_Click(object sender, EventArgs e)
        {
            if (outdata[4, 4] == "0" && (outdata[3, 3] == "0" && outdata[3, 4] == "0" && outdata[3, 5] == "0" && outdata[4, 3] == "0" && outdata[4, 5] == "0" && outdata[5, 3] == "0" && outdata[5, 4] == "0" && outdata[5, 5] == "0" && count < 8)) { outdata[4, 4] = "1"; count++; EE55.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void EE66_Click(object sender, EventArgs e)
        {
            if (outdata[4, 5] == "0" && (outdata[3, 4] == "0" && outdata[3, 5] == "0" && outdata[3, 6] == "0" && outdata[4, 4] == "0" && outdata[4, 6] == "0" && outdata[5, 4] == "0" && outdata[5, 5] == "0" && outdata[5, 6] == "0" && count < 8)) { outdata[4, 5] = "1"; count++; EE66.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void EE77_Click(object sender, EventArgs e)
        {
            if (outdata[4, 6] == "0" && (outdata[3, 5] == "0" && outdata[3, 6] == "0" && outdata[3, 7] == "0" && outdata[4, 5] == "0" && outdata[4, 7] == "0" && outdata[5, 5] == "0" && outdata[5, 6] == "0" && outdata[5, 7] == "0" && count < 8)) { outdata[4, 6] = "1"; count++; EE77.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void EE88_Click(object sender, EventArgs e)
        {
            if (outdata[4, 7] == "0" && (outdata[3, 6] == "0" && outdata[3, 7] == "0" && outdata[4, 6] == "0" && outdata[5, 6] == "0" && outdata[5, 7] == "0" && count < 8)) { outdata[4, 7] = "1"; count++; EE88.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void FF11_Click(object sender, EventArgs e)
        {
            if (outdata[5, 0] == "0" && (outdata[4, 0] == "0" && outdata[4, 1] == "0" && outdata[5, 1] == "0" && outdata[6, 0] == "0" && outdata[6, 1] == "0" && count < 8)) { outdata[5, 0] = "1"; count++; FF11.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void FF22_Click(object sender, EventArgs e)
        {
            if (outdata[5, 1] == "0" && (outdata[4, 0] == "0" && outdata[4, 1] == "0" && outdata[4, 2] == "0" && outdata[5, 0] == "0" && outdata[5, 2] == "0" && outdata[6, 0] == "0" && outdata[6, 1] == "0" && outdata[6, 2] == "0" && count < 8)) { outdata[5, 1] = "1"; count++; FF22.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void FF33_Click(object sender, EventArgs e)
        {
            if (outdata[5, 2] == "0" && (outdata[4, 1] == "0" && outdata[4, 2] == "0" && outdata[4, 3] == "0" && outdata[5, 1] == "0" && outdata[5, 3] == "0" && outdata[6, 1] == "0" && outdata[6, 2] == "0" && outdata[6, 3] == "0" && count < 8)) { outdata[5, 2] = "1"; count++; FF33.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void FF44_Click(object sender, EventArgs e)
        {
            if (outdata[5, 3] == "0" && (outdata[4, 2] == "0" && outdata[4, 3] == "0" && outdata[4, 4] == "0" && outdata[5, 2] == "0" && outdata[5, 4] == "0" && outdata[6, 2] == "0" && outdata[6, 3] == "0" && outdata[6, 4] == "0" && count < 8)) { outdata[5, 3] = "1"; count++; FF44.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void FF55_Click(object sender, EventArgs e)
        {
            if (outdata[5, 4] == "0" && (outdata[4, 3] == "0" && outdata[4, 4] == "0" && outdata[4, 5] == "0" && outdata[5, 3] == "0" && outdata[5, 5] == "0" && outdata[6, 3] == "0" && outdata[6, 4] == "0" && outdata[6, 5] == "0" && count < 8)) { outdata[5, 4] = "1"; count++; FF55.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void FF66_Click(object sender, EventArgs e)
        {
            if (outdata[5, 5] == "0" && (outdata[4, 4] == "0" && outdata[4, 5] == "0" && outdata[4, 6] == "0" && outdata[5, 4] == "0" && outdata[5, 6] == "0" && outdata[6, 4] == "0" && outdata[6, 5] == "0" && outdata[6, 6] == "0" && count < 8)) { outdata[5, 5] = "1"; count++; FF66.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void FF77_Click(object sender, EventArgs e)
        {
            if (outdata[5, 6] == "0" && (outdata[4, 5] == "0" && outdata[4, 6] == "0" && outdata[4, 7] == "0" && outdata[5, 5] == "0" && outdata[5, 7] == "0" && outdata[6, 5] == "0" && outdata[6, 6] == "0" && outdata[6, 7] == "0" && count < 8)) { outdata[5, 6] = "1"; count++; FF77.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void FF88_Click(object sender, EventArgs e)
        {
            if (outdata[5, 7] == "0" && (outdata[4, 6] == "0" && outdata[4, 7] == "0" && outdata[5, 6] == "0" && outdata[6, 6] == "0" && outdata[6, 7] == "0" && count < 8)) { outdata[5, 7] = "1"; count++; FF88.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void GG11_Click(object sender, EventArgs e)
        {
            if (outdata[6, 0] == "0" && (outdata[5, 0] == "0" && outdata[5, 1] == "0" && outdata[6, 1] == "0" && outdata[7, 0] == "0" && outdata[7, 1] == "0" && count < 8)) { outdata[6, 0] = "1"; count++; GG11.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void GG22_Click(object sender, EventArgs e)
        {
            if (outdata[6, 1] == "0" && (outdata[5, 0] == "0" && outdata[5, 1] == "0" && outdata[5, 2] == "0" && outdata[6, 0] == "0" && outdata[6, 2] == "0" && outdata[7, 0] == "0" && outdata[7, 1] == "0" && outdata[7, 2] == "0" && count < 8)) { outdata[6, 1] = "1"; count++; GG22.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void GG33_Click(object sender, EventArgs e)
        {
            if (outdata[6, 2] == "0" && (outdata[5, 1] == "0" && outdata[5, 2] == "0" && outdata[5, 3] == "0" && outdata[6, 1] == "0" && outdata[6, 3] == "0" && outdata[7, 1] == "0" && outdata[7, 2] == "0" && outdata[7, 3] == "0" && count < 8)) { outdata[6, 2] = "1"; count++; GG33.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void GG44_Click(object sender, EventArgs e)
        {
            if (outdata[6, 3] == "0" && (outdata[5, 2] == "0" && outdata[5, 3] == "0" && outdata[5, 4] == "0" && outdata[6, 2] == "0" && outdata[6, 4] == "0" && outdata[7, 2] == "0" && outdata[7, 3] == "0" && outdata[7, 4] == "0" && count < 8)) { outdata[6, 3] = "1"; count++; GG44.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void GG55_Click(object sender, EventArgs e)
        {
            if (outdata[6, 4] == "0" && (outdata[5, 3] == "0" && outdata[5, 4] == "0" && outdata[5, 5] == "0" && outdata[6, 3] == "0" && outdata[6, 5] == "0" && outdata[7, 3] == "0" && outdata[7, 4] == "0" && outdata[7, 5] == "0" && count < 8)) { outdata[6, 4] = "1"; count++; GG55.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void G_Click(object sender, EventArgs e)
        {
            if (outdata[6, 5] == "0" && (outdata[5, 4] == "0" && outdata[5, 5] == "0" && outdata[5, 6] == "0" && outdata[6, 4] == "0" && outdata[6, 6] == "0" && outdata[7, 4] == "0" && outdata[7, 5] == "0" && outdata[7, 6] == "0" && count < 8)) { outdata[6, 5] = "1"; count++; G.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void GG77_Click(object sender, EventArgs e)
        {
            if (outdata[6, 6] == "0" && (outdata[5, 5] == "0" && outdata[5, 6] == "0" && outdata[5, 7] == "0" && outdata[6, 5] == "0" && outdata[6, 7] == "0" && outdata[7, 5] == "0" && outdata[7, 6] == "0" && outdata[7, 7] == "0" && count < 8)) { outdata[6, 6] = "1"; count++; GG77.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void GG88_Click(object sender, EventArgs e)
        {
            if (outdata[6, 7] == "0" && (outdata[5, 6] == "0" && outdata[5, 7] == "0" && outdata[6, 6] == "0" && outdata[7, 6] == "0" && outdata[7, 7] == "0" && count < 8)) { outdata[6, 7] = "1"; count++; GG88.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void HH11_Click(object sender, EventArgs e)
        {
            if (outdata[7, 0] == "0" && (outdata[6, 0] == "0" && outdata[6, 1] == "0" && outdata[7, 1] == "0"  && count < 8)) { outdata[7, 0] = "1"; count++; HH11.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void HH22_Click(object sender, EventArgs e)
        {
            if (outdata[7, 1] == "0" && (outdata[6, 0] == "0" && outdata[6, 1] == "0" && outdata[6, 2] == "0" && outdata[7, 0] == "0" && outdata[7, 2] == "0" && count < 8)) { outdata[7, 1] = "1"; count++; HH22.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void HH33_Click(object sender, EventArgs e)
        {
            if (outdata[7, 2] == "0" && (outdata[6, 1] == "0" && outdata[6, 2] == "0" && outdata[6, 3] == "0" && outdata[7, 1] == "0" && outdata[7, 3] == "0" && count < 8)) { outdata[7, 2] = "1"; count++; HH33.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void HH44_Click(object sender, EventArgs e)
        {
            if (outdata[7, 3] == "0" && (outdata[6, 2] == "0" && outdata[6, 3] == "0" && outdata[6, 4] == "0" && outdata[7, 2] == "0" && outdata[7, 4] == "0" && count < 8)) { outdata[7, 3] = "1"; count++; HH44.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void HH55_Click(object sender, EventArgs e)
        {
            if (outdata[7, 4] == "0" && (outdata[6, 3] == "0" && outdata[6, 4] == "0" && outdata[6, 5] == "0" && outdata[7, 3] == "0" && outdata[7, 5] == "0" && count < 8)) { outdata[7, 4] = "1"; count++; HH55.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void HH66_Click(object sender, EventArgs e)
        {
            if (outdata[7, 5] == "0" && (outdata[6, 4] == "0" && outdata[6, 5] == "0" && outdata[6, 6] == "0" && outdata[7, 4] == "0" && outdata[7, 6] == "0" && count < 8)) { outdata[7, 5] = "1"; count++; HH66.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }
        

        private void HH77_Click(object sender, EventArgs e)
        {
            if (outdata[7, 6] == "0" && (outdata[6, 5] == "0" && outdata[6, 6] == "0" && outdata[6, 7] == "0" && outdata[7, 5] == "0" && outdata[7, 7] == "0" && count < 8)) { outdata[7, 6] = "1"; count++; HH77.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }

        private void HH88_Click(object sender, EventArgs e)
        {
            if (outdata[7, 7] == "0" && (outdata[6, 6] == "0" && outdata[6, 7] == "0" && outdata[7, 6] == "0" && count < 8)) { outdata[7, 7] = "1"; count++; HH88.Text = "O"; }
            else MessageBox.Show("Nie możesz to umieścić już statku!");
        }        
            
    }
}
