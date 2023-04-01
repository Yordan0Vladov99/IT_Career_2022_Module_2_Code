namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = "";
            string buffer = "";
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c >= '0' && c <= '9')
                {
                    buffer += c;
                }
                else
                {
                    if (buffer.Length != 0)
                    {
                        buffer = "";
                        output += c;
                    }
                    output += c;
                }
            }
            if (buffer.Length != 0)
            {
                output += buffer;
            }
            System.Console.WriteLine(output);
        }
    }
}