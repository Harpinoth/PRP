namespace Pomiar_temperatury
{
    partial class Temperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temperatura));
            this.tytulL = new System.Windows.Forms.Label();
            this.tematL = new System.Windows.Forms.Label();
            this.portB = new System.Windows.Forms.Button();
            this.odczytB = new System.Windows.Forms.Button();
            this.tworcyL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tytulL
            // 
            this.tytulL.AutoSize = true;
            this.tytulL.Font = new System.Drawing.Font("Pristina", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytulL.Location = new System.Drawing.Point(114, 36);
            this.tytulL.Name = "tytulL";
            this.tytulL.Size = new System.Drawing.Size(551, 23);
            this.tytulL.TabIndex = 0;
            this.tytulL.Text = "Projekt z przedmiotu Mikrokontrolery i urządzenia wbudowane";
            // 
            // tematL
            // 
            this.tematL.Font = new System.Drawing.Font("Matura MT Script Capitals", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tematL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tematL.Location = new System.Drawing.Point(22, 153);
            this.tematL.Name = "tematL";
            this.tematL.Size = new System.Drawing.Size(750, 133);
            this.tematL.TabIndex = 1;
            this.tematL.Text = "Cyfrowy tor pomiarowy termopary typu J z komputerowym inferfejsem komunikacyjnym";
            this.tematL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // portB
            // 
            this.portB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.portB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portB.Location = new System.Drawing.Point(105, 301);
            this.portB.Name = "portB";
            this.portB.Size = new System.Drawing.Size(200, 100);
            this.portB.TabIndex = 2;
            this.portB.Text = "Ustawienia portu komunikacyjnego";
            this.portB.UseVisualStyleBackColor = false;
            this.portB.Click += new System.EventHandler(this.portB_Click);
            // 
            // odczytB
            // 
            this.odczytB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odczytB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odczytB.Location = new System.Drawing.Point(489, 301);
            this.odczytB.Name = "odczytB";
            this.odczytB.Size = new System.Drawing.Size(200, 100);
            this.odczytB.TabIndex = 3;
            this.odczytB.Text = "Odczyt temperatury";
            this.odczytB.UseVisualStyleBackColor = false;
            this.odczytB.Click += new System.EventHandler(this.odczytB_Click);
            // 
            // tworcyL
            // 
            this.tworcyL.AutoSize = true;
            this.tworcyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tworcyL.Location = new System.Drawing.Point(470, 532);
            this.tworcyL.Name = "tworcyL";
            this.tworcyL.Size = new System.Drawing.Size(302, 20);
            this.tworcyL.TabIndex = 4;
            this.tworcyL.Text = "Wykonali: Tomasz Piłat, Robert Olszewski";
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tworcyL);
            this.Controls.Add(this.odczytB);
            this.Controls.Add(this.portB);
            this.Controls.Add(this.tematL);
            this.Controls.Add(this.tytulL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Temperatura";
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytulL;
        private System.Windows.Forms.Label tematL;
        private System.Windows.Forms.Button portB;
        private System.Windows.Forms.Button odczytB;
        private System.Windows.Forms.Label tworcyL;
    }
}

