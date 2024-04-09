namespace Lista_de_exercios_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, largura, comprimento, volume;                                                      


            Console.WriteLine("Informe a altura da caixa: ");
            altura = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Informe a largura da caixa: ");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o comprimento da caixa: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            volume = largura * altura * comprimento;

            Console.WriteLine("O volume da caixa é de: " + volume + "cm²");



        }
    }
}
