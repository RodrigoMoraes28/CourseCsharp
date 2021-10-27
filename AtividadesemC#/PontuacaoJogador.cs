using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program{
  public static void Main(){

    string nome;
    int pontuacao;
        
    Console.WriteLine();
    nome = Console.ReadLine();
    Console.WriteLine();
    pontuacao = int.Parse(Console.ReadLine());
        
    Console.WriteLine("Parabéns "+ nome + ", sua pontuação foi de " + pontuacao + " pontos");
  }
}