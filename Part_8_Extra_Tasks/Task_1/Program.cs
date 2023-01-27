namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            string type = System.Console.ReadLine();
            switch (type)
            {
                case "int":
                    System.Console.WriteLine(int.MaxValue);
                    System.Console.WriteLine(int.MinValue);
                    break;

                case "uint":
                    System.Console.WriteLine(uint.MaxValue);
                    System.Console.WriteLine(uint.MinValue);
                    break;

                case "long":
                    System.Console.WriteLine(long.MaxValue);
                    System.Console.WriteLine(long.MinValue);
                    break;
                case "byte":
                    System.Console.WriteLine(byte.MaxValue);
                    System.Console.WriteLine(byte.MinValue);
                    break;

                case "sbyte":
                    System.Console.WriteLine(sbyte.MaxValue);
                    System.Console.WriteLine(sbyte.MinValue);
                    break;


            }
        }
    }
}