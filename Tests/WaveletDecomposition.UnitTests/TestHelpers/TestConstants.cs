﻿using System.Collections.Generic;

namespace WaveletDecomposition.UnitTests.TestHelpers
{
    public static class TestConstants
    {
        public static List<double> OriginalValues = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 9, 3, 2, 7, 5, 2, 8, 2, 55, 2, 7, 3, 1, 6, 9, 1, 3, 2, 66 };
        public static List<double> AnalysisL = new List<double> { 1.333641, 1.936590, 3.073267, 4.053498, 5.000000, 5.973251, 6.963367, 8.031705, 8.833180, 9.031705, 8.802874, 8.887195, 9.533891, 7.873111, 3.550919, 3.048637, 5.705122, 6.261889, 3.143611, 1.286614, 17.770563, 33.132475, 17.422570, 1.494277, 2.318917, 3.253989, 5.911796, 8.850036, 2.183380, -3.285223, 19.369724, 40.840501 };
        public static List<double> AnalysisH = new List<double> { -0.865087, 0.250000, 0.182544, 0.000000, 0.000000, 0.000000, -0.091272, -0.125000, 0.432544, -0.125000, -0.091272, -0.547631, -0.293641, 3.767892, -2.801620, -3.484163, 4.930609, 0.134913, -0.771760, 3.924444, -34.154860, 58.557907, -33.894947, 2.356987, 3.996132, -4.853240, 1.460348, 6.123066, -0.325314, -2.014144, -37.644947, 71.067941 };

        public static List<double> DownSampleL = new List<double> { 1.333641, 3.073267, 0, 5.000000, 0, 6.963367, 0, 8.833180, 0, 8.802874, 0, 9.533891, 0, 3.550919, 0, 5.705122, 0, 3.143611, 0, 17.770563, 0, 17.422570, 0, 2.318917, 0, 5.911796, 0, 2.183380, 0, 19.369724, 0, };
        public static List<double> DownSampleH = new List<double> { 0, 0.250000, 0, 0.000000, 0, 0.000000, 0, -0.125000, 0, -0.125000, 0, -0.547631, 0, 3.767892, 0, -3.484163, 0, 0.134913, 0, 3.924444, 0, 58.557907, 0, 2.356987, 0, -4.853240, 0, 6.123066, 0, -2.014144, 0, 71.067941 };

        public static List<double> Rearranged = new List<double> { 1.333641, 3.073267, 5.000000, 6.963367, 8.833180, 8.802874, 9.533891, 3.550919, 5.705122, 3.143611, 17.770563, 17.422570, 2.318917, 5.911796, 2.183380, 19.369724, 0.250000, 0.000000, 0.000000, -0.125000, -0.125000, -0.547631, 3.767892, -3.484163, 0.134913, 3.924444, 58.557907, 2.356987, -4.853240, 6.123066, -2.014144, 71.067941 };

        public static List<double> UpSampleL = new List<double> { 1.333641, 0, 3.073267, 0, 5.000000, 0, 6.963367, 0, 8.833180, 0, 8.802874, 0, 9.533891, 0, 3.550919, 0, 5.705122, 0, 3.143611, 0, 17.770563, 0, 17.422570, 0, 2.318917, 0, 5.911796, 0, 2.183380, 0, 19.369724, 0 };
        public static List<double> UpSampleH = new List<double> { 0, 0.250000, 0, 0.000000, 0, 0.000000, 0, -0.125000, 0, -0.125000, 0, -0.547631, 0, 3.767892, 0, -3.484163, 0, 0.134913, 0, 3.924444, 0, 58.557907, 0, 2.356987, 0, -4.853240, 0, 6.123066, 0, -2.014144, 0, 71.067941, };

        public static List<double> SynthesisL = new List<double> { 1.133432, 1.868819, 3.062500, 4.016212, 4.997892, 5.986878, 6.968750, 8.080239, 8.942519, 8.921967, 8.759065, 9.711693, 9.920238, 6.412508, 3.082677, 4.315738, 5.976481, 3.285957, 2.154526, 10.255055, 18.632274, 20.310131, 18.271663, 9.511053, 1.243052, 3.077118, 6.333089, 2.806889, 0.979871, 10.436253, 20.358687, 22.506980 };
        public static List<double> SynthesisH = new List<double> { -0.133432, 0.131181, -0.062500, -0.016212, 0.002108, 0.013122, 0.031250, -0.080239, 0.057481, 0.078033, 0.240935, -0.711693, -0.920238, 2.587492, -0.082677, -2.315738, 1.023519, 1.714043, -0.154526, -2.255055, -16.632274, 34.689869, -16.271663, -2.511053, 1.756948, -2.077118, -0.333089, 6.193111, 0.020129, -7.436253, -18.358687, 43.493020 };
    }
}
