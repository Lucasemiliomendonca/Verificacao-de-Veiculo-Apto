using System;

class CarroMonitoramento
{
     
    public static string Verifique (string modelo, int anoFabricacao, int anoAtual)
    {
      int idade = anoAtual - anoFabricacao;
      
      if(idade <= 10)
      {
        return $"{modelo}: Apto";
      }
      else
      {
        return $"{modelo}: Nao apto";
      }
    }

    static void Main()
    {
        
        string modelo = Console.ReadLine()!;
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        int anoAtual = int.Parse(Console.ReadLine()!);

        
        string resultado = CarroMonitoramento.Verifique(modelo, anoFabricacao, anoAtual);

        
        Console.WriteLine(resultado);
    }
}