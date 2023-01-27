namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            string first_name = System.Console.ReadLine();
            string last_name = System.Console.ReadLine();
            int age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Hello, {first_name} {last_name}. You are {age} years old.");

        }
    }
}