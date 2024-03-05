using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
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

        float[,] histogram = new float[4, 256];
        float[] mean = new float[4];

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

            progressBar1.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar1.Maximum) progressBar1.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    histogram[0, (int)(ProcessedImage.GetPixel(i, j).R * 0.299 + ProcessedImage.GetPixel(i, j).G * 0.587 + ProcessedImage.GetPixel(i, j).B * 0.114)]++;
                    histogram[1, ProcessedImage.GetPixel(i, j).R]++;
                    histogram[2, ProcessedImage.GetPixel(i, j).G]++;
                    histogram[3, ProcessedImage.GetPixel(i, j).B]++;
                }
            }

            for (int i = 0; i < 256; i++)
            {
                histogram[0, i] /= imageResolution;
                histogram[1, i] /= imageResolution;
                histogram[2, i] /= imageResolution;
                histogram[3, i] /= imageResolution;
            }

            progressBar1.Visible = false;
        }


        private void AddHistogramToChart()
        {
            for (int i = 0; i < 256; i++)
            {
                histogramChart.Series["L"].Points.AddXY(i.ToString(), histogram[0, i]);
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
            }
        }

        private void CalculateMean()
        {
            for (int i = 0; i < 256; i++)
            {
                mean[0] += i * histogram[0, i];
                mean[1] += i * histogram[1, i];
                mean[2] += i * histogram[2, i];
                mean[3] += i * histogram[3, i];
            }

            meanLTextBox.Text = mean[0].ToString();
            meanRTextBox.Text = mean[1].ToString();
            meanGTextBox.Text = mean[2].ToString();
            meanBTextBox.Text = mean[3].ToString();
        }

        private void CalculateStandardDeviation()
        {
            double standardDeviation = 0;

            for (int i = 0; i < 256; i++)
            {
                standardDeviation += Math.Pow((i - mean[0]), 2) * histogram[0, i];
            }


            variabilityTextBox.Text = standardDeviation.ToString();//Variability

            standardDeviation = Math.Sqrt(standardDeviation);
            standardDeviationTextBox.Text = standardDeviation.ToString();
        }

        private void CalculateObliquity()
        {
            double obliquity = 0;

            for (int i = 0; i < 256; i++)
            {
                obliquity += Math.Pow((i - mean[0]), 3) * histogram[0, i];
            }

            obiquilityTextBox.Text = obliquity.ToString();
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

        private void grayscaleBuntton_Click(object sender, EventArgs e)
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

        private void redButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;
            
            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    ProcessedImageArray[0, i, j] = OriginalImageArray[0, i, j];
                    ProcessedImageArray[1, i, j] = 0;
                    ProcessedImageArray[2, i, j] = 0;
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    ProcessedImageArray[0, i, j] = 0;
                    ProcessedImageArray[1, i, j] = OriginalImageArray[1, i, j];
                    ProcessedImageArray[2, i, j] = 0;
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    ProcessedImageArray[0, i, j] = 0;
                    ProcessedImageArray[1, i, j] = 0;
                    ProcessedImageArray[2, i, j] = OriginalImageArray[2, i, j];
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private void reverseRedButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    ProcessedImageArray[0, i, j] = 255 - OriginalImageArray[0, i, j];
                    ProcessedImageArray[1, i, j] = 0;
                    ProcessedImageArray[2, i, j] = 0;
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private void reverseGreenButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    ProcessedImageArray[0, i, j] = 0;
                    ProcessedImageArray[1, i, j] = 255 - OriginalImageArray[1, i, j];
                    ProcessedImageArray[2, i, j] = 0;
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private void reverseBlueButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    ProcessedImageArray[0, i, j] = 0;
                    ProcessedImageArray[1, i, j] = 0;
                    ProcessedImageArray[2, i, j] = 255 - OriginalImageArray[2, i, j];
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private void binaryMeanButton_Click(object sender, EventArgs e)
        {
            int luminosity;

            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    luminosity = (int)(OriginalImageArray[0, i, j] * 0.299 + OriginalImageArray[1, i, j] * 0.587 + OriginalImageArray[2, i, j] * 0.114);
                    if (luminosity < mean[0])
                    {
                        ProcessedImageArray[0, i, j] = 0;
                        ProcessedImageArray[1, i, j] = 0;
                        ProcessedImageArray[2, i, j] = 0;
                    }
                    else
                    {
                        ProcessedImageArray[0, i, j] = 255;
                        ProcessedImageArray[1, i, j] = 255;
                        ProcessedImageArray[2, i, j] = 255;
                    }
                }
            }


            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private int Median()
        {
            float median = 0;
            int counter = 0;

            while (median < 0.5)
            {
                median += histogram[0, counter];
                counter++;
            }

            return counter;
        }

        private void binaryMedianButton_Click(object sender, EventArgs e)
        {
            int median = Median();
            int luminosity;

            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    luminosity = (int)(OriginalImageArray[0, i, j] * 0.299 + OriginalImageArray[1, i, j] * 0.587 + OriginalImageArray[2, i, j] * 0.114);
                    if (luminosity < median)
                    {
                        ProcessedImageArray[0, i, j] = 0;
                        ProcessedImageArray[1, i, j] = 0;
                        ProcessedImageArray[2, i, j] = 0;
                    }
                    else
                    {
                        ProcessedImageArray[0, i, j] = 255;
                        ProcessedImageArray[1, i, j] = 255;
                        ProcessedImageArray[2, i, j] = 255;
                    }
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private int MaxValue()
        {
            float max = 0;
            int index = 0;

            for (int i = 0; i < 256; i++)
            {
                if (histogram[0, i] > max)
                {
                    max = histogram[0, i];
                    index = i;
                }
            }

            return index;
        }

        private void binaryMaxButton_Click(object sender, EventArgs e)
        {
            int max = MaxValue();
            int luminosity;

            progress = 0;
            progressBar2.Visible = true;

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    luminosity = (int)(OriginalImageArray[0, i, j] * 0.299 + OriginalImageArray[1, i, j] * 0.587 + OriginalImageArray[2, i, j] * 0.114);
                    if (luminosity >= max)
                    {
                        ProcessedImageArray[0, i, j] = 255;
                        ProcessedImageArray[1, i, j] = 255;
                        ProcessedImageArray[2, i, j] = 255;
                    }
                    else
                    {
                        ProcessedImageArray[0, i, j] = 0;
                        ProcessedImageArray[1, i, j] = 0;
                        ProcessedImageArray[2, i, j] = 0;
                    }
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private void equalizeButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;

            float[,] equalizedHistogram = new float[3,256];

            equalizedHistogram[0, 0] = histogram[0, 0];
            equalizedHistogram[1, 0] = histogram[1, 0];
            equalizedHistogram[2, 0] = histogram[2, 0];

            for (int i = 1; i < 256; i++)
            {
                equalizedHistogram[0, i] = equalizedHistogram[0, i - 1] + histogram[0, i];
                equalizedHistogram[1, i] = equalizedHistogram[1, i - 1] + histogram[1, i];
                equalizedHistogram[2, i] = equalizedHistogram[2, i - 1] + histogram[2, i];
            }

            for (int i = 0; i < 256; i++)
            {
                equalizedHistogram[0, i] = equalizedHistogram[0, i] * 255;
                equalizedHistogram[1, i] = equalizedHistogram[1, i] * 255;
                equalizedHistogram[2, i] = equalizedHistogram[2, i] * 255;
            }

            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    ProcessedImageArray[0, i, j] = (int)equalizedHistogram[0, OriginalImageArray[0, i, j]];
                    ProcessedImageArray[1, i, j] = (int)equalizedHistogram[1, OriginalImageArray[1, i, j]];
                    ProcessedImageArray[2, i, j] = (int)equalizedHistogram[2, OriginalImageArray[2, i, j]];
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            threshholdValueLabel.Text = trackBar1.Value.ToString();
        }

        private void sobelHorizontalButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;


            for (int i = 0; i < OriginalImage.Width; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 0; j < OriginalImage.Height; j++)
                {
                    int value = HorizontalKernel(i, j);
                    if (value > 255)
                        value = 255;
                    else if (value < 0)
                        value = 0;

                    ProcessedImageArray[0, i, j] = value;
                    ProcessedImageArray[1, i, j] = value;
                    ProcessedImageArray[2, i, j] = value;
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private int HorizontalKernel(int x, int y)
        {
            int width = OriginalImage.Width;
            int height = OriginalImage.Height;
            int[,] kernel = new int[3,3] { { 1, 2, 1 },
                                        { 0, 0, 0} ,
                                        {-1, -2, -1 } };
            int sum = 0;

            for (int i = - 1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + width) % width;
                    var row = (y + j + height) % height;
                    var luminosity = (int)(OriginalImageArray[0, col, row] * 0.299 + OriginalImageArray[1, col, row] * 0.587
                                            + OriginalImageArray[2, col, row] * 0.114);

                    sum += kernel[i + 1, j + 1] * luminosity;
                }
            }

            return sum;
        }

        private void sobelVerticalButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;


            for (int i = 1; i < OriginalImage.Width - 1; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 1; j < OriginalImage.Height - 1; j++)
                {
                    int value = VerticalKernel(i, j);

                    if (value > 255)
                        value = 255;

                    else if (value < 0)
                        value = 0;

                    ProcessedImageArray[0, i, j] = value;
                    ProcessedImageArray[1, i, j] = value;
                    ProcessedImageArray[2, i, j] = value;
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }

        private int VerticalKernel(int x, int y) 
        { 
            int width = OriginalImage.Width;
            int height = OriginalImage.Height;
            int[,] kernel = new int[3, 3] { { 1, 0, -1 },
                                            { 2, 0, -2} ,
                                            { 1, 0, -1 } };
            int sum = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + width) % width;
                    var row = (y + j + height) % height;

                    var luminosity = (int)(OriginalImageArray[0, col, row] * 0.299 + OriginalImageArray[1, col, row] * 0.587
                                            + OriginalImageArray[2, col, row] * 0.114);

                    sum += kernel[i + 1, j + 1] * luminosity;
                }
            }

            return sum;
        }

        private void sobelButton_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar2.Visible = true;


            for (int i = 1; i < OriginalImage.Width - 1; i++)
            {
                CurrentProgress(i);
                if (progress <= progressBar2.Maximum) progressBar2.Value = progress;

                for (int j = 1; j < OriginalImage.Height - 1; j++)
                {
                    int verticalValue = VerticalKernel(i, j);
                    int horizontalValue = HorizontalKernel(i, j);
                    int value = (int)Math.Sqrt(Math.Pow(verticalValue, 2) + Math.Pow(horizontalValue, 2));

                    if (value > 255)
                        value = 255;

                    else if (value < 0)
                        value = 0;

                    ProcessedImageArray[0, i, j] = value;
                    ProcessedImageArray[1, i, j] = value;
                    ProcessedImageArray[2, i, j] = value;
                }
            }

            ConvertTableToImage(ProcessedImageArray);
            pictureBox2.Image = ProcessedImage;

            progressBar2.Visible = false;
        }
    }
}
