using System.Runtime.InteropServices;
using System.Transactions;

namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaración
            int[] numeros;
            int cont;
            int suma = 0;
            double prom = 0;
            int mayor = 0;
            int menor = 0;
            int indmenor = 0;
            int indmayor = 0;
            #endregion
            #region Definición del vector
            numeros = new int[100];
            #endregion
            #region Inicialización
            Console.WriteLine("Ingrese valor: ");
            int valor = int.Parse(Console.ReadLine());
            cont = 0;
            while (valor != -1)
            {
                numeros[cont] = valor;
                cont++;
                Console.WriteLine("Ingrese valor: ");
                valor = Convert.ToInt32(Console.ReadLine());
            }
            #endregion
            #region IMPRIMIR VALORES
            for(int i = 0; i < cont; i++)
            {
                Console.WriteLine($"{i}:{numeros[i], 3} ");
                suma += numeros[i];
                if (mayor == 0 && menor == 0)
                {
                    mayor = numeros[i];
                    menor = numeros[i];
                    indmayor = i;
                    indmenor = i;
                }
                else
                {
                    if (numeros[i] > mayor)
                    {
                        mayor = numeros[i];
                        indmayor = i;
                    }
                    else if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                        indmenor = i;
                    }
                }
            }
                Console.WriteLine($"El número mayor es {mayor} en el índice {indmayor}\nEl número menor es {menor} en el índice {indmenor}");
            #endregion
            #region promedio
            prom =1.0*(suma / (double)cont);
            Console.WriteLine($"Promedio:\n -----------------\n{prom}");
            #endregion
        }
    }
}
