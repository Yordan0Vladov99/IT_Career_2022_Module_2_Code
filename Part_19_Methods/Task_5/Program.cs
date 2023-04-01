namespace Task_5
{
    internal class Program
    {
        static double convertFahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static double convertCelciusToFahrenheit(double celcius)
        {
            return celcius * 9 / 5 + 32;
        }
        static void Main()
        {
            double f = double.Parse(Console.ReadLine());
            double c = convertFahrenheitToCelcius(f);
            System.Console.WriteLine(c);
            double new_f = convertCelciusToFahrenheit(c);
            System.Console.WriteLine(new_f);
        }
    }
}