using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<int> ObjData = new SimpleDataBase<int>(1302220001);
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase(List<T> storedData, List<DateTime> inputDates)
    {
        this.storedData = [];
        this.inputDates = inputDates;
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
            Console.WriteLine($"Data {i + 1} berisi : {this.storedData} yang disimpan pada waktu {this.inputDates}");
        }
    }
}
