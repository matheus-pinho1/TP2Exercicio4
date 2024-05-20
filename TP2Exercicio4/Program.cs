namespace TP2Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo.");
                return;
            }

            MostrarSequenciaFibonacci(N);
        }

        static void MostrarSequenciaFibonacci(int N)
        {
            int primeiro = 0;
            int segundo = 1;

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Console.Write(primeiro);
                }
                else if (i == 1)
                {
                    Console.Write(", " + segundo);
                }
                else
                {
                    int proximo = primeiro + segundo;
                    Console.Write(", " + proximo);
                    primeiro = segundo;
                    segundo = proximo;
                }
            }
            Console.WriteLine();

        }
    }
}
