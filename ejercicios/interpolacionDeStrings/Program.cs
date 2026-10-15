using System;

namespace interpolacionDeStrings;

public static class Program
{
    public static void Main(string[] args)
    {
        string edadTexto = "18" ;
        string estaturaTexto = "1.83" ;

        int edadNumero = int.Parse(edadTexto) ;
        double estaturaNumero = double.Parse(estaturaTexto) ;

        int edadEnMeses = edadNumero * 12 ;
        double estaturaEnCentimetros = estaturaNumero * 100 ;

        Console.WriteLine($"El usuario tiene {edadNumero} años ({edadEnMeses} meses) y mide {estaturaEnCentimetros} centimetros.") ;
    
    }
}