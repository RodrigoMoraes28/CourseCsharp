using System;
using System.Collections.Generic;
using System.Linq;
			
// Quantos minutos o formato wav equivale em formato mp3 por meio do tamanho do arquivo?
public class Program{
public static void Main(){   

	  double minuto;
    double mb_wav,mb_mp3;    
    
    Console.WriteLine("Digite o tempo da música em minutos");

    
    minuto = double.Parse(Console.ReadLine());
    
		mb_wav = 10*minuto; 
		mb_mp3 = 1.5*minuto;

    double temp_3;    
    temp_3 = (minuto * 10);   
		Console.WriteLine("WAV " + mb_wav + "MB ; MP3 " + mb_mp3  +  " MB ;"  + temp_3 +  " MB ; "  + (temp_3/1.5) +  " equivale a minutos em formato MP3");      
}
}