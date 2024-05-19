//#Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 
public static class Recursividad
{
    public static void ImprimirPares(int num)
    {
        if (num <= 100)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
            ImprimirPares(num + 1);
        }
    }

    public static void Main(string[] args)
    {
        ImprimirPares(1);
    }
}

