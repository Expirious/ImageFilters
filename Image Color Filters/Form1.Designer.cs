namespace Image_Color_Filters
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SelectImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.resetButton = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.details = new System.Windows.Forms.TabPage();
            this.meanLTextBox = new System.Windows.Forms.TextBox();
            this.meanLLablel = new System.Windows.Forms.Label();
            this.meanBTextBox = new System.Windows.Forms.TextBox();
            this.meanGTextBox = new System.Windows.Forms.TextBox();
            this.meanBLabel = new System.Windows.Forms.Label();
            this.meanGLabel = new System.Windows.Forms.Label();
            this.entropyTextBox = new System.Windows.Forms.TextBox();
            this.obiquilityTextBox = new System.Windows.Forms.TextBox();
            this.variabilityTextBox = new System.Windows.Forms.TextBox();
            this.standardDeviationTextBox = new System.Windows.Forms.TextBox();
            this.entropyLabel = new System.Windows.Forms.Label();
            this.obliquityLabel = new System.Windows.Forms.Label();
            this.variabilityLabel = new System.Windows.Forms.Label();
            this.standardDeviationLabel = new System.Windows.Forms.Label();
            this.meanRLabel = new System.Windows.Forms.Label();
            this.meanRTextBox = new System.Windows.Forms.TextBox();
            this.histogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.equalizeButton = new System.Windows.Forms.Button();
            this.binaryMaxButton = new System.Windows.Forms.Button();
            this.binaryMedianButton = new System.Windows.Forms.Button();
            this.binaryMeanButton = new System.Windows.Forms.Button();
            this.reverseBlueButton = new System.Windows.Forms.Button();
            this.reverseGreenButton = new System.Windows.Forms.Button();
            this.reverseRedButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.grayscaleBuntton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.applyThreshholdButton = new System.Windows.Forms.Button();
            this.threshholdValueLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sobelHorizontalButton = new System.Windows.Forms.Button();
            this.sobelVerticalButton = new System.Windows.Forms.Button();
            this.sobelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(565, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 312);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(12, 330);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(84, 31);
            this.SelectImage.TabIndex = 2;
            this.SelectImage.Text = "Select Image";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(102, 340);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(410, 21);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(981, 330);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(84, 31);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.IndianRed;
            this.progressBar2.Location = new System.Drawing.Point(565, 340);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(410, 21);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 2;
            this.progressBar2.Visible = false;
            // 
            // details
            // 
            this.details.Controls.Add(this.meanLTextBox);
            this.details.Controls.Add(this.meanLLablel);
            this.details.Controls.Add(this.meanBTextBox);
            this.details.Controls.Add(this.meanGTextBox);
            this.details.Controls.Add(this.meanBLabel);
            this.details.Controls.Add(this.meanGLabel);
            this.details.Controls.Add(this.entropyTextBox);
            this.details.Controls.Add(this.obiquilityTextBox);
            this.details.Controls.Add(this.variabilityTextBox);
            this.details.Controls.Add(this.standardDeviationTextBox);
            this.details.Controls.Add(this.entropyLabel);
            this.details.Controls.Add(this.obliquityLabel);
            this.details.Controls.Add(this.variabilityLabel);
            this.details.Controls.Add(this.standardDeviationLabel);
            this.details.Controls.Add(this.meanRLabel);
            this.details.Controls.Add(this.meanRTextBox);
            this.details.Controls.Add(this.histogramChart);
            this.details.Location = new System.Drawing.Point(4, 22);
            this.details.Name = "details";
            this.details.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.details.Size = new System.Drawing.Size(1045, 254);
            this.details.TabIndex = 1;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = true;
            // 
            // meanLTextBox
            // 
            this.meanLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meanLTextBox.Enabled = false;
            this.meanLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanLTextBox.Location = new System.Drawing.Point(74, 43);
            this.meanLTextBox.Name = "meanLTextBox";
            this.meanLTextBox.Size = new System.Drawing.Size(100, 15);
            this.meanLTextBox.TabIndex = 21;
            this.meanLTextBox.Text = "0";
            // 
            // meanLLablel
            // 
            this.meanLLablel.AutoSize = true;
            this.meanLLablel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanLLablel.Location = new System.Drawing.Point(11, 44);
            this.meanLLablel.Name = "meanLLablel";
            this.meanLLablel.Size = new System.Drawing.Size(54, 16);
            this.meanLLablel.TabIndex = 20;
            this.meanLLablel.Text = "Mean L:";
            // 
            // meanBTextBox
            // 
            this.meanBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meanBTextBox.Enabled = false;
            this.meanBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanBTextBox.Location = new System.Drawing.Point(74, 162);
            this.meanBTextBox.Name = "meanBTextBox";
            this.meanBTextBox.Size = new System.Drawing.Size(100, 15);
            this.meanBTextBox.TabIndex = 19;
            this.meanBTextBox.Text = "0";
            // 
            // meanGTextBox
            // 
            this.meanGTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meanGTextBox.Enabled = false;
            this.meanGTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanGTextBox.Location = new System.Drawing.Point(74, 123);
            this.meanGTextBox.Name = "meanGTextBox";
            this.meanGTextBox.Size = new System.Drawing.Size(100, 15);
            this.meanGTextBox.TabIndex = 18;
            this.meanGTextBox.Text = "0";
            // 
            // meanBLabel
            // 
            this.meanBLabel.AutoSize = true;
            this.meanBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanBLabel.Location = new System.Drawing.Point(12, 162);
            this.meanBLabel.Name = "meanBLabel";
            this.meanBLabel.Size = new System.Drawing.Size(56, 16);
            this.meanBLabel.TabIndex = 17;
            this.meanBLabel.Text = "Mean B:";
            // 
            // meanGLabel
            // 
            this.meanGLabel.AutoSize = true;
            this.meanGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanGLabel.Location = new System.Drawing.Point(11, 122);
            this.meanGLabel.Name = "meanGLabel";
            this.meanGLabel.Size = new System.Drawing.Size(57, 16);
            this.meanGLabel.TabIndex = 16;
            this.meanGLabel.Text = "Mean G:";
            // 
            // entropyTextBox
            // 
            this.entropyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entropyTextBox.Enabled = false;
            this.entropyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entropyTextBox.Location = new System.Drawing.Point(290, 162);
            this.entropyTextBox.Name = "entropyTextBox";
            this.entropyTextBox.Size = new System.Drawing.Size(100, 15);
            this.entropyTextBox.TabIndex = 14;
            this.entropyTextBox.Text = "0";
            // 
            // obiquilityTextBox
            // 
            this.obiquilityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.obiquilityTextBox.Enabled = false;
            this.obiquilityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obiquilityTextBox.Location = new System.Drawing.Point(290, 124);
            this.obiquilityTextBox.Name = "obiquilityTextBox";
            this.obiquilityTextBox.Size = new System.Drawing.Size(100, 15);
            this.obiquilityTextBox.TabIndex = 13;
            this.obiquilityTextBox.Text = "0";
            // 
            // variabilityTextBox
            // 
            this.variabilityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.variabilityTextBox.Enabled = false;
            this.variabilityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variabilityTextBox.Location = new System.Drawing.Point(290, 84);
            this.variabilityTextBox.Name = "variabilityTextBox";
            this.variabilityTextBox.Size = new System.Drawing.Size(100, 15);
            this.variabilityTextBox.TabIndex = 12;
            this.variabilityTextBox.Text = "0";
            // 
            // standardDeviationTextBox
            // 
            this.standardDeviationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.standardDeviationTextBox.Enabled = false;
            this.standardDeviationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardDeviationTextBox.Location = new System.Drawing.Point(290, 44);
            this.standardDeviationTextBox.Name = "standardDeviationTextBox";
            this.standardDeviationTextBox.Size = new System.Drawing.Size(100, 15);
            this.standardDeviationTextBox.TabIndex = 11;
            this.standardDeviationTextBox.Text = "0";
            // 
            // entropyLabel
            // 
            this.entropyLabel.AutoSize = true;
            this.entropyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entropyLabel.Location = new System.Drawing.Point(228, 161);
            this.entropyLabel.Name = "entropyLabel";
            this.entropyLabel.Size = new System.Drawing.Size(56, 16);
            this.entropyLabel.TabIndex = 9;
            this.entropyLabel.Text = "Entropy:";
            // 
            // obliquityLabel
            // 
            this.obliquityLabel.AutoSize = true;
            this.obliquityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obliquityLabel.Location = new System.Drawing.Point(222, 123);
            this.obliquityLabel.Name = "obliquityLabel";
            this.obliquityLabel.Size = new System.Drawing.Size(62, 16);
            this.obliquityLabel.TabIndex = 8;
            this.obliquityLabel.Text = "Obliquity:";
            // 
            // variabilityLabel
            // 
            this.variabilityLabel.AutoSize = true;
            this.variabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variabilityLabel.Location = new System.Drawing.Point(215, 84);
            this.variabilityLabel.Name = "variabilityLabel";
            this.variabilityLabel.Size = new System.Drawing.Size(69, 16);
            this.variabilityLabel.TabIndex = 7;
            this.variabilityLabel.Text = "Variability:";
            // 
            // standardDeviationLabel
            // 
            this.standardDeviationLabel.AutoSize = true;
            this.standardDeviationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardDeviationLabel.Location = new System.Drawing.Point(223, 43);
            this.standardDeviationLabel.Name = "standardDeviationLabel";
            this.standardDeviationLabel.Size = new System.Drawing.Size(61, 16);
            this.standardDeviationLabel.TabIndex = 6;
            this.standardDeviationLabel.Text = "Std. Dev:";
            // 
            // meanRLabel
            // 
            this.meanRLabel.AutoSize = true;
            this.meanRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanRLabel.Location = new System.Drawing.Point(11, 83);
            this.meanRLabel.Name = "meanRLabel";
            this.meanRLabel.Size = new System.Drawing.Size(57, 16);
            this.meanRLabel.TabIndex = 5;
            this.meanRLabel.Text = "Mean R:";
            // 
            // meanRTextBox
            // 
            this.meanRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meanRTextBox.Enabled = false;
            this.meanRTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanRTextBox.Location = new System.Drawing.Point(74, 84);
            this.meanRTextBox.Name = "meanRTextBox";
            this.meanRTextBox.Size = new System.Drawing.Size(100, 15);
            this.meanRTextBox.TabIndex = 4;
            this.meanRTextBox.Text = "0";
            // 
            // histogramChart
            // 
            chartArea1.Name = "ChartArea1";
            this.histogramChart.ChartAreas.Add(chartArea1);
            this.histogramChart.Enabled = false;
            legend1.Name = "Legend1";
            this.histogramChart.Legends.Add(legend1);
            this.histogramChart.Location = new System.Drawing.Point(552, 0);
            this.histogramChart.Name = "histogramChart";
            this.histogramChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.LightSlateGray;
            series1.Legend = "Legend1";
            series1.Name = "L";
            this.histogramChart.Series.Add(series1);
            this.histogramChart.Size = new System.Drawing.Size(474, 254);
            this.histogramChart.TabIndex = 3;
            this.histogramChart.Text = "chart1";
            title1.Name = "Pixels";
            title1.Text = "Histogram";
            this.histogramChart.Titles.Add(title1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.sobelButton);
            this.tabPage1.Controls.Add(this.sobelVerticalButton);
            this.tabPage1.Controls.Add(this.sobelHorizontalButton);
            this.tabPage1.Controls.Add(this.equalizeButton);
            this.tabPage1.Controls.Add(this.binaryMaxButton);
            this.tabPage1.Controls.Add(this.binaryMedianButton);
            this.tabPage1.Controls.Add(this.binaryMeanButton);
            this.tabPage1.Controls.Add(this.reverseBlueButton);
            this.tabPage1.Controls.Add(this.reverseGreenButton);
            this.tabPage1.Controls.Add(this.reverseRedButton);
            this.tabPage1.Controls.Add(this.blueButton);
            this.tabPage1.Controls.Add(this.greenButton);
            this.tabPage1.Controls.Add(this.redButton);
            this.tabPage1.Controls.Add(this.reverseButton);
            this.tabPage1.Controls.Add(this.grayscaleBuntton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1045, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            // 
            // equalizeButton
            // 
            this.equalizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.equalizeButton.Location = new System.Drawing.Point(278, 6);
            this.equalizeButton.Name = "equalizeButton";
            this.equalizeButton.Size = new System.Drawing.Size(85, 37);
            this.equalizeButton.TabIndex = 16;
            this.equalizeButton.Text = "Equalize";
            this.equalizeButton.UseVisualStyleBackColor = true;
            this.equalizeButton.Click += new System.EventHandler(this.equalizeButton_Click);
            // 
            // binaryMaxButton
            // 
            this.binaryMaxButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.binaryMaxButton.Location = new System.Drawing.Point(188, 93);
            this.binaryMaxButton.Name = "binaryMaxButton";
            this.binaryMaxButton.Size = new System.Drawing.Size(85, 37);
            this.binaryMaxButton.TabIndex = 15;
            this.binaryMaxButton.Text = "Binary Max";
            this.binaryMaxButton.UseVisualStyleBackColor = true;
            this.binaryMaxButton.Click += new System.EventHandler(this.binaryMaxButton_Click);
            // 
            // binaryMedianButton
            // 
            this.binaryMedianButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.binaryMedianButton.Location = new System.Drawing.Point(188, 50);
            this.binaryMedianButton.Name = "binaryMedianButton";
            this.binaryMedianButton.Size = new System.Drawing.Size(85, 37);
            this.binaryMedianButton.TabIndex = 14;
            this.binaryMedianButton.Text = "Binary Median";
            this.binaryMedianButton.UseVisualStyleBackColor = true;
            this.binaryMedianButton.Click += new System.EventHandler(this.binaryMedianButton_Click);
            // 
            // binaryMeanButton
            // 
            this.binaryMeanButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.binaryMeanButton.Location = new System.Drawing.Point(188, 6);
            this.binaryMeanButton.Name = "binaryMeanButton";
            this.binaryMeanButton.Size = new System.Drawing.Size(85, 37);
            this.binaryMeanButton.TabIndex = 13;
            this.binaryMeanButton.Text = "Binary Mean";
            this.binaryMeanButton.UseVisualStyleBackColor = true;
            this.binaryMeanButton.Click += new System.EventHandler(this.binaryMeanButton_Click);
            // 
            // reverseBlueButton
            // 
            this.reverseBlueButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.reverseBlueButton.Location = new System.Drawing.Point(97, 137);
            this.reverseBlueButton.Name = "reverseBlueButton";
            this.reverseBlueButton.Size = new System.Drawing.Size(85, 37);
            this.reverseBlueButton.TabIndex = 12;
            this.reverseBlueButton.Text = "Reverse B";
            this.reverseBlueButton.UseVisualStyleBackColor = true;
            this.reverseBlueButton.Click += new System.EventHandler(this.reverseBlueButton_Click);
            // 
            // reverseGreenButton
            // 
            this.reverseGreenButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.reverseGreenButton.Location = new System.Drawing.Point(97, 93);
            this.reverseGreenButton.Name = "reverseGreenButton";
            this.reverseGreenButton.Size = new System.Drawing.Size(85, 37);
            this.reverseGreenButton.TabIndex = 11;
            this.reverseGreenButton.Text = "Reverse G";
            this.reverseGreenButton.UseVisualStyleBackColor = true;
            this.reverseGreenButton.Click += new System.EventHandler(this.reverseGreenButton_Click);
            // 
            // reverseRedButton
            // 
            this.reverseRedButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.reverseRedButton.Location = new System.Drawing.Point(97, 50);
            this.reverseRedButton.Name = "reverseRedButton";
            this.reverseRedButton.Size = new System.Drawing.Size(85, 37);
            this.reverseRedButton.TabIndex = 10;
            this.reverseRedButton.Text = "Reverse R";
            this.reverseRedButton.UseVisualStyleBackColor = true;
            this.reverseRedButton.Click += new System.EventHandler(this.reverseRedButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(6, 137);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(85, 37);
            this.blueButton.TabIndex = 9;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.Location = new System.Drawing.Point(6, 93);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(85, 37);
            this.greenButton.TabIndex = 8;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(6, 50);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(85, 37);
            this.redButton.TabIndex = 7;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.reverseButton.Location = new System.Drawing.Point(97, 6);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(85, 37);
            this.reverseButton.TabIndex = 1;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // grayscaleBuntton
            // 
            this.grayscaleBuntton.Location = new System.Drawing.Point(6, 6);
            this.grayscaleBuntton.Name = "grayscaleBuntton";
            this.grayscaleBuntton.Size = new System.Drawing.Size(85, 37);
            this.grayscaleBuntton.TabIndex = 0;
            this.grayscaleBuntton.Text = "Grayscale";
            this.grayscaleBuntton.UseVisualStyleBackColor = true;
            this.grayscaleBuntton.Click += new System.EventHandler(this.grayscaleBuntton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.details);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 367);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 280);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.applyThreshholdButton);
            this.tabPage2.Controls.Add(this.threshholdValueLabel);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1045, 254);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Extras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // applyThreshholdButton
            // 
            this.applyThreshholdButton.Location = new System.Drawing.Point(217, 179);
            this.applyThreshholdButton.Name = "applyThreshholdButton";
            this.applyThreshholdButton.Size = new System.Drawing.Size(85, 37);
            this.applyThreshholdButton.TabIndex = 2;
            this.applyThreshholdButton.Text = "Apply";
            this.applyThreshholdButton.UseVisualStyleBackColor = true;
            // 
            // threshholdValueLabel
            // 
            this.threshholdValueLabel.AutoSize = true;
            this.threshholdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threshholdValueLabel.Location = new System.Drawing.Point(331, 136);
            this.threshholdValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.threshholdValueLabel.Name = "threshholdValueLabel";
            this.threshholdValueLabel.Size = new System.Drawing.Size(20, 24);
            this.threshholdValueLabel.TabIndex = 1;
            this.threshholdValueLabel.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar1.Location = new System.Drawing.Point(187, 128);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(140, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(527, 652);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // sobelHorizontalButton
            // 
            this.sobelHorizontalButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sobelHorizontalButton.Location = new System.Drawing.Point(279, 49);
            this.sobelHorizontalButton.Name = "sobelHorizontalButton";
            this.sobelHorizontalButton.Size = new System.Drawing.Size(85, 37);
            this.sobelHorizontalButton.TabIndex = 17;
            this.sobelHorizontalButton.Text = "Sobel Horizontal";
            this.sobelHorizontalButton.UseVisualStyleBackColor = true;
            this.sobelHorizontalButton.Click += new System.EventHandler(this.sobelHorizontalButton_Click);
            // 
            // sobelVerticalButton
            // 
            this.sobelVerticalButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sobelVerticalButton.Location = new System.Drawing.Point(279, 92);
            this.sobelVerticalButton.Name = "sobelVerticalButton";
            this.sobelVerticalButton.Size = new System.Drawing.Size(85, 37);
            this.sobelVerticalButton.TabIndex = 18;
            this.sobelVerticalButton.Text = "Sobel Vertical";
            this.sobelVerticalButton.UseVisualStyleBackColor = true;
            this.sobelVerticalButton.Click += new System.EventHandler(this.sobelVerticalButton_Click);
            // 
            // sobelButton
            // 
            this.sobelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sobelButton.Location = new System.Drawing.Point(279, 135);
            this.sobelButton.Name = "sobelButton";
            this.sobelButton.Size = new System.Drawing.Size(85, 37);
            this.sobelButton.TabIndex = 19;
            this.sobelButton.Text = "Sobel ";
            this.sobelButton.UseVisualStyleBackColor = true;
            this.sobelButton.Click += new System.EventHandler(this.sobelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Filters";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.details.ResumeLayout(false);
            this.details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TabPage details;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button grayscaleBuntton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label meanRLabel;
        private System.Windows.Forms.TextBox meanRTextBox;
        private System.Windows.Forms.TextBox entropyTextBox;
        private System.Windows.Forms.TextBox obiquilityTextBox;
        private System.Windows.Forms.TextBox variabilityTextBox;
        private System.Windows.Forms.TextBox standardDeviationTextBox;
        private System.Windows.Forms.Label entropyLabel;
        private System.Windows.Forms.Label obliquityLabel;
        private System.Windows.Forms.Label variabilityLabel;
        private System.Windows.Forms.Label standardDeviationLabel;
        private System.Windows.Forms.TextBox meanBTextBox;
        private System.Windows.Forms.TextBox meanGTextBox;
        private System.Windows.Forms.Label meanBLabel;
        private System.Windows.Forms.Label meanGLabel;
        private System.Windows.Forms.TextBox meanLTextBox;
        private System.Windows.Forms.Label meanLLablel;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramChart;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button reverseBlueButton;
        private System.Windows.Forms.Button reverseGreenButton;
        private System.Windows.Forms.Button reverseRedButton;
        private System.Windows.Forms.Button binaryMeanButton;
        private System.Windows.Forms.Button binaryMedianButton;
        private System.Windows.Forms.Button binaryMaxButton;
        private System.Windows.Forms.Button equalizeButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button applyThreshholdButton;
        private System.Windows.Forms.Label threshholdValueLabel;
        private System.Windows.Forms.Button sobelHorizontalButton;
        private System.Windows.Forms.Button sobelVerticalButton;
        private System.Windows.Forms.Button sobelButton;
    }
}

