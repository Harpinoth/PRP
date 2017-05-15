namespace PRP_Labo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dane_port = new System.Windows.Forms.TextBox();
            this.dane_szybkosc = new System.Windows.Forms.TextBox();
            this.dane_dlugosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dane_parzystosc = new System.Windows.Forms.TextBox();
            this.dane_bitystopu = new System.Windows.Forms.TextBox();
            this.zapisz = new System.Windows.Forms.Button();
            this.polacz = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.polacz);
            this.tabPage1.Controls.Add(this.zapisz);
            this.tabPage1.Controls.Add(this.dane_bitystopu);
            this.tabPage1.Controls.Add(this.dane_parzystosc);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dane_dlugosc);
            this.tabPage1.Controls.Add(this.dane_szybkosc);
            this.tabPage1.Controls.Add(this.dane_port);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Połączenie";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dane_port
            // 
            this.dane_port.Location = new System.Drawing.Point(232, 67);
            this.dane_port.Name = "dane_port";
            this.dane_port.Size = new System.Drawing.Size(171, 20);
            this.dane_port.TabIndex = 0;
            // 
            // dane_szybkosc
            // 
            this.dane_szybkosc.Location = new System.Drawing.Point(232, 93);
            this.dane_szybkosc.Name = "dane_szybkosc";
            this.dane_szybkosc.Size = new System.Drawing.Size(171, 20);
            this.dane_szybkosc.TabIndex = 1;
            // 
            // dane_dlugosc
            // 
            this.dane_dlugosc.Location = new System.Drawing.Point(233, 146);
            this.dane_dlugosc.Name = "dane_dlugosc";
            this.dane_dlugosc.Size = new System.Drawing.Size(171, 20);
            this.dane_dlugosc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Szybkość transmisji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parzystość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Długość ramki";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bity stopu";
            // 
            // dane_parzystosc
            // 
            this.dane_parzystosc.Location = new System.Drawing.Point(232, 119);
            this.dane_parzystosc.Name = "dane_parzystosc";
            this.dane_parzystosc.Size = new System.Drawing.Size(171, 20);
            this.dane_parzystosc.TabIndex = 10;
            // 
            // dane_bitystopu
            // 
            this.dane_bitystopu.Location = new System.Drawing.Point(232, 172);
            this.dane_bitystopu.Name = "dane_bitystopu";
            this.dane_bitystopu.Size = new System.Drawing.Size(171, 20);
            this.dane_bitystopu.TabIndex = 11;
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(270, 224);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(173, 24);
            this.zapisz.TabIndex = 12;
            this.zapisz.Text = "ZAPISZ";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // polacz
            // 
            this.polacz.Location = new System.Drawing.Point(91, 224);
            this.polacz.Name = "polacz";
            this.polacz.Size = new System.Drawing.Size(173, 24);
            this.polacz.TabIndex = 13;
            this.polacz.Text = "POŁĄCZ";
            this.polacz.UseVisualStyleBackColor = true;
            this.polacz.Click += new System.EventHandler(this.polacz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox dane_dlugosc;
        private System.Windows.Forms.TextBox dane_szybkosc;
        private System.Windows.Forms.TextBox dane_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dane_parzystosc;
        private System.Windows.Forms.TextBox dane_bitystopu;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Button polacz;
    }
}

