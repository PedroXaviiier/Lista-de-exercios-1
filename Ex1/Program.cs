namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Indique o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c) 
            {
                Console.WriteLine("A + B é maior que C");
            }

            else 
            {
                Console.WriteLine("A + B é menor que C");
            }
        }
    }
}
