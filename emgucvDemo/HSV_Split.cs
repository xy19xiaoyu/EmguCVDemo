using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emgucvDemo
{
    public partial class HSV_Split : Form
    {
        public HSV_Split()
        {
            InitializeComponent();
        }

        private Mat mat { get; set; }
        private Image<Gray, byte>[] hsvs { get; set; }

        private void HSV_Split_Load(object sender, EventArgs e)
        {

            CvInvoke.NamedWindow("HoughCircles");
            CvInvoke.NamedWindow("h");
            CvInvoke.NamedWindow("s");
            CvInvoke.NamedWindow("v");
            CvInvoke.NamedWindow("Canny");
            CvInvoke.NamedWindow("Canny1");
            ShowImage("E:\\wow\\pie.png");
        }
        private void ShowImage(string dir)
        {
            mat = new Mat(dir, LoadImageType.AnyColor);
            this.pictureBox1.Image = mat.Bitmap;
            var tmps = mat.ToImage<Hsv, byte>();
            hsvs = tmps.Split();

            var h = hsvs[0];
            var s = hsvs[1];
            var v = hsvs[2];

            CvInvoke.Imshow("h", h);
            CvInvoke.Imshow("s", s);
            CvInvoke.Imshow("v", v);

            tmps.Dispose();
            FindCircles();
            ThresholdBinary();
        }
        private void ThresholdBinary()
        {
            var h = hsvs[0].ThresholdBinary(new Gray((int)num_Width.Value), new Gray(255));
            var s = hsvs[1].ThresholdBinary(new Gray((int)num_Width.Value), new Gray(255));
            var v = hsvs[2].ThresholdBinary(new Gray((int)num_Width.Value), new Gray(255));

            var tmp = v.Canny((double)numCannyMin.Value, (double)numCannyMin.Value * 3);
            CvInvoke.Imshow("Canny", tmp);
            
            CvInvoke.Imshow("h", h);
            CvInvoke.Imshow("s", s);
            CvInvoke.Imshow("v", v);

            tmp.Dispose();
            h.Dispose();
            s.Dispose();
            v.Dispose();
        }
        private void num_Width_ValueChanged(object sender, EventArgs e)
        {

            ThresholdBinary();

        }

        private void HSV_Split_FormClosing(object sender, FormClosingEventArgs e)
        {
            CvInvoke.DestroyAllWindows();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mat?.Dispose();

                foreach (var tmp in hsvs)
                {
                    tmp.Dispose();
                }

                this.pictureBox1.Image?.Dispose();
                ShowImage(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindCircles();
        }

        private void FindCircles()
        {
#if DEBUG

            Stopwatch sw = new Stopwatch();
            sw.Start();
#endif



            var result = hsvs[2].ThresholdBinary(new Gray((int)num_Width.Value), new Gray(255));
            //var result = hsvs[2].Clone();
            result = result.Canny((double)numCannyMin.Value, (double)numCannyMin.Value * 3);
            CircleF[] circles = result.HoughCircles(new Gray((int)num_cannyThreshold.Value), new Gray((int)num_accumulatorThreshold.Value), (int)num_dp.Value, mat.Width / 8).First();



#if DEBUG
            sw.Stop();

            Image<Bgr, Byte> imageCircles = result.Convert<Bgr, byte>();
            foreach (CircleF circle in circles)
            {
                imageCircles.Draw(circle, new Bgr(Color.Yellow), 2);
            }


            CvInvoke.Imshow("HoughCircles", imageCircles);
            imageCircles.Dispose();
#endif


            result.Dispose();

        }

        private void num_cannyThreshold_ValueChanged(object sender, EventArgs e)
        {
            FindCircles();
        }

        private void num_accumulatorThreshold_ValueChanged(object sender, EventArgs e)
        {
            FindCircles();
        }

        private void num_dp_ValueChanged(object sender, EventArgs e)
        {
            FindCircles();
        }

        private void numCanny_ValueChanged(object sender, EventArgs e)
        {
            ThresholdBinary();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Mat dst = new Mat();
            var v = hsvs[2].ThresholdBinary(new Gray((int)num_Width.Value), new Gray(255));

            var tmp = v.Canny((double)numCannyMin.Value, (int)numCannyMax.Value);
            dst = tmp.Mat;

            //创建用于存储轮廓的VectorOfVectorOfPoint数据类型
            //需要添加引用命名空间Emgu.CV.Util
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.Imshow("Canny", dst);
            CvInvoke.FindContours(dst, contours, null, Emgu.CV.CvEnum.RetrType.External,
                  Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            int minValue = (int)numAreaMin.Value;
            int size = contours.Size;
            VectorOfVectorOfPoint contours2 = new VectorOfVectorOfPoint();
            for (int i = 0; i < contours.Size; i++)
            {
                VectorOfPoint vp = contours[i];
                double area = CvInvoke.ContourArea(vp);
                if (area < minValue)
                {
                    contours2.Push(vp);
                }
            }
            CvInvoke.DrawContours(dst, contours2, -1, new MCvScalar(255, 255, 255));
            CvInvoke.Imshow("Canny1", dst);

            dst.Dispose();
            v.Dispose();
            tmp.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
