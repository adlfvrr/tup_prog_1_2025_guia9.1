namespace ej3._2
{
    internal class Program
    {
        static int BusquedaSecuencial(int[]arreglo, int valor)
        {
            int indice = -1;
            int cont = 0;
            while (indice < 0 && cont != arreglo.Length)
            {
                if (arreglo[cont] == valor)
                {
                    indice = cont;
                }
                cont++;
            }
            return indice;
        }
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
        static void OrdenamientoBurbujaConNombres(int[] arreglo, string[]arregloNombres,int cantidadLength)
        {
            for (int i = 0; i < cantidadLength; i++)
            {
                for (int j = i + 1; j < cantidadLength; j++)
                {
                    if (arreglo[i] > arreglo[j])
                    {
                        Intercambio(arreglo, i, j);
                        IntercambioNombres(arregloNombres, i, j);
                    }
                }
            }
        }
        static int BusquedaBinaria(int[] arreglo,int valor, int fin)
        {
            int pivot, inicio = 0, final = fin - 1, indice = -1;
            while(inicio <= final && indice < 0)
            {
                pivot = (inicio + final) / 2;
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
                        final = pivot - 1;
                    }
                }
            }
            return indice;
        }
        static void Main(string[] args)
        {
            Random valoresAleatorios = new Random();
            int[] arreglo = new int[100];
            string[] tercerVector = new string[100];
            int cantidad = valoresAleatorios.Next(100);
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = valoresAleatorios.Next(1, 100);
            }
            string[] vectorString = new string[8];
            vectorString = ["Noemí", "Noelía", "Andrés", "Emilio", "Norberto", "Estefanía", "Daniela", "Valeria"];
            for (int i = 0; i < cantidad; i++)
            {
                tercerVector[i] = vectorString[valoresAleatorios.Next(vectorString.Length)];
                Console.WriteLine($"{i}, {arreglo[i]} : {tercerVector[i]}");
            }
            int numeroABuscar = arreglo[valoresAleatorios.Next(cantidad)];
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Valor sorteado: {numeroABuscar}");
            int indice = BusquedaSecuencial(arreglo, numeroABuscar);
            if (indice != -1)
            {
            Console.WriteLine($"Busqueda secuencial:\n Valor se encuentra en el índice {indice}, con el nombre {tercerVector[indice]}");
            }
            else
            {
                Console.WriteLine("Valor no encontrado.");
            }
                Console.WriteLine("");
            OrdenamientoBurbujaConNombres(arreglo,tercerVector,cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{i}, {arreglo[i]} : {tercerVector[i]}");
            }
            Console.WriteLine($"");
            indice = BusquedaBinaria(arreglo, numeroABuscar, cantidad);
            Console.WriteLine($"Busqueda Binaria");
            if (indice != -1)
            {
                Console.WriteLine($"Valor se encuentra en el índice {indice}, con el nombre {tercerVector[indice]}");
            }
            else
            {
                Console.WriteLine("Valor no encontrado.");
            }
        }
    }
}
