//8)	Crea una matriz de matrices.
class Programa_8
{
    static void Main()
    {
        int[][,] matriz_Matrices = new int[2][,];


        matriz_Matrices[0] = new int[2, 2] { { 8, 7 }, { 6, 5 } };
        matriz_Matrices[1] = new int[3, 3] { { 1, 12, 21 }, { 3, 34, 20 }, { 71, 54, 51 } };

        for (int i = 0; i < matriz_Matrices.Length; i++)
        {
            Console.WriteLine($"Matriz {i + 1}:");
            for (int j = 0; j < matriz_Matrices[i].GetLength(0); j++)
            {
                for (int k = 0; k < matriz_Matrices[i].GetLength(1); k++)
                {
                    Console.Write(matriz_Matrices[i][j, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}