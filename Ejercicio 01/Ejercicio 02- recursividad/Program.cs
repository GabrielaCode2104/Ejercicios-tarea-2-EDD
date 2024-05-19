// #2
public static class Recursividad
{
    public static int ImprSuma(int n)
    {
        if (n > 0)
        {
            int suma = ImprSuma(n - 1) + n;
            Console.WriteLine(n);
            return suma;
        }
        else
        {
            return 0;
        }
    }
    public static void Main(string[] args)
    {
        int suma = ImprSuma(10);
        Console.WriteLine("La suma es: " + suma);
    }
}


