using CIS.Contacts;
using CIS.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CIS.Presistence {
    class JSONManager : IPresistenceManager {
        public LinkedList<Contact> LoadData(string filePath)
        {
            if(!File.Exists(filePath))
                return new LinkedList<Contact>();

            string json = File.ReadAllText(filePath);
            List<Contact> contacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? new();
            return new LinkedList<Contact>(contacts);
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