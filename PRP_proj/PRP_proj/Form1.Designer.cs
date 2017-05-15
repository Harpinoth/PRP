namespace PRP_proj
{
          partial class Form1
          {
                    /// <summary>
                    /// Required designer variable.
                    /// </summary>
                    private System.ComponentModel.IContainer components = null;

                    /// <summary>
                    /// Clean up any resources being used.
                    /// </summary>
                    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
                    protected override void Dispose(bool disposing)
                    {
                              if (disposing && (components != null))
                              {
                                        components.Dispose();
                              }
                              base.Dispose(disposing);
                    }

                    #region Windows Form Designer generated code

                    /// <summary>
                    /// Required method for Designer support - do not modify
                    /// the contents of this method with the code editor.
                    /// </summary>
                    private void InitializeComponent()
                    {
                              this.components = new System.ComponentModel.Container();
                              this.tabControl1 = new System.Windows.Forms.TabControl();
                              this.tabPage1 = new System.Windows.Forms.TabPage();
                              this.label13 = new System.Windows.Forms.Label();
                              this.button2 = new System.Windows.Forms.Button();
                              this.button1 = new System.Windows.Forms.Button();
                              this.porty_combo = new System.Windows.Forms.ComboBox();
                              this.tabPage2 = new System.Windows.Forms.TabPage();
                              this.wyslij_komenda = new System.Windows.Forms.Button();
                              this.label3 = new System.Windows.Forms.Label();
                              this.label4 = new System.Windows.Forms.Label();
                              this.wlasna_komenda = new System.Windows.Forms.TextBox();
                              this.tabPage3 = new System.Windows.Forms.TabPage();
                              this.label8 = new System.Windows.Forms.Label();
                              this.przegub_minus = new System.Windows.Forms.Button();
                              this.przegub_plus = new System.Windows.Forms.Button();
                              this.label7 = new System.Windows.Forms.Label();
                              this.ramg_minus = new System.Windows.Forms.Button();
                              this.ramg_plus = new System.Windows.Forms.Button();
                              this.label6 = new System.Windows.Forms.Label();
                              this.ramd_minus = new System.Windows.Forms.Button();
                              this.ramd_plus = new System.Windows.Forms.Button();
                              this.label5 = new System.Windows.Forms.Label();
                              this.label2 = new System.Windows.Forms.Label();
                              this.label1 = new System.Windows.Forms.Label();
                              this.korpus_minus = new System.Windows.Forms.Button();
                              this.korpus_plus = new System.Windows.Forms.Button();
                              this.podstawa_minus = new System.Windows.Forms.Button();
                              this.podstawa_plus = new System.Windows.Forms.Button();
                              this.tabPage4 = new System.Windows.Forms.TabPage();
                              this.ppotw = new System.Windows.Forms.Button();
                              this.wart_pred = new System.Windows.Forms.Label();
                              this.label14 = new System.Windows.Forms.Label();
                              this.label15 = new System.Windows.Forms.Label();
                              this.label16 = new System.Windows.Forms.Label();
                              this.trackBar2 = new System.Windows.Forms.TrackBar();
                              this.wart_krok = new System.Windows.Forms.Label();
                              this.label12 = new System.Windows.Forms.Label();
                              this.label11 = new System.Windows.Forms.Label();
                              this.label10 = new System.Windows.Forms.Label();
                              this.label9 = new System.Windows.Forms.Label();
                              this.trackBar1 = new System.Windows.Forms.TrackBar();
                              this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
                              this.tabControl1.SuspendLayout();
                              this.tabPage1.SuspendLayout();
                              this.tabPage2.SuspendLayout();
                              this.tabPage3.SuspendLayout();
                              this.tabPage4.SuspendLayout();
                              ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
                              ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
                              this.SuspendLayout();
                              // 
                              // tabControl1
                              // 
                              this.tabControl1.Controls.Add(this.tabPage1);
                              this.tabControl1.Controls.Add(this.tabPage2);
                              this.tabControl1.Controls.Add(this.tabPage3);
                              this.tabControl1.Controls.Add(this.tabPage4);
                              this.tabControl1.Location = new System.Drawing.Point(1, 2);
                              this.tabControl1.Name = "tabControl1";
                              this.tabControl1.SelectedIndex = 0;
                              this.tabControl1.Size = new System.Drawing.Size(656, 375);
                              this.tabControl1.TabIndex = 0;
                              // 
                              // tabPage1
                              // 
                              this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
                              this.tabPage1.Controls.Add(this.label13);
                              this.tabPage1.Controls.Add(this.button2);
                              this.tabPage1.Controls.Add(this.button1);
                              this.tabPage1.Controls.Add(this.porty_combo);
                              this.tabPage1.Location = new System.Drawing.Point(4, 22);
                              this.tabPage1.Name = "tabPage1";
                              this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
                              this.tabPage1.Size = new System.Drawing.Size(648, 349);
                              this.tabPage1.TabIndex = 0;
                              this.tabPage1.Text = "Port";
                              // 
                              // label13
                              // 
                              this.label13.AutoSize = true;
                              this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                              this.label13.Location = new System.Drawing.Point(3, 3);
                              this.label13.Name = "label13";
                              this.label13.Size = new System.Drawing.Size(144, 20);
                              this.label13.TabIndex = 2;
                              this.label13.Text = "Ustawianie portu";
                              // 
                              // button2
                              // 
                              this.button2.Location = new System.Drawing.Point(134, 68);
                              this.button2.Name = "button2";
                              this.button2.Size = new System.Drawing.Size(75, 23);
                              this.button2.TabIndex = 1;
                              this.button2.Text = "Zamknij";
                              this.button2.UseVisualStyleBackColor = true;
                              this.button2.Click += new System.EventHandler(this.button2_Click);
                              // 
                              // button1
                              // 
                              this.button1.Location = new System.Drawing.Point(134, 39);
                              this.button1.Name = "button1";
                              this.button1.Size = new System.Drawing.Size(75, 23);
                              this.button1.TabIndex = 1;
                              this.button1.Text = "Otwórz";
                              this.button1.UseVisualStyleBackColor = true;
                              this.button1.Click += new System.EventHandler(this.button1_Click);
                              // 
                              // porty_combo
                              // 
                              this.porty_combo.FormattingEnabled = true;
                              this.porty_combo.Location = new System.Drawing.Point(7, 39);
                              this.porty_combo.Name = "porty_combo";
                              this.porty_combo.Size = new System.Drawing.Size(121, 21);
                              this.porty_combo.TabIndex = 0;
                              // 
                              // tabPage2
                              // 
                              this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
                              this.tabPage2.Controls.Add(this.wyslij_komenda);
                              this.tabPage2.Controls.Add(this.label3);
                              this.tabPage2.Controls.Add(this.label4);
                              this.tabPage2.Controls.Add(this.wlasna_komenda);
                              this.tabPage2.Location = new System.Drawing.Point(4, 22);
                              this.tabPage2.Name = "tabPage2";
                              this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
                              this.tabPage2.Size = new System.Drawing.Size(648, 349);
                              this.tabPage2.TabIndex = 1;
                              this.tabPage2.Text = "Własne";
                              // 
                              // wyslij_komenda
                              // 
                              this.wyslij_komenda.Location = new System.Drawing.Point(251, 48);
                              this.wyslij_komenda.Name = "wyslij_komenda";
                              this.wyslij_komenda.Size = new System.Drawing.Size(75, 23);
                              this.wyslij_komenda.TabIndex = 6;
                              this.wyslij_komenda.Text = "Wyślij";
                              this.wyslij_komenda.UseVisualStyleBackColor = true;
                              this.wyslij_komenda.Click += new System.EventHandler(this.wyslij_komenda_Click);
                              // 
                              // label3
                              // 
                              this.label3.AutoSize = true;
                              this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                              this.label3.Location = new System.Drawing.Point(6, 3);
                              this.label3.Name = "label3";
                              this.label3.Size = new System.Drawing.Size(143, 20);
                              this.label3.TabIndex = 5;
                              this.label3.Text = "Komendy własne";
                              // 
                              // label4
                              // 
                              this.label4.AutoSize = true;
                              this.label4.Location = new System.Drawing.Point(7, 53);
                              this.label4.Name = "label4";
                              this.label4.Size = new System.Drawing.Size(52, 13);
                              this.label4.TabIndex = 4;
                              this.label4.Text = "Komenda";
                              // 
                              // wlasna_komenda
                              // 
                              this.wlasna_komenda.Cursor = System.Windows.Forms.Cursors.Default;
                              this.wlasna_komenda.Location = new System.Drawing.Point(65, 50);
                              this.wlasna_komenda.Name = "wlasna_komenda";
                              this.wlasna_komenda.Size = new System.Drawing.Size(180, 20);
                              this.wlasna_komenda.TabIndex = 3;
                              // 
                              // tabPage3
                              // 
                              this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLight;
                              this.tabPage3.Controls.Add(this.label8);
                              this.tabPage3.Controls.Add(this.przegub_minus);
                              this.tabPage3.Controls.Add(this.przegub_plus);
                              this.tabPage3.Controls.Add(this.label7);
                              this.tabPage3.Controls.Add(this.ramg_minus);
                              this.tabPage3.Controls.Add(this.ramg_plus);
                              this.tabPage3.Controls.Add(this.label6);
                              this.tabPage3.Controls.Add(this.ramd_minus);
                              this.tabPage3.Controls.Add(this.ramd_plus);
                              this.tabPage3.Controls.Add(this.label5);
                              this.tabPage3.Controls.Add(this.label2);
                              this.tabPage3.Controls.Add(this.label1);
                              this.tabPage3.Controls.Add(this.korpus_minus);
                              this.tabPage3.Controls.Add(this.korpus_plus);
                              this.tabPage3.Controls.Add(this.podstawa_minus);
                              this.tabPage3.Controls.Add(this.podstawa_plus);
                              this.tabPage3.Location = new System.Drawing.Point(4, 22);
                              this.tabPage3.Name = "tabPage3";
                              this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
                              this.tabPage3.Size = new System.Drawing.Size(648, 349);
                              this.tabPage3.TabIndex = 2;
                              this.tabPage3.Text = "Ręczne";
                              // 
                              // label8
                              // 
                              this.label8.AutoSize = true;
                              this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                              this.label8.Location = new System.Drawing.Point(7, 3);
                              this.label8.Name = "label8";
                              this.label8.Size = new System.Drawing.Size(165, 20);
                              this.label8.TabIndex = 15;
                              this.label8.Text = "Sterowanie Ręczne";
                              // 
                              // przegub_minus
                              // 
                              this.przegub_minus.Location = new System.Drawing.Point(148, 152);
                              this.przegub_minus.Name = "przegub_minus";
                              this.przegub_minus.Size = new System.Drawing.Size(32, 23);
                              this.przegub_minus.TabIndex = 14;
                              this.przegub_minus.Text = "-";
                              this.przegub_minus.UseVisualStyleBackColor = true;
                              this.przegub_minus.Click += new System.EventHandler(this.przegub_minus_Click);
                              // 
                              // przegub_plus
                              // 
                              this.przegub_plus.Location = new System.Drawing.Point(101, 152);
                              this.przegub_plus.Name = "przegub_plus";
                              this.przegub_plus.Size = new System.Drawing.Size(32, 23);
                              this.przegub_plus.TabIndex = 13;
                              this.przegub_plus.Text = "+";
                              this.przegub_plus.UseVisualStyleBackColor = true;
                              this.przegub_plus.Click += new System.EventHandler(this.przegub_plus_Click);
                              // 
                              // label7
                              // 
                              this.label7.AutoSize = true;
                              this.label7.Location = new System.Drawing.Point(18, 157);
                              this.label7.Name = "label7";
                              this.label7.Size = new System.Drawing.Size(46, 13);
                              this.label7.TabIndex = 12;
                              this.label7.Text = "Przegub";
                              // 
                              // ramg_minus
                              // 
                              this.ramg_minus.Location = new System.Drawing.Point(148, 122);
                              this.ramg_minus.Name = "ramg_minus";
                              this.ramg_minus.Size = new System.Drawing.Size(32, 23);
                              this.ramg_minus.TabIndex = 11;
                              this.ramg_minus.Text = "-";
                              this.ramg_minus.UseVisualStyleBackColor = true;
                              this.ramg_minus.Click += new System.EventHandler(this.ramg_minus_Click);
                              // 
                              // ramg_plus
                              // 
                              this.ramg_plus.Location = new System.Drawing.Point(101, 122);
                              this.ramg_plus.Name = "ramg_plus";
                              this.ramg_plus.Size = new System.Drawing.Size(32, 23);
                              this.ramg_plus.TabIndex = 10;
                              this.ramg_plus.Text = "+";
                              this.ramg_plus.UseVisualStyleBackColor = true;
                              this.ramg_plus.Click += new System.EventHandler(this.ramg_plus_Click);
                              // 
                              // label6
                              // 
                              this.label6.AutoSize = true;
                              this.label6.Location = new System.Drawing.Point(18, 127);
                              this.label6.Name = "label6";
                              this.label6.Size = new System.Drawing.Size(67, 13);
                              this.label6.TabIndex = 9;
                              this.label6.Text = "Ramię górne";
                              // 
                              // ramd_minus
                              // 
                              this.ramd_minus.Location = new System.Drawing.Point(148, 91);
                              this.ramd_minus.Name = "ramd_minus";
                              this.ramd_minus.Size = new System.Drawing.Size(32, 23);
                              this.ramd_minus.TabIndex = 8;
                              this.ramd_minus.Text = "-";
                              this.ramd_minus.UseVisualStyleBackColor = true;
                              this.ramd_minus.Click += new System.EventHandler(this.ramd_minus_Click);
                              // 
                              // ramd_plus
                              // 
                              this.ramd_plus.Location = new System.Drawing.Point(101, 91);
                              this.ramd_plus.Name = "ramd_plus";
                              this.ramd_plus.Size = new System.Drawing.Size(32, 23);
                              this.ramd_plus.TabIndex = 7;
                              this.ramd_plus.Text = "+";
                              this.ramd_plus.UseVisualStyleBackColor = true;
                              this.ramd_plus.Click += new System.EventHandler(this.ramd_plus_Click);
                              // 
                              // label5
                              // 
                              this.label5.AutoSize = true;
                              this.label5.Location = new System.Drawing.Point(18, 99);
                              this.label5.Name = "label5";
                              this.label5.Size = new System.Drawing.Size(66, 13);
                              this.label5.TabIndex = 6;
                              this.label5.Text = "Ramię dolne";
                              // 
                              // label2
                              // 
                              this.label2.AutoSize = true;
                              this.label2.Location = new System.Drawing.Point(18, 67);
                              this.label2.Name = "label2";
                              this.label2.Size = new System.Drawing.Size(40, 13);
                              this.label2.TabIndex = 5;
                              this.label2.Text = "Korpus";
                              // 
                              // label1
                              // 
                              this.label1.AutoSize = true;
                              this.label1.Location = new System.Drawing.Point(18, 38);
                              this.label1.Name = "label1";
                              this.label1.Size = new System.Drawing.Size(54, 13);
                              this.label1.TabIndex = 4;
                              this.label1.Text = "Podstawa";
                              // 
                              // korpus_minus
                              // 
                              this.korpus_minus.Location = new System.Drawing.Point(148, 62);
                              this.korpus_minus.Name = "korpus_minus";
                              this.korpus_minus.Size = new System.Drawing.Size(32, 23);
                              this.korpus_minus.TabIndex = 3;
                              this.korpus_minus.Text = "-";
                              this.korpus_minus.UseVisualStyleBackColor = true;
                              this.korpus_minus.Click += new System.EventHandler(this.korpus_minus_Click);
                              // 
                              // korpus_plus
                              // 
                              this.korpus_plus.Location = new System.Drawing.Point(101, 62);
                              this.korpus_plus.Name = "korpus_plus";
                              this.korpus_plus.Size = new System.Drawing.Size(32, 23);
                              this.korpus_plus.TabIndex = 2;
                              this.korpus_plus.Text = "+";
                              this.korpus_plus.UseVisualStyleBackColor = true;
                              this.korpus_plus.Click += new System.EventHandler(this.korpus_plus_Click);
                              // 
                              // podstawa_minus
                              // 
                              this.podstawa_minus.Location = new System.Drawing.Point(148, 33);
                              this.podstawa_minus.Name = "podstawa_minus";
                              this.podstawa_minus.Size = new System.Drawing.Size(32, 23);
                              this.podstawa_minus.TabIndex = 1;
                              this.podstawa_minus.Text = "-";
                              this.podstawa_minus.UseVisualStyleBackColor = true;
                              this.podstawa_minus.Click += new System.EventHandler(this.podstawa_minus_Click);
                              // 
                              // podstawa_plus
                              // 
                              this.podstawa_plus.Location = new System.Drawing.Point(101, 33);
                              this.podstawa_plus.Name = "podstawa_plus";
                              this.podstawa_plus.Size = new System.Drawing.Size(32, 23);
                              this.podstawa_plus.TabIndex = 0;
                              this.podstawa_plus.Text = "+";
                              this.podstawa_plus.UseVisualStyleBackColor = true;
                              this.podstawa_plus.Click += new System.EventHandler(this.podstawa_plus_Click);
                              // 
                              // tabPage4
                              // 
                              this.tabPage4.BackColor = System.Drawing.SystemColors.ControlLight;
                              this.tabPage4.Controls.Add(this.ppotw);
                              this.tabPage4.Controls.Add(this.wart_pred);
                              this.tabPage4.Controls.Add(this.label14);
                              this.tabPage4.Controls.Add(this.label15);
                              this.tabPage4.Controls.Add(this.label16);
                              this.tabPage4.Controls.Add(this.trackBar2);
                              this.tabPage4.Controls.Add(this.wart_krok);
                              this.tabPage4.Controls.Add(this.label12);
                              this.tabPage4.Controls.Add(this.label11);
                              this.tabPage4.Controls.Add(this.label10);
                              this.tabPage4.Controls.Add(this.label9);
                              this.tabPage4.Controls.Add(this.trackBar1);
                              this.tabPage4.Location = new System.Drawing.Point(4, 22);
                              this.tabPage4.Name = "tabPage4";
                              this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
                              this.tabPage4.Size = new System.Drawing.Size(648, 349);
                              this.tabPage4.TabIndex = 3;
                              this.tabPage4.Text = "Ustawienia";
                              // 
                              // ppotw
                              // 
                              this.ppotw.Location = new System.Drawing.Point(224, 88);
                              this.ppotw.Name = "ppotw";
                              this.ppotw.Size = new System.Drawing.Size(86, 33);
                              this.ppotw.TabIndex = 18;
                              this.ppotw.Text = "potwierdź";
                              this.ppotw.UseVisualStyleBackColor = true;
                              this.ppotw.Click += new System.EventHandler(this.ppotw_Click);
                              // 
                              // wart_pred
                              // 
                              this.wart_pred.AutoSize = true;
                              this.wart_pred.Location = new System.Drawing.Point(139, 108);
                              this.wart_pred.Name = "wart_pred";
                              this.wart_pred.Size = new System.Drawing.Size(13, 13);
                              this.wart_pred.TabIndex = 17;
                              this.wart_pred.Text = "1";
                              // 
                              // label14
                              // 
                              this.label14.AutoSize = true;
                              this.label14.Location = new System.Drawing.Point(170, 144);
                              this.label14.Name = "label14";
                              this.label14.Size = new System.Drawing.Size(19, 13);
                              this.label14.TabIndex = 16;
                              this.label14.Text = "30";
                              // 
                              // label15
                              // 
                              this.label15.AutoSize = true;
                              this.label15.Location = new System.Drawing.Point(41, 144);
                              this.label15.Name = "label15";
                              this.label15.Size = new System.Drawing.Size(13, 13);
                              this.label15.TabIndex = 15;
                              this.label15.Text = "1";
                              // 
                              // label16
                              // 
                              this.label16.AutoSize = true;
                              this.label16.Location = new System.Drawing.Point(78, 108);
                              this.label16.Name = "label16";
                              this.label16.Size = new System.Drawing.Size(55, 13);
                              this.label16.TabIndex = 14;
                              this.label16.Text = "Prędkość:";
                              // 
                              // trackBar2
                              // 
                              this.trackBar2.Location = new System.Drawing.Point(60, 133);
                              this.trackBar2.Maximum = 30;
                              this.trackBar2.Minimum = 1;
                              this.trackBar2.Name = "trackBar2";
                              this.trackBar2.Size = new System.Drawing.Size(104, 45);
                              this.trackBar2.TabIndex = 13;
                              this.trackBar2.Value = 1;
                              this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
                              // 
                              // wart_krok
                              // 
                              this.wart_krok.AutoSize = true;
                              this.wart_krok.Location = new System.Drawing.Point(116, 35);
                              this.wart_krok.Name = "wart_krok";
                              this.wart_krok.Size = new System.Drawing.Size(22, 13);
                              this.wart_krok.TabIndex = 12;
                              this.wart_krok.Text = "0.1";
                              // 
                              // label12
                              // 
                              this.label12.AutoSize = true;
                              this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                              this.label12.Location = new System.Drawing.Point(13, 3);
                              this.label12.Name = "label12";
                              this.label12.Size = new System.Drawing.Size(97, 20);
                              this.label12.TabIndex = 11;
                              this.label12.Text = "Ustawienia";
                              // 
                              // label11
                              // 
                              this.label11.AutoSize = true;
                              this.label11.Location = new System.Drawing.Point(170, 71);
                              this.label11.Name = "label11";
                              this.label11.Size = new System.Drawing.Size(19, 13);
                              this.label11.TabIndex = 10;
                              this.label11.Text = "10";
                              // 
                              // label10
                              // 
                              this.label10.AutoSize = true;
                              this.label10.Location = new System.Drawing.Point(41, 71);
                              this.label10.Name = "label10";
                              this.label10.Size = new System.Drawing.Size(22, 13);
                              this.label10.TabIndex = 9;
                              this.label10.Text = "0.1";
                              // 
                              // label9
                              // 
                              this.label9.AutoSize = true;
                              this.label9.Location = new System.Drawing.Point(78, 35);
                              this.label9.Name = "label9";
                              this.label9.Size = new System.Drawing.Size(32, 13);
                              this.label9.TabIndex = 8;
                              this.label9.Text = "Krok:";
                              // 
                              // trackBar1
                              // 
                              this.trackBar1.Location = new System.Drawing.Point(60, 60);
                              this.trackBar1.Maximum = 100;
                              this.trackBar1.Minimum = 1;
                              this.trackBar1.Name = "trackBar1";
                              this.trackBar1.Size = new System.Drawing.Size(104, 45);
                              this.trackBar1.TabIndex = 7;
                              this.trackBar1.Value = 1;
                              this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
                              // 
                              // serialPort1
                              // 
                              this.serialPort1.Parity = System.IO.Ports.Parity.Even;
                              this.serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                              // 
                              // Form1
                              // 
                              this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                              this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                              this.ClientSize = new System.Drawing.Size(657, 404);
                              this.Controls.Add(this.tabControl1);
                              this.Name = "Form1";
                              this.Text = "Form1";
                              this.Load += new System.EventHandler(this.Form1_Load);
                              this.tabControl1.ResumeLayout(false);
                              this.tabPage1.ResumeLayout(false);
                              this.tabPage1.PerformLayout();
                              this.tabPage2.ResumeLayout(false);
                              this.tabPage2.PerformLayout();
                              this.tabPage3.ResumeLayout(false);
                              this.tabPage3.PerformLayout();
                              this.tabPage4.ResumeLayout(false);
                              this.tabPage4.PerformLayout();
                              ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
                              ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
                              this.ResumeLayout(false);

                    }

                    #endregion

                    private System.Windows.Forms.TabControl tabControl1;
                    private System.Windows.Forms.TabPage tabPage1;
                    private System.Windows.Forms.TabPage tabPage2;
                    private System.Windows.Forms.ComboBox porty_combo;
                    private System.Windows.Forms.Label label3;
                    private System.Windows.Forms.Label label4;
                    private System.Windows.Forms.TextBox wlasna_komenda;
                    private System.IO.Ports.SerialPort serialPort1;
                    private System.Windows.Forms.Button button1;
                    private System.Windows.Forms.Button button2;
                    private System.Windows.Forms.Button wyslij_komenda;
                    private System.Windows.Forms.TabPage tabPage3;
                    private System.Windows.Forms.Button ramg_minus;
                    private System.Windows.Forms.Button ramg_plus;
                    private System.Windows.Forms.Label label6;
                    private System.Windows.Forms.Button ramd_minus;
                    private System.Windows.Forms.Button ramd_plus;
                    private System.Windows.Forms.Label label5;
                    private System.Windows.Forms.Label label2;
                    private System.Windows.Forms.Label label1;
                    private System.Windows.Forms.Button korpus_minus;
                    private System.Windows.Forms.Button korpus_plus;
                    private System.Windows.Forms.Button podstawa_minus;
                    private System.Windows.Forms.Button podstawa_plus;
                    private System.Windows.Forms.Label label8;
                    private System.Windows.Forms.Button przegub_minus;
                    private System.Windows.Forms.Button przegub_plus;
                    private System.Windows.Forms.Label label7;
                    private System.Windows.Forms.TabPage tabPage4;
                    private System.Windows.Forms.Label label12;
                    private System.Windows.Forms.Label label11;
                    private System.Windows.Forms.Label label10;
                    private System.Windows.Forms.Label label9;
                    private System.Windows.Forms.TrackBar trackBar1;
                    private System.Windows.Forms.Label wart_krok;
                    private System.Windows.Forms.Label wart_pred;
                    private System.Windows.Forms.Label label14;
                    private System.Windows.Forms.Label label15;
                    private System.Windows.Forms.Label label16;
                    private System.Windows.Forms.TrackBar trackBar2;
                    private System.Windows.Forms.Button ppotw;
                    private System.Windows.Forms.Label label13;
          }
}

