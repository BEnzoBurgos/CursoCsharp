using System;

namespace Unidad5
{
    class Program
    {
        static void Main(string[] args)
        {

            // CICLO FOR(cICLO EXACTO)

            // for(int x=0; x<5; x++){
                
            //     Console.WriteLine("Hola Mundo"+x);
                
            // }
        //     int n=0;
        //   for (int x = 0; x < 10; x++)
        //   {
        //     Console.WriteLine("Ingrese un NUmero: ");
        //     n=int.Parse(Console.ReadLine());
        //   }
        //   Console.WriteLine("el numero es: "+n);
        //             int n,cont=0;
        //             Console.WriteLine("Ingrese un numero:");
        //              n=int.Parse(Console.ReadLine());
        //              while(n!=0){
        //                 cont++;
        //                 Console.WriteLine("Ingrese un numero:");
        //                 n=int.Parse(Console.ReadLine());

        // }
        // Console.WriteLine("Ingresaste "+cont+" numeros");
                    // int n,con=0;
                    // do
                    // {   
                    //     Console.WriteLine("Ingrese un Nro");
                    //     n= int.Parse(Console.ReadLine());
                    //     con++;
            
                    //  } while (n != 0);
                    
                    //  Console.WriteLine("Ingresaste "+con + " numeros");
                    // 1. Hacer un programa para mostrar los números del 1 al 10. 
                    // No se debe realizar ningún pedido de datos.
                    // for (int x = 1; x <= 10; x++)
                    // {
                    //     Console.Write(" | "+x);
                    // }
                    // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre
                    //  el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
                    // int n,mayor=0;
                    // for (int x = 0; x < 10; x++){
                    //     Console.WriteLine("Ingrese un numero: ");
                    //     n=int.Parse(Console.ReadLine());
                    //     if (n>mayor){
                    //         mayor=n;
                    //     }
                    // }
                    // Console.WriteLine("El mayor de los numeros es: " +mayor);
                    // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad 
                    // de aquellas personas mayores a 18 años.
                    // int edad,promedioEdad,SumaEdad=0,may=0;
                    // for (int x = 0; x < 5; x++)
                    // {
                    //     Console.WriteLine("Ingrese una Edad: ");
                    //     edad=int.Parse(Console.ReadLine());
                    //     if(edad>18){
                    //         SumaEdad=SumaEdad+edad;
                    //         may++;
                    //     }
                    // }
                    // promedioEdad=SumaEdad/may;
                    // Console.WriteLine("El promedio de edad de aquellas personas mayores a 18 es de: " +promedioEdad);

                //     4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo
                //     // es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
                //    int n,cont=0;
                //    Console.WriteLine("Ingrese un numero: ");
                //    n=int.Parse(Console.ReadLine());
                //    for (int x = 1; x <= n; x++)
                //    {
                //     if(n%x == 0)
                //     {
                //         cont++;
                //     }
                //    }
                //    if(cont==0)
                //    {
                //     Console.WriteLine("EL numero ingresado es primo!");
                //    }else{
                //     Console.WriteLine("EL numero ingresado no es primo!");
                //    }

                    // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares 
                    // y el mínimo de los números impares.
                    int n,maxP=0,minI=0,band=0;
                    for (int x = 0; x < 5; x++)
                    {
                        Console.WriteLine("Ingrese un numero: ");
                        n=int.Parse(Console.ReadLine());
                        if(n%2==0){
                            if(n>maxP){
                                maxP=n;
                            }
                        }else{
                            if(band==0){
                                minI=n;
                                band=1;
                            }else{
                                if(n<minI){
                                    minI=n;
                                }
                            }
                        }
                    }
                 Console.WriteLine("El maximo de los numeros pares es " + maxP +" y el minimo de los numeros impares es " + minI + "");
        }

    }
}

