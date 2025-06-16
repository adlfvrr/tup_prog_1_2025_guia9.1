namespace ej4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] miArreglo = new int[100];
            int contador = 0;
            Console.Write("Ingrese un número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int acumulador = 0;
            while (n != -1)
            {
                miArreglo[contador] = n;
                contador++;
                Console.Write("Ingrese un número: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Se ingresaron {contador} números.");
            for (int i = 0; i < contador; i++)
            {
                acumulador += miArreglo[i];
            }   
            double prom = 1.0 * (acumulador / (double)contador);
            Console.WriteLine($"El promedio de los números ingresados es: {prom:f2}");
            int[] miNuevoArreglo = new int[contador];
            int contadorMiNuevoArreglo = 0;
            for (int i = 0; i < contador; i++)
            {
                if (miArreglo[i] > prom)
                {
                    miNuevoArreglo[contadorMiNuevoArreglo] = miArreglo[i];
                    contadorMiNuevoArreglo++;
                }
            }
            Console.Write($"Ingrese cuantos números del listado de valores superiores al promedio desea ver (disponibles - {contadorMiNuevoArreglo}): ");
            int rango = Convert.ToInt32(Console.ReadLine());
            if (rango <= contadorMiNuevoArreglo)
            {
                for (int i = 0; i < rango; i++)
                {
                    Console.Write($"{i}:{miNuevoArreglo[i]}, ");
                }
            }
            else
            {
                Console.WriteLine($"El rango está fuera de los límites del arreglo.");
            }
        }

    }
}
