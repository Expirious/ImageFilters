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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SelectImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.resetButton = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.details = new System.Windows.Forms.TabPage();
            this.meanLabel = new System.Windows.Forms.Label();
            this.meanTextBox = new System.Windows.Forms.TextBox();
            this.histogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reverseButton = new System.Windows.Forms.Button();
            this.grayscaleBuntton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.standardDeviationLabel = new System.Windows.Forms.Label();
            this.variabilityLabel = new System.Windows.Forms.Label();
            this.obliquityLabel = new System.Windows.Forms.Label();
            this.entropyLabel = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.standardDeviationTextBox = new System.Windows.Forms.TextBox();
            this.variabilityTextBox = new System.Windows.Forms.TextBox();
            this.obiquilityTextBox = new System.Windows.Forms.TextBox();
            this.entropyTextBox = new System.Windows.Forms.TextBox();
            this.energyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.details.Controls.Add(this.energyTextBox);
            this.details.Controls.Add(this.entropyTextBox);
            this.details.Controls.Add(this.obiquilityTextBox);
            this.details.Controls.Add(this.variabilityTextBox);
            this.details.Controls.Add(this.standardDeviationTextBox);
            this.details.Controls.Add(this.energyLabel);
            this.details.Controls.Add(this.entropyLabel);
            this.details.Controls.Add(this.obliquityLabel);
            this.details.Controls.Add(this.variabilityLabel);
            this.details.Controls.Add(this.standardDeviationLabel);
            this.details.Controls.Add(this.meanLabel);
            this.details.Controls.Add(this.meanTextBox);
            this.details.Controls.Add(this.histogramChart);
            this.details.Location = new System.Drawing.Point(4, 22);
            this.details.Name = "details";
            this.details.Padding = new System.Windows.Forms.Padding(3);
            this.details.Size = new System.Drawing.Size(1045, 254);
            this.details.TabIndex = 1;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = true;
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanLabel.Location = new System.Drawing.Point(164, 9);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(44, 16);
            this.meanLabel.TabIndex = 5;
            this.meanLabel.Text = "Mean:";
            // 
            // meanTextBox
            // 
            this.meanTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meanTextBox.Enabled = false;
            this.meanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanTextBox.Location = new System.Drawing.Point(214, 10);
            this.meanTextBox.Name = "meanTextBox";
            this.meanTextBox.Size = new System.Drawing.Size(100, 15);
            this.meanTextBox.TabIndex = 4;
            this.meanTextBox.Text = "0";
            // 
            // histogramChart
            // 
            chartArea2.Name = "ChartArea1";
            this.histogramChart.ChartAreas.Add(chartArea2);
            this.histogramChart.Enabled = false;
            legend2.Name = "Legend1";
            this.histogramChart.Legends.Add(legend2);
            this.histogramChart.Location = new System.Drawing.Point(552, 0);
            this.histogramChart.Name = "histogramChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.LightSeaGreen;
            series2.Legend = "Legend1";
            series2.Name = "Pixels";
            this.histogramChart.Series.Add(series2);
            this.histogramChart.Size = new System.Drawing.Size(474, 254);
            this.histogramChart.TabIndex = 3;
            this.histogramChart.Text = "chart1";
            title2.Name = "Pixels";
            title2.Text = "Histogram";
            this.histogramChart.Titles.Add(title2);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.reverseButton);
            this.tabPage1.Controls.Add(this.grayscaleBuntton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1045, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            // 
            // reverseButton
            // 
            this.reverseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.reverseButton.Location = new System.Drawing.Point(6, 49);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 367);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 280);
            this.tabControl1.TabIndex = 4;
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
            // standardDeviationLabel
            // 
            this.standardDeviationLabel.AutoSize = true;
            this.standardDeviationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardDeviationLabel.Location = new System.Drawing.Point(147, 44);
            this.standardDeviationLabel.Name = "standardDeviationLabel";
            this.standardDeviationLabel.Size = new System.Drawing.Size(61, 16);
            this.standardDeviationLabel.TabIndex = 6;
            this.standardDeviationLabel.Text = "Std. Dev:";
            // 
            // variabilityLabel
            // 
            this.variabilityLabel.AutoSize = true;
            this.variabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variabilityLabel.Location = new System.Drawing.Point(139, 84);
            this.variabilityLabel.Name = "variabilityLabel";
            this.variabilityLabel.Size = new System.Drawing.Size(69, 16);
            this.variabilityLabel.TabIndex = 7;
            this.variabilityLabel.Text = "Variability:";
            // 
            // obliquityLabel
            // 
            this.obliquityLabel.AutoSize = true;
            this.obliquityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obliquityLabel.Location = new System.Drawing.Point(146, 124);
            this.obliquityLabel.Name = "obliquityLabel";
            this.obliquityLabel.Size = new System.Drawing.Size(62, 16);
            this.obliquityLabel.TabIndex = 8;
            this.obliquityLabel.Text = "Obliquity:";
            // 
            // entropyLabel
            // 
            this.entropyLabel.AutoSize = true;
            this.entropyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entropyLabel.Location = new System.Drawing.Point(152, 162);
            this.entropyLabel.Name = "entropyLabel";
            this.entropyLabel.Size = new System.Drawing.Size(56, 16);
            this.entropyLabel.TabIndex = 9;
            this.entropyLabel.Text = "Entropy:";
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyLabel.Location = new System.Drawing.Point(155, 203);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(53, 16);
            this.energyLabel.TabIndex = 10;
            this.energyLabel.Text = "Energy:";
            // 
            // standardDeviationTextBox
            // 
            this.standardDeviationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.standardDeviationTextBox.Enabled = false;
            this.standardDeviationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardDeviationTextBox.Location = new System.Drawing.Point(214, 45);
            this.standardDeviationTextBox.Name = "standardDeviationTextBox";
            this.standardDeviationTextBox.Size = new System.Drawing.Size(100, 15);
            this.standardDeviationTextBox.TabIndex = 11;
            this.standardDeviationTextBox.Text = "0";
            // 
            // variabilityTextBox
            // 
            this.variabilityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.variabilityTextBox.Enabled = false;
            this.variabilityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variabilityTextBox.Location = new System.Drawing.Point(214, 85);
            this.variabilityTextBox.Name = "variabilityTextBox";
            this.variabilityTextBox.Size = new System.Drawing.Size(100, 15);
            this.variabilityTextBox.TabIndex = 12;
            this.variabilityTextBox.Text = "0";
            // 
            // obiquilityTextBox
            // 
            this.obiquilityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.obiquilityTextBox.Enabled = false;
            this.obiquilityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obiquilityTextBox.Location = new System.Drawing.Point(214, 125);
            this.obiquilityTextBox.Name = "obiquilityTextBox";
            this.obiquilityTextBox.Size = new System.Drawing.Size(100, 15);
            this.obiquilityTextBox.TabIndex = 13;
            this.obiquilityTextBox.Text = "0";
            // 
            // entropyTextBox
            // 
            this.entropyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entropyTextBox.Enabled = false;
            this.entropyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entropyTextBox.Location = new System.Drawing.Point(214, 163);
            this.entropyTextBox.Name = "entropyTextBox";
            this.entropyTextBox.Size = new System.Drawing.Size(100, 15);
            this.entropyTextBox.TabIndex = 14;
            this.entropyTextBox.Text = "0";
            // 
            // energyTextBox
            // 
            this.energyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.energyTextBox.Enabled = false;
            this.energyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyTextBox.Location = new System.Drawing.Point(214, 203);
            this.energyTextBox.Name = "energyTextBox";
            this.energyTextBox.Size = new System.Drawing.Size(100, 15);
            this.energyTextBox.TabIndex = 15;
            this.energyTextBox.Text = "0";
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
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramChart;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button grayscaleBuntton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.TextBox meanTextBox;
        private System.Windows.Forms.TextBox energyTextBox;
        private System.Windows.Forms.TextBox entropyTextBox;
        private System.Windows.Forms.TextBox obiquilityTextBox;
        private System.Windows.Forms.TextBox variabilityTextBox;
        private System.Windows.Forms.TextBox standardDeviationTextBox;
        private System.Windows.Forms.Label energyLabel;
        private System.Windows.Forms.Label entropyLabel;
        private System.Windows.Forms.Label obliquityLabel;
        private System.Windows.Forms.Label variabilityLabel;
        private System.Windows.Forms.Label standardDeviationLabel;
    }
}

