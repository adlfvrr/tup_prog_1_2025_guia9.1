using System.Diagnostics;

namespace ej3._1
{
    internal class Program
    {
        static int BusquedaSecuencial(int[] arreglo, int valor)
        {
            int indice = -1;
            int cont = 0;
            while (indice == -1 && cont != arreglo.Length)
            {
                if (arreglo[cont] == valor)
                {
                    indice = cont;
                }
                else
                {
                    cont++;
                }
            }
            return indice;
        }
        static int BusquedaBinaria(int[] arreglo, int valor, int finVector)
        {
            int indice = -1;
            int inicio = 0;
            int fin = finVector - 1;
            int pivot;
            while (indice < 0 && inicio <= fin)             
            {
                pivot = (inicio + fin) / 2;
                if (arreglo[pivot] == valor)
                {
                    indice = pivot;
                }
                else
                {
                    if (arreglo[pivot] < valor)
                    {
                        inicio = pivot + 1;
                    }
                    else
                    {
                        fin = pivot - 1;
                    }
                }
            }
            return indice;
        }
        static void Intercambio(int[] arreglo, int indicePrimero, int indiceSegundo)
        {
            int aux = arreglo[indicePrimero];
            arreglo[indicePrimero] = arreglo[indiceSegundo];
            arreglo[indiceSegundo] = aux;
        }
        static int Partición(int[] arreglo, int indMenor, int indMayor)
        {
            int pivot = arreglo[indMayor];
            int j = indMenor - 1;
            for (int i = indMenor; i < indMayor; i++)
            {
                if (arreglo[i] <= pivot)
                {
                    j++;
                    Intercambio(arreglo, j, i);
                }
            }
            Intercambio(arreglo, j + 1, indMayor);
            return j + 1;
        }
        static void QuickSort(int[] arreglo, int indMenor, int indMayor)
        {
            if (indMenor < indMayor)
            {
                int pivot = Partición(arreglo, indMenor, indMayor);
                QuickSort(arreglo, indMenor, pivot - 1);
                QuickSort(arreglo, pivot + 1, indMayor);
            }
        }
        static void Main(string[] args)
        {
            Random valorAleatorio = new Random();
            int cantidadArreglo = valorAleatorio.Next(100);
            int[] miArreglo = new int[cantidadArreglo];
            for (int i = 0; i < cantidadArreglo; i++)
            {
                miArreglo[i] = valorAleatorio.Next(200);
                Console.Write($"{i}:{miArreglo[i]}, ");
            }
            int valorArreglo = miArreglo[valorAleatorio.Next(cantidadArreglo)];
            Console.WriteLine($"\nValor sorteado: {valorArreglo}");
            int indice = BusquedaSecuencial(miArreglo, valorArreglo);
            if (indice != -1)
            {
                Console.WriteLine($"Valor {valorArreglo} encontrado en el indice {indice}.");
            }
            else
            {
                Console.WriteLine("Valor no encontrado en el arreglo.");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            QuickSort(miArreglo, 0, cantidadArreglo - 1);
            for (int i = 0; i < cantidadArreglo; i++)
            {
                Console.Write($"{i}:{miArreglo[i]}, ");
            }
            Console.WriteLine($"\nValor sorteado: {valorArreglo}");
            indice = BusquedaBinaria(miArreglo, valorArreglo, cantidadArreglo);
            if (indice != -1)
            {
                Console.WriteLine($"Valor {valorArreglo} encontrado en el indice {indice}.");
            }
            else
            {
                Console.WriteLine("Valor no encontrado en el arreglo.");
            }
        } 
    } 
    
}
