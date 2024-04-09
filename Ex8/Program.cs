namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, temporario;

            Console.WriteLine("informe o valor 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o valor 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o valor 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            
            if (num1 < num2)
            {
                temporario = num2; 
                num2 = num1;
                num1 = temporario;
            }

            if (num1 < num3)
            {
                temporario = num3;
                num3 = num1;
                num1 = temporario;
            }

            if (num2 < num3)
            {
                temporario = num3;
                num3 = num2;
                num2 = temporario;
            }

            Console.WriteLine(num1 + ", " + num2 + ", " + num3);
        }
    }
}
