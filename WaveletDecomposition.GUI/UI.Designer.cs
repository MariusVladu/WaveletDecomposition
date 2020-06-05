namespace WaveletDecomposition.GUI
{
    partial class UI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.waveletImagePanel = new System.Windows.Forms.Panel();
            this.originalImagePanel = new System.Windows.Forms.Panel();
            this.buttonLoadOriginalImage = new System.Windows.Forms.Button();
            this.buttonTestError = new System.Windows.Forms.Button();
            this.labelMaximumError = new System.Windows.Forms.Label();
            this.labelMinimumError = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoadWavelet = new System.Windows.Forms.Button();
            this.buttonVisualizeWavelet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.scale = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.offset = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.startScaleX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.startScaleY = new System.Windows.Forms.NumericUpDown();
            this.buttonAnH1 = new System.Windows.Forms.Button();
            this.buttonSyH1 = new System.Windows.Forms.Button();
            this.buttonAnV1 = new System.Windows.Forms.Button();
            this.buttonSyV1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAnH2 = new System.Windows.Forms.Button();
            this.buttonSyV2 = new System.Windows.Forms.Button();
            this.buttonSyH2 = new System.Windows.Forms.Button();
            this.buttonAnV2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAnH3 = new System.Windows.Forms.Button();
            this.buttonSyV3 = new System.Windows.Forms.Button();
            this.buttonSyH3 = new System.Windows.Forms.Button();
            this.buttonAnV3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAnH4 = new System.Windows.Forms.Button();
            this.buttonSyV4 = new System.Windows.Forms.Button();
            this.buttonSyH4 = new System.Windows.Forms.Button();
            this.buttonAnV4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonAnH5 = new System.Windows.Forms.Button();
            this.buttonSyV5 = new System.Windows.Forms.Button();
            this.buttonSyH5 = new System.Windows.Forms.Button();
            this.buttonAnV5 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.levels = new System.Windows.Forms.NumericUpDown();
            this.buttonSynthesis = new System.Windows.Forms.Button();
            this.buttonAnalysis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startScaleY)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levels)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wavelet Image 512 x 512";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Original Image 512 x 512";
            // 
            // waveletImagePanel
            // 
            this.waveletImagePanel.Location = new System.Drawing.Point(539, 25);
            this.waveletImagePanel.Name = "waveletImagePanel";
            this.waveletImagePanel.Size = new System.Drawing.Size(512, 512);
            this.waveletImagePanel.TabIndex = 2;
            // 
            // originalImagePanel
            // 
            this.originalImagePanel.Location = new System.Drawing.Point(15, 25);
            this.originalImagePanel.Name = "originalImagePanel";
            this.originalImagePanel.Size = new System.Drawing.Size(512, 512);
            this.originalImagePanel.TabIndex = 3;
            // 
            // buttonLoadOriginalImage
            // 
            this.buttonLoadOriginalImage.Location = new System.Drawing.Point(15, 544);
            this.buttonLoadOriginalImage.Name = "buttonLoadOriginalImage";
            this.buttonLoadOriginalImage.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadOriginalImage.TabIndex = 6;
            this.buttonLoadOriginalImage.Text = "Load";
            this.buttonLoadOriginalImage.UseVisualStyleBackColor = true;
            this.buttonLoadOriginalImage.Click += new System.EventHandler(this.buttonLoadOriginalImage_Click);
            // 
            // buttonTestError
            // 
            this.buttonTestError.Location = new System.Drawing.Point(15, 573);
            this.buttonTestError.Name = "buttonTestError";
            this.buttonTestError.Size = new System.Drawing.Size(75, 23);
            this.buttonTestError.TabIndex = 7;
            this.buttonTestError.Text = "Test Error";
            this.buttonTestError.UseVisualStyleBackColor = true;
            this.buttonTestError.Click += new System.EventHandler(this.buttonTestError_Click);
            // 
            // labelMaximumError
            // 
            this.labelMaximumError.AutoSize = true;
            this.labelMaximumError.Location = new System.Drawing.Point(100, 581);
            this.labelMaximumError.Name = "labelMaximumError";
            this.labelMaximumError.Size = new System.Drawing.Size(39, 13);
            this.labelMaximumError.TabIndex = 24;
            this.labelMaximumError.Text = "Max = ";
            // 
            // labelMinimumError
            // 
            this.labelMinimumError.AutoSize = true;
            this.labelMinimumError.Location = new System.Drawing.Point(100, 565);
            this.labelMinimumError.Name = "labelMinimumError";
            this.labelMinimumError.Size = new System.Drawing.Size(36, 13);
            this.labelMinimumError.TabIndex = 23;
            this.labelMinimumError.Text = "Min = ";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(539, 573);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoadWavelet
            // 
            this.buttonLoadWavelet.Location = new System.Drawing.Point(539, 544);
            this.buttonLoadWavelet.Name = "buttonLoadWavelet";
            this.buttonLoadWavelet.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadWavelet.TabIndex = 26;
            this.buttonLoadWavelet.Text = "Load";
            this.buttonLoadWavelet.UseVisualStyleBackColor = true;
            this.buttonLoadWavelet.Click += new System.EventHandler(this.buttonLoadWavelet_Click);
            // 
            // buttonVisualizeWavelet
            // 
            this.buttonVisualizeWavelet.Location = new System.Drawing.Point(936, 544);
            this.buttonVisualizeWavelet.Name = "buttonVisualizeWavelet";
            this.buttonVisualizeWavelet.Size = new System.Drawing.Size(115, 23);
            this.buttonVisualizeWavelet.TabIndex = 27;
            this.buttonVisualizeWavelet.Text = "Visualize Wavelet";
            this.buttonVisualizeWavelet.UseVisualStyleBackColor = true;
            this.buttonVisualizeWavelet.Click += new System.EventHandler(this.buttonVisualizeWavelet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Scale";
            // 
            // scale
            // 
            this.scale.DecimalPlaces = 1;
            this.scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scale.Location = new System.Drawing.Point(686, 547);
            this.scale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(63, 20);
            this.scale.TabIndex = 28;
            this.scale.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.scale.ValueChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Offset";
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(686, 576);
            this.offset.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.offset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(63, 20);
            this.offset.TabIndex = 30;
            this.offset.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.offset.ValueChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(767, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "X";
            // 
            // startScaleX
            // 
            this.startScaleX.Location = new System.Drawing.Point(787, 547);
            this.startScaleX.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.startScaleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.startScaleX.Name = "startScaleX";
            this.startScaleX.Size = new System.Drawing.Size(63, 20);
            this.startScaleX.TabIndex = 32;
            this.startScaleX.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(767, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Y";
            // 
            // startScaleY
            // 
            this.startScaleY.Location = new System.Drawing.Point(787, 576);
            this.startScaleY.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.startScaleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.startScaleY.Name = "startScaleY";
            this.startScaleY.Size = new System.Drawing.Size(63, 20);
            this.startScaleY.TabIndex = 34;
            this.startScaleY.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // buttonAnH1
            // 
            this.buttonAnH1.Location = new System.Drawing.Point(6, 19);
            this.buttonAnH1.Name = "buttonAnH1";
            this.buttonAnH1.Size = new System.Drawing.Size(75, 23);
            this.buttonAnH1.TabIndex = 36;
            this.buttonAnH1.Text = "An H1";
            this.buttonAnH1.UseVisualStyleBackColor = true;
            this.buttonAnH1.Click += new System.EventHandler(this.buttonAnH1_Click);
            // 
            // buttonSyH1
            // 
            this.buttonSyH1.Location = new System.Drawing.Point(87, 19);
            this.buttonSyH1.Name = "buttonSyH1";
            this.buttonSyH1.Size = new System.Drawing.Size(75, 23);
            this.buttonSyH1.TabIndex = 37;
            this.buttonSyH1.Text = "Sy H1";
            this.buttonSyH1.UseVisualStyleBackColor = true;
            this.buttonSyH1.Click += new System.EventHandler(this.buttonSyH1_Click);
            // 
            // buttonAnV1
            // 
            this.buttonAnV1.Location = new System.Drawing.Point(6, 48);
            this.buttonAnV1.Name = "buttonAnV1";
            this.buttonAnV1.Size = new System.Drawing.Size(75, 23);
            this.buttonAnV1.TabIndex = 38;
            this.buttonAnV1.Text = "An V1";
            this.buttonAnV1.UseVisualStyleBackColor = true;
            this.buttonAnV1.Click += new System.EventHandler(this.buttonAnV1_Click);
            // 
            // buttonSyV1
            // 
            this.buttonSyV1.Location = new System.Drawing.Point(87, 48);
            this.buttonSyV1.Name = "buttonSyV1";
            this.buttonSyV1.Size = new System.Drawing.Size(75, 23);
            this.buttonSyV1.TabIndex = 39;
            this.buttonSyV1.Text = "Sy V1";
            this.buttonSyV1.UseVisualStyleBackColor = true;
            this.buttonSyV1.Click += new System.EventHandler(this.buttonSyV1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAnH1);
            this.groupBox1.Controls.Add(this.buttonSyV1);
            this.groupBox1.Controls.Add(this.buttonSyH1);
            this.groupBox1.Controls.Add(this.buttonAnV1);
            this.groupBox1.Location = new System.Drawing.Point(1057, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 78);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAnH2);
            this.groupBox2.Controls.Add(this.buttonSyV2);
            this.groupBox2.Controls.Add(this.buttonSyH2);
            this.groupBox2.Controls.Add(this.buttonAnV2);
            this.groupBox2.Location = new System.Drawing.Point(1057, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 78);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Level 2";
            // 
            // buttonAnH2
            // 
            this.buttonAnH2.Location = new System.Drawing.Point(6, 19);
            this.buttonAnH2.Name = "buttonAnH2";
            this.buttonAnH2.Size = new System.Drawing.Size(75, 23);
            this.buttonAnH2.TabIndex = 36;
            this.buttonAnH2.Text = "An H2";
            this.buttonAnH2.UseVisualStyleBackColor = true;
            this.buttonAnH2.Click += new System.EventHandler(this.buttonAnH2_Click);
            // 
            // buttonSyV2
            // 
            this.buttonSyV2.Location = new System.Drawing.Point(87, 48);
            this.buttonSyV2.Name = "buttonSyV2";
            this.buttonSyV2.Size = new System.Drawing.Size(75, 23);
            this.buttonSyV2.TabIndex = 39;
            this.buttonSyV2.Text = "Sy V2";
            this.buttonSyV2.UseVisualStyleBackColor = true;
            this.buttonSyV2.Click += new System.EventHandler(this.buttonSyV2_Click);
            // 
            // buttonSyH2
            // 
            this.buttonSyH2.Location = new System.Drawing.Point(87, 19);
            this.buttonSyH2.Name = "buttonSyH2";
            this.buttonSyH2.Size = new System.Drawing.Size(75, 23);
            this.buttonSyH2.TabIndex = 37;
            this.buttonSyH2.Text = "Sy H2";
            this.buttonSyH2.UseVisualStyleBackColor = true;
            this.buttonSyH2.Click += new System.EventHandler(this.buttonSyH2_Click);
            // 
            // buttonAnV2
            // 
            this.buttonAnV2.Location = new System.Drawing.Point(6, 48);
            this.buttonAnV2.Name = "buttonAnV2";
            this.buttonAnV2.Size = new System.Drawing.Size(75, 23);
            this.buttonAnV2.TabIndex = 38;
            this.buttonAnV2.Text = "An V2";
            this.buttonAnV2.UseVisualStyleBackColor = true;
            this.buttonAnV2.Click += new System.EventHandler(this.buttonAnV2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAnH3);
            this.groupBox3.Controls.Add(this.buttonSyV3);
            this.groupBox3.Controls.Add(this.buttonSyH3);
            this.groupBox3.Controls.Add(this.buttonAnV3);
            this.groupBox3.Location = new System.Drawing.Point(1057, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 78);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Level 3";
            // 
            // buttonAnH3
            // 
            this.buttonAnH3.Location = new System.Drawing.Point(6, 19);
            this.buttonAnH3.Name = "buttonAnH3";
            this.buttonAnH3.Size = new System.Drawing.Size(75, 23);
            this.buttonAnH3.TabIndex = 36;
            this.buttonAnH3.Text = "An H3";
            this.buttonAnH3.UseVisualStyleBackColor = true;
            this.buttonAnH3.Click += new System.EventHandler(this.buttonAnH3_Click);
            // 
            // buttonSyV3
            // 
            this.buttonSyV3.Location = new System.Drawing.Point(87, 48);
            this.buttonSyV3.Name = "buttonSyV3";
            this.buttonSyV3.Size = new System.Drawing.Size(75, 23);
            this.buttonSyV3.TabIndex = 39;
            this.buttonSyV3.Text = "Sy V3";
            this.buttonSyV3.UseVisualStyleBackColor = true;
            this.buttonSyV3.Click += new System.EventHandler(this.buttonSyV3_Click);
            // 
            // buttonSyH3
            // 
            this.buttonSyH3.Location = new System.Drawing.Point(87, 19);
            this.buttonSyH3.Name = "buttonSyH3";
            this.buttonSyH3.Size = new System.Drawing.Size(75, 23);
            this.buttonSyH3.TabIndex = 37;
            this.buttonSyH3.Text = "Sy H3";
            this.buttonSyH3.UseVisualStyleBackColor = true;
            this.buttonSyH3.Click += new System.EventHandler(this.buttonSyH3_Click);
            // 
            // buttonAnV3
            // 
            this.buttonAnV3.Location = new System.Drawing.Point(6, 48);
            this.buttonAnV3.Name = "buttonAnV3";
            this.buttonAnV3.Size = new System.Drawing.Size(75, 23);
            this.buttonAnV3.TabIndex = 38;
            this.buttonAnV3.Text = "An V3";
            this.buttonAnV3.UseVisualStyleBackColor = true;
            this.buttonAnV3.Click += new System.EventHandler(this.buttonAnV3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonAnH4);
            this.groupBox4.Controls.Add(this.buttonSyV4);
            this.groupBox4.Controls.Add(this.buttonSyH4);
            this.groupBox4.Controls.Add(this.buttonAnV4);
            this.groupBox4.Location = new System.Drawing.Point(1057, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 78);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Level 4";
            // 
            // buttonAnH4
            // 
            this.buttonAnH4.Location = new System.Drawing.Point(6, 19);
            this.buttonAnH4.Name = "buttonAnH4";
            this.buttonAnH4.Size = new System.Drawing.Size(75, 23);
            this.buttonAnH4.TabIndex = 36;
            this.buttonAnH4.Text = "An H4";
            this.buttonAnH4.UseVisualStyleBackColor = true;
            this.buttonAnH4.Click += new System.EventHandler(this.buttonAnH4_Click);
            // 
            // buttonSyV4
            // 
            this.buttonSyV4.Location = new System.Drawing.Point(87, 48);
            this.buttonSyV4.Name = "buttonSyV4";
            this.buttonSyV4.Size = new System.Drawing.Size(75, 23);
            this.buttonSyV4.TabIndex = 39;
            this.buttonSyV4.Text = "Sy V4";
            this.buttonSyV4.UseVisualStyleBackColor = true;
            this.buttonSyV4.Click += new System.EventHandler(this.buttonSyV4_Click);
            // 
            // buttonSyH4
            // 
            this.buttonSyH4.Location = new System.Drawing.Point(87, 19);
            this.buttonSyH4.Name = "buttonSyH4";
            this.buttonSyH4.Size = new System.Drawing.Size(75, 23);
            this.buttonSyH4.TabIndex = 37;
            this.buttonSyH4.Text = "Sy H4";
            this.buttonSyH4.UseVisualStyleBackColor = true;
            this.buttonSyH4.Click += new System.EventHandler(this.buttonSyH4_Click);
            // 
            // buttonAnV4
            // 
            this.buttonAnV4.Location = new System.Drawing.Point(6, 48);
            this.buttonAnV4.Name = "buttonAnV4";
            this.buttonAnV4.Size = new System.Drawing.Size(75, 23);
            this.buttonAnV4.TabIndex = 38;
            this.buttonAnV4.Text = "An V4";
            this.buttonAnV4.UseVisualStyleBackColor = true;
            this.buttonAnV4.Click += new System.EventHandler(this.buttonAnV4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonAnH5);
            this.groupBox5.Controls.Add(this.buttonSyV5);
            this.groupBox5.Controls.Add(this.buttonSyH5);
            this.groupBox5.Controls.Add(this.buttonAnV5);
            this.groupBox5.Location = new System.Drawing.Point(1057, 355);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 78);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Level 5";
            // 
            // buttonAnH5
            // 
            this.buttonAnH5.Location = new System.Drawing.Point(6, 19);
            this.buttonAnH5.Name = "buttonAnH5";
            this.buttonAnH5.Size = new System.Drawing.Size(75, 23);
            this.buttonAnH5.TabIndex = 36;
            this.buttonAnH5.Text = "An H5";
            this.buttonAnH5.UseVisualStyleBackColor = true;
            this.buttonAnH5.Click += new System.EventHandler(this.buttonAnH5_Click);
            // 
            // buttonSyV5
            // 
            this.buttonSyV5.Location = new System.Drawing.Point(87, 48);
            this.buttonSyV5.Name = "buttonSyV5";
            this.buttonSyV5.Size = new System.Drawing.Size(75, 23);
            this.buttonSyV5.TabIndex = 39;
            this.buttonSyV5.Text = "Sy V5";
            this.buttonSyV5.UseVisualStyleBackColor = true;
            this.buttonSyV5.Click += new System.EventHandler(this.buttonSyV5_Click);
            // 
            // buttonSyH5
            // 
            this.buttonSyH5.Location = new System.Drawing.Point(87, 19);
            this.buttonSyH5.Name = "buttonSyH5";
            this.buttonSyH5.Size = new System.Drawing.Size(75, 23);
            this.buttonSyH5.TabIndex = 37;
            this.buttonSyH5.Text = "Sy H5";
            this.buttonSyH5.UseVisualStyleBackColor = true;
            this.buttonSyH5.Click += new System.EventHandler(this.buttonSyH5_Click);
            // 
            // buttonAnV5
            // 
            this.buttonAnV5.Location = new System.Drawing.Point(6, 48);
            this.buttonAnV5.Name = "buttonAnV5";
            this.buttonAnV5.Size = new System.Drawing.Size(75, 23);
            this.buttonAnV5.TabIndex = 38;
            this.buttonAnV5.Text = "An V5";
            this.buttonAnV5.UseVisualStyleBackColor = true;
            this.buttonAnV5.Click += new System.EventHandler(this.buttonAnV5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.levels);
            this.groupBox6.Controls.Add(this.buttonSynthesis);
            this.groupBox6.Controls.Add(this.buttonAnalysis);
            this.groupBox6.Location = new System.Drawing.Point(1057, 459);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(169, 78);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Perform N levels";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "# Levels";
            // 
            // levels
            // 
            this.levels.Location = new System.Drawing.Point(60, 21);
            this.levels.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.levels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(102, 20);
            this.levels.TabIndex = 40;
            this.levels.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonSynthesis
            // 
            this.buttonSynthesis.Location = new System.Drawing.Point(87, 48);
            this.buttonSynthesis.Name = "buttonSynthesis";
            this.buttonSynthesis.Size = new System.Drawing.Size(75, 23);
            this.buttonSynthesis.TabIndex = 39;
            this.buttonSynthesis.Text = "Synthesis";
            this.buttonSynthesis.UseVisualStyleBackColor = true;
            this.buttonSynthesis.Click += new System.EventHandler(this.buttonSynthesis_Click);
            // 
            // buttonAnalysis
            // 
            this.buttonAnalysis.Location = new System.Drawing.Point(6, 48);
            this.buttonAnalysis.Name = "buttonAnalysis";
            this.buttonAnalysis.Size = new System.Drawing.Size(75, 23);
            this.buttonAnalysis.TabIndex = 37;
            this.buttonAnalysis.Text = "Analysis";
            this.buttonAnalysis.UseVisualStyleBackColor = true;
            this.buttonAnalysis.Click += new System.EventHandler(this.buttonAnalysis_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 608);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startScaleY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startScaleX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.buttonVisualizeWavelet);
            this.Controls.Add(this.buttonLoadWavelet);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelMaximumError);
            this.Controls.Add(this.labelMinimumError);
            this.Controls.Add(this.buttonTestError);
            this.Controls.Add(this.buttonLoadOriginalImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waveletImagePanel);
            this.Controls.Add(this.originalImagePanel);
            this.Name = "UI";
            this.Text = "Wavelet Decomposition";
            ((System.ComponentModel.ISupportInitialize)(this.scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startScaleY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel waveletImagePanel;
        private System.Windows.Forms.Panel originalImagePanel;
        private System.Windows.Forms.Button buttonLoadOriginalImage;
        private System.Windows.Forms.Button buttonTestError;
        private System.Windows.Forms.Label labelMaximumError;
        private System.Windows.Forms.Label labelMinimumError;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoadWavelet;
        private System.Windows.Forms.Button buttonVisualizeWavelet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown scale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown offset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown startScaleX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown startScaleY;
        private System.Windows.Forms.Button buttonAnH1;
        private System.Windows.Forms.Button buttonSyH1;
        private System.Windows.Forms.Button buttonAnV1;
        private System.Windows.Forms.Button buttonSyV1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAnH2;
        private System.Windows.Forms.Button buttonSyV2;
        private System.Windows.Forms.Button buttonSyH2;
        private System.Windows.Forms.Button buttonAnV2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAnH3;
        private System.Windows.Forms.Button buttonSyV3;
        private System.Windows.Forms.Button buttonSyH3;
        private System.Windows.Forms.Button buttonAnV3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAnH4;
        private System.Windows.Forms.Button buttonSyV4;
        private System.Windows.Forms.Button buttonSyH4;
        private System.Windows.Forms.Button buttonAnV4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonAnH5;
        private System.Windows.Forms.Button buttonSyV5;
        private System.Windows.Forms.Button buttonSyH5;
        private System.Windows.Forms.Button buttonAnV5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown levels;
        private System.Windows.Forms.Button buttonSynthesis;
        private System.Windows.Forms.Button buttonAnalysis;
    }
}

