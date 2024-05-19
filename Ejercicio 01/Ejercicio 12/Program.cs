// 12) Calcula la media de los elementos de una matriz. 
class Programa_12
{
    static void Main()
    {
        int[,] matriz = new int[3, 3] { { 50, 20, 10 }, { 30, 35, 40 }, { 55, 60, 75 } };

        double media = CalcularMediaMatriz(matriz);
        Console.WriteLine("Media de los elementos de la matriz: " + media);
    }

    static double CalcularMediaMatriz(int[,] matriz)
    {
        int suma = 0;

        int elementos = matriz.GetLength(0) * matriz.GetLength(1);

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                suma += matriz[i, j];
            }
        }
        double media = (double)suma / elementos;
        return media;
    }
}


