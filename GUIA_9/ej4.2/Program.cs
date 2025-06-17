using System.Runtime.ExceptionServices;

namespace ej4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroLibreta, notaLibreta, contAlumnos=0, contNumero=0, contNota=0;
            string nombreAlumno;
            string[] alumnos = new string[100];
            int[] numeroLibretas = new int[100];
            int[] notasLibretas = new int[100];
            int ac = 0;
            Console.Write($"Ingrese el nombre del alumno {contAlumnos + 1}: ");
            nombreAlumno = Console.ReadLine();
            while(nombreAlumno != "salir")
            {
                alumnos[contAlumnos] = nombreAlumno;
                contAlumnos++;
                Console.Write($"Ingrese el nombre del alumno {contAlumnos + 1} (En caso de no continuar, ingrese 'salir'): ");
                nombreAlumno = Console.ReadLine();
            }
            Console.Write($"Ingrese el número de libreta del alumno {alumnos[contNumero]}: ");
            numeroLibreta = Convert.ToInt32(Console.ReadLine());
            while (numeroLibreta != -1 && contNumero < contAlumnos-1)
            {
                numeroLibretas[contNumero] = numeroLibreta;
                contNumero++;
                Console.Write($"Ingrese el número de libreta del alumno {alumnos[contNumero]} (-1 para salir): ");
                numeroLibreta = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write($"Ingrese la nota del alumno {alumnos[contNota]}: ");
            notaLibreta = Convert.ToInt32(Console.ReadLine());
            ac += notaLibreta;
            while (notaLibreta != -1 && contNota < contAlumnos - 1)
            {
                notasLibretas[contNota] = notaLibreta;
                contNota++;
                ac += notaLibreta;
                Console.Write($"Ingrese la nota del alumno {alumnos[contNota]} (-1 para salir): ");
                notaLibreta = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Listado de alumnos:");
            for (int i = 0; i < contAlumnos; i++)
            {
                Console.WriteLine($"Alumno: {alumnos[i]}, Número de libreta: {numeroLibretas[i]}, Nota: {notasLibretas[i]}");
            }
            double prom = 1.0 * (ac / (double)contAlumnos);
            Console.WriteLine($"El promedio de las notas es de {prom:f2}");
            int[] arregloDeIndicesMayoresAlPromedio = new int[contAlumnos];
            int contadorIndicesMayores = 0;
            for (int i = 0; i < contAlumnos; i++)
            {
                if (notasLibretas[i] >= prom)
                {
                    arregloDeIndicesMayoresAlPromedio[contadorIndicesMayores] = i;
                    contadorIndicesMayores++; 
                }
            }
            Console.WriteLine("Alumnos con nota mayor al promedio:");
            for (int x = 0; x < contadorIndicesMayores; x++)
            {
                int indice = arregloDeIndicesMayoresAlPromedio[x];
                Console.WriteLine($"Alumno: {alumnos[indice]}, Número de libreta: {numeroLibretas[indice]}, Nota: {notasLibretas[indice]}");
            }
        }
    }
}
