namespace drumtuto_main
{
    partial class menu2
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
            this.p1 = new System.IO.Ports.SerialPort(this.components);
            this.btnmusic = new System.Windows.Forms.Button();
            this.btntutor = new System.Windows.Forms.Button();
            this.btnwarmup = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.opt2 = new System.Windows.Forms.Button();
            this.opt3 = new System.Windows.Forms.Button();
            this.opt4 = new System.Windows.Forms.Button();
            this.opt5 = new System.Windows.Forms.Button();
            this.opt1 = new System.Windows.Forms.Button();
            this.btnback2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.PortName = "COM3";
            this.p1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.p1_DataReceived);
            // 
            // btnmusic
            // 
            this.btnmusic.BackColor = System.Drawing.Color.Transparent;
            this.btnmusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmusic.FlatAppearance.BorderSize = 0;
            this.btnmusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmusic.Location = new System.Drawing.Point(55, 457);
            this.btnmusic.Name = "btnmusic";
            this.btnmusic.Size = new System.Drawing.Size(235, 53);
            this.btnmusic.TabIndex = 5;
            this.btnmusic.UseVisualStyleBackColor = false;
            this.btnmusic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // btntutor
            // 
            this.btntutor.BackColor = System.Drawing.Color.Transparent;
            this.btntutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntutor.FlatAppearance.BorderSize = 0;
            this.btntutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntutor.Location = new System.Drawing.Point(55, 337);
            this.btntutor.Name = "btntutor";
            this.btntutor.Size = new System.Drawing.Size(235, 53);
            this.btntutor.TabIndex = 4;
            this.btntutor.UseVisualStyleBackColor = false;
            this.btntutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // btnwarmup
            // 
            this.btnwarmup.BackColor = System.Drawing.Color.Transparent;
            this.btnwarmup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnwarmup.FlatAppearance.BorderSize = 0;
            this.btnwarmup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwarmup.Location = new System.Drawing.Point(55, 216);
            this.btnwarmup.Name = "btnwarmup";
            this.btnwarmup.Size = new System.Drawing.Size(235, 53);
            this.btnwarmup.TabIndex = 3;
            this.btnwarmup.UseVisualStyleBackColor = false;
            this.btnwarmup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(55, 575);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(235, 53);
            this.btnback.TabIndex = 6;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // opt2
            // 
            this.opt2.BackColor = System.Drawing.Color.Transparent;
            this.opt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opt2.FlatAppearance.BorderSize = 0;
            this.opt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt2.Location = new System.Drawing.Point(380, 149);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(235, 53);
            this.opt2.TabIndex = 7;
            this.opt2.UseVisualStyleBackColor = false;
            this.opt2.Visible = false;
            this.opt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // opt3
            // 
            this.opt3.BackColor = System.Drawing.Color.Transparent;
            this.opt3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opt3.FlatAppearance.BorderSize = 0;
            this.opt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt3.Location = new System.Drawing.Point(380, 270);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(235, 53);
            this.opt3.TabIndex = 8;
            this.opt3.UseVisualStyleBackColor = false;
            this.opt3.Visible = false;
            this.opt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // opt4
            // 
            this.opt4.BackColor = System.Drawing.Color.Transparent;
            this.opt4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opt4.FlatAppearance.BorderSize = 0;
            this.opt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt4.Location = new System.Drawing.Point(380, 390);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(235, 53);
            this.opt4.TabIndex = 9;
            this.opt4.UseVisualStyleBackColor = false;
            this.opt4.Visible = false;
            this.opt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // opt5
            // 
            this.opt5.BackColor = System.Drawing.Color.Transparent;
            this.opt5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opt5.FlatAppearance.BorderSize = 0;
            this.opt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt5.Location = new System.Drawing.Point(380, 512);
            this.opt5.Name = "opt5";
            this.opt5.Size = new System.Drawing.Size(235, 53);
            this.opt5.TabIndex = 10;
            this.opt5.UseVisualStyleBackColor = false;
            this.opt5.Visible = false;
            this.opt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // opt1
            // 
            this.opt1.BackColor = System.Drawing.Color.Transparent;
            this.opt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opt1.FlatAppearance.BorderSize = 0;
            this.opt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt1.Location = new System.Drawing.Point(380, 29);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(235, 53);
            this.opt1.TabIndex = 11;
            this.opt1.UseVisualStyleBackColor = false;
            this.opt1.Visible = false;
            this.opt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // btnback2
            // 
            this.btnback2.BackColor = System.Drawing.Color.Transparent;
            this.btnback2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback2.FlatAppearance.BorderSize = 0;
            this.btnback2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback2.Location = new System.Drawing.Point(380, 630);
            this.btnback2.Name = "btnback2";
            this.btnback2.Size = new System.Drawing.Size(235, 53);
            this.btnback2.TabIndex = 12;
            this.btnback2.UseVisualStyleBackColor = false;
            this.btnback2.Visible = false;
            this.btnback2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 727);
            this.Controls.Add(this.btnback2);
            this.Controls.Add(this.opt1);
            this.Controls.Add(this.opt5);
            this.Controls.Add(this.opt4);
            this.Controls.Add(this.opt3);
            this.Controls.Add(this.opt2);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnmusic);
            this.Controls.Add(this.btntutor);
            this.Controls.Add(this.btnwarmup);
            this.Name = "menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu2";
            this.Load += new System.EventHandler(this.menu2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort p1;
        private System.Windows.Forms.Button btnmusic;
        private System.Windows.Forms.Button btntutor;
        private System.Windows.Forms.Button btnwarmup;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button opt2;
        private System.Windows.Forms.Button opt3;
        private System.Windows.Forms.Button opt4;
        private System.Windows.Forms.Button opt5;
        private System.Windows.Forms.Button opt1;
        private System.Windows.Forms.Button btnback2;
    }
}