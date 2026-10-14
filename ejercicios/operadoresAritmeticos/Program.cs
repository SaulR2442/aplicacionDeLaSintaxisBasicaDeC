using System;

namespace operadoresAritmerticos;

public static class Program
{
    public static void Main(string[] args)
    {
        double precioProducto = 150.0 ;
        int cantidad = 3 ; 

        double subtotal = precioProducto * cantidad ;

        subtotal -= 20 ; //Descuento

        double iva = subtotal * 0.19 ;

        double precioFinal = subtotal + iva ;

       Console.WriteLine($"Con descuento -> {subtotal}") ;
       Console.WriteLine($"IVA -> {iva}") ;
       Console.WriteLine($"Precio Final -> {precioFinal}") ;
    
    }
}