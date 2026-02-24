using CIS.Contacts;

namespace CIS.Interfaces {
    public interface ISearchEngine
    {
        LinkedList<Contact> Search(DATA_FIELD field, string value);
    }
}