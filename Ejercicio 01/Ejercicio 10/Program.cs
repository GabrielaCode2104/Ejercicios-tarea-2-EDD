// 10) Suma dos matrices de diferentes tamaños.
class Programa_10
{
    static void Main()
    {
        int[,] matriz01 = new int[2, 2] { { 4, 3 }, { 5, 7 } };
        int[,] matriz02 = new int[2, 2] { { 12, 6 }, { 14, 15 } }; 

        int[,] resultado = new int[2, 2]; 

        // Suma las matrices elemento a elemento
        for (int fila = 0; fila < 2; fila++)
        {
            for (int columna = 0; columna < 2; columna++)
            {
                resultado[fila, columna] = matriz01[fila, columna] + matriz02[fila, columna]; 
            }
        }

        Console.WriteLine("Suma de matrices:");
        for (int fila = 0; fila < 2; fila++)
        {
            for (int columna = 0; columna < 2; columna++)
            {
                Console.Write(resultado[fila, columna] + "\t");
            }
            Console.WriteLine();
        }
    }
}