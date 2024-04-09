namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Informe o numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0) 
            {
                Console.WriteLine("O numero é par");
            }

            else
            {
                Console.WriteLine("O numero é impar");
            }
        }
    }
}
