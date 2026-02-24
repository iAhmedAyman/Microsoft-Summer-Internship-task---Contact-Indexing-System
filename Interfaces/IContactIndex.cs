using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IContactIndex
    {
        bool Add(Contact contact);
        bool Remove(DATA_FIELD DATA_FIELD, string value);
        bool Update(DATA_FIELD DATA_FIELD, string oldValue, Contact newContact);
    }
}