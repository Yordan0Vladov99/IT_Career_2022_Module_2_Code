namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            string[] args = Console.ReadLine().Split();
            int system_base = int.Parse(args[0]);
            string number = args[1];
            int converted = 0;

            for (int i = number.Length - 1, exponent = 0; i >= 0; i--, exponent++)
            {
                converted += (number[i] - '0') * (int)Math.Pow(system_base, exponent);
            }
            Console.WriteLine(converted);

        }
    }
}