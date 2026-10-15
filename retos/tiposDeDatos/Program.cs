using System;
using System.Diagnostics.CodeAnalysis;

namespace tiposDeDatos;

public static class Program
{
    public static void Main(string[] args)
    {
        int age = 25 ;
        double height = 1.75 ; 
        bool isStudent = true ;
        string name = "Ana" ;
        char grade = 'A' ;

        Console.WriteLine($"La edad es de -> {age}") ;
        Console.WriteLine($"La estatura es de -> {height}") ;
        Console.WriteLine($"El es un estudiante? -> {isStudent}") ;
        Console.WriteLine($"Su nombre es -> {name}") ;
        Console.WriteLine($"El grado donde estudia es -> {grade}") ;
    }
}