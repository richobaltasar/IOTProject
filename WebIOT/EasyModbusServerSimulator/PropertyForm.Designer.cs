namespace EasyModbusServerSimulator
{
    partial class PropertyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyForm));
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btnDischard = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(6, 2);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(513, 380);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.Click += new System.EventHandler(this.propertyGrid1_Click);
            // 
            // btnDischard
            // 
            this.btnDischard.Image = ((System.Drawing.Image)(resources.GetObject("btnDischard.Image")));
            this.btnDischard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDischard.Location = new System.Drawing.Point(6, 421);
            this.btnDischard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDischard.Name = "btnDischard";
            this.btnDischard.Size = new System.Drawing.Size(138, 103);
            this.btnDischard.TabIndex = 37;
            this.btnDischard.Text = "Dischard";
            this.btnDischard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDischard.UseVisualStyleBackColor = true;
            this.btnDischard.Click += new System.EventHandler(this.btnDischard_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccept.Location = new System.Drawing.Point(378, 421);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(138, 103);
            this.btnAccept.TabIndex = 38;
            this.btnAccept.Text = "Accept";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // PropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 528);
            this.ControlBox = false;
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnDischard);
            this.Controls.Add(this.propertyGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PropertyForm";
            this.Text = "Properties";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnDischard;
        private System.Windows.Forms.Button btnAccept;
    }
}