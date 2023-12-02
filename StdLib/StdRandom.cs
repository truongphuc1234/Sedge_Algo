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
}
