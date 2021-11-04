using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program{
  public static void Main(){
    
    // sera mostrado um menu com 2 armas "faca e pistola laser", e terá 3 opções que o usuário poderá
    // fazer, solicitar uma nova arma, escolher uma arma, ou fechar o progama
    List<string> listaArmas = new List<string> {"Faca" , "Pistola Laser"};
    
    
    string resposta;
    string nova_arma;
    int j;
    int i;
         
    do{
     
    Console.WriteLine("MENU - O que você deseja fazer?");
    Console.WriteLine("A - Solicitar um novo nome de arma");
    Console.WriteLine("E - Qual arma da lista você quer escolher? Escreva pelo número");
    Console.WriteLine("S - Para fechar o progama"); 

    resposta = Console.ReadLine();

    switch (resposta){    
     

    case "A":   
    Console.WriteLine("Digite o nome da nova arma");
    nova_arma = Console.ReadLine();
    listaArmas.Add(nova_arma);
    Console.WriteLine($"Arma {nova_arma} incluída");

    for (j = 0 ; j <listaArmas.Count ; j++){       
        Console.WriteLine(listaArmas[j]);
    }
    break;  		      
      
    case "E":     
    for (j = 0 ; j < listaArmas.Count ; j++) {
    Console.WriteLine($"A lista atual possui {listaArmas.Count} armas");  
    Console.WriteLine($"Numero da arma : {j}"); 
    Console.WriteLine($"Nome da arma : {listaArmas[j]}");
    }
      
    Console.WriteLine("Escolha uma arma");     
   	i = int.Parse(Console.ReadLine());
    Console.WriteLine($"Usando {listaArmas[i]}");     
    break;  
    }
    }

    while (resposta != "S");
    Console.WriteLine("Encerrando o progama");
        
  }
}