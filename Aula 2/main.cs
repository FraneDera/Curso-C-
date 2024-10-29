using System;

class Program
{
    public static void Main(string[] args)
    {
        const double precoTotal = 20.00;
        double precoFinal = 0;
        //informando a idade do comprador
        Console.Write("Por Favor digite a idade : ");
        int idade = int.Parse(Console.ReadLine());

        //Condições de Desconcotos
        if (idade < 5)
        {
            precoFinal = 0;
        }
        else if (idade >= 5 && idade <= 12)
        {
            precoFinal = precoTotal * 0.5;
        }
        else if (idade >= 13 && idade <= 60)
        {
            precoFinal = precoTotal;
        }
        else if (idade > 60)
        {
            precoFinal = precoTotal * 0.7;
        }

        Console.WriteLine($"O valor do ingresso é : R$ {precoFinal:F2}");
    }
}