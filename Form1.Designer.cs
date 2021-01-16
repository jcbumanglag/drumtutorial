namespace drumtuto_main
{
    partial class menu
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
            this.main = new System.Windows.Forms.GroupBox();
            this.pbtitle = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.p1 = new System.IO.Ports.SerialPort(this.components);
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtitle)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.Transparent;
            this.main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main.Controls.Add(this.pbtitle);
            this.main.Controls.Add(this.btnexit);
            this.main.Controls.Add(this.btnsettings);
            this.main.Controls.Add(this.btnstart);
            this.main.Location = new System.Drawing.Point(0, -17);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1354, 754);
            this.main.TabIndex = 0;
            this.main.TabStop = false;
            // 
            // pbtitle
            // 
            this.pbtitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtitle.Location = new System.Drawing.Point(394, -21);
            this.pbtitle.Name = "pbtitle";
            this.pbtitle.Size = new System.Drawing.Size(584, 203);
            this.pbtitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtitle.TabIndex = 3;
            this.pbtitle.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(109, 492);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(235, 53);
            this.btnexit.TabIndex = 2;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnch);
            // 
            // btnsettings
            // 
            this.btnsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Location = new System.Drawing.Point(109, 372);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(235, 53);
            this.btnsettings.TabIndex = 1;
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnch);
            // 
            // btnstart
            // 
            this.btnstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstart.FlatAppearance.BorderSize = 0;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Location = new System.Drawing.Point(109, 251);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(235, 53);
            this.btnstart.TabIndex = 0;
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnch);
            // 
            // p1
            // 
            this.p1.PortName = "COM3";
            this.p1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.p1_DataReceived);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 735);
            this.ControlBox = false;
            this.Controls.Add(this.main);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.menu_Load);
            this.main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbtitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox main;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.PictureBox pbtitle;
        private System.IO.Ports.SerialPort p1;
    }
}

