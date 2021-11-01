using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program{
  public static void Main(string[] args){
    
    int qtd_jogadores,total_Vencedores = 0;
    
    Console.WriteLine("Informe a quantidade de Jogadores");
    qtd_jogadores = int.Parse(Console.ReadLine());

    string[] nome = new string[qtd_jogadores];    
    int[] pontuacao_Jogador = new int[qtd_jogadores] ;

    //será lido a quantidade de jogadores junto com o nome de cada um e sua pontuação
    //os jogadores que fizerem uma pontuação de 100 para cima serão os vencedores
    //e será impresso seus a quantidade de vencedores e o nome de cada vencedor

    int i;    
    for (i = 0 ; i < qtd_jogadores ; i++){      
        Console.WriteLine($"Informe o nome do jogador {i}");  
			nome[i] = Console.ReadLine();			
          
        Console.WriteLine($"Quantos pontos fez o Jogador {i}");
       	pontuacao_Jogador[i] = int.Parse(Console.ReadLine()); 
        if (pontuacao_Jogador[i] >= 100){
            total_Vencedores = total_Vencedores+1;
      }
    }
   
   
    Console.WriteLine($"O total de Vencedores é {total_Vencedores}");
   
   int j;     
    for (j = 0 ; j < qtd_jogadores ; j++){
      	if (pontuacao_Jogador[j] >= 100){           
        Console.WriteLine($"O nome dos vencedores é de Vencedores é {nome[j]}");
        }    
    }
 
}
}
  
