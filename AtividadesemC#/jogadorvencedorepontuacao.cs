using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program{
   public static void Main(string[] args)  {
     
    int qnt_jogadores;   
    int pontuacao = 0;    
    int maior = 0; 
    string nome;
    string ganhador = " ";
   
     
    Console.WriteLine("Escreva a quantidade de jogadores"); 
  
    qnt_jogadores = int.Parse(Console.ReadLine());
   // será lido uma quantidade de jogadores, o jogador que tiver a maior pontuação será o vencedor
   // e sera impresso sua pontuação junto com seu nome
    for(int i = 1 ; i <= qnt_jogadores; i++){
      	Console.WriteLine("Digite o nome do jogador " + i); 
        nome = Console.ReadLine();
        Console.WriteLine("Digite a pontuação do jogador " + i); 
        pontuacao = int.Parse(Console.ReadLine());   				
       
      	if(pontuacao > maior){
        ganhador = Console.ReadLine();
        nome = ganhador;
        maior = pontuacao;
    }     
    }     
      Console.WriteLine ("A maior pontuacao é do jogador "+ ganhador +  ",que fez " + pontuacao + "pontos");
   }
}


