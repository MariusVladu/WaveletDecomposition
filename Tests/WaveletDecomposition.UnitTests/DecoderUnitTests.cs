using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WaveletDecomposition.UnitTests.TestHelpers;

namespace WaveletDecomposition.UnitTests
{
    [TestClass]
    public class DecoderUnitTests
    {
        [TestMethod]
        public void TestThatUpSampleListReturnsExpectedUpSampledL()
        {
            var listLength = TestConstants.Rearranged.Count;
            var lowPartOfRearranged = TestConstants.Rearranged.Take(listLength / 2).ToList();

            var result = Decoder.UpSampleList(lowPartOfRearranged, true);
            var roundedElementsResult = Util.GetListWithRoundedElements(result, 6);

            CollectionAssert.AreEqual(TestConstants.UpSampleL, roundedElementsResult);
        }

        [TestMethod]
        public void TestThatUpSampleListReturnsExpectedUpSampledH()
        {
            var listLength = TestConstants.Rearranged.Count;
            var highPartOfRearranged = TestConstants.Rearranged.Skip(listLength / 2).Take(listLength / 2).ToList();

            var result = Decoder.UpSampleList(highPartOfRearranged, false);
            var roundedElementsResult = Util.GetListWithRoundedElements(result, 6);

            CollectionAssert.AreEqual(TestConstants.UpSampleH, roundedElementsResult);
        }
    }
}
