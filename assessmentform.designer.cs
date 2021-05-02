namespace drumtuto_main
{
    partial class assessmentform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assessmentform));
            this.pbstars1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalscore1 = new System.Windows.Forms.Label();
            this.multi1 = new System.Windows.Forms.Label();
            this.miss1 = new System.Windows.Forms.Label();
            this.good1 = new System.Windows.Forms.Label();
            this.great1 = new System.Windows.Forms.Label();
            this.perfect1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnexit = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.port1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbstars1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbstars1
            // 
            this.pbstars1.BackColor = System.Drawing.Color.Transparent;
            this.pbstars1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbstars1.Location = new System.Drawing.Point(408, 12);
            this.pbstars1.Name = "pbstars1";
            this.pbstars1.Size = new System.Drawing.Size(567, 125);
            this.pbstars1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbstars1.TabIndex = 0;
            this.pbstars1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.totalscore1);
            this.groupBox1.Controls.Add(this.multi1);
            this.groupBox1.Controls.Add(this.miss1);
            this.groupBox1.Controls.Add(this.good1);
            this.groupBox1.Controls.Add(this.great1);
            this.groupBox1.Controls.Add(this.perfect1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell Extra Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1277, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assessment";
            // 
            // totalscore1
            // 
            this.totalscore1.AutoSize = true;
            this.totalscore1.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalscore1.Location = new System.Drawing.Point(949, 418);
            this.totalscore1.Name = "totalscore1";
            this.totalscore1.Size = new System.Drawing.Size(39, 37);
            this.totalscore1.TabIndex = 6;
            this.totalscore1.Text = "0";
            // 
            // multi1
            // 
            this.multi1.AutoSize = true;
            this.multi1.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi1.Location = new System.Drawing.Point(1096, 343);
            this.multi1.Name = "multi1";
            this.multi1.Size = new System.Drawing.Size(39, 37);
            this.multi1.TabIndex = 5;
            this.multi1.Text = "0";
            // 
            // miss1
            // 
            this.miss1.AutoSize = true;
            this.miss1.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miss1.Location = new System.Drawing.Point(1096, 268);
            this.miss1.Name = "miss1";
            this.miss1.Size = new System.Drawing.Size(39, 37);
            this.miss1.TabIndex = 4;
            this.miss1.Text = "0";
            // 
            // good1
            // 
            this.good1.AutoSize = true;
            this.good1.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.good1.Location = new System.Drawing.Point(1096, 193);
            this.good1.Name = "good1";
            this.good1.Size = new System.Drawing.Size(39, 37);
            this.good1.TabIndex = 3;
            this.good1.Text = "0";
            // 
            // great1
            // 
            this.great1.AutoSize = true;
            this.great1.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.great1.Location = new System.Drawing.Point(1096, 122);
            this.great1.Name = "great1";
            this.great1.Size = new System.Drawing.Size(39, 37);
            this.great1.TabIndex = 2;
            this.great1.Text = "0";
            // 
            // perfect1
            // 
            this.perfect1.AutoSize = true;
            this.perfect1.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfect1.Location = new System.Drawing.Point(1096, 48);
            this.perfect1.Name = "perfect1";
            this.perfect1.Size = new System.Drawing.Size(39, 37);
            this.perfect1.TabIndex = 1;
            this.perfect1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 407);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackgroundImage = global::drumtuto_main.Properties.Resources.btnquit;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(1000, 609);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(289, 72);
            this.btnexit.TabIndex = 10;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            this.btnexit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonpress1);
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.Color.Transparent;
            this.btnrestart.BackgroundImage = global::drumtuto_main.Properties.Resources.btnrestart;
            this.btnrestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrestart.FlatAppearance.BorderSize = 0;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestart.Location = new System.Drawing.Point(586, 609);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(289, 72);
            this.btnrestart.TabIndex = 9;
            this.btnrestart.UseVisualStyleBackColor = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            this.btnrestart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonpress1);
            // 
            // port1
            // 
            this.port1.PortName = "COM3";
            // 
            // assessmentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::drumtuto_main.Properties.Resources.Drumstick_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 693);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbstars1);
            this.Name = "assessmentform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.assessmentform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbstars1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbstars1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalscore1;
        private System.Windows.Forms.Label multi1;
        private System.Windows.Forms.Label miss1;
        private System.Windows.Forms.Label good1;
        private System.Windows.Forms.Label great1;
        private System.Windows.Forms.Label perfect1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnrestart;
        private System.IO.Ports.SerialPort port1;
    }
}