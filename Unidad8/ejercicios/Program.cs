using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
           int p1 =0, p2= 0, precio;
           Console.WriteLine("Precio del producto: ");
           p1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese la cantidad comprada: ");
           p2 = int.Parse(Console.ReadLine());

           precio = Producto(p1,p2);

           Console.WriteLine("El monto total a pagar es de: "+precio);
        }
        static int Producto(int n1, int n2)
        {
            int r =n1 * n2;
            return r;
        }
    }
}
