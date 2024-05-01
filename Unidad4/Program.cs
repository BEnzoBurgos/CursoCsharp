using System;

namespace Unidad4
{
    class Program
    {
        static void Main(string[] args)
        {
            // && ALT + 38
            // if (edad>10 && edad>30)     
            // || alt + 124
            // if(edad>10 || edad>30)
            // int edad=20;
            // char inicial='J';
            // if (edad > 20 && inicial == 'H'){
            //     Console.WriteLine("21 OFF..");
            // }else{
            // //     Console.WriteLine("NO hay oferta !!");
            // //switch !!
            // char letra='A';

            // switch (letra){
            //     case 'M':
            //     Console.WriteLine("Tu nombre comienza con M");
            //     //lalala codigo
            //         break;
            //     case 'H':
            //     //asfdasdf
            //     //asdfasdfas
            //         break;
            //     case 'R':
            //         break;
            //      default:
            //         Console.WriteLine("No coincide con ninguna");
            //         break;

            //     break;
            //     default:
            // }
            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            // A) La resta si el primero es mayor que el segundo.
            // B) La suma si son iguales.
            // C) El producto si el primero es menor.
            // D) Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            // int n1, n2 , resta, suma, producto;
            // Console.WriteLine("Ingrese el primer numero: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el segundo numero: ");
            // n2 = int.Parse(Console.ReadLine());
            // if (n1>n2){
            //     resta= n1-n2;
            //     Console.WriteLine("EL primer numero es mayor, la resta es: " +resta);
            // }
            // if (n1 == n2){
            //     suma=n1+n2;
            //     Console.WriteLine("Los dos numeros son iguales, su suma es: " +suma);
            // }
            // if(n1<n2){
            //     producto=n1*n2;
            //     Console.WriteLine("EL primer numero es menor, el producto de estos es de : " +producto );
            // }
            // 2. Un importante negocio de desinfectante líquido realiza descuentos
            //  dependiendo de la cantidad de litros vendidos según la siguiente escala:

            //         Si vende menos de 100 litros, no hay descuento.
            //         Si vende entre 101 y 300 litros, el descuento es del 10%.
            //         Si vende entre 301 y 500 litros, el descuento es del 15%.
            //     Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //      Hacer un programa que solicite el ingreso del importe total de la venta y la
            //     cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
            // int CantLitros;
            // float importe;
            // Console.WriteLine("Ingrese el importe total: ");
            // importe = float.Parse(Console.ReadLine());

            // Console.WriteLine("Ingrese la cantidad de litros: ");
            // CantLitros = int.Parse(Console.ReadLine());
            
            // if (CantLitros>500)
            //     importe= importe*0.75F;
            // else if(CantLitros>300)
            //     importe= importe*0.85F;
            // else if(CantLitros>100)
            //     importe= importe*0.90F;     
            
            // Console.WriteLine("El importe total es de: " +importe);
            // 3. Una importante marca de computadoras permite elegir cierta configuración del
            //  equipo a comprar. Para ello existe la siguiente escala de precios:

            // i5 (1)	i7 (2)	i9 (3)
            // 8 RAM (1)	USD 800	USD 900	USD 1200
            // 16 RAM (2)	USD 900	USD 1000	USD 1400
            // 32 RAM (3)	USD 1000	USD 1400	USD 2000
            //     Además, el equipo viene con un disco que permite almacenar 500 GB de información 
            //     y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional 
            //     de USD 300. Hacer un programa que solicite la opción de procesador, la opción de 
            //     memoria  RAM, y si extiende el disco o no (ingresa 1 para extender 
            //     y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.
            // int procesador,memoria,disco;
            // float precio;
            // Console.WriteLine("Ingrese la opcion de procesador: ");
            // procesador = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la opcion de Memoria:");
            // memoria = int.Parse(Console.ReadLine());
            // Console.WriteLine("¿Amplia disco?");
            // disco = int.Parse(Console.ReadLine());

            // switch(procesador){
            //     case 1:
            //         switch(memoria)
            //         {
            //             case 1:
            //                 precio=800;
            //                 break;
            //             case 2:
            //                 precio=900;
            //                 break;
            //             default:
            //                 precio=1000;
            //                 break;
            //         }
            //         break;
                    
            //     case 2:
            //         switch(memoria)
            //         {
            //             case 1:
            //                 precio=900;
            //                 break;
            //             case 2:
            //                 precio=1000;
            //                 break;
            //             default:
            //                 precio=1400;
            //                 break;
            //         }
            //         break;
            //     default:
            //         switch(memoria)
            //         {
            //             case 1:
            //                 precio=1200;
            //                 break;
            //             case 2:
            //                 precio=1400;
            //                 break;
            //             default:
            //                 precio=2000;
            //                 break;
            //         }
            //         break;
                    

            // }
            // if (disco==1){
            //     precio=precio +300;
            // }  
            // Console.WriteLine("El precio final de la compu es de: " + precio);
            // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si 
            // la suma de los dos primeros es mayor al producto del segundo con el tercero.
            // int n1,n2,n3;
            // Console.WriteLine("Ingrese el primer numero: ");
            // n1 =int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el segundo numero: ");
            // n2 =int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el tercer numero: ");
            // n3 =int.Parse(Console.ReadLine());
            // if((n1+n2)>(n2*n3))
            // Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");
            // else
            // Console.WriteLine("La suma de los dos primerros es menor al producto del segundo con el tercero");
            // Console.WriteLine("Fin del Programa!");

            // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos 
            // se encuentran ordenados de forma decreciente .
            int n1,n2,n3,n4;
            Console.WriteLine("Ingrese el primer numero: ");
            n1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            n2 =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            n3 =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero: ");
            n4 =int.Parse(Console.ReadLine());
            if(n1<n2 && n1<n3 && n1<n4){
                Console.WriteLine("Se encuentran ordenados de forma decreciente");
            }else{
                Console.WriteLine("No estan ordenados de forma decreciente!");
            }
            //UNIDAD 4 TERMINADA :D

        }
    }
}
