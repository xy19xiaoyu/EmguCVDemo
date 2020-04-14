using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace emgucvDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Mat mat { get; set; }
        private Image<Gray, byte>[] HSV { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            mat = new Mat("E:\\wow\\pie.png", LoadImageType.AnyColor);

            this.pictureBox1.Image = mat.Bitmap;


            HSV = mat.ToImage<Hsv, byte>().Split();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = $"{e.Location.X},{e.Location.Y}";
            Rectangle rect = new Rectangle()
            {
                X = e.Location.X - 10,
                Y = e.Location.Y - 10,
                Width = 20,
                Height = 20
            };
            int[] low = new int[3];
            int[] hie = new int[3];
            double[] min, max;
            Point[] minP, maxP;
            int i = 0;
            foreach (var channle in HSV)
            {
                var sub = channle.GetSubRect(rect);
                sub.MinMax(out min, out max, out minP, out maxP);


                this.textBox1.AppendText($"[{min[0]},{max[0]}]{Environment.NewLine}");
                sub.Dispose();
                low[i] = (int)min[0];
                hie[i] = (int)max[0];
                i++;
            }

            var img = mat.ToImage<Bgr, byte>();
            var tmp = img.GetSubRect(rect);
#if DEBUG
            CvInvoke.NamedWindow("xy");
            CvInvoke.Imshow("xy", tmp);
#endif
            img.Dispose();
            tmp.Dispose();

            LH.Value = low[0];
            LS.Value = low[1];
            LV.Value = low[2];

            HH.Value = hie[0];
            HS.Value = hie[1];
            HV.Value = hie[2];

        }

        private void hsvFindColor()
        {
            Hsv botLimit = new Hsv((int)LH.Value, (int)LS.Value, (int)LV.Value);
            Hsv uprLimit = new Hsv((int)HH.Value, (int)HS.Value, (int)HV.Value);

            Image<Hsv, byte> hsv = mat.ToImage<Hsv, byte>();
            var result = hsv.InRange(botLimit, uprLimit);

#if DEBUG
            CvInvoke.NamedWindow("xy1");
            CvInvoke.Imshow("xy1", result);
#endif

            hsv.Dispose();
            result.Dispose();
        }

        private void HV_ValueChanged(object sender, EventArgs e)
        {
            hsvFindColor();
        }

        private void LS_ValueChanged(object sender, EventArgs e)
        {
            hsvFindColor();
        }

        private void LV_ValueChanged(object sender, EventArgs e)
        {
            hsvFindColor();
        }

        private void HH_ValueChanged(object sender, EventArgs e)
        {
            hsvFindColor();
        }

        private void HS_ValueChanged(object sender, EventArgs e)
        {
            hsvFindColor();
        }

        private void LH_ValueChanged(object sender, EventArgs e)
        {
            hsvFindColor();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
#if DEBUG
            textBox1.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();
#endif
            Hsv botLimit = new Hsv(0, 0, 255);
            Hsv uprLimit = new Hsv(163, 255, 255);


            Image<Hsv, byte> hsv = mat.ToImage<Hsv, byte>();
            var result = hsv.InRange(botLimit, uprLimit);
            CvInvoke.GaussianBlur(result, result, new Size(9, 9), 0, 0);
            CircleF[] circles = result.HoughCircles(new Gray(180), new Gray(120), 2, mat.Width / 8).First();



#if DEBUG
            sw.Stop();
            this.textBox1.AppendText($"{sw.ElapsedMilliseconds}ms{Environment.NewLine}");
            Image<Bgr, Byte> imageCircles = result.Convert<Bgr, byte>();
            foreach (CircleF circle in circles)
            {
                imageCircles.Draw(circle, new Bgr(Color.Yellow), 5);
                this.textBox1.AppendText($"[x={circle.Center.X},y={circle.Center.Y}]{Environment.NewLine}");
            }


            CvInvoke.NamedWindow("InRange");
            CvInvoke.Imshow("InRange", result);


            CvInvoke.NamedWindow("HoughCircles");
            CvInvoke.Imshow("HoughCircles", imageCircles);
            imageCircles.Dispose();
#endif


            hsv.Dispose();
            result.Dispose();
        }
    }
}
