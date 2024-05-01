using System;

namespace Unidad8
{
    class Program
    {
        static void Main(string[] args)
        {
            // parte de una funcion

            // CABECERA
            // 1. tipo de dato
            // 2. tiene que tener un nombre
            // 3. Tiene que tener parametros >(opcional)

            // CUERPO
            // definicion/logica
            // retornar valor/ resultado >(Opcional)
            // int n = DevolverUno();
            // Console.WriteLine("Fin del programa: "+ DevolverUno());

            int n1 = 0, n2 = 0, resultado;

                pedirDatos(ref n1, ref n2);

                resultado = sumar(n1 , n2);

                Console.WriteLine("El resutlado es: "+ resultado);
                Console.WriteLine("El segundo valor es de : "+n2);
        }

         static int sumar(int a, int b){
            int r;
            r = a +b;
            a = 100;
            return r;
         }
         static void pedirDatos(ref int j, ref int h)
         {
                Console.WriteLine("Ingrese un numero: ");
                j = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero: ");
                h = int.Parse(Console.ReadLine());
                

         }

        // static int DevolverUno(){
        //     int nro =200;
        //     return nro;
        // }
    }
}
