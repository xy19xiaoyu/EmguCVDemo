namespace emgucvDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LH = new System.Windows.Forms.NumericUpDown();
            this.LS = new System.Windows.Forms.NumericUpDown();
            this.HS = new System.Windows.Forms.NumericUpDown();
            this.LV = new System.Windows.Forms.NumericUpDown();
            this.HH = new System.Windows.Forms.NumericUpDown();
            this.HV = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Dilate = new System.Windows.Forms.NumericUpDown();
            this.num_cannyThreshold = new System.Windows.Forms.NumericUpDown();
            this.num_accumulatorThreshold = new System.Windows.Forms.NumericUpDown();
            this.num_Erode = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDilate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HV)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Dilate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cannyThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_accumulatorThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Erode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Location = new System.Drawing.Point(522, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 450);
            this.textBox1.TabIndex = 1;
            // 
            // LH
            // 
            this.LH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LH.Location = new System.Drawing.Point(396, 12);
            this.LH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LH.Name = "LH";
            this.LH.Size = new System.Drawing.Size(120, 21);
            this.LH.TabIndex = 2;
            this.LH.ValueChanged += new System.EventHandler(this.LH_ValueChanged);
            // 
            // LS
            // 
            this.LS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LS.Location = new System.Drawing.Point(396, 39);
            this.LS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LS.Name = "LS";
            this.LS.Size = new System.Drawing.Size(120, 21);
            this.LS.TabIndex = 3;
            this.LS.ValueChanged += new System.EventHandler(this.LS_ValueChanged);
            // 
            // HS
            // 
            this.HS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HS.Location = new System.Drawing.Point(396, 135);
            this.HS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HS.Name = "HS";
            this.HS.Size = new System.Drawing.Size(120, 21);
            this.HS.TabIndex = 4;
            this.HS.ValueChanged += new System.EventHandler(this.HS_ValueChanged);
            // 
            // LV
            // 
            this.LV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LV.Location = new System.Drawing.Point(396, 66);
            this.LV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(120, 21);
            this.LV.TabIndex = 4;
            this.LV.ValueChanged += new System.EventHandler(this.LV_ValueChanged);
            // 
            // HH
            // 
            this.HH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HH.Location = new System.Drawing.Point(396, 108);
            this.HH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HH.Name = "HH";
            this.HH.Size = new System.Drawing.Size(120, 21);
            this.HH.TabIndex = 5;
            this.HH.ValueChanged += new System.EventHandler(this.HH_ValueChanged);
            // 
            // HV
            // 
            this.HV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HV.Location = new System.Drawing.Point(396, 162);
            this.HV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HV.Name = "HV";
            this.HV.Size = new System.Drawing.Size(120, 21);
            this.HV.TabIndex = 6;
            this.HV.ValueChanged += new System.EventHandler(this.HV_ValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(447, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "找圆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(522, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(507, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(402, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "当前参数找圆";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "lowHSV";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "HiHSV";
            // 
            // num_Dilate
            // 
            this.num_Dilate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Dilate.Location = new System.Drawing.Point(396, 274);
            this.num_Dilate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Dilate.Name = "num_Dilate";
            this.num_Dilate.Size = new System.Drawing.Size(120, 21);
            this.num_Dilate.TabIndex = 14;
            this.num_Dilate.ValueChanged += new System.EventHandler(this.num_Dilate_ValueChanged);
            // 
            // num_cannyThreshold
            // 
            this.num_cannyThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_cannyThreshold.Location = new System.Drawing.Point(396, 202);
            this.num_cannyThreshold.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_cannyThreshold.Name = "num_cannyThreshold";
            this.num_cannyThreshold.Size = new System.Drawing.Size(120, 21);
            this.num_cannyThreshold.TabIndex = 13;
            this.num_cannyThreshold.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // num_accumulatorThreshold
            // 
            this.num_accumulatorThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_accumulatorThreshold.Location = new System.Drawing.Point(396, 229);
            this.num_accumulatorThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_accumulatorThreshold.Name = "num_accumulatorThreshold";
            this.num_accumulatorThreshold.Size = new System.Drawing.Size(120, 21);
            this.num_accumulatorThreshold.TabIndex = 12;
            this.num_accumulatorThreshold.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_accumulatorThreshold.ValueChanged += new System.EventHandler(this.num_accumulatorThreshold_ValueChanged);
            // 
            // num_Erode
            // 
            this.num_Erode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Erode.Location = new System.Drawing.Point(396, 296);
            this.num_Erode.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Erode.Name = "num_Erode";
            this.num_Erode.Size = new System.Drawing.Size(120, 21);
            this.num_Erode.TabIndex = 16;
            this.num_Erode.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "cannyThreshold";
            // 
            // lblDilate
            // 
            this.lblDilate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDilate.AutoSize = true;
            this.lblDilate.Location = new System.Drawing.Point(348, 278);
            this.lblDilate.Name = "lblDilate";
            this.lblDilate.Size = new System.Drawing.Size(41, 12);
            this.lblDilate.TabIndex = 18;
            this.lblDilate.Text = "Dilate";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Erode";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "accumulatorThreshold";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDilate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_Erode);
            this.Controls.Add(this.num_Dilate);
            this.Controls.Add(this.num_cannyThreshold);
            this.Controls.Add(this.num_accumulatorThreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HV);
            this.Controls.Add(this.HH);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.HS);
            this.Controls.Add(this.LS);
            this.Controls.Add(this.LH);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HV)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Dilate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cannyThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_accumulatorThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Erode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown LH;
        private System.Windows.Forms.NumericUpDown LS;
        private System.Windows.Forms.NumericUpDown HS;
        private System.Windows.Forms.NumericUpDown LV;
        private System.Windows.Forms.NumericUpDown HH;
        private System.Windows.Forms.NumericUpDown HV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Dilate;
        private System.Windows.Forms.NumericUpDown num_cannyThreshold;
        private System.Windows.Forms.NumericUpDown num_accumulatorThreshold;
        private System.Windows.Forms.NumericUpDown num_Erode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDilate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

