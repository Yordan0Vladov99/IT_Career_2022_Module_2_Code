namespace Task_1
{
    internal class Program
    {
        static void PrintReceiptHeader()
        {
            System.Console.WriteLine("CASH RECEIPT");
            System.Console.WriteLine("------------------------------");
        }

        static void PrintReceiptBody()
        {
            System.Console.WriteLine("Charged to____________________");
            System.Console.WriteLine("Received by___________________");
        }

        static void PrintReceiptFooter()
        {
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("© BG");
        }
        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
        static void Main()
        {
            PrintReceipt();
        }
    }
}