namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            int sum = Console.ReadLine().Split(' ').Select(num =>
            {
                char[] c = num.ToCharArray();
                Array.Reverse(c);
                return int.Parse(new string(c));
            }).Sum();

            System.Console.WriteLine(sum);
        }
    }
}