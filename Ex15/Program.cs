namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tabuada = 0;
            int resultado;
            

            while (tabuada < 10) 
            {
                int i = 0;

                tabuada++;

                while (i < 10)
                {
                    i++;

                    resultado = i * tabuada;

                    Console.WriteLine(tabuada + " x " + i + " = " + resultado + "\n");

                }
            }
            

           
        }
    }
}
