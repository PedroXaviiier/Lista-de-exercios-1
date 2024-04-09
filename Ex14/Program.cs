namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contagem;

            Console.WriteLine("Informe o tamanho da contagem: ");
            contagem = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= contagem; i++)
            {

                if (i % 3 == 0) 
                {
                    Console.WriteLine("Fizz");

                }

                else if(i % 5 == 0) 
                {

                    Console.WriteLine("Buzz");
                     
                }

                else 
                {
                    Console.WriteLine(i);
                }

            }
            
        }
    }
}
