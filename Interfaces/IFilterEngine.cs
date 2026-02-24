using CIS.Contacts;

namespace CIS.Interfaces {
    public interface IFilterEngine
    {
        LinkedList<Contact> Filter(DATA_FIELD field, string value);
    }
}