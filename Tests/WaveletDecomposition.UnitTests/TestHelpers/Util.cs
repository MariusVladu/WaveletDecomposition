using System;
using System.Collections.Generic;
using System.Linq;

namespace WaveletDecomposition.UnitTests.TestHelpers
{
    public static class Util
    {
        public static List<double> GetListWithRoundedElements(List<double> list, int digits)
        {
            return list.Select(x => Math.Round(x, digits)).ToList();
        }
    }
}
