using models;
using System.Text.Json;

namespace Modul_2.Services;

public partial class Katigory
{
    private List<Salatlar> salatlar = new List<Salatlar>();
    string salatpath = path + "Salatlar.json";
    public void AddSalatlar(string name)
    {
        int id = salatlar.Count > 0 ? salatlar.Max(f => f.Id) + 1 : 1;
        salatlar.Add(new Salatlar() { Id = id, Name = name });
        string serialized = JsonSerializer.Serialize(salatlar);
        using (StreamWriter writer = new StreamWriter(salatpath))
        {
            writer.WriteLine(serialized);
        }
    }
    public void UpdateSalatlar(int id, string name)
    {
        var salat = salatlar.FirstOrDefault(k => k.Id == id);
        if (salat != null)
        {
            salat.Name = name;
            Console.WriteLine("Muvaffaqqiyatli o`zgardi");

        }
        else
        {
            Console.WriteLine("Salatlar not found");
        }

        string serialized = JsonSerializer.Serialize<List<Salatlar>>(salatlar);
        using (StreamWriter sw = new StreamWriter(salatpath))
        {
            sw.WriteLine(serialized);
        }
    }
    public void DeleteSalatlar(int id)
    {
        var salat = salatlar.FirstOrDefault(x => x.Id == id);
        if (salat != null)
        {
            salatlar.Remove(salat);
            Console.WriteLine("Muvaffaqqiyatli o`chdi");
        }
        else
            Console.WriteLine("Salatalr not found");
        string serialized = JsonSerializer.Serialize<List<Salatlar>>(salatlar);
        using (StreamWriter sw = new StreamWriter(salatpath))
        {
            sw.WriteLine(serialized);
        }
    }
    public void ListSalatlar()
    {
        salatlar = JsonReadSalatlar();
        foreach (var salat in salatlar)
        {
            Console.WriteLine($"Salatlar: {salat.Id}  , Name: {salat.Name}  , Narxi: {salat.Narxi}");
        }
    }
    public List<Salatlar> JsonReadSalatlar()
    {
        using (StreamReader reader = new StreamReader(salatpath))
        {
            string json = reader.ReadToEnd();
            salatlar = JsonSerializer.Deserialize<List<Salatlar>>(json);
        }
        return salatlar;
    }
}
