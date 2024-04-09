namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota1, peso1, nota2, peso2, media;

            Console.WriteLine("Informe a nota da primeira prova: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota da segunda prova: ");
            nota2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Informe o peso da nota da primeira prova: ");
            peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o peso da nota da segunda prova: ");
            peso2 = Convert.ToDouble(Console.ReadLine());

            media = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            Console.WriteLine("A media do aluno é " + media);



        }
    }
}
