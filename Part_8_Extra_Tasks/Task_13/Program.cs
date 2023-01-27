namespace Task_13
{
    internal class Program
    {
        static void Main()
        {

            byte key = byte.Parse(System.Console.ReadLine());
            byte n = byte.Parse(System.Console.ReadLine());
            String word = "";
            for (byte i = 0; i < n; i++)
            {
                char c = System.Console.ReadLine()[0];
                c = (char)((int)c + key);
                word += c;
            }
            System.Console.WriteLine(word);

        }
    }
}