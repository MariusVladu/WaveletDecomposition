using System.IO;

namespace WaveletDecomposition
{
    public static class FileOperations
    {
        public static void SaveMatrixToFile(double[,] matrix, string filePath)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write)))
            {
                for (int i = 0; i < 512; i++)
                    for (int j = 0; j < 512; j++)
                        binaryWriter.Write(matrix[i,j]);
            }
        }

        public static double[,] ReadMatrixFromFile(string filePath)
        {
            var matrix = new double[512, 512];

            using (BinaryReader binaryReader = new BinaryReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)))
            {
                for (int i = 0; i < 512; i++)
                    for (int j = 0; j < 512; j++)
                        matrix[i, j] = binaryReader.ReadDouble();
            }

            return matrix;
        }
    }
}
