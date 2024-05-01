using System;

namespace Unidad6
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLOSCOMBINADOS
            // ES ANIDAR CILOS, UN CICLO DENTRO DE OTRO
            // FOR con FOR
            // int prom, acu=0, n;

            // for (int y = 0; y < 10; y++)
            // {
            //     acu = 0;
            //     for (int x = 0; x < 20; x++)
            //     {
            //     Console.WriteLine("Ingrese la Edad: ");
            //     n=int.Parse(Console.ReadLine());
            //     acu +=n;
            //     }
            //     prom =acu/20;
            //     Console.WriteLine("El promedio es: " +prom);
            // }

            // FOR CON WHILE

            // for (int x = 0; x < 10; x++)
            // {
            //     int prom, acu=0, n, contPersonas=0;
            //     Console.WriteLine("Ingrese Edad: ");
            //     n = int.Parse(Console.ReadLine());
            //     while(n != 0)   
            //     {
            //         acu += n;
            //         contPersonas++;
            //         Console.WriteLine("Ingrese Edad: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     promedio = acu/contPersonas;
            //     Console.WriteLine("El promedio de edad de este equipo es de: "+ promedio);
            // }

            // WHILE CON FOR
            // int prom, acu=0, n, contPersonas=0;
            // Console.WriteLine("Ingrese un 1 para empezara procesar o 0 para terminar: ");
            // n = int.Parse(Console.ReadLine());
            // while(n =! 0)
            // {
            //     acu = 0;
            //     for (int x = 0; x < 20; x++)
            //     {
            //         Console.WriteLine("Ingrese la Edad: ");
            //         n=int.Parse(Console.ReadLine());
            //         acu +=n;
            //     }
            //     prom =acu/20;
            //     Console.WriteLine("El promedio es: " +prom);
            //     Console.WriteLine("Ingrese un 1 para continuar o 0 para terminar: ");
            //      n = int.Parse(Console.ReadLine());
            // }


                // WHILE CON WHILE !!
             
            //     int prom, acu=0, n, contPersonas=0;
            // while()
            //     {
            //     Console.WriteLine("Ingrese Edad: ");
            //     n = int.Parse(Console.ReadLine());
            //     while(n>0)   
            //     {
            //         acu += n;
            //         contPersonas++;
            //         Console.WriteLine("Ingrese Edad: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     promedio = acu/contPersonas;
            //     Console.WriteLine("El promedio de edad de este equipo es de: "+ promedio);

            //     Console.WriteLine("Ingrese Edad o un negativo para terminar el programa: ");
            //         n = int.Parse(Console.ReadLine());
          
            //}


            // CORTE DE CONTROL
                // int legajo, edad, codigoEquipo;
                // float sueldo;
                // int equipoActual;
                // Console.WriteLine("Ingrese el legajo: ");
                // legajo = int.Parse(Console.WriteLine());
                // Console.WriteLine("Ingrese la edad: ");
                // edad = int.Parse(Console.WriteLine());
                // Console.WriteLine("Ingrese el sueldo: ");
                // sueldo = float.Parse(Console.WriteLine());
                // Console.WriteLine("Ingrese el codigo de Eqipo: ");
                // codigoEquipo = int.Parse(Console.WriteLine());

                // while (sueldo > 0)

                // {       
                //     codigoEquipo = equipoActual
                //     while (codigoEquipo == equipoActual)
                //     {
                //         Console.WriteLine("Ingrese el legajo: ");
                //         legajo = int.Parse(Console.WriteLine());
                //         Console.WriteLine("Ingrese la edad: ");
                //         edad = int.Parse(Console.WriteLine());
                //         Console.WriteLine("Ingrese el sueldo: ");
                //         sueldo = float.Parse(Console.WriteLine());
                //         Console.WriteLine("Ingrese el codigo de Eqipo: ");
                //         codigoEquipo = int.Parse(Console.WriteLine());
                        
                //     }
                // }
                

                //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y 
                //    mostrar por pantalla cuántos de esos números son primos.

                // int n, contador,contPrimos=0;
            
                 
                //  for (int x = 0; x < 5; x++)
                //  {
                //     Console.WriteLine("Ingrese un numero: ");
                //     n = int.Parse(Console.ReadLine());
                //     contador = 0;
                //     for (int y = 1; y <= n; y++)
                //     {   
                //         if(n % y == 0)
                //         {
                //             contador++;
                //         }
                //     }
                //     if(contador == 2){
                //             contPrimos++;
                //         }
                //  }
                //  Console.WriteLine("Hay un total de "+contPrimos+" numeros primos" );


                //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
                //Se pide determinar e informar:

                 //        - El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
                //       - Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

                // int n, conNumeros=0, conImpares=0, grupodeImparesMaximo=0, min, contGruposOrdenados=0;
                // double porcetajeImpares, porcentajeMaximo=-1;
                // bool banderaOrdenados;
                // for (int x = 0; x < 5; x++)
                
                // {
                //     conNumeros=0;
                //     n = int.Parse(Console.ReadLine());
                //     banderaOrdenados = true;
                //     min = n;
                //     while (n != 0)
                //     {
                //             n = int.Parse(Console.ReadLine());
                //             conNumeros++;
                //              if(n%2 != 0)
                //                  {
                //                      conImpares++;
                //                  }
                //             // punto B
                //             if (n<=min){
                //                 min=n;
                //             }else{
                //                 banderaOrdenados= false;
                //             }
                            
                //         n = int.Parse(Console.ReadLine());
                //     }
                //     porcetajeImpares= conNumeros * 100 /conImpares;
                //     if (porcetajeImpares>porcentajeMaximo){
                //         porcentajeMaximo= porcetajeImpares;
                //         grupodeImparesMaximo= x+1;
                //     }
                //     if(banderaOrdenados){
                //         contGruposOrdenados++;
                //     }
                // }

                // Console.WriteLine("El grupo con mayor porcentaje de impares es el numero "+ grupodeImparesMaximo);
                // Console.WriteLine("La cantidad de grupos con numeros ordenados es: "+ contGruposOrdenados);



                //  3 . Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
                //  El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
                int n,con, grupo=0;


                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                while (n >= 0)
                {
                    grupo++;
                    con=0;
                    while(n>0)
                    {
                        con++;


                        Console.WriteLine("Ingrese otro numero: ");
                        n = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("La cantidad de numeros que hay en el grupo "+ grupo+ " es de: "+con);
                }


        }
    }
}
