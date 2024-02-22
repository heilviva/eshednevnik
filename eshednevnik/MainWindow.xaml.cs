using System;
using System.IO;
using Newtonsoft.Json;

public class Note
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
}

public class DataSerializer
{
    public static void Serialize<T>(T data, string filePath)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        File.WriteAllText(filePath, jsonData);
    }

    public static T Deserialize<T>(string filePath)
    {
        string jsonData = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<T>(jsonData);
    }
}
