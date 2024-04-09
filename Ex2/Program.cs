namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int temperaturaFahrenheit, temperaturaCelsius;

            Console.WriteLine("Informe a temperatura em Fahrenheit: ");
            temperaturaFahrenheit = Convert.ToInt32(Console.ReadLine());

            temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

            Console.WriteLine(temperaturaFahrenheit + $" graus Fahrenheit equivale à: " + temperaturaCelsius + " graus celsius ");
        }
    }
}
