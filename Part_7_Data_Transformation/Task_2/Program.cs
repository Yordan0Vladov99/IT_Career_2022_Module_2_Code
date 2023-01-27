namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(System.Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                string str_i = Convert.ToString(i);
                int sum = 0;
                for (int j = 0; j < str_i.Length; j++)
                {
                    sum += str_i[j] - '0';
                }
                System.Console.WriteLine($"{i} -> {sum == 5 || sum == 7 || sum == 11}");

            }
        }
    }
}