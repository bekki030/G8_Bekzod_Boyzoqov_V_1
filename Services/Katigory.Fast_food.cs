using models;
using System.Text.Json;

namespace Modul_2.Services;

public partial class Katigory
{
    private List<Fast_food> fastfood = new List<Fast_food>();
    private static string path = Directory.GetCurrentDirectory();
    string fastfoodpath = path + "Fastfood.json";
    public void AddFastfood(string name)
    {
        int id = fastfood.Count > 0 ? fastfood.Max(f => f.Id) + 1 : 1;
        fastfood.Add(new Fast_food() { Id = id, Name = name });
        string serialized = JsonSerializer.Serialize(fastfood);
        using (StreamWriter writer = new StreamWriter(fastfoodpath))
        {
            writer.WriteLine(serialized);
        }
    }
    public void UpdateFastfood(int id, string name)
    {
        var food = fastfood.FirstOrDefault(k => k.Id == id);
        if (food != null)
        {
            food.Name = name;
            Console.WriteLine("Muvaffaqqiyatli o`zgardi");

        }
        else
        {
            Console.WriteLine("Fastfood not found");
        }

        string serialized = JsonSerializer.Serialize<List<Fast_food>>(fastfood);
        using (StreamWriter sw = new StreamWriter(fastfoodpath))
        {
            sw.WriteLine(serialized);
        }
    }
    public void DeleteFastfood(int id)
    {
        var food = fastfood.FirstOrDefault(x => x.Id == id);
        if (food != null)
        {
            fastfood.Remove(food);
            Console.WriteLine("Muvaffaqqiyatli o`chdi");
        }
        else
            Console.WriteLine("Fastfood not found");
        string serialized = JsonSerializer.Serialize<List<Fast_food>>(fastfood);
        using (StreamWriter sw = new StreamWriter(fastfoodpath))
        {
            sw.WriteLine(serialized);
        }
    }
    public void ListFastfood()
    {
        fastfood = JsonReadFastfood();
        foreach (var fastfood in fastfood)
        {
            Console.WriteLine($"Fastfood: {fastfood.Id}  , Name: {fastfood.Name}  , Narxi: {fastfood.Narxi}");
        }
    }
    public List<Fast_food> JsonReadFastfood()
    {
        using (StreamReader reader = new StreamReader(fastfoodpath))
        {
            string json = reader.ReadToEnd();
            fastfood = JsonSerializer.Deserialize<List<Fast_food>>(json);
        }
        return fastfood;
    }
}
