namespace prácticas_metodos_ord
{
    internal class Program
    {
        static void Intercambio(int[]arreglo, int indPrimero, int indSegundo)
        {
            int aux = arreglo[indPrimero];
            arreglo[indPrimero] = arreglo[indSegundo];
            arreglo[indSegundo] = aux;
        }
        static void Burbuja(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (arreglo[i] > arreglo[j])
                    {
                        Intercambio(arreglo, i, j);
                    }
                }
                Console.Write($"{i}:{arreglo[i]}, ");
            }
        }
        static int Particion(int[] arreglo,int indMenor,int indMayor)
        {
            int pivot = arreglo[indMayor];
            int j = indMenor - 1;
            for(int i = indMenor; i < indMayor; i++)
            {
                if (arreglo[i] >= pivot)
                {
                    j++;
                }
            }
            Intercambio(arreglo, j + 1, indMayor);
            return j + 1;
        }
        static void QuickSort(int[] arreglo, int indMenor, int indMayor)
        {
            if (indMenor < indMayor)
            {
                int pivot = Particion(arreglo, indMenor, indMayor);
                QuickSort(arreglo, indMenor, pivot - 1);
                QuickSort(arreglo, pivot + 1, indMayor);
            }
        }
        static void Main(string[] args)
        {
            //METODOS ORDENAMIENTO
            int[] arreglo = new int[5];
            arreglo = [3, 8, 5, 7, 2];
            //Metodo Burbuja
            Burbuja(arreglo);
            Console.WriteLine("");
            Console.WriteLine("");
            //Metodo QuickSort
            QuickSort(arreglo, 0, 4);
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"{i}:{arreglo[i]}, ");
            }

        }
    }
}
