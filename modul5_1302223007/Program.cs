internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan.JumlahTigaAngka<int>(13, 02, 22);
    }
}

class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic nilaiA = a;
        dynamic nilaiB = b;
        dynamic nilaiC = c;
        Console.WriteLine(nilaiA + nilaiB + nilaiC);
    }
}