using models;
using System.Text.Json;

namespace Modul_2.Services;

public partial class Katigory
{
    private List<Ichimliklar> ichimlik = new List<Ichimliklar>();
    string ichimlikpath = path + "Ichimlik.json";
    public void AddIchimlik(string name)
    {
        int id = ichimlik.Count > 0 ? ichimlik.Max(f => f.Id) + 1 : 1;
        ichimlik.Add(new Ichimliklar() { Id = id, Name = name });
        string serialized = JsonSerializer.Serialize(ichimlik);
        using (StreamWriter writer = new StreamWriter(ichimlikpath))
        {
            writer.WriteLine(serialized);
        }
    }
    public void UpdateIchimlik(int id, string name)
    {
        var drink = ichimlik.FirstOrDefault(k => k.Id == id);
        if (drink != null)
        {
            drink.Name = name;
            Console.WriteLine("Muvaffaqqiyatli o`zgardi");

        }
        else
        {
            Console.WriteLine("Ichimlik not found");
        }

        string serialized = JsonSerializer.Serialize<List<Ichimliklar>>(ichimlik);
        using (StreamWriter sw = new StreamWriter(ichimlikpath))
        {
            sw.WriteLine(serialized);
        }
    }
    public void DeleteIchimlik(int id)
    {
        var drink = ichimlik.FirstOrDefault(x => x.Id == id);
        if (drink != null)
        {
            ichimlik.Remove(drink);
            Console.WriteLine("Muvaffaqqiyatli o`chdi");
        }
        else
            Console.WriteLine("Ichimlik not found");
        string serialized = JsonSerializer.Serialize<List<Ichimliklar >>(ichimlik);
        using (StreamWriter sw = new StreamWriter(ichimlikpath))
        {
            sw.WriteLine(serialized);
        }
    }
    public void ListIchimlik()
    {
        ichimlik = JsonReadIchimlik();
        foreach (var drink in ichimlik)
        {
            Console.WriteLine($"Ichimlik: {drink.Id}  , Name: {drink.Name}  ");
        }
    }
    public List<Ichimliklar> JsonReadIchimlik()
    {
        using (StreamReader reader = new StreamReader(ichimlikpath))
        {
            string json = reader.ReadToEnd();
            ichimlik = JsonSerializer.Deserialize<List<Ichimliklar>>(json);
        }
        return ichimlik;
    }
}
