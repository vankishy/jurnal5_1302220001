using static System.Runtime.InteropServices.JavaScript.JSType;

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T input)
    {
        storedData.Add(input);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi : {this.storedData[i]} yang disimpan pada waktu {this.inputDates[i]}");
        }
    }
}

﻿internal class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan.JumlahTigaAngka<float>(13, 02, 22);
        SimpleDataBase<int> ObjData = new SimpleDataBase<int>();
        ObjData.AddNewData(13);
        ObjData.AddNewData(02);
        ObjData.AddNewData(22);
        ObjData.PrintAllData();
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

