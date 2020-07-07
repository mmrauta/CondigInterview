using System.Collections.Generic;

namespace CodingInterview.ArraysAndStrings
{
    /// <summary>
    /// Write an algorithm such that if an element in an MxN matrix is 0, its entire row and columns are set to 0.
    /// </summary>
    public static class ZeroMatrix
    {
        public static int[][] Run(int[][] input)
        {
            var columns = new HashSet<int>();
            var rows = new HashSet<int>();

            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (columns.Contains(j) || input[i][j] != 0)
                        continue;

                    columns.Add(j);
                    rows.Add(i);
                }

            foreach (var column in columns)
                NullifyColumn(input, column);

            foreach (var row in rows)
                NullifyRow(input, row);

            return input;
        }

        private static void NullifyColumn(int[][] input, int columnNumber)
        {
            foreach (var row in input)
                row[columnNumber] = 0;
        }

        private static void NullifyRow(int[][] input, int rowNumber)
        {
            for (var i = 0; i < input[rowNumber].Length; i++)
                input[rowNumber][i] = 0;
        }
    }
}
