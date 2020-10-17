namespace ModbusServerRTU
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtConnectionTimeOut = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtSlaveAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComPort = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dg_DI = new System.Windows.Forms.DataGridView();
            this.Address_DI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_DI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dg_Coils = new System.Windows.Forms.DataGridView();
            this.Address_Coils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_Coils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dg_IR = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dg_HoldReg = new System.Windows.Forms.DataGridView();
            this.Add_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_IR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value_IR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DI)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Coils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_IR)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_HoldReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "ComPort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "ConnectionTimeout ";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(289, 78);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(232, 35);
            this.txtBaudRate.TabIndex = 0;
            this.txtBaudRate.Text = "9600";
            // 
            // txtConnectionTimeOut
            // 
            this.txtConnectionTimeOut.Location = new System.Drawing.Point(289, 129);
            this.txtConnectionTimeOut.Name = "txtConnectionTimeOut";
            this.txtConnectionTimeOut.Size = new System.Drawing.Size(232, 35);
            this.txtConnectionTimeOut.TabIndex = 0;
            this.txtConnectionTimeOut.Text = "100";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(390, 221);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(131, 40);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSlaveAddress
            // 
            this.txtSlaveAddress.Location = new System.Drawing.Point(289, 180);
            this.txtSlaveAddress.Name = "txtSlaveAddress";
            this.txtSlaveAddress.Size = new System.Drawing.Size(232, 35);
            this.txtSlaveAddress.TabIndex = 0;
            this.txtSlaveAddress.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Slave Address";
            // 
            // txtComPort
            // 
            this.txtComPort.FormattingEnabled = true;
            this.txtComPort.Location = new System.Drawing.Point(289, 29);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(232, 38);
            this.txtComPort.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(13, 284);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 484);
            this.listBox1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(559, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 3;
            this.tabControl1.Size = new System.Drawing.Size(860, 690);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dg_DI);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Discrete Inputs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dg_DI
            // 
            this.dg_DI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address_DI,
            this.Value_DI});
            this.dg_DI.Location = new System.Drawing.Point(31, 8);
            this.dg_DI.Name = "dg_DI";
            this.dg_DI.RowHeadersWidth = 72;
            this.dg_DI.Size = new System.Drawing.Size(791, 665);
            this.dg_DI.TabIndex = 0;
            this.dg_DI.Text = "dataGridView2";
            // 
            // Address_DI
            // 
            this.Address_DI.HeaderText = "Address";
            this.Address_DI.MinimumWidth = 9;
            this.Address_DI.Name = "Address_DI";
            this.Address_DI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Address_DI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address_DI.Width = 175;
            // 
            // Value_DI
            // 
            this.Value_DI.HeaderText = "Value";
            this.Value_DI.MinimumWidth = 9;
            this.Value_DI.Name = "Value_DI";
            this.Value_DI.Width = 175;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg_Coils);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coils";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dg_Coils
            // 
            this.dg_Coils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Coils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address_Coils,
            this.Value_Coils});
            this.dg_Coils.Location = new System.Drawing.Point(29, 12);
            this.dg_Coils.Name = "dg_Coils";
            this.dg_Coils.RowHeadersWidth = 72;
            this.dg_Coils.Size = new System.Drawing.Size(791, 665);
            this.dg_Coils.TabIndex = 0;
            this.dg_Coils.Text = "dataGridView2";
            // 
            // Address_Coils
            // 
            this.Address_Coils.HeaderText = "Address";
            this.Address_Coils.MinimumWidth = 9;
            this.Address_Coils.Name = "Address_Coils";
            this.Address_Coils.Width = 175;
            // 
            // Value_Coils
            // 
            this.Value_Coils.HeaderText = "Value";
            this.Value_Coils.MinimumWidth = 9;
            this.Value_Coils.Name = "Value_Coils";
            this.Value_Coils.Width = 175;
            // 
            // tabPage3
            // 
            // 
            // dg_IR
            // 
            this.dg_IR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_IR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address_IR,
            this.Value_IR});
            this.dg_IR.Location = new System.Drawing.Point(30, 14);
            this.dg_IR.Name = "dg_IR";
            this.dg_IR.RowHeadersWidth = 72;
            this.dg_IR.Size = new System.Drawing.Size(791, 612);
            this.dg_IR.TabIndex = 0;
            this.dg_IR.Text = "dataGridView2";
            this.tabPage3.Controls.Add(this.dg_IR);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(852, 647);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Input Resgisters";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dg_HoldReg);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(852, 647);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Holding Registers";
            // 
            // dg_HoldReg
            // 
            this.dg_HoldReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_HoldReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add_HR,
            this.Value_HR});
            this.dg_HoldReg.Location = new System.Drawing.Point(23, 18);
            this.dg_HoldReg.Name = "dg_HoldReg";
            this.dg_HoldReg.RowHeadersWidth = 72;
            this.dg_HoldReg.Size = new System.Drawing.Size(791, 665);
            this.dg_HoldReg.TabIndex = 0;
            this.dg_HoldReg.Text = "dataGridView2";
            // 
            // Add_HR
            // 
            this.Add_HR.HeaderText = "Address";
            this.Add_HR.MinimumWidth = 9;
            this.Add_HR.Name = "Add_HR";
            this.Add_HR.Width = 175;
            // 
            // Value_HR
            // 
            this.Value_HR.HeaderText = "Value";
            this.Value_HR.MinimumWidth = 9;
            this.Value_HR.Name = "Value_HR";
            this.Value_HR.Width = 175;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1210, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(210, 35);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1023, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Move to Address";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Holding Register";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Value";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // Address_IR
            // 
            this.Address_IR.HeaderText = "Address";
            this.Address_IR.MinimumWidth = 9;
            this.Address_IR.Name = "Address_IR";
            this.Address_IR.Width = 175;
            // 
            // Value_IR
            // 
            this.Value_IR.HeaderText = "Value";
            this.Value_IR.MinimumWidth = 9;
            this.Value_IR.Name = "Value_IR";
            this.Value_IR.Width = 175;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 784);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtComPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSlaveAddress);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtConnectionTimeOut);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DI)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Coils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_IR)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_HoldReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.TextBox txtConnectionTimeOut;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtSlaveAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtComPort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dg_HoldReg;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dg_DI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_DI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_DI;
        private System.Windows.Forms.DataGridView dg_Coils;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Coils;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_Coils;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dg_IR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_HR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_HR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_IR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_IR;
    }
}

