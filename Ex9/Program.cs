namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Informe seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc <= 16.9)
            {
                Console.WriteLine("IMC: " + imc + " Muito abaixo do peso");
            }

            else if (imc >= 17 && imc <= 18.4)
            {
                Console.WriteLine("IMC: " + imc + " Abaixo do peso");
            }

            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine(" IMC: " + imc + " Peso normal");
            }

            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine(" IMC: " + imc + " Acima do peso");
            }

            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine(" IMC: " + imc + " obesidade grau I");
            }

            else if (imc >= 35 && imc <= 40)
            {
                Console.WriteLine(" IMC: " + imc + " Obesidade grau II");
            }

            else
            {
                Console.WriteLine(" IMC: " + imc + " Obesidade grau III");
            }

        }
    }
}
