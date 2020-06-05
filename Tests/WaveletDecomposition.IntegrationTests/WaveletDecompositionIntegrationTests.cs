using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WaveletDecomposition.IntegrationTests
{
    [TestClass]
    public class WaveletDecompositionIntegrationTests
    {
        private static readonly Random random = new Random();

        [TestMethod]
        public void TestThatAfterOneHorizontalAnalysisAndSynthesisMatrixRemainsTheSame()
        {
            var level = 1;
            var size = 512;
            var matrix = GetRandomMatrix(size);

            var encoded = Encoder.HorizontalAnalysis(matrix, level);
            var decoded = Decoder.HorizontalSynthesis(matrix, level);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Assert.AreEqual(encoded[i, j], decoded[i, j]);
                }
            }
        }

        private double[,] GetRandomMatrix(int size)
        {
            var matrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(256);
                }
            }

            return matrix;
        }
    }
}
