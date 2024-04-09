namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double consumoPKM;
            double quilometragemInicial, quilometragemFinal, consumoGeral;


            Console.WriteLine("Informe a quilometragem inicial: ");
            quilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quilometragem final: ");
            quilometragemFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o consumo de combustivel: ");
            consumoGeral = Convert.ToDouble(Console.ReadLine());

            consumoPKM = consumoGeral / (quilometragemFinal - quilometragemInicial);

            Console.WriteLine("o consumo geral foi de " + consumoPKM.ToString("F") + " litros por km.");

        }
    }
}
