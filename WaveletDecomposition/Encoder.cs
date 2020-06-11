using System.Collections.Generic;

namespace WaveletDecomposition
{
    public static class Encoder
    {
        public static void PerformLevelsOfAnalysis(double[,] matrix, int numberOfLevels)
        {
            for (int level = 1; level <= numberOfLevels; level++)
            {
                HorizontalAnalysis(matrix, level);
                VerticalAnalysis(matrix, level);
            }
        }

        public static void HorizontalAnalysis(double[,] matrix, int level)
        {
            var height = matrix.GetLength(0) >> (level - 1);
            var width = matrix.GetLength(1) >> (level - 1);

            for (int j = 0; j < width; j++)
            {
                var column = CommonOperations.GetMatrixColumnAsList(j, matrix, height);

                for (int i = 0; i < height / 2; i++)
                {
                    matrix[i, j] = CommonOperations.GetDotProductForIndex(i * 2, column, Constants.AnalysisVectorL);
                    matrix[i + height / 2, j] = CommonOperations.GetDotProductForIndex(i * 2 + 1, column, Constants.AnalysisVectorH);
                }
            }
        }

        public static void VerticalAnalysis(double[,] matrix, int level)
        {
            var height = matrix.GetLength(0) >> (level - 1);
            var width = matrix.GetLength(1) >> (level - 1);

            for (int i = 0; i < height; i++)
            {
                var line = CommonOperations.GetMatrixLineAsList(i, matrix, width);

                for (int j = 0; j < width / 2; j++)
                {
                    matrix[i, j] = CommonOperations.GetDotProductForIndex(j * 2, line, Constants.AnalysisVectorL);
                    matrix[i, j + width / 2] = CommonOperations.GetDotProductForIndex(j * 2 + 1, line, Constants.AnalysisVectorH);
                }
            }
        }
    }
}
