namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            char[] word = Console.ReadLine().ToCharArray();
            Array.Reverse(word);
            string reversed = new string(word);
            Console.WriteLine(reversed);
        }
    }
}