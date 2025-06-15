using System.Numerics;

namespace ej2._2
{
    internal class Program
    {
        static void Intercambio(int[] arreglo, int indPrimero, int indSegundo)
        {
            int aux = arreglo[indPrimero];
            arreglo[indPrimero] = arreglo[indSegundo];
            arreglo[indSegundo] = aux;
        }
        static void IntercambioNombres(string[] arregloNombres, int indPrimero, int indSegundo)
        {
            string aux = arregloNombres[indPrimero];
            arregloNombres[indPrimero] = arregloNombres[indSegundo];
            arregloNombres[indSegundo] = aux;
        }
        static void BurbujaConNombres(int[] arreglo, string[] arregloNombres, int cantidadElementos)
        {
            for (int i = 0; i < cantidadElementos; i++)
            {
                for (int j = i + 1; j < cantidadElementos; j++)
                {
                    if (arreglo[i] > arreglo[j])
                    {
                        Intercambio(arreglo, i, j);
                        IntercambioNombres(arregloNombres, i, j);
                    }
                }
            }
        }
        static int Particion(int[] arreglo, string[] arregloNombres, int indMenor, int indMayor)
        {
            int pivot = arreglo[indMayor];
            int j = indMenor - 1;
            for (int i = indMenor; i < indMayor; i++)
            {
                if (arreglo[i] >= pivot)
                {
                    j++;
                    Intercambio(arreglo, j, i);
                    IntercambioNombres(arregloNombres, j, i);
                }
            }
            Intercambio(arreglo, j + 1, indMayor);
            IntercambioNombres(arregloNombres, j + 1, indMayor);
            return j + 1;
        }
        static void QuickSort(int[] arreglo, string[] arregloNombres, int indMenor, int indMayor)
        {
            if (indMenor < indMayor)
            {
                Particion(arreglo, arregloNombres, indMenor, indMayor);
                QuickSort(arreglo, arregloNombres, indMenor, indMayor - 1);
                QuickSort(arreglo, arregloNombres, indMayor + 1, indMayor);
            }
        }
        static void Main(string[] args)
        {
            Random valoresAleatorios = new Random();
            int[] arreglo = new int[100];
            string[] tercerVector = new string[100];
            int cantidad = valoresAleatorios.Next(100);
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = valoresAleatorios.Next(1,100);
            }
            string[] vectorString = new string[8];
            vectorString = ["Noemí", "Noelía", "Andrés", "Emilio", "Norberto", "Estefanía", "Daniela", "Valeria"];
            for (int i = 0; i < cantidad; i++)
            {
                int índice = valoresAleatorios.Next(vectorString.Length);
                tercerVector[i] = vectorString[índice];
                Console.WriteLine($"{i}, \"{tercerVector[i]}\" : {arreglo[i]}");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            BurbujaConNombres(arreglo, tercerVector, cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{i}, \"{tercerVector[i]}\" : {arreglo[i]}");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            QuickSort(arreglo, tercerVector, 0, cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{i}, \"{tercerVector[i]}\" : {arreglo[i]}");
            }
        }
    }
}
