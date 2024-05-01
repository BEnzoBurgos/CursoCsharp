using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es 
            //par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int numeros, cont=0, parImpar;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un numero");
                numeros = int.Parse(Console.ReadLine());

                parImpar = Par(numeros);
                if (parImpar == 1)
                {
                    cont++;
                }

            }

            Console.WriteLine("La cantidad de numeros pares es d: "+ cont);


        }
        static int Par(int n1)
        {
            if (n1%2 == 0)
            {
                return 1;
            }
            else{
                return 0;
            }
        }
    }
}
