namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(System.Console.ReadLine());
            int capacity = int.Parse(System.Console.ReadLine());

            int res = people / capacity;
            if (people % capacity != 0) res += 1;

            System.Console.WriteLine(res);
        }
    }
}