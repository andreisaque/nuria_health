namespace Nuria
{
    using System;
    class RaizPotencia
    {
        static void Main(string[] args)
        {
            //Formato UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaração de variáveis
            int[] dados = new int[2];
            double num_max, num_min, pot, raiz;

            //Tratamento de exceção
            try
            {
                Console.WriteLine("Informe dois Números:\n");

                //Números de entrada do usuário
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Número:");
                    dados[i] = Convert.ToInt32(Console.ReadLine());
                }

                //Atribuindo valores
                num_max = dados[0];
                num_min = dados[0];

                //Comparando os números
                for (int i = 0; i < dados.Length; i++)
                {
                    if (dados[i] > num_max)
                        num_max = dados[i];
                    if (dados[i] < num_min)
                        num_min = dados[i];
                }

                //Cálculo de potência;
                pot = Math.Pow(num_min, 2);

                //Cálculo de raiz quadrada;
                raiz = Math.Sqrt(num_max);

                //Imprimindo a resposta
                Console.WriteLine("\nQuadrado do Menor Número = {0} - Raiz quadrada do Maior Número = {1}", pot, raiz);

                //Encerramento do console
                Console.ReadLine();
            }

            //Erro ao digitar números
            catch (Exception)
            {
                Console.Write("Número Inválido. Por favor, digite novamente");
            }
        }
    }
}
