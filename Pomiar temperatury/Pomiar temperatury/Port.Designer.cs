namespace Pomiar_temperatury
{
    partial class Port
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Port));
            this.PortL = new System.Windows.Forms.Label();
            this.PortyCB = new System.Windows.Forms.ComboBox();
            this.ParametryPortuL = new System.Windows.Forms.Label();
            this.AktualneUstawieniaL = new System.Windows.Forms.Label();
            this.BityStopuL = new System.Windows.Forms.Label();
            this.ZamknijB = new System.Windows.Forms.Button();
            this.ZaspiszB = new System.Windows.Forms.Button();
            this.ParzystoscL = new System.Windows.Forms.Label();
            this.DlugoscL = new System.Windows.Forms.Label();
            this.PredkoscL = new System.Windows.Forms.Label();
            this.ParzystoscCB = new System.Windows.Forms.ComboBox();
            this.DlugoscCB = new System.Windows.Forms.ComboBox();
            this.BityStopuCB = new System.Windows.Forms.ComboBox();
            this.PredkoscCB = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.StartB = new System.Windows.Forms.Button();
            this.StopB = new System.Windows.Forms.Button();
            this.stanL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PortL
            // 
            this.PortL.AutoSize = true;
            this.PortL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortL.Location = new System.Drawing.Point(66, 9);
            this.PortL.Name = "PortL";
            this.PortL.Size = new System.Drawing.Size(104, 17);
            this.PortL.TabIndex = 33;
            this.PortL.Text = "Numer Portu:";
            // 
            // PortyCB
            // 
            this.PortyCB.FormattingEnabled = true;
            this.PortyCB.Location = new System.Drawing.Point(180, 9);
            this.PortyCB.Name = "PortyCB";
            this.PortyCB.Size = new System.Drawing.Size(121, 21);
            this.PortyCB.TabIndex = 32;
            // 
            // ParametryPortuL
            // 
            this.ParametryPortuL.AutoSize = true;
            this.ParametryPortuL.Location = new System.Drawing.Point(177, 348);
            this.ParametryPortuL.Name = "ParametryPortuL";
            this.ParametryPortuL.Size = new System.Drawing.Size(40, 13);
            this.ParametryPortuL.TabIndex = 31;
            this.ParametryPortuL.Text = "           ";
            // 
            // AktualneUstawieniaL
            // 
            this.AktualneUstawieniaL.AutoSize = true;
            this.AktualneUstawieniaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AktualneUstawieniaL.Location = new System.Drawing.Point(14, 346);
            this.AktualneUstawieniaL.Name = "AktualneUstawieniaL";
            this.AktualneUstawieniaL.Size = new System.Drawing.Size(157, 17);
            this.AktualneUstawieniaL.TabIndex = 30;
            this.AktualneUstawieniaL.Text = "Aktualne ustawienia:";
            // 
            // BityStopuL
            // 
            this.BityStopuL.AutoSize = true;
            this.BityStopuL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BityStopuL.Location = new System.Drawing.Point(66, 254);
            this.BityStopuL.Name = "BityStopuL";
            this.BityStopuL.Size = new System.Drawing.Size(87, 17);
            this.BityStopuL.TabIndex = 29;
            this.BityStopuL.Text = "Bity Stopu:";
            // 
            // ZamknijB
            // 
            this.ZamknijB.Location = new System.Drawing.Point(359, 449);
            this.ZamknijB.Name = "ZamknijB";
            this.ZamknijB.Size = new System.Drawing.Size(75, 23);
            this.ZamknijB.TabIndex = 28;
            this.ZamknijB.Text = "ZAMKNIJ";
            this.ZamknijB.UseVisualStyleBackColor = true;
            this.ZamknijB.Click += new System.EventHandler(this.ZamknijB_Click);
            // 
            // ZaspiszB
            // 
            this.ZaspiszB.Location = new System.Drawing.Point(203, 295);
            this.ZaspiszB.Name = "ZaspiszB";
            this.ZaspiszB.Size = new System.Drawing.Size(75, 23);
            this.ZaspiszB.TabIndex = 27;
            this.ZaspiszB.Text = "ZAPISZ";
            this.ZaspiszB.UseVisualStyleBackColor = true;
            this.ZaspiszB.Click += new System.EventHandler(this.ZaspiszB_Click);
            // 
            // ParzystoscL
            // 
            this.ParzystoscL.AutoSize = true;
            this.ParzystoscL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ParzystoscL.Location = new System.Drawing.Point(66, 190);
            this.ParzystoscL.Name = "ParzystoscL";
            this.ParzystoscL.Size = new System.Drawing.Size(92, 17);
            this.ParzystoscL.TabIndex = 26;
            this.ParzystoscL.Text = "Parzystość:";
            // 
            // DlugoscL
            // 
            this.DlugoscL.AutoSize = true;
            this.DlugoscL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DlugoscL.Location = new System.Drawing.Point(66, 126);
            this.DlugoscL.Name = "DlugoscL";
            this.DlugoscL.Size = new System.Drawing.Size(71, 17);
            this.DlugoscL.TabIndex = 25;
            this.DlugoscL.Text = "Długość:";
            // 
            // PredkoscL
            // 
            this.PredkoscL.AutoSize = true;
            this.PredkoscL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PredkoscL.Location = new System.Drawing.Point(66, 65);
            this.PredkoscL.Name = "PredkoscL";
            this.PredkoscL.Size = new System.Drawing.Size(80, 17);
            this.PredkoscL.TabIndex = 24;
            this.PredkoscL.Text = "Prędkość:";
            // 
            // ParzystoscCB
            // 
            this.ParzystoscCB.FormattingEnabled = true;
            this.ParzystoscCB.Items.AddRange(new object[] {
            "Brak",
            "Parzystość",
            "Nieparzystość"});
            this.ParzystoscCB.Location = new System.Drawing.Point(180, 190);
            this.ParzystoscCB.Name = "ParzystoscCB";
            this.ParzystoscCB.Size = new System.Drawing.Size(121, 21);
            this.ParzystoscCB.TabIndex = 23;
            // 
            // DlugoscCB
            // 
            this.DlugoscCB.FormattingEnabled = true;
            this.DlugoscCB.Items.AddRange(new object[] {
            "8",
            "9"});
            this.DlugoscCB.Location = new System.Drawing.Point(180, 126);
            this.DlugoscCB.Name = "DlugoscCB";
            this.DlugoscCB.Size = new System.Drawing.Size(121, 21);
            this.DlugoscCB.TabIndex = 22;
            // 
            // BityStopuCB
            // 
            this.BityStopuCB.FormattingEnabled = true;
            this.BityStopuCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.BityStopuCB.Location = new System.Drawing.Point(180, 251);
            this.BityStopuCB.Name = "BityStopuCB";
            this.BityStopuCB.Size = new System.Drawing.Size(121, 21);
            this.BityStopuCB.TabIndex = 21;
            // 
            // PredkoscCB
            // 
            this.PredkoscCB.FormattingEnabled = true;
            this.PredkoscCB.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.PredkoscCB.Location = new System.Drawing.Point(180, 63);
            this.PredkoscCB.Name = "PredkoscCB";
            this.PredkoscCB.Size = new System.Drawing.Size(121, 21);
            this.PredkoscCB.TabIndex = 20;
            // 
            // StartB
            // 
            this.StartB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartB.Location = new System.Drawing.Point(93, 391);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(94, 25);
            this.StartB.TabIndex = 34;
            this.StartB.Text = "START";
            this.StartB.UseVisualStyleBackColor = true;
            this.StartB.Click += new System.EventHandler(this.StartB_Click);
            // 
            // StopB
            // 
            this.StopB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StopB.Location = new System.Drawing.Point(245, 391);
            this.StopB.Name = "StopB";
            this.StopB.Size = new System.Drawing.Size(94, 25);
            this.StopB.TabIndex = 35;
            this.StopB.Text = "STOP";
            this.StopB.UseVisualStyleBackColor = true;
            this.StopB.Click += new System.EventHandler(this.StopB_Click);
            // 
            // stanL
            // 
            this.stanL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stanL.Location = new System.Drawing.Point(151, 429);
            this.stanL.Name = "stanL";
            this.stanL.Size = new System.Drawing.Size(113, 23);
            this.stanL.TabIndex = 36;
            this.stanL.Text = "      ";
            this.stanL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Port
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(436, 474);
            this.Controls.Add(this.stanL);
            this.Controls.Add(this.StopB);
            this.Controls.Add(this.StartB);
            this.Controls.Add(this.PortL);
            this.Controls.Add(this.PortyCB);
            this.Controls.Add(this.ParametryPortuL);
            this.Controls.Add(this.AktualneUstawieniaL);
            this.Controls.Add(this.BityStopuL);
            this.Controls.Add(this.ZamknijB);
            this.Controls.Add(this.ZaspiszB);
            this.Controls.Add(this.ParzystoscL);
            this.Controls.Add(this.DlugoscL);
            this.Controls.Add(this.PredkoscL);
            this.Controls.Add(this.ParzystoscCB);
            this.Controls.Add(this.DlugoscCB);
            this.Controls.Add(this.BityStopuCB);
            this.Controls.Add(this.PredkoscCB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Port";
            this.Text = "Port Komunikacyjny";
            this.Load += new System.EventHandler(this.Port_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PortL;
        private System.Windows.Forms.ComboBox PortyCB;
        private System.Windows.Forms.Label ParametryPortuL;
        private System.Windows.Forms.Label AktualneUstawieniaL;
        private System.Windows.Forms.Label BityStopuL;
        private System.Windows.Forms.Button ZamknijB;
        private System.Windows.Forms.Button ZaspiszB;
        private System.Windows.Forms.Label ParzystoscL;
        private System.Windows.Forms.Label DlugoscL;
        private System.Windows.Forms.Label PredkoscL;
        private System.Windows.Forms.ComboBox ParzystoscCB;
        private System.Windows.Forms.ComboBox DlugoscCB;
        private System.Windows.Forms.ComboBox BityStopuCB;
        private System.Windows.Forms.ComboBox PredkoscCB;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Button StopB;
        private System.Windows.Forms.Label stanL;
    }
}