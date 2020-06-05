using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WaveletDecomposition.UnitTests.TestHelpers;

namespace WaveletDecomposition.UnitTests
{
    [TestClass]
    public class CommonOperationsUnitTests
    {
        [TestMethod]
        public void TestThatGetDotProductForIndexCalculatesCorrectlyTheFirstItem()
        {
            var index = 0;

            var result = CommonOperations.GetDotProductForIndex(index, TestConstants.OriginalValues, Constants.AnalysisVectorL);
            var roundedResult = Math.Round(result, 6);

            Assert.AreEqual(TestConstants.AnalysisL[index], roundedResult);
        }

        [TestMethod]
        public void TestThatGetDotProductForIndexCalculatesCorrectlyTheLastItem()
        {
            var index = TestConstants.OriginalValues.Count - 1;

            var result = CommonOperations.GetDotProductForIndex(index, TestConstants.OriginalValues, Constants.AnalysisVectorL);
            var roundedResult = Math.Round(result, 6);

            Assert.AreEqual(TestConstants.AnalysisL[index], roundedResult);
        }

        [TestMethod]
        public void TestThatGetDotProductForIndexCalculatesCorrectlyMiddleElement()
        {
            var index = TestConstants.OriginalValues.Count / 2;

            var result = CommonOperations.GetDotProductForIndex(index, TestConstants.OriginalValues, Constants.AnalysisVectorL);
            var roundedResult = Math.Round(result, 6);

            Assert.AreEqual(TestConstants.AnalysisL[index], roundedResult);
        }

        [TestMethod]
        public void TestThatApplyConvolutionToListReturnsExpectedAnalysisL()
        {
            var result = CommonOperations.ApplyConvolutionToList(TestConstants.OriginalValues, Constants.AnalysisVectorL);
            var roundedResult = Util.GetListWithRoundedElements(result, 6);

            CollectionAssert.AreEqual(TestConstants.AnalysisL, roundedResult);
        }

        [TestMethod]
        public void TestThatApplyConvolutionToListReturnsExpectedAnalysisH()
        {
            var result = CommonOperations.ApplyConvolutionToList(TestConstants.OriginalValues, Constants.AnalysisVectorH);
            var roundedResult = Util.GetListWithRoundedElements(result, 6);

            CollectionAssert.AreEqual(TestConstants.AnalysisH, roundedResult);
        }

        [TestMethod]
        public void TestThatApplyConvolutionToListReturnsExpectedSynthesisL()
        {
            var expectedRoundedResult = Util.GetListWithRoundedElements(TestConstants.SynthesisL, 5);

            var result = CommonOperations.ApplyConvolutionToList(TestConstants.UpSampleL, Constants.SynthesisVectorL);
            var roundedResult = Util.GetListWithRoundedElements(result, 5);

            CollectionAssert.AreEqual(expectedRoundedResult, roundedResult);
        }

        [TestMethod]
        public void TestThatApplyConvolutionToListReturnsExpectedSynthesisH()
        {
            var expectedRoundedResult = Util.GetListWithRoundedElements(TestConstants.SynthesisH, 5);

            var result = CommonOperations.ApplyConvolutionToList(TestConstants.UpSampleH, Constants.SynthesisVectorH);
            var roundedResult = Util.GetListWithRoundedElements(result, 5);

            CollectionAssert.AreEqual(expectedRoundedResult, roundedResult);
        }

        [TestMethod]
        public void TestThatGetMatrixLineAsListReturnsExpectedList()
        {
            var matrix = new double[,]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 }
            };
            var lineIndex = 1;
            var length = 2;
            var expectedList = new List<double> { 5, 6 };

            var result = CommonOperations.GetMatrixLineAsList(lineIndex, matrix, length);

            CollectionAssert.AreEqual(expectedList, result);
        }

        [TestMethod]
        public void TestThatGetMatrixColumnAsListReturnsExpectedList()
        {
            var matrix = new double[,]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 }
            };
            var columnIndex = 2;
            var length = 1;
            var expectedList = new List<double> { 3 };

            var result = CommonOperations.GetMatrixColumnAsList(columnIndex, matrix, length);

            CollectionAssert.AreEqual(expectedList, result);
        }
    }
}
