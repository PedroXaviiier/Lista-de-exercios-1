namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int anterior;
            int resultado = 1;

            Console.WriteLine("Informe o numero para calcular o fatorial: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++) 
            {
                
                anterior = resultado * i;
                resultado = anterior;

                Console.WriteLine("\n" + numero + "! = " + anterior + " x " + i + " = " + resultado);
            }
        }
    }
}
