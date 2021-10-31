using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program{
  public static void Main(){
    
    string escolha;
    
    Console.WriteLine("Informe a classe do jogador");   
    escolha = Console.ReadLine();
    
    String[] Classe = new String[4];
    //será apresentado 3 classes aojogador e será impreso a que ele escolheu,
    //se ele digitar um número que não corresponde a nenhuma classe terá que digitar novamente
    //até que digite um número válido
    Classe[0] = "Mago";
    Classe[1] = "Arqueiro";
    Classe[2] = "Guerreiro";
            
    
    for(int i = 0; i<=3 ; i++){      
        if (escolha == Classe[i]){
        	Console.WriteLine("A classe escolhida foi " + Classe[i]);
        break;
        }
        while (escolha != Classe [i]){
        Console.WriteLine("Digite o nome de sua classe corretamente");
        escolha = Console.ReadLine();
        }
          	if(escolha == Classe[i]){
          	Console.WriteLine("A classe escolhida foi " + Classe[i]);
            break;
       }
    }    
}    
}

