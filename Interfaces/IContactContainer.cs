using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IContactContainer
    {
        bool Add(Contact contact);
        bool Remove(DATA_FIELD field, string value);
        bool Update(DATA_FIELD field, string oldValue, Contact newContact);
    }
}