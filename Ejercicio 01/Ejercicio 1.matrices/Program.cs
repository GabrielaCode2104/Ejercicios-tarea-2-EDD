// #1 Crea una matriz de números aleatorios de tamaño 100x100.
class GeneradorMatriz
{
    static void Main()
    {
        Random generadorAleatorio = new Random();
        int[,] matrizAleatoria = new int[100, 100];
        for (int fila = 0; fila < 100; fila++)
        {
            for (int columna = 0; columna < 100; columna++)
            {
                matrizAleatoria[fila, columna] = generadorAleatorio.Next(1, 101);

            }      
        }

        for (int fila = 0; fila < 100; fila++)
        {
            for (int columna = 0; columna < 100; columna++)
            {
                Console.Write(matrizAleatoria[fila, columna] + "\t");
            }
            Console.WriteLine();
        }
    }
}