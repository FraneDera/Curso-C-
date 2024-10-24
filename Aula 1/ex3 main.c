using System;

class Program {
public
  static void Main(string[] args) {
    // Exercicio 3
    Console.WriteLine("Sua media de notas do ano");
    Console.WriteLine("Coloque sua primeira nota:");
    string nota1 = Console.ReadLine();
    int nota1_int = int.Parse(nota1);

    Console.WriteLine("Coloque a segunda nota:");
    string nota2 = Console.ReadLine();
    int nota2_int = int.Parse(nota2);

    Console.WriteLine("Coloque a terceira nota:");
    string nota3 = Console.ReadLine();
    int nota3_int = int.Parse(nota3);

    int soma = nota1_int + nota2_int + nota3_int;

    int media = soma / 3;

    Console.WriteLine("A media é: " + soma / 3);
  }
}