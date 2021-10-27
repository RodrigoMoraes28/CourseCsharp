using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program{
  public static void Main(){
    // achando a area do circulo
      float r;
      double area;
  
      Console.WriteLine("Informe o raio:");
		  r = float.Parse(Console.ReadLine());
      area = (3.14 * r * r);
      Console.WriteLine($"{area}");   

  }
}