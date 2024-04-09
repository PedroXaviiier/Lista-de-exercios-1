namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salarioBase = 1500, salarioTotal, totalVendas, comissao;


            Console.WriteLine("Informe o total de vendas do funcionario: ");
            totalVendas = Convert.ToDouble(Console.ReadLine());

            salarioTotal = salarioBase + totalVendas * 0.05; //5% das vendas

            Console.WriteLine("O salario do funcionario nesse mes sera de: " + salarioTotal);

            
        }
    }
}
