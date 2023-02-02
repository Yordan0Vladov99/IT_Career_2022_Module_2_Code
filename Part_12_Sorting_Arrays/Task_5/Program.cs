namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}