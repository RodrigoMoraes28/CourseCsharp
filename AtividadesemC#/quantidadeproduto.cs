using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
  {
    
    int dinheiro,preco;
     
    // quanto do produto é possível comprar sabendo o preço dele e a quantidade de dinheiro que você tem
    
    Console.WriteLine("Informe o seu dinheiro:");
   	dinheiro = int.Parse(Console.ReadLine());
     
    Console.WriteLine("Informe o preço do produto:");

   	preco = int.Parse(Console.ReadLine());

       
    int quantidade;
    
    quantidade = (dinheiro / preco); // descobrindo a quantidade de produtos que é possível comprar com seu dinheiro

    
    if (quantidade > 0 ){
		Console.WriteLine($"É possível comprar o item {quantidade}");
    }
    else{
      Console.WriteLine("Não é possível comprar o item");
    } 
 
    

  }
}