using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalFacturado, comision, sueldoFinal;
            float sueldoFijo = 15000;
            float porcentajeComision = 0.05F;

            Console.WriteLine("Ingrese el total facturado por el empleado");
            totalFacturado = float.Parse(Console.ReadLine());
            comision = totalFacturado * porcentajeComision;
            sueldoFinal = comision + sueldoFijo;
            Console.WriteLine("El total de dinero a pagar al empleado es de:" + sueldoFinal);
        }
    }
}
