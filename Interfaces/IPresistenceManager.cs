using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IPresistenceManager
    {
        bool LoadData(string filePath);
        bool SaveData(string filePath);
    }
}