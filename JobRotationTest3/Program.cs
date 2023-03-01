using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        double SP = 67836.43;
        double RJ = 36678.66;
        double MG = 29229.88;
        double ES = 27165.48;
        double OUTROS = 19849.53;
        double percentual;

        percentual = SP + RJ + MG + ES + OUTROS;

        double perct1 = (SP / percentual) * 100;
        double perct2 = (RJ / percentual) * 100;
        double perct3 = (MG / percentual) * 100;
        double perct4 = (ES / percentual) * 100;
        double perct5 = (OUTROS / percentual) * 100;

        Console.Write("SP - " + perct1.ToString("F2", CultureInfo.InvariantCulture) + "%, ");
        Console.Write("RJ - " + perct2.ToString("F2", CultureInfo.InvariantCulture) + "%, ");
        Console.Write("MG - " + perct3.ToString("F2", CultureInfo.InvariantCulture) + "%, ");
        Console.Write("ES - " + perct4.ToString("F2", CultureInfo.InvariantCulture) + "%, ");
        Console.Write("OUTROS - " + perct5.ToString("F2", CultureInfo.InvariantCulture) + "%, ");
    }
}