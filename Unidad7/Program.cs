using System;

namespace Unidad7
{
    class Program
    {
        static  void Main(string[] args)
        { 
            // vecotres- array - arreglo // array list NO
            // int [] numeros = new int [10];
            // bool [] asistenciaQuincena1 = new bool[15];
            // char[] nombre= new char[11];

            // char letra;
            // int indice=0;
            // Console.WriteLine("Ingrese su nombre letra por letra. . . (termina en un punto");
            // letra = char.Parse(Console.ReadLine());
            // while(letra != '.' && indice<10)
            // {
            //     nombre[indice] = letra;
            //     letra = char.Parse(Console.ReadLine());
            //     indice++;
            // }
            // nombre[indice] = '\0';
            // Console.Write("Hola ");
            // indice = 0;
            // while(nombre[indice] != '\0')
            // {
            //     Console.Write(nombre[indice]);
            //     indice++;
            // }
            // string nombre;
            // Console.WriteLine("Ingrese su nombre. . .");
            // nombre = Console.ReadLine();
            // Console.WriteLine("¿Como estas? " + nombre);


            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer 
            // los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            // int n, maximo=0, posicion=1;
            // int [] numeros = new int[10];

            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     n = int.Parse(Console.ReadLine());
            //     numeros[x] = n;
            // }

            // maximo = numeros[0];

            // for (int x = 0; x < 10; x++)
            // {
            //     if(numeros[x]>maximo)
            //     {
            //         maximo= numeros[x];
            //         posicion = x+1;
            //     }
            // }
            // Console.WriteLine("El valor maximo es "+maximo+ " y esta en la posicion "+ posicion);


            // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector 
            // para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            // int[] numeros = new int[10];
            // int n,suma=0,promedio=0;
            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     n = int.Parse(Console.ReadLine());
            //     numeros[x] = n;
            //     suma+= n;
            // }
            // promedio = suma/10;
            // Console.WriteLine("El promedio es: "+promedio);
            // for (int x = 0; x < 10; x++)
            // {
            //     if(promedio<numeros[x])
            //         {
            //             Console.WriteLine(" "+ numeros[x]  + " | Es mayor a el promedio.");
            //         }
            // }

            
            // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos 
            // (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del
            //  primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. 
            //     Ejemplo:
            //         CADENA FUENTE: “La mar estaba serena"
            //         CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //         CADENA RESULTADO: “Li mir estibi sereni"

                // char LetraActual, LetraNueva;
                // char[] frase = new char[30];
                // int indice=0;
                // char letra;
                // Console.WriteLine("Ingrese una letra..");
                // letra = char.Parse(Console.ReadLine());
                // while (letra != '0' && indice < 30)
                // {
                //     frase [indice] = letra;
                //     Console.WriteLine("Ingrese otra letra..");
                //     letra = char.Parse(Console.ReadLine());
                //     indice++;
                // }
                // frase[indice] = '\0';
                // Console.WriteLine("La frase completa es. . .");
                // indice = 0;
                // while (frase[indice] != '\0')
                // {
                //     Console.Write(frase[indice]);
                //     indice++;
                // }
                // Console.WriteLine("Ingrese letra a remplazar: ");
                // LetraActual = char.Parse(Console.ReadLine());
                // Console.WriteLine("Ingrese letra nueva: ");
                // LetraNueva = char.Parse(Console.ReadLine());
                
                // indice =0;
                // while (frase[indice] != '\0')
                // {
                //     if (frase[indice] == LetraActual)
                //     {
                //         frase[indice] = LetraNueva;
                //     }
                //     indice++;
                // }
                
                // Console.WriteLine("La frase nueva es . . .");
                // indice= 0;
                // while (frase[indice] != '\0')
                // {
                //     Console.Write(frase[indice]);
                //     indice++;
                // }


                // string frase;
                // char LetraActual, LetraNueva;
                // Console.WriteLine("Ingrese Frase...");
                // frase = Console.ReadLine();
                // Console.WriteLine("Infrese la letra a remplazar: ");
                // LetraActual = char.Parse(Console.ReadLine());
                // Console.WriteLine("Ingrese la letra nueva: ");
                // LetraNueva = char.Parse(Console.ReadLine());
                // frase = frase.Replace(LetraActual, LetraNueva);

                // Console.WriteLine("La frase nueva es: ");
                // Console.WriteLine(frase);



                // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con 
                    //   los siguientes datos:
                    //     - Número de Artículo (1 a 15)
                    //     - Cantidad Vendida 

                    //     Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
                    //     Se pide determinar e informar:
                    //     a) El número de artículo que más se vendió en total.
                    //     b) Los números de artículos que no registraron ventas.
                    //     c) Cuantas unidades se vendieron del número de artículo 10.
                

        
                int nroArticulo,cantidad,maximo, numeroMax;
                int[] totalCantidadVendida = new int[15];

                for (int x = 0; x < 15; x++)
                {
                    totalCantidadVendida[x] = 0;
                }
                
                        Console.WriteLine("Ingrese el Numero de articulo (1 a 15): ");
                        nroArticulo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese La cantidad vendida: ");
                        cantidad = int.Parse(Console.ReadLine());
                    
                    while (nroArticulo != 0)
                    {
                        totalCantidadVendida[nroArticulo - 1] +=cantidad;


                        Console.WriteLine("Ingrese el Numero de articulo (1 a 15): ");
                        nroArticulo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese La cantidad vendida: ");
                        cantidad = int.Parse(Console.ReadLine());
                    }

                    maximo = totalCantidadVendida[0];
                    numeroMax= 1;
                    for (int x = 1; x < 15; x++)
                    {
                        if (maximo < totalCantidadVendida[x])
                        {
                            maximo = totalCantidadVendida[x];
                            numeroMax = x+1;
                        }
                    }
                    Console.WriteLine("El nro de producto que mas se vendio en total es el: "+numeroMax);

                    for (int x = 0; x < 15; x++)
                    {
                        if (totalCantidadVendida[x] == 0)
                        {
                            Console.WriteLine("No se regristro venta en el producto nro: "+ (x+1) );

                        }
                    }
                    Console.WriteLine("Del producto 10 se vendieron en total "+totalCantidadVendida[9]+" articulos");
        }
    }
}
