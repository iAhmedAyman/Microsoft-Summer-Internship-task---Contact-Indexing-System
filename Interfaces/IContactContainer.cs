using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IContactContainer
    {
        void Add(Contact contact);
        void Remove(DATA_FIELD field, string value);
        void Update(DATA_FIELD field, string oldValue, Contact newContact);
    }
}