using System;

class Program {
  public static void Main (string[] args) {
    //ex1
    Console.WriteLine ("Digite alguma coisa no teclado: ");

    //capturando a entrado do usuario
    string entrada = Console.ReadLine();

    //exibindo oq o usuario digitou
    Console.WriteLine("Você digitou: " + entrada);

    //ex2----------------------------------------------------
    Console.WriteLine("***********ex2************");
    // capturando o primeiro valor
    Console.WriteLine("Digite o primeiro valor: ");
    string valor1 = Console.ReadLine();
    int numero1 = int.Parse(valor1);


    // capturando o segundo valor
      Console.WriteLine("Digite o primeiro valor: ");
      string valor2 = Console.ReadLine();
      int numero2 = int.Parse(valor2);

    //calculando a soma 
    int soma = numero1 + numero2;

    //exibindo o resultado
       Console.WriteLine("A soma dos valores é: " + soma);
  }
  
}