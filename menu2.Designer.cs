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
            this.btntutor = new System.Windows.Forms.Button();
            this.btnwarmup = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.opt2 = new System.Windows.Forms.Button();
            this.opt1 = new System.Windows.Forms.Button();
            this.btnback2 = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a2 = new bankers_game_proto.Curvebutton();
            this.a4 = new bankers_game_proto.Curvebutton();
            this.opt3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.PortName = "COM3";
            // 
            // btntutor
            // 
            this.btntutor.BackColor = System.Drawing.Color.Transparent;
            this.btntutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntutor.FlatAppearance.BorderSize = 0;
            this.btntutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntutor.Location = new System.Drawing.Point(110, 338);
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
            this.btnwarmup.Location = new System.Drawing.Point(110, 217);
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
            this.btnback.Location = new System.Drawing.Point(110, 463);
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
            this.opt2.Location = new System.Drawing.Point(450, 296);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(235, 53);
            this.opt2.TabIndex = 7;
            this.opt2.UseVisualStyleBackColor = false;
            this.opt2.Visible = false;
            this.opt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // opt1
            // 
            this.opt1.BackColor = System.Drawing.Color.Transparent;
            this.opt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opt1.FlatAppearance.BorderSize = 0;
            this.opt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt1.Location = new System.Drawing.Point(450, 176);
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
            this.btnback2.Location = new System.Drawing.Point(450, 534);
            this.btnback2.Name = "btnback2";
            this.btnback2.Size = new System.Drawing.Size(235, 53);
            this.btnback2.TabIndex = 12;
            this.btnback2.UseVisualStyleBackColor = false;
            this.btnback2.Visible = false;
            this.btnback2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Transparent;
            this.btnmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmenu.FlatAppearance.BorderSize = 0;
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.Location = new System.Drawing.Point(382, 12);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(575, 114);
            this.btnmenu.TabIndex = 13;
            this.btnmenu.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell Extra Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(942, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 240);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.a2);
            this.groupBox2.Controls.Add(this.a4);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell Extra Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(942, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 214);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 33);
            this.label3.TabIndex = 77;
            this.label3.Text = "Hit to Enter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 33);
            this.label2.TabIndex = 76;
            this.label2.Text = "Hit to scroll down";
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.Transparent;
            this.a2.BackgroundImage = global::drumtuto_main.Properties.Resources.b2activated;
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.FlatAppearance.BorderSize = 0;
            this.a2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a2.Location = new System.Drawing.Point(31, 48);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(50, 50);
            this.a2.TabIndex = 74;
            this.a2.UseVisualStyleBackColor = false;
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.Color.Transparent;
            this.a4.BackgroundImage = global::drumtuto_main.Properties.Resources.b4activated;
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.FlatAppearance.BorderSize = 0;
            this.a4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a4.Location = new System.Drawing.Point(31, 128);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(50, 50);
            this.a4.TabIndex = 75;
            this.a4.UseVisualStyleBackColor = false;
            // 
            // opt3
            // 
            this.opt3.BackColor = System.Drawing.Color.Transparent;
            this.opt3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opt3.FlatAppearance.BorderSize = 0;
            this.opt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt3.Location = new System.Drawing.Point(450, 417);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(235, 53);
            this.opt3.TabIndex = 8;
            this.opt3.UseVisualStyleBackColor = false;
            this.opt3.Visible = false;
            this.opt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnpress);
            // 
            // menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 727);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnback2);
            this.Controls.Add(this.opt1);
            this.Controls.Add(this.opt3);
            this.Controls.Add(this.opt2);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btntutor);
            this.Controls.Add(this.btnwarmup);
            this.Name = "menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.menu2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort p1;
        private System.Windows.Forms.Button btntutor;
        private System.Windows.Forms.Button btnwarmup;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button opt2;
        private System.Windows.Forms.Button opt1;
        private System.Windows.Forms.Button btnback2;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private bankers_game_proto.Curvebutton a2;
        private bankers_game_proto.Curvebutton a4;
        private System.Windows.Forms.Button opt3;
    }
}