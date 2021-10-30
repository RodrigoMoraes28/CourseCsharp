using System;
using System.Collections.Generic;
using System.Linq;			
public class Program{
  public static void Main(string[] args){
    
    //lendo os pontos superiores e inferiores (x,y)
    int ponto_x,ponto_y,superior_x,superior_y,inferior_x,inferior_y;
   
    
	Console.WriteLine("Informe o ponto superior esquerdo");
    
    superior_x = int.Parse(Console.ReadLine()); 
	superior_y = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Informe o ponto inferior direito");

    inferior_x = int.Parse(Console.ReadLine());
    inferior_y = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Informe o ponto a ser testado");
    
    ponto_x = int.Parse(Console.ReadLine());
    ponto_y = int.Parse(Console.ReadLine());
    
    //testando se o ponto está dentro do retângulo
    if ((ponto_x >= superior_x && ponto_x <= inferior_x) && (ponto_y <= superior_y && ponto_y >= inferior_y)){  
      		Console.WriteLine("O ponto está dentro do retângulo"); 
    }else{
        	Console.WriteLine("O ponto está fora do retângulo");
    }
       
     
}
}

