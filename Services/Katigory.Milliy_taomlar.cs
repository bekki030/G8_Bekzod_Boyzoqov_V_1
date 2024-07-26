using models;
using System.Text.Json;

namespace Modul_2.Services;

public partial class Katigory
{
    private List<Milliy_taomlar> taomlar = new List<Milliy_taomlar>();
    string taompath = path + "Taomlar.json";
    public void AddTaomlar(string name)
    {
        int id = taomlar.Count > 0 ? taomlar.Max(f => f.Id) + 1 : 1;
        taomlar.Add(new Milliy_taomlar() { Id = id, Name = name });
        string serialized = JsonSerializer.Serialize(taomlar);
        using (StreamWriter writer = new StreamWriter(taompath))
        {
            writer.WriteLine(serialized);
        }
    }
    public void UpdateTaomlar(int id, string name)
    {
        var taom = taomlar.FirstOrDefault(k => k.Id == id);
        if (taom != null)
        {
            taom.Name = name;
            Console.WriteLine("Muvaffaqqiyatli o`zgardi");

        }
        else
        {
            Console.WriteLine("Taomlar not found");
        }

        string serialized = JsonSerializer.Serialize<List<Milliy_taomlar>>(taomlar);
        using (StreamWriter sw = new StreamWriter(taompath))
        {
            sw.WriteLine(serialized);
        }
    }
    public void DeleteTaomlar(int id)
    {
        var taom = taomlar.FirstOrDefault(x => x.Id == id);
        if (taom != null)
        {
            taomlar.Remove(taom);
            Console.WriteLine("Muvaffaqqiyatli o`chdi");
        }
        else
            Console.WriteLine("Taomlar not found");
        string serialized = JsonSerializer.Serialize<List<Milliy_taomlar>>(taomlar);
        using (StreamWriter sw = new StreamWriter(taompath))
        {
            sw.WriteLine(serialized);
        }
    }
    public void ListTaomlar()
    {
        taomlar = JsonReadTaomlar();
        foreach (var taom in taomlar)
        {
            Console.WriteLine($"Taom: {taom.Id}  , Name: {taom.Name}  , Narxi: {taom.Narxi}");
        }
    }
    public List<Milliy_taomlar> JsonReadTaomlar()
    {
        using (StreamReader reader = new StreamReader(taompath))
        {
            string json = reader.ReadToEnd();
            taomlar = JsonSerializer.Deserialize<List<Milliy_taomlar>>(json);
        }
        return taomlar;
    }
}
