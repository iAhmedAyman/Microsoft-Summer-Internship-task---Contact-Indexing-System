using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IContactService
    {
        void LoadData(string filePath);
        void SaveData(string filePath);
        void Add(Contact contact);
        void Remove(DATA_FIELD field, string value);
        void Update(DATA_FIELD field, string oldValue, Contact newContact);
        LinkedList<LinkedListNode<Contact>> ViewContact(DATA_FIELD field, string value);
        LinkedList<Contact> GetAllContacts();
        LinkedList<LinkedListNode<Contact>> Search(DATA_FIELD field, string value);
        LinkedList<Contact> Filter(DATA_FIELD field, string value);
    }
}