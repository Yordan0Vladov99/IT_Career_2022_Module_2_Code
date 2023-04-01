namespace Task_1
{
    internal class Program
    {
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());
            if (num < 0) num *= -1;

            int odd_sum = 0;
            int even_sum = 0;

            string str_num = num.ToString();
            for (int i = 0; i < str_num.Length; i++)
            {
                int digit = str_num[i] - '0';
                if (digit % 2 == 0)
                {
                    even_sum += digit;
                }
                else
                {
                    odd_sum += digit;

                }
            }

            Console.WriteLine(odd_sum * even_sum);
        }
    }
}