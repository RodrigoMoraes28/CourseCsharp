using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program{
  public static void Main(){
    
    //joken po com o pc, o usuario ira digitar um numero que corresponde a pedra, papel ou tesoura
    // e a maquina fará uma jogada também, será impresso quem venceu e qual foi sua jogada
    for( ;  ; ){
      
    int Player_1;
    Random rand = new Random();
    
    Console.WriteLine("Player_1 , informe sua escolha: 1 - pedra , 2- papel, 3 - tesoura");
    Player_1 = int.Parse(Console.ReadLine()); 
    int PC = rand.Next(1,4);
    
    if (Player_1 > 3 || Player_1 < 1) {
      Console.WriteLine("Invalido");
    }
    
    if(Player_1 == PC){
        Console.WriteLine("maquina = " +PC);
      	Console.WriteLine("Empate");
    }else if(Player_1 == 1 && PC == 3) {
      Console.WriteLine("maquina = " +PC);
      Console.WriteLine("O vencedor é o Player_1, porque pedra vence de tesoura");
    }else if(Player_1 == 2 && PC == 1) {
        Console.WriteLine("maquina = " +PC);
        Console.WriteLine("O vencedor é o Player_1, porque papel vence de pedra");
    }else if(Player_1 == 3 && PC == 2) {
      	Console.WriteLine("maquina = " +PC);
      	Console.WriteLine("O vencedor é o Player_1, porque tesoura vence de papel");    
    }else if(Player_1 == 3 && PC == 1) {
      	Console.WriteLine("maquina = " +PC);
      	Console.WriteLine("O vencedor é o PC, porque tesoura perde para pedra");    
    }else if(Player_1 == 1 && PC == 2) {
        Console.WriteLine("maquina = " +PC);
        Console.WriteLine("O vencedor é o PC, porque pedra perde para papel");
    }else if(Player_1 == 2 && PC == 3) {
      	Console.WriteLine("maquina = " +PC);
      	Console.WriteLine("O vencedor é o PC, porque papel perde para tesoura");        
    }
      
    //apos o jogo terminar será perguntado se o usuario quer jogar novamente
    //se sim, o progama iria reiniciar, senão ele termina
    Console.WriteLine("Você quer jogar novamente?");
    string resposta = Console.ReadLine();
    
    if (resposta == "s"){
    }
    else if (resposta == "n"){
      Console.WriteLine("Obrigado por jogar");
      break;
    }
    }
  }
}


