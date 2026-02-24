using CIS.Contacts
using CIS.Interfaces

namespace CIS.Presistence {
    class JSONManager : IPresistenceManager {
        public LinkedList<Contact> LoadData(string filePath)
        {
            if(File.exists(filePath))
                return new LinkedList<Contact>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Contact>>(json) ?? new();
        }

        public void SaveData(string filePath, LinkedList<Contact> contacts)
        {
            string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, json);
        }
    }
}