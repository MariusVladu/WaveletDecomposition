using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaveletDecomposition.UnitTests.TestHelpers;

namespace WaveletDecomposition.UnitTests
{
    [TestClass]
    public class EncoderUnitTests
    {
        [TestMethod]
        public void TestThatGetListAnalysisReturnsExpectedRearrangedList()
        {
            var result = Encoder.GetListAnalysis(TestConstants.OriginalValues);
            var roundedElementsList = Util.GetListWithRoundedElements(result, 6);

            CollectionAssert.AreEqual(TestConstants.Rearranged, roundedElementsList);
        }
    }
}
