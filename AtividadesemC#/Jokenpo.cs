using System;
using System.Collections.Generic;
using System.Linq;			
public class Program{
  public static void Main(string[] args){
    
    // código para jokenpo
    int Player_1;
    Console.WriteLine("Player_1 , informe sua escolha: 1 - pedra , 2- papel, 3 - tesoura");
    Player_1 = int.Parse(Console.ReadLine()); 

    int Player_2;
    Console.WriteLine("Player_2 , informe sua escolha: 1 - pedra , 2- papel, 3 - tesoura");
    Player_2 = int.Parse(Console.ReadLine()); 
    
    if (Player_1 == Player_2){
      Console.WriteLine("Empate");    
    }
		
    else{
      if(((Player_1 == 2 && Player_2 == 1) || (Player_1 == 3 && Player_2 == 2)) || (Player_1 == 1 && Player_2 == 3)){
       	Console.WriteLine("O Vencedor é o Player_1");
    } else{
        Console.WriteLine("O Vencedor é o Player_2");
    }      
    }    
    }   
}
