using System.Text.Json;

namespace CW_17._11_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Albom albom = new Albom();
            albom.Input();
            albom.Print();

            string filePath = "albom.json";

            var option = new JsonSerializerOptions { WriteIndented = true };
            string jsonStr = JsonSerializer.Serialize(albom, option);
            File.WriteAllText(filePath, jsonStr);

            Console.WriteLine("File was serialize");

            if (File.Exists(filePath))
            {
                string readJson = File.ReadAllText(filePath);
                Albom? restoredAlbom = JsonSerializer.Deserialize<Albom>(readJson);
                if (restoredAlbom != null)
                {
                    Console.WriteLine("User is deserialized");

                }
            }
        }
    }
}
