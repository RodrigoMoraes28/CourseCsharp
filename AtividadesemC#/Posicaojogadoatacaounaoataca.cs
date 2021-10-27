using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program{
  public static void Main(){

    // descobrindo a posição X do jogador e a posição X do inimigo, se elas forem menores que 5 você
    // pode atacar, senão não pode atacar
    int ax,bx;    
    	
    Console.WriteLine("Informe a posição X do jogador:");
    ax = int.Parse(Console.ReadLine());
     
    Console.WriteLine("Informe a posição X do inimigo:");
    bx = int.Parse(Console.ReadLine());
    //descobrindo a posição X do jogador e a posição X do inimigo
      
    //se elas forem menores que 5 você pode atacar, senão não pode atacar
    if(((ax - bx <= 5) || (bx - ax <= 5)) || ((ax - bx <= -5) || (bx - ax <= -5))){
        Console.WriteLine("Ataca");
    }else{
    Console.WriteLine("Não Ataca");
}    
  }     
}
