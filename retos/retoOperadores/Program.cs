using System;
using System.Diagnostics.CodeAnalysis;

namespace retoOperadores;

public static class Program
{
    public static void Main(string[] args)
    {
       int width = 7 ;
       int height = 5 ;

       int area = width * height ;

       int perimeter = ( 2 * width) + ( 2 * height) ;

       width += 3 ;
       height -= 2 ;

       area = width * height ;

       perimeter = ( 2 * width) + ( 2 * height) ;

       Console.WriteLine($"El ancho es -> {width}");
       Console.WriteLine($"La altura es -> {height}");
       Console.WriteLine($"El area es -> {area}");
       Console.WriteLine($"El perimetro es -> {perimeter}");

    }
}