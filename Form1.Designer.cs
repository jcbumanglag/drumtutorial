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
            this.main = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbtitle = new System.Windows.Forms.PictureBox();
            this.a2 = new bankers_game_proto.Curvebutton();
            this.a4 = new bankers_game_proto.Curvebutton();
            this.main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtitle)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.Transparent;
            this.main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main.Controls.Add(this.groupBox1);
            this.main.Controls.Add(this.pbtitle);
            this.main.Controls.Add(this.btnexit);
            this.main.Controls.Add(this.btnsettings);
            this.main.Controls.Add(this.btnstart);
            this.main.Controls.Add(this.groupBox2);
            this.main.Location = new System.Drawing.Point(0, -17);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1354, 754);
            this.main.TabIndex = 0;
            this.main.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(227, 523);
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
            this.btnsettings.Location = new System.Drawing.Point(227, 403);
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
            this.btnstart.Location = new System.Drawing.Point(227, 282);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(235, 53);
            this.btnstart.TabIndex = 0;
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnch);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell Extra Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(944, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 240);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.a2);
            this.groupBox2.Controls.Add(this.a4);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell Extra Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(944, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 214);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
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
            // pbtitle
            // 
            this.pbtitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtitle.Location = new System.Drawing.Point(227, -21);
            this.pbtitle.Name = "pbtitle";
            this.pbtitle.Size = new System.Drawing.Size(858, 271);
            this.pbtitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtitle.TabIndex = 3;
            this.pbtitle.TabStop = false;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox main;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.PictureBox pbtitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private bankers_game_proto.Curvebutton a2;
        private bankers_game_proto.Curvebutton a4;
    }
}

