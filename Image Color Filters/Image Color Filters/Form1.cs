using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Color_Filters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap OriginalImage;
        Bitmap ProcessedImage;

        int[,,] OriginalImageArray;
        int[,,] ProcessedImageArray;

        float[,] histogram = new float[3, 256];
        float[] mean = new float[3];

        int progress;

        private void CurrentProgress(int currentWidth)
        {

            if (currentWidth / (OriginalImage.Width * 0.01) >= progress + 1) progress++;
        }

        private void ConvertImageToTable(Bitmap image)
        {
            progress = 0;
            progressBar1.Visible = true;

            for(int i = 0; i < image.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar1.Maximum) progressBar1.Value = progress;

                for (int j = 0; j < image.Height; j++)
                {
                    OriginalImageArray[0, i, j] = image.GetPixel(i, j).R;
                    OriginalImageArray[1, i, j] = image.GetPixel(i, j).G;
                    OriginalImageArray[2, i, j] = image.GetPixel(i, j).B;
                }
            }

            progressBar1.Visible = false;
        }

        private void ConvertTableToImage(int[,,] array)
        {
            Color pixel = new Color();
            ProcessedImage = new Bitmap(OriginalImage.Width, OriginalImage.Height);

            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < ProcessedImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < ProcessedImage.Height; j++)
                {
                    pixel = Color.FromArgb(ProcessedImageArray[0, i ,j], ProcessedImageArray[1, i, j], ProcessedImageArray [2, i, j]);
                    ProcessedImage.SetPixel(i, j, pixel);
                }
            }

            progressBar2.Visible=false;
        }

        private void Histogram(float[,] histogram)
        {
            int imageResolution = OriginalImage.Width * OriginalImage.Height;
            progress = 0;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar1.Maximum) progressBar1.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    histogram[0, ProcessedImage.GetPixel(i, j).R]++;
                    histogram[1, ProcessedImage.GetPixel(i, j).G]++;
                    histogram[2, ProcessedImage.GetPixel(i, j).B]++;
                }
            }

            for (int i = 0; i < 256; i++)
            {
                histogram[0, i] /= imageResolution;
                histogram[1, i] /= imageResolution;
                histogram[2, i] /= imageResolution;
            }
        }

        private void AddHistogramToChart()
        {
            for (int i = 0; i < 256; i++)
            {
                histogramChart.Series["Pixels"].Points.AddXY(i.ToString(), histogram[0, i]);
            }
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("details");

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                OriginalImage = new Bitmap(openFileDialog1.FileName);

                OriginalImageArray = new int[3, OriginalImage.Width, OriginalImage.Height];
                ProcessedImageArray = new int[3, OriginalImage.Width, OriginalImage.Height];

                ConvertImageToTable(OriginalImage);
                ProcessedImage = OriginalImage;

                pictureBox1.Image = OriginalImage;
                pictureBox2.Image = OriginalImage;


                Histogram(histogram);
                AddHistogramToChart();
                CalculateMean();
                CalculateStandardDeviation();
                CalculateObliquity();
                CalculateEntropy();
                energyTextBox.Text = (Math.Pow(2, mean[0])).ToString();//energy
            }
        }

        private void CalculateMean()
        {
            for (int i = 0; i < 256; i++)
            {
                mean[0] += i * histogram[0, i];
                mean[1] += i * histogram[1, i];
                mean[2] += i * histogram[2, i];
            }

            meanTextBox.Text = mean[0].ToString();
        }

        private void CalculateStandardDeviation()
        {
            double standardDeviation = 0;

            for (int i = 0; i < 256; i++)
            {
                standardDeviation += Math.Pow(2, (i - mean[0])) * histogram[0, i];
            }

            variabilityTextBox.Text = standardDeviation.ToString();//Variability

            standardDeviation /= 2;
            standardDeviationTextBox.Text = standardDeviation.ToString();
        }

        private void CalculateObliquity()
        {
            double obliquity = 0;

            for (int i = 0; i < 256; i++)
            {
                obliquity += Math.Pow(3, (i - mean[0])) * histogram[0, i];
            }

            obiquilityTextBox.Text = obliquity.ToString();//Variability
        }

        private void CalculateEntropy()
        {
            double entropy = 0;

            for (int i = 0; i < 256; i++)
            {
                entropy += histogram[0, i] * Math.Log(histogram[0, i], 2);
            }
            
            entropy = - entropy;
            entropyTextBox.Text = entropy.ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    ProcessedImageArray[0, i, j] = 255 - OriginalImage.GetPixel(i, j).R;
                    ProcessedImageArray[1, i, j] = 255 - OriginalImage.GetPixel(i, j).G;
                    ProcessedImageArray[2, i, j] = 255 - OriginalImage.GetPixel(i, j).B;
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private void ConvertToGrayscale()
        {
            int averageValue;

            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    averageValue = (OriginalImage.GetPixel(i, j).R + OriginalImage.GetPixel(i, j).G + OriginalImage.GetPixel(i, j).B) / 3;
                    ProcessedImageArray[0, i, j] = averageValue;
                    ProcessedImageArray[1, i, j] = averageValue;
                    ProcessedImageArray[2, i, j] = averageValue;
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;
        }

        private void grayscaleBuntton_Click(object sender, EventArgs e)
        {
            ConvertToGrayscale();
        }

    }
}
