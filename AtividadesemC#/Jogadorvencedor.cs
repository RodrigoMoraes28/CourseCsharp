using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program{
  public static void Main(string[] args){
    
    //com base na quantidade de jogadores e a pontuação de cada um, caso algum faça 100 pontos ou mais será o vencedor
    //e será impresso a quantidade de vencedores
    int qtd_jogadores, pontuacao_Jogador, total_Vencedores = 0;
   

	Console.WriteLine("Informe a quantidade de Jogadores");    
    qtd_jogadores = int.Parse(Console.ReadLine()); 
    
    int i;
    for (i = 0 ; i <= qtd_jogadores ; i++){
      Console.WriteLine($"Quantos pontos fez o Jogador {i}");
       	pontuacao_Jogador = int.Parse(Console.ReadLine()); 
        if (pontuacao_Jogador >= 100){
            total_Vencedores = total_Vencedores+1;
        }      
      Console.WriteLine($"O total de Vencedores é {total_Vencedores}");      
    }   
}
}

