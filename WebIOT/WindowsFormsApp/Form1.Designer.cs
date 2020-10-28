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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTopic = new System.Windows.Forms.TextBox();
            this.panelSubscribe = new System.Windows.Forms.Panel();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelPublish = new System.Windows.Forms.Panel();
            this.btnPTegangan = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPPTegangan = new System.Windows.Forms.TextBox();
            this.txtPtTegangan = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPGetaran = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPPGetaran = new System.Windows.Forms.TextBox();
            this.txtPtGetaran = new System.Windows.Forms.TextBox();
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listSubReceive = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnStatusProcess = new System.Windows.Forms.Button();
            this.btnStatusPower = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnStartServices = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.btnShowSetting = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.panelMqttSetting = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelSubscribe.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelPublish.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelMqttSetting.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Location = new System.Drawing.Point(3, 35);
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
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
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
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.Location = new System.Drawing.Point(24, 54);
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.Size = new System.Drawing.Size(419, 35);
            this.txtSubTopic.TabIndex = 0;
            // 
            // panelSubscribe
            // 
            this.panelSubscribe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubscribe.Controls.Add(this.btnSubscribe);
            this.panelSubscribe.Controls.Add(this.label4);
            this.panelSubscribe.Controls.Add(this.txtSubTopic);
            this.panelSubscribe.Location = new System.Drawing.Point(3, 204);
            this.panelSubscribe.Name = "panelSubscribe";
            this.panelSubscribe.Size = new System.Drawing.Size(632, 114);
            this.panelSubscribe.TabIndex = 0;
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
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Host";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Subscribe";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1992, 115);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1772, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 115);
            this.button1.TabIndex = 1;
            this.button1.Text = "<>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumPurple;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(1882, 0);
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
            // PanelPublish
            // 
            this.PanelPublish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPublish.Controls.Add(this.btnPTegangan);
            this.PanelPublish.Controls.Add(this.label16);
            this.PanelPublish.Controls.Add(this.txtPPTegangan);
            this.PanelPublish.Controls.Add(this.txtPtTegangan);
            this.PanelPublish.Controls.Add(this.label15);
            this.PanelPublish.Controls.Add(this.btnPGetaran);
            this.PanelPublish.Controls.Add(this.label14);
            this.PanelPublish.Controls.Add(this.txtPPGetaran);
            this.PanelPublish.Controls.Add(this.txtPtGetaran);
            this.PanelPublish.Controls.Add(this.label13);
            this.PanelPublish.Controls.Add(this.btnPKonveyor);
            this.PanelPublish.Controls.Add(this.label12);
            this.PanelPublish.Controls.Add(this.txtPPKonveyor);
            this.PanelPublish.Controls.Add(this.txtPtKonveyor);
            this.PanelPublish.Controls.Add(this.label11);
            this.PanelPublish.Controls.Add(this.btnPLed);
            this.PanelPublish.Controls.Add(this.txtPPLed);
            this.PanelPublish.Controls.Add(this.label10);
            this.PanelPublish.Controls.Add(this.txtPtLed);
            this.PanelPublish.Controls.Add(this.label8);
            this.PanelPublish.Location = new System.Drawing.Point(3, 359);
            this.PanelPublish.Name = "PanelPublish";
            this.PanelPublish.Size = new System.Drawing.Size(632, 384);
            this.PanelPublish.TabIndex = 0;
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
            this.btnPTegangan.Click += new System.EventHandler(this.btnPTegangan_Click);
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
            this.txtPPTegangan.Text = "0";
            this.txtPPTegangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPtTegangan
            // 
            this.txtPtTegangan.Location = new System.Drawing.Point(24, 315);
            this.txtPtTegangan.Name = "txtPtTegangan";
            this.txtPtTegangan.Size = new System.Drawing.Size(314, 35);
            this.txtPtTegangan.TabIndex = 0;
            this.txtPtTegangan.Text = "IOTAPP/TEGANGAN";
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
            this.btnPGetaran.Click += new System.EventHandler(this.btnPGetaran_Click);
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
            this.txtPPGetaran.Text = "0";
            this.txtPPGetaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPtGetaran
            // 
            this.txtPtGetaran.Location = new System.Drawing.Point(24, 225);
            this.txtPtGetaran.Name = "txtPtGetaran";
            this.txtPtGetaran.Size = new System.Drawing.Size(314, 35);
            this.txtPtGetaran.TabIndex = 0;
            this.txtPtGetaran.Text = "IOTAPP/GETARAN";
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
            this.btnPKonveyor.Click += new System.EventHandler(this.btnPKonveyor_Click);
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
            this.txtPPKonveyor.Text = "0";
            this.txtPPKonveyor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnPLed.Click += new System.EventHandler(this.btnPLed_Click);
            // 
            // txtPPLed
            // 
            this.txtPPLed.Location = new System.Drawing.Point(357, 55);
            this.txtPPLed.Name = "txtPPLed";
            this.txtPPLed.Size = new System.Drawing.Size(86, 35);
            this.txtPPLed.TabIndex = 0;
            this.txtPPLed.Text = "0";
            this.txtPPLed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label9.Location = new System.Drawing.Point(3, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Publish";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(18, 266);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(819, 384);
            this.txtResult.TabIndex = 3;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Result";
            // 
            // listSubReceive
            // 
            this.listSubReceive.FormattingEnabled = true;
            this.listSubReceive.ItemHeight = 30;
            this.listSubReceive.Location = new System.Drawing.Point(18, 41);
            this.listSubReceive.Name = "listSubReceive";
            this.listSubReceive.Size = new System.Drawing.Size(819, 184);
            this.listSubReceive.TabIndex = 4;
            this.listSubReceive.SelectedIndexChanged += new System.EventHandler(this.listSubReceive_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 30);
            this.label17.TabIndex = 1;
            this.label17.Text = "Result";
            // 
            // btnStatusProcess
            // 
            this.btnStatusProcess.BackColor = System.Drawing.Color.DeepPink;
            this.btnStatusProcess.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnStatusProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusProcess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatusProcess.Location = new System.Drawing.Point(521, 44);
            this.btnStatusProcess.Name = "btnStatusProcess";
            this.btnStatusProcess.Size = new System.Drawing.Size(131, 50);
            this.btnStatusProcess.TabIndex = 2;
            this.btnStatusProcess.Text = "Error";
            this.btnStatusProcess.UseVisualStyleBackColor = false;
            // 
            // btnStatusPower
            // 
            this.btnStatusPower.BackColor = System.Drawing.Color.DeepPink;
            this.btnStatusPower.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnStatusPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatusPower.Location = new System.Drawing.Point(352, 45);
            this.btnStatusPower.Name = "btnStatusPower";
            this.btnStatusPower.Size = new System.Drawing.Size(131, 50);
            this.btnStatusPower.TabIndex = 2;
            this.btnStatusPower.Text = "Stop";
            this.btnStatusPower.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(352, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 30);
            this.label18.TabIndex = 1;
            this.label18.Text = "Status Power";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(521, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 30);
            this.label19.TabIndex = 1;
            this.label19.Text = "Status Proses";
            // 
            // btnStartServices
            // 
            this.btnStartServices.BackColor = System.Drawing.Color.DeepPink;
            this.btnStartServices.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnStartServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartServices.Location = new System.Drawing.Point(177, 45);
            this.btnStartServices.Name = "btnStartServices";
            this.btnStartServices.Size = new System.Drawing.Size(131, 50);
            this.btnStartServices.TabIndex = 2;
            this.btnStartServices.Text = "Start";
            this.btnStartServices.UseVisualStyleBackColor = false;
            this.btnStartServices.Click += new System.EventHandler(this.button1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(177, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 30);
            this.label20.TabIndex = 1;
            this.label20.Text = "Run Services";
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.label17);
            this.panelResult.Controls.Add(this.txtResult);
            this.panelResult.Controls.Add(this.label3);
            this.panelResult.Controls.Add(this.listSubReceive);
            this.panelResult.Location = new System.Drawing.Point(672, 256);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(861, 670);
            this.panelResult.TabIndex = 5;
            // 
            // btnShowSetting
            // 
            this.btnShowSetting.BackColor = System.Drawing.Color.MediumPurple;
            this.btnShowSetting.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnShowSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowSetting.Location = new System.Drawing.Point(18, 44);
            this.btnShowSetting.Name = "btnShowSetting";
            this.btnShowSetting.Size = new System.Drawing.Size(131, 50);
            this.btnShowSetting.TabIndex = 2;
            this.btnShowSetting.Text = "Show";
            this.btnShowSetting.UseVisualStyleBackColor = false;
            this.btnShowSetting.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(129, 30);
            this.label21.TabIndex = 1;
            this.label21.Text = "Mqtt Setting";
            // 
            // panelMqttSetting
            // 
            this.panelMqttSetting.Controls.Add(this.panel1);
            this.panelMqttSetting.Controls.Add(this.panelSubscribe);
            this.panelMqttSetting.Controls.Add(this.label5);
            this.panelMqttSetting.Controls.Add(this.label6);
            this.panelMqttSetting.Controls.Add(this.PanelPublish);
            this.panelMqttSetting.Controls.Add(this.label9);
            this.panelMqttSetting.Location = new System.Drawing.Point(12, 148);
            this.panelMqttSetting.Name = "panelMqttSetting";
            this.panelMqttSetting.Size = new System.Drawing.Size(638, 778);
            this.panelMqttSetting.TabIndex = 6;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.button2);
            this.panelControl.Controls.Add(this.label22);
            this.panelControl.Controls.Add(this.label21);
            this.panelControl.Controls.Add(this.btnStatusPower);
            this.panelControl.Controls.Add(this.label18);
            this.panelControl.Controls.Add(this.btnShowSetting);
            this.panelControl.Controls.Add(this.btnStatusProcess);
            this.panelControl.Controls.Add(this.label19);
            this.panelControl.Controls.Add(this.label20);
            this.panelControl.Controls.Add(this.btnStartServices);
            this.panelControl.Location = new System.Drawing.Point(672, 147);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(861, 103);
            this.panelControl.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(706, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(691, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 30);
            this.label22.TabIndex = 1;
            this.label22.Text = "Modbus Setting";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "IOT Services is Running";
            this.notifyIcon1.BalloonTipTitle = "IOT Apps";
            this.notifyIcon1.Text = "IOT Gateway Services";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(1548, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 778);
            this.panel2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 35);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1992, 957);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelMqttSetting);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status Proses";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSubscribe.ResumeLayout(false);
            this.panelSubscribe.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelPublish.ResumeLayout(false);
            this.PanelPublish.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelMqttSetting.ResumeLayout(false);
            this.panelMqttSetting.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubTopic;
        private System.Windows.Forms.Panel panelSubscribe;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PanelPublish;
        private System.Windows.Forms.Button btnPTegangan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPPTegangan;
        private System.Windows.Forms.TextBox txtPtTegangan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPGetaran;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPPGetaran;
        private System.Windows.Forms.TextBox txtPtGetaran;
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
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listSubReceive;
        private System.Windows.Forms.Button btnStatusProcess;
        private System.Windows.Forms.Label label17;
        
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnStatusPower;
        private System.Windows.Forms.Button btnStartServices;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button btnShowSetting;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panelMqttSetting;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

