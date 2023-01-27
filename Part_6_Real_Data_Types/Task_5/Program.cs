namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            float distance = float.Parse(System.Console.ReadLine());
            float hours = float.Parse(System.Console.ReadLine());
            float minutes = float.Parse(System.Console.ReadLine());
            float seconds = float.Parse(System.Console.ReadLine());
            float total = seconds + 60 * minutes + 60 * 60 * hours;
            float speed = distance / total;
            System.Console.WriteLine($"{speed:f7}");
            speed = distance / 1000 / (total / 3600);
            System.Console.WriteLine($"{speed:f7}");
            System.Console.WriteLine($"{speed / 1.609:f7}");


        }
    }
}