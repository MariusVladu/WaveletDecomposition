using System.Collections.Generic;

namespace WaveletDecomposition
{
    public static class CommonOperations
    {
        public static List<double> ApplyConvolutionToList(List<double> list, double[] analysisVector)
        {
            var result = new List<double>(list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                result.Add(GetDotProductForIndex(i, list, analysisVector));
            }

            return result;
        }

        public static double GetDotProductForIndex(int index, List<double> list, double[] analysisVector)
        {
            var n = list.Count - 1;
            double result = 0;

            for (int i = -4; i <= 4; i++)
            {
                var listIndex = index + i;

                if (listIndex < 0)
                    listIndex = -listIndex;

                if (listIndex > n)
                    listIndex = n - (listIndex - n);

                result += list[listIndex] * analysisVector[i + 4];
            }

            return result;
        }

        public static List<double> GetMatrixLineAsList(int line, double[,] matrix, int length)
        {
            var result = new List<double>(length);

            for (int j = 0; j < length; j++)
            {
                result.Add(matrix[line, j]);
            }

            return result;
        }

        public static List<double> GetMatrixColumnAsList(int column, double[,] matrix, int length)
        {
            var result = new List<double>(length);

            for (int i = 0; i < length; i++)
            {
                result.Add(matrix[i, column]);
            }

            return result;
        }
    }
}
