namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            string[] args = Console.ReadLine().Split();
            string first = args[0];
            string second = args[1];
            int sum = 0;
            int first_index = 0;
            int second_index = 0;
            for (; first_index < first.Length && second_index < second.Length; first_index++, second_index++)
            {
                sum += first[first_index] * second[second_index];
            }
            for (; first_index < first.Length; first_index++)
            {
                sum += first[first_index];
            }
            for (; second_index < second.Length; second_index++)
            {
                sum += second[second_index];
            }
            Console.WriteLine(sum);

        }
    }
}