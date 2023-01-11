
using System; 

class E1019 {

    public static void executar(string[] args) { 
        int.TryParse(Console.ReadLine(), out int segundos);
        int minutos, horas;

        horas = segundos / (60 * 60);
        segundos -= horas * 60 * 60;

        minutos = segundos / 60;
        segundos -= minutos * 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);        
    }
}