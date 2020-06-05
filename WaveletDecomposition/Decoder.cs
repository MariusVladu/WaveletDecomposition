using System.Collections.Generic;

namespace WaveletDecomposition
{
    public static class Decoder
    {
        public static double[,] VerticalSynthesis(double[,] matrix, int level)
        {
            var height = matrix.GetLength(0) >> (level - 1);
            var width = matrix.GetLength(1) >> (level - 1);

            for (int i = 0; i < height; i++)
            {
                var line = CommonOperations.GetMatrixLineAsList(i, matrix, width);

                var upsampledL = UpSampleList(line, true);
                var upsampledH = UpSampleList(line, false);

                var synthesisL = CommonOperations.ApplyConvolutionToList(upsampledL, Constants.SynthesisVectorL);
                var synthesisH = CommonOperations.ApplyConvolutionToList(upsampledH, Constants.SynthesisVectorH);

                for (int j = 0; j < width; j++)
                    matrix[i, j] = synthesisL[j] + synthesisH[j];
            }

            return matrix;
        }

        public static double[,] HorizontalSynthesis(double[,] matrix, int level)
        {
            var height = matrix.GetLength(0) >> (level - 1);
            var width = matrix.GetLength(1) >> (level - 1);

            for (int j = 0; j < width; j++)
            {
                var column = CommonOperations.GetMatrixColumnAsList(j, matrix, height);

                var upsampledL = UpSampleList(column, true);
                var upsampledH = UpSampleList(column, false);

                var synthesisL = CommonOperations.ApplyConvolutionToList(upsampledL, Constants.SynthesisVectorL);
                var synthesisH = CommonOperations.ApplyConvolutionToList(upsampledH, Constants.SynthesisVectorH);

                for (int i = 0; i < height; i++)
                    matrix[i, j] = synthesisL[i] + synthesisH[i];
            }

            return matrix;
        }

        public static List<double> UpSampleList(List<double> list, bool valuesOnEvenPositions)
        {
            var result = new List<double>(list.Count * 2);

            for (int i = 0; i < list.Count; i ++)
            {
                if(valuesOnEvenPositions)
                {
                    result.Add(list[i]);
                    result.Add(0);
                }
                else
                {
                    result.Add(0);
                    result.Add(list[i]);
                }
            }

            return result;
        }
    }
}
