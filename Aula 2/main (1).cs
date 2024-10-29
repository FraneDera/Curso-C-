using System;

class Program {
  public static void Main (string[] args) {
    // Solicitando a nota que o aluno tirou
    Console.WriteLine("Insire a sua nota (0 a 100): ");
    int nota = int.Parse(Console.ReadLine());
    // Verificando se a nota é válida
    if (nota >= 0 && nota <= 100){
      // Verificando se a nota é azul 
      if (nota >= 50){
        Console.WriteLine("Parabéns, Você esta com nota azul");
      }
      else{
        Console.WriteLine("Estude mais, você esta de recuperção");
      }
    }
    else
    {
      Console.WriteLine("Nota inválida! Insire outra nota");
    }
  }
}