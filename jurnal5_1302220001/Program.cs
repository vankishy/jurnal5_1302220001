internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan.JumlahTigaAngka<float>(13, 02, 22);
    }
}

class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T A, T B, T C)
    {
        dynamic temp;
        dynamic angka1 = A;
        dynamic angka2 = B;
        dynamic angka3 = C;
        temp = angka1 + angka2 + angka3;
        Console.WriteLine(temp);
    }
}


