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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HV)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
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
            this.button1.Location = new System.Drawing.Point(441, 202);
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(476, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

