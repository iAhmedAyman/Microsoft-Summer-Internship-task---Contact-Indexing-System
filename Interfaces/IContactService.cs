using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IContactService
    {
        bool LoadData(string filePath);
        bool SaveData(string filePath);
        bool Add(Contact contact);
        bool Remove(DATA_FIELD field, string value);
        bool Update(DATA_FIELD field, string oldValue, Contact newContact);
        Contact ViewContact(DATA_FIELD field, string value);
        LinkedList<Contact> GetAllContacts();
        Contact Search(DATA_FIELD field, string value);
        LinkedList<Contact> Filter(DATA_FIELD field, string value);
    }
}