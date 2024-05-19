// Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n. 
public static class Recursividad
{
    public static void ImprimirPiramide(int n, int fila = 1)
    {
        if (fila > n)
        {
            return;
        }

        for (int i = 1; i <= fila; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
        ImprimirPiramide(n, fila + 1);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int num = Convert.ToInt32(Console.ReadLine());
        ImprimirPiramide(num);
    }
}