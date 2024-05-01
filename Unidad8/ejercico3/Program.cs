﻿using System;

namespace ejercico3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1
            //  si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.
            //   Informar el promedio teniendo en cuenta sólo los números primos.

            int n, conPrimos=0, acuPrimos=0, promedio ;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if(Primo(n)){

                    conPrimos++;
                    acuPrimos+=n;

                }
                
                Console.WriteLine("Ingrese otro numero o 0 para finalizar carga: ");
                n = int.Parse(Console.ReadLine());
            }
            promedio= acuPrimos/conPrimos;

            Console.WriteLine("EL PROMEDIO DE NUMEROS PRIMOS ES DE: "+promedio);


        }
        static bool Primo (int a)
        {
            int con = 0;
            for (int x = 1; x <= a; x++)
            {
                if (a % x == 0)
                {
                    con++;
                }      
            }
            if(con == 2)
                return true;
            else
                return false;
        }
    }
}
