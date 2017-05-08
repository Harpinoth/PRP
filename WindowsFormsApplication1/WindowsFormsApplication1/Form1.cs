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
        public string index, com, flaga3="0",p="p",znikaj;
        public string[] przepisywacz;
        public string[,] indata = new string [8,8]{ {"0","0","0","0","0","0","0","0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" } };
        public string[,] outdata = new string[8,8]{ {"0","0","0","0","0","0","0","0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0", "0" } };
        public bool flaga1=false, flaga2 = false, readyclicked=true, connclicked = true,iwasnthere=true,gra2=false,kolejnosc=false;
        public int status=0,count=0,win=0,liczmitu=0,ignor=0; 
        
        // Przysłanie danych w trakcie gry      
        
        
        private void A1_Click(object sender, EventArgs e)
        {
            if (indata[0, 0] == "1") { A1.Text = "X"; win++; }
            else A1.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("1");
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (indata[0, 1] == "1") { A2.Text = "X"; win++; }
            else A2.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("2");
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (indata[0, 2] == "1") { A3.Text = "X"; win++; }
            else A3.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("3");
        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (indata[0, 3] == "1") { A4.Text = "X"; win++; }
            else A4.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("4");
        }

        private void A5_Click(object sender, EventArgs e)
        {
            if (indata[0, 4] == "1") { A5.Text = "X"; win++; }
            else A5.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("5");
        }

        private void A6_Click(object sender, EventArgs e)
        {
            if (indata[0, 5] == "1") { A6.Text = "X"; win++; }
            else A6.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("6");
        }

        private void A7_Click(object sender, EventArgs e)
        {
            if (indata[0, 6] == "1") { A7.Text = "X"; win++; }
            else A7.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("7");
        }

        private void A8_Click(object sender, EventArgs e)
        {
            if (indata[0, 7] == "1") { A8.Text = "X"; win++; }
            else A8.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("8");
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (indata[1, 0] == "1") { B1.Text = "X"; win++; }
            else B1.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("9");
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (indata[1, 1] == "1") { B2.Text = "X"; win++; }
            else B2.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("10");
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (indata[1, 2] == "1") { B3.Text = "X"; win++; }
            else B3.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("11");
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (indata[1, 3] == "1") { B4.Text = "X"; win++; }
            else B4.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("12");
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (indata[1, 4] == "1") { B5.Text = "X"; win++; }
            else B5.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("13");
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (indata[1, 5] == "1") { B6.Text = "X"; win++; }
            else B6.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("14");
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (indata[1, 6] == "1") { B7.Text = "X"; win++; }
            else B7.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("15");
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (indata[1, 7] == "1") { B8.Text = "X"; win++; }
            else B8.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("16");
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (indata[2, 0] == "1") { C1.Text = "X"; win++; }
            else C1.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("17");
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (indata[2, 1] == "1") { C2.Text = "X"; win++; }
            else C2.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("18");
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (indata[2, 2] == "1") { C3.Text = "X"; win++; }
            else C3.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("19");
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if(indata[2, 3] == "1") { C4.Text = "X"; win++; }
            else C4.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("20");
        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (indata[2, 4] == "1") { C5.Text = "X"; win++; }
            else C5.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("21");
        }

        private void C6_Click(object sender, EventArgs e)
        {
            if (indata[2, 5] == "1") { C6.Text = "X"; win++; }
            else C6.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("22");
        }

        private void C7_Click(object sender, EventArgs e)
        {
            if (indata[2, 6] == "1") { C7.Text = "X"; win++; }
            else C7.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("23");
        }

        private void C8_Click(object sender, EventArgs e)
        {
            if (indata[2, 7] == "1") { C8.Text = "X"; win++; }
            else C8.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("24");
        }

        private void D1_Click(object sender, EventArgs e)
        {
            if (indata[3, 0] == "1") { D1.Text = "X"; win++; }
            else D1.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("25");
        }

        private void D2_Click(object sender, EventArgs e)
        {
            if (indata[3, 1] == "1") { D2.Text = "X"; win++; }
            else D2.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("26");
        }

        private void D3_Click(object sender, EventArgs e)
        {
            if (indata[3, 2] == "1") { D3.Text = "X"; win++; }
            else D3.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("27");
        }

        private void D4_Click(object sender, EventArgs e)
        {
            if (indata[3, 3] == "1") { D4.Text = "X"; win++; }
            else D4.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("28");
        }

        private void D5_Click(object sender, EventArgs e)
        {
            if (indata[3, 4] == "1") { D5.Text = "X"; win++; }
            else D5.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("29");

        }

        private void D6_Click(object sender, EventArgs e)
        {
            if (indata[3, 5] == "1") { D6.Text = "X"; win++; }
            else D6.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("30");
        }

        private void D7_Click(object sender, EventArgs e)
        {
            if (indata[3, 6] == "1") { D7.Text = "X"; win++; }
            else D7.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("31");
        }

        private void D8_Click(object sender, EventArgs e)
        {
            if (indata[3, 7] == "1") { D8.Text = "X"; win++; }
            else D8.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("32");

        }

        private void E1_Click(object sender, EventArgs e)
        {
            if (indata[4, 0] == "1") { E1.Text = "X"; win++; }
            else E1.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("33");
        }

        private void E2_Click(object sender, EventArgs e)
        {
            if (indata[4, 1] == "1") { E2.Text = "X"; win++; }
            else E2.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("34");
        }

        private void E3_Click(object sender, EventArgs e)
        {
            if (indata[4, 2] == "1") { E3.Text = "X"; win++; }
            else E3.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("35");
        }

        private void E4_Click(object sender, EventArgs e)
        {
            if (indata[4, 3] == "1") { E4.Text = "X"; win++; }
            else E4.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("36");
        }

        private void E5_Click(object sender, EventArgs e)
        {
            if (indata[4, 4] == "1") { E5.Text = "X"; win++; }
            else E5.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("37");
        }

        private void E6_Click(object sender, EventArgs e)
        {
            if (indata[4, 5] == "1") { E6.Text = "X"; win++; }
            else E6.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("38");
        }

        private void E7_Click(object sender, EventArgs e)
        {
            if (indata[4, 6] == "1") { E7.Text = "X"; win++; }
            else E7.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("39");
        }

        private void E8_Click(object sender, EventArgs e)
        {
            if (indata[4, 7] == "1") { E8.Text = "X"; win++; }
            else E8.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("40");
        }

        private void F1_Click(object sender, EventArgs e)
        {
            if (indata[5, 0] == "1") { F1.Text = "X"; win++; }
            else F1.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("41");
        }

        private void F2_Click(object sender, EventArgs e)
        {
            if (indata[5, 1] == "1") { F2.Text = "X"; win++; }
            else F2.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("42");
        }

        private void F3_Click(object sender, EventArgs e)
        {
            if (indata[5, 2] == "1") { F3.Text = "X"; win++; }
            else F3.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("43");
        }

        private void F4_Click(object sender, EventArgs e)
        {
            if (indata[5, 3] == "1") { F4.Text = "X"; win++; }
            else F4.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("44");
        }

        private void F5_Click(object sender, EventArgs e)
        {
            if (indata[5, 4] == "1") { F5.Text = "X"; win++; }
            else F5.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("45");
        }

        private void F6_Click(object sender, EventArgs e)
        {
            if (indata[5, 5] == "1") { F6.Text = "X"; win++; }
            else F6.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("46");
        }

        private void F7_Click(object sender, EventArgs e)
        {
            if (indata[5, 6] == "1") { F7.Text = "X"; win++; }
            else F7.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("47");
        }

        private void F8_Click(object sender, EventArgs e)
        {
            if (indata[5, 7] == "1") { F8.Text = "X"; win++; }
            else F8.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("48");
        }

        private void G1_Click(object sender, EventArgs e)
        {
            if (indata[6, 0] == "1") { G1.Text = "X"; win++; }
            else G1.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("49");
        }

        private void G2_Click(object sender, EventArgs e)
        {
            if(indata[6, 1] == "1") { G2.Text = "X"; win++; }
            else G2.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("50");
        }

        private void G3_Click(object sender, EventArgs e)
        {
            if (indata[6, 2] == "1") { G3.Text = "X"; win++; }
            else G3.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("51");
        }

        private void G4_Click(object sender, EventArgs e)
        {
            if (indata[6, 3] == "1") { G4.Text = "X"; win++; }
            else G4.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("52");
        }

        private void G5_Click(object sender, EventArgs e)
        {
            if (indata[6, 4] == "1") { G5.Text = "X"; win++; }
            else G5.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("53");
        }

        private void G6_Click(object sender, EventArgs e)
        {
            if (indata[6, 5] == "1") { G6.Text = "X"; win++; }
            else G6.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("54");
        }

        private void G7_Click(object sender, EventArgs e)
        {
            if (indata[6, 6] == "1") { G7.Text = "X"; win++; }
            else G7.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("55");
        }

        private void G8_Click(object sender, EventArgs e)
        {
            if (indata[6, 7] == "1") { G8.Text = "X"; win++; }
            else G8.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("56");
        }

        private void H1_Click(object sender, EventArgs e)
        {
            if (indata[7, 0] == "1") { H1.Text = "X"; win++; }
            else H1.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("57");
        }

        private void H2_Click(object sender, EventArgs e)
        {
            if(indata[7, 1] == "1") { H2.Text = "X"; win++; }
            else H2.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("58");
        }

        private void H3_Click(object sender, EventArgs e)
        {
            if (indata[7, 2] == "1") { H3.Text = "X"; win++; }
            else H3.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("59");
        }

        private void H4_Click(object sender, EventArgs e)
        {
            if (indata[7, 3] == "1") { H4.Text = "X"; win++; }
            else H4.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("60");
        }

        private void H5_Click(object sender, EventArgs e)
        {
            if (indata[7, 4] == "1") { H5.Text = "X"; win++; }
            else H5.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("61");
        }

        private void H6_Click(object sender, EventArgs e)
        {
            if (indata[7, 5] == "1") { H6.Text = "X"; win++; }
            else H6.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("62");
        }

        private void H7_Click(object sender, EventArgs e)
        {
            if (indata[7, 6] == "1") { H7.Text = "X"; win++; }
            else H7.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("63");
        }

        private void H8_Click(object sender, EventArgs e)
        {
            if (indata[7, 7] == "1") { H8.Text = "X"; win++; }
            else H8.Text = "pudło";
            if (win == 8) { port.Write("80"); MessageBox.Show("Wygrałeś"); }
            else port.Write("64");
        }

        // Aktualizowanie moich statków

        public void invokemaster(string a)
        {
            switch(a)
            {
                case "1":
                    if (outdata[0, 0] == "1") AA11.Invoke(new Action(delegate () { AA11.Text = "X"; }));
                    else AA11.Invoke(new Action(delegate () { AA11.Text = "pudło"; }));
                    break;
                case "2":
                    if (outdata[0, 1] == "1") AA22.Invoke(new Action(delegate () { AA22.Text = "X"; }));
                    else AA22.Invoke(new Action(delegate () { AA22.Text = "pudło"; }));
                    break;
                case "3":
                    if (outdata[0, 2] == "1") AA33.Invoke(new Action(delegate () { AA33.Text = "X"; }));
                    else AA33.Invoke(new Action(delegate () { AA33.Text = "pudło"; }));
                    break;
                case "4":
                    if (outdata[0, 3] == "1") AA44.Invoke(new Action(delegate () { AA44.Text = "X"; }));
                    else AA44.Invoke(new Action(delegate () { AA44.Text = "pudło"; }));
                    break;
                case "5":
                    if (outdata[0, 4] == "1") AA55.Invoke(new Action(delegate () { AA55.Text = "X"; }));
                    else AA55.Invoke(new Action(delegate () { AA55.Text = "pudło"; }));
                    break;
                case "6":
                    if (outdata[0, 5] == "1") AA66.Invoke(new Action(delegate () { AA66.Text = "X"; }));
                    else AA66.Invoke(new Action(delegate () { AA66.Text = "pudło"; }));
                    break;
                case "7":
                    if (outdata[0, 6] == "1") AA77.Invoke(new Action(delegate () { AA77.Text = "X"; }));
                    else AA77.Invoke(new Action(delegate () { AA77.Text = "pudło"; }));
                    break;
                case "8":
                    if (outdata[0, 7] == "1") AA88.Invoke(new Action(delegate () { AA88.Text = "X"; }));
                    else AA88.Invoke(new Action(delegate () { AA88.Text = "pudło"; }));
                    break;
                case "9":
                    if (outdata[1, 0] == "1") BB11.Invoke(new Action(delegate () { BB11.Text = "X"; }));
                    else BB11.Invoke(new Action(delegate () { BB11.Text = "pudło"; }));
                    break;
                case "10":
                    if (outdata[1, 1] == "1") B.Invoke(new Action(delegate () { B.Text = "X"; }));
                    else B.Invoke(new Action(delegate () { B.Text = "pudło"; }));
                    break;
                case "11":
                    if (outdata[1, 2] == "1") B33.Invoke(new Action(delegate () { B33.Text = "X"; }));
                    else B33.Invoke(new Action(delegate () { B33.Text = "pudło"; }));
                    break;
                case "12":
                    if (outdata[1, 3] == "1") BB44.Invoke(new Action(delegate () { BB44.Text = "X"; }));
                    else BB44.Invoke(new Action(delegate () { BB44.Text = "pudło"; }));
                    break;
                case "13":
                    if (outdata[1, 4] == "1") BB55.Invoke(new Action(delegate () { BB55.Text = "X"; }));
                    else BB55.Invoke(new Action(delegate () { BB55.Text = "pudło"; }));
                    break;
                case "14":
                    if (outdata[1, 5] == "1") BB66.Invoke(new Action(delegate () { BB66.Text = "X"; }));
                    else BB66.Invoke(new Action(delegate () { BB66.Text = "pudło"; }));
                    break;
                case "15":
                    if (outdata[1, 6] == "1") BB77.Invoke(new Action(delegate () { BB77.Text = "X"; }));
                    else BB77.Invoke(new Action(delegate () { BB77.Text = "pudło"; }));
                    break;
                case "16":
                    if (outdata[1, 7] == "1") BB88.Invoke(new Action(delegate () { BB88.Text = "X"; }));
                    else BB88.Invoke(new Action(delegate () { BB88.Text = "pudło"; }));
                    break;
                case "17":
                    if (outdata[2, 0] == "1") CC11.Invoke(new Action(delegate () { CC11.Text = "X"; }));
                    else CC11.Invoke(new Action(delegate () { CC11.Text = "pudło"; }));
                    break;
                case "18":
                    if (outdata[2, 1] == "1") CC22.Invoke(new Action(delegate () { CC22.Text = "X"; }));
                    else CC22.Invoke(new Action(delegate () { CC22.Text = "pudło"; }));
                    break;
                case "19":
                    if (outdata[2, 2] == "1") CC33.Invoke(new Action(delegate () { CC33.Text = "X"; }));
                    else CC33.Invoke(new Action(delegate () { CC33.Text = "pudło"; }));
                    break;
                case "20":
                    if (outdata[2, 3] == "1") CC44.Invoke(new Action(delegate () { CC44.Text = "X"; }));
                    else CC44.Invoke(new Action(delegate () { CC44.Text = "pudło"; }));
                    break;
                case "21":
                    if (outdata[2, 4] == "1") CC55.Invoke(new Action(delegate () { CC55.Text = "X"; }));
                    else CC55.Invoke(new Action(delegate () { CC55.Text = "pudło"; }));
                    break;
                case "22":
                    if (outdata[2, 5] == "1") CC66.Invoke(new Action(delegate () { CC66.Text = "X"; }));
                    else CC66.Invoke(new Action(delegate () { CC66.Text = "pudło"; }));
                    break;
                case "23":
                    if (outdata[2, 6] == "1") CC77.Invoke(new Action(delegate () { CC77.Text = "X"; }));
                    else CC77.Invoke(new Action(delegate () { CC77.Text = "pudło"; }));
                    break;
                case "24":
                    if (outdata[2, 7] == "1") CC88.Invoke(new Action(delegate () { CC88.Text = "X"; }));
                    else CC88.Invoke(new Action(delegate () { CC88.Text = "pudło"; }));
                    break;
                case "25":
                    if (outdata[3, 0] == "1") DD11.Invoke(new Action(delegate () { DD11.Text = "X"; }));
                    else DD11.Invoke(new Action(delegate () { DD11.Text = "pudło"; }));
                    break;
                case "26":
                    if (outdata[3, 1] == "1") DD22.Invoke(new Action(delegate () { DD22.Text = "X"; }));
                    else DD22.Invoke(new Action(delegate () { DD22.Text = "pudło"; }));
                    break;
                case "27":
                    if (outdata[3, 2] == "1") DD33.Invoke(new Action(delegate () { DD33.Text = "X"; }));
                    else DD33.Invoke(new Action(delegate () { DD33.Text = "pudło"; }));
                    break;
                case "28":
                    if (outdata[3, 3] == "1") DD44.Invoke(new Action(delegate () { DD44.Text = "X"; }));
                    else DD44.Invoke(new Action(delegate () { DD44.Text = "pudło"; }));
                    break;
                case "29":
                    if (outdata[3, 4] == "1") DD55.Invoke(new Action(delegate () { DD55.Text = "X"; }));
                    else DD55.Invoke(new Action(delegate () { DD55.Text = "pudło"; }));
                    break;
                case "30":
                    if (outdata[3, 5] == "1") DD66.Invoke(new Action(delegate () { DD66.Text = "X"; }));
                    else DD66.Invoke(new Action(delegate () { DD66.Text = "pudło"; }));
                    break;
                case "31":
                    if (outdata[3, 6] == "1") DD77.Invoke(new Action(delegate () { DD77.Text = "X"; }));
                    else DD77.Invoke(new Action(delegate () { DD77.Text = "pudło"; }));
                    break;
                case "32":
                    if (outdata[3, 7] == "1") DD88.Invoke(new Action(delegate () { DD88.Text = "X"; }));
                    else DD88.Invoke(new Action(delegate () { DD88.Text = "pudło"; }));
                    break;
                case "33":
                    if (outdata[4, 0] == "1") EE11.Invoke(new Action(delegate () { EE11.Text = "X"; }));
                    else EE11.Invoke(new Action(delegate () { EE11.Text = "pudło"; }));
                    break;
                case "34":
                    if (outdata[4, 1] == "1") EE22.Invoke(new Action(delegate () { EE22.Text = "X"; }));
                    else EE22.Invoke(new Action(delegate () { EE22.Text = "pudło"; }));
                    break;
                case "35":
                    if (outdata[4, 2] == "1") EE33.Invoke(new Action(delegate () { EE33.Text = "X"; }));
                    else EE33.Invoke(new Action(delegate () { EE33.Text = "pudło"; }));
                    break;
                case "36":
                    if (outdata[4, 3] == "1") EE44.Invoke(new Action(delegate () { EE44.Text = "X"; }));
                    else EE44.Invoke(new Action(delegate () { EE44.Text = "pudło"; }));
                    break;
                case "37":
                    if (outdata[4, 4] == "1") EE55.Invoke(new Action(delegate () { EE55.Text = "X"; }));
                    else EE55.Invoke(new Action(delegate () { EE55.Text = "pudło"; }));
                    break;
                case "38":
                    if (outdata[4, 5] == "1") EE66.Invoke(new Action(delegate () { EE66.Text = "X"; }));
                    else EE66.Invoke(new Action(delegate () { EE66.Text = "pudło"; }));
                    break;
                case "39":
                    if (outdata[4, 6] == "1") EE77.Invoke(new Action(delegate () { EE77.Text = "X"; }));
                    else EE77.Invoke(new Action(delegate () { EE77.Text = "pudło"; }));
                    break;
                case "40":
                    if (outdata[4, 7] == "1") EE88.Invoke(new Action(delegate () { EE88.Text = "X"; }));
                    else EE88.Invoke(new Action(delegate () { EE88.Text = "pudło"; }));
                    break;
                case "41":
                    if (outdata[5, 0] == "1") FF11.Invoke(new Action(delegate () { FF11.Text = "X"; }));
                    else FF11.Invoke(new Action(delegate () { FF11.Text = "pudło"; }));
                    break;
                case "42":
                    if (outdata[5, 1] == "1") FF22.Invoke(new Action(delegate () { FF22.Text = "X"; }));
                    else FF22.Invoke(new Action(delegate () { FF22.Text = "pudło"; }));
                    break;
                case "43":
                    if (outdata[5, 2] == "1") FF33.Invoke(new Action(delegate () { FF33.Text = "X"; }));
                    else FF33.Invoke(new Action(delegate () { FF33.Text = "pudło"; }));
                    break;
                case "44":
                    if (outdata[5, 3] == "1") FF44.Invoke(new Action(delegate () { FF44.Text = "X"; }));
                    else FF44.Invoke(new Action(delegate () { FF44.Text = "pudło"; }));
                    break;
                case "45":
                    if (outdata[5, 4] == "1") FF55.Invoke(new Action(delegate () { FF55.Text = "X"; }));
                    else FF55.Invoke(new Action(delegate () { FF55.Text = "pudło"; }));
                    break;
                case "46":
                    if (outdata[5, 5] == "1") FF66.Invoke(new Action(delegate () { FF66.Text = "X"; }));
                    else FF66.Invoke(new Action(delegate () { FF66.Text = "pudło"; }));
                    break;
                case "47":
                    if (outdata[5, 6] == "1") FF77.Invoke(new Action(delegate () { FF77.Text = "X"; }));
                    else FF77.Invoke(new Action(delegate () { FF77.Text = "pudło"; }));
                    break;
                case "48":
                    if (outdata[5, 7] == "1") FF88.Invoke(new Action(delegate () { FF88.Text = "X"; }));
                    else FF88.Invoke(new Action(delegate () { FF88.Text = "pudło"; }));
                    break;
                case "49":
                    if (outdata[6, 0] == "1") GG11.Invoke(new Action(delegate () { GG11.Text = "X"; }));
                    else GG11.Invoke(new Action(delegate () { GG11.Text = "pudło"; }));
                    break;
                case "50":
                    if (outdata[6, 1] == "1") GG22.Invoke(new Action(delegate () { GG22.Text = "X"; }));
                    else GG22.Invoke(new Action(delegate () { GG22.Text = "pudło"; }));
                    break;
                case "51":
                    if (outdata[6, 2] == "1") GG33.Invoke(new Action(delegate () { GG33.Text = "X"; }));
                    else GG33.Invoke(new Action(delegate () { GG33.Text = "pudło"; }));
                    break;
                case "52":
                    if (outdata[6, 3] == "1") GG44.Invoke(new Action(delegate () { GG44.Text = "X"; }));
                    else GG44.Invoke(new Action(delegate () { GG44.Text = "pudło"; }));
                    break;
                case "53":
                    if (outdata[6, 4] == "1") GG55.Invoke(new Action(delegate () { GG55.Text = "X"; }));
                    else GG55.Invoke(new Action(delegate () { GG55.Text = "pudło"; }));
                    break;
                case "54":
                    if (outdata[6, 5] == "1") G.Invoke(new Action(delegate () { G.Text = "X"; }));
                    else G.Invoke(new Action(delegate () { G.Text = "pudło"; }));
                    break;
                case "55":
                    if (outdata[6, 6] == "1") GG77.Invoke(new Action(delegate () { GG77.Text = "X"; }));
                    else GG77.Invoke(new Action(delegate () { GG77.Text = "pudło"; }));
                    break;
                case "56":
                    if (outdata[6, 7] == "1") GG88.Invoke(new Action(delegate () { GG88.Text = "X"; }));
                    else GG88.Invoke(new Action(delegate () { GG88.Text = "pudło"; }));
                    break;
                case "57":
                    if (outdata[7, 0] == "1") HH11.Invoke(new Action(delegate () { HH11.Text = "X"; }));
                    else HH11.Invoke(new Action(delegate () { HH11.Text = "pudło"; }));
                    break;
                case "58":
                    if (outdata[7, 1] == "1") HH22.Invoke(new Action(delegate () { HH22.Text = "X"; }));
                    else HH22.Invoke(new Action(delegate () { HH22.Text = "pudło"; }));
                    break;
                case "59":
                    if (outdata[7, 2] == "1") HH33.Invoke(new Action(delegate () { HH33.Text = "X"; }));
                    else HH33.Invoke(new Action(delegate () { HH33.Text = "pudło"; }));
                    break;
                case "60":
                    if (outdata[7, 3] == "1") HH44.Invoke(new Action(delegate () { HH44.Text = "X"; }));
                    else HH44.Invoke(new Action(delegate () { HH44.Text = "pudło"; }));
                    break;
                case "61":
                    if (outdata[7, 4] == "1") HH55.Invoke(new Action(delegate () { HH55.Text = "X"; }));
                    else HH55.Invoke(new Action(delegate () { HH55.Text = "pudło"; }));
                    break;
                case "62":
                    if (outdata[7, 5] == "1") HH66.Invoke(new Action(delegate () { HH66.Text = "X"; }));
                    else HH66.Invoke(new Action(delegate () { HH66.Text = "pudło"; }));
                    break;
                case "63":
                    if (outdata[7, 6] == "1") HH77.Invoke(new Action(delegate () { HH77.Text = "X"; }));
                    else HH77.Invoke(new Action(delegate () { HH77.Text = "pudło"; }));
                    break;
                case "64":
                    if (outdata[7, 7] == "1") HH88.Invoke(new Action(delegate () { HH88.Text = "X"; }));
                    else HH88.Invoke(new Action(delegate () { HH88.Text = "pudło"; }));
                    break;
                case "80":
                    MessageBox.Show("Przegrałeś!");
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
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            MessageBox.Show("Poczekaj na przeciwnika!");
            port.Write("Hello");
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (gra2==false)
            {
                port.Write("Hello");
                if (iwasnthere)
                {
                    if (com == "COM4") { flaga3 = "pierwszy"; kolejnosc = true; }
                    else flaga3 = "drugi";
                    if (flaga3 == "pierwszy") flaga1 = true;
                    else flaga2 = true;
                    status = 2;
                    iwasnthere = false;
                }
                Thread.Sleep(50);
                //if (kolejnosc) { port.Write("czekaj"); while (!(port.ReadExisting() == "synchro")) { port.Write("czekaj"); } }
                //else { port.Write("synchro"); while (!(port.ReadExisting() == "czekaj")) { port.Write("synchro"); } }
                while (status > 0)
                {
                    MessageBox.Show("Łączenie z przeciwnikiem!");
                    if (flaga1 && status > 0)
                    {
                        //while(com == "COM4" && liczmitu < 2) { znikaj = port.ReadExisting(); liczmitu++; }
                        while (liczmitu < 2 && com == "COM4")
                        {
                            znikaj = port.ReadExisting();
                            liczmitu++;
                        }
                        for (int i = 0; i <= 7; i++)
                        {
                            for (int j = 0; j <= 7; j++)
                            {                                                                                                                  
                                port.Write("OK");
                                Thread.Sleep(10);
                                indata[i, j] = port.ReadExisting();
                                Thread.Sleep(100);
                                //port.Write("STOP");
                                textBox2.Invoke(new Action(delegate () { textBox2.AppendText(indata[i, j]); }));
                                
                            }
                        }
                        flaga2 = true;
                        flaga1 = false;
                        status = status - 1;
                        Thread.Sleep(200);
                    }
                    if (flaga2 && status>0)
                    {                        
                        for (int i = 0; i <= 7; i++)
                        {
                            for (int j = 0; j <= 7; j++)
                            {
                                while (!(port.ReadExisting() == "OK")) {; }
                                //while (!(port.ReadExisting() == "STOP")) { port.Write(outdata[i, j]); } 
                                port.Write(outdata[i, j]);
                                textBox1.Invoke(new Action(delegate () { textBox1.AppendText(outdata[i, j]); }));                                
                            }
                        }
                        flaga1 = true;
                        flaga2 = false;
                        status = status - 1;
                        Thread.Sleep(200);
                    }
                }
                MessageBox.Show("Gra się zaczęła!");
                gra2=true;                
            }
            else
            {          
                index = port.ReadExisting();
                invokemaster(index);
               
            }                 
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
