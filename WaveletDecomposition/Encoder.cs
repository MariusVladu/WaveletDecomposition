using System.Collections.Generic;

namespace WaveletDecomposition
{
    public static class Encoder
    {
        public static double[,] PerformLevelsOfAnalysis(double[,] matrix, int numberOfLevels)
        {
            for (int level = 0; level < numberOfLevels; level++)
            {
                matrix = HorizontalAnalysis(matrix, level);
                matrix = VerticalAnalysis(matrix, level);
            }

            return matrix;
        }

        public static double[,] HorizontalAnalysis(double[,] matrix, int level)
        {
            var height = matrix.GetLength(0) >> (level - 1);
            var width = matrix.GetLength(1) >> (level - 1);

            for (int j = 0; j < width; j++)
            {
                var column = CommonOperations.GetMatrixColumnAsList(j, matrix, height);

                var listAfterAnalysis = GetListAnalysis(column);
                for (int i = 0; i < height; i++)
                    matrix[i, j] = listAfterAnalysis[i];
            }

            return matrix;
        }

        public static double[,] VerticalAnalysis(double[,] matrix, int level)
        {
            var height = matrix.GetLength(0) >> (level - 1);
            var width = matrix.GetLength(1) >> (level - 1);

            for (int i = 0; i < height; i++)
            {
                var line = CommonOperations.GetMatrixLineAsList(i, matrix, width);

                var listAfterAnalysis = GetListAnalysis(line);
                for (int j = 0; j < width; j++)
                    matrix[i, j] = listAfterAnalysis[i];
            }

            return matrix;
        }

        public static List<double> GetListAnalysis(List<double> list)
        {
            var L = CommonOperations.ApplyConvolutionToList(list, Constants.AnalysisVectorL);
            var H = CommonOperations.ApplyConvolutionToList(list, Constants.AnalysisVectorH);

            return DownSampleAndRearrange(L, H);
        }

        public static List<double> DownSampleAndRearrange(List<double> L, List<double> H)
        {
            var length = L.Count;

            var result = new List<double>(length);

            for (int i = 0; i < length; i += 2)
                result.Add(L[i]);

            for (int i = 1; i < length; i += 2)
                result.Add(H[i]);

            return result;
        }
    }
}
