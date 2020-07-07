namespace CodingInterview.ArraysAndStrings
{
    /// <summary>
    /// Given an image represented by NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees.
    /// Can you do this in place?
    /// </summary>
    public static class RotateMatrix
    {
        public static int[][] Run(int[][] input)
        {
            var length = input.Length;

            var layerStart = 0;
            for (int l = 0; l < length / 2; l++)
            {
                var layerLength = length -  layerStart;
                for (var i = layerStart; i < layerLength-1; i++)
                {
                    var source = input[l][i];
                    var row = l;
                    var column = i;

                    for (var j = 0; j < 4; j++)
                    {
                        var newRow = column;
                        var newColumn = length - 1 - row;

                        var tmp = input[newRow][newColumn];
                        input[newRow][newColumn] = source;

                        source = tmp;
                        row = newRow;
                        column = newColumn;
                    }
                }

                layerStart++;
            }

            return input;
        }
    }
}
