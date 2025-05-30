using System.Diagnostics.CodeAnalysis;

namespace ej1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaraciones
            string nombre;
            int nlib;
            double nota;
            string[] alumnos = new string[100];
            int[]libreta = new int[100];
            double[] notasAl = new double[100];
            int cont = 0;
            int contnlib = 0;
            int contnot = 0;
            string almayornota = "";
            string almenornota = "";
            int nlibmayor=0;
            int nlibmenor = 0;
            double notamayor = 0;
            double notamenor = 0;
            double prom = 0;
            double suma = 0;
            #endregion
            #region Ingresos Alumnos
            Console.WriteLine($"Ingrese nombre del alumno {cont+1}: ");
            nombre = Console.ReadLine();
            while (nombre != "salir")
            {
                alumnos[cont] = nombre;
                cont++;
                Console.Write($"Ingrese nombre del alumno {cont+1} (En caso de no continuar, ingrese 'salir'): ");
                nombre = Console.ReadLine();
            }
            #endregion
            #region Ingresos números de libreta
            Console.Write($"Ingrese número de libreta del alumno {alumnos[contnlib]}: ");
            nlib = Convert.ToInt32(Console.ReadLine());
            while (nlib != -1)
            {
                libreta[contnlib] = nlib;
                contnlib++;
                Console.Write($"Ingrese número de libreta del alumno {alumnos[contnlib]} (-1 para salir): ");
                nlib = Convert.ToInt32(Console.ReadLine());
            }
            #endregion
            #region Ingresos notas
            Console.Write($"Ingrese nota del alumno {alumnos[contnot]}: ");
            nota = Convert.ToDouble(Console.ReadLine());
            while (nota != -1)
            {
                notasAl[contnot] = nota;
                contnot++;
                Console.Write($"Ingrese nota del alumno {alumnos[contnot] } (-1 para salir): ");
                nota = Convert.ToDouble(Console.ReadLine());
            }
            #endregion
            #region Recorrido
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine($"Nombre de alumno: {alumnos[i]}");
                Console.WriteLine($"Número de libreta: {libreta[i]}");
                Console.WriteLine($"Nota: {notasAl[i]}");
                if (notamayor == 0 && notamenor == 0)
                {
                    almayornota = alumnos[i];
                    almenornota = alumnos[i];
                    nlibmayor = libreta[i];
                    nlibmenor = libreta[i];
                    notamayor = notasAl[i];
                    notamenor = notasAl[i];
                }
                else
                {
                    if (notasAl[i] > notamayor)
                    {
                    almayornota = alumnos[i];
                    nlibmayor = libreta[i];
                    notamayor = notasAl[i];
                    }
                    else if (notasAl[i] < notamenor)
                    {
                        almenornota = alumnos[i];
                        nlibmenor = libreta[i];
                        notamenor = notasAl[i];
                    }
                }
            }

            #endregion
            #region Promedio
            for (int contprom = 0; contprom < cont; contprom++)
            {
                suma += notasAl[contprom]; 
            }
            prom = 1.0 * (suma / (double)cont);
            Console.WriteLine($"El promedio de las notas es {prom:f2}\nEl alumno con mayor nota es {almayornota}, número de libreta {nlibmayor} con una nota de {notamayor}\nEl alumno con menor nota es {almenornota}, número de libreta {nlibmenor} con uan nota de {notamenor} ");
            #endregion
        }
    }
}
