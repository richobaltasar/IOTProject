namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTopic = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPTegangan = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPPTegangan = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPGetaran = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPPGetaran = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPKonveyor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPPKonveyor = new System.Windows.Forms.TextBox();
            this.txtPtKonveyor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPLed = new System.Windows.Forms.Button();
            this.txtPPLed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPtLed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Location = new System.Drawing.Point(36, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 114);
            this.panel1.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.MediumPurple;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnect.Location = new System.Drawing.Point(478, 47);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(131, 50);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(357, 55);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(86, 35);
            this.txtPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(24, 55);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(314, 35);
            this.txtHost.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Topic";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.Location = new System.Drawing.Point(24, 54);
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.Size = new System.Drawing.Size(419, 35);
            this.txtSubTopic.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSubscribe);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSubTopic);
            this.panel2.Location = new System.Drawing.Point(36, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 114);
            this.panel2.TabIndex = 0;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscribe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubscribe.Location = new System.Drawing.Point(478, 46);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(131, 50);
            this.btnSubscribe.TabIndex = 2;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Host";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Subscribe";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1450, 115);
            this.panel3.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumPurple;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(1340, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 115);
            this.button6.TabIndex = 1;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(23, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(434, 57);
            this.label7.TabIndex = 0;
            this.label7.Text = "Modbus IOT Gateway";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPTegangan);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtPPTegangan);
            this.panel4.Controls.Add(this.textBox11);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.btnPGetaran);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtPPGetaran);
            this.panel4.Controls.Add(this.textBox9);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.btnPKonveyor);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtPPKonveyor);
            this.panel4.Controls.Add(this.txtPtKonveyor);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btnPLed);
            this.panel4.Controls.Add(this.txtPPLed);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtPtLed);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(36, 496);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 384);
            this.panel4.TabIndex = 0;
            // 
            // btnPTegangan
            // 
            this.btnPTegangan.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPTegangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPTegangan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPTegangan.Location = new System.Drawing.Point(478, 307);
            this.btnPTegangan.Name = "btnPTegangan";
            this.btnPTegangan.Size = new System.Drawing.Size(131, 50);
            this.btnPTegangan.TabIndex = 2;
            this.btnPTegangan.Text = "Publish";
            this.btnPTegangan.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(357, 279);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 30);
            this.label16.TabIndex = 1;
            this.label16.Text = "Payload";
            // 
            // txtPPTegangan
            // 
            this.txtPPTegangan.Location = new System.Drawing.Point(357, 315);
            this.txtPPTegangan.Name = "txtPPTegangan";
            this.txtPPTegangan.Size = new System.Drawing.Size(86, 35);
            this.txtPPTegangan.TabIndex = 0;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(24, 315);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(314, 35);
            this.textBox11.TabIndex = 0;
            this.textBox11.Text = "IOTAPP/TEGANGAN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 30);
            this.label15.TabIndex = 1;
            this.label15.Text = "TEGANGAN";
            // 
            // btnPGetaran
            // 
            this.btnPGetaran.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPGetaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPGetaran.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPGetaran.Location = new System.Drawing.Point(478, 217);
            this.btnPGetaran.Name = "btnPGetaran";
            this.btnPGetaran.Size = new System.Drawing.Size(131, 50);
            this.btnPGetaran.TabIndex = 2;
            this.btnPGetaran.Text = "Publish";
            this.btnPGetaran.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(357, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 30);
            this.label14.TabIndex = 1;
            this.label14.Text = "Payload";
            // 
            // txtPPGetaran
            // 
            this.txtPPGetaran.Location = new System.Drawing.Point(357, 225);
            this.txtPPGetaran.Name = "txtPPGetaran";
            this.txtPPGetaran.Size = new System.Drawing.Size(86, 35);
            this.txtPPGetaran.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(24, 225);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(314, 35);
            this.textBox9.TabIndex = 0;
            this.textBox9.Text = "IOTAPP/GETARAN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 30);
            this.label13.TabIndex = 1;
            this.label13.Text = "GETARAN";
            // 
            // btnPKonveyor
            // 
            this.btnPKonveyor.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPKonveyor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPKonveyor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPKonveyor.Location = new System.Drawing.Point(478, 132);
            this.btnPKonveyor.Name = "btnPKonveyor";
            this.btnPKonveyor.Size = new System.Drawing.Size(131, 50);
            this.btnPKonveyor.TabIndex = 2;
            this.btnPKonveyor.Text = "Publish";
            this.btnPKonveyor.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(357, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 30);
            this.label12.TabIndex = 1;
            this.label12.Text = "Payload";
            // 
            // txtPPKonveyor
            // 
            this.txtPPKonveyor.Location = new System.Drawing.Point(357, 140);
            this.txtPPKonveyor.Name = "txtPPKonveyor";
            this.txtPPKonveyor.Size = new System.Drawing.Size(86, 35);
            this.txtPPKonveyor.TabIndex = 0;
            // 
            // txtPtKonveyor
            // 
            this.txtPtKonveyor.Location = new System.Drawing.Point(24, 140);
            this.txtPtKonveyor.Name = "txtPtKonveyor";
            this.txtPtKonveyor.Size = new System.Drawing.Size(314, 35);
            this.txtPtKonveyor.TabIndex = 0;
            this.txtPtKonveyor.Text = "IOTAPP/KONVEYOR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "KONVEYOR";
            // 
            // btnPLed
            // 
            this.btnPLed.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPLed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPLed.Location = new System.Drawing.Point(478, 47);
            this.btnPLed.Name = "btnPLed";
            this.btnPLed.Size = new System.Drawing.Size(131, 50);
            this.btnPLed.TabIndex = 2;
            this.btnPLed.Text = "Publish";
            this.btnPLed.UseVisualStyleBackColor = false;
            // 
            // txtPPLed
            // 
            this.txtPPLed.Location = new System.Drawing.Point(357, 55);
            this.txtPPLed.Name = "txtPPLed";
            this.txtPPLed.Size = new System.Drawing.Size(86, 35);
            this.txtPPLed.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Payload";
            // 
            // txtPtLed
            // 
            this.txtPtLed.Location = new System.Drawing.Point(24, 55);
            this.txtPtLed.Name = "txtPtLed";
            this.txtPtLed.Size = new System.Drawing.Size(314, 35);
            this.txtPtLed.TabIndex = 0;
            this.txtPtLed.Text = "IOTAPP/LED";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "LED";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Publish";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(702, 341);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(736, 539);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subscribe";
            this.label3.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1450, 910);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubTopic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPTegangan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPPTegangan;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPGetaran;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPPGetaran;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPKonveyor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPPKonveyor;
        private System.Windows.Forms.TextBox txtPtKonveyor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPLed;
        private System.Windows.Forms.TextBox txtPPLed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPtLed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

