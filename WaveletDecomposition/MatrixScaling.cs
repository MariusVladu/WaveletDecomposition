namespace WaveletDecomposition
{
    public static class MatrixScaling
    {
        public static void ScaleMatrix(double[,] matrix, int startX, int startY, double scale, int offset)
        {
            var height = matrix.GetLength(0);
            var width = matrix.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i >= startX || j >= startY)
                    {
                        matrix[i, j] = matrix[i, j] * scale + offset;
                    }
                }
            }
        }
    }
}
