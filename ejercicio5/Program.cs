using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        // ejercicio 5. Hacer un programa para ingresar por teclado las tres notas de exámenes 
        // de un alumno y luego calcule 
        // y emita por pantalla el promedioDeNotas final.
        float nota1, nota2, nota3, promedioDeNotas;
        Console.WriteLine("Ingrese la primer nota: ");
        nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la tercer nota: ");
        nota3 = float.Parse(Console.ReadLine());
        promedioDeNotas = (nota1+nota2+nota3)/3;
        Console.WriteLine("El promedioDeNotas de notas del alumno es de: " + promedioDeNotas.ToString("0.00"));
        }
    }
}
