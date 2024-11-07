using System;
class Carro
{
    //propriedades do carro
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"carro: {Marca} {Modelo}");
    }
}

class Program
{
    public static void Main(string[] args)
    {

        Carro meuCarro = new Carro();
        meuCarro.Marca = "VW";
        meuCarro.Modelo = "Golf";

        //chamando o metodo do objeto 
        meuCarro.ExibirInfo();
    }
}