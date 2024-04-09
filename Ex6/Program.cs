namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double comprimento, largura, area;

            Console.WriteLine("Informe o comprimento da caixa: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a largura da caixa: ");
            largura = Convert.ToDouble(Console.ReadLine());

            area = comprimento * largura;

            Console.WriteLine("a area do terreno é de: " + area + "m²");


        }
    }
}
