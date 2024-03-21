internal class Program
{
    private static void Main(string[] args)
    {
        // Generic Method
        Penjumlahan.JumlahTigaAngka<int>(13, 02, 22);
        
        // Generic Class
        SimpleDatabase<String> db = new SimpleDatabase<String>();
        db.AddNewData("13");
        db.AddNewData("02");
        db.AddNewData("22");
        db.PrintAllData();
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

class SimpleDatabase<T>
{
    private List<T> storeData;
    private List<DateTime> inputDates;

    public SimpleDatabase()
    {
        this.storeData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storeData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int i = 0; i < storeData.Count; i++)
        {
            Console.WriteLine(
                "Data " + (i+1) + " berisi: " + storeData[i] + ", " +
                "yang disimpan pada waktu UTC: " + inputDates[i]
            );
        }
    }
}