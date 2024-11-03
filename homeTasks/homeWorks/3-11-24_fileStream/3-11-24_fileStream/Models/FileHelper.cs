using Newtonsoft.Json;

namespace _3_11_24_fileStream.Models;
    class FileHelper
    {
    public string Path { get; set; }
    public FileHelper(string path)
    {
        Path = path;    
    }

    //methodlarin daxilinde biraz komek almışam((

    public void Add(string name)
    {
        List<string> namesList;

        if (File.Exists(Path))
        {
            var existingJson = File.ReadAllText(Path);
            namesList = JsonConvert.DeserializeObject<List<string>>(existingJson) ?? new List<string>();
        }
        else
        {
            namesList = new List<string>();
        }

        if (!namesList.Contains(name))
        {
            namesList.Add(name);
        }

        var updatedJson = JsonConvert.SerializeObject(namesList);
        File.WriteAllText(Path, updatedJson);
    }
    public bool Exist(string name)
    {
        if (File.Exists(Path))
        {
            var existingJson = File.ReadAllText(Path);
            List<string> namesList = JsonConvert.DeserializeObject<List<string>>(existingJson);


            return namesList.Contains(name);
        }
        else
        {
            return false;
        }
    }
    public void Update(int index, string name)
    {
        if (File.Exists(Path))
        {
            var existingJson = File.ReadAllText(Path);
            List<string> namesList = JsonConvert.DeserializeObject<List<string>>(existingJson);

            if (index >= 0 && index < namesList.Count)
            {
                namesList[index] = name;

                var updatedJson = JsonConvert.SerializeObject(namesList);
                File.WriteAllText(Path, updatedJson);
            }
            else
            {
                Console.WriteLine("Duzgun index daxil olunmayib");
            }
        }
        else
        {
            Console.WriteLine("tapilmadi");
        }
    }

    public void Delete(int index)
    {
        if (File.Exists(Path))
        {
            var existingJson = File.ReadAllText(Path);
            List<string> namesList = JsonConvert.DeserializeObject<List<string>>(existingJson);

            if (index >= 0 && index < namesList.Count)
            {
                namesList.RemoveAt(index);

                var updatedJson = JsonConvert.SerializeObject(namesList);
                File.WriteAllText(Path, updatedJson);

                Console.WriteLine($"Index {index} silindi.");
            }
            else
            {
                Console.WriteLine("Duzgun index deyil.");
            }
        }
        else
        {
            Console.WriteLine("Tapilmadi");
        }
    }

}

