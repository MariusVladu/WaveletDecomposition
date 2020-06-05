using System;
using System.Drawing;

namespace WaveletDecomposition
{
    public static class ImageMapper
    {
        public static double[,] GetPixelMatrixFromImage(Bitmap image)
        {
            double[,] pixelMatrix = new double[image.Height, image.Width];

            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    Color color = image.GetPixel(i, j);
                    pixelMatrix[i, j] = (color.R + color.G + color.B) / 3;
                }

            return pixelMatrix;
        }

        public static Bitmap GetImageFromPixelMatrix(double[,] matrix)
        {
            var height = matrix.GetLength(0);
            var width = matrix.GetLength(1);

            var bitmap = new Bitmap(width, height);

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    var pixelIntensity = NormalizeValue((int)Math.Round(matrix[i, j]));

                    bitmap.SetPixel(i, j, Color.FromArgb(pixelIntensity, pixelIntensity, pixelIntensity));
                }

            return bitmap;
        }

        private static int NormalizeValue(int value)
        {
            if (value < 0)
                return 0;

            if (value > 255)
                return 255;

            return value;
        }
    }
}
