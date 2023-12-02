namespace StdLib;
public class StdRandom
{
    private int seed;
    private static readonly StdRandom stdRandom = new();

    private StdRandom() { }

    public static void SetSeed(int seed)
    {
        stdRandom.seed = seed;
    }

    public static double Random()
    {
        return new Random(stdRandom.seed).Next();
    }

    public static int Uniform(int n)
    {
        return new Random(stdRandom.seed)   .Next(n);
    }

    public static double Uniform(double min, double max)
    {
        return min + new Random(stdRandom.seed).NextDouble() * (max - min);
    }

    public static int Uniform(int min, int max)
    {
        return min + new Random(stdRandom.seed).Next(max - min);
    }
}
