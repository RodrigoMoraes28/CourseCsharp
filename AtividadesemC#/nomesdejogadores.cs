using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main(string[] args)
  {
    
    //será lido o nome de até 10 jogadores, se o jogador tiver o mesmo nome que outro terá
    // que digitar o nome novamente, não poderão haver nomes repetidos
    
    for( ;  ; ){
    
    int qnt_jogadores;
       
    Console.WriteLine("Informe a quantidade de jogadores");
    qnt_jogadores = int.Parse(Console.ReadLine());
    string[] nome = new string [qnt_jogadores];
    
    int i;    
    if(qnt_jogadores <= 10){
    for(i = 0 ; i < qnt_jogadores ; i++){
      
        Console.WriteLine($"Informe o nome do jogador {i}");
   	    nome[i] = (Console.ReadLine()); 

            int j;      
			for(j = 0 ; j < i ; j++){	        
      		if(nome[i] == nome[j]) {
   			    Console.WriteLine("Nome repetido, não pode ser incluido novamente");
  	 			j = 0;   	  		   
	    }
     }
    }    		
  }		
     
    if(qnt_jogadores > 10){
        Console.WriteLine("Você não pode exceder o número de 10 jogadores");
    }    
 
    Console.WriteLine("Você quer jogar novamente?");
    string resposta;
    resposta = Console.ReadLine();
    
   	if(resposta == "s"){
    }
   	else if (resposta == "n"){
    Console.WriteLine("Obrigado por jogar");
    break;
    }
      
   }      
  }    
}   

