namespace Nuria
{
    using System;
    using static System.Console;

    class AnoBissexto
    {
        static void Main(string[] args)
        {
            //Tratamento de exceção
            try
            {
                //Formato UTF-8
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("Digite o seu o ano de nascimento:");

                //declarando variável
                int ano = int.Parse(Console.ReadLine());

                //Verificando o ano de nascimento
                if (((ano % 4 == 0) && (ano % 100 != 0)) || (ano % 400 == 0))
                    Console.WriteLine("\nAno bissexto");
                else
                    Console.WriteLine("\nAno não bissexto");

                //Encerramento do console
                Console.ReadLine();
            }

            //Erro ao informar a data de nascimento
            catch (Exception)
            {
                Console.Write("Ano Inválido. Por favor digite apenas números");
            }
        }
    }
}
