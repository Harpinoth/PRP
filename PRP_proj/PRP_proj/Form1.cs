using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRP_proj
{
          public partial class Form1 : Form
          {
                    //public static string[] myPort = System.IO.Ports.SerialPort.GetPortNames();
                    public static string[] myPort = {"TestCOM1", "TestCOM2"}; // do testów
                    public static float krok = (float)0.1;

                    public Form1()
                    {
                              InitializeComponent();
                    }

                    private void Form1_Load(object sender, EventArgs e)
                    {
                              button2.Enabled = false;
                              tabPage2.Enabled = false;
                              tabPage3.Enabled = false;
                              tabPage4.Enabled = false;

                              for (int i = 0; i < myPort.Length; i++)
                              {
                                        porty_combo.Items.Add(myPort[i]);
                              }
                              porty_combo.Text = myPort[0];
                    }
                    private void button1_Click(object sender, EventArgs e)
                    {
                              serialPort1.PortName = porty_combo.Text;
                              serialPort1.Open();
                              button2.Enabled = true;
                              tabPage2.Enabled = true;
                              tabPage3.Enabled = true;
                              tabPage4.Enabled = true;
                    }



                    private void button2_Click(object sender, EventArgs e)
                    {
                              serialPort1.Close();
                              button2.Enabled = false;
                              tabPage2.Enabled = false;
                              tabPage3.Enabled = false;
                              tabPage4.Enabled = false;
                    }

                    private void wyslij_komenda_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format(wlasna_komenda.Text + "\r\n"));
                    }

                    private void podstawa_plus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 1," + krok + "\r\n")); // potem można zrobic stepa i speed

                    }

                    private void podstawa_minus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 1,-" + krok + "\r\n")); 
                    }

                    private void korpus_plus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 2," + krok + "\r\n"));
                    }

                    private void korpus_minus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 2,-" + krok + "\r\n"));
                    }

                    private void ramd_plus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 3," + krok + "\r\n"));
                    }

                    private void ramd_minus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 3,-" + krok + "\r\n"));
                    }

                    private void ramg_plus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 4," + krok + "\r\n"));
                    }

                    private void ramg_minus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 4,-" + krok + "\r\n"));
                    }

                    private void przegub_plus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 5," + krok + "\r\n"));
                    }

                    private void przegub_minus_Click(object sender, EventArgs e)
                    {
                              serialPort1.Write(String.Format("DJ 5,-" + krok + "\r\n"));
                    }

                    private void trackBar1_Scroll(object sender, EventArgs e)
                    {
                              wart_krok.Text = Convert.ToString(trackBar1.Value/10);
                    }

                    private void trackBar2_Scroll(object sender, EventArgs e)
                    {
                              wart_pred.Text = Convert.ToString(trackBar2.Value);
                    }

                    private void ppotw_Click(object sender, EventArgs e)
                    {
                              krok = (float)trackBar1.Value/10;
                              serialPort1.Write(String.Format("SP " + wart_pred.Text + "\r\n"));
                    }

          }
}
