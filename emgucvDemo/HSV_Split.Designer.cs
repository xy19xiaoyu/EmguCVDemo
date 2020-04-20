namespace emgucvDemo
{
    partial class HSV_Split
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
            this.num_Width = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_cannyThreshold = new System.Windows.Forms.NumericUpDown();
            this.num_accumulatorThreshold = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.num_dp = new System.Windows.Forms.NumericUpDown();
            this.numCannyMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numAreaMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numCannyMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cannyThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_accumulatorThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCannyMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCannyMax)).BeginInit();
            this.SuspendLayout();
            // 
            // num_Width
            // 
            this.num_Width.Location = new System.Drawing.Point(63, 12);
            this.num_Width.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Width.Name = "num_Width";
            this.num_Width.Size = new System.Drawing.Size(120, 21);
            this.num_Width.TabIndex = 17;
            this.num_Width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Width.ValueChanged += new System.EventHandler(this.num_Width_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(24, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "accumulatorThreshold";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "cannyThreshold";
            // 
            // num_cannyThreshold
            // 
            this.num_cannyThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_cannyThreshold.Location = new System.Drawing.Point(668, 12);
            this.num_cannyThreshold.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_cannyThreshold.Name = "num_cannyThreshold";
            this.num_cannyThreshold.Size = new System.Drawing.Size(120, 21);
            this.num_cannyThreshold.TabIndex = 22;
            this.num_cannyThreshold.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_cannyThreshold.ValueChanged += new System.EventHandler(this.num_cannyThreshold_ValueChanged);
            // 
            // num_accumulatorThreshold
            // 
            this.num_accumulatorThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_accumulatorThreshold.Location = new System.Drawing.Point(668, 39);
            this.num_accumulatorThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_accumulatorThreshold.Name = "num_accumulatorThreshold";
            this.num_accumulatorThreshold.Size = new System.Drawing.Size(120, 21);
            this.num_accumulatorThreshold.TabIndex = 21;
            this.num_accumulatorThreshold.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_accumulatorThreshold.ValueChanged += new System.EventHandler(this.num_accumulatorThreshold_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "dp";
            // 
            // num_dp
            // 
            this.num_dp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_dp.Location = new System.Drawing.Point(668, 66);
            this.num_dp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_dp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_dp.Name = "num_dp";
            this.num_dp.Size = new System.Drawing.Size(120, 21);
            this.num_dp.TabIndex = 25;
            this.num_dp.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_dp.ValueChanged += new System.EventHandler(this.num_dp_ValueChanged);
            // 
            // numCannyMin
            // 
            this.numCannyMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCannyMin.Location = new System.Drawing.Point(668, 184);
            this.numCannyMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numCannyMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCannyMin.Name = "numCannyMin";
            this.numCannyMin.Size = new System.Drawing.Size(120, 21);
            this.numCannyMin.TabIndex = 27;
            this.numCannyMin.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numCannyMin.ValueChanged += new System.EventHandler(this.numCanny_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "CannyMin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numAreaMin
            // 
            this.numAreaMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numAreaMin.Location = new System.Drawing.Point(668, 278);
            this.numAreaMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numAreaMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAreaMin.Name = "numAreaMin";
            this.numAreaMin.Size = new System.Drawing.Size(120, 21);
            this.numAreaMin.TabIndex = 29;
            this.numAreaMin.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numAreaMin.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "CannyMax";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numCannyMax
            // 
            this.numCannyMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCannyMax.Location = new System.Drawing.Point(668, 211);
            this.numCannyMax.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numCannyMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCannyMax.Name = "numCannyMax";
            this.numCannyMax.Size = new System.Drawing.Size(120, 21);
            this.numCannyMax.TabIndex = 31;
            this.numCannyMax.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // HSV_Split
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numCannyMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numAreaMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numCannyMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_dp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_cannyThreshold);
            this.Controls.Add(this.num_accumulatorThreshold);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_Width);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HSV_Split";
            this.Text = "HSV_Split";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HSV_Split_FormClosing);
            this.Load += new System.EventHandler(this.HSV_Split_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cannyThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_accumulatorThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCannyMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCannyMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_Width;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_cannyThreshold;
        private System.Windows.Forms.NumericUpDown num_accumulatorThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_dp;
        private System.Windows.Forms.NumericUpDown numCannyMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAreaMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCannyMax;
    }
}