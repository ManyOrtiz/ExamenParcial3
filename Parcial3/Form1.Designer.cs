namespace Parcial3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OBJ_LOAD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LIGHT_BTN = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.STOP_BTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonZ = new System.Windows.Forms.Button();
            this.ButtonX = new System.Windows.Forms.Button();
            this.ButtonY = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.OBJ_LOAD);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1617, 51);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // OBJ_LOAD
            // 
            this.OBJ_LOAD.Location = new System.Drawing.Point(409, 11);
            this.OBJ_LOAD.Margin = new System.Windows.Forms.Padding(4);
            this.OBJ_LOAD.Name = "OBJ_LOAD";
            this.OBJ_LOAD.Size = new System.Drawing.Size(100, 28);
            this.OBJ_LOAD.TabIndex = 2;
            this.OBJ_LOAD.Text = "LOAD";
            this.OBJ_LOAD.UseVisualStyleBackColor = true;
            this.OBJ_LOAD.Click += new System.EventHandler(this.OBJ_LOAD_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "RUTA DEL OBJ:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1552, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 745);
            this.panel3.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar1.Location = new System.Drawing.Point(9, 0);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 745);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 40;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.LIGHT_BTN);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(91, 745);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Parcial3.Properties.Resources.among_us_sus;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 553);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // LIGHT_BTN
            // 
            this.LIGHT_BTN.Location = new System.Drawing.Point(5, 73);
            this.LIGHT_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.LIGHT_BTN.Name = "LIGHT_BTN";
            this.LIGHT_BTN.Size = new System.Drawing.Size(79, 28);
            this.LIGHT_BTN.TabIndex = 4;
            this.LIGHT_BTN.Text = "POWER";
            this.LIGHT_BTN.UseVisualStyleBackColor = true;
            this.LIGHT_BTN.Click += new System.EventHandler(this.LIGHT_BTN_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 790);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel5.Controls.Add(this.STOP_BTN);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.ButtonZ);
            this.panel5.Controls.Add(this.ButtonX);
            this.panel5.Controls.Add(this.ButtonY);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(91, 695);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1461, 101);
            this.panel5.TabIndex = 5;
            // 
            // STOP_BTN
            // 
            this.STOP_BTN.ForeColor = System.Drawing.Color.Yellow;
            this.STOP_BTN.Image = global::Parcial3.Properties.Resources.OIP;
            this.STOP_BTN.Location = new System.Drawing.Point(385, 25);
            this.STOP_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.STOP_BTN.Name = "STOP_BTN";
            this.STOP_BTN.Size = new System.Drawing.Size(149, 43);
            this.STOP_BTN.TabIndex = 4;
            this.STOP_BTN.Text = "PAUSE";
            this.STOP_BTN.UseVisualStyleBackColor = true;
            this.STOP_BTN.Click += new System.EventHandler(this.STOP_BTN_Click_1);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1461, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "RAND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ButtonZ
            // 
            this.ButtonZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonZ.ForeColor = System.Drawing.Color.Cyan;
            this.ButtonZ.Image = global::Parcial3.Properties.Resources.OIP;
            this.ButtonZ.Location = new System.Drawing.Point(1044, 25);
            this.ButtonZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonZ.Name = "ButtonZ";
            this.ButtonZ.Size = new System.Drawing.Size(145, 43);
            this.ButtonZ.TabIndex = 2;
            this.ButtonZ.Text = "Rotacion Z";
            this.ButtonZ.UseVisualStyleBackColor = true;
            this.ButtonZ.Click += new System.EventHandler(this.ButtonZ_Click_1);
            // 
            // ButtonX
            // 
            this.ButtonX.ForeColor = System.Drawing.Color.Lime;
            this.ButtonX.Image = global::Parcial3.Properties.Resources.OIP;
            this.ButtonX.Location = new System.Drawing.Point(601, 25);
            this.ButtonX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonX.Name = "ButtonX";
            this.ButtonX.Size = new System.Drawing.Size(149, 43);
            this.ButtonX.TabIndex = 0;
            this.ButtonX.Text = " Rotacion X";
            this.ButtonX.UseVisualStyleBackColor = true;
            this.ButtonX.Click += new System.EventHandler(this.ButtonX_Click_1);
            // 
            // ButtonY
            // 
            this.ButtonY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonY.ForeColor = System.Drawing.Color.White;
            this.ButtonY.Image = global::Parcial3.Properties.Resources.OIP;
            this.ButtonY.Location = new System.Drawing.Point(827, 25);
            this.ButtonY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonY.Name = "ButtonY";
            this.ButtonY.Size = new System.Drawing.Size(147, 43);
            this.ButtonY.TabIndex = 1;
            this.ButtonY.Text = "Rotacion Y";
            this.ButtonY.UseVisualStyleBackColor = true;
            this.ButtonY.Click += new System.EventHandler(this.ButtonY_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(91, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1461, 745);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 796);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OBJ_LOAD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button LIGHT_BTN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button STOP_BTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonZ;
        private System.Windows.Forms.Button ButtonX;
        private System.Windows.Forms.Button ButtonY;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

