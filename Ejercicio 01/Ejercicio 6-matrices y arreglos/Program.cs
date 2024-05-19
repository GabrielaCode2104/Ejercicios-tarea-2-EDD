// 6. Crea una matriz de números reales. 
class Programa_6
{
    static void Main()
    {
        double[,] matr = new double[3, 3];
        matr[0, 0] = 0.2;
        matr[0, 1] = 1.2;
        matr[0, 2] = 3.4;
        matr[1, 0] = 4.4;
        matr[1, 1] = 5.9;
        matr[1, 2] = 1.6;
        matr[2, 0] = 7.4;
        matr[2, 1] = 6.8;
        matr[2, 2] = 9.2;
        ImprimirMatriz(matr);
    }
    static void ImprimirMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
