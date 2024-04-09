namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            

            Console.WriteLine("informe o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            var soma = (a + b);

            Console.WriteLine("Resultado da soma é:" + soma);
        }


    }
}
