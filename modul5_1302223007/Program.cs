internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDatabase<String> db = new SimpleDatabase<String>();
        db.AddNewData("13");
        db.AddNewData("02");
        db.AddNewData("22");
        db.PrintAllData();
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