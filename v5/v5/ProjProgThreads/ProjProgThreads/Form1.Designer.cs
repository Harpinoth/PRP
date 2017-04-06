namespace ProjProgThreads
{
    partial class windowform
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
            this.IPadd = new System.Windows.Forms.TextBox();
            this.monitorprz = new System.Windows.Forms.Button();
            this.kontrolaprz = new System.Windows.Forms.Button();
            this.monitorkontrolaprz = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.roboinfo1 = new System.Windows.Forms.TextBox();
            this.roboinfo2 = new System.Windows.Forms.TextBox();
            this.roboinfo3 = new System.Windows.Forms.TextBox();
            this.roboinfo4 = new System.Windows.Forms.TextBox();
            this.roboinfo5 = new System.Windows.Forms.TextBox();
            this.noofrobots = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.controlledrobot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.moveforward = new System.Windows.Forms.Button();
            this.moveleft = new System.Windows.Forms.Button();
            this.movebackwards = new System.Windows.Forms.Button();
            this.moveright = new System.Windows.Forms.Button();
            this.stopper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPadd
            // 
            this.IPadd.Location = new System.Drawing.Point(116, 11);
            this.IPadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IPadd.Name = "IPadd";
            this.IPadd.Size = new System.Drawing.Size(140, 20);
            this.IPadd.TabIndex = 0;
            this.IPadd.Text = "192.168.2.";
            // 
            // monitorprz
            // 
            this.monitorprz.Location = new System.Drawing.Point(21, 9);
            this.monitorprz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monitorprz.Name = "monitorprz";
            this.monitorprz.Size = new System.Drawing.Size(88, 40);
            this.monitorprz.TabIndex = 1;
            this.monitorprz.Text = "Monitor";
            this.monitorprz.UseVisualStyleBackColor = true;
            this.monitorprz.Click += new System.EventHandler(this.monitorprz_Click);
            // 
            // kontrolaprz
            // 
            this.kontrolaprz.Location = new System.Drawing.Point(21, 54);
            this.kontrolaprz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kontrolaprz.Name = "kontrolaprz";
            this.kontrolaprz.Size = new System.Drawing.Size(88, 40);
            this.kontrolaprz.TabIndex = 2;
            this.kontrolaprz.Text = "Control";
            this.kontrolaprz.UseVisualStyleBackColor = true;
            this.kontrolaprz.Click += new System.EventHandler(this.kontrolaprz_Click);
            // 
            // monitorkontrolaprz
            // 
            this.monitorkontrolaprz.Location = new System.Drawing.Point(21, 98);
            this.monitorkontrolaprz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monitorkontrolaprz.Name = "monitorkontrolaprz";
            this.monitorkontrolaprz.Size = new System.Drawing.Size(88, 40);
            this.monitorkontrolaprz.TabIndex = 3;
            this.monitorkontrolaprz.Text = "Monitor/Control";
            this.monitorkontrolaprz.UseVisualStyleBackColor = true;
            this.monitorkontrolaprz.Click += new System.EventHandler(this.monitorkontrolaprz_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(21, 143);
            this.disconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(88, 40);
            this.disconnect.TabIndex = 4;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // roboinfo1
            // 
            this.roboinfo1.Location = new System.Drawing.Point(115, 229);
            this.roboinfo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roboinfo1.Name = "roboinfo1";
            this.roboinfo1.Size = new System.Drawing.Size(399, 20);
            this.roboinfo1.TabIndex = 5;
            // 
            // roboinfo2
            // 
            this.roboinfo2.Location = new System.Drawing.Point(115, 252);
            this.roboinfo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roboinfo2.Name = "roboinfo2";
            this.roboinfo2.Size = new System.Drawing.Size(399, 20);
            this.roboinfo2.TabIndex = 6;
            // 
            // roboinfo3
            // 
            this.roboinfo3.Location = new System.Drawing.Point(116, 275);
            this.roboinfo3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roboinfo3.Name = "roboinfo3";
            this.roboinfo3.Size = new System.Drawing.Size(398, 20);
            this.roboinfo3.TabIndex = 7;
            // 
            // roboinfo4
            // 
            this.roboinfo4.Location = new System.Drawing.Point(116, 297);
            this.roboinfo4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roboinfo4.Name = "roboinfo4";
            this.roboinfo4.Size = new System.Drawing.Size(398, 20);
            this.roboinfo4.TabIndex = 8;
            // 
            // roboinfo5
            // 
            this.roboinfo5.Location = new System.Drawing.Point(115, 320);
            this.roboinfo5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roboinfo5.Name = "roboinfo5";
            this.roboinfo5.Size = new System.Drawing.Size(399, 20);
            this.roboinfo5.TabIndex = 9;
            // 
            // noofrobots
            // 
            this.noofrobots.FormattingEnabled = true;
            this.noofrobots.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.noofrobots.Location = new System.Drawing.Point(115, 54);
            this.noofrobots.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noofrobots.Name = "noofrobots";
            this.noofrobots.Size = new System.Drawing.Size(92, 21);
            this.noofrobots.TabIndex = 10;
            this.noofrobots.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "No of robots";
            // 
            // controlledrobot
            // 
            this.controlledrobot.FormattingEnabled = true;
            this.controlledrobot.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.controlledrobot.Location = new System.Drawing.Point(115, 98);
            this.controlledrobot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlledrobot.Name = "controlledrobot";
            this.controlledrobot.Size = new System.Drawing.Size(92, 21);
            this.controlledrobot.TabIndex = 13;
            this.controlledrobot.Text = "1";
            this.controlledrobot.SelectedIndexChanged += new System.EventHandler(this.controlledrobot_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Currently controlled robot";
            // 
            // moveforward
            // 
            this.moveforward.Location = new System.Drawing.Point(392, 85);
            this.moveforward.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveforward.Name = "moveforward";
            this.moveforward.Size = new System.Drawing.Size(62, 52);
            this.moveforward.TabIndex = 15;
            this.moveforward.Text = "Forward";
            this.moveforward.UseVisualStyleBackColor = true;
            this.moveforward.Click += new System.EventHandler(this.moveforward_Click);
            // 
            // moveleft
            // 
            this.moveleft.Location = new System.Drawing.Point(334, 143);
            this.moveleft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveleft.Name = "moveleft";
            this.moveleft.Size = new System.Drawing.Size(54, 52);
            this.moveleft.TabIndex = 16;
            this.moveleft.Text = "Left";
            this.moveleft.UseVisualStyleBackColor = true;
            this.moveleft.Click += new System.EventHandler(this.moveleft_Click);
            // 
            // movebackwards
            // 
            this.movebackwards.Location = new System.Drawing.Point(392, 143);
            this.movebackwards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movebackwards.Name = "movebackwards";
            this.movebackwards.Size = new System.Drawing.Size(62, 52);
            this.movebackwards.TabIndex = 17;
            this.movebackwards.Text = "Reverse";
            this.movebackwards.UseVisualStyleBackColor = true;
            this.movebackwards.Click += new System.EventHandler(this.movebackwards_Click);
            // 
            // moveright
            // 
            this.moveright.Location = new System.Drawing.Point(459, 143);
            this.moveright.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveright.Name = "moveright";
            this.moveright.Size = new System.Drawing.Size(54, 52);
            this.moveright.TabIndex = 18;
            this.moveright.Text = "Right";
            this.moveright.UseVisualStyleBackColor = true;
            this.moveright.Click += new System.EventHandler(this.moveright_Click);
            // 
            // stopper
            // 
            this.stopper.Location = new System.Drawing.Point(458, 85);
            this.stopper.Margin = new System.Windows.Forms.Padding(2);
            this.stopper.Name = "stopper";
            this.stopper.Size = new System.Drawing.Size(62, 52);
            this.stopper.TabIndex = 19;
            this.stopper.Text = "Stop";
            this.stopper.UseVisualStyleBackColor = true;
            this.stopper.Click += new System.EventHandler(this.stopper_Click);
            // 
            // windowform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 348);
            this.Controls.Add(this.stopper);
            this.Controls.Add(this.moveright);
            this.Controls.Add(this.movebackwards);
            this.Controls.Add(this.moveleft);
            this.Controls.Add(this.moveforward);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.controlledrobot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noofrobots);
            this.Controls.Add(this.roboinfo5);
            this.Controls.Add(this.roboinfo4);
            this.Controls.Add(this.roboinfo3);
            this.Controls.Add(this.roboinfo2);
            this.Controls.Add(this.roboinfo1);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.monitorkontrolaprz);
            this.Controls.Add(this.kontrolaprz);
            this.Controls.Add(this.monitorprz);
            this.Controls.Add(this.IPadd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "windowform";
            this.Text = "Projekt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPadd;
        private System.Windows.Forms.Button monitorprz;
        private System.Windows.Forms.Button kontrolaprz;
        private System.Windows.Forms.Button monitorkontrolaprz;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.TextBox roboinfo1;
        private System.Windows.Forms.TextBox roboinfo2;
        private System.Windows.Forms.TextBox roboinfo3;
        private System.Windows.Forms.TextBox roboinfo4;
        private System.Windows.Forms.TextBox roboinfo5;
        private System.Windows.Forms.ComboBox noofrobots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox controlledrobot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button moveforward;
        private System.Windows.Forms.Button moveleft;
        private System.Windows.Forms.Button movebackwards;
        private System.Windows.Forms.Button moveright;
        private System.Windows.Forms.Button stopper;
    }
}

