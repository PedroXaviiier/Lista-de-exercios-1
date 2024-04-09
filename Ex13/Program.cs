using System.Dynamic;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int anterior = 0;
            int resultado;
            int temporario = 1;

            Console.WriteLine("Informe o limite para sequencia de Fibonacci: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= numero; i++ )
            {
               
               resultado = anterior + temporario;
               anterior = temporario;
               temporario = resultado; 

                Console.WriteLine(resultado);
            }

        }
    }
}
