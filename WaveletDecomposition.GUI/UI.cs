using System;
using System.Drawing;
using System.Windows.Forms;

namespace WaveletDecomposition.GUI
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private string originalImagePath;
        private string waveletPath;
        private Bitmap originalBitmap;
        private Bitmap waveletBitmap;

        private double[,] originalMatrix;
        private double[,] waveletMatrix;

        private void buttonLoadOriginalImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Bitmap Image|*.bmp";
            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            originalImagePath = fileDialog.FileName;
            originalBitmap = new Bitmap(originalImagePath);
            originalMatrix = ImageMapper.GetPixelMatrixFromImage(originalBitmap);
            waveletMatrix = ImageMapper.GetPixelMatrixFromImage(originalBitmap);

            this.originalImagePanel.BackgroundImage = originalBitmap;
        }

        private void buttonLoadWavelet_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Wavelet File|*.wvl";
            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            waveletPath = fileDialog.FileName;

            waveletMatrix = FileOperations.ReadMatrixFromFile(waveletPath);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonVisualizeWavelet_Click(object sender, EventArgs e)
        {
            var waveletMatrixScaled = (double[,])waveletMatrix.Clone();
            MatrixScaling.ScaleMatrix(waveletMatrixScaled, (int)startScaleX.Value, (int)startScaleY.Value, (double)scale.Value, (int)offset.Value);

            waveletBitmap = ImageMapper.GetImageFromPixelMatrix(waveletMatrixScaled);

            this.waveletImagePanel.BackgroundImage = waveletBitmap;
        }

        private void buttonAnH1_Click(object sender, EventArgs e)
        {
            Encoder.HorizontalAnalysis(waveletMatrix, 1);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnV1_Click(object sender, EventArgs e)
        {
            Encoder.VerticalAnalysis(waveletMatrix, 1);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnH2_Click(object sender, EventArgs e)
        {
            Encoder.HorizontalAnalysis(waveletMatrix, 2);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnV2_Click(object sender, EventArgs e)
        {
            Encoder.VerticalAnalysis(waveletMatrix, 2);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnH3_Click(object sender, EventArgs e)
        {
            Encoder.HorizontalAnalysis(waveletMatrix, 3);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnV3_Click(object sender, EventArgs e)
        {
            Encoder.VerticalAnalysis(waveletMatrix, 3);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnH4_Click(object sender, EventArgs e)
        {
            Encoder.HorizontalAnalysis(waveletMatrix, 4);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnV4_Click(object sender, EventArgs e)
        {
            Encoder.VerticalAnalysis(waveletMatrix, 4);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnH5_Click(object sender, EventArgs e)
        {
            Encoder.HorizontalAnalysis(waveletMatrix, 5);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnV5_Click(object sender, EventArgs e)
        {
            Encoder.VerticalAnalysis(waveletMatrix, 5);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyH1_Click(object sender, EventArgs e)
        {
            Decoder.HorizontalSynthesis(waveletMatrix, 1);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyV1_Click(object sender, EventArgs e)
        {
            Decoder.VerticalSynthesis(waveletMatrix, 1);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyH2_Click(object sender, EventArgs e)
        {
            Decoder.HorizontalSynthesis(waveletMatrix, 2);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyV2_Click(object sender, EventArgs e)
        {
            Decoder.VerticalSynthesis(waveletMatrix, 2);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyH3_Click(object sender, EventArgs e)
        {
            Decoder.HorizontalSynthesis(waveletMatrix, 3);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyV3_Click(object sender, EventArgs e)
        {
            Decoder.VerticalSynthesis(waveletMatrix, 3);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyH4_Click(object sender, EventArgs e)
        {
            Decoder.HorizontalSynthesis(waveletMatrix, 4);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyV4_Click(object sender, EventArgs e)
        {
            Decoder.VerticalSynthesis(waveletMatrix, 4);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyH5_Click(object sender, EventArgs e)
        {
            Decoder.HorizontalSynthesis(waveletMatrix, 5);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSyV5_Click(object sender, EventArgs e)
        {
            Decoder.VerticalSynthesis(waveletMatrix, 5);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonAnalysis_Click(object sender, EventArgs e)
        {
            var numberOfLevels = (int)levels.Value;

            Encoder.PerformLevelsOfAnalysis(waveletMatrix, numberOfLevels);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSynthesis_Click(object sender, EventArgs e)
        {
            var numberOfLevels = (int)levels.Value;

            Decoder.PerformLevelsOfSynthesis(waveletMatrix, numberOfLevels);

            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonTestError_Click(object sender, EventArgs e)
        {
            if (originalBitmap == null || waveletBitmap == null)
            {
                MessageBox.Show("No wavelet image");
                return;
            }

            var height = originalMatrix.GetLength(0);
            var width = originalMatrix.GetLength(1);

            var minError = double.MaxValue;
            var maxError = double.MinValue;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    var error = Math.Round(originalMatrix[i, j] - waveletMatrix[i, j]);

                    if (error < minError)
                        minError = error;

                    if (error > maxError)
                        maxError = error;
                }
            }

            labelMinimumError.Visible = true;
            labelMaximumError.Visible = true;

            labelMinimumError.Text = $"Min = {(int)minError}";
            labelMaximumError.Text = $"Max = {(int)maxError}";
        }

        private void UpdatePreview(object sender, EventArgs e)
        {
            buttonVisualizeWavelet.PerformClick();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var outputPath = $"{originalImagePath}.wvl";

            FileOperations.SaveMatrixToFile(waveletMatrix, outputPath);
        }
    }
}
