namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            float[,] matrix = new float[rows, cols + 1];

            for (int row = 0; row < rows; row++)
            {
                float avg = 0;
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                    avg += matrix[row, col];
                }
                matrix[row, cols] = avg / cols;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col <= cols; col++)
                {
                    Console.Write("{0,10}", matrix[row, col]);
                }
                Console.WriteLine();
            }


        }
    }
}