// #2 Escribe una función recursiva que imprima la suma de los números del 1 al n. 

class Programa_2
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La suma desde 1 hasta " + num1 + " es: " + SumaRecursiva(num1));
    }
    static int SumaRecursiva(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n + SumaRecursiva(n - 1);
    }
}

