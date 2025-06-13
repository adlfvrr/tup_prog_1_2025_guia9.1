namespace ej1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GENERACION DEL VECTOR
            int[] numeros = new int[30];
            int[] vectorReducido = new int[1];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
                Console.Write($"{numeros[i]}, ");
            }
            Random elementoAleatorio = new Random();
            Console.WriteLine("");
            Console.WriteLine("");
            // ELEMENTOS ALEATORIOS Y SUSTITUCION DEL ULTIMO ELEMENTO DEL VECTOR NUMEROS
            for (int j = 0; j < 10; j++)
            {
                int aleatorio = elementoAleatorio.Next(numeros.Length);
                Console.Write($"{aleatorio}, ");
                numeros[(numeros.Length) - 2] = aleatorio;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            //REDUCCIÓN DEL NUMERO DE ELEMENTOS A 1
            for (int k = 0; k < numeros.Length - 2; k++)
            {
                numeros[k] = 0;
                Console.Write($"{numeros[k]}, ");
            }
            Console.WriteLine("");
            //REDUCCION DEL NUMERO DE ELEMENTOS A 1 (CASO DE NUEVO VECTOR)
            vectorReducido[0] = numeros[numeros.Length - 2];
            //
            Console.WriteLine("");
            //ULTIMO ELEMENTO DEL VECTOR
            for (int l = 0; l < numeros.Length - 1; l++)
            {
                Console.Write($"{numeros[l]}, ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"{vectorReducido[0]}");
        }
    }
}
