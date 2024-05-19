// Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 
class Programa_4
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número:");
        int num = Convert.ToInt32(Console.ReadLine());
        ImprimirPiramInv(num);
    }

    static void ImprimirPiramInv(int n, int fila = 0)
    {
        if (fila >= n)
        {
            return;
        }
        for (int esp = 0; esp < fila; esp++)
        {
            Console.Write(" ");
        }
        for (int i = n - fila; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        ImprimirPiramInv(n, fila + 1);
    }
}
