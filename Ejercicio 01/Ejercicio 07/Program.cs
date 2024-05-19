//7) Crea una matriz de números complejos.
using System.Numerics;
class Programa_7
{
    static void Main()
    {
        Complex[,] matriz = new Complex[3, 3];

        matriz[0, 0] = new Complex(4, 3);
        matriz[0, 1] = new Complex(2, 5);
        matriz[0, 2] = new Complex(7, 3);
        matriz[1, 0] = new Complex(9, 6);
        matriz[1, 1] = new Complex(11, 15);
        matriz[1, 2] = new Complex(13, 12);
        matriz[2, 0] = new Complex(17, 14);
        matriz[2, 1] = new Complex(18, 16);
        matriz[2, 2] = new Complex(17, 20);

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}