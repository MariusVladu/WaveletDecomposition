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
            var expectedMatrix = (double[,])matrix.Clone();

            Encoder.HorizontalAnalysis(matrix, level);
            Decoder.HorizontalSynthesis(matrix, level);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Assert.AreEqual(expectedMatrix[i, j], Math.Round(matrix[i, j], 6));
                }
            }
        }

        [TestMethod]
        public void TestThatAfterOneLevelOfAnalysisAndSynthesisMatrixRemainsTheSame()
        {
            var numberOfLevels = 1;
            var size = 512;
            var matrix = GetRandomMatrix(size);
            var expectedMatrix = (double[,])matrix.Clone();

            Encoder.PerformLevelsOfAnalysis(matrix, numberOfLevels);
            Decoder.PerformLevelsOfSynthesis(matrix, numberOfLevels);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Assert.AreEqual(expectedMatrix[i, j], Math.Round(matrix[i, j], 6));
                }
            }
        }

        [TestMethod]
        public void TestThatAfter5LevelsOfAnalysisAndSynthesisMatrixRemainsTheSame()
        {
            var numberOfLevels = 5;
            var size = 512;
            var matrix = GetRandomMatrix(size);
            var expectedMatrix = (double[,])matrix.Clone();

            Encoder.PerformLevelsOfAnalysis(matrix, numberOfLevels);
            Decoder.PerformLevelsOfSynthesis(matrix, numberOfLevels);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Assert.AreEqual(expectedMatrix[i, j], Math.Round(matrix[i, j], 6));
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
