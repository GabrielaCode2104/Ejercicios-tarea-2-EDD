// Ejercicio 5:  Escribe una función que encuentre la matriz de covarianza de dos matrices.
class Programa
{
    static double[,] EncontrarMatrizDeCovarianza(double[,] matrizA, double[,] matrizB)
    {
        int filas = matrizA.GetLength(0);
        int columnas = matrizA.GetLength(1);
        if (filas != matrizB.GetLength(0) || columnas != matrizB.GetLength(1))
        {
            throw new ArgumentException("Las matrices deben tener el mismo tamaño");
        }

        double[,] matrCovarianza1 = new double[columnas, columnas];

        // Calcular la media de cada columna de las matrices
        double[] mediaA = new double[columnas];
        double[] mediaB = new double[columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                mediaA[j] += matrizA[i, j];
                mediaB[j] += matrizB[i, j];
            }
        }
        for (int j = 0; j < columnas; j++)
        {
            mediaA[j] /= filas;
            mediaB[j] /= filas;
        }
        // Calculamos la matriz de covarianza
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                for (int k = 0; k < columnas; k++)
                {
                    matrCovarianza1[j, k] += (matrizA[i, j] - mediaA[j]) * (matrizB[i, k] - mediaB[k]);
                }
            }
        }
        for (int j = 0; j < columnas; j++)
        {
            for (int k = 0; k < columnas; k++)
            {
                matrCovarianza1[j, k] /= filas;
            }
        }

        return matrCovarianza1;
    }
    static void Main()
    {
        double[,] matrizA = new double[3, 2] { { 5.0, 2.0 }, { 3.0, 4.0 }, { 12.0, 13.0 } };
        double[,] matrizB = new double[3, 2] { { 7.0, 8.0 }, { 8.0, 10.0 }, { 11.0, 12.0 } };
        double[,] matrCovarianza = EncontrarMatrizDeCovarianza(matrizA, matrizB);
        Console.WriteLine("La matriz de covarianza es: ");
        for (int i = 0; i < matrCovarianza.GetLength(0); i++)
        {
            for (int j = 0; j < matrCovarianza.GetLength(1); j++)
            {
                Console.Write(matrCovarianza[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}