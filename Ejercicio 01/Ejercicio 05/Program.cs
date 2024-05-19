// Ejercicio 5: Escribe una función recursiva que imprima la tabla de multiplicar del n. 
class Programa_5
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número: ");
        int num01 = Convert.ToInt32(Console.ReadLine());
        ImprimirTablaMultiplicar(num01);
    }
    static void ImprimirTablaMultiplicar(int n, int multiplicador = 1)
    {
        if (multiplicador > 12)
        {
            return;
        }
        Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
        ImprimirTablaMultiplicar(n, multiplicador + 1);
    }
}
