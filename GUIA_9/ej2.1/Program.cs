namespace ej2._1
{
    internal class Program
    {
        static void Intercambio(int[] arreglo, int i, int j)
        {
            int aux = arreglo[i];
            arreglo[i] = arreglo[j];
            arreglo[j] = aux;
        }
        static void Burbuja(int[] arreglo)
        {
            for (int j = 0; j < (arreglo.Length - 1); j++)
            {
                for (int k = j + 1; k < arreglo.Length; k++)
                {
                    if (arreglo[j] < arreglo[k])
                    {
                        Intercambio(arreglo, j, k);
                    }
                }
                if (arreglo[j] != 0)
                {
                    Console.Write($"{j}:{arreglo[j]}, ");
                }
            }
        }
        static int Particion(int[] arreglo, int iMenor, int iMayor)
        {
            int pivot = arreglo[iMayor];
            int j = iMenor - 1;
            for (int i = iMenor; i < iMayor; i++)
            {
                if (arreglo[i] <= pivot)
                {
                    j++;
                }
            }
            Intercambio(arreglo, j + 1, iMayor);
            return j + 1;
        }
        static void QuickSort(int[] arreglo, int iMenor, int iMayor)
        {
            if (iMenor < iMayor)
            {
                int pivot = Particion(arreglo, iMenor, iMayor);
                QuickSort(arreglo, iMenor, pivot - 1);
                QuickSort(arreglo, pivot + 1, iMayor);
            }
        }
        static int Busqueda(int[] arreglo, int valor)
        {
            int encontrado = -1;
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                if (arreglo[i] == valor)
                {
                    encontrado = i;
                }
            }
            return encontrado;
        }
        static void Main(string[] args)
        {
            int[] arreglo = new int[100];
            int[] arregloBurbuja = new int[20];
            int[] arregloQuickSort = new int[20];
            Random elementosVector = new Random();
            for (int i = 0; i < 20 - 1; i++)
            {
                arreglo[i] = elementosVector.Next(200);
                Console.Write($"{i}:{arreglo[i]}, ");
                arregloBurbuja[i] = arreglo[i];
            }

            Console.WriteLine("");
            Console.WriteLine("");
            //Ordenamiento Burbuja
            Burbuja(arregloBurbuja);
            for (int i = 0; i < arregloBurbuja.Length - 1; i++)
            {
                arregloQuickSort[i] = arregloBurbuja[i];
            }
            Console.WriteLine("");
            Console.WriteLine("");
            //Ordenamiento QuickSort
            QuickSort(arregloQuickSort, 0, 19);
            for (int i = 0; i < arregloQuickSort.Length - 1; i++)
            {
                if (arregloQuickSort[i] != 0)
                    Console.Write($"{i}:{arregloQuickSort[i]}, ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            //Búsqueda de un elemento
            int valorAleatorio = elementosVector.Next(1,200);
            int indiceAEncontrar = Busqueda(arregloQuickSort, valorAleatorio);
            if (indiceAEncontrar != -1)
            {
                Console.WriteLine($"El numero {valorAleatorio} se encuentra en el índice: {indiceAEncontrar} dentro de la lista ordenada por QuickSort.");
            }
            else
            {
                Console.WriteLine($"{valorAleatorio} no encontrado.");
            }
        }
    }
}
