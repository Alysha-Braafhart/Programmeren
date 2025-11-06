namespace math;

class Program
{
    static void Main(string[] args)
    {
        double kleiner = 9;
        double groter = 19;

        double welkeIsKleiner = Math.Min(kleiner, groter);
        Console.WriteLine($"{welkeIsKleiner} is de kleinste van {kleiner} en {groter}.");

        groter = 14;
        double welkeIsGroter = Math.Max(kleiner, groter);
        Console.WriteLine($"{welkeIsGroter} is de grootse van {kleiner} en {groter}.");

        double clampResultaatVan16 = 16;
        double min = 20;
        double max = 30;
        double clampResultaat = Math.Clamp(min, max);
        Console.WriteLine($"{clampResultaat}");
    }
}
