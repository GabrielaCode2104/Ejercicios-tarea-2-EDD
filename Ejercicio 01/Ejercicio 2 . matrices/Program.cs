// Ejercicio 2: Calcula la media, la mediana y la desviación estándar de los elementos de una matriz.

class EstadisticasMatriz
{
    static void Main()
    {
        int[,] matr = new int[3, 3] { { 11, 2, 31 }, { 40, 52, 6 }, { 73, 82, 19 } };

        var elemen = matr.Cast<int>().ToList();

        double media = elemen.Average();

        // Calculamos la mediana
        elemen.Sort();
        double mediana = elemen.Count % 2 == 0 ?
            (elemen[elemen.Count / 2 - 1] + elemen[elemen.Count / 2]) / 2.0 :
            elemen[elemen.Count / 2];

        // Calculamos la desviación estándar
        double sumDifCuad = elemen.Sum(x => Math.Pow(x - media, 2));
        double desvEstandar = Math.Sqrt(sumDifCuad / elemen.Count);

        // Imprimimos los resultados
        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Mediana: {mediana}");
        Console.WriteLine($"Desviación Estándar: {desvEstandar}");
    }
}