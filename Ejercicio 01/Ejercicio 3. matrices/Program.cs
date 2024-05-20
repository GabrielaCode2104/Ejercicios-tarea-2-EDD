// Ejercicio 3: Escribe una función que encuentre el elemento máximo de una matriz. 
class MaximoElementoMatriz
{
    static void Main()
    {
        int[,] matriz = new int[3, 3] { { 11, 2, 33 }, { 4, 52, 62 }, { 72, 84, 9 } };
        int max = FindMax(matriz);
        Console.WriteLine($"El elemento máximo de la matriz es: {max}");
    }
    static int FindMax(int[,] matriz)
    {
        int max1 = int.MinValue;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > max1)
                {
                    max1 = matriz[i, j];
                }
            }
        }
        return max1;
    }
}