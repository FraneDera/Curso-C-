using System;

class Program
{
    public static void Main(string[] args)
    {
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            bool acertou = false;
            Console.WriteLine("Bem-vindo ao jogo da adivinhação em c#");
            //enquanto o usuario não acertar
            while (!acertou)
            {
                Console.Write("Digite sua tentativa: ");
                string input = Console.ReadLine();
                //verifica se o usuario digitou um numero
                if (int.TryParse(input, out tentativas))
                {
                    //logico do jogo
                    if (tentativas < 1 || tentativas > 100)
                    {
                        Console.WriteLine("Por favor, digite um numero entre 1 e 100");
                    }
                    else if (tentativas < numeroSecreto)
                    {
                        Console.WriteLine("O numero secreto é maior");
                    }
                    else if (tentativas > numeroSecreto)
                    {
                        Console.WriteLine("O numero secreto é menor");
                    }
                    else
                    {
                        Console.WriteLine("Parabéns voce acertou");
                        acertou = true;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite ouutro número");
                }
            }
        }
    }
}