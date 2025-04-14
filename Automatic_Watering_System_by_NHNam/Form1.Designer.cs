namespace Automatic_Watering_System_by_NHNam
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtmois = new System.Windows.Forms.TextBox();
            this.scom = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbcom = new System.Windows.Forms.ComboBox();
            this.cbbbaud = new System.Windows.Forms.ComboBox();
            this.bconnect = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bsend = new System.Windows.Forms.Button();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.lstatus = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.bmode = new System.Windows.Forms.Button();
            this.brelay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btimer = new System.Windows.Forms.Button();
            this.numhour = new System.Windows.Forms.NumericUpDown();
            this.numminute = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.Comunication = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numminute)).BeginInit();
            this.Comunication.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmois
            // 
            this.txtmois.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmois.BackColor = System.Drawing.SystemColors.Control;
            this.txtmois.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmois.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtmois.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmois.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtmois.Location = new System.Drawing.Point(7, 28);
            this.txtmois.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmois.Name = "txtmois";
            this.txtmois.ReadOnly = true;
            this.txtmois.Size = new System.Drawing.Size(219, 98);
            this.txtmois.TabIndex = 0;
            this.txtmois.Text = "0";
            this.txtmois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scom
            // 
            this.scom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.scom_DataReceived);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "COM:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baudrate:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbcom
            // 
            this.cbbcom.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbcom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbbcom.FormattingEnabled = true;
            this.cbbcom.Location = new System.Drawing.Point(77, 24);
            this.cbbcom.Name = "cbbcom";
            this.cbbcom.Size = new System.Drawing.Size(73, 29);
            this.cbbcom.TabIndex = 4;
            // 
            // cbbbaud
            // 
            this.cbbbaud.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbbaud.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbbbaud.FormattingEnabled = true;
            this.cbbbaud.Location = new System.Drawing.Point(278, 24);
            this.cbbbaud.Name = "cbbbaud";
            this.cbbbaud.Size = new System.Drawing.Size(100, 29);
            this.cbbbaud.TabIndex = 5;
            // 
            // bconnect
            // 
            this.bconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(102)))));
            this.bconnect.Location = new System.Drawing.Point(425, 18);
            this.bconnect.Name = "bconnect";
            this.bconnect.Size = new System.Drawing.Size(137, 38);
            this.bconnect.TabIndex = 6;
            this.bconnect.Text = "CONNECT";
            this.bconnect.UseVisualStyleBackColor = false;
            this.bconnect.Click += new System.EventHandler(this.bconnect_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ForeColor = System.Drawing.Color.Teal;
            this.numericUpDown1.Location = new System.Drawing.Point(126, 115);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(146, 36);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // bsend
            // 
            this.bsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bsend.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsend.ForeColor = System.Drawing.Color.Teal;
            this.bsend.Location = new System.Drawing.Point(486, 179);
            this.bsend.Name = "bsend";
            this.bsend.Size = new System.Drawing.Size(146, 36);
            this.bsend.TabIndex = 10;
            this.bsend.Text = "SET";
            this.bsend.UseVisualStyleBackColor = false;
            this.bsend.Click += new System.EventHandler(this.bsend_Click);
            // 
            // txtinfo
            // 
            this.txtinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtinfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtinfo.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtinfo.Location = new System.Drawing.Point(7, 25);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(219, 98);
            this.txtinfo.TabIndex = 11;
            this.txtinfo.Text = "0";
            this.txtinfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstatus
            // 
            this.lstatus.AutoSize = true;
            this.lstatus.Location = new System.Drawing.Point(100, 10);
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(0, 28);
            this.lstatus.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.ForeColor = System.Drawing.Color.Teal;
            this.numericUpDown2.Location = new System.Drawing.Point(486, 115);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(146, 36);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // bmode
            // 
            this.bmode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bmode.ForeColor = System.Drawing.Color.Teal;
            this.bmode.Location = new System.Drawing.Point(126, 35);
            this.bmode.Name = "bmode";
            this.bmode.Size = new System.Drawing.Size(146, 60);
            this.bmode.TabIndex = 14;
            this.bmode.Text = "MANUAL";
            this.bmode.UseVisualStyleBackColor = false;
            this.bmode.Click += new System.EventHandler(this.bmode_Click);
            // 
            // brelay
            // 
            this.brelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brelay.ForeColor = System.Drawing.Color.Teal;
            this.brelay.Location = new System.Drawing.Point(486, 35);
            this.brelay.Name = "brelay";
            this.brelay.Size = new System.Drawing.Size(146, 60);
            this.brelay.TabIndex = 15;
            this.brelay.Text = "OFF";
            this.brelay.UseVisualStyleBackColor = false;
            this.brelay.Click += new System.EventHandler(this.brelay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Upper:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lower:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pump status:";
            // 
            // txtsend
            // 
            this.txtsend.ForeColor = System.Drawing.Color.Teal;
            this.txtsend.Location = new System.Drawing.Point(350, 179);
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(130, 36);
            this.txtsend.TabIndex = 9;
            this.txtsend.Text = "5.42";
            this.txtsend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btimer);
            this.groupBox1.Controls.Add(this.numhour);
            this.groupBox1.Controls.Add(this.numminute);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(30, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 264);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // btimer
            // 
            this.btimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btimer.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btimer.ForeColor = System.Drawing.Color.Teal;
            this.btimer.Location = new System.Drawing.Point(41, 185);
            this.btimer.Name = "btimer";
            this.btimer.Size = new System.Drawing.Size(146, 55);
            this.btimer.TabIndex = 25;
            this.btimer.Text = "SET";
            this.btimer.UseVisualStyleBackColor = false;
            this.btimer.Click += new System.EventHandler(this.btimer_Click);
            // 
            // numhour
            // 
            this.numhour.BackColor = System.Drawing.SystemColors.Window;
            this.numhour.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numhour.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.numhour.Location = new System.Drawing.Point(41, 63);
            this.numhour.Name = "numhour";
            this.numhour.Size = new System.Drawing.Size(146, 36);
            this.numhour.TabIndex = 23;
            this.numhour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numminute
            // 
            this.numminute.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numminute.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.numminute.Location = new System.Drawing.Point(41, 133);
            this.numminute.Name = "numminute";
            this.numminute.Size = new System.Drawing.Size(146, 36);
            this.numminute.TabIndex = 24;
            this.numminute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 28);
            this.label11.TabIndex = 23;
            this.label11.Text = "Minute:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Hour:";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zedGraphControl1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.zedGraphControl1.Location = new System.Drawing.Point(334, 345);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(705, 264);
            this.zedGraphControl1.TabIndex = 22;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // Comunication
            // 
            this.Comunication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Comunication.Controls.Add(this.cbbcom);
            this.Comunication.Controls.Add(this.label2);
            this.Comunication.Controls.Add(this.label3);
            this.Comunication.Controls.Add(this.cbbbaud);
            this.Comunication.Controls.Add(this.bconnect);
            this.Comunication.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comunication.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Comunication.Location = new System.Drawing.Point(334, 10);
            this.Comunication.Name = "Comunication";
            this.Comunication.Size = new System.Drawing.Size(705, 64);
            this.Comunication.TabIndex = 23;
            this.Comunication.TabStop = false;
            this.Comunication.Text = "Communication";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "Maximum Water Height (cm):";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtmois);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(30, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 134);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moisture (%)";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txtinfo);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(30, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 131);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Water Height (cm)";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtsend);
            this.groupBox4.Controls.Add(this.bsend);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.brelay);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.bmode);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(334, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(705, 239);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control Panel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1085, 632);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Comunication);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstatus);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic Watering System - Nguyễn Hoài Nam 20216203";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numminute)).EndInit();
            this.Comunication.ResumeLayout(false);
            this.Comunication.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort scom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbcom;
        private System.Windows.Forms.ComboBox cbbbaud;
        private System.Windows.Forms.Button bconnect;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtmois;
        private System.Windows.Forms.Button bsend;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.Label lstatus;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button bmode;
        private System.Windows.Forms.Button brelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btimer;
        private System.Windows.Forms.NumericUpDown numhour;
        private System.Windows.Forms.NumericUpDown numminute;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox Comunication;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

