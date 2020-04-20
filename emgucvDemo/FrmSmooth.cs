using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emgucvDemo
{
    public partial class FrmSmooth : Form
    {
        public FrmSmooth()
        {
            InitializeComponent();
        }
        private Mat mat { get; set; }
        private void FrmSmooth_Load(object sender, EventArgs e)
        {
            mat = new Mat("E:\\wow\\pie.png", LoadImageType.AnyColor);

            this.pictureBox1.Image = mat.Bitmap;

            CvInvoke.NamedWindow("Smooth_Out", NamedWindowType.AutoSize);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Smooth();
        }

        private void Smooth()
        {
            Image<Gray, byte> image = mat.ToImage<Gray, byte>();
            //高斯模糊
            //image = image.SmoothBlur((int)num_Width.Value, (int)num_Width.Value);
            //高斯平滑
            //image = image.SmoothGaussian((int)num_Width.Value);
            //中值平滑
            //image = image.SmoothMedian((int)num_Width.Value);

            //双边滤波
            image = image.SmoothBilatral((int)num_Width.Value, 2, 3);
            CvInvoke.Imshow("Smooth_Out", image);

            image.Dispose();
        }

        private void num_Height_ValueChanged(object sender, EventArgs e)
        {
            Smooth();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
