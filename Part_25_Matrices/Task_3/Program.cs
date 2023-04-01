namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows + 1, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int minCol = matrix[0, col];
                for (int row = 1; row < rows; row++)
                {
                    minCol = Math.Min(minCol, matrix[row, col]);
                }
                matrix[rows, col] = minCol;
            }

            for (int row = 0; row <= rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0,5}", matrix[row, col]);
                }
                Console.WriteLine();
            }


        }
    }
}