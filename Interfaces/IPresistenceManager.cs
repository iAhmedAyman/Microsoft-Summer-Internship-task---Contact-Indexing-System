using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IPresistenceManager
    {
        LinkedList<Contact> LoadData(string filePath);
        void SaveData(string filePath);
    }
}