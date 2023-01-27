namespace Task_19
{
    internal class Program
    {
        static void Main()
        {
            char beginning = (char)int.Parse(System.Console.ReadLine());
            char end = (char)int.Parse(System.Console.ReadLine());
            for (char i = beginning; i <= end; i++)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
        }
    }
}