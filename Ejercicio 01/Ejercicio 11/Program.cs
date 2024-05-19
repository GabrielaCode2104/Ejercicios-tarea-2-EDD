// 11) Multiplica una matriz por un número. 
class Programa_11
{
    static void Main()
    {
        int[,] matriz = new int[2, 2] { { 11, 10 }, { 23, 14 } };
        int numero = 5;
        MultiplicarMatrizPorNumero(matriz, numero);

        ImprimirMatriz(matriz);
    }
    static void MultiplicarMatrizPorNumero(int[,] matriz, int numero)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] *= numero;
            }
        }
    }
    static void ImprimirMatriz(int[,] matriz)
    {
        Console.WriteLine("Matriz multiplicada por un número:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}